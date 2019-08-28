using System;
using System.Windows.Forms;
using LineOfBands.Database.Entities;
using LineOfBands.Database.Repositories;

namespace LineOfBands.App.Forms
{
    public partial class FrmLines : Form
    {
        private Line _line;

        public FrmLines()
        {
            InitializeComponent();
        }

        private void FrmLines_Load(object sender, EventArgs e)
        {
            _line = new Line();
            BindingDataToControls();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var frmLinesSearch = new FrmLinesSearch();
            frmLinesSearch.ShowDialog();
            _line = frmLinesSearch.SelectedLine;
            frmLinesSearch.Dispose();
            BindingDataToControls();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            NewData();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            RemoveData();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveOrUpdateData();
        }

        private void NewData()
        {
            _line = new Line();
            BindingDataToControls();
        }

        private void SaveOrUpdateData()
        {
            BindingDataFromControls();

            if (DataIsValidToSaveOrUpdate())
            {
                LineRepository.SaveOrUpdate(_line);
                CheckRepositoryTransaction();
            }
            else
            {
                MessageBox.Show("Existe un error en los datos", "Error en los datos", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void RemoveData()
        {
            LineRepository.Remove(_line);
            CheckRepositoryTransaction();
        }

        private void BindingDataToControls()
        {
            if (_line == null) return;
            TxtCode.Text = _line.Code.ToString();
            TxtName.Text = _line.Name;
        }

        private void BindingDataFromControls()
        {
            _line.Code = int.Parse(TxtCode.Text);
            _line.Name = TxtName.Text;
        }

        private bool DataIsValidToSaveOrUpdate()
        {
            if (_line.Code == 0) return false;
            if (string.IsNullOrEmpty(_line.Name)) return false;
            return true;
        }

        private void CheckRepositoryTransaction()
        {
            if (LineRepository.TranResult == TransactionResult.Succsesfull)
            {
                MessageBox.Show(LineRepository.TranMessage, "Operación correcta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                NewData();
            }
            else
            {
                MessageBox.Show(LineRepository.TranMessage, "Operación incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {             
                    e.Handled = true;
                } 
        }
    }
}
