using LeetCode.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    public class DurationUnitTest
    {
        private readonly DurationTimeSpan duration;
        public DurationUnitTest()
        {
            this.duration = new DurationTimeSpan();

        }
        [Theory]
        [ClassData(typeof(DurationTestData))]
        public void DurationUnitTest_Test(DurationTest data)
        {
            var reuslt = duration.GetRunningDurationPeriod(data.Measurement.ToArray(), data.Start, data.End);

            Assert.Equal(data.Expected, reuslt);
        }
    }
}
