using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jovellano__Vincent_Harley_R.___COPRO4
{
    public partial class Form2 : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private static string tb1;
        private static string tb2;
        private static string tb3;
        private static string tb4;
        private static string tb6;
        public static string LN;
        public static string FN;
        public static string MI;
        public static string add;
        public static string email;
        public static string password;
        public static string gender;
        public static string num;
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
        public Form2()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tb1 = textBox1.Text;
                tb2 = textBox2.Text;
                tb3 = textBox3.Text;
                tb4 = textBox4.Text;
                tb6 = textBox6.Text;

                if (tb1 == "" && tb2 == "" || tb3 == "" || tb4 == "" || tb6 == "")
                {
                    Application.Exit();
                }
                else
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

        private void Form2_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Text = String.Empty;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                LN = textBox1.Text;
                FN = textBox2.Text;
                MI = textBox3.Text;
                add = textBox4.Text;
                password = textBox5.Text;
                email = textBox7.Text;
                num = textBox6.Text;
                string label = " ";
                if (radioButton1.Checked)
                {
                    label = label + radioButton1.Text;
                }
                else if (radioButton2.Checked)
                {
                    label = label + radioButton2.Text;
                }
                gender = label;
                new Form3().Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Unexpected issue has occured please restart the app", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
