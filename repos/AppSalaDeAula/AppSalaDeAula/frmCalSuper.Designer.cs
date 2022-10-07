namespace AppSalaDeAula
{
    partial class frmCalSuper
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalSuper));
            this.lblVisor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnInvertSinal = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnDivisão = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVisor
            // 
            this.lblVisor.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblVisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisor.Location = new System.Drawing.Point(12, 20);
            this.lblVisor.Name = "lblVisor";
            this.lblVisor.Size = new System.Drawing.Size(370, 50);
            this.lblVisor.TabIndex = 0;
            this.lblVisor.Text = "0";
            this.lblVisor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblVisor.Click += new System.EventHandler(this.LblVisor_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btnInvertSinal);
            this.panel1.Controls.Add(this.btn0);
            this.panel1.Controls.Add(this.btnVirgula);
            this.panel1.Location = new System.Drawing.Point(12, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 293);
            this.panel1.TabIndex = 1;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(95, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(105, 30);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.TabStop = false;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btn7
            // 
            this.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn7.FlatAppearance.BorderSize = 2;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(26, 47);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(57, 30);
            this.btn7.TabIndex = 11;
            this.btn7.TabStop = false;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.f_Botoes);
            // 
            // btn8
            // 
            this.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn8.FlatAppearance.BorderSize = 2;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(120, 47);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(57, 30);
            this.btn8.TabIndex = 10;
            this.btn8.TabStop = false;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.f_Botoes);
            // 
            // btn9
            // 
            this.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn9.FlatAppearance.BorderSize = 2;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(207, 47);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(57, 30);
            this.btn9.TabIndex = 9;
            this.btn9.TabStop = false;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.f_Botoes);
            // 
            // btn4
            // 
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn4.FlatAppearance.BorderSize = 2;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(26, 115);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(57, 30);
            this.btn4.TabIndex = 8;
            this.btn4.TabStop = false;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.f_Botoes);
            // 
            // btn5
            // 
            this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn5.FlatAppearance.BorderSize = 2;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(120, 115);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(57, 30);
            this.btn5.TabIndex = 7;
            this.btn5.TabStop = false;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.f_Botoes);
            // 
            // btn6
            // 
            this.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn6.FlatAppearance.BorderSize = 2;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(207, 115);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(57, 30);
            this.btn6.TabIndex = 6;
            this.btn6.TabStop = false;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.f_Botoes);
            // 
            // btn1
            // 
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn1.FlatAppearance.BorderSize = 2;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(26, 186);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(57, 30);
            this.btn1.TabIndex = 5;
            this.btn1.TabStop = false;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.f_Botoes);
            // 
            // btn2
            // 
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn2.FlatAppearance.BorderSize = 2;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(120, 186);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(57, 30);
            this.btn2.TabIndex = 4;
            this.btn2.TabStop = false;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.f_Botoes);
            // 
            // btn3
            // 
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn3.FlatAppearance.BorderSize = 2;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(207, 186);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(57, 30);
            this.btn3.TabIndex = 3;
            this.btn3.TabStop = false;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.f_Botoes);
            // 
            // btnInvertSinal
            // 
            this.btnInvertSinal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInvertSinal.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInvertSinal.FlatAppearance.BorderSize = 2;
            this.btnInvertSinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvertSinal.Location = new System.Drawing.Point(26, 257);
            this.btnInvertSinal.Name = "btnInvertSinal";
            this.btnInvertSinal.Size = new System.Drawing.Size(57, 30);
            this.btnInvertSinal.TabIndex = 2;
            this.btnInvertSinal.TabStop = false;
            this.btnInvertSinal.Text = "+/-";
            this.btnInvertSinal.UseVisualStyleBackColor = true;
            this.btnInvertSinal.Click += new System.EventHandler(this.BtnInvertSinal_Click);
            // 
            // btn0
            // 
            this.btn0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn0.FlatAppearance.BorderSize = 2;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(120, 257);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(57, 30);
            this.btn0.TabIndex = 1;
            this.btn0.TabStop = false;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.f_Botoes);
            // 
            // btnVirgula
            // 
            this.btnVirgula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVirgula.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVirgula.FlatAppearance.BorderSize = 2;
            this.btnVirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirgula.Location = new System.Drawing.Point(207, 257);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(57, 30);
            this.btnVirgula.TabIndex = 0;
            this.btnVirgula.TabStop = false;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = true;
            this.btnVirgula.Click += new System.EventHandler(this.f_Botoes);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnIgual);
            this.panel2.Controls.Add(this.btnDivisão);
            this.panel2.Controls.Add(this.btnX);
            this.panel2.Controls.Add(this.btnMenos);
            this.panel2.Controls.Add(this.btnMais);
            this.panel2.Location = new System.Drawing.Point(296, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(86, 293);
            this.panel2.TabIndex = 2;
            // 
            // btnIgual
            // 
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(15, 253);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(57, 30);
            this.btnIgual.TabIndex = 16;
            this.btnIgual.TabStop = false;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.BtnIgual_Click);
            // 
            // btnDivisão
            // 
            this.btnDivisão.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisão.Location = new System.Drawing.Point(15, 202);
            this.btnDivisão.Name = "btnDivisão";
            this.btnDivisão.Size = new System.Drawing.Size(57, 30);
            this.btnDivisão.TabIndex = 15;
            this.btnDivisão.TabStop = false;
            this.btnDivisão.Text = "/";
            this.btnDivisão.UseVisualStyleBackColor = true;
            this.btnDivisão.Click += new System.EventHandler(this.f_Op);
            // 
            // btnX
            // 
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Location = new System.Drawing.Point(15, 142);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(57, 30);
            this.btnX.TabIndex = 14;
            this.btnX.TabStop = false;
            this.btnX.Text = "x";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.f_Op);
            // 
            // btnMenos
            // 
            this.btnMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.Location = new System.Drawing.Point(15, 86);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(57, 30);
            this.btnMenos.TabIndex = 13;
            this.btnMenos.TabStop = false;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.f_Op);
            // 
            // btnMais
            // 
            this.btnMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMais.Location = new System.Drawing.Point(15, 42);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(57, 30);
            this.btnMais.TabIndex = 12;
            this.btnMais.TabStop = false;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.f_Op);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(311, 92);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(57, 30);
            this.btnBack.TabIndex = 18;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "<==";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(13, 92);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(13, 13);
            this.lbl1.TabIndex = 19;
            this.lbl1.Text = "0";
            this.lbl1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // frmCalSuper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 454);
            this.ControlBox = false;
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblVisor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmCalSuper";
            this.Text = "  Calculadora";
            this.Load += new System.EventHandler(this.FrmCalSuper_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCalSuper_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVisor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnInvertSinal;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnDivisão;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lbl1;
    }
}

