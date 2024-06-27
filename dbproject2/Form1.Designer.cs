namespace dbproject2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textCode = new TextBox();
            textName = new TextBox();
            textPrice = new TextBox();
            textAmount = new TextBox();
            textTotal = new TextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            dataGridView1 = new DataGridView();
            code = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            tax = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            bAdd = new Button();
            bNew = new Button();
            bShow = new Button();
            bClose = new Button();
            button1 = new Button();
            bRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textCode
            // 
            textCode.Location = new Point(119, 61);
            textCode.Name = "textCode";
            textCode.Size = new Size(100, 23);
            textCode.TabIndex = 0;
            textCode.KeyDown += textCode_KeyDown;
            // 
            // textName
            // 
            textName.Location = new Point(119, 111);
            textName.Name = "textName";
            textName.Size = new Size(100, 23);
            textName.TabIndex = 1;
            textName.KeyDown += textName_KeyDown;
            // 
            // textPrice
            // 
            textPrice.Location = new Point(119, 205);
            textPrice.Name = "textPrice";
            textPrice.Size = new Size(100, 23);
            textPrice.TabIndex = 2;
            textPrice.KeyDown += textPrice_KeyDown;
            // 
            // textAmount
            // 
            textAmount.Location = new Point(119, 263);
            textAmount.Name = "textAmount";
            textAmount.Size = new Size(100, 23);
            textAmount.TabIndex = 3;
            textAmount.KeyDown += textAmount_KeyDown;
            textAmount.KeyPress += textAmount_KeyPress;
            // 
            // textTotal
            // 
            textTotal.Enabled = false;
            textTotal.Location = new Point(119, 320);
            textTotal.Name = "textTotal";
            textTotal.Size = new Size(100, 23);
            textTotal.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "เสื้อผ้า", "อาหาร", "น้ำ", "อุปกรณ์ไฟฟ้า", "ของเล่น", "ขนม", "เครื่องครัว" });
            comboBox1.Location = new Point(119, 157);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            comboBox1.KeyDown += comboBox1_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(56, 63);
            label1.Name = "label1";
            label1.Size = new Size(35, 21);
            label1.TabIndex = 6;
            label1.Text = "รหัส";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(56, 113);
            label2.Name = "label2";
            label2.Size = new Size(28, 21);
            label2.TabIndex = 7;
            label2.Text = "ชื่อ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(56, 159);
            label3.Name = "label3";
            label3.Size = new Size(54, 21);
            label3.TabIndex = 8;
            label3.Text = "ประเภท";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(56, 207);
            label4.Name = "label4";
            label4.Size = new Size(40, 21);
            label4.TabIndex = 9;
            label4.Text = "ราคา";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(56, 265);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 10;
            label5.Text = "จำนวน";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(56, 322);
            label6.Name = "label6";
            label6.Size = new Size(53, 21);
            label6.TabIndex = 11;
            label6.Text = "เป็นเงิน";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(242, 207);
            label7.Name = "label7";
            label7.Size = new Size(35, 21);
            label7.TabIndex = 12;
            label7.Text = "บาท";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(242, 265);
            label8.Name = "label8";
            label8.Size = new Size(30, 21);
            label8.TabIndex = 13;
            label8.Text = "ชิ้น";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(242, 322);
            label9.Name = "label9";
            label9.Size = new Size(35, 21);
            label9.TabIndex = 14;
            label9.Text = "บาท";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { code, name, type, price, amount, total, tax });
            dataGridView1.Location = new Point(298, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(694, 280);
            dataGridView1.TabIndex = 15;
            // 
            // code
            // 
            code.HeaderText = "รหัส";
            code.Name = "code";
            // 
            // name
            // 
            name.HeaderText = "ชื่อ";
            name.Name = "name";
            // 
            // type
            // 
            type.HeaderText = "ประเภท";
            type.Name = "type";
            // 
            // price
            // 
            price.HeaderText = "ราคา";
            price.Name = "price";
            // 
            // amount
            // 
            amount.FillWeight = 50F;
            amount.HeaderText = "จำนวน";
            amount.Name = "amount";
            amount.Width = 50;
            // 
            // total
            // 
            total.HeaderText = "เป็นเงิน";
            total.Name = "total";
            // 
            // tax
            // 
            tax.HeaderText = "คิดภาษี";
            tax.Name = "tax";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(56, 370);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(221, 89);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "คิดภาษี";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(138, 36);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(61, 25);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "ไม่คิด";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(63, 36);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(46, 25);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "คิด";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // bAdd
            // 
            bAdd.Location = new Point(298, 370);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(75, 31);
            bAdd.TabIndex = 17;
            bAdd.Text = "Add";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click;
            // 
            // bNew
            // 
            bNew.Location = new Point(189, 475);
            bNew.Name = "bNew";
            bNew.Size = new Size(75, 31);
            bNew.TabIndex = 18;
            bNew.Text = "New";
            bNew.UseVisualStyleBackColor = true;
            bNew.Click += bNew_Click;
            // 
            // bShow
            // 
            bShow.Location = new Point(298, 475);
            bShow.Name = "bShow";
            bShow.Size = new Size(75, 31);
            bShow.TabIndex = 19;
            bShow.Text = "Show";
            bShow.UseVisualStyleBackColor = true;
            bShow.Click += bShow_Click;
            // 
            // bClose
            // 
            bClose.Location = new Point(402, 475);
            bClose.Name = "bClose";
            bClose.Size = new Size(75, 31);
            bClose.TabIndex = 20;
            bClose.Text = "Close";
            bClose.UseVisualStyleBackColor = true;
            bClose.Click += bClose_Click;
            // 
            // button1
            // 
            button1.Location = new Point(515, 370);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 21;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            // 
            // bRemove
            // 
            bRemove.Location = new Point(402, 370);
            bRemove.Name = "bRemove";
            bRemove.Size = new Size(75, 31);
            bRemove.TabIndex = 22;
            bRemove.Text = "Delete";
            bRemove.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 549);
            Controls.Add(bRemove);
            Controls.Add(button1);
            Controls.Add(bClose);
            Controls.Add(bShow);
            Controls.Add(bNew);
            Controls.Add(bAdd);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(textTotal);
            Controls.Add(textAmount);
            Controls.Add(textPrice);
            Controls.Add(textName);
            Controls.Add(textCode);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textCode;
        private TextBox textName;
        private TextBox textPrice;
        private TextBox textAmount;
        private TextBox textTotal;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button bAdd;
        private Button bNew;
        private Button bShow;
        private Button bClose;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private DataGridViewTextBoxColumn code;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewTextBoxColumn total;
        private DataGridViewTextBoxColumn tax;
        private Button button1;
        private Button bRemove;
    }
}