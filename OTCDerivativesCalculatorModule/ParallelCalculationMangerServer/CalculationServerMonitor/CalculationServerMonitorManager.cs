using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Excel_Interface;

namespace ParallelCalculationMangerServer
{
    public class CalculationServerMonitorManager
    {
        public List<TargetServerInfoViewModel> TargetServerList_;

        public CalculationServerMonitorManager()
        { 
            
        }

        private void loadServer()
        { 
        
        }

        public void stringMonitioring()
        { 
            while ( true )
            {

                foreach (var item in TargetServerList_)
                {
                    
                }
                

                Thread.Sleep(5000);
            }
        }
    }
}
