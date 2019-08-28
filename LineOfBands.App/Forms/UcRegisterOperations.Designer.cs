namespace LineOfBands.App.Forms
{
    partial class UcRegisterOperations
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcRegisterOperations));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.HeadPanel = new MetroFramework.Controls.MetroPanel();
            this.BtnMenu = new MetroFramework.Controls.MetroLink();
            this.ContentPanel = new MetroFramework.Controls.MetroPanel();
            this.LastOpertationsPanel = new MetroFramework.Controls.MetroPanel();
            this.LastOpertationsDescPanel = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.ActiveOperationsPanel = new MetroFramework.Controls.MetroPanel();
            this.DataGridActiveOperations = new MetroFramework.Controls.MetroGrid();
            this.operationRegisterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActiveOpertationsDescPanel = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.palletDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridLastOperations = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.HeadPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.LastOpertationsPanel.SuspendLayout();
            this.LastOpertationsDescPanel.SuspendLayout();
            this.ActiveOperationsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridActiveOperations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationRegisterBindingSource)).BeginInit();
            this.ActiveOpertationsDescPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridLastOperations)).BeginInit();
            this.SuspendLayout();
            // 
            // HeadPanel
            // 
            this.HeadPanel.Controls.Add(this.BtnMenu);
            this.HeadPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeadPanel.HorizontalScrollbarBarColor = true;
            this.HeadPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.HeadPanel.HorizontalScrollbarSize = 10;
            this.HeadPanel.Location = new System.Drawing.Point(0, 0);
            this.HeadPanel.Name = "HeadPanel";
            this.HeadPanel.Size = new System.Drawing.Size(895, 55);
            this.HeadPanel.TabIndex = 0;
            this.HeadPanel.VerticalScrollbarBarColor = true;
            this.HeadPanel.VerticalScrollbarHighlightOnWheel = false;
            this.HeadPanel.VerticalScrollbarSize = 10;
            // 
            // BtnMenu
            // 
            this.BtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenu.Image")));
            this.BtnMenu.ImageSize = 30;
            this.BtnMenu.Location = new System.Drawing.Point(8, 4);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(59, 46);
            this.BtnMenu.TabIndex = 2;
            this.BtnMenu.UseSelectable = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.LastOpertationsPanel);
            this.ContentPanel.Controls.Add(this.LastOpertationsDescPanel);
            this.ContentPanel.Controls.Add(this.ActiveOperationsPanel);
            this.ContentPanel.Controls.Add(this.ActiveOpertationsDescPanel);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.HorizontalScrollbarBarColor = true;
            this.ContentPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.ContentPanel.HorizontalScrollbarSize = 10;
            this.ContentPanel.Location = new System.Drawing.Point(0, 55);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(895, 623);
            this.ContentPanel.TabIndex = 1;
            this.ContentPanel.VerticalScrollbarBarColor = true;
            this.ContentPanel.VerticalScrollbarHighlightOnWheel = false;
            this.ContentPanel.VerticalScrollbarSize = 10;
            // 
            // LastOpertationsPanel
            // 
            this.LastOpertationsPanel.Controls.Add(this.DataGridLastOperations);
            this.LastOpertationsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LastOpertationsPanel.HorizontalScrollbarBarColor = true;
            this.LastOpertationsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.LastOpertationsPanel.HorizontalScrollbarSize = 10;
            this.LastOpertationsPanel.Location = new System.Drawing.Point(0, 358);
            this.LastOpertationsPanel.Name = "LastOpertationsPanel";
            this.LastOpertationsPanel.Size = new System.Drawing.Size(895, 265);
            this.LastOpertationsPanel.TabIndex = 5;
            this.LastOpertationsPanel.VerticalScrollbarBarColor = true;
            this.LastOpertationsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.LastOpertationsPanel.VerticalScrollbarSize = 10;
            // 
            // LastOpertationsDescPanel
            // 
            this.LastOpertationsDescPanel.Controls.Add(this.metroLabel2);
            this.LastOpertationsDescPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LastOpertationsDescPanel.HorizontalScrollbarBarColor = true;
            this.LastOpertationsDescPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.LastOpertationsDescPanel.HorizontalScrollbarSize = 10;
            this.LastOpertationsDescPanel.Location = new System.Drawing.Point(0, 332);
            this.LastOpertationsDescPanel.Name = "LastOpertationsDescPanel";
            this.LastOpertationsDescPanel.Size = new System.Drawing.Size(895, 26);
            this.LastOpertationsDescPanel.TabIndex = 4;
            this.LastOpertationsDescPanel.VerticalScrollbarBarColor = true;
            this.LastOpertationsDescPanel.VerticalScrollbarHighlightOnWheel = false;
            this.LastOpertationsDescPanel.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 3);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "metroLabel2";
            // 
            // ActiveOperationsPanel
            // 
            this.ActiveOperationsPanel.Controls.Add(this.DataGridActiveOperations);
            this.ActiveOperationsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ActiveOperationsPanel.HorizontalScrollbarBarColor = true;
            this.ActiveOperationsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.ActiveOperationsPanel.HorizontalScrollbarSize = 10;
            this.ActiveOperationsPanel.Location = new System.Drawing.Point(0, 26);
            this.ActiveOperationsPanel.Name = "ActiveOperationsPanel";
            this.ActiveOperationsPanel.Size = new System.Drawing.Size(895, 306);
            this.ActiveOperationsPanel.TabIndex = 3;
            this.ActiveOperationsPanel.VerticalScrollbarBarColor = true;
            this.ActiveOperationsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.ActiveOperationsPanel.VerticalScrollbarSize = 10;
            // 
            // DataGridActiveOperations
            // 
            this.DataGridActiveOperations.AllowUserToResizeRows = false;
            this.DataGridActiveOperations.AutoGenerateColumns = false;
            this.DataGridActiveOperations.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridActiveOperations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridActiveOperations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridActiveOperations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridActiveOperations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridActiveOperations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridActiveOperations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.operationInDataGridViewTextBoxColumn,
            this.operationOutDataGridViewTextBoxColumn,
            this.palletDataGridViewTextBoxColumn,
            this.moldDataGridViewTextBoxColumn,
            this.partDataGridViewTextBoxColumn,
            this.initDateTimeDataGridViewTextBoxColumn,
            this.endDateTimeDataGridViewTextBoxColumn});
            this.DataGridActiveOperations.DataSource = this.operationRegisterBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridActiveOperations.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridActiveOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridActiveOperations.EnableHeadersVisualStyles = false;
            this.DataGridActiveOperations.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataGridActiveOperations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridActiveOperations.Location = new System.Drawing.Point(0, 0);
            this.DataGridActiveOperations.Name = "DataGridActiveOperations";
            this.DataGridActiveOperations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridActiveOperations.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridActiveOperations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridActiveOperations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridActiveOperations.Size = new System.Drawing.Size(895, 306);
            this.DataGridActiveOperations.TabIndex = 2;
            // 
            // operationRegisterBindingSource
            // 
            this.operationRegisterBindingSource.DataSource = typeof(LineOfBands.Database.Entities.OperationRegister);
            // 
            // ActiveOpertationsDescPanel
            // 
            this.ActiveOpertationsDescPanel.Controls.Add(this.metroLabel1);
            this.ActiveOpertationsDescPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ActiveOpertationsDescPanel.HorizontalScrollbarBarColor = true;
            this.ActiveOpertationsDescPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.ActiveOpertationsDescPanel.HorizontalScrollbarSize = 10;
            this.ActiveOpertationsDescPanel.Location = new System.Drawing.Point(0, 0);
            this.ActiveOpertationsDescPanel.Name = "ActiveOpertationsDescPanel";
            this.ActiveOpertationsDescPanel.Size = new System.Drawing.Size(895, 26);
            this.ActiveOpertationsDescPanel.TabIndex = 2;
            this.ActiveOpertationsDescPanel.VerticalScrollbarBarColor = true;
            this.ActiveOpertationsDescPanel.VerticalScrollbarHighlightOnWheel = false;
            this.ActiveOpertationsDescPanel.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 4);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "metroLabel1";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // operationInDataGridViewTextBoxColumn
            // 
            this.operationInDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.operationInDataGridViewTextBoxColumn.DataPropertyName = "OperationIn";
            this.operationInDataGridViewTextBoxColumn.HeaderText = "Operacion Entrada";
            this.operationInDataGridViewTextBoxColumn.Name = "operationInDataGridViewTextBoxColumn";
            // 
            // operationOutDataGridViewTextBoxColumn
            // 
            this.operationOutDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.operationOutDataGridViewTextBoxColumn.DataPropertyName = "OperationOut";
            this.operationOutDataGridViewTextBoxColumn.HeaderText = "Operacion Salida";
            this.operationOutDataGridViewTextBoxColumn.Name = "operationOutDataGridViewTextBoxColumn";
            // 
            // palletDataGridViewTextBoxColumn
            // 
            this.palletDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.palletDataGridViewTextBoxColumn.DataPropertyName = "Pallet";
            this.palletDataGridViewTextBoxColumn.HeaderText = "Pallet";
            this.palletDataGridViewTextBoxColumn.Name = "palletDataGridViewTextBoxColumn";
            // 
            // moldDataGridViewTextBoxColumn
            // 
            this.moldDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.moldDataGridViewTextBoxColumn.DataPropertyName = "Mold";
            this.moldDataGridViewTextBoxColumn.HeaderText = "Molde";
            this.moldDataGridViewTextBoxColumn.Name = "moldDataGridViewTextBoxColumn";
            // 
            // partDataGridViewTextBoxColumn
            // 
            this.partDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.partDataGridViewTextBoxColumn.DataPropertyName = "Part";
            this.partDataGridViewTextBoxColumn.HeaderText = "Pieza";
            this.partDataGridViewTextBoxColumn.Name = "partDataGridViewTextBoxColumn";
            // 
            // initDateTimeDataGridViewTextBoxColumn
            // 
            this.initDateTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.initDateTimeDataGridViewTextBoxColumn.DataPropertyName = "InitDateTime";
            this.initDateTimeDataGridViewTextBoxColumn.HeaderText = "Fecha/Hora Inicio";
            this.initDateTimeDataGridViewTextBoxColumn.Name = "initDateTimeDataGridViewTextBoxColumn";
            // 
            // endDateTimeDataGridViewTextBoxColumn
            // 
            this.endDateTimeDataGridViewTextBoxColumn.DataPropertyName = "EndDateTime";
            this.endDateTimeDataGridViewTextBoxColumn.HeaderText = "EndDateTime";
            this.endDateTimeDataGridViewTextBoxColumn.Name = "endDateTimeDataGridViewTextBoxColumn";
            this.endDateTimeDataGridViewTextBoxColumn.Visible = false;
            // 
            // DataGridLastOperations
            // 
            this.DataGridLastOperations.AllowUserToResizeRows = false;
            this.DataGridLastOperations.AutoGenerateColumns = false;
            this.DataGridLastOperations.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridLastOperations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridLastOperations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridLastOperations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridLastOperations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridLastOperations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridLastOperations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.DataGridLastOperations.DataSource = this.operationRegisterBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridLastOperations.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridLastOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridLastOperations.EnableHeadersVisualStyles = false;
            this.DataGridLastOperations.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataGridLastOperations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridLastOperations.Location = new System.Drawing.Point(0, 0);
            this.DataGridLastOperations.Name = "DataGridLastOperations";
            this.DataGridLastOperations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridLastOperations.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridLastOperations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridLastOperations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridLastOperations.Size = new System.Drawing.Size(895, 265);
            this.DataGridLastOperations.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "OperationIn";
            this.dataGridViewTextBoxColumn2.HeaderText = "Operacion Entrada";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "OperationOut";
            this.dataGridViewTextBoxColumn3.HeaderText = "Operacion Salida";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Pallet";
            this.dataGridViewTextBoxColumn4.HeaderText = "Pallet";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Mold";
            this.dataGridViewTextBoxColumn5.HeaderText = "Molde";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Part";
            this.dataGridViewTextBoxColumn6.HeaderText = "Pieza";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "InitDateTime";
            this.dataGridViewTextBoxColumn7.HeaderText = "Fecha/Hora Inicio";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "EndDateTime";
            this.dataGridViewTextBoxColumn8.HeaderText = "Fecha/Hora Fin";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Interval = 1000;
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // UcRegisterOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.HeadPanel);
            this.Name = "UcRegisterOperations";
            this.Size = new System.Drawing.Size(895, 678);
            this.Load += new System.EventHandler(this.UcRegisterOperations_Load);
            this.HeadPanel.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.LastOpertationsPanel.ResumeLayout(false);
            this.LastOpertationsDescPanel.ResumeLayout(false);
            this.LastOpertationsDescPanel.PerformLayout();
            this.ActiveOperationsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridActiveOperations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationRegisterBindingSource)).EndInit();
            this.ActiveOpertationsDescPanel.ResumeLayout(false);
            this.ActiveOpertationsDescPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridLastOperations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel HeadPanel;
        private MetroFramework.Controls.MetroPanel ContentPanel;
        private MetroFramework.Controls.MetroPanel LastOpertationsPanel;
        private MetroFramework.Controls.MetroPanel LastOpertationsDescPanel;
        private MetroFramework.Controls.MetroPanel ActiveOperationsPanel;
        private MetroFramework.Controls.MetroPanel ActiveOpertationsDescPanel;
        private MetroFramework.Controls.MetroGrid DataGridActiveOperations;
        private MetroFramework.Controls.MetroLink BtnMenu;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.BindingSource operationRegisterBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn palletDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn initDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateTimeDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroGrid DataGridLastOperations;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Timer RefreshTimer;
    }
}
