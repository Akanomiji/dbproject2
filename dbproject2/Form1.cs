namespace dbproject2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { textName.Focus(); }

        }

        private void textName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { comboBox1.Focus(); }

        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { textPrice.Focus(); }

        }

        private void textPrice_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter) { textAmount.Focus(); }

        }

        private void textAmount_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {
                double Tprice = int.Parse(textPrice.Text) * int.Parse(textAmount.Text);
                textTotal.Text = Tprice.ToString("#,###.00");
                textTotal.Focus();
            }

        }
        string cTax = "";
        private void Vat()
        {
            if (radioButton1.Checked == true)
            {
                cTax = radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                cTax = radioButton2.Text;
            }

        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            Vat();
            dataGridView1.Rows.Add();
            int n = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[n].Cells[0].Value = textCode.Text;
            dataGridView1.Rows[n].Cells[1].Value = textName.Text;
            dataGridView1.Rows[n].Cells[2].Value = comboBox1.Text;
            dataGridView1.Rows[n].Cells[3].Value = textPrice.Text;
            dataGridView1.Rows[n].Cells[4].Value = textAmount.Text;
            dataGridView1.Rows[n].Cells[5].Value = textTotal.Text;
            dataGridView1.Rows[n].Cells[6].Value = cTax;
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            textCode.Clear();
            textName.Clear();
            comboBox1.Text = "";
            textPrice.Clear();
            textTotal.Clear();
            textAmount.Clear();
            cTax = "";
            textCode.Focus();
        }

        private void bShow_Click(object sender, EventArgs e)
        {
            Vat();
            MessageBox.Show(label1.Text + ": " + textCode.Text + "\n" + label2.Text + ": " + textName.Text + "\n" +
                label3.Text + ": " + comboBox1.Text + "\n" + label4.Text + ": " + textPrice.Text + "\n" + label5.Text + ": " +
                textAmount.Text + "\n" + label6.Text + ": " + textTotal.Text + "\n" + groupBox1.Text + ": " + cTax + "");

        }

        private void bClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการที่จะปิดหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void textAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}