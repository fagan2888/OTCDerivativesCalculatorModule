using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace VolatiltityManager
{
    

    public class VolCalculater
    {
        public List<double> result(string underCode, DateTime startDate, DateTime endDate)
        {
            List<double> data = new List<double>();

            for (int i = 0; i < 50 ; i++)
            {
                data.Add(0.3 + i * 0.01);    
            }

            return data;

        }

        internal void result(string underCode, DateTime startDate, DateTime endDate, List<string> selectedCalculationStr_)
        {
            throw new NotImplementedException();
        }
    }
}
