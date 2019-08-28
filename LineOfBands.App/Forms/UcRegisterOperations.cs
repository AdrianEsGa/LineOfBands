using System;
using System.Collections.Generic;
using System.ComponentModel;
using LineOfBands.Database.Controllers;
using LineOfBands.Database.Entities;
using MetroFramework.Controls;

namespace LineOfBands.App.Forms
{
    public partial class UcRegisterOperations : MetroUserControl
    {
        private BackgroundWorker _worker;
        private List<OperationRegister> _activeOperations;
        private List<OperationRegister> _lastOperations;

        public UcRegisterOperations()
        {
            InitializeComponent();
        }

        private void BtnMenu_Click(object sender, System.EventArgs e)
        {
            ViewController.Show(View.UcMenu);
            _worker = new BackgroundWorker();

            _worker.DoWork += Worker_DoWork;
            _worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            LoadOperations();
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            RefreshOperations();
        }

        private void UcRegisterOperations_Load(object sender, System.EventArgs e)
        {
            _worker.RunWorkerAsync();
        }

        private void LoadOperations()
        {
            try
            {
                _activeOperations = OperationRegisterController.GetActiveOperations();
                _lastOperations = OperationRegisterController.GetLastOperations();
            }
            catch (Exception)
            {

            }
        }

        private void RefreshOperations()
        {
            try
            {
                DataGridActiveOperations.DataSource = _activeOperations;
                DataGridLastOperations.DataSource = _lastOperations;
            }
            catch (Exception)
            {

            }
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            if (!_worker.IsBusy)
               _worker.RunWorkerAsync();
        }

    }
}
