namespace CalculoMedia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nmaluno_lbl = new System.Windows.Forms.Label();
            this.nmaluno_txtbox = new System.Windows.Forms.TextBox();
            this.n1_lbl = new System.Windows.Forms.Label();
            this.n1_txtbox = new System.Windows.Forms.TextBox();
            this.n2_txtbox = new System.Windows.Forms.TextBox();
            this.n2_lbl = new System.Windows.Forms.Label();
            this.n3_txtbox = new System.Windows.Forms.TextBox();
            this.n3_lbl = new System.Windows.Forms.Label();
            this.n4_txtbox = new System.Windows.Forms.TextBox();
            this.n4_lbl = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.mdf_txtbox = new System.Windows.Forms.TextBox();
            this.md_lbl = new System.Windows.Forms.Label();
            this.situacao_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nmaluno_lbl
            // 
            this.nmaluno_lbl.Location = new System.Drawing.Point(86, 9);
            this.nmaluno_lbl.Name = "nmaluno_lbl";
            this.nmaluno_lbl.Size = new System.Drawing.Size(99, 13);
            this.nmaluno_lbl.TabIndex = 0;
            this.nmaluno_lbl.Text = "Nome do Aluno:";
            this.nmaluno_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.nmaluno_lbl.Click += new System.EventHandler(this.nmaluno_lbl_Click);
            // 
            // nmaluno_txtbox
            // 
            this.nmaluno_txtbox.Location = new System.Drawing.Point(43, 25);
            this.nmaluno_txtbox.Name = "nmaluno_txtbox";
            this.nmaluno_txtbox.Size = new System.Drawing.Size(195, 20);
            this.nmaluno_txtbox.TabIndex = 1;
            this.nmaluno_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // n1_lbl
            // 
            this.n1_lbl.AutoSize = true;
            this.n1_lbl.Location = new System.Drawing.Point(41, 90);
            this.n1_lbl.Name = "n1_lbl";
            this.n1_lbl.Size = new System.Drawing.Size(46, 13);
            this.n1_lbl.TabIndex = 2;
            this.n1_lbl.Text = "1ª Nota:";
            this.n1_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // n1_txtbox
            // 
            this.n1_txtbox.Location = new System.Drawing.Point(43, 107);
            this.n1_txtbox.Name = "n1_txtbox";
            this.n1_txtbox.Size = new System.Drawing.Size(43, 20);
            this.n1_txtbox.TabIndex = 3;
            this.n1_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // n2_txtbox
            // 
            this.n2_txtbox.Location = new System.Drawing.Point(97, 107);
            this.n2_txtbox.Name = "n2_txtbox";
            this.n2_txtbox.Size = new System.Drawing.Size(43, 20);
            this.n2_txtbox.TabIndex = 5;
            this.n2_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // n2_lbl
            // 
            this.n2_lbl.AutoSize = true;
            this.n2_lbl.Location = new System.Drawing.Point(95, 90);
            this.n2_lbl.Name = "n2_lbl";
            this.n2_lbl.Size = new System.Drawing.Size(46, 13);
            this.n2_lbl.TabIndex = 4;
            this.n2_lbl.Text = "2ª Nota:";
            // 
            // n3_txtbox
            // 
            this.n3_txtbox.Location = new System.Drawing.Point(146, 107);
            this.n3_txtbox.Name = "n3_txtbox";
            this.n3_txtbox.Size = new System.Drawing.Size(43, 20);
            this.n3_txtbox.TabIndex = 7;
            this.n3_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // n3_lbl
            // 
            this.n3_lbl.AutoSize = true;
            this.n3_lbl.Location = new System.Drawing.Point(144, 90);
            this.n3_lbl.Name = "n3_lbl";
            this.n3_lbl.Size = new System.Drawing.Size(46, 13);
            this.n3_lbl.TabIndex = 6;
            this.n3_lbl.Text = "3ª Nota:";
            // 
            // n4_txtbox
            // 
            this.n4_txtbox.Location = new System.Drawing.Point(195, 107);
            this.n4_txtbox.Name = "n4_txtbox";
            this.n4_txtbox.Size = new System.Drawing.Size(43, 20);
            this.n4_txtbox.TabIndex = 9;
            this.n4_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // n4_lbl
            // 
            this.n4_lbl.AutoSize = true;
            this.n4_lbl.Location = new System.Drawing.Point(193, 90);
            this.n4_lbl.Name = "n4_lbl";
            this.n4_lbl.Size = new System.Drawing.Size(46, 13);
            this.n4_lbl.TabIndex = 8;
            this.n4_lbl.Text = "4ª Nota:";
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(102, 143);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(75, 23);
            this.btn_calc.TabIndex = 10;
            this.btn_calc.Text = "Calcular";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // mdf_txtbox
            // 
            this.mdf_txtbox.Location = new System.Drawing.Point(43, 209);
            this.mdf_txtbox.Name = "mdf_txtbox";
            this.mdf_txtbox.Size = new System.Drawing.Size(195, 20);
            this.mdf_txtbox.TabIndex = 11;
            this.mdf_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mdf_txtbox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // md_lbl
            // 
            this.md_lbl.Location = new System.Drawing.Point(41, 189);
            this.md_lbl.Name = "md_lbl";
            this.md_lbl.Size = new System.Drawing.Size(197, 17);
            this.md_lbl.TabIndex = 12;
            this.md_lbl.Text = "Média Final:";
            this.md_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.md_lbl.Click += new System.EventHandler(this.md_lbl_Click);
            // 
            // situacao_lbl
            // 
            this.situacao_lbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.situacao_lbl.ForeColor = System.Drawing.Color.RosyBrown;
            this.situacao_lbl.Location = new System.Drawing.Point(12, 232);
            this.situacao_lbl.Name = "situacao_lbl";
            this.situacao_lbl.Size = new System.Drawing.Size(260, 21);
            this.situacao_lbl.TabIndex = 13;
            this.situacao_lbl.Text = " ";
            this.situacao_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.situacao_lbl);
            this.Controls.Add(this.md_lbl);
            this.Controls.Add(this.mdf_txtbox);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.n4_txtbox);
            this.Controls.Add(this.n4_lbl);
            this.Controls.Add(this.n3_txtbox);
            this.Controls.Add(this.n3_lbl);
            this.Controls.Add(this.n2_txtbox);
            this.Controls.Add(this.n2_lbl);
            this.Controls.Add(this.n1_txtbox);
            this.Controls.Add(this.n1_lbl);
            this.Controls.Add(this.nmaluno_txtbox);
            this.Controls.Add(this.nmaluno_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cálculo de Média";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nmaluno_lbl;
        private System.Windows.Forms.TextBox nmaluno_txtbox;
        private System.Windows.Forms.Label n1_lbl;
        private System.Windows.Forms.TextBox n1_txtbox;
        private System.Windows.Forms.TextBox n2_txtbox;
        private System.Windows.Forms.Label n2_lbl;
        private System.Windows.Forms.TextBox n3_txtbox;
        private System.Windows.Forms.Label n3_lbl;
        private System.Windows.Forms.TextBox n4_txtbox;
        private System.Windows.Forms.Label n4_lbl;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.TextBox mdf_txtbox;
        private System.Windows.Forms.Label md_lbl;
        private System.Windows.Forms.Label situacao_lbl;
    }
}

