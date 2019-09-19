using LineOfBands.Database.Entities;
using LineOfBands.Snap7;

namespace LineOfBands.App
{
    public static class Common
    {
        public static DataContent GetDataContent(byte [] buffer)
        {

            var content = new DataContent
            {
                ResultCode = S7.GetWordAt(buffer, 0),
                PalletCode = S7.GetWordAt(buffer, 2),
                OperationCode = S7.GetWordAt(buffer, 4),
                MoldCode = S7.GetWordAt(buffer, 6),
                AlarmCode = S7.GetWordAt(buffer, 8),
            };

            return content;
        }
    }
}
