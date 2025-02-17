using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class Memory
    {
        private List<Itemmemory> memoryItems = new List<Itemmemory>();

        public void AddToMemory(double value)
        {
            memoryItems.Add(new Itemmemory(value));
        }

        public void ClearMemory()
        {
            memoryItems.Clear();
        }

        public void ShowMemory()
        {
            
            foreach (var item in memoryItems)
            {
                Console.WriteLine(item.Value);
            }
        }
    }

}
