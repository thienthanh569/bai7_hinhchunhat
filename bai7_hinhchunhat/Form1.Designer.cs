﻿namespace bai7_hinhchunhat
{
    partial class Form1
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
            this.txtDai = new System.Windows.Forms.TextBox();
            this.txtRong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChuVi = new System.Windows.Forms.TextBox();
            this.btTinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "chiều dài";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "chiều rộng";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDai
            // 
            this.txtDai.Location = new System.Drawing.Point(144, 71);
            this.txtDai.Name = "txtDai";
            this.txtDai.Size = new System.Drawing.Size(100, 20);
            this.txtDai.TabIndex = 1;
            // 
            // txtRong
            // 
            this.txtRong.Location = new System.Drawing.Point(144, 98);
            this.txtRong.Name = "txtRong";
            this.txtRong.Size = new System.Drawing.Size(100, 20);
            this.txtRong.TabIndex = 2;
            this.txtRong.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "diện tích";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDienTich
            // 
            this.txtDienTich.Location = new System.Drawing.Point(144, 124);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.Size = new System.Drawing.Size(100, 20);
            this.txtDienTich.TabIndex = 2;
            this.txtDienTich.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "chu vi";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtChuVi
            // 
            this.txtChuVi.Location = new System.Drawing.Point(144, 150);
            this.txtChuVi.Name = "txtChuVi";
            this.txtChuVi.Size = new System.Drawing.Size(100, 20);
            this.txtChuVi.TabIndex = 2;
            this.txtChuVi.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btTinh
            // 
            this.btTinh.Location = new System.Drawing.Point(261, 86);
            this.btTinh.Name = "btTinh";
            this.btTinh.Size = new System.Drawing.Size(75, 23);
            this.btTinh.TabIndex = 3;
            this.btTinh.Text = "tính";
            this.btTinh.UseVisualStyleBackColor = true;
            this.btTinh.Click += new System.EventHandler(this.btTinh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btTinh);
            this.Controls.Add(this.txtChuVi);
            this.Controls.Add(this.txtDienTich);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDai;
        private System.Windows.Forms.TextBox txtRong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChuVi;
        private System.Windows.Forms.Button btTinh;
    }
}

