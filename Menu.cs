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
        decimal total = 0;
        string[] itens;
        public Menu(string nomeBusca)
        {
            InitializeComponent();
            nome_usuario.Text = nomeBusca;
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(Menu_KeyDown);
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
                // input_quantidade.Enabled = true;
                ativo = true;
                MessageBox.Show("Transação Habilitada");
            }

            if (e.KeyCode == Keys.F1)
            {
                if (ativo == true)
                {
                    if(input_codigo.Text != "" && input_quantidade.Text != "")
                    {
                        AddItem(input_codigo.Text, input_quantidade.Text);
                    } else {
                        MessageBox.Show("Código ou quantidade não preenchidos");
                    }
                } else {
                    MessageBox.Show("Transação desabilitada. Para habilitar, por favor pressione F12");
                }
            }


            if (e.KeyCode == Keys.F5)
            {
                if (ativo == true)
                {
                    if (list_itens.Text != "")
                    {
                        Extornar();
                    }
                    else
                    {
                        MessageBox.Show("Lista vazia! Não há o que extornar.");
                    }
                }
                else
                {
                    MessageBox.Show("Transação desabilitada. Para habilitar, por favor pressione F12");
                }
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

        private void input_codigo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(input_codigo.Text))
            {
                input_quantidade.Enabled = true;
                //input_quantidade.Focus();

                Search();
            } else {
                input_quantidade.Enabled = false;
                input_descricao.Text = "";
                input_preco.Text = "";
                input_quantidade.Text = "";
            }
        }

        private void Search()
        {

            string codInserido = input_codigo.Text;

            string CodigoItemBusca = "";
            string DescricaoBusca = "";
            string PrecoUnitBusca = "";

            DataRow[] oDataRow = pDVDataSet1.Tables["Item"].Select("Id = '" + codInserido + "'");

            if (oDataRow.Length > 0)
            {
                foreach (DataRow dr in oDataRow)
                {
                    CodigoItemBusca = dr[0].ToString();
                    DescricaoBusca = dr["Descricao"].ToString();
                    PrecoUnitBusca = dr[3].ToString();
                }

                input_descricao.Text = DescricaoBusca;
                input_preco.Text = PrecoUnitBusca;
                input_quantidade.Text = "1";
            } else {
                input_descricao.Text = "";
                input_preco.Text = "";
                input_quantidade.Text = "";
            }

        }

        private void AddItem(string codigo, string quantidade)
        {
            //throw new NotImplementedException();

            string CodigoItemBusca = "";
            string DescricaoBusca = "";
            string UnidadeBusca = "";
            string PrecoUnitBusca = "";
            string EstoqueInternoBusca = "";
            string EstoqueGondolaBusca = "";

            DataRow[] oDataRow = pDVDataSet1.Tables["Item"].Select("Id = '" + codigo + "'");

            if (oDataRow.Length > 0)
            {
                foreach (DataRow dr in oDataRow)
                {
                    CodigoItemBusca = dr[0].ToString();
                    DescricaoBusca = dr["Descricao"].ToString();
                    UnidadeBusca = dr[2].ToString();
                    PrecoUnitBusca = dr[3].ToString();
                    EstoqueInternoBusca = dr[4].ToString();
                    EstoqueGondolaBusca = dr[5].ToString();
                }

                decimal valorPreco = Convert.ToDecimal(PrecoUnitBusca);
                int valorQuantidade = Int32.Parse(quantidade);
                int valorGondola = Int32.Parse(EstoqueGondolaBusca);
                decimal valorTotal = valorPreco * valorQuantidade;
                //EstoqueGondolaBusca = (valorGondola - valorQuantidade);


                list_itens.Text += CodigoItemBusca + " " + DescricaoBusca + " " + quantidade + " x R$ " + PrecoUnitBusca + Environment.NewLine;
                text_operacao.Text += "+" + Environment.NewLine;
                list_totals.Text += valorTotal + Environment.NewLine;
                total += valorTotal;
                input_total.Text = total.ToString();
                total_geral.Text = "Total geral: R$" + total.ToString();
                
                // itens[Int32.Parse(CodigoItemBusca)] = new string[4] {CodigoItemBusca, DescricaoBusca, quantidade, PrecoUnitBusca };
                

            }
            else
            {
                MessageBox.Show("Produto não encontrato em nosso estoque");
            }
        }

        private void Extornar()
        {
            int i;
            text_operacao.Text = "";
            text_est.Text = "";
            total_geral.Text = "Total geral: R$ 0,00";


            for (i = 0; i<lista_linhas; i++)
            {
                text_est.Text += "Est " + Environment.NewLine;
                text_operacao.Text += "-" + Environment.NewLine;
            }
        }
    }
}
