namespace Mini_Calculadora
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txbNum1 = new System.Windows.Forms.TextBox();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.txbNum2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txbResultado = new System.Windows.Forms.TextBox();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txbNum1
            // 
            resources.ApplyResources(this.txbNum1, "txbNum1");
            this.txbNum1.Name = "txbNum1";
            this.txbNum1.TextChanged += new System.EventHandler(this.txbNum1_TextChanged);
            this.txbNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNum1_KeyPress);
            // 
            // lblNum1
            // 
            resources.ApplyResources(this.lblNum1, "lblNum1");
            this.lblNum1.Name = "lblNum1";
            // 
            // lblNum2
            // 
            resources.ApplyResources(this.lblNum2, "lblNum2");
            this.lblNum2.Name = "lblNum2";
            // 
            // txbNum2
            // 
            resources.ApplyResources(this.txbNum2, "txbNum2");
            this.txbNum2.Name = "txbNum2";
            this.txbNum2.TextChanged += new System.EventHandler(this.txbNum2_TextChanged);
            this.txbNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNum2_KeyPress);
            // 
            // lblResultado
            // 
            resources.ApplyResources(this.lblResultado, "lblResultado");
            this.lblResultado.Name = "lblResultado";
            // 
            // txbResultado
            // 
            this.txbResultado.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.txbResultado, "txbResultado");
            this.txbResultado.Name = "txbResultado";
            this.txbResultado.ReadOnly = true;
            // 
            // btnMais
            // 
            resources.ApplyResources(this.btnMais, "btnMais");
            this.btnMais.Name = "btnMais";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // btnMenos
            // 
            resources.ApplyResources(this.btnMenos, "btnMenos");
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnMultiplicar
            // 
            resources.ApplyResources(this.btnMultiplicar, "btnMultiplicar");
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnLimpar
            // 
            resources.ApplyResources(this.btnLimpar, "btnLimpar");
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnDivisao
            // 
            resources.ApplyResources(this.btnDivisao, "btnDivisao");
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnSair
            // 
            resources.ApplyResources(this.btnSair, "btnSair");
            this.btnSair.Name = "btnSair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Name = "dateTimePicker1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txbResultado);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.txbNum2);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.txbNum1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbNum1;
        private Label lblNum1;
        private Label lblNum2;
        private TextBox txbNum2;
        private Label lblResultado;
        private TextBox txbResultado;
        private Button btnMais;
        private Button btnMenos;
        private Button btnMultiplicar;
        private Button btnLimpar;
        private Button btnDivisao;
        private Button btnSair;
        private Label label1;
        private DateTimePicker dateTimePicker1;
    }
}