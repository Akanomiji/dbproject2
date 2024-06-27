namespace dbproject2
{
    partial class Invoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tCode = new TextBox();
            tCustomer = new TextBox();
            tValue = new TextBox();
            tVat = new TextBox();
            tTotal = new TextBox();
            label7 = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            Ccode = new DataGridViewTextBoxColumn();
            Cname = new DataGridViewTextBoxColumn();
            Cdept = new DataGridViewTextBoxColumn();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            comboBox2 = new ComboBox();
            bNew = new Button();
            bAdd = new Button();
            bUpdate = new Button();
            bDelete = new Button();
            bClose = new Button();
            dataGridView2 = new DataGridView();
            Cno = new DataGridViewTextBoxColumn();
            Cdate = new DataGridViewTextBoxColumn();
            Ccustomer = new DataGridViewTextBoxColumn();
            Cemployee = new DataGridViewTextBoxColumn();
            Cvalue = new DataGridViewTextBoxColumn();
            Cvat = new DataGridViewTextBoxColumn();
            Ctotal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(70, 45);
            label1.Name = "label1";
            label1.Size = new Size(42, 21);
            label1.TabIndex = 0;
            label1.Text = "เลขที่";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(70, 88);
            label2.Name = "label2";
            label2.Size = new Size(44, 21);
            label2.TabIndex = 1;
            label2.Text = "ลูกค้า";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(26, 133);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 2;
            label3.Text = "พนักงานขาย";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(35, 184);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 3;
            label4.Text = "มูลค่าสินค้า";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(60, 231);
            label5.Name = "label5";
            label5.Size = new Size(54, 21);
            label5.TabIndex = 4;
            label5.Text = "Vat7%";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(38, 276);
            label6.Name = "label6";
            label6.Size = new Size(76, 21);
            label6.TabIndex = 5;
            label6.Text = "รวมเป็นเงิน";
            // 
            // tCode
            // 
            tCode.Location = new Point(135, 47);
            tCode.Name = "tCode";
            tCode.Size = new Size(100, 23);
            tCode.TabIndex = 6;
            tCode.KeyDown += tCode_KeyDown;
            // 
            // tCustomer
            // 
            tCustomer.Location = new Point(135, 90);
            tCustomer.Name = "tCustomer";
            tCustomer.Size = new Size(100, 23);
            tCustomer.TabIndex = 7;
            tCustomer.KeyDown += tCustomer_KeyDown;
            // 
            // tValue
            // 
            tValue.Location = new Point(135, 186);
            tValue.Name = "tValue";
            tValue.Size = new Size(100, 23);
            tValue.TabIndex = 9;
            tValue.KeyDown += tValue_KeyDown;
            // 
            // tVat
            // 
            tVat.Location = new Point(135, 233);
            tVat.Name = "tVat";
            tVat.Size = new Size(100, 23);
            tVat.TabIndex = 10;
            // 
            // tTotal
            // 
            tTotal.Location = new Point(135, 278);
            tTotal.Name = "tTotal";
            tTotal.Size = new Size(100, 23);
            tTotal.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(261, 45);
            label7.Name = "label7";
            label7.Size = new Size(36, 21);
            label7.TabIndex = 12;
            label7.Text = "วันที่";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(261, 90);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(303, 47);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(128, 23);
            dateTimePicker1.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Ccode, Cname, Cdept });
            dataGridView1.Location = new Point(469, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(344, 252);
            dataGridView1.TabIndex = 15;
            // 
            // Ccode
            // 
            Ccode.HeaderText = "รหัส";
            Ccode.Name = "Ccode";
            // 
            // Cname
            // 
            Cname.HeaderText = "ชื่อ";
            Cname.Name = "Cname";
            // 
            // Cdept
            // 
            Cdept.HeaderText = "ยอดหนี้";
            Cdept.Name = "Cdept";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(261, 184);
            label8.Name = "label8";
            label8.Size = new Size(35, 21);
            label8.TabIndex = 16;
            label8.Text = "บาท";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(261, 231);
            label9.Name = "label9";
            label9.Size = new Size(35, 21);
            label9.TabIndex = 17;
            label9.Text = "บาท";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(261, 276);
            label10.Name = "label10";
            label10.Size = new Size(35, 21);
            label10.TabIndex = 18;
            label10.Text = "บาท";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(135, 135);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 19;
            // 
            // bNew
            // 
            bNew.Location = new Point(135, 325);
            bNew.Name = "bNew";
            bNew.Size = new Size(69, 31);
            bNew.TabIndex = 20;
            bNew.Text = "New";
            bNew.UseVisualStyleBackColor = true;
            bNew.Click += bNew_Click;
            // 
            // bAdd
            // 
            bAdd.Location = new Point(235, 325);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(78, 31);
            bAdd.TabIndex = 21;
            bAdd.Text = "Add";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click;
            // 
            // bUpdate
            // 
            bUpdate.Location = new Point(337, 325);
            bUpdate.Name = "bUpdate";
            bUpdate.Size = new Size(76, 31);
            bUpdate.TabIndex = 22;
            bUpdate.Text = "Update";
            bUpdate.UseVisualStyleBackColor = true;
            bUpdate.Click += bUpdate_Click;
            // 
            // bDelete
            // 
            bDelete.Location = new Point(450, 325);
            bDelete.Name = "bDelete";
            bDelete.Size = new Size(72, 31);
            bDelete.TabIndex = 23;
            bDelete.Text = "Delete";
            bDelete.UseVisualStyleBackColor = true;
            bDelete.Click += bDelete_Click;
            // 
            // bClose
            // 
            bClose.Location = new Point(558, 325);
            bClose.Name = "bClose";
            bClose.Size = new Size(78, 31);
            bClose.TabIndex = 24;
            bClose.Text = "Close";
            bClose.UseVisualStyleBackColor = true;
            bClose.Click += bClose_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Cno, Cdate, Ccustomer, Cemployee, Cvalue, Cvat, Ctotal });
            dataGridView2.Location = new Point(70, 389);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(743, 150);
            dataGridView2.TabIndex = 25;
            // 
            // Cno
            // 
            Cno.HeaderText = "เลขที่";
            Cno.Name = "Cno";
            // 
            // Cdate
            // 
            Cdate.HeaderText = "วันที่";
            Cdate.Name = "Cdate";
            // 
            // Ccustomer
            // 
            Ccustomer.HeaderText = "ลูกค้า";
            Ccustomer.Name = "Ccustomer";
            // 
            // Cemployee
            // 
            Cemployee.HeaderText = "พนักงาน";
            Cemployee.Name = "Cemployee";
            // 
            // Cvalue
            // 
            Cvalue.HeaderText = "มูลค่า";
            Cvalue.Name = "Cvalue";
            // 
            // Cvat
            // 
            Cvat.HeaderText = "Vat";
            Cvat.Name = "Cvat";
            // 
            // Ctotal
            // 
            Ctotal.HeaderText = "รวมเงิน";
            Ctotal.Name = "Ctotal";
            // 
            // Invoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 579);
            Controls.Add(dataGridView2);
            Controls.Add(bClose);
            Controls.Add(bDelete);
            Controls.Add(bUpdate);
            Controls.Add(bAdd);
            Controls.Add(bNew);
            Controls.Add(comboBox2);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(tTotal);
            Controls.Add(tVat);
            Controls.Add(tValue);
            Controls.Add(tCustomer);
            Controls.Add(tCode);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Invoice";
            Text = "Invoice";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tCode;
        private TextBox tCustomer;
        private TextBox tValue;
        private TextBox tVat;
        private TextBox tTotal;
        private Label label7;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Ccode;
        private DataGridViewTextBoxColumn Cname;
        private DataGridViewTextBoxColumn Cdept;
        private Label label8;
        private Label label9;
        private Label label10;
        private ComboBox comboBox2;
        private Button bNew;
        private Button bAdd;
        private Button bUpdate;
        private Button bDelete;
        private Button bClose;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Cno;
        private DataGridViewTextBoxColumn Cdate;
        private DataGridViewTextBoxColumn Ccustomer;
        private DataGridViewTextBoxColumn Cemployee;
        private DataGridViewTextBoxColumn Cvalue;
        private DataGridViewTextBoxColumn Cvat;
        private DataGridViewTextBoxColumn Ctotal;
    }
}