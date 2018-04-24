namespace MaiorDeTres
{
    partial class frmMaiorValorDeTres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaiorValorDeTres));
            this.vla_lbl = new System.Windows.Forms.Label();
            this.vla_txtbox = new System.Windows.Forms.TextBox();
            this.vlb_txtbox = new System.Windows.Forms.TextBox();
            this.vlb_lbl = new System.Windows.Forms.Label();
            this.vlc_txtbox = new System.Windows.Forms.TextBox();
            this.vlc_lbl = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.maiorvalor_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vla_lbl
            // 
            this.vla_lbl.AutoSize = true;
            this.vla_lbl.Location = new System.Drawing.Point(54, 25);
            this.vla_lbl.Name = "vla_lbl";
            this.vla_lbl.Size = new System.Drawing.Size(44, 13);
            this.vla_lbl.TabIndex = 0;
            this.vla_lbl.Text = "Valor A:";
            // 
            // vla_txtbox
            // 
            this.vla_txtbox.Location = new System.Drawing.Point(104, 22);
            this.vla_txtbox.Name = "vla_txtbox";
            this.vla_txtbox.Size = new System.Drawing.Size(100, 20);
            this.vla_txtbox.TabIndex = 1;
            this.vla_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vlb_txtbox
            // 
            this.vlb_txtbox.Location = new System.Drawing.Point(104, 58);
            this.vlb_txtbox.Name = "vlb_txtbox";
            this.vlb_txtbox.Size = new System.Drawing.Size(100, 20);
            this.vlb_txtbox.TabIndex = 3;
            this.vlb_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vlb_lbl
            // 
            this.vlb_lbl.AutoSize = true;
            this.vlb_lbl.Location = new System.Drawing.Point(54, 61);
            this.vlb_lbl.Name = "vlb_lbl";
            this.vlb_lbl.Size = new System.Drawing.Size(44, 13);
            this.vlb_lbl.TabIndex = 2;
            this.vlb_lbl.Text = "Valor B:";
            // 
            // vlc_txtbox
            // 
            this.vlc_txtbox.Location = new System.Drawing.Point(104, 94);
            this.vlc_txtbox.Name = "vlc_txtbox";
            this.vlc_txtbox.Size = new System.Drawing.Size(100, 20);
            this.vlc_txtbox.TabIndex = 5;
            this.vlc_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vlc_lbl
            // 
            this.vlc_lbl.AutoSize = true;
            this.vlc_lbl.Location = new System.Drawing.Point(54, 97);
            this.vlc_lbl.Name = "vlc_lbl";
            this.vlc_lbl.Size = new System.Drawing.Size(44, 13);
            this.vlc_lbl.TabIndex = 4;
            this.vlc_lbl.Text = "Valor C:";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(104, 138);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 6;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // maiorvalor_lbl
            // 
            this.maiorvalor_lbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maiorvalor_lbl.Location = new System.Drawing.Point(12, 187);
            this.maiorvalor_lbl.Name = "maiorvalor_lbl";
            this.maiorvalor_lbl.Size = new System.Drawing.Size(260, 23);
            this.maiorvalor_lbl.TabIndex = 7;
            this.maiorvalor_lbl.Text = " ";
            this.maiorvalor_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMaiorValorDeTres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.maiorvalor_lbl);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.vlc_txtbox);
            this.Controls.Add(this.vlc_lbl);
            this.Controls.Add(this.vlb_txtbox);
            this.Controls.Add(this.vlb_lbl);
            this.Controls.Add(this.vla_txtbox);
            this.Controls.Add(this.vla_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMaiorValorDeTres";
            this.Text = "Maior Valor";
            this.Load += new System.EventHandler(this.frmMaiorValorDeTres_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vla_lbl;
        private System.Windows.Forms.TextBox vla_txtbox;
        private System.Windows.Forms.TextBox vlb_txtbox;
        private System.Windows.Forms.Label vlb_lbl;
        private System.Windows.Forms.TextBox vlc_txtbox;
        private System.Windows.Forms.Label vlc_lbl;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label maiorvalor_lbl;
    }
}

