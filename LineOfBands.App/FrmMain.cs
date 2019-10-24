using System;
using System.Threading;
using System.Windows.Forms;
using LineOfBands.App.Forms;
using LineOfBands.Common;
using LineOfBands.Database.Controllers;
using LineOfBands.Database.Entities;
using LineOfBands.Database.Repositories;
using LineOfBands.Opc;
using LineOfBands.Snap7;
using LineOfBands.Snap7.Entities;
using MetroFramework.Controls;

namespace LineOfBands.App
{
    public partial class FrmMain : MetroFramework.Forms.MetroForm
    {
        //-----------------------------------------------------------------------
        #region ESQUEMA DE FORMULARIO

        #region 1. DECLARACIÓN DE VARIABLES
        public static FrmMain Instance
        {
            get { return _instance ?? (_instance = new FrmMain()); }
        }
        private static FrmMain _instance; // Preguntar Adrian se crea un objeto para manejar el formulario
        public MetroPanel Container
        {
            get { return ContentPanel; }
            set { ContentPanel = value; }
        }

        #endregion

        #region 2. CARGAMOS EL FORMULARIO
        #region 2.0 Inicializaciones

        public FrmMain()        /// Código generado por visual estido - Controles, etc.
        {
            InitializeComponent();
            _instance = this;
        }
        private void Main_Load(object sender, EventArgs e)/// el primer evento que ejecuta siempre esté definido.
        {
            try
            {
                SqlServer.ConnectionString = "Server=DESKTOP-3K5JSL0\\TRAZA;Database=LineOfBands;User Id=sa;Password=1234;";
                InitializeStations();
                ViewController.Show(View.UcRegisterOperations);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ByeBye", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
        #endregion

        #region 3. FORMULARIO - EVENTOS 

        #region 3.1 Temporizadores

        //Motor de la aplicación Estaciones, Bandejas, Moldes, Operaciones, Ordenes de fabricación y piezas
        private void TimerComunicationStatus_Tick(object sender, EventArgs e)
        {
            TimerS7ComunicationStatus.Stop();

            foreach (var station in AppGlobal.Stations)
            {
                if (station.Bussy) continue;

                if (!S7.GetBitAt(AppGlobal.Snap7Server.Read(station.StatusChangeS7), 0, 0)) continue;

                var data = AppGlobal.Snap7Server.Read(station.DataAddressS7);
                station.DataContent = Common.GetDataContent(data);

                var pallet = PalletController.GetByCode(station.DataContent.PalletCode);
                var operation = OperationController.GetByCode(station.DataContent.OperationCode);
                var mold = MoldRepository.GetByCode(station.DataContent.MoldCode);

                station.ActiveOperation = operation;
              
                if (operation.InitPart)
                {
                    station.Bussy = true;
                    Thread AskForReferencePartThread = new Thread(new ThreadStart(() => AskForReferencePart(station, pallet, operation, mold)));
                    AskForReferencePartThread.Start();
                }
                else
                {
                    OperationRegisterController.Register(station, pallet, operation, mold, "Pieza 1");
                    AppGlobal.Snap7Server.WriteWord(station.StatusChangeS7Ack, (ushort)operation.Code);
                }
            }

            TimerS7ComunicationStatus.Start();
        }

        private void AskForReferencePart(Station station, Pallet pallet, Operation operation, Mold mold)
        {

            var reference = string.Empty;
            FrmPartReference frmPartReference = new FrmPartReference();
            frmPartReference.ShowDialog();
            reference = frmPartReference.Reference;

            OperationRegisterController.Register(station, pallet, operation, mold, reference);

            AppGlobal.Snap7Server.WriteWord(station.StatusChangeS7Ack, (ushort)operation.Code);

            station.Bussy = false;
        }

        #endregion

        #region 3.2 Menu

        #endregion

        #region 3.3 Botones

        #endregion

        #endregion

        #region 4. FUNCIONES DEL FORMULARIO

        #region 4.1 Inicialización
        private void InitializeStations()// Cargamos estaciones de BD.
        {

            try
            {
                if (AppGlobal.ComunicationProtocol == ComunicationProtocol.Snap7)
                {
                    AppGlobal.Stations = StationController.GetAll();
                    AppGlobal.Snap7Server = new S7Server("192.168.0.1", 0, 0);

                    foreach (var station in AppGlobal.Stations)
                    {
                        station.StatusChangeS7 = new S7Item(station.StatusDataChangeAddress);
                        station.StatusChangeS7Ack = new S7Item(station.StatusDataChangeAddressAck);
                        station.DataAddressS7 = new S7Item(station.DataAddress);
                    }

                    TimerS7ComunicationStatus.Start();
                   // TimerStateStations.Start();
                }
                else
                {
                    AppGlobal.FillStation1 = StationController.GetByCode(1);
                    AppGlobal.FillStation2 = StationController.GetByCode(2);

                    AppGlobal.OvenStation1 = StationController.GetByCode(3);
                    AppGlobal.OvenStation2 = StationController.GetByCode(4);
                    AppGlobal.OvenStation3 = StationController.GetByCode(5);
                    AppGlobal.OvenStation4 = StationController.GetByCode(6);
                    AppGlobal.OvenStation5 = StationController.GetByCode(7);
                    AppGlobal.OvenStation6 = StationController.GetByCode(8);
                    AppGlobal.OvenStation7 = StationController.GetByCode(9);
                    AppGlobal.OvenStation8 = StationController.GetByCode(10);
                    AppGlobal.OvenStation9 = StationController.GetByCode(11);
                    AppGlobal.OvenStation10 = StationController.GetByCode(12);

                    AppGlobal.UnmoldStation1 = StationController.GetByCode(13);
                    AppGlobal.UnmoldStation2 = StationController.GetByCode(14);

                    AppGlobal.TransferStation = StationController.GetByCode(15);

                    AppGlobal.Stations.Add(AppGlobal.FillStation1);
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en InitializeStations()");
            }
        }

        #endregion

        #region 4.2 Validaciones


        #endregion

        #region 4.3 Refresco de información en el formulario

        #endregion

        #region 4.4 PLC

        #endregion

        #region 4.4 Lectores CDB

        #endregion

        #region 4.5 Impresoras

        #endregion

        #region 4.6 Base de datos SQL

        #endregion

        #region 4.7 Pruebas

        #endregion

        #endregion
        #endregion


        //-----------------------------------------------------------------------

        #region BORRAR

        #region OPC - Protocolo de cumunicación

        #region Initialize
        private static void TransferStationGroup_DataChange(object sender, Group.DataChangeArgs e)
        {


        }

        private static void UnmoldStation2Group_DataChange(object sender, Group.DataChangeArgs e)
        {

        }

        private static void UnmoldStation1Group_DataChange(object sender, Group.DataChangeArgs e)
        {
            throw new NotImplementedException();
        }

        private static void OvenStation10Group_DataChange(object sender, Group.DataChangeArgs e)
        {
            throw new NotImplementedException();
        }

        private static void OvenStation9Group_DataChange(object sender, Group.DataChangeArgs e)
        {
            throw new NotImplementedException();
        }

        private static void OvenStation8Group_DataChange(object sender, Group.DataChangeArgs e)
        {
            throw new NotImplementedException();
        }

        private static void OvenStation7Group_DataChange(object sender, Group.DataChangeArgs e)
        {
            throw new NotImplementedException();
        }

        private static void OvenStation6Group_DataChange(object sender, Group.DataChangeArgs e)
        {
            throw new NotImplementedException();
        }

        private static void OvenStation5Group_DataChange(object sender, Group.DataChangeArgs e)
        {
            throw new NotImplementedException();
        }

        private static void OvenStation4Group_DataChange(object sender, Group.DataChangeArgs e)
        {
            throw new NotImplementedException();
        }

        private static void OvenStation3Group_DataChange(object sender, Group.DataChangeArgs e)
        {
            throw new NotImplementedException();
        }

        private static void OvenStation2Group_DataChange(object sender, Group.DataChangeArgs e)
        {
            throw new NotImplementedException();
        }

        private static void OvenStation1Group_DataChange(object sender, Group.DataChangeArgs e)
        {
            throw new NotImplementedException();
        }

        private static void FillStation2Group_DataChange(object sender, Group.DataChangeArgs e)
        {
            throw new NotImplementedException();
        }

        private static void FillStation1Group_DataChange(object sender, Group.DataChangeArgs e)
        {
            throw new NotImplementedException();
        }

        private void InitializeOpc()
        {
            InitializeOpc_Initilize();
            InitializeOpc_EventsHandlers();
            InitializeOpc_AddGroups();
            InitializeOpc_InitilizeStationItems();
            InitializeOpc_AddItems();
        }

        private void InitializeOpc_Initilize()
        {
            AppGlobal.OpcServer = new Server("Simatic.NET");
            AppGlobal.FillStation1Group = new Group("FillStation1Group", 500, true, true);
            AppGlobal.FillStation2Group = new Group("FillStation2Group", 500, true, true);

            AppGlobal.OvenStation1Group = new Group("OvenStation1Group", 500, true, true);
            AppGlobal.OvenStation2Group = new Group("OvenStation2Group", 500, true, true);
            AppGlobal.OvenStation3Group = new Group("OvenStation3Group", 500, true, true);
            AppGlobal.OvenStation4Group = new Group("OvenStation4Group", 500, true, true);
            AppGlobal.OvenStation5Group = new Group("OvenStation5Group", 500, true, true);
            AppGlobal.OvenStation6Group = new Group("OvenStation6Group", 500, true, true);
            AppGlobal.OvenStation7Group = new Group("OvenStation7Group", 500, true, true);
            AppGlobal.OvenStation8Group = new Group("OvenStation8Group", 500, true, true);
            AppGlobal.OvenStation9Group = new Group("OvenStation9Group", 500, true, true);
            AppGlobal.OvenStation10Group = new Group("OvenStation10Group", 500, true, true);

            AppGlobal.UnmoldStation1Group = new Group("UnmoldStation1Group", 500, true, true);
            AppGlobal.UnmoldStation2Group = new Group("UnmoldStation2Group", 500, true, true);

            AppGlobal.TransferStationGroup = new Group("TransferStationGroup", 500, true, true);
        }

        private void InitializeOpc_EventsHandlers()
        {
            AppGlobal.FillStation1Group.StatusDataChange += FillStation1Group_DataChange;
            AppGlobal.FillStation2Group.StatusDataChange += FillStation2Group_DataChange;

            AppGlobal.OvenStation1Group.StatusDataChange += OvenStation1Group_DataChange;
            AppGlobal.OvenStation2Group.StatusDataChange += OvenStation2Group_DataChange;
            AppGlobal.OvenStation3Group.StatusDataChange += OvenStation3Group_DataChange;
            AppGlobal.OvenStation4Group.StatusDataChange += OvenStation4Group_DataChange;
            AppGlobal.OvenStation5Group.StatusDataChange += OvenStation5Group_DataChange;
            AppGlobal.OvenStation6Group.StatusDataChange += OvenStation6Group_DataChange;
            AppGlobal.OvenStation7Group.StatusDataChange += OvenStation7Group_DataChange;
            AppGlobal.OvenStation8Group.StatusDataChange += OvenStation8Group_DataChange;
            AppGlobal.OvenStation9Group.StatusDataChange += OvenStation9Group_DataChange;
            AppGlobal.OvenStation10Group.StatusDataChange += OvenStation10Group_DataChange;

            AppGlobal.UnmoldStation1Group.StatusDataChange += UnmoldStation1Group_DataChange;
            AppGlobal.UnmoldStation2Group.StatusDataChange += UnmoldStation2Group_DataChange;

            AppGlobal.TransferStationGroup.StatusDataChange += TransferStationGroup_DataChange;
        }

        private void InitializeOpc_AddGroups()
        {
            AppGlobal.OpcServer.AddGroup(AppGlobal.FillStation1Group);
            AppGlobal.OpcServer.AddGroup(AppGlobal.FillStation2Group);

            AppGlobal.OpcServer.AddGroup(AppGlobal.OvenStation1Group);
            AppGlobal.OpcServer.AddGroup(AppGlobal.OvenStation2Group);
            AppGlobal.OpcServer.AddGroup(AppGlobal.OvenStation3Group);
            AppGlobal.OpcServer.AddGroup(AppGlobal.OvenStation4Group);
            AppGlobal.OpcServer.AddGroup(AppGlobal.OvenStation5Group);
            AppGlobal.OpcServer.AddGroup(AppGlobal.OvenStation6Group);
            AppGlobal.OpcServer.AddGroup(AppGlobal.OvenStation7Group);
            AppGlobal.OpcServer.AddGroup(AppGlobal.OvenStation8Group);
            AppGlobal.OpcServer.AddGroup(AppGlobal.OvenStation9Group);
            AppGlobal.OpcServer.AddGroup(AppGlobal.OvenStation10Group);

            AppGlobal.OpcServer.AddGroup(AppGlobal.UnmoldStation1Group);
            AppGlobal.OpcServer.AddGroup(AppGlobal.UnmoldStation2Group);

            AppGlobal.OpcServer.AddGroup(AppGlobal.TransferStationGroup);
        }

        private void InitializeOpc_InitilizeStationItems()
        {
            //Status change item
            AppGlobal.FillStation1.StatusChangeOpc = new Item(AppGlobal.FillStation1.StatusDataChangeAddress);
            AppGlobal.FillStation2.StatusChangeOpc = new Item(AppGlobal.FillStation2.StatusDataChangeAddress);

            AppGlobal.OvenStation1.StatusChangeOpc = new Item(AppGlobal.OvenStation1.StatusDataChangeAddress);
            AppGlobal.OvenStation2.StatusChangeOpc = new Item(AppGlobal.OvenStation2.StatusDataChangeAddress);
            AppGlobal.OvenStation3.StatusChangeOpc = new Item(AppGlobal.OvenStation3.StatusDataChangeAddress);
            AppGlobal.OvenStation4.StatusChangeOpc = new Item(AppGlobal.OvenStation4.StatusDataChangeAddress);
            AppGlobal.OvenStation5.StatusChangeOpc = new Item(AppGlobal.OvenStation5.StatusDataChangeAddress);
            AppGlobal.OvenStation6.StatusChangeOpc = new Item(AppGlobal.OvenStation6.StatusDataChangeAddress);
            AppGlobal.OvenStation7.StatusChangeOpc = new Item(AppGlobal.OvenStation7.StatusDataChangeAddress);
            AppGlobal.OvenStation8.StatusChangeOpc = new Item(AppGlobal.OvenStation8.StatusDataChangeAddress);
            AppGlobal.OvenStation9.StatusChangeOpc = new Item(AppGlobal.OvenStation9.StatusDataChangeAddress);
            AppGlobal.OvenStation10.StatusChangeOpc = new Item(AppGlobal.OvenStation10.StatusDataChangeAddress);

            AppGlobal.UnmoldStation1.StatusChangeOpc = new Item(AppGlobal.UnmoldStation1.StatusDataChangeAddress);
            AppGlobal.UnmoldStation2.StatusChangeOpc = new Item(AppGlobal.UnmoldStation2.StatusDataChangeAddress);

            AppGlobal.TransferStation.StatusChangeOpc = new Item(AppGlobal.TransferStation.StatusDataChangeAddress);



        }

        private void InitializeOpc_AddItems()
        {
            //Change group - items

            AppGlobal.FillStation1Group.AddOpcItem(AppGlobal.FillStation1.StatusChangeOpc, 1000);
            AppGlobal.FillStation2Group.AddOpcItem(AppGlobal.FillStation2.StatusChangeOpc, 1000);

            AppGlobal.OvenStation1Group.AddOpcItem(AppGlobal.OvenStation1.StatusChangeOpc, 1000);
            AppGlobal.OvenStation2Group.AddOpcItem(AppGlobal.OvenStation2.StatusChangeOpc, 1000);
            AppGlobal.OvenStation3Group.AddOpcItem(AppGlobal.OvenStation3.StatusChangeOpc, 1000);
            AppGlobal.OvenStation4Group.AddOpcItem(AppGlobal.OvenStation4.StatusChangeOpc, 1000);
            AppGlobal.OvenStation5Group.AddOpcItem(AppGlobal.OvenStation5.StatusChangeOpc, 1000);
            AppGlobal.OvenStation6Group.AddOpcItem(AppGlobal.OvenStation6.StatusChangeOpc, 1000);
            AppGlobal.OvenStation7Group.AddOpcItem(AppGlobal.OvenStation7.StatusChangeOpc, 1000);
            AppGlobal.OvenStation8Group.AddOpcItem(AppGlobal.OvenStation8.StatusChangeOpc, 1000);
            AppGlobal.OvenStation9Group.AddOpcItem(AppGlobal.OvenStation9.StatusChangeOpc, 1000);
            AppGlobal.OvenStation10Group.AddOpcItem(AppGlobal.OvenStation10.StatusChangeOpc, 1000);

            AppGlobal.UnmoldStation1Group.AddOpcItem(AppGlobal.UnmoldStation1.StatusChangeOpc, 1000);
            AppGlobal.UnmoldStation2Group.AddOpcItem(AppGlobal.UnmoldStation2.StatusChangeOpc, 1000);

            AppGlobal.TransferStationGroup.AddOpcItem(AppGlobal.TransferStation.StatusChangeOpc, 1000);





        }

        #endregion

        #region Events


        #endregion

        #endregion

        #endregion

        #region 3. Comunicaciones





        #endregion






    }
}