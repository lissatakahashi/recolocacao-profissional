namespace WindowsApp
{
    partial class LoginEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginEmpresa));
            this.label3 = new System.Windows.Forms.Label();
            this.tbLoginSenhaEmpresa = new System.Windows.Forms.TextBox();
            this.tbLoginEmailEmpresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btEntrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 35);
            this.label3.TabIndex = 10;
            this.label3.Text = "Login da Empresa";
            // 
            // tbLoginSenhaEmpresa
            // 
            this.tbLoginSenhaEmpresa.Location = new System.Drawing.Point(278, 214);
            this.tbLoginSenhaEmpresa.Name = "tbLoginSenhaEmpresa";
            this.tbLoginSenhaEmpresa.Size = new System.Drawing.Size(286, 27);
            this.tbLoginSenhaEmpresa.TabIndex = 9;
            this.tbLoginSenhaEmpresa.UseSystemPasswordChar = true;
            // 
            // tbLoginEmailEmpresa
            // 
            this.tbLoginEmailEmpresa.Location = new System.Drawing.Point(278, 138);
            this.tbLoginEmailEmpresa.Name = "tbLoginEmailEmpresa";
            this.tbLoginEmailEmpresa.Size = new System.Drawing.Size(286, 27);
            this.tbLoginEmailEmpresa.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(278, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(278, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "E-mail:";
            // 
            // btEntrar
            // 
            this.btEntrar.Location = new System.Drawing.Point(436, 267);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(128, 36);
            this.btEntrar.TabIndex = 11;
            this.btEntrar.Text = "Entrar";
            this.btEntrar.UseVisualStyleBackColor = true;
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // LoginEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(598, 322);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btEntrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLoginSenhaEmpresa);
            this.Controls.Add(this.tbLoginEmailEmpresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginEmpresa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private TextBox tbLoginSenhaEmpresa;
        private TextBox tbLoginEmailEmpresa;
        private Label label2;
        private Label label1;
        private Button btEntrar;
        private PictureBox pictureBox1;
    }
}