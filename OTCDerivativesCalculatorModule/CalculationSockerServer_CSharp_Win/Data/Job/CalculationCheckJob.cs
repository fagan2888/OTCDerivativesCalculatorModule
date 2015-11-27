using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;

namespace CalculationSockerServer_CSharp_Win
{
    public class CalculationCheckJob : IJobAction
    {
        public CalculationCheckJob()
        { 
        
        }

        //public string DoJob()
        //{
            
        //    // get process 떠있는 num

        //    int liveProcessNum = AsynchronousSocketListener.ProcessList_.Count;

        //    // 조건 check

        //    if (liveProcessNum > 7)
        //    {
        //        return "busy";
        //    }
        //    else
        //    {
        //        return "now " + liveProcessNum;
        //    }



        //    // 실행
        //}

        public string DoJob()
        {
            throw new NotImplementedException();
        }
    }
}
