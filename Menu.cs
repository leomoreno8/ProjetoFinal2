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
        Boolean ativo = false;
        public Menu(string nomeBusca)
        {
            InitializeComponent();
            nome_usuario.Text = nomeBusca;
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Menu_KeyDown);
        }

        private void itemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void itemBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.itemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pDVDataSet1);

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'pDVDataSet1.Item'. Você pode movê-la ou removê-la conforme necessário.
            this.itemTableAdapter.Fill(this.pDVDataSet1.Item);

        }

        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                input_codigo.Enabled = true;
                input_quantidade.Enabled = true;
                ativo = true;
            }
        }

        private void input_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void input_quantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
