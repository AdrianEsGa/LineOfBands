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
        private readonly BackgroundWorker _worker;
        private List<OperationRegister> _activeOperations;
        private List<OperationRegister> _lastOperations;

        public UcRegisterOperations()
        {
            InitializeComponent();
            _worker = new BackgroundWorker();
            _worker.DoWork += Worker_DoWork;
            _worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        }

        private void UcRegisterOperations_Load(object sender, EventArgs e)
        {
            RefreshTimer.Start();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            ViewController.Show(View.UcMenu);
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            LoadOperations();
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            RefreshOperations();
        }

        private void LoadOperations()
        {
            try
            {
                _activeOperations = OperationRegisterController.GetActiveOperations();
                _lastOperations = OperationRegisterController.GetLastOperations();
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        private void RefreshOperations()
        {
            try
            {
                DataGridActiveOperations.DataSource = _activeOperations;
                DataGridLastOperations.DataSource = _lastOperations;
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            if (!_worker.IsBusy)
               _worker.RunWorkerAsync();
        }

    }
}
