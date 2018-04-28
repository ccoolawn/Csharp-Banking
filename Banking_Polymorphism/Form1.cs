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

namespace Banking_Polymorphism
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //minimum 10 accounts
            int[] accNumbers = GenerateAccNumber(10);
        }
        private int[] GenerateAccNumber(int size)
        {
            int[] accNumbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                accNumbers[i] = rand.Next(00000, 1000000);
            }
            return accNumbers;
        }

        private void DisplayAccts(Account acct)
        {
            string[] items =
            {
                acct.AccNumber.ToString(),
                acct.GetType().ToString()
            };
            ListViewItem lvi = new ListViewItem(items);
            //add the row to the listview
            listView1.Items.Add(lvi);
            //cause the listview1 to scroll to the bottom
            //by making the last item visible
            listView1.EnsureVisible(listView1.Items.Count - 1);
        }

        private void DisplayTransactions(Transaction acctTrans)
        {
            string[] items =
            {
                acctTrans.Type.ToString(),
                acctTrans.Date.ToString(),
                acctTrans.Description,
                acctTrans.Amount.ToString()
            };
            ListViewItem lvi = new ListViewItem(items);
            //add the row to the listview
            listView2.Items.Add(lvi);
            //cause the listview1 to scroll to the bottom
            //by making the last item visible
            listView1.EnsureVisible(listView1.Items.Count - 1);
        }

        private AcctType RandomAccount(){
 
            return (AcctType)(rand.Next(0, Enum.GetNames(typeof(AcctType)).Length));
 
        }

        private void PopulateAccounts(int[] accNumbers, List<Transaction> accList)
        {
            string[] banks =
            {"Republic Savings","AMCORE Bank Carpentersville","Broadway Bank",
             "First Choice Bank","South Carolina Federal Savings Bank",
             "Valley Bank Richland Center","Trinity National Bank",
             "Glasgow Savings Bank","Gunnison Valley Bank","Little Falls Bank"};

            AcctType at = RandomAccount();
            for (int i = 0; i < accNumbers.Length; i++)
            {
                Account a[i] = new Account(accNumbers[i],rand.Next(10, 3000),banks[i]);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
