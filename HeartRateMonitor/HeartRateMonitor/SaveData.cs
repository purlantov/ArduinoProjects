using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartRateMonitor
{
    public class SaveData
    {
        private string tmpSaveFile = "tmp.txt";

        public void DataSave(int value)
        {
            System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(tmpSaveFile,true);
            using (streamWriter)
            {
                streamWriter.Write(value + ";");
            }
        }
    }
}
