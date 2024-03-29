﻿namespace LineOfBands.App.Forms
{
    partial class UcStations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcStations));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCode = new MetroFramework.Controls.MetroTextBox();
            this.cmbType = new MetroFramework.Controls.MetroComboBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.btnNew = new MetroFramework.Controls.MetroTile();
            this.btnRemove = new MetroFramework.Controls.MetroTile();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.btnSearch = new MetroFramework.Controls.MetroTile();
            this.BtnBack = new MetroFramework.Controls.MetroLink();
            this.lblCode = new MetroFramework.Controls.MetroLabel();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.lblType = new MetroFramework.Controls.MetroLabel();
            this.pnHead = new MetroFramework.Controls.MetroPanel();
            this.pnFooter = new MetroFramework.Controls.MetroPanel();
            this.pnRightFooter = new MetroFramework.Controls.MetroPanel();
            this.pnContent = new MetroFramework.Controls.MetroPanel();
            this.tabControlContent = new MetroFramework.Controls.MetroTabControl();
            this.tabData = new MetroFramework.Controls.MetroTabPage();
            this.txtDataAddress = new MetroFramework.Controls.MetroTextBox();
            this.txtStatusDataChangeAddressAck = new MetroFramework.Controls.MetroTextBox();
            this.txtStatusDataChangeAddress = new MetroFramework.Controls.MetroTextBox();
            this.lblDataAddress = new MetroFramework.Controls.MetroLabel();
            this.lblStatusDataChangeAddressAck = new MetroFramework.Controls.MetroLabel();
            this.lblStatusDataChangeAddress = new MetroFramework.Controls.MetroLabel();
            this.tabSearch = new MetroFramework.Controls.MetroTabPage();
            this.DataGridSearch = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataChangeAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataChangeAddressAckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusChangeS7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusChangeS7AckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAddressS7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusChangeOpcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusChangeOpcAckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAddressOpcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataContentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnHead.SuspendLayout();
            this.pnFooter.SuspendLayout();
            this.pnRightFooter.SuspendLayout();
            this.pnContent.SuspendLayout();
            this.tabControlContent.SuspendLayout();
            this.tabData.SuspendLayout();
            this.tabSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCode
            // 
            // 
            // 
            // 
            this.txtCode.CustomButton.Image = null;
            this.txtCode.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txtCode.CustomButton.Name = "";
            this.txtCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCode.CustomButton.TabIndex = 1;
            this.txtCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCode.CustomButton.UseSelectable = true;
            this.txtCode.CustomButton.UseWaitCursor = true;
            this.txtCode.CustomButton.Visible = false;
            this.txtCode.Lines = new string[0];
            this.txtCode.Location = new System.Drawing.Point(213, 28);
            this.txtCode.MaxLength = 32767;
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCode.SelectedText = "";
            this.txtCode.SelectionLength = 0;
            this.txtCode.SelectionStart = 0;
            this.txtCode.ShortcutsEnabled = true;
            this.txtCode.Size = new System.Drawing.Size(155, 23);
            this.txtCode.TabIndex = 0;
            this.txtCode.UseSelectable = true;
            this.txtCode.UseWaitCursor = true;
            this.txtCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbType
            // 
            this.cmbType.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.ItemHeight = 19;
            this.cmbType.Location = new System.Drawing.Point(213, 92);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(155, 25);
            this.cmbType.TabIndex = 2;
            this.cmbType.UseSelectable = true;
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(213, 60);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(155, 23);
            this.txtName.TabIndex = 4;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnNew
            // 
            this.btnNew.ActiveControl = null;
            this.btnNew.Location = new System.Drawing.Point(17, 9);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(131, 37);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "Nuevo";
            this.btnNew.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnNew.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnNew.UseSelectable = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.ActiveControl = null;
            this.btnRemove.Location = new System.Drawing.Point(154, 9);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(131, 37);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Eliminar";
            this.btnRemove.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnRemove.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnRemove.UseSelectable = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSave
            // 
            this.btnSave.ActiveControl = null;
            this.btnSave.Location = new System.Drawing.Point(291, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 37);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Guardar";
            this.btnSave.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnSave.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.ActiveControl = null;
            this.btnSearch.Location = new System.Drawing.Point(8, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(230, 37);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnSearch.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.ImageSize = 40;
            this.BtnBack.Location = new System.Drawing.Point(8, 4);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(59, 46);
            this.BtnBack.TabIndex = 13;
            this.BtnBack.UseSelectable = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(33, 28);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(53, 19);
            this.lblCode.TabIndex = 14;
            this.lblCode.Text = "Código";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(33, 60);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 19);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Nombre";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(33, 92);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(35, 19);
            this.lblType.TabIndex = 16;
            this.lblType.Text = "Tipo";
            // 
            // pnHead
            // 
            this.pnHead.Controls.Add(this.BtnBack);
            this.pnHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHead.HorizontalScrollbarBarColor = true;
            this.pnHead.HorizontalScrollbarHighlightOnWheel = false;
            this.pnHead.HorizontalScrollbarSize = 10;
            this.pnHead.Location = new System.Drawing.Point(0, 0);
            this.pnHead.Name = "pnHead";
            this.pnHead.Size = new System.Drawing.Size(776, 54);
            this.pnHead.TabIndex = 17;
            this.pnHead.VerticalScrollbarBarColor = true;
            this.pnHead.VerticalScrollbarHighlightOnWheel = false;
            this.pnHead.VerticalScrollbarSize = 10;
            // 
            // pnFooter
            // 
            this.pnFooter.Controls.Add(this.pnRightFooter);
            this.pnFooter.Controls.Add(this.btnSearch);
            this.pnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnFooter.HorizontalScrollbarBarColor = true;
            this.pnFooter.HorizontalScrollbarHighlightOnWheel = false;
            this.pnFooter.HorizontalScrollbarSize = 10;
            this.pnFooter.Location = new System.Drawing.Point(0, 411);
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(776, 59);
            this.pnFooter.Style = MetroFramework.MetroColorStyle.Lime;
            this.pnFooter.TabIndex = 18;
            this.pnFooter.VerticalScrollbarBarColor = true;
            this.pnFooter.VerticalScrollbarHighlightOnWheel = false;
            this.pnFooter.VerticalScrollbarSize = 10;
            // 
            // pnRightFooter
            // 
            this.pnRightFooter.Controls.Add(this.btnRemove);
            this.pnRightFooter.Controls.Add(this.btnNew);
            this.pnRightFooter.Controls.Add(this.btnSave);
            this.pnRightFooter.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnRightFooter.HorizontalScrollbarBarColor = true;
            this.pnRightFooter.HorizontalScrollbarHighlightOnWheel = false;
            this.pnRightFooter.HorizontalScrollbarSize = 10;
            this.pnRightFooter.Location = new System.Drawing.Point(336, 0);
            this.pnRightFooter.Name = "pnRightFooter";
            this.pnRightFooter.Size = new System.Drawing.Size(440, 59);
            this.pnRightFooter.TabIndex = 13;
            this.pnRightFooter.VerticalScrollbarBarColor = true;
            this.pnRightFooter.VerticalScrollbarHighlightOnWheel = false;
            this.pnRightFooter.VerticalScrollbarSize = 10;
            // 
            // pnContent
            // 
            this.pnContent.Controls.Add(this.tabControlContent);
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.HorizontalScrollbarBarColor = true;
            this.pnContent.HorizontalScrollbarHighlightOnWheel = false;
            this.pnContent.HorizontalScrollbarSize = 10;
            this.pnContent.Location = new System.Drawing.Point(0, 54);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(776, 357);
            this.pnContent.TabIndex = 19;
            this.pnContent.VerticalScrollbarBarColor = true;
            this.pnContent.VerticalScrollbarHighlightOnWheel = false;
            this.pnContent.VerticalScrollbarSize = 10;
            // 
            // tabControlContent
            // 
            this.tabControlContent.Controls.Add(this.tabData);
            this.tabControlContent.Controls.Add(this.tabSearch);
            this.tabControlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlContent.Location = new System.Drawing.Point(0, 0);
            this.tabControlContent.Name = "tabControlContent";
            this.tabControlContent.SelectedIndex = 0;
            this.tabControlContent.Size = new System.Drawing.Size(776, 357);
            this.tabControlContent.TabIndex = 17;
            this.tabControlContent.UseSelectable = true;
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.txtDataAddress);
            this.tabData.Controls.Add(this.txtStatusDataChangeAddressAck);
            this.tabData.Controls.Add(this.txtStatusDataChangeAddress);
            this.tabData.Controls.Add(this.lblDataAddress);
            this.tabData.Controls.Add(this.lblStatusDataChangeAddressAck);
            this.tabData.Controls.Add(this.lblStatusDataChangeAddress);
            this.tabData.Controls.Add(this.lblCode);
            this.tabData.Controls.Add(this.lblName);
            this.tabData.Controls.Add(this.txtName);
            this.tabData.Controls.Add(this.lblType);
            this.tabData.Controls.Add(this.cmbType);
            this.tabData.Controls.Add(this.txtCode);
            this.tabData.HorizontalScrollbarBarColor = true;
            this.tabData.HorizontalScrollbarHighlightOnWheel = false;
            this.tabData.HorizontalScrollbarSize = 10;
            this.tabData.Location = new System.Drawing.Point(4, 38);
            this.tabData.Name = "tabData";
            this.tabData.Size = new System.Drawing.Size(768, 315);
            this.tabData.TabIndex = 0;
            this.tabData.Text = "Ficha";
            this.tabData.VerticalScrollbarBarColor = true;
            this.tabData.VerticalScrollbarHighlightOnWheel = false;
            this.tabData.VerticalScrollbarSize = 10;
            // 
            // txtDataAddress
            // 
            // 
            // 
            // 
            this.txtDataAddress.CustomButton.Image = null;
            this.txtDataAddress.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txtDataAddress.CustomButton.Name = "";
            this.txtDataAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDataAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDataAddress.CustomButton.TabIndex = 1;
            this.txtDataAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDataAddress.CustomButton.UseSelectable = true;
            this.txtDataAddress.CustomButton.UseWaitCursor = true;
            this.txtDataAddress.CustomButton.Visible = false;
            this.txtDataAddress.Lines = new string[0];
            this.txtDataAddress.Location = new System.Drawing.Point(213, 190);
            this.txtDataAddress.MaxLength = 32767;
            this.txtDataAddress.Name = "txtDataAddress";
            this.txtDataAddress.PasswordChar = '\0';
            this.txtDataAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDataAddress.SelectedText = "";
            this.txtDataAddress.SelectionLength = 0;
            this.txtDataAddress.SelectionStart = 0;
            this.txtDataAddress.ShortcutsEnabled = true;
            this.txtDataAddress.Size = new System.Drawing.Size(155, 23);
            this.txtDataAddress.TabIndex = 22;
            this.txtDataAddress.UseSelectable = true;
            this.txtDataAddress.UseWaitCursor = true;
            this.txtDataAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDataAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtStatusDataChangeAddressAck
            // 
            // 
            // 
            // 
            this.txtStatusDataChangeAddressAck.CustomButton.Image = null;
            this.txtStatusDataChangeAddressAck.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txtStatusDataChangeAddressAck.CustomButton.Name = "";
            this.txtStatusDataChangeAddressAck.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStatusDataChangeAddressAck.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStatusDataChangeAddressAck.CustomButton.TabIndex = 1;
            this.txtStatusDataChangeAddressAck.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStatusDataChangeAddressAck.CustomButton.UseSelectable = true;
            this.txtStatusDataChangeAddressAck.CustomButton.UseWaitCursor = true;
            this.txtStatusDataChangeAddressAck.CustomButton.Visible = false;
            this.txtStatusDataChangeAddressAck.Lines = new string[0];
            this.txtStatusDataChangeAddressAck.Location = new System.Drawing.Point(213, 158);
            this.txtStatusDataChangeAddressAck.MaxLength = 32767;
            this.txtStatusDataChangeAddressAck.Name = "txtStatusDataChangeAddressAck";
            this.txtStatusDataChangeAddressAck.PasswordChar = '\0';
            this.txtStatusDataChangeAddressAck.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStatusDataChangeAddressAck.SelectedText = "";
            this.txtStatusDataChangeAddressAck.SelectionLength = 0;
            this.txtStatusDataChangeAddressAck.SelectionStart = 0;
            this.txtStatusDataChangeAddressAck.ShortcutsEnabled = true;
            this.txtStatusDataChangeAddressAck.Size = new System.Drawing.Size(155, 23);
            this.txtStatusDataChangeAddressAck.TabIndex = 21;
            this.txtStatusDataChangeAddressAck.UseSelectable = true;
            this.txtStatusDataChangeAddressAck.UseWaitCursor = true;
            this.txtStatusDataChangeAddressAck.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStatusDataChangeAddressAck.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtStatusDataChangeAddress
            // 
            // 
            // 
            // 
            this.txtStatusDataChangeAddress.CustomButton.Image = null;
            this.txtStatusDataChangeAddress.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txtStatusDataChangeAddress.CustomButton.Name = "";
            this.txtStatusDataChangeAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStatusDataChangeAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStatusDataChangeAddress.CustomButton.TabIndex = 1;
            this.txtStatusDataChangeAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStatusDataChangeAddress.CustomButton.UseSelectable = true;
            this.txtStatusDataChangeAddress.CustomButton.UseWaitCursor = true;
            this.txtStatusDataChangeAddress.CustomButton.Visible = false;
            this.txtStatusDataChangeAddress.Lines = new string[0];
            this.txtStatusDataChangeAddress.Location = new System.Drawing.Point(213, 126);
            this.txtStatusDataChangeAddress.MaxLength = 32767;
            this.txtStatusDataChangeAddress.Name = "txtStatusDataChangeAddress";
            this.txtStatusDataChangeAddress.PasswordChar = '\0';
            this.txtStatusDataChangeAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStatusDataChangeAddress.SelectedText = "";
            this.txtStatusDataChangeAddress.SelectionLength = 0;
            this.txtStatusDataChangeAddress.SelectionStart = 0;
            this.txtStatusDataChangeAddress.ShortcutsEnabled = true;
            this.txtStatusDataChangeAddress.Size = new System.Drawing.Size(155, 23);
            this.txtStatusDataChangeAddress.TabIndex = 20;
            this.txtStatusDataChangeAddress.UseSelectable = true;
            this.txtStatusDataChangeAddress.UseWaitCursor = true;
            this.txtStatusDataChangeAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStatusDataChangeAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDataAddress
            // 
            this.lblDataAddress.AutoSize = true;
            this.lblDataAddress.Location = new System.Drawing.Point(33, 188);
            this.lblDataAddress.Name = "lblDataAddress";
            this.lblDataAddress.Size = new System.Drawing.Size(136, 19);
            this.lblDataAddress.TabIndex = 19;
            this.lblDataAddress.Text = "Dirección PLC - Datos";
            this.lblDataAddress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblStatusDataChangeAddressAck
            // 
            this.lblStatusDataChangeAddressAck.AutoSize = true;
            this.lblStatusDataChangeAddressAck.Location = new System.Drawing.Point(33, 156);
            this.lblStatusDataChangeAddressAck.Name = "lblStatusDataChangeAddressAck";
            this.lblStatusDataChangeAddressAck.Size = new System.Drawing.Size(161, 19);
            this.lblStatusDataChangeAddressAck.TabIndex = 18;
            this.lblStatusDataChangeAddressAck.Text = "Dirección PLC - Respuesta";
            this.lblStatusDataChangeAddressAck.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblStatusDataChangeAddress
            // 
            this.lblStatusDataChangeAddress.AutoSize = true;
            this.lblStatusDataChangeAddress.Location = new System.Drawing.Point(33, 124);
            this.lblStatusDataChangeAddress.Name = "lblStatusDataChangeAddress";
            this.lblStatusDataChangeAddress.Size = new System.Drawing.Size(148, 19);
            this.lblStatusDataChangeAddress.TabIndex = 17;
            this.lblStatusDataChangeAddress.Text = "Dirección PLC - Petición";
            this.lblStatusDataChangeAddress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.DataGridSearch);
            this.tabSearch.HorizontalScrollbarBarColor = true;
            this.tabSearch.HorizontalScrollbarHighlightOnWheel = false;
            this.tabSearch.HorizontalScrollbarSize = 10;
            this.tabSearch.Location = new System.Drawing.Point(4, 38);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Size = new System.Drawing.Size(768, 315);
            this.tabSearch.TabIndex = 1;
            this.tabSearch.Text = "Búsqueda";
            this.tabSearch.VerticalScrollbarBarColor = true;
            this.tabSearch.VerticalScrollbarHighlightOnWheel = false;
            this.tabSearch.VerticalScrollbarSize = 10;
            // 
            // DataGridSearch
            // 
            this.DataGridSearch.AllowUserToResizeRows = false;
            this.DataGridSearch.AutoGenerateColumns = false;
            this.DataGridSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridSearch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.statusDataChangeAddressDataGridViewTextBoxColumn,
            this.statusDataChangeAddressAckDataGridViewTextBoxColumn,
            this.dataAddressDataGridViewTextBoxColumn,
            this.statusChangeS7DataGridViewTextBoxColumn,
            this.statusChangeS7AckDataGridViewTextBoxColumn,
            this.dataAddressS7DataGridViewTextBoxColumn,
            this.statusChangeOpcDataGridViewTextBoxColumn,
            this.statusChangeOpcAckDataGridViewTextBoxColumn,
            this.dataAddressOpcDataGridViewTextBoxColumn,
            this.dataContentDataGridViewTextBoxColumn});
            this.DataGridSearch.DataSource = this.stationBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridSearch.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridSearch.EnableHeadersVisualStyles = false;
            this.DataGridSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataGridSearch.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridSearch.Location = new System.Drawing.Point(0, 0);
            this.DataGridSearch.Name = "DataGridSearch";
            this.DataGridSearch.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridSearch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridSearch.Size = new System.Drawing.Size(768, 315);
            this.DataGridSearch.TabIndex = 2;
            this.DataGridSearch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridSearch_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // statusDataChangeAddressDataGridViewTextBoxColumn
            // 
            this.statusDataChangeAddressDataGridViewTextBoxColumn.DataPropertyName = "StatusDataChangeAddress";
            this.statusDataChangeAddressDataGridViewTextBoxColumn.HeaderText = "StatusDataChangeAddress";
            this.statusDataChangeAddressDataGridViewTextBoxColumn.Name = "statusDataChangeAddressDataGridViewTextBoxColumn";
            this.statusDataChangeAddressDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusDataChangeAddressAckDataGridViewTextBoxColumn
            // 
            this.statusDataChangeAddressAckDataGridViewTextBoxColumn.DataPropertyName = "StatusDataChangeAddressAck";
            this.statusDataChangeAddressAckDataGridViewTextBoxColumn.HeaderText = "StatusDataChangeAddressAck";
            this.statusDataChangeAddressAckDataGridViewTextBoxColumn.Name = "statusDataChangeAddressAckDataGridViewTextBoxColumn";
            this.statusDataChangeAddressAckDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataAddressDataGridViewTextBoxColumn
            // 
            this.dataAddressDataGridViewTextBoxColumn.DataPropertyName = "DataAddress";
            this.dataAddressDataGridViewTextBoxColumn.HeaderText = "DataAddress";
            this.dataAddressDataGridViewTextBoxColumn.Name = "dataAddressDataGridViewTextBoxColumn";
            this.dataAddressDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusChangeS7DataGridViewTextBoxColumn
            // 
            this.statusChangeS7DataGridViewTextBoxColumn.DataPropertyName = "StatusChangeS7";
            this.statusChangeS7DataGridViewTextBoxColumn.HeaderText = "StatusChangeS7";
            this.statusChangeS7DataGridViewTextBoxColumn.Name = "statusChangeS7DataGridViewTextBoxColumn";
            this.statusChangeS7DataGridViewTextBoxColumn.Visible = false;
            // 
            // statusChangeS7AckDataGridViewTextBoxColumn
            // 
            this.statusChangeS7AckDataGridViewTextBoxColumn.DataPropertyName = "StatusChangeS7Ack";
            this.statusChangeS7AckDataGridViewTextBoxColumn.HeaderText = "StatusChangeS7Ack";
            this.statusChangeS7AckDataGridViewTextBoxColumn.Name = "statusChangeS7AckDataGridViewTextBoxColumn";
            this.statusChangeS7AckDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataAddressS7DataGridViewTextBoxColumn
            // 
            this.dataAddressS7DataGridViewTextBoxColumn.DataPropertyName = "DataAddressS7";
            this.dataAddressS7DataGridViewTextBoxColumn.HeaderText = "DataAddressS7";
            this.dataAddressS7DataGridViewTextBoxColumn.Name = "dataAddressS7DataGridViewTextBoxColumn";
            this.dataAddressS7DataGridViewTextBoxColumn.Visible = false;
            // 
            // statusChangeOpcDataGridViewTextBoxColumn
            // 
            this.statusChangeOpcDataGridViewTextBoxColumn.DataPropertyName = "StatusChangeOpc";
            this.statusChangeOpcDataGridViewTextBoxColumn.HeaderText = "StatusChangeOpc";
            this.statusChangeOpcDataGridViewTextBoxColumn.Name = "statusChangeOpcDataGridViewTextBoxColumn";
            this.statusChangeOpcDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusChangeOpcAckDataGridViewTextBoxColumn
            // 
            this.statusChangeOpcAckDataGridViewTextBoxColumn.DataPropertyName = "StatusChangeOpcAck";
            this.statusChangeOpcAckDataGridViewTextBoxColumn.HeaderText = "StatusChangeOpcAck";
            this.statusChangeOpcAckDataGridViewTextBoxColumn.Name = "statusChangeOpcAckDataGridViewTextBoxColumn";
            this.statusChangeOpcAckDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataAddressOpcDataGridViewTextBoxColumn
            // 
            this.dataAddressOpcDataGridViewTextBoxColumn.DataPropertyName = "DataAddressOpc";
            this.dataAddressOpcDataGridViewTextBoxColumn.HeaderText = "DataAddressOpc";
            this.dataAddressOpcDataGridViewTextBoxColumn.Name = "dataAddressOpcDataGridViewTextBoxColumn";
            this.dataAddressOpcDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataContentDataGridViewTextBoxColumn
            // 
            this.dataContentDataGridViewTextBoxColumn.DataPropertyName = "DataContent";
            this.dataContentDataGridViewTextBoxColumn.HeaderText = "DataContent";
            this.dataContentDataGridViewTextBoxColumn.Name = "dataContentDataGridViewTextBoxColumn";
            this.dataContentDataGridViewTextBoxColumn.Visible = false;
            // 
            // stationBindingSource
            // 
            this.stationBindingSource.DataSource = typeof(LineOfBands.Database.Entities.Station);
            // 
            // UcStations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.pnFooter);
            this.Controls.Add(this.pnHead);
            this.Name = "UcStations";
            this.Size = new System.Drawing.Size(776, 470);
            this.Load += new System.EventHandler(this.FrmStations_Load);
            this.pnHead.ResumeLayout(false);
            this.pnFooter.ResumeLayout(false);
            this.pnRightFooter.ResumeLayout(false);
            this.pnContent.ResumeLayout(false);
            this.tabControlContent.ResumeLayout(false);
            this.tabData.ResumeLayout(false);
            this.tabData.PerformLayout();
            this.tabSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtCode;
        private MetroFramework.Controls.MetroComboBox cmbType;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTile btnNew;
        private MetroFramework.Controls.MetroTile btnRemove;
        private MetroFramework.Controls.MetroTile btnSave;
        private MetroFramework.Controls.MetroTile btnSearch;
        private MetroFramework.Controls.MetroLink BtnBack;
        private MetroFramework.Controls.MetroLabel lblCode;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroLabel lblType;
        private MetroFramework.Controls.MetroPanel pnHead;
        private MetroFramework.Controls.MetroPanel pnFooter;
        private MetroFramework.Controls.MetroPanel pnContent;
        private MetroFramework.Controls.MetroPanel pnRightFooter;
        private MetroFramework.Controls.MetroTabControl tabControlContent;
        private MetroFramework.Controls.MetroTabPage tabData;
        private MetroFramework.Controls.MetroTabPage tabSearch;
        private MetroFramework.Controls.MetroGrid DataGridSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataChangeAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataChangeAddressAckDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusChangeS7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusChangeS7AckDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAddressS7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusChangeOpcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusChangeOpcAckDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAddressOpcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataContentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stationBindingSource;
        private MetroFramework.Controls.MetroLabel lblStatusDataChangeAddress;
        private MetroFramework.Controls.MetroTextBox txtDataAddress;
        private MetroFramework.Controls.MetroTextBox txtStatusDataChangeAddressAck;
        private MetroFramework.Controls.MetroTextBox txtStatusDataChangeAddress;
        private MetroFramework.Controls.MetroLabel lblDataAddress;
        private MetroFramework.Controls.MetroLabel lblStatusDataChangeAddressAck;
    }
}