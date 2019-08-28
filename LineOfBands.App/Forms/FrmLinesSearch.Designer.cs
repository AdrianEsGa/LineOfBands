using LineOfBands.Database.Entities;

namespace LineOfBands.App.Forms
{
    partial class FrmLinesSearch
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
            this.LineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PanelHead = new System.Windows.Forms.Panel();
            this.PanelFooter = new System.Windows.Forms.Panel();
            this.DataGridViewLines = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelContent = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.LineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLines)).BeginInit();
            this.PanelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // LineBindingSource
            // 
            this.LineBindingSource.DataSource = typeof(Line);
            // 
            // PanelHead
            // 
            this.PanelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHead.Location = new System.Drawing.Point(0, 0);
            this.PanelHead.Name = "PanelHead";
            this.PanelHead.Size = new System.Drawing.Size(397, 25);
            this.PanelHead.TabIndex = 0;
            // 
            // PanelFooter
            // 
            this.PanelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelFooter.Location = new System.Drawing.Point(0, 293);
            this.PanelFooter.Name = "PanelFooter";
            this.PanelFooter.Size = new System.Drawing.Size(397, 25);
            this.PanelFooter.TabIndex = 1;
            // 
            // DataGridViewLines
            // 
            this.DataGridViewLines.AllowUserToAddRows = false;
            this.DataGridViewLines.AllowUserToDeleteRows = false;
            this.DataGridViewLines.AllowUserToResizeColumns = false;
            this.DataGridViewLines.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(244)))));
            this.DataGridViewLines.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewLines.AutoGenerateColumns = false;
            this.DataGridViewLines.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.DataGridViewLines.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DataGridViewLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewLines.ColumnHeadersVisible = false;
            this.DataGridViewLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.DataGridViewLines.DataSource = this.LineBindingSource;
            this.DataGridViewLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewLines.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewLines.MultiSelect = false;
            this.DataGridViewLines.Name = "DataGridViewLines";
            this.DataGridViewLines.ReadOnly = true;
            this.DataGridViewLines.RowHeadersVisible = false;
            this.DataGridViewLines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewLines.Size = new System.Drawing.Size(397, 268);
            this.DataGridViewLines.TabIndex = 3;
            this.DataGridViewLines.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewLines_CellDoubleClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // PanelContent
            // 
            this.PanelContent.Controls.Add(this.DataGridViewLines);
            this.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContent.Location = new System.Drawing.Point(0, 25);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(397, 268);
            this.PanelContent.TabIndex = 2;
            // 
            // FrmLinesSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 318);
            this.Controls.Add(this.PanelContent);
            this.Controls.Add(this.PanelFooter);
            this.Controls.Add(this.PanelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLinesSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Búsqueda de líneas";
            this.Load += new System.EventHandler(this.FrmLinesSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLines)).EndInit();
            this.PanelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource LineBindingSource;
        private System.Windows.Forms.Panel PanelHead;
        private System.Windows.Forms.Panel PanelFooter;
        private System.Windows.Forms.DataGridView DataGridViewLines;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel PanelContent;

    }
}