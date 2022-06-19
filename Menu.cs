using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal
{
    public partial class Menu : Form
    {
        public Menu(string nomeBusca)
        {
            InitializeComponent();
            nome_usuario.Text = nomeBusca;
        }

        private void itemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

    }
}
