using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbproject2
{
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void tCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tCustomer.Focus();
            }
        }

        private void tCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tValue.Focus();
            }
        }

        private void tValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tVat.Focus();
            }
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            tCode.Clear();
            tCustomer.Clear();
            tValue.Clear();
            tVat.Clear();
            tTotal.Clear();
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            dateTimePicker1.Text = " ";
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            int n = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[n].Cells[0].Value = tCode.Text;
            dataGridView1.Rows[n].Cells[1].Value = tCustomer.Text;
            //dataGridView1.Rows[n].Cells[2].Value = comboBox1.Text;
            dataGridView2.Rows.Add();
            dataGridView2.Rows[n].Cells[0].Value = tCode.Text;
            dataGridView2.Rows[n].Cells[1].Value = dateTimePicker1.Text;
            dataGridView2.Rows[n].Cells[2].Value = tCustomer.Text;
            dataGridView2.Rows[n].Cells[3].Value = comboBox2.Text;
            dataGridView2.Rows[n].Cells[4].Value = tValue.Text;
            dataGridView2.Rows[n].Cells[5].Value = tVat.Text;
            dataGridView2.Rows[n].Cells[6].Value = tTotal.Text;
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {

        }

        private void bDelete_Click(object sender, EventArgs e)
        {

        }

        private void bClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการที่จะปิดหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
