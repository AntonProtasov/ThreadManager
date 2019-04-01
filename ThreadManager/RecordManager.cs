using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadManager
{
    public class RecordManager
    {
        private readonly Random randomFunction;

        public RecordManager()
        {
            randomFunction = new Random();
        }

        public void AddRecords()
        {
            int recordsCount = randomFunction.Next(5, 11);

            int i = 1;
            while(i <= recordsCount)
            {
                int id = randomFunction.Next(1, 1000);
                DateTime time = DateTime.Now;

                int stringLength = randomFunction.Next(50, 100);
                string data = RecordManagerHelper.GenerateRandomString(randomFunction, stringLength);

                Record record = new Record
                {
                    Data = data,
                    Id = id,
                    Time = time
                };

                //Records.Add(record);
                i++;
            }
        }
    }
}