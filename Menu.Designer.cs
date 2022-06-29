namespace ProjetoFinal
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.labelCod = new System.Windows.Forms.Label();
            this.input_codigo = new System.Windows.Forms.TextBox();
            this.input_descricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.input_preco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.input_quantidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.input_total = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.list_itens = new System.Windows.Forms.TextBox();
            this.nome_usuario = new System.Windows.Forms.Label();
            this.pDVDataSet1 = new ProjetoFinal.PDVDataSet1();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemTableAdapter = new ProjetoFinal.PDVDataSet1TableAdapters.ItemTableAdapter();
            this.tableAdapterManager = new ProjetoFinal.PDVDataSet1TableAdapters.TableAdapterManager();
            this.itemDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.itemBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.itemBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.list_totals = new System.Windows.Forms.TextBox();
            this.total_geral = new System.Windows.Forms.TextBox();
            this.text_est = new System.Windows.Forms.TextBox();
            this.text_operacao = new System.Windows.Forms.TextBox();
            this.itensCupomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itensCupomTableAdapter = new ProjetoFinal.PDVDataSet1TableAdapters.ItensCupomTableAdapter();
            this.itensCupomDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cupomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cupomTableAdapter = new ProjetoFinal.PDVDataSet1TableAdapters.CupomTableAdapter();
            this.cupomDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pDVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingNavigator)).BeginInit();
            this.itemBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itensCupomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensCupomDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cupomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cupomDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCod
            // 
            this.labelCod.AutoSize = true;
            this.labelCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCod.Location = new System.Drawing.Point(290, 174);
            this.labelCod.Name = "labelCod";
            this.labelCod.Size = new System.Drawing.Size(125, 37);
            this.labelCod.TabIndex = 0;
            this.labelCod.Text = "Código";
            // 
            // input_codigo
            // 
            this.input_codigo.AcceptsTab = true;
            this.input_codigo.Enabled = false;
            this.input_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_codigo.Location = new System.Drawing.Point(297, 214);
            this.input_codigo.Name = "input_codigo";
            this.input_codigo.Size = new System.Drawing.Size(438, 31);
            this.input_codigo.TabIndex = 1;
            this.input_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.input_codigo.TextChanged += new System.EventHandler(this.input_codigo_TextChanged);
            this.input_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_codigo_KeyPress);
            // 
            // input_descricao
            // 
            this.input_descricao.AcceptsTab = true;
            this.input_descricao.Enabled = false;
            this.input_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_descricao.Location = new System.Drawing.Point(297, 294);
            this.input_descricao.Name = "input_descricao";
            this.input_descricao.Size = new System.Drawing.Size(438, 31);
            this.input_descricao.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Produto";
            // 
            // input_preco
            // 
            this.input_preco.AcceptsTab = true;
            this.input_preco.Enabled = false;
            this.input_preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_preco.Location = new System.Drawing.Point(297, 378);
            this.input_preco.Name = "input_preco";
            this.input_preco.Size = new System.Drawing.Size(438, 31);
            this.input_preco.TabIndex = 5;
            this.input_preco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Preço Unitário";
            // 
            // input_quantidade
            // 
            this.input_quantidade.AcceptsTab = true;
            this.input_quantidade.Enabled = false;
            this.input_quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_quantidade.Location = new System.Drawing.Point(297, 457);
            this.input_quantidade.Name = "input_quantidade";
            this.input_quantidade.Size = new System.Drawing.Size(438, 31);
            this.input_quantidade.TabIndex = 7;
            this.input_quantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.input_quantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_quantidade_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(290, 529);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "<F1> Adiciona";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(527, 529);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "<F5> Estorno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(527, 576);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "<F10> Finaliza";
            // 
            // input_total
            // 
            this.input_total.Enabled = false;
            this.input_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_total.Location = new System.Drawing.Point(297, 677);
            this.input_total.Name = "input_total";
            this.input_total.Size = new System.Drawing.Size(438, 31);
            this.input_total.TabIndex = 12;
            this.input_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(290, 637);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(271, 37);
            this.label7.TabIndex = 11;
            this.label7.Text = "Total acumulado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(966, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 37);
            this.label8.TabIndex = 13;
            this.label8.Text = "Caixa - ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Thistle;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(777, 174);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(559, 55);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "Supermercado Bom de Preço\r\nCNPJ 00.000.000/0000-00\r\n-----------------------------" +
    "-------------------------\r\n";
            // 
            // list_itens
            // 
            this.list_itens.BackColor = System.Drawing.Color.Thistle;
            this.list_itens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_itens.Location = new System.Drawing.Point(839, 229);
            this.list_itens.Multiline = true;
            this.list_itens.Name = "list_itens";
            this.list_itens.ReadOnly = true;
            this.list_itens.Size = new System.Drawing.Size(411, 421);
            this.list_itens.TabIndex = 15;
            // 
            // nome_usuario
            // 
            this.nome_usuario.AutoSize = true;
            this.nome_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_usuario.Location = new System.Drawing.Point(1086, 9);
            this.nome_usuario.Name = "nome_usuario";
            this.nome_usuario.Size = new System.Drawing.Size(103, 37);
            this.nome_usuario.TabIndex = 16;
            this.nome_usuario.Text = "Caixa";
            // 
            // pDVDataSet1
            // 
            this.pDVDataSet1.DataSetName = "PDVDataSet1";
            this.pDVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.pDVDataSet1;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CupomTableAdapter = null;
            this.tableAdapterManager.ItemTableAdapter = this.itemTableAdapter;
            this.tableAdapterManager.ItensCupomTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoFinal.PDVDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // itemDataGridView
            // 
            this.itemDataGridView.AutoGenerateColumns = false;
            this.itemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.itemDataGridView.DataSource = this.itemBindingSource;
            this.itemDataGridView.Location = new System.Drawing.Point(12, 59);
            this.itemDataGridView.Name = "itemDataGridView";
            this.itemDataGridView.Size = new System.Drawing.Size(676, 94);
            this.itemDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Unidade";
            this.dataGridViewTextBoxColumn3.HeaderText = "Unidade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PrecoUnit";
            this.dataGridViewTextBoxColumn4.HeaderText = "PrecoUnit";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EstoqueInterno";
            this.dataGridViewTextBoxColumn5.HeaderText = "EstoqueInterno";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "EstoqueGondola";
            this.dataGridViewTextBoxColumn6.HeaderText = "EstoqueGondola";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // itemBindingNavigatorSaveItem
            // 
            this.itemBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.itemBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("itemBindingNavigatorSaveItem.Image")));
            this.itemBindingNavigatorSaveItem.Name = "itemBindingNavigatorSaveItem";
            this.itemBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.itemBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.itemBindingNavigatorSaveItem.Click += new System.EventHandler(this.itemBindingNavigatorSaveItem_Click_1);
            // 
            // itemBindingNavigator
            // 
            this.itemBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.itemBindingNavigator.BindingSource = this.itemBindingSource;
            this.itemBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.itemBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.itemBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.itemBindingNavigatorSaveItem});
            this.itemBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.itemBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.itemBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.itemBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.itemBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.itemBindingNavigator.Name = "itemBindingNavigator";
            this.itemBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.itemBindingNavigator.Size = new System.Drawing.Size(1904, 25);
            this.itemBindingNavigator.TabIndex = 17;
            this.itemBindingNavigator.Text = "bindingNavigator1";
            // 
            // list_totals
            // 
            this.list_totals.BackColor = System.Drawing.Color.Thistle;
            this.list_totals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_totals.Location = new System.Drawing.Point(1248, 229);
            this.list_totals.Multiline = true;
            this.list_totals.Name = "list_totals";
            this.list_totals.ReadOnly = true;
            this.list_totals.Size = new System.Drawing.Size(66, 421);
            this.list_totals.TabIndex = 19;
            // 
            // total_geral
            // 
            this.total_geral.BackColor = System.Drawing.Color.Thistle;
            this.total_geral.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.total_geral.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_geral.Location = new System.Drawing.Point(777, 655);
            this.total_geral.Multiline = true;
            this.total_geral.Name = "total_geral";
            this.total_geral.ReadOnly = true;
            this.total_geral.Size = new System.Drawing.Size(559, 53);
            this.total_geral.TabIndex = 20;
            // 
            // text_est
            // 
            this.text_est.BackColor = System.Drawing.Color.Thistle;
            this.text_est.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_est.Location = new System.Drawing.Point(777, 229);
            this.text_est.Multiline = true;
            this.text_est.Name = "text_est";
            this.text_est.ReadOnly = true;
            this.text_est.Size = new System.Drawing.Size(62, 421);
            this.text_est.TabIndex = 21;
            // 
            // text_operacao
            // 
            this.text_operacao.BackColor = System.Drawing.Color.Thistle;
            this.text_operacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_operacao.Location = new System.Drawing.Point(1309, 229);
            this.text_operacao.Multiline = true;
            this.text_operacao.Name = "text_operacao";
            this.text_operacao.ReadOnly = true;
            this.text_operacao.Size = new System.Drawing.Size(27, 421);
            this.text_operacao.TabIndex = 22;
            // 
            // itensCupomBindingSource
            // 
            this.itensCupomBindingSource.DataMember = "ItensCupom";
            this.itensCupomBindingSource.DataSource = this.pDVDataSet1;
            // 
            // itensCupomTableAdapter
            // 
            this.itensCupomTableAdapter.ClearBeforeFill = true;
            // 
            // itensCupomDataGridView
            // 
            this.itensCupomDataGridView.AutoGenerateColumns = false;
            this.itensCupomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itensCupomDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.itensCupomDataGridView.DataSource = this.itensCupomBindingSource;
            this.itensCupomDataGridView.Location = new System.Drawing.Point(706, 49);
            this.itensCupomDataGridView.Name = "itensCupomDataGridView";
            this.itensCupomDataGridView.Size = new System.Drawing.Size(780, 88);
            this.itensCupomDataGridView.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Sequencial";
            this.dataGridViewTextBoxColumn7.HeaderText = "Sequencial";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CupomId";
            this.dataGridViewTextBoxColumn8.HeaderText = "CupomId";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ItemId";
            this.dataGridViewTextBoxColumn9.HeaderText = "ItemId";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Qtde";
            this.dataGridViewTextBoxColumn10.HeaderText = "Qtde";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "PrecoUnit";
            this.dataGridViewTextBoxColumn11.HeaderText = "PrecoUnit";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "TotalItem";
            this.dataGridViewTextBoxColumn12.HeaderText = "TotalItem";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "UId";
            this.dataGridViewTextBoxColumn13.HeaderText = "UId";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // cupomBindingSource
            // 
            this.cupomBindingSource.DataMember = "Cupom";
            this.cupomBindingSource.DataSource = this.pDVDataSet1;
            // 
            // cupomTableAdapter
            // 
            this.cupomTableAdapter.ClearBeforeFill = true;
            // 
            // cupomDataGridView
            // 
            this.cupomDataGridView.AutoGenerateColumns = false;
            this.cupomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cupomDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.cupomDataGridView.DataSource = this.cupomBindingSource;
            this.cupomDataGridView.Location = new System.Drawing.Point(1392, 173);
            this.cupomDataGridView.Name = "cupomDataGridView";
            this.cupomDataGridView.Size = new System.Drawing.Size(460, 72);
            this.cupomDataGridView.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn14.HeaderText = "Id";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "DtEmissao";
            this.dataGridViewTextBoxColumn15.HeaderText = "DtEmissao";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "TotalVenda";
            this.dataGridViewTextBoxColumn16.HeaderText = "TotalVenda";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "CPF";
            this.dataGridViewTextBoxColumn17.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.cupomDataGridView);
            this.Controls.Add(this.itensCupomDataGridView);
            this.Controls.Add(this.text_operacao);
            this.Controls.Add(this.text_est);
            this.Controls.Add(this.total_geral);
            this.Controls.Add(this.list_totals);
            this.Controls.Add(this.itemDataGridView);
            this.Controls.Add(this.itemBindingNavigator);
            this.Controls.Add(this.nome_usuario);
            this.Controls.Add(this.list_itens);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.input_total);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.input_quantidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input_preco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input_descricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_codigo);
            this.Controls.Add(this.labelCod);
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Menu_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pDVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingNavigator)).EndInit();
            this.itemBindingNavigator.ResumeLayout(false);
            this.itemBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itensCupomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensCupomDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cupomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cupomDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCod;
        private System.Windows.Forms.TextBox input_codigo;
        private System.Windows.Forms.TextBox input_descricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_preco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input_quantidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox input_total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox list_itens;
        private System.Windows.Forms.Label nome_usuario;
        private PDVDataSet1 pDVDataSet1;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private PDVDataSet1TableAdapters.ItemTableAdapter itemTableAdapter;
        private PDVDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView itemDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton itemBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator itemBindingNavigator;
        private System.Windows.Forms.TextBox list_totals;
        private System.Windows.Forms.TextBox total_geral;
        private System.Windows.Forms.TextBox text_est;
        private System.Windows.Forms.TextBox text_operacao;
        private System.Windows.Forms.BindingSource itensCupomBindingSource;
        private PDVDataSet1TableAdapters.ItensCupomTableAdapter itensCupomTableAdapter;
        private System.Windows.Forms.DataGridView itensCupomDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.BindingSource cupomBindingSource;
        private PDVDataSet1TableAdapters.CupomTableAdapter cupomTableAdapter;
        private System.Windows.Forms.DataGridView cupomDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
    }
}