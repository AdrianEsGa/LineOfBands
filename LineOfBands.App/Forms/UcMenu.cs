using MetroFramework.Controls;

namespace LineOfBands.App.Forms
{
    public partial class UcMenu : MetroUserControl
    {
        public UcMenu()
        {
            InitializeComponent();
        }

        private void UcMenu_Load(object sender, System.EventArgs e)
        {

        }

        private void BtnStationTypes_Click(object sender, System.EventArgs e)
        {
            ViewController.Show(View.UcStationTypes);
        }

        private void BtnBack_Click(object sender, System.EventArgs e)
        {
            ViewController.Show(View.UcRegisterOperations);
        }

        private void BtnStations_Click(object sender, System.EventArgs e)
        {
            ViewController.Show(View.UcStations);
        }
    }
}
