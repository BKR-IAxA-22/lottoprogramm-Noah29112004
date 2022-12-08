using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottoprogramm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] zahlen = new int[6];
            Random r =new Random();


            for(int i = 0; i < zahlen.Length; i++)
            {
                int check=r.Next(1,49);
                if (zahlen.Contains(check))
                {
                    i--;
                }
                else 
                {
                    zahlen[i] = check;
                }  
            }
            textBox1.Text = zahlen[0].ToString();
            textBox2.Text = zahlen[1].ToString();
            textBox3.Text = zahlen[2].ToString();
            textBox4.Text = zahlen[3].ToString();
            textBox5.Text = zahlen[4].ToString();
            textBox6.Text = zahlen[5].ToString();   
           


        }
    }
}
