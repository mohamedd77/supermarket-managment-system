
namespace Supermarket_Management_System
{
    partial class changeproduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_change = new System.Windows.Forms.Button();
            this.cmb_c_id = new System.Windows.Forms.ComboBox();
            this.cmb_p_id = new System.Windows.Forms.ComboBox();
            this.txt_new_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_show = new System.Windows.Forms.Button();
            this.txt_c_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tip: choose the customer id and then choose the product id that you want to chang" +
    "e";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(15, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = " and then write the new id in the text box";
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(233, 229);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(113, 40);
            this.btn_change.TabIndex = 2;
            this.btn_change.Text = "change";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // cmb_c_id
            // 
            this.cmb_c_id.FormattingEnabled = true;
            this.cmb_c_id.Location = new System.Drawing.Point(99, 78);
            this.cmb_c_id.Name = "cmb_c_id";
            this.cmb_c_id.Size = new System.Drawing.Size(121, 21);
            this.cmb_c_id.TabIndex = 3;
            this.cmb_c_id.SelectedIndexChanged += new System.EventHandler(this.cmb_c_id_SelectedIndexChanged);
            // 
            // cmb_p_id
            // 
            this.cmb_p_id.FormattingEnabled = true;
            this.cmb_p_id.Location = new System.Drawing.Point(99, 140);
            this.cmb_p_id.Name = "cmb_p_id";
            this.cmb_p_id.Size = new System.Drawing.Size(121, 21);
            this.cmb_p_id.TabIndex = 4;
            // 
            // txt_new_id
            // 
            this.txt_new_id.Location = new System.Drawing.Point(384, 140);
            this.txt_new_id.Name = "txt_new_id";
            this.txt_new_id.Size = new System.Drawing.Size(120, 20);
            this.txt_new_id.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "customer_id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "products_id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "the new id";
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(99, 186);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(121, 23);
            this.btn_show.TabIndex = 9;
            this.btn_show.Text = "show the products";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_c_name
            // 
            this.txt_c_name.Location = new System.Drawing.Point(384, 78);
            this.txt_c_name.Name = "txt_c_name";
            this.txt_c_name.Size = new System.Drawing.Size(120, 20);
            this.txt_c_name.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "customer_name";
            // 
            // changeproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 281);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_c_name);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_new_id);
            this.Controls.Add(this.cmb_p_id);
            this.Controls.Add(this.cmb_c_id);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "changeproduct";
            this.Text = "changeproduct";
            this.Load += new System.EventHandler(this.changeproduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.ComboBox cmb_c_id;
        private System.Windows.Forms.ComboBox cmb_p_id;
        private System.Windows.Forms.TextBox txt_new_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.TextBox txt_c_name;
        private System.Windows.Forms.Label label6;
    }
}