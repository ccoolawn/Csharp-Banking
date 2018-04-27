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
        private void PopulateAccounts(int[] accNumbers, List<Account> accList)
        {

        }
    }
}
