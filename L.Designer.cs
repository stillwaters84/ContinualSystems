namespace GL
{
    partial class L
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
            this.m_nextl = new System.Windows.Forms.TextBox();
            this.m_npl = new System.Windows.Forms.TextBox();
            this.m_nml = new System.Windows.Forms.TextBox();
            this.m_zl = new System.Windows.Forms.TextBox();
            this.IDC_NEXTL_BUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Катушка L";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Узел n+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Узел n-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Индуктивность (мГн)";
            // 
            // m_nextl
            // 
            this.m_nextl.Location = new System.Drawing.Point(231, 56);
            this.m_nextl.Name = "m_nextl";
            this.m_nextl.ReadOnly = true;
            this.m_nextl.Size = new System.Drawing.Size(100, 20);
            this.m_nextl.TabIndex = 4;
            this.m_nextl.Text = "1";
            // 
            // m_npl
            // 
            this.m_npl.Location = new System.Drawing.Point(231, 97);
            this.m_npl.Name = "m_npl";
            this.m_npl.Size = new System.Drawing.Size(100, 20);
            this.m_npl.TabIndex = 5;
            this.m_npl.Text = "0";
            // 
            // m_nml
            // 
            this.m_nml.Location = new System.Drawing.Point(231, 135);
            this.m_nml.Name = "m_nml";
            this.m_nml.Size = new System.Drawing.Size(100, 20);
            this.m_nml.TabIndex = 6;
            this.m_nml.Text = "0";
            // 
            // m_zl
            // 
            this.m_zl.Location = new System.Drawing.Point(231, 173);
            this.m_zl.Name = "m_zl";
            this.m_zl.Size = new System.Drawing.Size(100, 20);
            this.m_zl.TabIndex = 7;
            this.m_zl.Text = "0";
            // 
            // IDC_NEXTL_BUTTON
            // 
            this.IDC_NEXTL_BUTTON.Location = new System.Drawing.Point(151, 224);
            this.IDC_NEXTL_BUTTON.Name = "IDC_NEXTL_BUTTON";
            this.IDC_NEXTL_BUTTON.Size = new System.Drawing.Size(107, 33);
            this.IDC_NEXTL_BUTTON.TabIndex = 8;
            this.IDC_NEXTL_BUTTON.Text = "Следующая";
            this.IDC_NEXTL_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_NEXTL_BUTTON.Click += new System.EventHandler(this.IDC_NEXTL_BUTTON_Click);
            // 
            // L
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 311);
            this.Controls.Add(this.IDC_NEXTL_BUTTON);
            this.Controls.Add(this.m_zl);
            this.Controls.Add(this.m_nml);
            this.Controls.Add(this.m_npl);
            this.Controls.Add(this.m_nextl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "L";
            this.Text = "L";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m_nextl;
        private System.Windows.Forms.TextBox m_npl;
        private System.Windows.Forms.TextBox m_nml;
        private System.Windows.Forms.TextBox m_zl;
        private System.Windows.Forms.Button IDC_NEXTL_BUTTON;
    }
}