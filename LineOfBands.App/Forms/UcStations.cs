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

        #region Events

        private void BtnBack_Click(object sender, EventArgs e)
        {
            ViewController.Show(View.UcMenu);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            New();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void DataGridSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridSearch.CurrentRow == null) return;
            _selectedStation = (Station)DataGridSearch.CurrentRow.DataBoundItem;

            if (_selectedStation == null) return;

            BindingDataToControls();

            tabControlContent.SelectedTab = tabData;
        }

        #endregion

        #region Private Methods

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
               ViewController.ShowError(ex.Message);
            }
        }

        private void New()
        {
            try
            {
                _selectedStation = new Station();
                BindingDataToControls();
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        private void Remove()
        {
            try
            {
                if(_selectedStation.Id == 0) return;
                StationController.Remove(_selectedStation);
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        private void Save()
        {
            try
            {
                BindingControlsToData();
               _selectedStation = StationController.SaveOrUpdate(_selectedStation);
                BindingDataToControls();
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        private void BindingDataToControls()
        {
            txtCode.Text = _selectedStation.Code.ToString();
            txtName.Text = _selectedStation.Name;
        }

        private void BindingControlsToData()
        {
            _selectedStation.Code = int.Parse(txtCode.Text);
            _selectedStation.Name = txtName.Text;
        }

        #endregion

    }
}
