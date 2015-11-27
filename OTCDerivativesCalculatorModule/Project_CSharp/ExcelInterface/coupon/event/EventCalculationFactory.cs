using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RiskMonitor;

namespace ExcelInterface
{
	public class EventCalculationFactory
	{
        public EventCalculationFactory()
        { 
        
        }

        public EventCalculationViewModel eventCalculation(string type,
                                                          string[] array)
        {
            EventCalculationViewModel ecvm;

            if (type.ToUpper() == "LOWERBARRIER")
            {
                ecvm = new LowerBarrierEventCalViewModel();
            }
            else 
            {
                throw new Exception();
            }

            return ecvm;
        }

	}
}
