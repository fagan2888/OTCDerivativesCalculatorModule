using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculationSockerServer_CSharp_Win
{
    public class MessageParser
    {
        private string messageText_;
        private IJobAction jobAction_;

        #region Result_
        private string result_;
        public string Result_
        {
            get { return this.result_; }
            set
            {
                if (this.result_ != value)
                {
                    this.result_ = value;
                }
            }
        }
        #endregion

        private CalculationServerProtocol calculationServerProtocol_;

        public MessageParser(string messageText)
        {
            this.messageText_ = messageText;
        }

        public void parsing()
        {
            // 분류함.
            //this.jobAction_ = new InstrumentDataEnQueueJob(this.messageText_);
            //this.jobAction_ = new CalculationStartJob();

            this.calculationServerProtocol_ = new CalculationServerProtocol(this.messageText_);

            string typeStr = this.calculationServerProtocol_.Type_;

            if (typeStr.ToString() == "CALCULATIONCHECKJOB")
            {
                this.jobAction_ = new CalculationCheckJob();
            }
            else
            {
                this.jobAction_ = new CalculationStartJob();
            }


        }

        public void DoJob()
        {
            this.jobAction_.DoJob();
            // db에 넣음.
            this.result_ = "complete Job";
        }


    }
}
