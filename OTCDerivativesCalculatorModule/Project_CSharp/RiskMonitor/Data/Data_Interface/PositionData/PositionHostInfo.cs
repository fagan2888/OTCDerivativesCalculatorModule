using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiskMonitor
{
    public class PositionHostInfo
    {
        private string positionName;

        //private string positionHostName;
        //private string ip;
        //private string userID;

        public PositionHostInfo(string positionName)
        {
            // TODO: Complete member initialization
            this.positionName = positionName;
        }

        private void initialize()
        {
            // 파일을 열어서 읽어옴 예)tnsora파일같은거
        }
    }
}
