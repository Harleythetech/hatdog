namespace Jovellano__Vincent_Harley_R.___COPRO4
{
    public partial class Form1 : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private bool btnp3 = false;
        private bool btnp4 = false;
        private bool btnp5 = false;
        private bool btnp6 = false;
        private bool btnp7 = false;
        private bool btnp8 = false;
        private bool btnp9 = false;
        private bool btnp10 = false;
        private static string icr = "907995";
        private static string ica = "974974";
        private static string icp = "981922";
        private static string icm = "966300";
        private static string ics = "939336";
        private static string icc = "925017";
        private static string icsp = "999668";
        private static string icsh = "954873";
        private static string icw = "911738";
        private static string iccoke = "949630";
        private static string icpal = "950245";
        private static int pr = 20;
        private static int pa = 50;
        private static int pp = 45;
        private static int pm = 35;
        private static int ps = 75;
        private static int pc = 35;
        private static int psp = 65;
        private static int psh = 69;
        private static int pw = 7;
        private static int pcoke = 16;
        private static int ppal = 10;
        private int total = 0;
        public static bool lab9;
        private static string lname;
        private static string fname;
        public static bool swt;
        public static string Food;
        public static string QT;
        public static string TP;
        public static string price;
        public static string cashier;
        public static string kwasong;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lname = Form3.LName;
            fname = Form3.FName;
            swt = Form3.lab;
            this.ControlBox = false;
            this.Text = String.Empty;
            this.FormBorderStyle = FormBorderStyle.None;
            label8.Hide();
            try
            {
                if (swt == false)
                {
                    label9.Hide();
                }
                else if (swt == true)
                {
                    cashier = lname + ", " + fname;
                    label9.Text = lname + ", " + fname;
                    label9.Show();
                    button2.Hide();
                    button15.Hide();
                    label8.Show();
                }
            }
            catch
            {
                MessageBox.Show("Unexpected issue has occured please restart the app", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnp3 = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            try { 
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(dataGridView1);

            // if Else loop for Buttons
            if (btnp3)
            {
                newRow.Cells[0].Value = button3.Text;
                newRow.Cells[1].Value = textBox1.Text;
                newRow.Cells[2].Value = icr;
                newRow.Cells[3].Value = pr;
                btnp3 = false;
            }
            else if (btnp4)
            {
                newRow.Cells[0].Value = button4.Text;
                newRow.Cells[1].Value = textBox1.Text;
                newRow.Cells[2].Value = ica;
                newRow.Cells[3].Value = pa;
                btnp4 = false;
            }
            else if (btnp5)
            {
                newRow.Cells[0].Value = button5.Text;
                newRow.Cells[1].Value = textBox1.Text;
                newRow.Cells[2].Value = icp;
                newRow.Cells[3].Value = pp;
                btnp5 = false;
            }
            else if (btnp6)
            {
                newRow.Cells[0].Value = button6.Text;
                newRow.Cells[1].Value = textBox1.Text;
                newRow.Cells[2].Value = icm;
                newRow.Cells[3].Value = pm;
                btnp6 = false;
            }
            else if (btnp7)
            {
                newRow.Cells[0].Value = button7.Text;
                newRow.Cells[1].Value = textBox1.Text;
                newRow.Cells[2].Value = ics;
                newRow.Cells[3].Value = ps;
                btnp7 = false;
            }
            else if (btnp8)
            {
                newRow.Cells[0].Value = button8.Text;
                newRow.Cells[1].Value = textBox1.Text;
                newRow.Cells[2].Value = icc;
                newRow.Cells[3].Value = pc;
                btnp8 = false;
            }
            else if (btnp9)
            {
                newRow.Cells[0].Value = button9.Text;
                newRow.Cells[1].Value = textBox1.Text;
                newRow.Cells[2].Value = icsp;
                newRow.Cells[3].Value = psp;
                btnp9 = false;
            }
            else if (btnp10)
            {
                newRow.Cells[0].Value = button10.Text;
                newRow.Cells[1].Value = textBox1.Text;
                newRow.Cells[2].Value = icsh;
                newRow.Cells[3].Value = psh;
                btnp10 = false;
            }

            //Radio Button Based Orders
            if (checkBox1.Checked)
            {
                newRow.Cells[0].Value = checkBox1.Text;
                newRow.Cells[1].Value = textBox1.Text;
                newRow.Cells[2].Value = icw;
                newRow.Cells[3].Value = pw;
            }
            else if (checkBox2.Checked)
            {
                newRow.Cells[0].Value = checkBox2.Text;
                newRow.Cells[1].Value = textBox1.Text;
                newRow.Cells[2].Value = iccoke;
                newRow.Cells[3].Value = pcoke;
            }
            else if (checkBox3.Checked)
            {
                newRow.Cells[0].Value = checkBox3.Text;
                newRow.Cells[1].Value = textBox1.Text;
                newRow.Cells[2].Value = icpal;
                newRow.Cells[3].Value = ppal;
            }
            //Data set
            dataGridView1.Rows.Add(newRow);

            // Quantity * Item Price Equation
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[dataGridView1.Columns[4].Index].Value = (Convert.ToDouble(row.Cells[dataGridView1.Columns[1].Index].Value) * Convert.ToDouble(row.Cells[dataGridView1.Columns[3].Index].Value));

            }
            //Total Price Equation
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {

                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
            }
            label6.Text = sum.ToString() + " PHP";
            price = label6.Text;
            //quantity compu
            int kwan = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {

                kwan += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
            }
            kwasong = kwan.ToString();
        } catch
            {
                MessageBox.Show("Unexpected issue has occured please restart the app", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(index);
                int sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {

                    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                }
                label6.Text = sum.ToString() + " PHP";
                price = label6.Text;
                //Quantity (for reciept)
                int kwan = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {

                    kwan += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                }
                kwasong = kwan.ToString();
            }
            catch
            {
                MessageBox.Show("Cannot delete selected row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow newRow = dataGridView1.CurrentRow;
                // if Else loop for Buttons
                if (btnp3)
                {
                    newRow.Cells[0].Value = button3.Text;
                    newRow.Cells[1].Value = textBox1.Text;
                    newRow.Cells[2].Value = icr;
                    newRow.Cells[3].Value = pr;
                    btnp3 = false;
                }
                else if (btnp4)
                {
                    newRow.Cells[0].Value = button4.Text;
                    newRow.Cells[1].Value = textBox1.Text;
                    newRow.Cells[2].Value = ica;
                    newRow.Cells[3].Value = pa;
                    btnp4 = false;
                }
                else if (btnp5)
                {
                    newRow.Cells[0].Value = button5.Text;
                    newRow.Cells[1].Value = textBox1.Text;
                    newRow.Cells[2].Value = icp;
                    newRow.Cells[3].Value = pp;
                    btnp5 = false;
                }
                else if (btnp6)
                {
                    newRow.Cells[0].Value = button6.Text;
                    newRow.Cells[1].Value = textBox1.Text;
                    newRow.Cells[2].Value = icm;
                    newRow.Cells[3].Value = pm;
                    btnp6 = false;
                }
                else if (btnp7)
                {
                    newRow.Cells[0].Value = button7.Text;
                    newRow.Cells[1].Value = textBox1.Text;
                    newRow.Cells[2].Value = ics;
                    newRow.Cells[3].Value = ps;
                    btnp7 = false;
                }
                else if (btnp8)
                {
                    newRow.Cells[0].Value = button8.Text;
                    newRow.Cells[1].Value = textBox1.Text;
                    newRow.Cells[2].Value = icc;
                    newRow.Cells[3].Value = pc;
                    btnp8 = false;
                }
                else if (btnp9)
                {
                    newRow.Cells[0].Value = button9.Text;
                    newRow.Cells[1].Value = textBox1.Text;
                    newRow.Cells[2].Value = icsp;
                    newRow.Cells[3].Value = psp;
                    btnp9 = false;
                }
                else if (btnp10)
                {
                    newRow.Cells[0].Value = button10.Text;
                    newRow.Cells[1].Value = textBox1.Text;
                    newRow.Cells[2].Value = icsh;
                    newRow.Cells[3].Value = psh;
                    btnp10 = false;
                }

                //Radio Button Based Orders
                if (checkBox1.Checked)
                {
                    newRow.Cells[0].Value = checkBox1.Text;
                    newRow.Cells[1].Value = textBox1.Text;
                    newRow.Cells[2].Value = icw;
                    newRow.Cells[3].Value = pw;
                }
                else if (checkBox2.Checked)
                {
                    newRow.Cells[0].Value = checkBox2.Text;
                    newRow.Cells[1].Value = textBox1.Text;
                    newRow.Cells[2].Value = iccoke;
                    newRow.Cells[3].Value = pcoke;
                }
                else if (checkBox3.Checked)
                {
                    newRow.Cells[0].Value = checkBox3.Text;
                    newRow.Cells[1].Value = textBox1.Text;
                    newRow.Cells[2].Value = icpal;
                    newRow.Cells[3].Value = ppal;
                }

                // Quantity * Item Price Equation
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells[dataGridView1.Columns[4].Index].Value = (Convert.ToDouble(row.Cells[dataGridView1.Columns[1].Index].Value) * Convert.ToDouble(row.Cells[dataGridView1.Columns[3].Index].Value));

                }
                //Total Price Equation
                int sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {

                    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                }
                label6.Text = sum.ToString() + " PHP";
                price = label6.Text;
                //Quantity (for reciept)
                int kwan = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {

                    kwan += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                }
                kwasong = kwan.ToString();
            }catch
            {
                MessageBox.Show("Unexpected issue has occured please restart the app", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int ind = e.RowIndex;
                DataGridViewRow selrow = this.dataGridView1.Rows[ind];
                int sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {

                    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                }
                label6.Text = sum.ToString() + " PHP";
                price = label6.Text;
                //Quantity (for reciept)
                int kwan = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {

                    kwan += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                }
                kwasong = kwan.ToString();
            }
            catch
            {
                MessageBox.Show("Cannot delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnp4 = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnp5 = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btnp6 = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            btnp7 = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            btnp8 = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            btnp9 = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            btnp10 = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                new Form5().Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Unexpected issue has occured please restart the app", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                new Form3().Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Unexpected issue has occured please restart the app", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}