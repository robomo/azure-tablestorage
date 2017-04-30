using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableStorage.Model
{

    using Microsoft.WindowsAzure.Storage.Table;

    public class SensorReadingEntity : TableEntity
    {

        public SensorReadingEntity() { }

        public SensorReadingEntity(string sensorId)
        {
            PartitionKey = sensorId;
            //RowKey = (DateTime.MaxValue.Ticks - timeOfReport.Ticks).ToString("d19");
            RowKey = DateTime.Now.ToString("yyyyMMddHHmmssffff");
        }

        public Double Temperature { get; set; }
        public Double Humidity { get; set; }
        public Double Light { get; set; }

    }

}
