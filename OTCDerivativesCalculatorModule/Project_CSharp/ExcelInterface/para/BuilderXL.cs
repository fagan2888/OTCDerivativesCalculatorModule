using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using RiskMonitor;

namespace ExcelInterface
{
    public class BuilderXL
    {
        protected string errStr_ = "";
        protected int errNum_ = 0;
        protected bool buildXmlFlag_ = false;
        protected string resultStr_;

        public string getResultStr()
        {
            return this.resultStr_;
        }

        public string getErrStr()
        {
            return ErrorManager.errStr();
        }

        public int errNum()
        {
            return errNum_;
        }

    }
}
