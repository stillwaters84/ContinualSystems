﻿namespace GL
{
    partial class FILE
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
            this.m_file = new System.Windows.Forms.TextBox();
            this.IDC_FILEOK_BUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите имя файла";
            // 
            // m_file
            // 
            this.m_file.Location = new System.Drawing.Point(13, 74);
            this.m_file.Name = "m_file";
            this.m_file.Size = new System.Drawing.Size(321, 20);
            this.m_file.TabIndex = 1;
            // 
            // IDC_FILEOK_BUTTON
            // 
            this.IDC_FILEOK_BUTTON.Location = new System.Drawing.Point(136, 210);
            this.IDC_FILEOK_BUTTON.Name = "IDC_FILEOK_BUTTON";
            this.IDC_FILEOK_BUTTON.Size = new System.Drawing.Size(75, 23);
            this.IDC_FILEOK_BUTTON.TabIndex = 2;
            this.IDC_FILEOK_BUTTON.Text = "Ок";
            this.IDC_FILEOK_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_FILEOK_BUTTON.Click += new System.EventHandler(this.IDC_FILEOK_BUTTON_Click);
            // 
            // FILE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 245);
            this.Controls.Add(this.IDC_FILEOK_BUTTON);
            this.Controls.Add(this.m_file);
            this.Controls.Add(this.label1);
            this.Name = "FILE";
            this.Text = "FILE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_file;
        private System.Windows.Forms.Button IDC_FILEOK_BUTTON;
    }
}