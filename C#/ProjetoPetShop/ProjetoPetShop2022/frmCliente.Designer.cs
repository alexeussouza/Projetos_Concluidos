namespace ProjetoPetShop2022
{
    partial class frmCliente
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
            System.Windows.Forms.Label client_idLabel;
            System.Windows.Forms.Label client_cpfLabel;
            System.Windows.Forms.Label client_nomeLabel;
            System.Windows.Forms.Label client_enderecoLabel;
            System.Windows.Forms.Label client_bairroLabel;
            System.Windows.Forms.Label client_cidadeLabel;
            System.Windows.Forms.Label client_ufLabel;
            System.Windows.Forms.Label client_cepLabel;
            System.Windows.Forms.Label client_emailLabel;
            System.Windows.Forms.Label client_fotoLabel;
            System.Windows.Forms.Label client_telefoneLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.client_idLabel2 = new System.Windows.Forms.Label();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPetshop2022 = new ProjetoPetShop2022.DataSetPetshop2022();
            this.client_cpfMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.client_nomeTextBox = new System.Windows.Forms.TextBox();
            this.client_enderecoTextBox = new System.Windows.Forms.TextBox();
            this.client_bairroTextBox = new System.Windows.Forms.TextBox();
            this.client_cidadeTextBox = new System.Windows.Forms.TextBox();
            this.client_ufTextBox = new System.Windows.Forms.TextBox();
            this.client_cepMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.client_emailTextBox = new System.Windows.Forms.TextBox();
            this.client_fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.client_telefoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.clienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNovoItem = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnDeletar = new System.Windows.Forms.ToolStripButton();
            this.btnLocalizar = new System.Windows.Forms.ToolStripButton();
            this.clienteTableAdapter = new ProjetoPetShop2022.DataSetPetshop2022TableAdapters.clienteTableAdapter();
            this.tableAdapterManager = new ProjetoPetShop2022.DataSetPetshop2022TableAdapters.TableAdapterManager();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            client_idLabel = new System.Windows.Forms.Label();
            client_cpfLabel = new System.Windows.Forms.Label();
            client_nomeLabel = new System.Windows.Forms.Label();
            client_enderecoLabel = new System.Windows.Forms.Label();
            client_bairroLabel = new System.Windows.Forms.Label();
            client_cidadeLabel = new System.Windows.Forms.Label();
            client_ufLabel = new System.Windows.Forms.Label();
            client_cepLabel = new System.Windows.Forms.Label();
            client_emailLabel = new System.Windows.Forms.Label();
            client_fotoLabel = new System.Windows.Forms.Label();
            client_telefoneLabel = new System.Windows.Forms.Label();
            this.groupBoxCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPetshop2022)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).BeginInit();
            this.clienteBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // client_idLabel
            // 
            client_idLabel.AutoSize = true;
            client_idLabel.Location = new System.Drawing.Point(11, 56);
            client_idLabel.Name = "client_idLabel";
            client_idLabel.Size = new System.Drawing.Size(71, 24);
            client_idLabel.TabIndex = 0;
            client_idLabel.Text = "Codigo";
            // 
            // client_cpfLabel
            // 
            client_cpfLabel.AutoSize = true;
            client_cpfLabel.Location = new System.Drawing.Point(11, 99);
            client_cpfLabel.Name = "client_cpfLabel";
            client_cpfLabel.Size = new System.Drawing.Size(47, 24);
            client_cpfLabel.TabIndex = 2;
            client_cpfLabel.Text = "CPF";
            // 
            // client_nomeLabel
            // 
            client_nomeLabel.AutoSize = true;
            client_nomeLabel.Location = new System.Drawing.Point(11, 136);
            client_nomeLabel.Name = "client_nomeLabel";
            client_nomeLabel.Size = new System.Drawing.Size(62, 24);
            client_nomeLabel.TabIndex = 4;
            client_nomeLabel.Text = "Nome";
            // 
            // client_enderecoLabel
            // 
            client_enderecoLabel.AutoSize = true;
            client_enderecoLabel.Location = new System.Drawing.Point(11, 172);
            client_enderecoLabel.Name = "client_enderecoLabel";
            client_enderecoLabel.Size = new System.Drawing.Size(94, 24);
            client_enderecoLabel.TabIndex = 6;
            client_enderecoLabel.Text = "Endereço";
            // 
            // client_bairroLabel
            // 
            client_bairroLabel.AutoSize = true;
            client_bairroLabel.Location = new System.Drawing.Point(11, 244);
            client_bairroLabel.Name = "client_bairroLabel";
            client_bairroLabel.Size = new System.Drawing.Size(59, 24);
            client_bairroLabel.TabIndex = 8;
            client_bairroLabel.Text = "Bairro";
            // 
            // client_cidadeLabel
            // 
            client_cidadeLabel.AutoSize = true;
            client_cidadeLabel.Location = new System.Drawing.Point(419, 244);
            client_cidadeLabel.Name = "client_cidadeLabel";
            client_cidadeLabel.Size = new System.Drawing.Size(70, 24);
            client_cidadeLabel.TabIndex = 10;
            client_cidadeLabel.Text = "Cidade";
            // 
            // client_ufLabel
            // 
            client_ufLabel.AutoSize = true;
            client_ufLabel.Location = new System.Drawing.Point(628, 281);
            client_ufLabel.Name = "client_ufLabel";
            client_ufLabel.Size = new System.Drawing.Size(35, 24);
            client_ufLabel.TabIndex = 12;
            client_ufLabel.Text = "UF";
            // 
            // client_cepLabel
            // 
            client_cepLabel.AutoSize = true;
            client_cepLabel.Location = new System.Drawing.Point(419, 281);
            client_cepLabel.Name = "client_cepLabel";
            client_cepLabel.Size = new System.Drawing.Size(48, 24);
            client_cepLabel.TabIndex = 14;
            client_cepLabel.Text = "CEP";
            // 
            // client_emailLabel
            // 
            client_emailLabel.AutoSize = true;
            client_emailLabel.Location = new System.Drawing.Point(11, 209);
            client_emailLabel.Name = "client_emailLabel";
            client_emailLabel.Size = new System.Drawing.Size(57, 24);
            client_emailLabel.TabIndex = 16;
            client_emailLabel.Text = "Email";
            // 
            // client_fotoLabel
            // 
            client_fotoLabel.AutoSize = true;
            client_fotoLabel.Location = new System.Drawing.Point(685, 28);
            client_fotoLabel.Name = "client_fotoLabel";
            client_fotoLabel.Size = new System.Drawing.Size(48, 24);
            client_fotoLabel.TabIndex = 18;
            client_fotoLabel.Text = "Foto";
            // 
            // client_telefoneLabel
            // 
            client_telefoneLabel.AutoSize = true;
            client_telefoneLabel.Location = new System.Drawing.Point(11, 285);
            client_telefoneLabel.Name = "client_telefoneLabel";
            client_telefoneLabel.Size = new System.Drawing.Size(85, 24);
            client_telefoneLabel.TabIndex = 20;
            client_telefoneLabel.Text = "Telefone";
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.Controls.Add(this.btnFoto);
            this.groupBoxCliente.Controls.Add(this.client_idLabel2);
            this.groupBoxCliente.Controls.Add(client_idLabel);
            this.groupBoxCliente.Controls.Add(client_cpfLabel);
            this.groupBoxCliente.Controls.Add(this.client_cpfMaskedTextBox);
            this.groupBoxCliente.Controls.Add(client_nomeLabel);
            this.groupBoxCliente.Controls.Add(this.client_nomeTextBox);
            this.groupBoxCliente.Controls.Add(client_enderecoLabel);
            this.groupBoxCliente.Controls.Add(this.client_enderecoTextBox);
            this.groupBoxCliente.Controls.Add(client_bairroLabel);
            this.groupBoxCliente.Controls.Add(this.client_bairroTextBox);
            this.groupBoxCliente.Controls.Add(client_cidadeLabel);
            this.groupBoxCliente.Controls.Add(this.client_cidadeTextBox);
            this.groupBoxCliente.Controls.Add(client_ufLabel);
            this.groupBoxCliente.Controls.Add(this.client_ufTextBox);
            this.groupBoxCliente.Controls.Add(client_cepLabel);
            this.groupBoxCliente.Controls.Add(this.client_cepMaskedTextBox);
            this.groupBoxCliente.Controls.Add(client_emailLabel);
            this.groupBoxCliente.Controls.Add(this.client_emailTextBox);
            this.groupBoxCliente.Controls.Add(client_fotoLabel);
            this.groupBoxCliente.Controls.Add(this.client_fotoPictureBox);
            this.groupBoxCliente.Controls.Add(client_telefoneLabel);
            this.groupBoxCliente.Controls.Add(this.client_telefoneMaskedTextBox);
            this.groupBoxCliente.Enabled = false;
            this.groupBoxCliente.Location = new System.Drawing.Point(11, 42);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(917, 531);
            this.groupBoxCliente.TabIndex = 2;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Cadastro de Clientes";
            // 
            // btnFoto
            // 
            this.btnFoto.BackgroundImage = global::ProjetoPetShop2022.Properties.Resources.client;
            this.btnFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoto.Location = new System.Drawing.Point(800, 256);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(44, 53);
            this.btnFoto.TabIndex = 23;
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // client_idLabel2
            // 
            this.client_idLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "client_id", true));
            this.client_idLabel2.Location = new System.Drawing.Point(129, 56);
            this.client_idLabel2.Name = "client_idLabel2";
            this.client_idLabel2.Size = new System.Drawing.Size(100, 23);
            this.client_idLabel2.TabIndex = 22;
            this.client_idLabel2.Text = "label1";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.dataSetPetshop2022;
            // 
            // dataSetPetshop2022
            // 
            this.dataSetPetshop2022.DataSetName = "DataSetPetshop2022";
            this.dataSetPetshop2022.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // client_cpfMaskedTextBox
            // 
            this.client_cpfMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "client_cpf", true));
            this.client_cpfMaskedTextBox.Location = new System.Drawing.Point(133, 96);
            this.client_cpfMaskedTextBox.Mask = "999.999.999-99";
            this.client_cpfMaskedTextBox.Name = "client_cpfMaskedTextBox";
            this.client_cpfMaskedTextBox.Size = new System.Drawing.Size(220, 29);
            this.client_cpfMaskedTextBox.TabIndex = 3;
            // 
            // client_nomeTextBox
            // 
            this.client_nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "client_nome", true));
            this.client_nomeTextBox.Location = new System.Drawing.Point(133, 133);
            this.client_nomeTextBox.Name = "client_nomeTextBox";
            this.client_nomeTextBox.Size = new System.Drawing.Size(585, 29);
            this.client_nomeTextBox.TabIndex = 5;
            // 
            // client_enderecoTextBox
            // 
            this.client_enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "client_endereco", true));
            this.client_enderecoTextBox.Location = new System.Drawing.Point(133, 169);
            this.client_enderecoTextBox.Name = "client_enderecoTextBox";
            this.client_enderecoTextBox.Size = new System.Drawing.Size(585, 29);
            this.client_enderecoTextBox.TabIndex = 7;
            // 
            // client_bairroTextBox
            // 
            this.client_bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "client_bairro", true));
            this.client_bairroTextBox.Location = new System.Drawing.Point(133, 241);
            this.client_bairroTextBox.Name = "client_bairroTextBox";
            this.client_bairroTextBox.Size = new System.Drawing.Size(280, 29);
            this.client_bairroTextBox.TabIndex = 9;
            // 
            // client_cidadeTextBox
            // 
            this.client_cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "client_cidade", true));
            this.client_cidadeTextBox.Location = new System.Drawing.Point(495, 239);
            this.client_cidadeTextBox.Name = "client_cidadeTextBox";
            this.client_cidadeTextBox.Size = new System.Drawing.Size(223, 29);
            this.client_cidadeTextBox.TabIndex = 11;
            // 
            // client_ufTextBox
            // 
            this.client_ufTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "client_uf", true));
            this.client_ufTextBox.Location = new System.Drawing.Point(669, 276);
            this.client_ufTextBox.Name = "client_ufTextBox";
            this.client_ufTextBox.Size = new System.Drawing.Size(49, 29);
            this.client_ufTextBox.TabIndex = 13;
            // 
            // client_cepMaskedTextBox
            // 
            this.client_cepMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "client_cep", true));
            this.client_cepMaskedTextBox.Location = new System.Drawing.Point(495, 278);
            this.client_cepMaskedTextBox.Mask = "99999-999";
            this.client_cepMaskedTextBox.Name = "client_cepMaskedTextBox";
            this.client_cepMaskedTextBox.Size = new System.Drawing.Size(127, 29);
            this.client_cepMaskedTextBox.TabIndex = 15;
            // 
            // client_emailTextBox
            // 
            this.client_emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "client_email", true));
            this.client_emailTextBox.Location = new System.Drawing.Point(133, 206);
            this.client_emailTextBox.Name = "client_emailTextBox";
            this.client_emailTextBox.Size = new System.Drawing.Size(585, 29);
            this.client_emailTextBox.TabIndex = 17;
            // 
            // client_fotoPictureBox
            // 
            this.client_fotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.client_fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.clienteBindingSource, "client_foto", true));
            this.client_fotoPictureBox.Location = new System.Drawing.Point(739, 28);
            this.client_fotoPictureBox.Name = "client_fotoPictureBox";
            this.client_fotoPictureBox.Size = new System.Drawing.Size(165, 220);
            this.client_fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.client_fotoPictureBox.TabIndex = 19;
            this.client_fotoPictureBox.TabStop = false;
            // 
            // client_telefoneMaskedTextBox
            // 
            this.client_telefoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "client_telefone", true));
            this.client_telefoneMaskedTextBox.Location = new System.Drawing.Point(133, 280);
            this.client_telefoneMaskedTextBox.Mask = "(99) 99999-9999";
            this.client_telefoneMaskedTextBox.Name = "client_telefoneMaskedTextBox";
            this.client_telefoneMaskedTextBox.Size = new System.Drawing.Size(280, 29);
            this.client_telefoneMaskedTextBox.TabIndex = 21;
            // 
            // clienteBindingNavigator
            // 
            this.clienteBindingNavigator.AddNewItem = null;
            this.clienteBindingNavigator.BindingSource = this.clienteBindingSource;
            this.clienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clienteBindingNavigator.DeleteItem = null;
            this.clienteBindingNavigator.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.clienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnNovoItem,
            this.btnSalvar,
            this.btnEditar,
            this.btnCancelar,
            this.btnDeletar,
            this.btnLocalizar});
            this.clienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clienteBindingNavigator.Name = "clienteBindingNavigator";
            this.clienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clienteBindingNavigator.Size = new System.Drawing.Size(940, 43);
            this.clienteBindingNavigator.TabIndex = 3;
            this.clienteBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(46, 23);
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
            // btnNovoItem
            // 
            this.btnNovoItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovoItem.Image = global::ProjetoPetShop2022.Properties.Resources.icons8_mais_256;
            this.btnNovoItem.Name = "btnNovoItem";
            this.btnNovoItem.RightToLeftAutoMirrorImage = true;
            this.btnNovoItem.Size = new System.Drawing.Size(40, 40);
            this.btnNovoItem.Text = "Adicionar novo";
            this.btnNovoItem.Click += new System.EventHandler(this.btnNovoItem_Click);
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
            // btnDeletar
            // 
            this.btnDeletar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeletar.Image = global::ProjetoPetShop2022.Properties.Resources.icons8_remover_256;
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.RightToLeftAutoMirrorImage = true;
            this.btnDeletar.Size = new System.Drawing.Size(40, 40);
            this.btnDeletar.Text = "Excluir";
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.BackColor = System.Drawing.Color.Transparent;
            this.btnLocalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLocalizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLocalizar.Image = global::ProjetoPetShop2022.Properties.Resources.icons8_pesquisar_256;
            this.btnLocalizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(40, 40);
            this.btnLocalizar.Text = "toolStripButton1";
            this.btnLocalizar.ToolTipText = "Localizar";
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendamento_servicosTableAdapter = null;
            this.tableAdapterManager.agendamentoTableAdapter = null;
            this.tableAdapterManager.animalTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.racaTableAdapter = null;
            this.tableAdapterManager.servicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoPetShop2022.DataSetPetshop2022TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Title = "Escolha sua foto:";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(940, 585);
            this.Controls.Add(this.clienteBindingNavigator);
            this.Controls.Add(this.groupBoxCliente);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPetshop2022)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).EndInit();
            this.clienteBindingNavigator.ResumeLayout(false);
            this.clienteBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.MaskedTextBox client_cpfMaskedTextBox;
        private System.Windows.Forms.TextBox client_nomeTextBox;
        private System.Windows.Forms.TextBox client_enderecoTextBox;
        private System.Windows.Forms.TextBox client_bairroTextBox;
        private System.Windows.Forms.TextBox client_cidadeTextBox;
        private System.Windows.Forms.TextBox client_ufTextBox;
        private System.Windows.Forms.MaskedTextBox client_cepMaskedTextBox;
        private System.Windows.Forms.TextBox client_emailTextBox;
        private System.Windows.Forms.PictureBox client_fotoPictureBox;
        private System.Windows.Forms.MaskedTextBox client_telefoneMaskedTextBox;
        private System.Windows.Forms.BindingNavigator clienteBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnNovoItem;
        private System.Windows.Forms.ToolStripButton btnDeletar;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private DataSetPetshop2022 dataSetPetshop2022;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DataSetPetshop2022TableAdapters.clienteTableAdapter clienteTableAdapter;
        private DataSetPetshop2022TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label client_idLabel2;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripButton btnLocalizar;
    }
}