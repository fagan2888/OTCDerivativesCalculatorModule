using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using RiskMonitor;

namespace ExcelInterface
{
    public class ParameterBuilder : BuilderXL
    {
        protected int simulationNum_;
        protected string evaluationTime_;
        protected string itemCode_;

        //private string errStr_;
        
        protected XmlDocument InstXmlDoc_;

        protected ParameterBuilder()
        {

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

        public string setSimulationNum(int simulationNum)
        {
            if (simulationNum < 100)
            {
                return "too small simulationNum , min simulationNum is 10^2";
            }

            if (simulationNum > 10000000)
            {
                return "too large simulationNum , max simulationNum is 10^7";
            }

            this.simulationNum_ = simulationNum;

            return "";
        }

        public string setEvaluationTIme(string evalTime)
        {
            this.evaluationTime_ = evalTime;

            return "";
        }

    }
}
