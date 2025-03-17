using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    /// <summary>
    /// Calculator class that provides basic arithmetic operations and memory functionality
    /// </summary>
    public class Calculator
    {
        private double memory;
        private double lastResult;

        /// <summary>
        /// Gets the last calculated result
        /// </summary>
        public double Result => lastResult;

        /// <summary>
        /// Adds two numbers and stores the result
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>The sum of the two numbers</returns>
        public double Add(double a, double b)
        {
            lastResult = a + b;
            return lastResult;
        }

        /// <summary>
        /// Subtracts the second number from the first and stores the result
        /// </summary>
        /// <param name="a">Number to subtract from</param>
        /// <param name="b">Number to subtract</param>
        /// <returns>The difference of the two numbers</returns>
        public double Subtract(double a, double b)
        {
            lastResult = a - b;
            return lastResult;
        }

        /// <summary>
        /// Stores a value in the calculator's memory
        /// </summary>
        /// <param name="value">Value to store in memory</param>
        public void StoreInMemory(double value)
        {
            memory = value;
        }

        /// <summary>
        /// Returns the value currently stored in memory
        /// </summary>
        /// <returns>The value stored in memory</returns>
        public double RecallMemory()
        {
            return memory;
        }

        /// <summary>
        /// Clears the calculator's memory by setting it to zero
        /// </summary>
        public void ClearMemory()
        {
            memory = 0;
        }

        /// <summary>
        /// Adds the specified value to the value in memory
        /// </summary>
        /// <param name="value">Value to add to memory</param>
        /// <returns>The new value in memory</returns>
        public double AddToMemory(double value)
        {
            memory += value;
            return memory;
        }

        /// <summary>
        /// Subtracts the specified value from the value in memory
        /// </summary>
        /// <param name="value">Value to subtract from memory</param>
        /// <returns>The new value in memory</returns>
        public double SubtractFromMemory(double value)
        {
            memory -= value;
            return memory;
        }
    }
}