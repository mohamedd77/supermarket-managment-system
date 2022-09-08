namespace Supermarket_Management_System
{
    partial class payments
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
            this.customer_ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_c_id = new System.Windows.Forms.ComboBox();
            this.txt_c_name = new System.Windows.Forms.TextBox();
            this.txt_p_name = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_show = new System.Windows.Forms.Button();
            this.cmb_p_id = new System.Windows.Forms.ComboBox();
            this.txt_p_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_bill = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_bill = new System.Windows.Forms.Button();
            this.btn_add_c = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customer_ID
            // 
            this.customer_ID.AutoSize = true;
            this.customer_ID.Location = new System.Drawing.Point(108, 62);
            this.customer_ID.Name = "customer_ID";
            this.customer_ID.Size = new System.Drawing.Size(68, 13);
            this.customer_ID.TabIndex = 0;
            this.customer_ID.Text = "customer_ID";
            this.customer_ID.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer_Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "products";
            // 
            // cmb_c_id
            // 
            this.cmb_c_id.FormattingEnabled = true;
            this.cmb_c_id.Location = new System.Drawing.Point(206, 62);
            this.cmb_c_id.Name = "cmb_c_id";
            this.cmb_c_id.Size = new System.Drawing.Size(126, 21);
            this.cmb_c_id.TabIndex = 3;
            this.cmb_c_id.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_c_name
            // 
            this.txt_c_name.Location = new System.Drawing.Point(206, 116);
            this.txt_c_name.Name = "txt_c_name";
            this.txt_c_name.Size = new System.Drawing.Size(126, 20);
            this.txt_c_name.TabIndex = 4;
            this.txt_c_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_p_name
            // 
            this.txt_p_name.Location = new System.Drawing.Point(206, 223);
            this.txt_p_name.Name = "txt_p_name";
            this.txt_p_name.Size = new System.Drawing.Size(126, 20);
            this.txt_p_name.TabIndex = 5;
            this.txt_p_name.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(122, 378);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(141, 36);
            this.btn_insert.TabIndex = 6;
            this.btn_insert.Text = "make payment";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.button1_Click);
            this.btn_insert.MouseHover += new System.EventHandler(this.hover);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(291, 378);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(141, 36);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "change payment";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(473, 379);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(141, 35);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "delete payment";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.button3_Click);
            this.btn_delete.MouseHover += new System.EventHandler(this.hover_delete);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "price";
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(394, 174);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(135, 23);
            this.btn_show.TabIndex = 12;
            this.btn_show.Text = "show customer products";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.button4_Click);
            // 
            // cmb_p_id
            // 
            this.cmb_p_id.FormattingEnabled = true;
            this.cmb_p_id.Location = new System.Drawing.Point(206, 174);
            this.cmb_p_id.Name = "cmb_p_id";
            this.cmb_p_id.Size = new System.Drawing.Size(126, 21);
            this.cmb_p_id.TabIndex = 13;
            this.cmb_p_id.SelectedIndexChanged += new System.EventHandler(this.cmb_p_name_SelectedIndexChanged);
            // 
            // txt_p_price
            // 
            this.txt_p_price.Location = new System.Drawing.Point(206, 280);
            this.txt_p_price.Name = "txt_p_price";
            this.txt_p_price.Size = new System.Drawing.Size(126, 20);
            this.txt_p_price.TabIndex = 14;
            this.txt_p_price.TextChanged += new System.EventHandler(this.txt_p_price_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "name";
            // 
            // txt_bill
            // 
            this.txt_bill.Location = new System.Drawing.Point(206, 330);
            this.txt_bill.Name = "txt_bill";
            this.txt_bill.Size = new System.Drawing.Size(126, 20);
            this.txt_bill.TabIndex = 16;
            this.txt_bill.TextChanged += new System.EventHandler(this.txt_bill_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "The Bill";
            // 
            // btn_bill
            // 
            this.btn_bill.Location = new System.Drawing.Point(394, 328);
            this.btn_bill.Name = "btn_bill";
            this.btn_bill.Size = new System.Drawing.Size(135, 23);
            this.btn_bill.TabIndex = 18;
            this.btn_bill.Text = "show_bill";
            this.btn_bill.UseVisualStyleBackColor = true;
            this.btn_bill.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_add_c
            // 
            this.btn_add_c.Location = new System.Drawing.Point(394, 24);
            this.btn_add_c.Name = "btn_add_c";
            this.btn_add_c.Size = new System.Drawing.Size(135, 23);
            this.btn_add_c.TabIndex = 19;
            this.btn_add_c.Text = "add new customer";
            this.btn_add_c.UseVisualStyleBackColor = true;
            this.btn_add_c.Click += new System.EventHandler(this.btn_add_c_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(394, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "change customer info";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(394, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "delete customer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_add_c);
            this.Controls.Add(this.btn_bill);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_bill);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_p_price);
            this.Controls.Add(this.cmb_p_id);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.txt_p_name);
            this.Controls.Add(this.txt_c_name);
            this.Controls.Add(this.cmb_c_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customer_ID);
            this.Name = "payments";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customer_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_c_id;
        private System.Windows.Forms.TextBox txt_c_name;
        private System.Windows.Forms.TextBox txt_p_name;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.ComboBox cmb_p_id;
        private System.Windows.Forms.TextBox txt_p_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_bill;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_bill;
        private System.Windows.Forms.Button btn_add_c;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

