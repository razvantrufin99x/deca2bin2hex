using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deca2bin2hex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void deca2bin(int d, ref List<int> binar)
        {
            int deca = d;
            int rest = 0;
            while (deca > 1)
            {
                rest = deca % 2;
                deca = deca / 2;
                binar.Add(rest);
                Text = rest.ToString();
                Text += deca.ToString();
            }
            binar.Add(deca);

        }
        public void printList(ref List<Int32> lista, ref TextBox t)
        {
            t.Text = "";
            for(int i = lista.Count-1; i >=0 ; i--)
            {
                t.Text += lista[i].ToString() + " ";
            }
        }
        public List<Int32> binarnumar = new List<Int32>();
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            binarnumar.Clear();
            Int32 dd = Convert.ToInt32(this.textBox1.Text);
            deca2bin(dd, ref binarnumar);
            printList(ref binarnumar, ref this.textBox2);
        }
    }
}
