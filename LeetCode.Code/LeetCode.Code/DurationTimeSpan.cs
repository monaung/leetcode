using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class DurationTimeSpan
    {
        public DurationTimeSpan()
        {
            List<Measure> measurements = new List<Measure>
            {
                new Measure { Time = new DateTime(2019, 10, 01, 10, 14, 11), Value = 0 },
                new Measure { Time = new DateTime(2019, 10, 01, 10, 55, 00), Value = 1 },
                new Measure { Time = new DateTime(2019, 10, 01, 12, 21, 00), Value = 0 },
                new Measure { Time = new DateTime(2019, 10, 01, 13, 14, 12), Value = 1 },
                new Measure { Time = new DateTime(2019, 10, 01, 14, 45, 14), Value = 0 }
                    //new Measure { Time = new DateTime(2025, 3, 01, 0, 0, 0), Value = 0 },
                    //new Measure { Time = new DateTime(2025, 3, 03, 0, 0, 0), Value = 1 },
                    //new Measure { Time = new DateTime(2025, 3, 05, 0, 0, 0), Value = 0 },
                    //new Measure { Time = new DateTime(2025, 3, 07, 0, 0, 0), Value = 0 },
                    //new Measure { Time = new DateTime(2025, 3, 9, 0, 0, 0), Value = 1 },
                    //new Measure { Time = new DateTime(2025, 3, 11, 0, 0, 0), Value = 0 },
                    //new Measure { Time = new DateTime(2025, 3, 14, 0, 0, 0), Value = 0 }

            };

            //var result = GetRunningDurationPeriod(measurements.ToArray(), new DateTime(2025, 3, 7), new DateTime(2025, 3, 11));
            var result = GetRunningDurationPeriod(measurements.ToArray(), new DateTime(2019, 10, 01, 10, 15,00), new DateTime(2019, 10, 01, 10, 58, 00));

            Console.WriteLine($"Running time is {result}");
        }

        public TimeSpan GetRunningDurationPeriod(Measure[] onOffMeasure, DateTime start, DateTime end)
        {

            var previousOnRecord = onOffMeasure.Where(x => x.Time < end && x.Value == 1).OrderByDescending(x => x.Time).FirstOrDefault();
            

            //var startRecord = onOffMeasure.Where(x => x.Time < start && x.Time >= previousOnRecord?.Time).OrderByDescending(x => x.Time).FirstOrDefault();

            if (previousOnRecord == null || previousOnRecord.Value == 0)
                return TimeSpan.Zero;

            if (previousOnRecord.Time > start)
                start = previousOnRecord.Time;

            var lastOffAt = onOffMeasure.Where(x => x.Time <= end && x.Time >= previousOnRecord.Time && x.Value == 0).OrderBy(x => x.Time).FirstOrDefault();

            if (lastOffAt != null)
                end = lastOffAt.Time;

            var result = end - start;

            return result;
        }
    }

    public class Measure
    {
        public DateTime Time { get; set; }
        public int Value { get; set; }
    }
}
