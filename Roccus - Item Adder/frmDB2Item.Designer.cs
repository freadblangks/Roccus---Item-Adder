﻿namespace Roccus___Item_Adder
{
    partial class frmDB2Item
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CascReadBtn = new System.Windows.Forms.Button();
            this.CSVGenBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(406, 444);
            this.dataGridView1.TabIndex = 0;
            // 
            // CascReadBtn
            // 
            this.CascReadBtn.Location = new System.Drawing.Point(22, 14);
            this.CascReadBtn.Name = "CascReadBtn";
            this.CascReadBtn.Size = new System.Drawing.Size(185, 58);
            this.CascReadBtn.TabIndex = 1;
            this.CascReadBtn.Text = "Fill Table";
            this.CascReadBtn.UseVisualStyleBackColor = true;
            this.CascReadBtn.Click += new System.EventHandler(this.CascReadBtn_Click);
            // 
            // CSVGenBtn
            // 
            this.CSVGenBtn.Location = new System.Drawing.Point(243, 14);
            this.CSVGenBtn.Name = "CSVGenBtn";
            this.CSVGenBtn.Size = new System.Drawing.Size(185, 58);
            this.CSVGenBtn.TabIndex = 2;
            this.CSVGenBtn.Text = "CSV Generation";
            this.CSVGenBtn.UseVisualStyleBackColor = true;
            this.CSVGenBtn.Click += new System.EventHandler(this.CSVGenBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 480);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Table";
            // 
            // frmDB2Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 565);
            this.Controls.Add(this.CSVGenBtn);
            this.Controls.Add(this.CascReadBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDB2Item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDB2Item";
            this.Load += new System.EventHandler(this.frmDB2Item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CascReadBtn;
        private System.Windows.Forms.Button CSVGenBtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}