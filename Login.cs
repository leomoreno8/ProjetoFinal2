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
            Espera espera = new Espera();
            espera.Show();
            this.Hide();

            //DataRow foundRow = PDVDataSet1.Usuario["AnyTable"].Rows.Find(s);
            
            // var db = this.PDVDataSet11
            // string selectQuery = "SELECT * FROM Usuario WHERE Login='" + textBox_usuario.Text + "' AND Senha='" + textBox_senha.Text + "'";
            // DataTable TABLE = new DataTable();
            // SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, dBCon.GetCon());
            // adapter.Fill(table);
        }
    }
}
