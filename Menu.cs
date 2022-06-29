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
        int[] gondolaInicial; 
        int[] gondolaAtualizada;
        int[] gondolaAtt;
        int idUsuario;
        DateTime localDate = DateTime.Now;
        Random random = new Random();

        public Menu(string nomeBusca, string UsuarioIdBusca)
        {
            InitializeComponent();
            nome_usuario.Text = nomeBusca;
            idUsuario = Int32.Parse(UsuarioIdBusca);
            this.KeyPreview = true;
            gondolaAtt = new int[50];
            gondolaInicial = new int[50];
            gondolaAtualizada = new int[50];
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
            // TODO: esta linha de código carrega dados na tabela 'pDVDataSet1.Cupom'. Você pode movê-la ou removê-la conforme necessário.
            this.cupomTableAdapter.Fill(this.pDVDataSet1.Cupom);
            // TODO: esta linha de código carrega dados na tabela 'pDVDataSet1.ItensCupom'. Você pode movê-la ou removê-la conforme necessário.
            this.itensCupomTableAdapter.Fill(this.pDVDataSet1.ItensCupom);
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
                string CodigoItemBusca = "";
                string DescricaoBusca = "";
                string UnidadeBusca = "";
                string PrecoUnitBusca = "";
                string EstoqueInternoBusca = "";
                string EstoqueGondolaBusca = "";
                DataRow[] oDataRow = pDVDataSet1.Tables["Item"].Select();
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
                        //MessageBox.Show("GONDOLAINICIAL ANTES" + gondolaInicial[Int32.Parse(CodigoItemBusca)]);
                        int valorGondola = Int32.Parse(EstoqueGondolaBusca);
                        gondolaInicial[Int32.Parse(CodigoItemBusca)] = valorGondola;
                        //MessageBox.Show("GONDOLAINICIAL DEPOIS" + gondolaInicial[Int32.Parse(CodigoItemBusca)]);
                    }

                }
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
                        Estornar(input_codigo.Text, input_quantidade.Text);
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

            if (e.KeyCode == Keys.F10)
            {
                if (ativo == true)
                {
                    ativo = false;                 

                    string CodigoItemBusca = "";
                    string DescricaoBusca = "";
                    string UnidadeBusca = "";
                    string PrecoUnitBusca = "";
                    string EstoqueInternoBusca = "";
                    string EstoqueGondolaBusca = "";

                    DataRow[] oDataRow = pDVDataSet1.Tables["Item"].Select();

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

                            decimal valorPreco = Convert.ToDecimal(PrecoUnitBusca);
                            int valorQuantidade = gondolaInicial[Int32.Parse(CodigoItemBusca)] - gondolaAtualizada[Int32.Parse(CodigoItemBusca)];
                            //int valorQuantidade = Int32.Parse(quantidade);
                            int valorGondola = Int32.Parse(EstoqueGondolaBusca);
                            decimal valorTotal = valorPreco * valorQuantidade;

                            int sequencialId = random.Next(1, 10000);
                            int cupomId = random.Next(1, 10000);
                            //pDVDataSet1.Tables["ItensCupom"].Rows.Add(sequencialId, cupomId, Int32.Parse(CodigoItemBusca), valorQuantidade, valorPreco, valorTotal, idUsuario);
                            //pDVDataSet1.Tables["Cupom"].Rows.Add(cupomId, localDate, Convert.ToDecimal(total_geral.Text), "00000000000");
                        }

                        input_quantidade.Enabled = false;
                        input_quantidade.Text = "";
                        input_codigo.Enabled = false;
                        input_codigo.Text = "";
                        input_descricao.Text = "";
                        input_preco.Text = "";
                        input_total.Text = "";
                        list_itens.Text = "";
                        list_totals.Text = "";
                        total_geral.Text = "";

                        MessageBox.Show("Venda Concluída. Transação Finalizada com Sucesso!");

                    } else {
                        //insiro
                        MessageBox.Show("Sem itens. Nenhum cupom foi gerado. Transação Finalizada!");
                        pDVDataSet1.Tables["ItensCupom"].Rows.Add("Chris", "25");
                    }



                }
                else
                {
                    MessageBox.Show("Transação desabilitada. Para habilitar, por favor pressione F12");
                }
            }

            if (e.KeyCode == Keys.Escape)
            {
                if (ativo == true)
                {
                    MessageBox.Show("Transação habilitada, impossível sair. Para desabilitar, por favor pressione F10");
                }
                else
                {
                    this.Hide();
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

                if(gondolaAtt[Int32.Parse(CodigoItemBusca)] == 0)
                {
                    gondolaAtualizada[Int32.Parse(CodigoItemBusca)] = gondolaInicial[Int32.Parse(CodigoItemBusca)];
                    gondolaAtt[Int32.Parse(CodigoItemBusca)] = 1;
                }
                gondolaAtualizada[Int32.Parse(CodigoItemBusca)] = gondolaAtualizada[Int32.Parse(CodigoItemBusca)] - Int32.Parse(quantidade);
                CupomUpdate(CodigoItemBusca, quantidade);

                list_itens.Text += CodigoItemBusca + " " + DescricaoBusca + " " + quantidade + " x R$ " + PrecoUnitBusca + Environment.NewLine;
                text_operacao.Text += "+" + Environment.NewLine;
                list_totals.Text += valorTotal + Environment.NewLine;
                total += valorTotal;
                input_total.Text = total.ToString();
                total_geral.Text = "Total geral: R$" + total.ToString();                

            } else {
                MessageBox.Show("Produto não encontrato em nosso estoque");
            }

        }

        private void Estornar(string codigo, string quantidade)
        {
            if (!string.IsNullOrEmpty(codigo))
            {
                input_quantidade.Enabled = true;
                Search();
            }
            else
            {
                input_quantidade.Enabled = false;
                input_descricao.Text = "";
                input_preco.Text = "";
                input_quantidade.Text = "";
            }

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

                if ((gondolaAtualizada[Int32.Parse(CodigoItemBusca)] + Int32.Parse(quantidade)) <= gondolaInicial[Int32.Parse(CodigoItemBusca)])
                {
                    decimal valorPreco = Convert.ToDecimal(PrecoUnitBusca);
                    int valorQuantidade = Int32.Parse(quantidade);
                    int valorGondola = Int32.Parse(EstoqueGondolaBusca);
                    decimal valorTotal = valorPreco * valorQuantidade;


                    list_itens.Text += "0000 Est: " + DescricaoBusca + " -" + quantidade + " x R$ " + PrecoUnitBusca + Environment.NewLine;
                    text_operacao.Text += "-" + Environment.NewLine;
                    list_totals.Text += valorTotal + Environment.NewLine;
                    total -= valorTotal;
                    input_total.Text = total.ToString();
                    total_geral.Text = "Total geral: R$" + total.ToString();
                    gondolaAtualizada[Int32.Parse(CodigoItemBusca)] = gondolaAtualizada[Int32.Parse(CodigoItemBusca)] + Int32.Parse(quantidade);
                    CupomUpdate(CodigoItemBusca, quantidade);

                } else {
                    MessageBox.Show("Impossível estornar, quantidade maior do que a comprada ou produto inexistente");
                }



            }
            else
            {
                MessageBox.Show("Produto não encontrato em nosso estoque");
            }
        }

        private void CupomUpdate(string codigo, string quantidade)
        {

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
                    dr[5] = gondolaAtualizada[Int32.Parse(CodigoItemBusca)];
                    DescricaoBusca = dr["Descricao"].ToString();
                    UnidadeBusca = dr[2].ToString();
                    PrecoUnitBusca = dr[3].ToString();
                    EstoqueInternoBusca = dr[4].ToString();
                    EstoqueGondolaBusca = dr[5].ToString();
                }
            }
        }

    }
}
