namespace modelo_login_csharp
{
    partial class form_login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.titulo = new System.Windows.Forms.Label();
            this.senha = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.titulo.Location = new System.Drawing.Point(54, 9);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(165, 26);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Acesso Restrito";
            // 
            // senha
            // 
            this.senha.AutoSize = true;
            this.senha.Location = new System.Drawing.Point(25, 126);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(38, 13);
            this.senha.TabIndex = 1;
            this.senha.Text = "Senha";
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Location = new System.Drawing.Point(25, 87);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(43, 13);
            this.usuario.TabIndex = 2;
            this.usuario.Text = "Usuário";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(75, 80);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(166, 20);
            this.txt_usuario.TabIndex = 3;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(72, 119);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(169, 20);
            this.txt_senha.TabIndex = 4;
            // 
            // btn_login
            // 
            this.btn_login.AutoSize = true;
            this.btn_login.Location = new System.Drawing.Point(28, 186);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Acessar";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSize = true;
            this.btn_cancel.Location = new System.Drawing.Point(182, 186);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(59, 23);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.titulo);
            this.Name = "form_login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label senha;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_cancel;
    }
}

