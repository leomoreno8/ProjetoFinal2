using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetoFinal
{
    public partial class Login : Form
    {
        // DBConnect dBcon = new DBConnect();
        public Login()
        {
            InitializeComponent();
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Indigo;
        }

        private void label_exit_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string usuario = textBox_usuario.Text;
            string senha = textBox_senha.Text;

            string UsuarioIdBusca = "";
            string NomeBusca = "";
            string LoginBusca = "";
            string SenhaBusca = "";

            DataRow[] oDataRow = pDVDataSet1.Tables["Usuario"].Select("Login = '" + usuario + "' and Senha = '" + senha + "'");
            
            if (oDataRow.Length > 0)
            {
                foreach (DataRow dr in oDataRow)
                {
                    UsuarioIdBusca = dr[0].ToString();
                    NomeBusca = dr["Nome"].ToString();
                    LoginBusca = dr[2].ToString();
                    SenhaBusca = dr[3].ToString();
                }

                Menu menu = new Menu(NomeBusca, UsuarioIdBusca);
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha Incorreta");
            }

        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pDVDataSet1);

        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'pDVDataSet1.Usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter.Fill(this.pDVDataSet1.Usuario);

        }

    }
}
