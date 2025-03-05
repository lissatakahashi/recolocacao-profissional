namespace WindowsApp
{
    partial class Inicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicial));
            this.btLoginCandidatos = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.picSelecao = new System.Windows.Forms.PictureBox();
            this.btLoginEmpresas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSelecao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btLoginCandidatos
            // 
            this.btLoginCandidatos.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btLoginCandidatos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btLoginCandidatos.Location = new System.Drawing.Point(446, 0);
            this.btLoginCandidatos.Name = "btLoginCandidatos";
            this.btLoginCandidatos.Size = new System.Drawing.Size(174, 45);
            this.btLoginCandidatos.TabIndex = 0;
            this.btLoginCandidatos.Text = "Login para candidatos";
            this.btLoginCandidatos.UseVisualStyleBackColor = false;
            this.btLoginCandidatos.Click += new System.EventHandler(this.btLoginCandidatos_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.SteelBlue;
            this.btCadastrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btCadastrar.Location = new System.Drawing.Point(76, 356);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(204, 73);
            this.btCadastrar.TabIndex = 1;
            this.btCadastrar.Text = "Cadastre-se agora!";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // picSelecao
            // 
            this.picSelecao.Image = ((System.Drawing.Image)(resources.GetObject("picSelecao.Image")));
            this.picSelecao.Location = new System.Drawing.Point(-6, 0);
            this.picSelecao.Name = "picSelecao";
            this.picSelecao.Size = new System.Drawing.Size(806, 453);
            this.picSelecao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSelecao.TabIndex = 2;
            this.picSelecao.TabStop = false;
            // 
            // btLoginEmpresas
            // 
            this.btLoginEmpresas.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btLoginEmpresas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btLoginEmpresas.Location = new System.Drawing.Point(626, 0);
            this.btLoginEmpresas.Name = "btLoginEmpresas";
            this.btLoginEmpresas.Size = new System.Drawing.Size(174, 45);
            this.btLoginEmpresas.TabIndex = 4;
            this.btLoginEmpresas.Text = "Login para empresa";
            this.btLoginEmpresas.UseVisualStyleBackColor = false;
            this.btLoginEmpresas.Click += new System.EventHandler(this.btLoginEmpresas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btLoginEmpresas);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.btLoginCandidatos);
            this.Controls.Add(this.picSelecao);
            this.Name = "Inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicial";
            ((System.ComponentModel.ISupportInitialize)(this.picSelecao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btLoginCandidatos;
        private Button btCadastrar;
        private PictureBox picSelecao;
        private Button btLoginEmpresas;
        private PictureBox pictureBox1;
    }
}