﻿namespace GL
{
    partial class R
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_nextr = new System.Windows.Forms.TextBox();
            this.m_npr = new System.Windows.Forms.TextBox();
            this.m_nmr = new System.Windows.Forms.TextBox();
            this.m_zr = new System.Windows.Forms.TextBox();
            this.IDC_NEXTR_BUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Резистор R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Узел n+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Узел n-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Сопротивление (КОм)";
            // 
            // m_nextr
            // 
            this.m_nextr.Location = new System.Drawing.Point(199, 48);
            this.m_nextr.Name = "m_nextr";
            this.m_nextr.ReadOnly = true;
            this.m_nextr.Size = new System.Drawing.Size(100, 20);
            this.m_nextr.TabIndex = 4;
            this.m_nextr.Text = "1";
            // 
            // m_npr
            // 
            this.m_npr.Location = new System.Drawing.Point(199, 85);
            this.m_npr.Name = "m_npr";
            this.m_npr.Size = new System.Drawing.Size(100, 20);
            this.m_npr.TabIndex = 5;
            this.m_npr.Text = "0";
            // 
            // m_nmr
            // 
            this.m_nmr.Location = new System.Drawing.Point(199, 125);
            this.m_nmr.Name = "m_nmr";
            this.m_nmr.Size = new System.Drawing.Size(100, 20);
            this.m_nmr.TabIndex = 6;
            this.m_nmr.Text = "0";
            // 
            // m_zr
            // 
            this.m_zr.Location = new System.Drawing.Point(199, 161);
            this.m_zr.Name = "m_zr";
            this.m_zr.Size = new System.Drawing.Size(100, 20);
            this.m_zr.TabIndex = 7;
            this.m_zr.Text = "0";
            // 
            // IDC_NEXTR_BUTTON
            // 
            this.IDC_NEXTR_BUTTON.Location = new System.Drawing.Point(136, 217);
            this.IDC_NEXTR_BUTTON.Name = "IDC_NEXTR_BUTTON";
            this.IDC_NEXTR_BUTTON.Size = new System.Drawing.Size(109, 28);
            this.IDC_NEXTR_BUTTON.TabIndex = 8;
            this.IDC_NEXTR_BUTTON.Text = "Следующий";
            this.IDC_NEXTR_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_NEXTR_BUTTON.Click += new System.EventHandler(this.IDC_NEXTR_BUTTON_Click);
            // 
            // R
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 268);
            this.Controls.Add(this.IDC_NEXTR_BUTTON);
            this.Controls.Add(this.m_zr);
            this.Controls.Add(this.m_nmr);
            this.Controls.Add(this.m_npr);
            this.Controls.Add(this.m_nextr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "R";
            this.Text = "R";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m_nextr;
        private System.Windows.Forms.TextBox m_npr;
        private System.Windows.Forms.TextBox m_nmr;
        private System.Windows.Forms.TextBox m_zr;
        private System.Windows.Forms.Button IDC_NEXTR_BUTTON;
    }
}