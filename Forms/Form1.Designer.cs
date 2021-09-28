
namespace CalculadoraIMC
{
    partial class frmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcularIMC = new System.Windows.Forms.Button();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.btnZerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResultIMC = new System.Windows.Forms.TextBox();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcularIMC
            // 
            this.btnCalcularIMC.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCalcularIMC.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnCalcularIMC.Location = new System.Drawing.Point(84, 227);
            this.btnCalcularIMC.Name = "btnCalcularIMC";
            this.btnCalcularIMC.Size = new System.Drawing.Size(123, 71);
            this.btnCalcularIMC.TabIndex = 2;
            this.btnCalcularIMC.Text = "Calcular";
            this.btnCalcularIMC.UseVisualStyleBackColor = false;
            this.btnCalcularIMC.Click += new System.EventHandler(this.btnCalcularIMC_Click);
            // 
            // lblAltura
            // 
            this.lblAltura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(84, 21);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(95, 15);
            this.lblAltura.TabIndex = 1;
            this.lblAltura.Text = "Insira sua altura: ";
            this.lblAltura.UseWaitCursor = true;
            this.lblAltura.Click += new System.EventHandler(this.lblAltura_Click);
            // 
            // txtAltura
            // 
            this.txtAltura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAltura.Location = new System.Drawing.Point(84, 54);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(108, 23);
            this.txtAltura.TabIndex = 0;
            this.txtAltura.TextChanged += new System.EventHandler(this.txtAltura_TextChanged);
            // 
            // lblPeso
            // 
            this.lblPeso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(231, 21);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(87, 15);
            this.lblPeso.TabIndex = 1;
            this.lblPeso.Text = "Insira seu peso:";
            this.lblPeso.UseWaitCursor = true;
            this.lblPeso.Click += new System.EventHandler(this.lblPeso_Click);
            // 
            // txtPeso
            // 
            this.txtPeso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPeso.Location = new System.Drawing.Point(231, 54);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(108, 23);
            this.txtPeso.TabIndex = 1;
            this.txtPeso.TextChanged += new System.EventHandler(this.txtPeso_TextChanged);
            // 
            // btnZerar
            // 
            this.btnZerar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnZerar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnZerar.Location = new System.Drawing.Point(231, 227);
            this.btnZerar.Name = "btnZerar";
            this.btnZerar.Size = new System.Drawing.Size(123, 71);
            this.btnZerar.TabIndex = 3;
            this.btnZerar.Text = "Zerar";
            this.btnZerar.UseVisualStyleBackColor = false;
            this.btnZerar.Click += new System.EventHandler(this.btnZerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seu IMC é: ";
            // 
            // txtResultIMC
            // 
            this.txtResultIMC.Location = new System.Drawing.Point(147, 152);
            this.txtResultIMC.Name = "txtResultIMC";
            this.txtResultIMC.Size = new System.Drawing.Size(149, 23);
            this.txtResultIMC.TabIndex = 0;
            this.txtResultIMC.TabStop = false;
            // 
            // txtIMC
            // 
            this.txtIMC.Location = new System.Drawing.Point(147, 123);
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.Size = new System.Drawing.Size(86, 23);
            this.txtIMC.TabIndex = 4;
            this.txtIMC.TabStop = false;
            this.txtIMC.TextChanged += new System.EventHandler(this.txtIMC_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Você está: ";
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(412, 324);
            this.Controls.Add(this.txtIMC);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtResultIMC);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.btnZerar);
            this.Controls.Add(this.btnCalcularIMC);
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularIMC;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Button btnZerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResultIMC;
        private System.Windows.Forms.TextBox txtIMC;
        private System.Windows.Forms.Label label2;
    }
}

