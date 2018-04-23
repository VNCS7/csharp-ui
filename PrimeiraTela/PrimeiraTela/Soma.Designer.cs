namespace PrimeiraTela
{
    partial class Soma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Soma));
            this.nm1_lbl = new System.Windows.Forms.Label();
            this.nm1_txtbox = new System.Windows.Forms.TextBox();
            this.nm2_txtbox = new System.Windows.Forms.TextBox();
            this.nm2_lbl = new System.Windows.Forms.Label();
            this.btn_Somar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Resultado_txtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nm1_lbl
            // 
            this.nm1_lbl.AutoSize = true;
            this.nm1_lbl.Location = new System.Drawing.Point(13, 13);
            this.nm1_lbl.Name = "nm1_lbl";
            this.nm1_lbl.Size = new System.Drawing.Size(56, 13);
            this.nm1_lbl.TabIndex = 0;
            this.nm1_lbl.Text = "Número 1:";
            this.nm1_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // nm1_txtbox
            // 
            this.nm1_txtbox.Location = new System.Drawing.Point(16, 30);
            this.nm1_txtbox.Name = "nm1_txtbox";
            this.nm1_txtbox.Size = new System.Drawing.Size(138, 20);
            this.nm1_txtbox.TabIndex = 1;
            // 
            // nm2_txtbox
            // 
            this.nm2_txtbox.Location = new System.Drawing.Point(16, 70);
            this.nm2_txtbox.Name = "nm2_txtbox";
            this.nm2_txtbox.Size = new System.Drawing.Size(138, 20);
            this.nm2_txtbox.TabIndex = 3;
            // 
            // nm2_lbl
            // 
            this.nm2_lbl.AutoSize = true;
            this.nm2_lbl.Location = new System.Drawing.Point(13, 53);
            this.nm2_lbl.Name = "nm2_lbl";
            this.nm2_lbl.Size = new System.Drawing.Size(56, 13);
            this.nm2_lbl.TabIndex = 2;
            this.nm2_lbl.Text = "Número 1:";
            // 
            // btn_Somar
            // 
            this.btn_Somar.Location = new System.Drawing.Point(16, 97);
            this.btn_Somar.Name = "btn_Somar";
            this.btn_Somar.Size = new System.Drawing.Size(138, 23);
            this.btn_Somar.TabIndex = 4;
            this.btn_Somar.Text = "Somar";
            this.btn_Somar.UseVisualStyleBackColor = true;
            this.btn_Somar.Click += new System.EventHandler(this.btn_Somar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Resultado";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Resultado_txtbox
            // 
            this.Resultado_txtbox.Location = new System.Drawing.Point(16, 153);
            this.Resultado_txtbox.Name = "Resultado_txtbox";
            this.Resultado_txtbox.Size = new System.Drawing.Size(138, 20);
            this.Resultado_txtbox.TabIndex = 6;
            // 
            // Soma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 192);
            this.Controls.Add(this.Resultado_txtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Somar);
            this.Controls.Add(this.nm2_txtbox);
            this.Controls.Add(this.nm2_lbl);
            this.Controls.Add(this.nm1_txtbox);
            this.Controls.Add(this.nm1_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Soma";
            this.Text = "Somar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nm1_lbl;
        private System.Windows.Forms.TextBox nm1_txtbox;
        private System.Windows.Forms.TextBox nm2_txtbox;
        private System.Windows.Forms.Label nm2_lbl;
        private System.Windows.Forms.Button btn_Somar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Resultado_txtbox;
    }
}

