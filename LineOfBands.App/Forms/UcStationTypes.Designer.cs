namespace LineOfBands.App.Forms
{
    partial class UcStationTypes
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcStationTypes));
            this.pnContent = new MetroFramework.Controls.MetroPanel();
            this.tabControlContent = new MetroFramework.Controls.MetroTabControl();
            this.tabData = new MetroFramework.Controls.MetroTabPage();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.tabSearch = new MetroFramework.Controls.MetroTabPage();
            this.DataGridSearch = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnFooter = new MetroFramework.Controls.MetroPanel();
            this.pnRightFooter = new MetroFramework.Controls.MetroPanel();
            this.btnRemove = new MetroFramework.Controls.MetroTile();
            this.btnNew = new MetroFramework.Controls.MetroTile();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.btnSearch = new MetroFramework.Controls.MetroTile();
            this.pnHead = new MetroFramework.Controls.MetroPanel();
            this.BtnBack = new MetroFramework.Controls.MetroLink();
            this.pnContent.SuspendLayout();
            this.tabControlContent.SuspendLayout();
            this.tabData.SuspendLayout();
            this.tabSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationTypeBindingSource)).BeginInit();
            this.pnFooter.SuspendLayout();
            this.pnRightFooter.SuspendLayout();
            this.pnHead.SuspendLayout();
            this.SuspendLayout();
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
            this.pnContent.Size = new System.Drawing.Size(601, 276);
            this.pnContent.TabIndex = 22;
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
            this.tabControlContent.Size = new System.Drawing.Size(601, 276);
            this.tabControlContent.TabIndex = 17;
            this.tabControlContent.UseSelectable = true;
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.lblName);
            this.tabData.Controls.Add(this.txtName);
            this.tabData.HorizontalScrollbarBarColor = true;
            this.tabData.HorizontalScrollbarHighlightOnWheel = false;
            this.tabData.HorizontalScrollbarSize = 10;
            this.tabData.Location = new System.Drawing.Point(4, 38);
            this.tabData.Name = "tabData";
            this.tabData.Size = new System.Drawing.Size(593, 234);
            this.tabData.TabIndex = 0;
            this.tabData.Text = "Ficha";
            this.tabData.VerticalScrollbarBarColor = true;
            this.tabData.VerticalScrollbarHighlightOnWheel = false;
            this.tabData.VerticalScrollbarSize = 10;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(33, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 19);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Nombre";
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
            this.txtName.Location = new System.Drawing.Point(213, 21);
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
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.DataGridSearch);
            this.tabSearch.HorizontalScrollbarBarColor = true;
            this.tabSearch.HorizontalScrollbarHighlightOnWheel = false;
            this.tabSearch.HorizontalScrollbarSize = 10;
            this.tabSearch.Location = new System.Drawing.Point(4, 38);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Size = new System.Drawing.Size(593, 234);
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
            this.nameDataGridViewTextBoxColumn});
            this.DataGridSearch.DataSource = this.stationTypeBindingSource;
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
            this.DataGridSearch.Size = new System.Drawing.Size(593, 234);
            this.DataGridSearch.TabIndex = 2;
            this.DataGridSearch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridSearch_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // stationTypeBindingSource
            // 
            this.stationTypeBindingSource.DataSource = typeof(LineOfBands.Database.Entities.StationType);
            // 
            // pnFooter
            // 
            this.pnFooter.Controls.Add(this.pnRightFooter);
            this.pnFooter.Controls.Add(this.btnSearch);
            this.pnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnFooter.HorizontalScrollbarBarColor = true;
            this.pnFooter.HorizontalScrollbarHighlightOnWheel = false;
            this.pnFooter.HorizontalScrollbarSize = 10;
            this.pnFooter.Location = new System.Drawing.Point(0, 330);
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(601, 59);
            this.pnFooter.Style = MetroFramework.MetroColorStyle.Lime;
            this.pnFooter.TabIndex = 21;
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
            this.pnRightFooter.Location = new System.Drawing.Point(161, 0);
            this.pnRightFooter.Name = "pnRightFooter";
            this.pnRightFooter.Size = new System.Drawing.Size(440, 59);
            this.pnRightFooter.TabIndex = 13;
            this.pnRightFooter.VerticalScrollbarBarColor = true;
            this.pnRightFooter.VerticalScrollbarHighlightOnWheel = false;
            this.pnRightFooter.VerticalScrollbarSize = 10;
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
            this.pnHead.Size = new System.Drawing.Size(601, 54);
            this.pnHead.TabIndex = 20;
            this.pnHead.VerticalScrollbarBarColor = true;
            this.pnHead.VerticalScrollbarHighlightOnWheel = false;
            this.pnHead.VerticalScrollbarSize = 10;
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
            // UcStationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.pnFooter);
            this.Controls.Add(this.pnHead);
            this.Name = "UcStationTypes";
            this.Size = new System.Drawing.Size(601, 389);
            this.Load += new System.EventHandler(this.UcStationTypes_Load);
            this.pnContent.ResumeLayout(false);
            this.tabControlContent.ResumeLayout(false);
            this.tabData.ResumeLayout(false);
            this.tabData.PerformLayout();
            this.tabSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationTypeBindingSource)).EndInit();
            this.pnFooter.ResumeLayout(false);
            this.pnRightFooter.ResumeLayout(false);
            this.pnHead.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnContent;
        private MetroFramework.Controls.MetroTabControl tabControlContent;
        private MetroFramework.Controls.MetroTabPage tabData;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTabPage tabSearch;
        private MetroFramework.Controls.MetroGrid DataGridSearch;
        private MetroFramework.Controls.MetroPanel pnFooter;
        private MetroFramework.Controls.MetroPanel pnRightFooter;
        private MetroFramework.Controls.MetroTile btnRemove;
        private MetroFramework.Controls.MetroTile btnNew;
        private MetroFramework.Controls.MetroTile btnSave;
        private MetroFramework.Controls.MetroTile btnSearch;
        private MetroFramework.Controls.MetroPanel pnHead;
        private MetroFramework.Controls.MetroLink BtnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stationTypeBindingSource;
    }
}
