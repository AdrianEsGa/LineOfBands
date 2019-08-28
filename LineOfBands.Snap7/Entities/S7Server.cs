using System;

namespace LineOfBands.Snap7.Entities
{

    public class S7Server
    {
        public string IpAddress { get; set; }
        public int Rack { get; set; }
        public int Slot { get; set; }
        private S7Client client { get; set; }

        public S7Server(string ipAddress, int rack, int slot)
        {
            try
            {
                client = new S7Client();
                client.ConnectTo(ipAddress, rack, slot);

                if (!client.Connected) throw new Exception("No Conectado!!!");


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public byte [] Read(S7Item item)
        {
            if(!client.Connected) throw new Exception("La conexión no esta abierta");
            byte[] buffer = new byte[1024];
            client.ReadArea(item.Area, item.DBNumber, item.Start,item.Amount, item.WordLen, buffer);
            return buffer;
        }
        public void WriteBit(S7Item item,bool value)
        {
            if (!client.Connected) throw new Exception("La conexión no esta abierta");
            byte[] buffer = new byte[1024];
            S7.SetBitAt(ref buffer, 0, 0, value);
            client.WriteArea(item.Area, item.DBNumber, item.Start, item.Amount, item.WordLen, buffer);
        }

        public void WriteWord(S7Item item, ushort value)
        {
            if (!client.Connected) throw new Exception("La conexión no esta abierta");
            byte[] buffer = new byte[1024];
            S7.SetWordAt(buffer, 0, value);
            client.WriteArea(item.Area, item.DBNumber, item.Start, item.Amount, item.WordLen, buffer);
        }

    }
}
