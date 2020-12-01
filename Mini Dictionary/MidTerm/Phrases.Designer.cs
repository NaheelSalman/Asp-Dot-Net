﻿namespace MidTerm
{
    partial class Phrases
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.colSerial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProverb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhrase = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSlang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtPhrases = new System.Windows.Forms.TextBox();
            this.txtSlang = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtProverb = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(181, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "English Phrases";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSerial,
            this.colProverb,
            this.colPhrase,
            this.colSlang});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 178);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(514, 354);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colSerial
            // 
            this.colSerial.Text = "Serial No.";
            this.colSerial.Width = 59;
            // 
            // colProverb
            // 
            this.colProverb.Text = "Proverbs";
            this.colProverb.Width = 139;
            // 
            // colPhrase
            // 
            this.colPhrase.Text = "Phrases verb ";
            this.colPhrase.Width = 157;
            // 
            // colSlang
            // 
            this.colSlang.Text = "Slang ";
            this.colSlang.Width = 70;
            // 
            // txtPhrases
            // 
            this.txtPhrases.Location = new System.Drawing.Point(344, 45);
            this.txtPhrases.Multiline = true;
            this.txtPhrases.Name = "txtPhrases";
            this.txtPhrases.Size = new System.Drawing.Size(100, 26);
            this.txtPhrases.TabIndex = 3;
            // 
            // txtSlang
            // 
            this.txtSlang.Location = new System.Drawing.Point(344, 86);
            this.txtSlang.Multiline = true;
            this.txtSlang.Name = "txtSlang";
            this.txtSlang.Size = new System.Drawing.Size(100, 26);
            this.txtSlang.TabIndex = 3;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(137, 45);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 26);
            this.txtId.TabIndex = 3;
            // 
            // txtProverb
            // 
            this.txtProverb.Location = new System.Drawing.Point(137, 86);
            this.txtProverb.Multiline = true;
            this.txtProverb.Name = "txtProverb";
            this.txtProverb.Size = new System.Drawing.Size(100, 26);
            this.txtProverb.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = global::MidTerm.Properties.Resources._221_2214644_button_add_icon_web_symbol_internet_website_add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Location = new System.Drawing.Point(122, 135);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(38, 37);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = global::MidTerm.Properties.Resources._1116032_preview_preview;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Location = new System.Drawing.Point(178, 135);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(38, 37);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BackgroundImage = global::MidTerm.Properties.Resources.download;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.Location = new System.Drawing.Point(329, 135);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(38, 37);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Transparent;
            this.btnView.BackgroundImage = global::MidTerm.Properties.Resources.download1;
            this.btnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.Location = new System.Drawing.Point(385, 135);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(38, 37);
            this.btnView.TabIndex = 7;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label3.Location = new System.Drawing.Point(46, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "S.No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label4.Location = new System.Drawing.Point(46, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Proverbs";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label5.Location = new System.Drawing.Point(255, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phrases";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label6.Location = new System.Drawing.Point(272, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Slang";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::MidTerm.Properties.Resources.photo_1557683316_973673baf926;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(-2, -2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 40);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "< Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Phrases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MidTerm.Properties.Resources.photo_1557683316_973673baf926;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(531, 544);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtProverb);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtSlang);
            this.Controls.Add(this.txtPhrases);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Phrases";
            this.Text = "Phrases";
            this.Load += new System.EventHandler(this.Phrases_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colSerial;
        private System.Windows.Forms.ColumnHeader colProverb;
        private System.Windows.Forms.ColumnHeader colPhrase;
        private System.Windows.Forms.ColumnHeader colSlang;
        private System.Windows.Forms.TextBox txtPhrases;
        private System.Windows.Forms.TextBox txtSlang;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtProverb;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBack;
    }
}