using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jovellano__Vincent_Harley_R.___COPRO4
{
    public partial class Form3 : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private static string tb1;
        private static string tb2;
        private static string mail;
        private static string pass;
        public static string LName;
        public static string FName;
        public static bool lab;
        protected override void WndProc(ref Message message)
        {
            try
            {
                base.WndProc(ref message);

                if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                    message.Result = (IntPtr)HTCAPTION;
            }
            catch
            {
                MessageBox.Show("Unexpected issue has occured please restart the app", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lab = Form1.lab9;
            mail = Form2.email;
            pass = Form2.password;
            this.ControlBox = false;
            this.Text = String.Empty;
            this.FormBorderStyle = FormBorderStyle.None;
            label4.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                tb1 = textBox1.Text;
                tb2 = textBox2.Text;
                if (tb1 == "admin" && tb2 == "admin" || tb1 == mail && tb2 == pass)
                {
                    LName = Form2.LN;
                    FName = Form2.FN;
                    lab = true;
                    new Form1().Show();
                    this.Hide();
                }
                else
                {
                    label4.Show();
                }
            }
            catch
            {
                MessageBox.Show("Unexpected issue has occured please restart the app", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            new Form2().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tb1 = textBox1.Text;
                tb2 = textBox2.Text;
                if (tb1 == "admin" || tb1 == "" && tb2 == "admin" || tb2 == "")
                {
                    DialogResult confirm = MessageBox.Show("Closing this form will discard any data that is written, Do you want to Close this form?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Unexpected issue has occured please restart the app", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


//v1.3.23 made by Jovellano,Vincent Harley R.