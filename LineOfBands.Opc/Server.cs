using System.Collections.Generic;
using OPCAutomation;

namespace LineOfBands.Opc
{
    public class Server
    {
        private readonly string _name;
        private readonly OPCServer _opcServer;
        private readonly List<Group> _opcGroups;

        public Server(string name)
        {
            _name = name;
            _opcServer = new OPCServer();
            _opcGroups = new List<Group>();

            Connect();
        }


        public bool IsConnnected
        {
            get
            {
                return _opcServer.ServerState == 1;
            }
        }

        public void Disconnect()
        {
            _opcServer.Disconnect();
        }

        private void Connect()
        {
            _opcServer.Connect(_name, "");
        }

        public void AddGroup(Group group)
        {
            group.OpcGroup = _opcServer.OPCGroups.Add(group.Name);
            group.OpcGroup.UpdateRate = group.UpdateRate;
            group.OpcGroup.IsActive = group.IsActive;
            group.OpcGroup.IsSubscribed = group.IsSubscribed;
            _opcGroups.Add(group);

        }



    }
}
