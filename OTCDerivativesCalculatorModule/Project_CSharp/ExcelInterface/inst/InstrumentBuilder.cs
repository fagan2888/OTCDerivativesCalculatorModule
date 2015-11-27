using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RiskMonitor;
using System.Xml;

namespace ExcelInterface 
{
    public class InstrumentBuilder : BuilderXL
    {
        
        protected XmlDocument InstXmlDoc_;

        #region InstPositionVM
        protected InstPositionInfoViewModel instPositionVM_;
        public InstPositionInfoViewModel InstPositionVM
        {
            get { return this.instPositionVM_; }
            set
            {
                if (this.instPositionVM_ != value)
                {
                    this.instPositionVM_ = value;
                }
            }
        }
        #endregion

        protected InstrumentBuilder()
        {

        }

        public void setInstPositionInfo(string krCode,
            string instName,
            string instCode,
            string instType,
            double notional)
        {
            this.instPositionVM_ = new InstPositionInfoViewModel();
        }

        public string save(string path, string fileName)
        {
            try
            {
                this.InstXmlDoc_ = new XmlDocument();

                if (this.resultStr_ == null)
                {
                    throw new Exception("result empty!");
                }
                //else if (this.buildXmlFlag_ == false)
                //{
                //    throw new Exception("build process is fail!");
                //}

                this.InstXmlDoc_.LoadXml(this.resultStr_);

                //DirectoryInfo dir = new DirectoryInfo(path);

                this.InstXmlDoc_.Save(path + "\\" + fileName);
            }
            catch (Exception e)
            {
                ErrorManager.setError(e);
                this.errNum_ += 1;
                this.errStr_ += e.Message + "\n";
            }

            return this.errStr_;


        }

        public void setHeader(string productName,
            string krCode)
        { 
            
        }



    }
}
