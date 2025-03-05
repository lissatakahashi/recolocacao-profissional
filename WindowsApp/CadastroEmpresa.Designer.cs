namespace WindowsApp
{
    partial class CadastroEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroEmpresa));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNomeEmpresa = new System.Windows.Forms.TextBox();
            this.tbCNPJEmpresa = new System.Windows.Forms.TextBox();
            this.tbSenhaEmpresa = new System.Windows.Forms.TextBox();
            this.tbEmailEmpresa = new System.Windows.Forms.TextBox();
            this.btGravarEmpresa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(66, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o nome da empresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(66, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Informe o e-mail da empresa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(66, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Crie uma senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(66, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Informe o CNPJ:";
            // 
            // tbNomeEmpresa
            // 
            this.tbNomeEmpresa.Location = new System.Drawing.Point(66, 119);
            this.tbNomeEmpresa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNomeEmpresa.Name = "tbNomeEmpresa";
            this.tbNomeEmpresa.Size = new System.Drawing.Size(438, 27);
            this.tbNomeEmpresa.TabIndex = 0;
            // 
            // tbCNPJEmpresa
            // 
            this.tbCNPJEmpresa.Location = new System.Drawing.Point(66, 364);
            this.tbCNPJEmpresa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCNPJEmpresa.Name = "tbCNPJEmpresa";
            this.tbCNPJEmpresa.Size = new System.Drawing.Size(438, 27);
            this.tbCNPJEmpresa.TabIndex = 2;
            // 
            // tbSenhaEmpresa
            // 
            this.tbSenhaEmpresa.Location = new System.Drawing.Point(66, 473);
            this.tbSenhaEmpresa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSenhaEmpresa.Name = "tbSenhaEmpresa";
            this.tbSenhaEmpresa.Size = new System.Drawing.Size(438, 27);
            this.tbSenhaEmpresa.TabIndex = 3;
            this.tbSenhaEmpresa.UseSystemPasswordChar = true;
            // 
            // tbEmailEmpresa
            // 
            this.tbEmailEmpresa.Location = new System.Drawing.Point(66, 229);
            this.tbEmailEmpresa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEmailEmpresa.Name = "tbEmailEmpresa";
            this.tbEmailEmpresa.Size = new System.Drawing.Size(438, 27);
            this.tbEmailEmpresa.TabIndex = 1;
            // 
            // btGravarEmpresa
            // 
            this.btGravarEmpresa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btGravarEmpresa.Location = new System.Drawing.Point(673, 529);
            this.btGravarEmpresa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btGravarEmpresa.Name = "btGravarEmpresa";
            this.btGravarEmpresa.Size = new System.Drawing.Size(197, 43);
            this.btGravarEmpresa.TabIndex = 4;
            this.btGravarEmpresa.Text = "Gravar";
            this.btGravarEmpresa.UseVisualStyleBackColor = true;
            this.btGravarEmpresa.Click += new System.EventHandler(this.btGravarEmpresa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(606, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // CadastroEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btGravarEmpresa);
            this.Controls.Add(this.tbEmailEmpresa);
            this.Controls.Add(this.tbSenhaEmpresa);
            this.Controls.Add(this.tbCNPJEmpresa);
            this.Controls.Add(this.tbNomeEmpresa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CadastroEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroEmpresa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbNomeEmpresa;
        private TextBox tbCNPJEmpresa;
        private TextBox tbSenhaEmpresa;
        private TextBox tbEmailEmpresa;
        private Button btGravarEmpresa;
        private PictureBox pictureBox1;
    }
}