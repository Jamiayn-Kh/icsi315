using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    
    public class Calculator
    {
        private double memory;

        
        public double Add(double a, double b)
        {
            return a + b;
        }

       
        /// Хоёр тооны ялгаврыг буцаана
        
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        
        /// Санах ойд тоо хадгална
        
        public void StoreInMemory(double value)
        {
            memory = value;
        }

        
        public double RecallMemory()
        {
            return memory;
        }

        
        /// Санах ойг цэвэрлэнэ
      
        public void ClearMemory()
        {
            memory = 0;
        }
    }
}

