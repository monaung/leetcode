using LeetCode.Code;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;
using static LeetCode.Test.UnitTest1;

namespace LeetCode.Test
{
    [Serializable()]
    public class DurationTest
    {
        public List<Measure> Measurement { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public TimeSpan Expected { get; set; }
    }

    [Serializable()]
    public class DurationTestData : IEnumerable<object[]>, IXunitSerializable
    {
        private readonly List<object[]> data = new List<object[]>()
        {
             new object[]{
                 new DurationTest{
                    Measurement = new List<Measure>
                    {
                        new Measure { Time = new DateTime(2019, 10, 01, 10, 14, 11), Value = 0 },
                        new Measure { Time = new DateTime(2019, 10, 01, 10, 55, 00), Value = 1 },
                        new Measure { Time = new DateTime(2019, 10, 01, 12, 21, 00), Value = 0 },
                        new Measure { Time = new DateTime(2019, 10, 01, 13, 14, 12), Value = 1 },
                        new Measure { Time = new DateTime(2019, 10, 01, 14, 45, 14), Value = 0 }
                    },
                    Start = new DateTime(2019, 10, 01, 10, 15, 00),
                    End = new DateTime(2019, 10, 01, 11, 00, 00),
                    Expected = new TimeSpan(0,5,0)
                }
           
             
             },

             new object[]
             {
                    new DurationTest{
                    Measurement = new List<Measure>
                    {
                        new Measure { Time = new DateTime(2025, 3, 01, 0, 0, 0), Value = 0 },
                        new Measure { Time = new DateTime(2025, 3, 03, 0, 0, 0), Value = 1 },
                        new Measure { Time = new DateTime(2025, 3, 05, 0, 0, 0), Value = 0 },
                        new Measure { Time = new DateTime(2025, 3, 07, 0, 0, 0), Value = 0 },
                        new Measure { Time = new DateTime(2025, 3, 9, 0, 0, 0), Value = 1 },
                        new Measure { Time = new DateTime(2025, 3, 11, 0, 0, 0), Value = 0 },
                        new Measure { Time = new DateTime(2025, 3, 14, 0, 0, 0), Value = 0 }                    
                    },
                    Start = new DateTime(2025, 3, 7),
                    End = new DateTime(2025, 3, 11),
                    Expected = new TimeSpan(2,0, 0, 0)
                }
              
             }
             ,

             new object[]
             {
                    new DurationTest{
                    Measurement = new List<Measure>
                    {
                        new Measure { Time = new DateTime(2025, 3, 01, 0, 0, 0), Value = 1 },
                        new Measure { Time = new DateTime(2025, 3, 03, 0, 0, 0), Value = 0 }, //2 days
                        new Measure { Time = new DateTime(2025, 3, 05, 0, 0, 0), Value = 1 }, 
                        new Measure { Time = new DateTime(2025, 3, 07, 0, 0, 0), Value = 0 }, //2 days
                        new Measure { Time = new DateTime(2025, 3, 9, 0, 0, 0), Value = 1 },
                        new Measure { Time = new DateTime(2025, 3, 11, 0, 0, 0), Value = 0 }, //2 days
                        new Measure { Time = new DateTime(2025, 3, 14, 0, 0, 0), Value = 0 }                    },
                    Start = new DateTime(2025, 3, 1),
                    End = new DateTime(2025, 3, 11),
                    Expected = new TimeSpan(6,0,0,0)
                }
             }

        };

        public DurationTestData()
        {
            
        }

        public DurationTestData(DurationTest value)
        {
            Value = value;
        }
        public DurationTest Value { get; private set; }
        public void Deserialize(IXunitSerializationInfo info)
        {
            Value = info.GetValue<DurationTest>("Value");
        }

        public IEnumerator<object[]> GetEnumerator()
        {
            return this.data.GetEnumerator();
        }

        public void Serialize(IXunitSerializationInfo info)
        {
            info.AddValue("Value", Value);
        }

        public override string ToString()
        {
            return  "Value = " + Value;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
