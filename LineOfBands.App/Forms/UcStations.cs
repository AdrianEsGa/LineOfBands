using LineOfBands.Database.Controllers;
using MetroFramework;
using System;
using System.Windows.Forms;
using LineOfBands.Database.Entities;
using MetroFramework.Controls;

namespace LineOfBands.App.Forms
{
    public partial class UcStations : MetroUserControl
    {
        private Station _selectedStation;

        public UcStations()
        {
            InitializeComponent();
        }

        private void FrmStations_Load(object sender, EventArgs e)
        {
            try
            {
                Initialize();
                cmbType.DataSource = StationTypeController.GetAll();
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "PEtada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            ViewController.Show(View.UcMenu);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void DataGridSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridSearch.CurrentRow == null) return;
            _selectedStation = (Station)DataGridSearch.CurrentRow.DataBoundItem;

            if (_selectedStation == null) return;

            BindingDataToControls();

            tabControlContent.SelectedTab = tabData;
        }

        private void Initialize()
        {
            tabControlContent.SelectedTab = tabData;
        }

        private void Search()
        {
            try
            {
                DataGridSearch.DataSource = StationController.GetAll();
                tabControlContent.SelectedTab = tabSearch;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindingDataToControls()
        {
            txtCode.Text = _selectedStation.Code.ToString();
            txtName.Text = _selectedStation.Name;
        }

        private void BindingControlsToData()
        {
            
        }
    }
}
