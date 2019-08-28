namespace LineOfBands.App.Forms
{
    partial class FrmLines
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
            this.PanelHead = new System.Windows.Forms.Panel();
            this.PanelFooter = new System.Windows.Forms.Panel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblCode = new System.Windows.Forms.Label();
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.PanelFooter.SuspendLayout();
            this.PanelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHead
            // 
            this.PanelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHead.Location = new System.Drawing.Point(0, 0);
            this.PanelHead.Name = "PanelHead";
            this.PanelHead.Size = new System.Drawing.Size(567, 39);
            this.PanelHead.TabIndex = 0;
            // 
            // PanelFooter
            // 
            this.PanelFooter.Controls.Add(this.BtnSave);
            this.PanelFooter.Controls.Add(this.BtnRemove);
            this.PanelFooter.Controls.Add(this.BtnNew);
            this.PanelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelFooter.Location = new System.Drawing.Point(0, 183);
            this.PanelFooter.Name = "PanelFooter";
            this.PanelFooter.Size = new System.Drawing.Size(567, 54);
            this.PanelFooter.TabIndex = 1;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(458, 12);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(89, 30);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(363, 12);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(89, 30);
            this.BtnRemove.TabIndex = 1;
            this.BtnRemove.Text = "Eliminar";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(268, 12);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(89, 30);
            this.BtnNew.TabIndex = 0;
            this.BtnNew.Text = "Nuevo";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // PanelContent
            // 
            this.PanelContent.Controls.Add(this.BtnSearch);
            this.PanelContent.Controls.Add(this.LblName);
            this.PanelContent.Controls.Add(this.TxtName);
            this.PanelContent.Controls.Add(this.LblCode);
            this.PanelContent.Controls.Add(this.TxtCode);
            this.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContent.Location = new System.Drawing.Point(0, 39);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(567, 144);
            this.PanelContent.TabIndex = 2;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(181, 42);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(27, 23);
            this.BtnSearch.TabIndex = 4;
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(49, 72);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(44, 13);
            this.LblName.TabIndex = 3;
            this.LblName.Text = "Nombre";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(99, 69);
            this.TxtName.MaxLength = 50;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(215, 20);
            this.TxtName.TabIndex = 2;
            // 
            // LblCode
            // 
            this.LblCode.AutoSize = true;
            this.LblCode.Location = new System.Drawing.Point(49, 46);
            this.LblCode.Name = "LblCode";
            this.LblCode.Size = new System.Drawing.Size(40, 13);
            this.LblCode.TabIndex = 1;
            this.LblCode.Text = "Código";
            // 
            // TxtCode
            // 
            this.TxtCode.Location = new System.Drawing.Point(99, 43);
            this.TxtCode.MaxLength = 4;
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(76, 20);
            this.TxtCode.TabIndex = 0;
            this.TxtCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCode_KeyPress);
            // 
            // FrmLines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 237);
            this.Controls.Add(this.PanelContent);
            this.Controls.Add(this.PanelFooter);
            this.Controls.Add(this.PanelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Líneas";
            this.Load += new System.EventHandler(this.FrmLines_Load);
            this.PanelFooter.ResumeLayout(false);
            this.PanelContent.ResumeLayout(false);
            this.PanelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelHead;
        private System.Windows.Forms.Panel PanelFooter;
        private System.Windows.Forms.Panel PanelContent;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblCode;
        private System.Windows.Forms.TextBox TxtCode;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnSearch;
    }
}