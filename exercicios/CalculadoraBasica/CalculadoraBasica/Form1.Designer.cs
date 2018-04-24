namespace CalculadoraBasica
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
            this.vl1_lbl = new System.Windows.Forms.Label();
            this.nm1_txtbox = new System.Windows.Forms.TextBox();
            this.nm2_txtbox = new System.Windows.Forms.TextBox();
            this.vl2_lbl = new System.Windows.Forms.Label();
            this.resultado_txtbox = new System.Windows.Forms.TextBox();
            this.result_lbl = new System.Windows.Forms.Label();
            this.btn_soma = new System.Windows.Forms.Button();
            this.btn_subtrair = new System.Windows.Forms.Button();
            this.btn_multiplicar = new System.Windows.Forms.Button();
            this.btn_dividir = new System.Windows.Forms.Button();
            this.credits_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vl1_lbl
            // 
            this.vl1_lbl.AutoSize = true;
            this.vl1_lbl.Location = new System.Drawing.Point(125, 22);
            this.vl1_lbl.Name = "vl1_lbl";
            this.vl1_lbl.Size = new System.Drawing.Size(43, 13);
            this.vl1_lbl.TabIndex = 0;
            this.vl1_lbl.Text = "Valor 1:";
            this.vl1_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // nm1_txtbox
            // 
            this.nm1_txtbox.Location = new System.Drawing.Point(106, 38);
            this.nm1_txtbox.Name = "nm1_txtbox";
            this.nm1_txtbox.Size = new System.Drawing.Size(81, 20);
            this.nm1_txtbox.TabIndex = 1;
            this.nm1_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nm2_txtbox
            // 
            this.nm2_txtbox.Location = new System.Drawing.Point(106, 89);
            this.nm2_txtbox.Name = "nm2_txtbox";
            this.nm2_txtbox.Size = new System.Drawing.Size(81, 20);
            this.nm2_txtbox.TabIndex = 3;
            this.nm2_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nm2_txtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // vl2_lbl
            // 
            this.vl2_lbl.AutoSize = true;
            this.vl2_lbl.Location = new System.Drawing.Point(125, 73);
            this.vl2_lbl.Name = "vl2_lbl";
            this.vl2_lbl.Size = new System.Drawing.Size(43, 13);
            this.vl2_lbl.TabIndex = 2;
            this.vl2_lbl.Text = "Valor 2:";
            this.vl2_lbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // resultado_txtbox
            // 
            this.resultado_txtbox.Location = new System.Drawing.Point(15, 209);
            this.resultado_txtbox.Name = "resultado_txtbox";
            this.resultado_txtbox.Size = new System.Drawing.Size(257, 20);
            this.resultado_txtbox.TabIndex = 4;
            this.resultado_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // result_lbl
            // 
            this.result_lbl.AutoSize = true;
            this.result_lbl.Location = new System.Drawing.Point(110, 193);
            this.result_lbl.Name = "result_lbl";
            this.result_lbl.Size = new System.Drawing.Size(58, 13);
            this.result_lbl.TabIndex = 5;
            this.result_lbl.Text = "Resultado:";
            // 
            // btn_soma
            // 
            this.btn_soma.Location = new System.Drawing.Point(28, 133);
            this.btn_soma.Name = "btn_soma";
            this.btn_soma.Size = new System.Drawing.Size(52, 24);
            this.btn_soma.TabIndex = 6;
            this.btn_soma.Text = "Somar";
            this.btn_soma.UseVisualStyleBackColor = true;
            this.btn_soma.Click += new System.EventHandler(this.btn_soma_Click);
            // 
            // btn_subtrair
            // 
            this.btn_subtrair.Location = new System.Drawing.Point(86, 133);
            this.btn_subtrair.Name = "btn_subtrair";
            this.btn_subtrair.Size = new System.Drawing.Size(52, 24);
            this.btn_subtrair.TabIndex = 7;
            this.btn_subtrair.Text = "Subtrair";
            this.btn_subtrair.UseVisualStyleBackColor = true;
            this.btn_subtrair.Click += new System.EventHandler(this.btn_subtrair_Click);
            // 
            // btn_multiplicar
            // 
            this.btn_multiplicar.Location = new System.Drawing.Point(144, 133);
            this.btn_multiplicar.Name = "btn_multiplicar";
            this.btn_multiplicar.Size = new System.Drawing.Size(52, 24);
            this.btn_multiplicar.TabIndex = 8;
            this.btn_multiplicar.Text = "Multiplicar";
            this.btn_multiplicar.UseVisualStyleBackColor = true;
            this.btn_multiplicar.Click += new System.EventHandler(this.btn_multiplicacao_Click);
            // 
            // btn_dividir
            // 
            this.btn_dividir.Location = new System.Drawing.Point(202, 133);
            this.btn_dividir.Name = "btn_dividir";
            this.btn_dividir.Size = new System.Drawing.Size(52, 24);
            this.btn_dividir.TabIndex = 9;
            this.btn_dividir.Text = "Dividir";
            this.btn_dividir.UseVisualStyleBackColor = true;
            this.btn_dividir.Click += new System.EventHandler(this.btn_dividir_Click);
            // 
            // credits_lbl
            // 
            this.credits_lbl.AutoSize = true;
            this.credits_lbl.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credits_lbl.Location = new System.Drawing.Point(217, 239);
            this.credits_lbl.Name = "credits_lbl";
            this.credits_lbl.Size = new System.Drawing.Size(55, 14);
            this.credits_lbl.TabIndex = 10;
            this.credits_lbl.Text = "V N C S 7";
            this.credits_lbl.Click += new System.EventHandler(this.credits_lbl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.credits_lbl);
            this.Controls.Add(this.btn_dividir);
            this.Controls.Add(this.btn_multiplicar);
            this.Controls.Add(this.btn_subtrair);
            this.Controls.Add(this.btn_soma);
            this.Controls.Add(this.result_lbl);
            this.Controls.Add(this.resultado_txtbox);
            this.Controls.Add(this.nm2_txtbox);
            this.Controls.Add(this.vl2_lbl);
            this.Controls.Add(this.nm1_txtbox);
            this.Controls.Add(this.vl1_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Básica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vl1_lbl;
        private System.Windows.Forms.TextBox nm1_txtbox;
        private System.Windows.Forms.TextBox nm2_txtbox;
        private System.Windows.Forms.Label vl2_lbl;
        private System.Windows.Forms.TextBox resultado_txtbox;
        private System.Windows.Forms.Label result_lbl;
        private System.Windows.Forms.Button btn_soma;
        private System.Windows.Forms.Button btn_subtrair;
        private System.Windows.Forms.Button btn_multiplicar;
        private System.Windows.Forms.Button btn_dividir;
        private System.Windows.Forms.Label credits_lbl;
    }
}

