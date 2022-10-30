namespace ProjetoPetShop2022
{
    partial class frmAgendamento
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
            System.Windows.Forms.Label agend_idLabel;
            System.Windows.Forms.Label agend_dataLabel;
            System.Windows.Forms.Label agend_horarioLabel;
            System.Windows.Forms.Label agend_situacaoLabel;
            System.Windows.Forms.Label agend_totalLabel;
            System.Windows.Forms.Label anim_idLabel;
            System.Windows.Forms.Label serv_tempoLabel;
            System.Windows.Forms.Label serv_tempoLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgendamento));
            this.groupBoxAgendamentos = new System.Windows.Forms.GroupBox();
            this.txt_agend_id = new System.Windows.Forms.TextBox();
            this.agendamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPetshop2022 = new ProjetoPetShop2022.DataSetPetshop2022();
            this.txt_agend_TempoTotal = new System.Windows.Forms.TextBox();
            this.txt_Tempo = new System.Windows.Forms.TextBox();
            this.anim_idComboBox = new System.Windows.Forms.ComboBox();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agend_situacaoComboBox = new System.Windows.Forms.ComboBox();
            this.agend_dataMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.agend_horarioMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.txt_agend_ValorTotal = new System.Windows.Forms.TextBox();
            this.agendamentoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCriarNovo = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnFinalizar = new System.Windows.Forms.ToolStripButton();
            this.groupBoxAgendamentoServico = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.view_AgendamentoServicosDataGridView = new System.Windows.Forms.DataGridView();
            this.agendservidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agendidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servdescricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servtempoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agendservquantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agendservvalorunitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_AgendamentoServicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.btnAdicionarServico = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtServico_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.agendamentoTableAdapter = new ProjetoPetShop2022.DataSetPetshop2022TableAdapters.agendamentoTableAdapter();
            this.tableAdapterManager = new ProjetoPetShop2022.DataSetPetshop2022TableAdapters.TableAdapterManager();
            this.agendamento_servicosTableAdapter = new ProjetoPetShop2022.DataSetPetshop2022TableAdapters.agendamento_servicosTableAdapter();
            this.animalTableAdapter = new ProjetoPetShop2022.DataSetPetshop2022TableAdapters.animalTableAdapter();
            this.servicoTableAdapter = new ProjetoPetShop2022.DataSetPetshop2022TableAdapters.servicoTableAdapter();
            this.view_AgendamentoServicosTableAdapter = new ProjetoPetShop2022.DataSetPetshop2022TableAdapters.View_AgendamentoServicosTableAdapter();
            this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendamento_servicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_Total_ServicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_Total_ServicosTableAdapter = new ProjetoPetShop2022.DataSetPetshop2022TableAdapters.View_Total_ServicosTableAdapter();
            this.btnLocalizar = new System.Windows.Forms.ToolStripButton();
            agend_idLabel = new System.Windows.Forms.Label();
            agend_dataLabel = new System.Windows.Forms.Label();
            agend_horarioLabel = new System.Windows.Forms.Label();
            agend_situacaoLabel = new System.Windows.Forms.Label();
            agend_totalLabel = new System.Windows.Forms.Label();
            anim_idLabel = new System.Windows.Forms.Label();
            serv_tempoLabel = new System.Windows.Forms.Label();
            serv_tempoLabel1 = new System.Windows.Forms.Label();
            this.groupBoxAgendamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPetshop2022)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingNavigator)).BeginInit();
            this.agendamentoBindingNavigator.SuspendLayout();
            this.groupBoxAgendamentoServico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_AgendamentoServicosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_AgendamentoServicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamento_servicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Total_ServicosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // agend_idLabel
            // 
            agend_idLabel.AutoSize = true;
            agend_idLabel.Location = new System.Drawing.Point(15, 36);
            agend_idLabel.Name = "agend_idLabel";
            agend_idLabel.Size = new System.Drawing.Size(71, 24);
            agend_idLabel.TabIndex = 0;
            agend_idLabel.Text = "Código";
            // 
            // agend_dataLabel
            // 
            agend_dataLabel.AutoSize = true;
            agend_dataLabel.Location = new System.Drawing.Point(722, 77);
            agend_dataLabel.Name = "agend_dataLabel";
            agend_dataLabel.Size = new System.Drawing.Size(47, 24);
            agend_dataLabel.TabIndex = 2;
            agend_dataLabel.Text = "Data";
            // 
            // agend_horarioLabel
            // 
            agend_horarioLabel.AutoSize = true;
            agend_horarioLabel.Location = new System.Drawing.Point(15, 146);
            agend_horarioLabel.Name = "agend_horarioLabel";
            agend_horarioLabel.Size = new System.Drawing.Size(72, 24);
            agend_horarioLabel.TabIndex = 4;
            agend_horarioLabel.Text = "Horário";
            // 
            // agend_situacaoLabel
            // 
            agend_situacaoLabel.AutoSize = true;
            agend_situacaoLabel.Location = new System.Drawing.Point(223, 147);
            agend_situacaoLabel.Name = "agend_situacaoLabel";
            agend_situacaoLabel.Size = new System.Drawing.Size(82, 24);
            agend_situacaoLabel.TabIndex = 6;
            agend_situacaoLabel.Text = "Situação";
            // 
            // agend_totalLabel
            // 
            agend_totalLabel.AutoSize = true;
            agend_totalLabel.Location = new System.Drawing.Point(726, 154);
            agend_totalLabel.Name = "agend_totalLabel";
            agend_totalLabel.Size = new System.Drawing.Size(51, 24);
            agend_totalLabel.TabIndex = 8;
            agend_totalLabel.Text = "Total";
            // 
            // anim_idLabel
            // 
            anim_idLabel.AutoSize = true;
            anim_idLabel.Location = new System.Drawing.Point(15, 72);
            anim_idLabel.Name = "anim_idLabel";
            anim_idLabel.Size = new System.Drawing.Size(94, 24);
            anim_idLabel.TabIndex = 10;
            anim_idLabel.Text = "Nome Pet";
            // 
            // serv_tempoLabel
            // 
            serv_tempoLabel.AutoSize = true;
            serv_tempoLabel.Location = new System.Drawing.Point(15, 187);
            serv_tempoLabel.Name = "serv_tempoLabel";
            serv_tempoLabel.Size = new System.Drawing.Size(71, 24);
            serv_tempoLabel.TabIndex = 14;
            serv_tempoLabel.Text = "Tempo";
            // 
            // serv_tempoLabel1
            // 
            serv_tempoLabel1.AutoSize = true;
            serv_tempoLabel1.Location = new System.Drawing.Point(523, 47);
            serv_tempoLabel1.Name = "serv_tempoLabel1";
            serv_tempoLabel1.Size = new System.Drawing.Size(71, 24);
            serv_tempoLabel1.TabIndex = 11;
            serv_tempoLabel1.Text = "Tempo";
            // 
            // groupBoxAgendamentos
            // 
            this.groupBoxAgendamentos.Controls.Add(this.txt_agend_id);
            this.groupBoxAgendamentos.Controls.Add(this.txt_agend_TempoTotal);
            this.groupBoxAgendamentos.Controls.Add(serv_tempoLabel);
            this.groupBoxAgendamentos.Controls.Add(this.txt_Tempo);
            this.groupBoxAgendamentos.Controls.Add(this.anim_idComboBox);
            this.groupBoxAgendamentos.Controls.Add(this.agend_situacaoComboBox);
            this.groupBoxAgendamentos.Controls.Add(this.agend_dataMaskedTextBox);
            this.groupBoxAgendamentos.Controls.Add(agend_idLabel);
            this.groupBoxAgendamentos.Controls.Add(agend_dataLabel);
            this.groupBoxAgendamentos.Controls.Add(agend_horarioLabel);
            this.groupBoxAgendamentos.Controls.Add(this.agend_horarioMaskedTextBox);
            this.groupBoxAgendamentos.Controls.Add(agend_situacaoLabel);
            this.groupBoxAgendamentos.Controls.Add(agend_totalLabel);
            this.groupBoxAgendamentos.Controls.Add(this.txt_agend_ValorTotal);
            this.groupBoxAgendamentos.Controls.Add(anim_idLabel);
            this.groupBoxAgendamentos.Enabled = false;
            this.groupBoxAgendamentos.Location = new System.Drawing.Point(12, 46);
            this.groupBoxAgendamentos.Name = "groupBoxAgendamentos";
            this.groupBoxAgendamentos.Size = new System.Drawing.Size(928, 439);
            this.groupBoxAgendamentos.TabIndex = 0;
            this.groupBoxAgendamentos.TabStop = false;
            this.groupBoxAgendamentos.Text = "Cadastro de Agendamentos";
            // 
            // txt_agend_id
            // 
            this.txt_agend_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "agend_id", true));
            this.txt_agend_id.Location = new System.Drawing.Point(121, 28);
            this.txt_agend_id.Name = "txt_agend_id";
            this.txt_agend_id.Size = new System.Drawing.Size(119, 29);
            this.txt_agend_id.TabIndex = 18;
            this.txt_agend_id.TextChanged += new System.EventHandler(this.txt_agend_id_TextChanged_1);
            // 
            // agendamentoBindingSource
            // 
            this.agendamentoBindingSource.DataMember = "agendamento";
            this.agendamentoBindingSource.DataSource = this.dataSetPetshop2022;
            this.agendamentoBindingSource.PositionChanged += new System.EventHandler(this.agendamentoBindingSource_PositionChanged);
            // 
            // dataSetPetshop2022
            // 
            this.dataSetPetshop2022.DataSetName = "DataSetPetshop2022";
            this.dataSetPetshop2022.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_agend_TempoTotal
            // 
            this.txt_agend_TempoTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "agend_TempoTotal", true));
            this.txt_agend_TempoTotal.Location = new System.Drawing.Point(214, 184);
            this.txt_agend_TempoTotal.Name = "txt_agend_TempoTotal";
            this.txt_agend_TempoTotal.Size = new System.Drawing.Size(100, 29);
            this.txt_agend_TempoTotal.TabIndex = 17;
            this.txt_agend_TempoTotal.Visible = false;
            // 
            // txt_Tempo
            // 
            this.txt_Tempo.Location = new System.Drawing.Point(121, 184);
            this.txt_Tempo.Name = "txt_Tempo";
            this.txt_Tempo.Size = new System.Drawing.Size(86, 29);
            this.txt_Tempo.TabIndex = 15;
            // 
            // anim_idComboBox
            // 
            this.anim_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.agendamentoBindingSource, "anim_id", true));
            this.anim_idComboBox.DataSource = this.animalBindingSource;
            this.anim_idComboBox.DisplayMember = "anim_nome";
            this.anim_idComboBox.FormattingEnabled = true;
            this.anim_idComboBox.Location = new System.Drawing.Point(121, 64);
            this.anim_idComboBox.Name = "anim_idComboBox";
            this.anim_idComboBox.Size = new System.Drawing.Size(595, 32);
            this.anim_idComboBox.TabIndex = 14;
            this.anim_idComboBox.ValueMember = "anim_id";
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "animal";
            this.animalBindingSource.DataSource = this.dataSetPetshop2022;
            // 
            // agend_situacaoComboBox
            // 
            this.agend_situacaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "agend_situacao", true));
            this.agend_situacaoComboBox.FormattingEnabled = true;
            this.agend_situacaoComboBox.Items.AddRange(new object[] {
            "Agendado\t",
            "Em adamento",
            "Finalizado"});
            this.agend_situacaoComboBox.Location = new System.Drawing.Point(320, 143);
            this.agend_situacaoComboBox.Name = "agend_situacaoComboBox";
            this.agend_situacaoComboBox.Size = new System.Drawing.Size(396, 32);
            this.agend_situacaoComboBox.TabIndex = 13;
            // 
            // agend_dataMaskedTextBox
            // 
            this.agend_dataMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "agend_data", true));
            this.agend_dataMaskedTextBox.Location = new System.Drawing.Point(797, 72);
            this.agend_dataMaskedTextBox.Mask = "00/00/0000";
            this.agend_dataMaskedTextBox.Name = "agend_dataMaskedTextBox";
            this.agend_dataMaskedTextBox.Size = new System.Drawing.Size(111, 29);
            this.agend_dataMaskedTextBox.TabIndex = 12;
            this.agend_dataMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // agend_horarioMaskedTextBox
            // 
            this.agend_horarioMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "agend_horario", true));
            this.agend_horarioMaskedTextBox.Location = new System.Drawing.Point(121, 143);
            this.agend_horarioMaskedTextBox.Mask = "00:00";
            this.agend_horarioMaskedTextBox.Name = "agend_horarioMaskedTextBox";
            this.agend_horarioMaskedTextBox.Size = new System.Drawing.Size(86, 29);
            this.agend_horarioMaskedTextBox.TabIndex = 5;
            this.agend_horarioMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // txt_agend_ValorTotal
            // 
            this.txt_agend_ValorTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "agend_Total", true));
            this.txt_agend_ValorTotal.Location = new System.Drawing.Point(797, 151);
            this.txt_agend_ValorTotal.Name = "txt_agend_ValorTotal";
            this.txt_agend_ValorTotal.Size = new System.Drawing.Size(111, 29);
            this.txt_agend_ValorTotal.TabIndex = 9;
            // 
            // agendamentoBindingNavigator
            // 
            this.agendamentoBindingNavigator.AddNewItem = null;
            this.agendamentoBindingNavigator.BindingSource = this.agendamentoBindingSource;
            this.agendamentoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.agendamentoBindingNavigator.DeleteItem = null;
            this.agendamentoBindingNavigator.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.agendamentoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnCriarNovo,
            this.btnSalvar,
            this.btnEditar,
            this.btnCancelar,
            this.btnExcluir,
            this.btnFinalizar,
            this.btnLocalizar});
            this.agendamentoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.agendamentoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.agendamentoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.agendamentoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.agendamentoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.agendamentoBindingNavigator.Name = "agendamentoBindingNavigator";
            this.agendamentoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.agendamentoBindingNavigator.Size = new System.Drawing.Size(940, 43);
            this.agendamentoBindingNavigator.TabIndex = 2;
            this.agendamentoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 40);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = global::ProjetoPetShop2022.Properties.Resources.icons8_001_primeiro_64;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(40, 40);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = global::ProjetoPetShop2022.Properties.Resources.icons8_001_anterior_64;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(40, 40);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 43);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = global::ProjetoPetShop2022.Properties.Resources.icons8_001_próximo_64;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(40, 40);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = global::ProjetoPetShop2022.Properties.Resources.icons8_001_último_64;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(40, 40);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnCriarNovo
            // 
            this.btnCriarNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCriarNovo.Image = global::ProjetoPetShop2022.Properties.Resources.icons8_mais_256;
            this.btnCriarNovo.Name = "btnCriarNovo";
            this.btnCriarNovo.RightToLeftAutoMirrorImage = true;
            this.btnCriarNovo.Size = new System.Drawing.Size(40, 40);
            this.btnCriarNovo.Text = "Adicionar novo";
            this.btnCriarNovo.Click += new System.EventHandler(this.btnCriarNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(40, 40);
            this.btnSalvar.Text = "Salvar Dados";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = global::ProjetoPetShop2022.Properties.Resources._184697;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(40, 40);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = global::ProjetoPetShop2022.Properties.Resources.cancelar1;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(40, 40);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = global::ProjetoPetShop2022.Properties.Resources.icons8_remover_256;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.RightToLeftAutoMirrorImage = true;
            this.btnExcluir.Size = new System.Drawing.Size(40, 40);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFinalizar.Image = global::ProjetoPetShop2022.Properties.Resources.done;
            this.btnFinalizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(40, 40);
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // groupBoxAgendamentoServico
            // 
            this.groupBoxAgendamentoServico.Controls.Add(this.txtDescricao);
            this.groupBoxAgendamentoServico.Controls.Add(this.view_AgendamentoServicosDataGridView);
            this.groupBoxAgendamentoServico.Controls.Add(serv_tempoLabel1);
            this.groupBoxAgendamentoServico.Controls.Add(this.txtTempo);
            this.groupBoxAgendamentoServico.Controls.Add(this.btnAdicionarServico);
            this.groupBoxAgendamentoServico.Controls.Add(this.txtValor);
            this.groupBoxAgendamentoServico.Controls.Add(this.txtQuantidade);
            this.groupBoxAgendamentoServico.Controls.Add(this.txtServico_id);
            this.groupBoxAgendamentoServico.Controls.Add(this.label5);
            this.groupBoxAgendamentoServico.Controls.Add(this.label4);
            this.groupBoxAgendamentoServico.Controls.Add(this.label3);
            this.groupBoxAgendamentoServico.Controls.Add(this.label1);
            this.groupBoxAgendamentoServico.Location = new System.Drawing.Point(12, 268);
            this.groupBoxAgendamentoServico.Name = "groupBoxAgendamentoServico";
            this.groupBoxAgendamentoServico.Size = new System.Drawing.Size(928, 323);
            this.groupBoxAgendamentoServico.TabIndex = 3;
            this.groupBoxAgendamentoServico.TabStop = false;
            this.groupBoxAgendamentoServico.Text = "Serviços";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(135, 78);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(386, 29);
            this.txtDescricao.TabIndex = 13;
            // 
            // view_AgendamentoServicosDataGridView
            // 
            this.view_AgendamentoServicosDataGridView.AllowUserToAddRows = false;
            this.view_AgendamentoServicosDataGridView.AllowUserToDeleteRows = false;
            this.view_AgendamentoServicosDataGridView.AutoGenerateColumns = false;
            this.view_AgendamentoServicosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_AgendamentoServicosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.agendservidDataGridViewTextBoxColumn,
            this.agendidDataGridViewTextBoxColumn,
            this.servidDataGridViewTextBoxColumn,
            this.servdescricaoDataGridViewTextBoxColumn,
            this.servtempoDataGridViewTextBoxColumn,
            this.agendservquantidadeDataGridViewTextBoxColumn,
            this.agendservvalorunitarioDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.view_AgendamentoServicosDataGridView.DataSource = this.view_AgendamentoServicosBindingSource;
            this.view_AgendamentoServicosDataGridView.Location = new System.Drawing.Point(10, 119);
            this.view_AgendamentoServicosDataGridView.Name = "view_AgendamentoServicosDataGridView";
            this.view_AgendamentoServicosDataGridView.ReadOnly = true;
            this.view_AgendamentoServicosDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.view_AgendamentoServicosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.view_AgendamentoServicosDataGridView.Size = new System.Drawing.Size(898, 184);
            this.view_AgendamentoServicosDataGridView.TabIndex = 12;
            this.view_AgendamentoServicosDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_AgendamentoServicosDataGridView_CellDoubleClick);
            // 
            // agendservidDataGridViewTextBoxColumn
            // 
            this.agendservidDataGridViewTextBoxColumn.DataPropertyName = "agend_serv_id";
            this.agendservidDataGridViewTextBoxColumn.HeaderText = "agend_serv_id";
            this.agendservidDataGridViewTextBoxColumn.Name = "agendservidDataGridViewTextBoxColumn";
            this.agendservidDataGridViewTextBoxColumn.ReadOnly = true;
            this.agendservidDataGridViewTextBoxColumn.Visible = false;
            // 
            // agendidDataGridViewTextBoxColumn
            // 
            this.agendidDataGridViewTextBoxColumn.DataPropertyName = "agend_id";
            this.agendidDataGridViewTextBoxColumn.HeaderText = "agend_id";
            this.agendidDataGridViewTextBoxColumn.Name = "agendidDataGridViewTextBoxColumn";
            this.agendidDataGridViewTextBoxColumn.ReadOnly = true;
            this.agendidDataGridViewTextBoxColumn.Visible = false;
            // 
            // servidDataGridViewTextBoxColumn
            // 
            this.servidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.servidDataGridViewTextBoxColumn.DataPropertyName = "serv_id";
            this.servidDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.servidDataGridViewTextBoxColumn.Name = "servidDataGridViewTextBoxColumn";
            this.servidDataGridViewTextBoxColumn.ReadOnly = true;
            this.servidDataGridViewTextBoxColumn.Width = 96;
            // 
            // servdescricaoDataGridViewTextBoxColumn
            // 
            this.servdescricaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.servdescricaoDataGridViewTextBoxColumn.DataPropertyName = "serv_descricao";
            this.servdescricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.servdescricaoDataGridViewTextBoxColumn.Name = "servdescricaoDataGridViewTextBoxColumn";
            this.servdescricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // servtempoDataGridViewTextBoxColumn
            // 
            this.servtempoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.servtempoDataGridViewTextBoxColumn.DataPropertyName = "serv_tempo";
            this.servtempoDataGridViewTextBoxColumn.HeaderText = "Tempo";
            this.servtempoDataGridViewTextBoxColumn.Name = "servtempoDataGridViewTextBoxColumn";
            this.servtempoDataGridViewTextBoxColumn.ReadOnly = true;
            this.servtempoDataGridViewTextBoxColumn.Width = 96;
            // 
            // agendservquantidadeDataGridViewTextBoxColumn
            // 
            this.agendservquantidadeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.agendservquantidadeDataGridViewTextBoxColumn.DataPropertyName = "agend_serv_quantidade";
            this.agendservquantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.agendservquantidadeDataGridViewTextBoxColumn.Name = "agendservquantidadeDataGridViewTextBoxColumn";
            this.agendservquantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.agendservquantidadeDataGridViewTextBoxColumn.Width = 133;
            // 
            // agendservvalorunitarioDataGridViewTextBoxColumn
            // 
            this.agendservvalorunitarioDataGridViewTextBoxColumn.DataPropertyName = "agend_serv_valor_unitario";
            this.agendservvalorunitarioDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.agendservvalorunitarioDataGridViewTextBoxColumn.Name = "agendservvalorunitarioDataGridViewTextBoxColumn";
            this.agendservvalorunitarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 76;
            // 
            // view_AgendamentoServicosBindingSource
            // 
            this.view_AgendamentoServicosBindingSource.DataMember = "View_AgendamentoServicos";
            this.view_AgendamentoServicosBindingSource.DataSource = this.dataSetPetshop2022;
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(527, 78);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(100, 29);
            this.txtTempo.TabIndex = 12;
            // 
            // btnAdicionarServico
            // 
            this.btnAdicionarServico.BackgroundImage = global::ProjetoPetShop2022.Properties.Resources.icons8_mais_25666;
            this.btnAdicionarServico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdicionarServico.FlatAppearance.BorderSize = 0;
            this.btnAdicionarServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarServico.Location = new System.Drawing.Point(850, 69);
            this.btnAdicionarServico.Name = "btnAdicionarServico";
            this.btnAdicionarServico.Size = new System.Drawing.Size(58, 44);
            this.btnAdicionarServico.TabIndex = 10;
            this.btnAdicionarServico.UseVisualStyleBackColor = true;
            this.btnAdicionarServico.Click += new System.EventHandler(this.btnAdicionarServico_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(760, 78);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 29);
            this.txtValor.TabIndex = 9;
            this.txtValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValor_KeyDown);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(633, 78);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(121, 29);
            this.txtQuantidade.TabIndex = 8;
            this.txtQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantidade_KeyDown);
            // 
            // txtServico_id
            // 
            this.txtServico_id.Location = new System.Drawing.Point(6, 78);
            this.txtServico_id.Name = "txtServico_id";
            this.txtServico_id.Size = new System.Drawing.Size(123, 29);
            this.txtServico_id.TabIndex = 5;
            this.txtServico_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtServico_id_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(756, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(629, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod. Serviço";
            // 
            // agendamentoTableAdapter
            // 
            this.agendamentoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendamento_servicosTableAdapter = this.agendamento_servicosTableAdapter;
            this.tableAdapterManager.agendamentoTableAdapter = this.agendamentoTableAdapter;
            this.tableAdapterManager.animalTableAdapter = this.animalTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.racaTableAdapter = null;
            this.tableAdapterManager.servicoTableAdapter = this.servicoTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProjetoPetShop2022.DataSetPetshop2022TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // agendamento_servicosTableAdapter
            // 
            this.agendamento_servicosTableAdapter.ClearBeforeFill = true;
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
            // 
            // servicoTableAdapter
            // 
            this.servicoTableAdapter.ClearBeforeFill = true;
            // 
            // view_AgendamentoServicosTableAdapter
            // 
            this.view_AgendamentoServicosTableAdapter.ClearBeforeFill = true;
            // 
            // servicoBindingSource
            // 
            this.servicoBindingSource.DataMember = "servico";
            this.servicoBindingSource.DataSource = this.dataSetPetshop2022;
            // 
            // agendamento_servicosBindingSource
            // 
            this.agendamento_servicosBindingSource.DataMember = "agendamento_servicos";
            this.agendamento_servicosBindingSource.DataSource = this.dataSetPetshop2022;
            // 
            // view_Total_ServicosBindingSource
            // 
            this.view_Total_ServicosBindingSource.DataMember = "View_Total_Servicos";
            this.view_Total_ServicosBindingSource.DataSource = this.dataSetPetshop2022;
            // 
            // view_Total_ServicosTableAdapter
            // 
            this.view_Total_ServicosTableAdapter.ClearBeforeFill = true;
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLocalizar.Image = global::ProjetoPetShop2022.Properties.Resources.icons8_pesquisar_256;
            this.btnLocalizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(40, 40);
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // frmAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(940, 601);
            this.Controls.Add(this.groupBoxAgendamentoServico);
            this.Controls.Add(this.agendamentoBindingNavigator);
            this.Controls.Add(this.groupBoxAgendamentos);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmAgendamento";
            this.Text = "frmAgendamento";
            this.Load += new System.EventHandler(this.frmAgendamento_Load);
            this.groupBoxAgendamentos.ResumeLayout(false);
            this.groupBoxAgendamentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPetshop2022)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingNavigator)).EndInit();
            this.agendamentoBindingNavigator.ResumeLayout(false);
            this.agendamentoBindingNavigator.PerformLayout();
            this.groupBoxAgendamentoServico.ResumeLayout(false);
            this.groupBoxAgendamentoServico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_AgendamentoServicosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_AgendamentoServicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamento_servicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Total_ServicosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAgendamentos;
        private System.Windows.Forms.ComboBox agend_situacaoComboBox;
        private System.Windows.Forms.MaskedTextBox agend_dataMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox agend_horarioMaskedTextBox;
        private System.Windows.Forms.TextBox txt_agend_ValorTotal;
        private System.Windows.Forms.BindingNavigator agendamentoBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnCriarNovo;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripButton btnFinalizar;
        private System.Windows.Forms.GroupBox groupBoxAgendamentoServico;
        private System.Windows.Forms.Button btnAdicionarServico;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtServico_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        
        private System.Windows.Forms.ComboBox anim_idComboBox;
        private System.Windows.Forms.TextBox txt_Tempo;
        private System.Windows.Forms.TextBox txtTempo;
        
        private System.Windows.Forms.DataGridView view_AgendamentoServicosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txt_agend_TempoTotal;
        private DataSetPetshop2022 dataSetPetshop2022;
        private System.Windows.Forms.BindingSource agendamentoBindingSource;
        private DataSetPetshop2022TableAdapters.agendamentoTableAdapter agendamentoTableAdapter;
        private DataSetPetshop2022TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txt_agend_id;
        private System.Windows.Forms.BindingSource view_AgendamentoServicosBindingSource;
        private DataSetPetshop2022TableAdapters.View_AgendamentoServicosTableAdapter view_AgendamentoServicosTableAdapter;
        private DataSetPetshop2022TableAdapters.animalTableAdapter animalTableAdapter;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private DataSetPetshop2022TableAdapters.servicoTableAdapter servicoTableAdapter;
        private System.Windows.Forms.BindingSource servicoBindingSource;
        private DataSetPetshop2022TableAdapters.agendamento_servicosTableAdapter agendamento_servicosTableAdapter;
        private System.Windows.Forms.BindingSource agendamento_servicosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn agendservidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agendidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servdescricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servtempoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agendservquantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agendservvalorunitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource view_Total_ServicosBindingSource;
        private DataSetPetshop2022TableAdapters.View_Total_ServicosTableAdapter view_Total_ServicosTableAdapter;
        private System.Windows.Forms.ToolStripButton btnLocalizar;
    }
}