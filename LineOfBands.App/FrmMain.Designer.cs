namespace LineOfBands.App
{
    partial class FrmMain
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TimerS7ComunicationStatus = new System.Windows.Forms.Timer(this.components);
            this.ContentPanel = new MetroFramework.Controls.MetroPanel();
            this.TxtPartReference = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // TimerS7ComunicationStatus
            // 
            this.TimerS7ComunicationStatus.Interval = 200;
            this.TimerS7ComunicationStatus.Tick += new System.EventHandler(this.TimerComunicationStatus_Tick);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.HorizontalScrollbarBarColor = true;
            this.ContentPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.ContentPanel.HorizontalScrollbarSize = 10;
            this.ContentPanel.Location = new System.Drawing.Point(20, 60);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(709, 414);
            this.ContentPanel.TabIndex = 0;
            this.ContentPanel.VerticalScrollbarBarColor = true;
            this.ContentPanel.VerticalScrollbarHighlightOnWheel = false;
            this.ContentPanel.VerticalScrollbarSize = 10;
            // 
            // TxtPartReference
            // 
            // 
            // 
            // 
            this.TxtPartReference.CustomButton.Image = null;
            this.TxtPartReference.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.TxtPartReference.CustomButton.Name = "";
            this.TxtPartReference.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtPartReference.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPartReference.CustomButton.TabIndex = 1;
            this.TxtPartReference.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPartReference.CustomButton.UseSelectable = true;
            this.TxtPartReference.CustomButton.Visible = false;
            this.TxtPartReference.Lines = new string[] {
        "metroTextBox1"};
            this.TxtPartReference.Location = new System.Drawing.Point(240, 20);
            this.TxtPartReference.MaxLength = 32767;
            this.TxtPartReference.Name = "TxtPartReference";
            this.TxtPartReference.PasswordChar = '\0';
            this.TxtPartReference.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPartReference.SelectedText = "";
            this.TxtPartReference.SelectionLength = 0;
            this.TxtPartReference.SelectionStart = 0;
            this.TxtPartReference.ShortcutsEnabled = true;
            this.TxtPartReference.Size = new System.Drawing.Size(244, 23);
            this.TxtPartReference.TabIndex = 1;
            this.TxtPartReference.Text = "metroTextBox1";
            this.TxtPartReference.UseSelectable = true;
            this.TxtPartReference.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPartReference.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 494);
            this.Controls.Add(this.TxtPartReference);
            this.Controls.Add(this.ContentPanel);
            this.Name = "FrmMain";
            this.Text = "Line Of Bands";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer TimerS7ComunicationStatus;
        private MetroFramework.Controls.MetroPanel ContentPanel;
        private MetroFramework.Controls.MetroTextBox TxtPartReference;
    }
}

