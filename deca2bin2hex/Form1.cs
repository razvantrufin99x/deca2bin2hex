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
		public void deca2hex(int d, ref List<int> hexa)
        {
            int deca = d;
            int rest = 0;
            while (deca > 1)
            {
                rest = deca % 16;
                deca = deca / 16;
                hexa.Add(rest);
                Text = rest.ToString();
                Text += deca.ToString();
            }
            hexa.Add(deca);

        }
		public void deca2anybase(int d, ref List<int> anybase, int basenumar)
        {
            int deca = d;
            int rest = 0;
            while (deca > 1)
            {
                rest = deca % basenumar;
                deca = deca / basenumar;
                anybase.Add(rest);
                Text = rest.ToString();
                Text += deca.ToString();
            }
            anybase.Add(deca);

        }
        public void printList(ref List<Int32> lista, ref TextBox t)
        {
            t.Text = "";
            for(int i = lista.Count-1; i >=0 ; i--)
            {
                t.Text += lista[i].ToString() + " ";
            }
        }
        public void printListHexa(ref List<Int32> lista, ref TextBox t)
        {
            t.Text = "";
            string s = "";
            for (int i = lista.Count - 1; i >= 0; i--)
            {
                if (lista[i] == 10) { s = "A"; }
                else if (lista[i] == 11) { s = "B"; }
                else if (lista[i] == 12) { s = "C"; }
                else if (lista[i] == 13) { s = "D"; }
                else if (lista[i] == 14) { s = "E"; }
                else if (lista[i] == 15) { s = "F"; }
                else { s = lista[i].ToString(); }
                    t.Text += s + " ";
            }
        }
        public List<Int32> binarnumar = new List<Int32>();
		public List<Int32> hexanumar = new List<Int32>();
		public List<char> hexanumarchar = new List<char>();

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

        private void button2_Click(object sender, EventArgs e)
        {
            hexanumar.Clear();
            Int32 dd = Convert.ToInt32(this.textBox1.Text);
            deca2hex(dd, ref hexanumar);
            //printList(ref hexanumar, ref this.textBox2);
            printListHexa(ref hexanumar, ref this.textBox2);
        }
    }
}
