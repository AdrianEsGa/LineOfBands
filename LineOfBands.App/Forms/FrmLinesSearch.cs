using System.Drawing;
using System.Windows.Forms;
using LineOfBands.Database.Entities;
using LineOfBands.Database.Repositories;

namespace LineOfBands.App.Forms
{
    public partial class FrmLinesSearch : Form
    {
        public Line SelectedLine { get; set; }
        public FrmLinesSearch()
        {
            InitializeComponent();
        }

        private void FrmLinesSearch_Load(object sender, System.EventArgs e)
        {
            DataGridViewLines.DataSource = LineRepository.GetAll();
        }

        private void DataGridViewLines_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewLines.CurrentRow == null) return;
            DataGridViewLines.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.Green;
            SelectedLine = (Line)DataGridViewLines.CurrentRow.DataBoundItem;
            Close();
        }
    }
}
