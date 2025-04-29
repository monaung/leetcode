using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code.Interview
{

    public class GetAsync
    {
        static int data = 0;

        public   async void StartHere()
        {
            List<int> tasks = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                tasks.Add(i);
                GetDataAsync();
            }
            await Task.WhenAll();

            Console.WriteLine("This is data " + data);
        }

        public async void GetDataAsync()
        {
            data += 1;
        }
    }
}
