namespace GL
{
    partial class RED
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
            this.m_n = new System.Windows.Forms.TextBox();
            this.IDC_OUT_BUTTON = new System.Windows.Forms.Button();
            this.m_redlst = new System.Windows.Forms.ListBox();
            this.IDC_NP1_STATIC = new System.Windows.Forms.Label();
            this.IDC_NM1_STATIC = new System.Windows.Forms.Label();
            this.m_np1 = new System.Windows.Forms.TextBox();
            this.m_nm1 = new System.Windows.Forms.TextBox();
            this.IDC_NP2_STATIC = new System.Windows.Forms.Label();
            this.IDC_NM2_STATIC = new System.Windows.Forms.Label();
            this.IDC_Z1_STATIC = new System.Windows.Forms.Label();
            this.IDC_Z2_STATIC = new System.Windows.Forms.Label();
            this.IDC_Z3_STATIC = new System.Windows.Forms.Label();
            this.IDC_Z4_STATIC = new System.Windows.Forms.Label();
            this.IDC_Z5_STATIC = new System.Windows.Forms.Label();
            this.IDC_Z6_STATIC = new System.Windows.Forms.Label();
            this.m_np2 = new System.Windows.Forms.TextBox();
            this.m_nm2 = new System.Windows.Forms.TextBox();
            this.m_z1 = new System.Windows.Forms.TextBox();
            this.m_z2 = new System.Windows.Forms.TextBox();
            this.m_z3 = new System.Windows.Forms.TextBox();
            this.m_z4 = new System.Windows.Forms.TextBox();
            this.m_z5 = new System.Windows.Forms.TextBox();
            this.m_z6 = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.IDC_IN_BUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип компонента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер компонента";
            // 
            // m_n
            // 
            this.m_n.Location = new System.Drawing.Point(395, 28);
            this.m_n.Name = "m_n";
            this.m_n.Size = new System.Drawing.Size(141, 20);
            this.m_n.TabIndex = 2;
            this.m_n.Text = "1";
            // 
            // IDC_OUT_BUTTON
            // 
            this.IDC_OUT_BUTTON.Location = new System.Drawing.Point(323, 66);
            this.IDC_OUT_BUTTON.Name = "IDC_OUT_BUTTON";
            this.IDC_OUT_BUTTON.Size = new System.Drawing.Size(143, 26);
            this.IDC_OUT_BUTTON.TabIndex = 3;
            this.IDC_OUT_BUTTON.Text = "Вывод описания";
            this.IDC_OUT_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_OUT_BUTTON.Click += new System.EventHandler(this.IDC_OUT_BUTTON_Click);
            // 
            // m_redlst
            // 
            this.m_redlst.FormattingEnabled = true;
            this.m_redlst.Items.AddRange(new object[] {
            "Резисторы",
            "Конденсаторы",
            "Индуктивности",
            "ИТУН",
            "ИТУТ",
            "ИНУН",
            "ИНУТ",
            "Б/п транзисторы",
            "У/п транзисторы",
            "Операционные усилители",
            "Трансформаторы",
            "Ид. опер. усилители",
            "Ид. трансформаторы"});
            this.m_redlst.Location = new System.Drawing.Point(27, 66);
            this.m_redlst.Name = "m_redlst";
            this.m_redlst.Size = new System.Drawing.Size(184, 316);
            this.m_redlst.TabIndex = 4;
            this.m_redlst.DoubleClick += new System.EventHandler(this.m_redlst_DoubleClick);
            // 
            // IDC_NP1_STATIC
            // 
            this.IDC_NP1_STATIC.AutoSize = true;
            this.IDC_NP1_STATIC.Location = new System.Drawing.Point(233, 123);
            this.IDC_NP1_STATIC.Name = "IDC_NP1_STATIC";
            this.IDC_NP1_STATIC.Size = new System.Drawing.Size(55, 13);
            this.IDC_NP1_STATIC.TabIndex = 5;
            this.IDC_NP1_STATIC.Text = "Значение";
            // 
            // IDC_NM1_STATIC
            // 
            this.IDC_NM1_STATIC.AutoSize = true;
            this.IDC_NM1_STATIC.Location = new System.Drawing.Point(233, 158);
            this.IDC_NM1_STATIC.Name = "IDC_NM1_STATIC";
            this.IDC_NM1_STATIC.Size = new System.Drawing.Size(55, 13);
            this.IDC_NM1_STATIC.TabIndex = 6;
            this.IDC_NM1_STATIC.Text = "Значение";
            // 
            // m_np1
            // 
            this.m_np1.Location = new System.Drawing.Point(294, 120);
            this.m_np1.Name = "m_np1";
            this.m_np1.Size = new System.Drawing.Size(100, 20);
            this.m_np1.TabIndex = 7;
            // 
            // m_nm1
            // 
            this.m_nm1.Location = new System.Drawing.Point(294, 155);
            this.m_nm1.Name = "m_nm1";
            this.m_nm1.Size = new System.Drawing.Size(100, 20);
            this.m_nm1.TabIndex = 8;
            // 
            // IDC_NP2_STATIC
            // 
            this.IDC_NP2_STATIC.AutoSize = true;
            this.IDC_NP2_STATIC.Location = new System.Drawing.Point(419, 123);
            this.IDC_NP2_STATIC.Name = "IDC_NP2_STATIC";
            this.IDC_NP2_STATIC.Size = new System.Drawing.Size(55, 13);
            this.IDC_NP2_STATIC.TabIndex = 9;
            this.IDC_NP2_STATIC.Text = "Значение";
            // 
            // IDC_NM2_STATIC
            // 
            this.IDC_NM2_STATIC.AutoSize = true;
            this.IDC_NM2_STATIC.Location = new System.Drawing.Point(419, 158);
            this.IDC_NM2_STATIC.Name = "IDC_NM2_STATIC";
            this.IDC_NM2_STATIC.Size = new System.Drawing.Size(55, 13);
            this.IDC_NM2_STATIC.TabIndex = 10;
            this.IDC_NM2_STATIC.Text = "Значение";
            // 
            // IDC_Z1_STATIC
            // 
            this.IDC_Z1_STATIC.AutoSize = true;
            this.IDC_Z1_STATIC.Location = new System.Drawing.Point(419, 192);
            this.IDC_Z1_STATIC.Name = "IDC_Z1_STATIC";
            this.IDC_Z1_STATIC.Size = new System.Drawing.Size(55, 13);
            this.IDC_Z1_STATIC.TabIndex = 11;
            this.IDC_Z1_STATIC.Text = "Значение";
            // 
            // IDC_Z2_STATIC
            // 
            this.IDC_Z2_STATIC.AutoSize = true;
            this.IDC_Z2_STATIC.Location = new System.Drawing.Point(419, 225);
            this.IDC_Z2_STATIC.Name = "IDC_Z2_STATIC";
            this.IDC_Z2_STATIC.Size = new System.Drawing.Size(55, 13);
            this.IDC_Z2_STATIC.TabIndex = 12;
            this.IDC_Z2_STATIC.Text = "Значение";
            // 
            // IDC_Z3_STATIC
            // 
            this.IDC_Z3_STATIC.AutoSize = true;
            this.IDC_Z3_STATIC.Location = new System.Drawing.Point(419, 258);
            this.IDC_Z3_STATIC.Name = "IDC_Z3_STATIC";
            this.IDC_Z3_STATIC.Size = new System.Drawing.Size(55, 13);
            this.IDC_Z3_STATIC.TabIndex = 13;
            this.IDC_Z3_STATIC.Text = "Значение";
            // 
            // IDC_Z4_STATIC
            // 
            this.IDC_Z4_STATIC.AutoSize = true;
            this.IDC_Z4_STATIC.Location = new System.Drawing.Point(419, 291);
            this.IDC_Z4_STATIC.Name = "IDC_Z4_STATIC";
            this.IDC_Z4_STATIC.Size = new System.Drawing.Size(55, 13);
            this.IDC_Z4_STATIC.TabIndex = 14;
            this.IDC_Z4_STATIC.Text = "Значение";
            // 
            // IDC_Z5_STATIC
            // 
            this.IDC_Z5_STATIC.AutoSize = true;
            this.IDC_Z5_STATIC.Location = new System.Drawing.Point(419, 325);
            this.IDC_Z5_STATIC.Name = "IDC_Z5_STATIC";
            this.IDC_Z5_STATIC.Size = new System.Drawing.Size(55, 13);
            this.IDC_Z5_STATIC.TabIndex = 15;
            this.IDC_Z5_STATIC.Text = "Значение";
            // 
            // IDC_Z6_STATIC
            // 
            this.IDC_Z6_STATIC.AutoSize = true;
            this.IDC_Z6_STATIC.Location = new System.Drawing.Point(419, 359);
            this.IDC_Z6_STATIC.Name = "IDC_Z6_STATIC";
            this.IDC_Z6_STATIC.Size = new System.Drawing.Size(55, 13);
            this.IDC_Z6_STATIC.TabIndex = 16;
            this.IDC_Z6_STATIC.Text = "Значение";
            // 
            // m_np2
            // 
            this.m_np2.Location = new System.Drawing.Point(480, 120);
            this.m_np2.Name = "m_np2";
            this.m_np2.Size = new System.Drawing.Size(100, 20);
            this.m_np2.TabIndex = 17;
            // 
            // m_nm2
            // 
            this.m_nm2.Location = new System.Drawing.Point(480, 155);
            this.m_nm2.Name = "m_nm2";
            this.m_nm2.Size = new System.Drawing.Size(100, 20);
            this.m_nm2.TabIndex = 18;
            // 
            // m_z1
            // 
            this.m_z1.Location = new System.Drawing.Point(480, 189);
            this.m_z1.Name = "m_z1";
            this.m_z1.Size = new System.Drawing.Size(100, 20);
            this.m_z1.TabIndex = 19;
            // 
            // m_z2
            // 
            this.m_z2.Location = new System.Drawing.Point(480, 222);
            this.m_z2.Name = "m_z2";
            this.m_z2.Size = new System.Drawing.Size(100, 20);
            this.m_z2.TabIndex = 20;
            // 
            // m_z3
            // 
            this.m_z3.Location = new System.Drawing.Point(480, 255);
            this.m_z3.Name = "m_z3";
            this.m_z3.Size = new System.Drawing.Size(100, 20);
            this.m_z3.TabIndex = 21;
            // 
            // m_z4
            // 
            this.m_z4.Location = new System.Drawing.Point(480, 288);
            this.m_z4.Name = "m_z4";
            this.m_z4.Size = new System.Drawing.Size(100, 20);
            this.m_z4.TabIndex = 22;
            // 
            // m_z5
            // 
            this.m_z5.Location = new System.Drawing.Point(480, 322);
            this.m_z5.Name = "m_z5";
            this.m_z5.Size = new System.Drawing.Size(100, 20);
            this.m_z5.TabIndex = 23;
            // 
            // m_z6
            // 
            this.m_z6.Location = new System.Drawing.Point(480, 356);
            this.m_z6.Name = "m_z6";
            this.m_z6.Size = new System.Drawing.Size(100, 20);
            this.m_z6.TabIndex = 24;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(39, 423);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 25;
            this.OK.Text = "Ок";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // IDC_IN_BUTTON
            // 
            this.IDC_IN_BUTTON.Location = new System.Drawing.Point(372, 423);
            this.IDC_IN_BUTTON.Name = "IDC_IN_BUTTON";
            this.IDC_IN_BUTTON.Size = new System.Drawing.Size(112, 23);
            this.IDC_IN_BUTTON.TabIndex = 26;
            this.IDC_IN_BUTTON.Text = "Ввод описания";
            this.IDC_IN_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_IN_BUTTON.Click += new System.EventHandler(this.IDC_IN_BUTTON_Click);
            // 
            // RED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 458);
            this.Controls.Add(this.IDC_IN_BUTTON);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.m_z6);
            this.Controls.Add(this.m_z5);
            this.Controls.Add(this.m_z4);
            this.Controls.Add(this.m_z3);
            this.Controls.Add(this.m_z2);
            this.Controls.Add(this.m_z1);
            this.Controls.Add(this.m_nm2);
            this.Controls.Add(this.m_np2);
            this.Controls.Add(this.IDC_Z6_STATIC);
            this.Controls.Add(this.IDC_Z5_STATIC);
            this.Controls.Add(this.IDC_Z4_STATIC);
            this.Controls.Add(this.IDC_Z3_STATIC);
            this.Controls.Add(this.IDC_Z2_STATIC);
            this.Controls.Add(this.IDC_Z1_STATIC);
            this.Controls.Add(this.IDC_NM2_STATIC);
            this.Controls.Add(this.IDC_NP2_STATIC);
            this.Controls.Add(this.m_nm1);
            this.Controls.Add(this.m_np1);
            this.Controls.Add(this.IDC_NM1_STATIC);
            this.Controls.Add(this.IDC_NP1_STATIC);
            this.Controls.Add(this.m_redlst);
            this.Controls.Add(this.IDC_OUT_BUTTON);
            this.Controls.Add(this.m_n);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RED";
            this.Text = "Редактирование компонентов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_n;
        private System.Windows.Forms.Button IDC_OUT_BUTTON;
        private System.Windows.Forms.ListBox m_redlst;
        private System.Windows.Forms.Label IDC_NP1_STATIC;
        private System.Windows.Forms.Label IDC_NM1_STATIC;
        private System.Windows.Forms.TextBox m_np1;
        private System.Windows.Forms.TextBox m_nm1;
        private System.Windows.Forms.Label IDC_NP2_STATIC;
        private System.Windows.Forms.Label IDC_NM2_STATIC;
        private System.Windows.Forms.Label IDC_Z1_STATIC;
        private System.Windows.Forms.Label IDC_Z2_STATIC;
        private System.Windows.Forms.Label IDC_Z3_STATIC;
        private System.Windows.Forms.Label IDC_Z4_STATIC;
        private System.Windows.Forms.Label IDC_Z5_STATIC;
        private System.Windows.Forms.Label IDC_Z6_STATIC;
        private System.Windows.Forms.TextBox m_np2;
        private System.Windows.Forms.TextBox m_nm2;
        private System.Windows.Forms.TextBox m_z1;
        private System.Windows.Forms.TextBox m_z2;
        private System.Windows.Forms.TextBox m_z3;
        private System.Windows.Forms.TextBox m_z4;
        private System.Windows.Forms.TextBox m_z5;
        private System.Windows.Forms.TextBox m_z6;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button IDC_IN_BUTTON;
    }
}