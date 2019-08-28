using System;
using OPCAutomation;

namespace LineOfBands.Opc
{
    public class Item
    {
        private OPCItem _opcItem;
        private string _address;

        public Item(string adresss)
        {
            _address = adresss;
        }

        public OPCItem OpcItem
        {
            set { _opcItem = value; }
        }

        public string Address
        {
            get { return _address; }
        }

        public object Value
        {
            get { return _opcItem.Value; }
            set { _opcItem.Write(value); }
        }

        public OPCQuality Quality
        {
            get
            {
                if (_opcItem != null)
                {
                    return (OPCQuality)_opcItem.Quality;
                }

                return OPCQuality.OPCQualityBad;
            }
        }

        //public bool? GetBit(int nBit)
        //{
        //    if (_opcItem != null)
        //    {
        //        return (_opcItem.Value && (1 << nBit)) > 0;
        //    }

        //    return null;

        //}

        private static bool? GetBit(object value, int bit)
        {
            return ((int)value & (1 << bit)) > 0;
        }

        //public void SetBit(int nBit, bool status)
        //{

        //    if (_opcItem == null)
        //        return;

        //    try
        //    {
        //        if (GetBit(nBit) == status) return;
        //        SyncOpcWrite(status);

        //    }
        //    catch (Exception ex)
        //    {
        //        // ignored
        //    }
        //}


        //public void SetBit(int bit, bool Estado)
        //{
        //    if (_opcItem == null)
        //        return;
        //    object Value = null;
        //    try
        //    {
        //        //If _opcItem.Quality = OPCAutomation.OPCQuality.OPCQualityGood Then
        //        // Forzar lectura de la varible
        //        Value = SyncOpcRead();
        //        // Sólo escribe si el estado del bit es diferente al solicitado
        //        if (GetBit(Value, bit) != Estado)
        //        {
        //            if (Estado)
        //            {
        //                //Item.Write(Value Or (1 << bit))
        //                SyncOpcWrite(Value | (1 << bit));
        //            }
        //            else
        //            {
        //                //Item.Write(Value And Not (1 << bit))
        //                SyncOpcWrite(Value & !(1 << bit));
        //            }
        //        }
        //        //End If
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //}




        private object SyncOpcRead()
        {
            Array handles = new Array[2];
            Array values = null;

            try
            {
                Array errors;
                object qualities;
                object timestamps;

                _opcItem.Parent.SyncRead((short)OPCDataSource.OPCDevice, 1, ref handles, out values, out errors, out qualities, out timestamps);
            }
            catch (Exception ex)
            {
                // ignored
            }

            return values != null ? values.GetValue(1) : null;
        }

        public void SyncOpcWrite(object value)
        {
            Array handles = new Array[2];
            Array values = new Array[1];
            Array errors;

            try
            {
                Array.IndexOf(handles, _opcItem.ServerHandle);
                Array.IndexOf(values, value);

                _opcItem.Parent.SyncWrite(1, ref handles, ref values, out errors);
            }
            catch (Exception ex)
            {
                // ignored
            }
        }

    }
}
