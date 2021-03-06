﻿/* Ana Carolina de Souza Mendes
 * Cornell Coulon
 * 
 * May 01, 2018
 * 
 * Inheritance Lab Assignment
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankLib;
using MetroFramework;

namespace Banking_Polymorphism
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        //**************************GLOBAL***********************************
        Random rand = new Random();
        List<Account> acctList = new List<Account>();

        //**************************FORM***********************************
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //minimum 10 accounts
            int[] acctNumbers = GenerateAccNumber(10);
            //populates acctList
            PopulateAccounts(acctNumbers, acctList);
            //populate comboboxes
            PopulateComboboxes(acctList);
            //block other combobox
            cboToAcct.Enabled = false;
            //set lblcurrBalance to empty string
            lblcurrBalance.Text = String.Empty;
        }

        //**************************METHODS***********************************
        private int[] GenerateAccNumber(int size)
        {
            int[] acctNumbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                acctNumbers[i] = rand.Next(00000, 1000000);
            }
            return acctNumbers;
        }

        private AcctType RandomAccount() => (AcctType)rand.Next(0, Enum.GetNames(typeof(AcctType)).Length);

        private void PopulateAccounts(int[] acctNumbers, List<Account> a)
        {
            string[] banks =
            {"Republic Savings","AMCORE Bank Carpentersville","Broadway Bank",
             "First Choice Bank","South Carolina Federal Savings Bank",
             "Valley Bank Richland Center","Trinity National Bank",
             "Glasgow Savings Bank","Gunnison Valley Bank","Little Falls Bank"};

            AcctType at = RandomAccount();
            for (int i = 0; i < acctNumbers.Length; i++)
            {
                if (RandomAccount() == AcctType.checking)
                {
                    a.Add(new Checking(acctNumbers[i], rand.Next(10, 3000), banks[i]));
                }
                else
                {
                    a.Add(new Savings(acctNumbers[i], rand.Next(10, 3000), banks[i]));
                }
            }
            PopulateTransactions(a);
        }
        private void PopulateTransactions(List<Account> a)
        {
            for (int i = 0; i < a.Count; i++)
            {
                //deposits and withdraws
                for (int j = 0; j < 3; j++)
                {
                    a[i].Deposit(rand.Next(40, 1500));
                    a[i].Withdraw(rand.Next(40, 1500));
                }
                //transfers
                for (int k = 0; k < 2; k++)
                {
                    int index = rand.Next(0, a.Count);
                    if (a[index].AcctNumber != a[i].AcctNumber)
                    {
                        a[i].TransferTo(a[index], rand.Next(40, 1500));
                    }
                    else
                        k--;
                }
            }
        }

        private void PopulateComboboxes(List<Account> acctList)
        {
            //populate Type combobox
            cboTransType.DataSource = Enum.GetValues(typeof(TransType));

            foreach (Account obj in acctList)
            {
                cboFromAcct.Items.Add(obj.AcctNumber);
            }
            cboFromAcct.Sorted = true;
        }
        private void DisplayAccts(List<Account> acctList)
        {
            listView1.Items.Clear();

            ListViewItem lvi = new ListViewItem();
            foreach (Account acct in acctList)
            {
                string[] items = { acct.AcctNumber.ToString(), acct.GetType().Name.ToString(), acct.CurrentBalance.ToString("c")};
                lvi = new ListViewItem(items);
                //add the row to the listview
                listView1.Items.Add(lvi);
            }           
        }

        private void DisplayTransactions(Transaction acctTrans)
        {
            string[] items =
            {
                acctTrans.Type.ToString(),
                acctTrans.Date.ToString(),
                acctTrans.Description,
                acctTrans.Amount.ToString("c")
            };
            ListViewItem lvi = new ListViewItem(items);
            //add the row to the listview
            listView2.Items.Add(lvi);
        }

        //**************************EVENTS***********************************
        private void btnDisplayAccts_Click(object sender, EventArgs e)
        {
            DisplayAccts(acctList);            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView2.Items.Clear();

            if (listView1.SelectedItems.Count > 0)
            {
                int idx = listView1.FocusedItem.Index;
                Account acct = acctList[idx];
                Transaction[] transactions = acct.TransactionList;
                foreach(Transaction ts in acct.TransactionList)
                {
                    DisplayTransactions(ts);
                }

                DisplayCurrBalance(acct);
            }            
        }

        private void DisplayCurrBalance(Account acct)
        {
            lblcurrBalance.Text = acct.CurrentBalance.ToString("C");
        }

        private void cboFromAcct_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboToAcct.Enabled = true;
            cboToAcct.Items.Clear();

            foreach (Account obj in acctList)
            {
                if (Convert.ToInt32(cboFromAcct.SelectedItem) != obj.AcctNumber)
                    cboToAcct.Items.Add(obj.AcctNumber);
            }
            cboToAcct.Sorted = true;
        }
        private void btnSubmitTrans_Click(object sender, EventArgs e)
        {
            //get values from comboboxes and txtboxes
            TransType tt = (TransType)Enum.Parse(typeof(TransType), cboTransType.SelectedItem.ToString());
            int fromAcct = Convert.ToInt32(cboFromAcct.SelectedItem);
            int toAcct = Convert.ToInt32(cboToAcct.SelectedItem);
            decimal amount;
            if(!cboFromAcct.Items.Contains(fromAcct))
                MetroFramework.MetroMessageBox.Show(this, "Enter a valid FROM account!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
            {
                if(tt == TransType.transferOut)
                {
                    if (!cboToAcct.Items.Contains(toAcct))
                        MetroFramework.MetroMessageBox.Show(this, "Enter a valid TO account!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }                

                if (!decimal.TryParse(txtTransAmt.Text, out amount))
                    MetroFramework.MetroMessageBox.Show(this, "Enter a valid amount!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                {
                    //get Accounts
                    int indexFrom = 0;
                    int indexTo = 0;
                    for (int i = 0; i < acctList.Count; i++)
                    {
                        if (acctList[i].AcctNumber == fromAcct)
                            indexFrom = i;
                        if (acctList[i].AcctNumber == toAcct)
                            indexTo = i;
                    }

                    switch (tt)
                    {
                        case (TransType.deposit):
                            //deposit money
                            acctList[indexFrom].Deposit(amount);
                            break;
                        case (TransType.withdrawal):
                            acctList[indexFrom].Withdraw(amount);
                            break;
                        case (TransType.transferIn):
                            MetroMessageBox.Show(this, "Transation not available for user. \n Please contact your manager.");
                            break;
                        case (TransType.transferOut):
                            //transfer money
                            acctList[indexFrom].TransferTo(acctList[indexTo], amount);
                            break;
                        default:
                            break;
                    }

                    listView2.Items.Clear();
                    Account acct = acctList[indexFrom];
                    Transaction[] transactions = acctList[indexFrom].TransactionList;
                    foreach (Transaction ts in transactions)
                    {
                        DisplayTransactions(ts);
                    }

                    DisplayAccts(acctList);
                    DisplayCurrBalance(acct);
                }
            }                   
        }        
    }
}
