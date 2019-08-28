using System.Collections.Generic;
using LineOfBands.Database.Entities;
using LineOfBands.Opc;
using LineOfBands.Snap7.Entities;

namespace LineOfBands.App
{
    public static class AppGlobal
    {

        public static ComunicationProtocol ComunicationProtocol = ComunicationProtocol.Snap7;
        public static S7Server Snap7Server;
        public static List<Station> Stations;

        //Declaramaos las estaciones en un ambito
        public static Station FillStation1;
        public static Station FillStation2;

        public static Station OvenStation1;
        public static Station OvenStation2;
        public static Station OvenStation3;
        public static Station OvenStation4;
        public static Station OvenStation5;
        public static Station OvenStation6;
        public static Station OvenStation7;
        public static Station OvenStation8;
        public static Station OvenStation9;
        public static Station OvenStation10;

        public static Station UnmoldStation1;
        public static Station UnmoldStation2;

        public static Station TransferStation;



        //OPC Server variables
        public static Server OpcServer;

        public static Group FillStation1Group;
        public static Group FillStation2Group;

        public static Group OvenStation1Group;
        public static Group OvenStation2Group;
        public static Group OvenStation3Group;
        public static Group OvenStation4Group;
        public static Group OvenStation5Group;
        public static Group OvenStation6Group;
        public static Group OvenStation7Group;
        public static Group OvenStation8Group;
        public static Group OvenStation9Group;
        public static Group OvenStation10Group;

        public static Group UnmoldStation1Group;
        public static Group UnmoldStation2Group;

        public static Group TransferStationGroup;

        public static Group GenericGroup;
    }

    public enum ComunicationProtocol
    {
        Snap7 = 1,
        Opc = 2
    }
}
