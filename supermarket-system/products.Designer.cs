namespace Supermarket_Management_System
{
    partial class products
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_search_id = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_search_name = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "product_ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(394, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(438, 350);
            this.dataGridView1.TabIndex = 9;
            // 
            // btn_search_id
            // 
            this.btn_search_id.Location = new System.Drawing.Point(174, 129);
            this.btn_search_id.Name = "btn_search_id";
            this.btn_search_id.Size = new System.Drawing.Size(172, 26);
            this.btn_search_id.TabIndex = 10;
            this.btn_search_id.Text = "search by product id";
            this.btn_search_id.UseVisualStyleBackColor = true;
            this.btn_search_id.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(126, 372);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(172, 27);
            this.btn_show.TabIndex = 11;
            this.btn_show.Text = "show all products information";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(568, 410);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(124, 30);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(126, 61);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(124, 20);
            this.txt_id.TabIndex = 13;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(126, 206);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(124, 20);
            this.txt_name.TabIndex = 14;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "product_Name";
            // 
            // btn_search_name
            // 
            this.btn_search_name.Location = new System.Drawing.Point(174, 269);
            this.btn_search_name.Name = "btn_search_name";
            this.btn_search_name.Size = new System.Drawing.Size(172, 23);
            this.btn_search_name.TabIndex = 16;
            this.btn_search_name.Text = "search by product name";
            this.btn_search_name.UseVisualStyleBackColor = true;
            this.btn_search_name.Click += new System.EventHandler(this.btn_search_name_Click);
            // 
            // products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 471);
            this.Controls.Add(this.btn_search_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btn_search_id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "products";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_search_id;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_search_name;
    }
}