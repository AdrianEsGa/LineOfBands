using System;
using LineOfBands.Database.Controllers;
using LineOfBands.Database.Entities;
using MetroFramework.Controls;

namespace LineOfBands.App.Forms
{
    public partial class UcStationTypes : MetroUserControl
    {

        private StationType _selectedStationType;

        public UcStationTypes()
        {
            InitializeComponent();
        }
        private void UcStationTypes_Load(object sender, EventArgs e)
        {
            Initialize();
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
                DataGridSearch.DataSource = StationTypeController.GetAll();
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
                _selectedStationType = new StationType();
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
                if (_selectedStationType.Id == 0) return;
                //StationTypeController.Remove(_selectedStationType);
                New();
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
                //_selectedStationType = StationTypeController.SaveOrUpdate(_selectedStationType);
                BindingDataToControls();
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        private void BindingDataToControls()
        {
            txtName.Text = _selectedStationType.Name;
         }

        private void BindingControlsToData()
        {
            _selectedStationType.Name = txtName.Text;
        }

        #endregion

        private void DataGridSearch_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (DataGridSearch.CurrentRow == null) return;
            _selectedStationType = (StationType)DataGridSearch.CurrentRow.DataBoundItem;

            if (_selectedStationType == null) return;

            BindingDataToControls();

            tabControlContent.SelectedTab = tabData;
        }
    }
}
