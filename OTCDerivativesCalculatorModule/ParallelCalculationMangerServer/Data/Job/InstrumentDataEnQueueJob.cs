using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using Excel_Interface;

namespace ParallelCalculationMangerServer
{
    public class InstrumentDataEnQueueJob : JobAction
    {
        public string InstrumentXml_;

        public string InstrumentType_ { get; set; }
        public string InstrumentCode_ { get; set; }
        public string ReferenceDate_ { get; set; }

        public InstrumentDataEnQueueJob(MessageViewModel e_mvm)
        {
            this.MessageViewModel_ = e_mvm;
            
            //this.xmlDoc_ = new XmlDocument();

        }

        //public void buildInstrumentInfo()
        //{ 
        //    //this.xmlDoc_.LoadXml(this.InstrumentXml_);

        //    this.InstrumentType_ = "testType";
        //    this.InstrumentCode_ = "testCode";
        //    this.ReferenceDate_ = "testRefDate";
        //}

        public override void DoJob()
        {
            //this.buildInstrumentInfo();

            // db queue insert

            CALCULATION_QUEUE_INFO_Table_DAO dao = new CALCULATION_QUEUE_INFO_Table_DAO();

            GridCalculationViewModel gcvm = this.MessageViewModel_.MessageBodyViewModel_ as GridCalculationViewModel;

            dao.INST_CODE_ = gcvm.Inst_code_;
            dao.INST_NAME_ = gcvm.Inst_name_;
            dao.INST_TYPE_ = gcvm.Inst_type_;
            dao.PARA_DATE_ = gcvm.Para_refDate_;

            dao.CALCULATION_STATE_ = "regist";

            string connectionStr = DataBaseConnectManager.ConnectionString_;

            if (dao.CALCULATION_STATE_ == "regist")
            {
                dao.insert(DataBaseConnectManager.ConnectionFactory("sqlCe",connectionStr));
                File.WriteAllText(gcvm.Inst_code_ + ".xml", gcvm.InnerXml_);
            }
            else if (dao.CALCULATION_STATE_ == "deRegist")
            {
                dao.delete(DataBaseConnectManager.ConnectionFactory("sqlCe",connectionStr));
            }
            else
            {

            }


            //string fileName = this.InstrumentCode_;

            //File.WriteAllText(fileName, this.InstrumentXml_);

            //Console.WriteLine("File Saved. , name : {0} : ", fileName);

            //AsynchronousSocketListener.InstrumentQueue_.Enqueue(this);


        }

    }
}
