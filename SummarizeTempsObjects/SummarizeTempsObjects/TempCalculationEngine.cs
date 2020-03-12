using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SummarizeTempsObjects
{
    public class TempCalculationEngine
    {
        List<int> _temperatures;
        public TempCalculationEngine(List<int> temperatures)
        {
            _temperatures = temperatures;
        }

        public int AverageTemperature()
        {
            // add logic to calculate the average
            int sumOfTemps = 0;
            foreach(int temp in _temperatures)
            {
                sumOfTemps += temp;
            }
            int averageTemps = sumOfTemps / _temperatures.Count;

            return averageTemps; // <-- Replace this with the actual average
        }

        public int TempsAboveThreshold(int threshold)
        {
            int tempcount = 0;
            foreach (int temp in _temperatures)
            {
                if (temp>threshold)
                {
                    tempcount = tempcount + 1;
                }

            }
            // add logic to calculate temps above the threshold
            return tempcount; // <-- Replace this with the number
        }

        public int TempsBelowThreshold(int threshold)
        {
            int tempcount = 0;
            foreach (int temp in _temperatures)
            {
                if (temp < threshold)
                {
                    tempcount = (tempcount + 1);
                }

            }
            // add logic to calculate and return temps below the threshold
            return tempcount; // <-- Replace this with the number
        }

        public int TempsAtThreshold(int threshold)
        {
            int tempcount = 0;
            foreach (int temp in _temperatures)
            {
                if ( temp == threshold)
                {
                    tempcount= (tempcount + 1);
                }
            }
            // add logic to calculate and return temps at the threshold
            return tempcount; // <-- Replace this with the number
        }

        public int NumberOfTemperatures()
        {
            int tempcount = 0;
                foreach (int temp in _temperatures)
            {
                tempcount = (tempcount + 1);
            }
            // add logic to return the number of temparature readings
            return tempcount; // <-- Replace this with the number
        }
    }
}
