namespace ProjetoPetShop2022
{
    partial class frmAnimal
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
            System.Windows.Forms.Label anim_idLabel;
            System.Windows.Forms.Label client_idLabel;
            System.Windows.Forms.Label anim_nomeLabel;
            System.Windows.Forms.Label anim_agressivoLabel;
            System.Windows.Forms.Label anim_sexoLabel;
            System.Windows.Forms.Label anim_corLabel;
            System.Windows.Forms.Label anim_idadeLabel;
            System.Windows.Forms.Label anim_alergiaLabel;
            System.Windows.Forms.Label anim_fotoLabel;
            System.Windows.Forms.Label raca_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnimal));
            this.groupBoxAnimal = new System.Windows.Forms.GroupBox();
            this.anim_fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPetshop2022 = new ProjetoPetShop2022.DataSetPetshop2022();
            this.anim_idLabel3 = new System.Windows.Forms.Label();
            this.anim_alergiaComboBox = new System.Windows.Forms.ComboBox();
            this.bntFoto = new System.Windows.Forms.Button();
            this.client_idComboBox = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anim_nomeTextBox = new System.Windows.Forms.TextBox();
            this.anim_agressivoComboBox = new System.Windows.Forms.ComboBox();
            this.anim_sexoComboBox = new System.Windows.Forms.ComboBox();
            this.anim_corComboBox = new System.Windows.Forms.ComboBox();
            this.anim_idadeTextBox = new System.Windows.Forms.TextBox();
            this.raca_idComboBox = new System.Windows.Forms.ComboBox();
            this.racaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.animalBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.btnLocalizar = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.animalTableAdapter = new ProjetoPetShop2022.DataSetPetshop2022TableAdapters.animalTableAdapter();
            this.tableAdapterManager = new ProjetoPetShop2022.DataSetPetshop2022TableAdapters.TableAdapterManager();
            this.clienteTableAdapter = new ProjetoPetShop2022.DataSetPetshop2022TableAdapters.clienteTableAdapter();
            this.racaTableAdapter = new ProjetoPetShop2022.DataSetPetshop2022TableAdapters.racaTableAdapter();
            anim_idLabel = new System.Windows.Forms.Label();
            client_idLabel = new System.Windows.Forms.Label();
            anim_nomeLabel = new System.Windows.Forms.Label();
            anim_agressivoLabel = new System.Windows.Forms.Label();
            anim_sexoLabel = new System.Windows.Forms.Label();
            anim_corLabel = new System.Windows.Forms.Label();
            anim_idadeLabel = new System.Windows.Forms.Label();
            anim_alergiaLabel = new System.Windows.Forms.Label();
            anim_fotoLabel = new System.Windows.Forms.Label();
            raca_idLabel = new System.Windows.Forms.Label();
            this.groupBoxAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anim_fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPetshop2022)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingNavigator)).BeginInit();
            this.animalBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // anim_idLabel
            // 
            anim_idLabel.AutoSize = true;
            anim_idLabel.Location = new System.Drawing.Point(14, 46);
            anim_idLabel.Name = "anim_idLabel";
            anim_idLabel.Size = new System.Drawing.Size(71, 24);
            anim_idLabel.TabIndex = 0;
            anim_idLabel.Text = "Codigo";
            // 
            // client_idLabel
            // 
            client_idLabel.AutoSize = true;
            client_idLabel.Location = new System.Drawing.Point(14, 85);
            client_idLabel.Name = "client_idLabel";
            client_idLabel.Size = new System.Drawing.Size(68, 24);
            client_idLabel.TabIndex = 2;
            client_idLabel.Text = "Cliente";
            // 
            // anim_nomeLabel
            // 
            anim_nomeLabel.AutoSize = true;
            anim_nomeLabel.Location = new System.Drawing.Point(14, 124);
            anim_nomeLabel.Name = "anim_nomeLabel";
            anim_nomeLabel.Size = new System.Drawing.Size(62, 24);
            anim_nomeLabel.TabIndex = 4;
            anim_nomeLabel.Text = "Nome";
            // 
            // anim_agressivoLabel
            // 
            anim_agressivoLabel.AutoSize = true;
            anim_agressivoLabel.Location = new System.Drawing.Point(14, 243);
            anim_agressivoLabel.Name = "anim_agressivoLabel";
            anim_agressivoLabel.Size = new System.Drawing.Size(93, 24);
            anim_agressivoLabel.TabIndex = 6;
            anim_agressivoLabel.Text = "Agressivo";
            // 
            // anim_sexoLabel
            // 
            anim_sexoLabel.AutoSize = true;
            anim_sexoLabel.Location = new System.Drawing.Point(308, 207);
            anim_sexoLabel.Name = "anim_sexoLabel";
            anim_sexoLabel.Size = new System.Drawing.Size(54, 24);
            anim_sexoLabel.TabIndex = 8;
            anim_sexoLabel.Text = "Sexo";
            // 
            // anim_corLabel
            // 
            anim_corLabel.AutoSize = true;
            anim_corLabel.Location = new System.Drawing.Point(308, 245);
            anim_corLabel.Name = "anim_corLabel";
            anim_corLabel.Size = new System.Drawing.Size(40, 24);
            anim_corLabel.TabIndex = 10;
            anim_corLabel.Text = "Cor";
            // 
            // anim_idadeLabel
            // 
            anim_idadeLabel.AutoSize = true;
            anim_idadeLabel.Location = new System.Drawing.Point(14, 286);
            anim_idadeLabel.Name = "anim_idadeLabel";
            anim_idadeLabel.Size = new System.Drawing.Size(57, 24);
            anim_idadeLabel.TabIndex = 12;
            anim_idadeLabel.Text = "Idade";
            // 
            // anim_alergiaLabel
            // 
            anim_alergiaLabel.AutoSize = true;
            anim_alergiaLabel.Location = new System.Drawing.Point(14, 195);
            anim_alergiaLabel.Name = "anim_alergiaLabel";
            anim_alergiaLabel.Size = new System.Drawing.Size(69, 24);
            anim_alergiaLabel.TabIndex = 14;
            anim_alergiaLabel.Text = "Alergia";
            // 
            // anim_fotoLabel
            // 
            anim_fotoLabel.AutoSize = true;
            anim_fotoLabel.Location = new System.Drawing.Point(648, 46);
            anim_fotoLabel.Name = "anim_fotoLabel";
            anim_fotoLabel.Size = new System.Drawing.Size(48, 24);
            anim_fotoLabel.TabIndex = 16;
            anim_fotoLabel.Text = "Foto";
            // 
            // raca_idLabel
            // 
            raca_idLabel.AutoSize = true;
            raca_idLabel.Location = new System.Drawing.Point(14, 160);
            raca_idLabel.Name = "raca_idLabel";
            raca_idLabel.Size = new System.Drawing.Size(53, 24);
            raca_idLabel.TabIndex = 18;
            raca_idLabel.Text = "Raca";
            // 
            // groupBoxAnimal
            // 
            this.groupBoxAnimal.Controls.Add(this.anim_fotoPictureBox);
            this.groupBoxAnimal.Controls.Add(this.anim_idLabel3);
            this.groupBoxAnimal.Controls.Add(this.anim_alergiaComboBox);
            this.groupBoxAnimal.Controls.Add(this.bntFoto);
            this.groupBoxAnimal.Controls.Add(anim_idLabel);
            this.groupBoxAnimal.Controls.Add(client_idLabel);
            this.groupBoxAnimal.Controls.Add(this.client_idComboBox);
            this.groupBoxAnimal.Controls.Add(anim_nomeLabel);
            this.groupBoxAnimal.Controls.Add(this.anim_nomeTextBox);
            this.groupBoxAnimal.Controls.Add(anim_agressivoLabel);
            this.groupBoxAnimal.Controls.Add(this.anim_agressivoComboBox);
            this.groupBoxAnimal.Controls.Add(anim_sexoLabel);
            this.groupBoxAnimal.Controls.Add(this.anim_sexoComboBox);
            this.groupBoxAnimal.Controls.Add(anim_corLabel);
            this.groupBoxAnimal.Controls.Add(this.anim_corComboBox);
            this.groupBoxAnimal.Controls.Add(anim_idadeLabel);
            this.groupBoxAnimal.Controls.Add(this.anim_idadeTextBox);
            this.groupBoxAnimal.Controls.Add(anim_alergiaLabel);
            this.groupBoxAnimal.Controls.Add(anim_fotoLabel);
            this.groupBoxAnimal.Controls.Add(raca_idLabel);
            this.groupBoxAnimal.Controls.Add(this.raca_idComboBox);
            this.groupBoxAnimal.Enabled = false;
            this.groupBoxAnimal.Location = new System.Drawing.Point(11, 42);
            this.groupBoxAnimal.Name = "groupBoxAnimal";
            this.groupBoxAnimal.Size = new System.Drawing.Size(915, 531);
            this.groupBoxAnimal.TabIndex = 0;
            this.groupBoxAnimal.TabStop = false;
            this.groupBoxAnimal.Text = "Cadastro Animal";
            // 
            // anim_fotoPictureBox
            // 
            this.anim_fotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.anim_fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.animalBindingSource, "anim_foto", true));
            this.anim_fotoPictureBox.Location = new System.Drawing.Point(719, 28);
            this.anim_fotoPictureBox.Name = "anim_fotoPictureBox";
            this.anim_fotoPictureBox.Size = new System.Drawing.Size(180, 230);
            this.anim_fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anim_fotoPictureBox.TabIndex = 25;
            this.anim_fotoPictureBox.TabStop = false;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "animal";
            this.animalBindingSource.DataSource = this.dataSetPetshop2022;
            // 
            // dataSetPetshop2022
            // 
            this.dataSetPetshop2022.DataSetName = "DataSetPetshop2022";
            this.dataSetPetshop2022.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // anim_idLabel3
            // 
            this.anim_idLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "anim_id", true));
            this.anim_idLabel3.Location = new System.Drawing.Point(106, 46);
            this.anim_idLabel3.Name = "anim_idLabel3";
            this.anim_idLabel3.Size = new System.Drawing.Size(100, 23);
            this.anim_idLabel3.TabIndex = 24;
            this.anim_idLabel3.Text = "label1";
            // 
            // anim_alergiaComboBox
            // 
            this.anim_alergiaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "anim_alergia", true));
            this.anim_alergiaComboBox.FormattingEnabled = true;
            this.anim_alergiaComboBox.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.anim_alergiaComboBox.Location = new System.Drawing.Point(110, 197);
            this.anim_alergiaComboBox.Name = "anim_alergiaComboBox";
            this.anim_alergiaComboBox.Size = new System.Drawing.Size(169, 32);
            this.anim_alergiaComboBox.TabIndex = 22;
            // 
            // bntFoto
            // 
            this.bntFoto.BackgroundImage = global::ProjetoPetShop2022.Properties.Resources.bunny_rabbit;
            this.bntFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntFoto.Location = new System.Drawing.Point(775, 269);
            this.bntFoto.Name = "bntFoto";
            this.bntFoto.Size = new System.Drawing.Size(56, 64);
            this.bntFoto.TabIndex = 20;
            this.bntFoto.UseVisualStyleBackColor = true;
            this.bntFoto.Click += new System.EventHandler(this.bntFoto_Click);
            // 
            // client_idComboBox
            // 
            this.client_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.animalBindingSource, "client_id", true));
            this.client_idComboBox.DataSource = this.clienteBindingSource;
            this.client_idComboBox.DisplayMember = "client_nome";
            this.client_idComboBox.FormattingEnabled = true;
            this.client_idComboBox.Location = new System.Drawing.Point(110, 85);
            this.client_idComboBox.Name = "client_idComboBox";
            this.client_idComboBox.Size = new System.Drawing.Size(529, 32);
            this.client_idComboBox.TabIndex = 1;
            this.client_idComboBox.ValueMember = "client_id";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.dataSetPetshop2022;
            // 
            // anim_nomeTextBox
            // 
            this.anim_nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "anim_nome", true));
            this.anim_nomeTextBox.Location = new System.Drawing.Point(110, 123);
            this.anim_nomeTextBox.Name = "anim_nomeTextBox";
            this.anim_nomeTextBox.Size = new System.Drawing.Size(529, 29);
            this.anim_nomeTextBox.TabIndex = 2;
            // 
            // anim_agressivoComboBox
            // 
            this.anim_agressivoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "anim_agressivo", true));
            this.anim_agressivoComboBox.FormattingEnabled = true;
            this.anim_agressivoComboBox.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.anim_agressivoComboBox.Location = new System.Drawing.Point(110, 237);
            this.anim_agressivoComboBox.Name = "anim_agressivoComboBox";
            this.anim_agressivoComboBox.Size = new System.Drawing.Size(169, 32);
            this.anim_agressivoComboBox.TabIndex = 5;
            // 
            // anim_sexoComboBox
            // 
            this.anim_sexoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "anim_sexo", true));
            this.anim_sexoComboBox.FormattingEnabled = true;
            this.anim_sexoComboBox.Items.AddRange(new object[] {
            "Macho",
            "Femea"});
            this.anim_sexoComboBox.Location = new System.Drawing.Point(368, 199);
            this.anim_sexoComboBox.Name = "anim_sexoComboBox";
            this.anim_sexoComboBox.Size = new System.Drawing.Size(271, 32);
            this.anim_sexoComboBox.TabIndex = 6;
            // 
            // anim_corComboBox
            // 
            this.anim_corComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "anim_cor", true));
            this.anim_corComboBox.FormattingEnabled = true;
            this.anim_corComboBox.Items.AddRange(new object[] {
            "Preto",
            "Branco",
            "Caramelo",
            "Cinza",
            "Outros"});
            this.anim_corComboBox.Location = new System.Drawing.Point(368, 237);
            this.anim_corComboBox.Name = "anim_corComboBox";
            this.anim_corComboBox.Size = new System.Drawing.Size(271, 32);
            this.anim_corComboBox.TabIndex = 7;
            // 
            // anim_idadeTextBox
            // 
            this.anim_idadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "anim_idade", true));
            this.anim_idadeTextBox.Location = new System.Drawing.Point(110, 286);
            this.anim_idadeTextBox.Name = "anim_idadeTextBox";
            this.anim_idadeTextBox.Size = new System.Drawing.Size(169, 29);
            this.anim_idadeTextBox.TabIndex = 8;
            // 
            // raca_idComboBox
            // 
            this.raca_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.animalBindingSource, "raca_id", true));
            this.raca_idComboBox.DataSource = this.racaBindingSource;
            this.raca_idComboBox.DisplayMember = "raca_nome";
            this.raca_idComboBox.FormattingEnabled = true;
            this.raca_idComboBox.Location = new System.Drawing.Point(110, 159);
            this.raca_idComboBox.Name = "raca_idComboBox";
            this.raca_idComboBox.Size = new System.Drawing.Size(529, 32);
            this.raca_idComboBox.TabIndex = 3;
            this.raca_idComboBox.ValueMember = "raca_id";
            // 
            // racaBindingSource
            // 
            this.racaBindingSource.DataMember = "raca";
            this.racaBindingSource.DataSource = this.dataSetPetshop2022;
            // 
            // animalBindingNavigator
            // 
            this.animalBindingNavigator.AddNewItem = null;
            this.animalBindingNavigator.BindingSource = this.animalBindingSource;
            this.animalBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.animalBindingNavigator.DeleteItem = null;
            this.animalBindingNavigator.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.animalBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.animalBindingNavigatorSaveItem,
            this.btnEditar,
            this.btnCancelar,
            this.bindingNavigatorDeleteItem,
            this.btnLocalizar});
            this.animalBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.animalBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.animalBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.animalBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.animalBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.animalBindingNavigator.Name = "animalBindingNavigator";
            this.animalBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.animalBindingNavigator.Size = new System.Drawing.Size(938, 43);
            this.animalBindingNavigator.TabIndex = 1;
            this.animalBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = global::ProjetoPetShop2022.Properties.Resources.icons8_mais_256;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(40, 40);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // animalBindingNavigatorSaveItem
            // 
            this.animalBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.animalBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("animalBindingNavigatorSaveItem.Image")));
            this.animalBindingNavigatorSaveItem.Name = "animalBindingNavigatorSaveItem";
            this.animalBindingNavigatorSaveItem.Size = new System.Drawing.Size(40, 40);
            this.animalBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.animalBindingNavigatorSaveItem.Click += new System.EventHandler(this.animalBindingNavigatorSaveItem_Click);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = global::ProjetoPetShop2022.Properties.Resources.icons8_remover_256;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(40, 40);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Title = "Escolha uma foto: ";
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendamento_servicosTableAdapter = null;
            this.tableAdapterManager.agendamentoTableAdapter = null;
            this.tableAdapterManager.animalTableAdapter = this.animalTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.racaTableAdapter = this.racaTableAdapter;
            this.tableAdapterManager.servicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoPetShop2022.DataSetPetshop2022TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // racaTableAdapter
            // 
            this.racaTableAdapter.ClearBeforeFill = true;
            // 
            // frmAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(938, 585);
            this.Controls.Add(this.animalBindingNavigator);
            this.Controls.Add(this.groupBoxAnimal);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmAnimal";
            this.Text = "frmAnimal";
            this.Load += new System.EventHandler(this.frmAnimal_Load);
            this.groupBoxAnimal.ResumeLayout(false);
            this.groupBoxAnimal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anim_fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPetshop2022)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingNavigator)).EndInit();
            this.animalBindingNavigator.ResumeLayout(false);
            this.animalBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAnimal;
        private System.Windows.Forms.BindingNavigator animalBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton animalBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox client_idComboBox;
        private System.Windows.Forms.TextBox anim_nomeTextBox;
        private System.Windows.Forms.ComboBox anim_agressivoComboBox;
        private System.Windows.Forms.ComboBox anim_sexoComboBox;
        private System.Windows.Forms.ComboBox anim_corComboBox;
        private System.Windows.Forms.TextBox anim_idadeTextBox;
        private System.Windows.Forms.ComboBox raca_idComboBox;
        private System.Windows.Forms.Button bntFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ComboBox anim_alergiaComboBox;
        private DataSetPetshop2022 dataSetPetshop2022;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private DataSetPetshop2022TableAdapters.animalTableAdapter animalTableAdapter;
        private DataSetPetshop2022TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label anim_idLabel3;
        private DataSetPetshop2022TableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DataSetPetshop2022TableAdapters.racaTableAdapter racaTableAdapter;
        private System.Windows.Forms.BindingSource racaBindingSource;
        private System.Windows.Forms.PictureBox anim_fotoPictureBox;
        private System.Windows.Forms.ToolStripButton btnLocalizar;
    }
}