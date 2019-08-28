using LineOfBands.Database.Entities;

namespace LineOfBands.App.Forms
{
    partial class FrmStationsSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.DataGridViewStations = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PanelFooter = new System.Windows.Forms.Panel();
            this.PanelHead = new System.Windows.Forms.Panel();
            this.PanelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelContent
            // 
            this.PanelContent.Controls.Add(this.DataGridViewStations);
            this.PanelContent.Location = new System.Drawing.Point(0, 25);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(397, 268);
            this.PanelContent.TabIndex = 5;
            // 
            // DataGridViewStations
            // 
            this.DataGridViewStations.AllowUserToAddRows = false;
            this.DataGridViewStations.AllowUserToDeleteRows = false;
            this.DataGridViewStations.AllowUserToResizeColumns = false;
            this.DataGridViewStations.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(244)))));
            this.DataGridViewStations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewStations.AutoGenerateColumns = false;
            this.DataGridViewStations.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.DataGridViewStations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DataGridViewStations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewStations.ColumnHeadersVisible = false;
            this.DataGridViewStations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.lineDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.DataGridViewStations.DataSource = this.stationBindingSource;
            this.DataGridViewStations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewStations.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewStations.MultiSelect = false;
            this.DataGridViewStations.Name = "DataGridViewStations";
            this.DataGridViewStations.ReadOnly = true;
            this.DataGridViewStations.RowHeadersVisible = false;
            this.DataGridViewStations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewStations.Size = new System.Drawing.Size(397, 268);
            this.DataGridViewStations.TabIndex = 3;
            this.DataGridViewStations.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewStations_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lineDataGridViewTextBoxColumn
            // 
            this.lineDataGridViewTextBoxColumn.DataPropertyName = "Line";
            this.lineDataGridViewTextBoxColumn.HeaderText = "Line";
            this.lineDataGridViewTextBoxColumn.Name = "lineDataGridViewTextBoxColumn";
            this.lineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stationBindingSource
            // 
            this.stationBindingSource.DataSource = typeof(Station);
            // 
            // PanelFooter
            // 
            this.PanelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelFooter.Location = new System.Drawing.Point(0, 292);
            this.PanelFooter.Name = "PanelFooter";
            this.PanelFooter.Size = new System.Drawing.Size(398, 25);
            this.PanelFooter.TabIndex = 4;
            // 
            // PanelHead
            // 
            this.PanelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHead.Location = new System.Drawing.Point(0, 0);
            this.PanelHead.Name = "PanelHead";
            this.PanelHead.Size = new System.Drawing.Size(398, 25);
            this.PanelHead.TabIndex = 3;
            // 
            // FrmStationsSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 317);
            this.Controls.Add(this.PanelContent);
            this.Controls.Add(this.PanelFooter);
            this.Controls.Add(this.PanelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStationsSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de estaciones";
            this.Load += new System.EventHandler(this.FrmStationsSearch_Load);
            this.PanelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelContent;
        private System.Windows.Forms.DataGridView DataGridViewStations;
        private System.Windows.Forms.Panel PanelFooter;
        private System.Windows.Forms.Panel PanelHead;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stationBindingSource;

    }
}