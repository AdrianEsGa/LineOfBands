using System.Windows.Forms;
using LineOfBands.App.Forms;
using MetroFramework;
using MetroFramework.Controls;

namespace LineOfBands.App
{
    public static class ViewController
    {
        public static void Show(View viewType)
        {
            var view = new MetroUserControl();
            if (!FrmMain.Instance.Container.Controls.ContainsKey(viewType.ToString()))
            {
                switch (viewType)
                {
                    case View.UcRegisterOperations:
                        view = new UcRegisterOperations { Dock = DockStyle.Fill };
                        break;

                    case View.UcMenu:
                        view = new UcMenu() { Dock = DockStyle.Fill };
                        break;

                    case View.UcStations:
                        view = new UcStations() { Dock = DockStyle.Fill };
                        break;

                    case View.UcStationTypes:
                        view = new UcStationTypes() { Dock = DockStyle.Fill };
                        break;
                }

                FrmMain.Instance.Container.Controls.Add(view);
            }
     
            FrmMain.Instance.Container.Controls[viewType.ToString()].BringToFront();
        }

        public static void ShowError(string message)
        {
            MetroMessageBox.Show(FrmMain.Instance, message, "Ha ocurrido un error! Nooooo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public enum View
    {
        UcRegisterOperations,
        UcMenu,
        UcStations,
        UcStationTypes
    }
}
