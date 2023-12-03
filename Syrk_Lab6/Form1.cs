using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syrk_Lab6
{
    public partial class Form1 : Form
    {
        System.Random randomNumber = new System.Random();

        object lockObject = new object();
        object lockObject2 = new object();
        object lockObject3 = new object();

        int queue;
        int clientsServed = 0;
        bool[] cashiers = new bool[3];

        List<Label> cashierTexts = new List<Label>();

        int time=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cashierTexts.Add(Cashier1Text);
            cashierTexts.Add(Cashier2Text);
            cashierTexts.Add(Cashier3Text);
            
            timer1.Interval = randomNumber.Next(3, 5) * 1000;
            timer1.Start();
            timer2.Start();

            Thread cashierThread1 = new Thread(()=>ServeCustomer(0));
            Thread cashierThread2 = new Thread(() => ServeCustomer(1));
            Thread cashierThread3 = new Thread(() => ServeCustomer(2));

            cashierThread1.Start();
            cashierThread2.Start();
            cashierThread3.Start();
        }

        void UpdateCashierText(int number)
        {
            queueText.Text = "" + queue;

            if (!cashiers[number])
                cashierTexts[number].Text = "" + 1;
            else
                cashierTexts[number].Text = "" + 0;

            clientsServedText.Text = "" + clientsServed;
        }

        void ServeCustomer(int cashierNumber)
        {
            while (true)
            {
                lock (lockObject)
                {
                    if (!cashiers[cashierNumber] && queue > 0)
                    {                       
                        queue--;

                        if (cashierTexts[cashierNumber].InvokeRequired)
                            cashierTexts[cashierNumber].Invoke(new Action<int>(UpdateCashierText), cashierNumber);
                        else
                            UpdateCashierText(cashierNumber);

                        cashiers[cashierNumber] = true;
                        //if (cashierTexts[cashierNumber].InvokeRequired)
                        //{

                        //}
                        //else
                        //{
                        //    queueText.Text = "" + queue;
                        //    cashierTexts[cashierNumber].Text = "" + 1;
                        //}

                    }
                }

                if (cashiers[cashierNumber])
                {                   
                    int serviceTime = randomNumber.Next(1,100);

                    Thread.Sleep(serviceTime*1000);

                    cashiers[cashierNumber] = false;

                    clientsServed++;

                    lock (lockObject2)
                    {
                        if (cashierTexts[cashierNumber].InvokeRequired)
                            cashierTexts[cashierNumber].Invoke(new Action<int>(UpdateCashierText), cashierNumber);
                        else
                            UpdateCashierText(cashierNumber);
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lock (lockObject3)
            {
                queue++;
                queueText.Text = "" + queue;

                timer1.Interval = randomNumber.Next(3, 5) * 1000;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            time++;

            timeText.Text = $"Магазин работает {time} мин.";
        }
    }
}
