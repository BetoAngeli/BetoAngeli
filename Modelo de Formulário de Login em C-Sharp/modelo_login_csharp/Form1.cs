using System;
using System.Windows.Forms;

namespace modelo_login_csharp
{
    public partial class form_login : Form
    {
        public form_login()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string user;
            string usercorreto="admin";
            string passcorreto="admin";
            string pass;
            user = txt_usuario.Text ;
            pass = txt_senha.Text;
            if (user == usercorreto)
            {
                if (pass == passcorreto)
                {
                    MessageBox.Show("Parabéns, você conseguiu acessar", "PARABÉNS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_usuario.Text = "";
                    txt_senha.Text = "";
                    txt_usuario.Focus();
                }else
                {
                    MessageBox.Show("Senha incorreta!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_senha.Text = "";
                    txt_senha.Focus();
                }
            }else
            {
                MessageBox.Show("Usuário inválido", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_usuario.Text = "";
                txt_senha.Text = "";
                txt_usuario.Focus();
            }
        }
    }
}
