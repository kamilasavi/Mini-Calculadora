namespace Mini_Calculadora
{
    partial class Form2
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
            this.btnUm = new System.Windows.Forms.Button();
            this.txbVisor = new System.Windows.Forms.TextBox();
            this.btnDois = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUm
            // 
            this.btnUm.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUm.Location = new System.Drawing.Point(192, 231);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(55, 42);
            this.btnUm.TabIndex = 0;
            this.btnUm.Text = "1";
            this.btnUm.UseVisualStyleBackColor = true;
            this.btnUm.Click += new System.EventHandler(this.btnUm_Click);
            // 
            // txbVisor
            // 
            this.txbVisor.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbVisor.Location = new System.Drawing.Point(192, 144);
            this.txbVisor.Name = "txbVisor";
            this.txbVisor.Size = new System.Drawing.Size(186, 43);
            this.txbVisor.TabIndex = 1;
            this.txbVisor.TextChanged += new System.EventHandler(this.txbVisor_TextChanged);
            // 
            // btnDois
            // 
            this.btnDois.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDois.Location = new System.Drawing.Point(323, 231);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(55, 42);
            this.btnDois.TabIndex = 2;
            this.btnDois.Text = "2";
            this.btnDois.UseVisualStyleBackColor = true;
            this.btnDois.Click += new System.EventHandler(this.btnDois_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDois);
            this.Controls.Add(this.txbVisor);
            this.Controls.Add(this.btnUm);
            this.Name = "Form2";
            this.Text = "Acumulativo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnUm;
        private TextBox txbVisor;
        private Button btnDois;
    }
}