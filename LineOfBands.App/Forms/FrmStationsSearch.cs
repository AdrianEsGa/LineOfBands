using System.Drawing;
using System.Windows.Forms;
using LineOfBands.Database.Controllers;
using LineOfBands.Database.Entities;
using LineOfBands.Database.Repositories;

namespace LineOfBands.App.Forms
{
    public partial class FrmStationsSearch : Form
    {
        public Station SelectedStation { get; set; }
        public FrmStationsSearch()
        {
            InitializeComponent();
        }

        private void FrmStationsSearch_Load(object sender, System.EventArgs e)
        {
            DataGridViewStations.DataSource = StationController.GetAll();
        }

        private void DataGridViewStations_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewStations.CurrentRow == null) return;
            DataGridViewStations.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.Green;
            SelectedStation = (Station)DataGridViewStations.CurrentRow.DataBoundItem;
            Close();
        }


    }
}
