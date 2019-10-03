namespace LineOfBands.App.Forms
{
    partial class UcMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcMenu));
            this.BtnStations = new MetroFramework.Controls.MetroTile();
            this.BtnStationTypes = new MetroFramework.Controls.MetroTile();
            this.BtnStationTypeOpertations = new MetroFramework.Controls.MetroTile();
            this.BtnProductionOrders = new MetroFramework.Controls.MetroTile();
            this.BtnParts = new MetroFramework.Controls.MetroTile();
            this.BtnBack = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // BtnStations
            // 
            this.BtnStations.ActiveControl = null;
            this.BtnStations.Location = new System.Drawing.Point(16, 65);
            this.BtnStations.Name = "BtnStations";
            this.BtnStations.Size = new System.Drawing.Size(146, 104);
            this.BtnStations.TabIndex = 0;
            this.BtnStations.Text = "Estaciones";
            this.BtnStations.UseSelectable = true;
            this.BtnStations.Click += new System.EventHandler(this.BtnStations_Click);
            // 
            // BtnStationTypes
            // 
            this.BtnStationTypes.ActiveControl = null;
            this.BtnStationTypes.Location = new System.Drawing.Point(16, 175);
            this.BtnStationTypes.Name = "BtnStationTypes";
            this.BtnStationTypes.Size = new System.Drawing.Size(146, 104);
            this.BtnStationTypes.TabIndex = 1;
            this.BtnStationTypes.Text = "Tipos de estación";
            this.BtnStationTypes.UseSelectable = true;
            this.BtnStationTypes.Click += new System.EventHandler(this.BtnStationTypes_Click);
            // 
            // BtnStationTypeOpertations
            // 
            this.BtnStationTypeOpertations.ActiveControl = null;
            this.BtnStationTypeOpertations.Location = new System.Drawing.Point(168, 175);
            this.BtnStationTypeOpertations.Name = "BtnStationTypeOpertations";
            this.BtnStationTypeOpertations.Size = new System.Drawing.Size(216, 104);
            this.BtnStationTypeOpertations.TabIndex = 2;
            this.BtnStationTypeOpertations.Text = "Tipos de operación por estación";
            this.BtnStationTypeOpertations.UseSelectable = true;
            // 
            // BtnProductionOrders
            // 
            this.BtnProductionOrders.ActiveControl = null;
            this.BtnProductionOrders.Location = new System.Drawing.Point(16, 360);
            this.BtnProductionOrders.Name = "BtnProductionOrders";
            this.BtnProductionOrders.Size = new System.Drawing.Size(181, 104);
            this.BtnProductionOrders.TabIndex = 3;
            this.BtnProductionOrders.Text = "Ordenes de producción";
            this.BtnProductionOrders.UseSelectable = true;
            // 
            // BtnParts
            // 
            this.BtnParts.ActiveControl = null;
            this.BtnParts.Location = new System.Drawing.Point(203, 360);
            this.BtnParts.Name = "BtnParts";
            this.BtnParts.Size = new System.Drawing.Size(181, 104);
            this.BtnParts.TabIndex = 4;
            this.BtnParts.Text = "Piezas";
            this.BtnParts.UseSelectable = true;
            // 
            // BtnBack
            // 
            this.BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.ImageSize = 40;
            this.BtnBack.Location = new System.Drawing.Point(8, 4);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(59, 46);
            this.BtnBack.TabIndex = 5;
            this.BtnBack.UseSelectable = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // UcMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnParts);
            this.Controls.Add(this.BtnProductionOrders);
            this.Controls.Add(this.BtnStationTypeOpertations);
            this.Controls.Add(this.BtnStationTypes);
            this.Controls.Add(this.BtnStations);
            this.Name = "UcMenu";
            this.Size = new System.Drawing.Size(749, 610);
            this.Load += new System.EventHandler(this.UcMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile BtnStations;
        private MetroFramework.Controls.MetroTile BtnStationTypes;
        private MetroFramework.Controls.MetroTile BtnStationTypeOpertations;
        private MetroFramework.Controls.MetroTile BtnProductionOrders;
        private MetroFramework.Controls.MetroTile BtnParts;
        private MetroFramework.Controls.MetroLink BtnBack;
    }
}
