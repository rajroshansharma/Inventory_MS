
namespace connecting_dbms
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.insert_btn = new System.Windows.Forms.Button();
            this.id_Box1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name_Box = new System.Windows.Forms.TextBox();
            this.price_Box = new System.Windows.Forms.TextBox();
            this.supplierName_Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.place_Box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(626, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(673, 453);
            this.dataGridView1.TabIndex = 0;
            // 
            // insert_btn
            // 
            this.insert_btn.Location = new System.Drawing.Point(54, 479);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(110, 40);
            this.insert_btn.TabIndex = 1;
            this.insert_btn.Text = "Insert Data";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // id_Box1
            // 
            this.id_Box1.Location = new System.Drawing.Point(50, 99);
            this.id_Box1.Name = "id_Box1";
            this.id_Box1.Size = new System.Drawing.Size(130, 27);
            this.id_Box1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(179, 479);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(110, 40);
            this.delete_btn.TabIndex = 4;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(305, 479);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(110, 40);
            this.update_btn.TabIndex = 5;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Product name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Product price Rs";
            // 
            // name_Box
            // 
            this.name_Box.Location = new System.Drawing.Point(229, 99);
            this.name_Box.Multiline = true;
            this.name_Box.Name = "name_Box";
            this.name_Box.Size = new System.Drawing.Size(306, 35);
            this.name_Box.TabIndex = 8;
            // 
            // price_Box
            // 
            this.price_Box.Location = new System.Drawing.Point(50, 185);
            this.price_Box.Multiline = true;
            this.price_Box.Name = "price_Box";
            this.price_Box.Size = new System.Drawing.Size(306, 35);
            this.price_Box.TabIndex = 9;
            // 
            // supplierName_Box
            // 
            this.supplierName_Box.Location = new System.Drawing.Point(50, 272);
            this.supplierName_Box.Multiline = true;
            this.supplierName_Box.Name = "supplierName_Box";
            this.supplierName_Box.Size = new System.Drawing.Size(306, 35);
            this.supplierName_Box.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Supplier name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Product Place";
            // 
            // place_Box
            // 
            this.place_Box.Location = new System.Drawing.Point(50, 354);
            this.place_Box.Multiline = true;
            this.place_Box.Name = "place_Box";
            this.place_Box.Size = new System.Drawing.Size(306, 35);
            this.place_Box.TabIndex = 12;
            this.place_Box.TextChanged += new System.EventHandler(this.place_Box_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1189, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 601);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.place_Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.supplierName_Box);
            this.Controls.Add(this.price_Box);
            this.Controls.Add(this.name_Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_Box1);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.TextBox id_Box1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name_Box;
        private System.Windows.Forms.TextBox price_Box;
        private System.Windows.Forms.TextBox supplierName_Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox place_Box;
        private System.Windows.Forms.Button button1;
    }
}

