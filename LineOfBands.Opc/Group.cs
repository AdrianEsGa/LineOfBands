using System;
using System.Collections.Generic;
using OPCAutomation;

namespace LineOfBands.Opc
{
    public class Group
    {
        private OPCGroup _opcGroup;
        private readonly string _name;
        private readonly int _updateRate;
        private readonly bool _isSubscribed;
        private readonly bool _isActive;
        private readonly List<Item> Items;

        public delegate void DataChangeEventHandler(object sender, DataChangeArgs e);
        public event DataChangeEventHandler StatusDataChange;

        public Group(string name, int updateRate, bool isSubscribed, bool isActive)
        {
            _name = name;
            _updateRate = updateRate;
            _isSubscribed = isSubscribed;
            _isActive = isActive;
            Items = new List<Item>();
            _opcGroup.DataChange += DataChange;
        }

        public OPCGroup OpcGroup
        {
            get { return _opcGroup; }
            set { _opcGroup = value; }
        }

        public string Name
        {
            get { return _name; }
        }

        public int UpdateRate
        {
            get { return _updateRate; }
        }

        public bool IsSubscribed
        {
            get { return _isSubscribed; }
        }

        public bool IsActive
        {
            get { return _isActive; }
        }

        public void AddOpcItem(Item item, int clientHandle)
        {
            item.OpcItem = _opcGroup.OPCItems.AddItem(item.Address, clientHandle);
            Items.Add(item);
        }

        public class DataChangeArgs
        {
            public DataChangeArgs(string s) { Text = s; }
            public String Text { get; private set; } // readonly
        }

        private void DataChange(int transactionid, int numitems, ref Array clienthandles, ref Array itemvalues, ref Array qualities, ref Array timestamps)
        {
            if (StatusDataChange != null) StatusDataChange.Invoke(this, new DataChangeArgs("Hello"));
        }

        
    }

}
