using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel_Interface;

namespace ParallelCalculationMangerServer
{
    public class CalculationServerInfoJob : JobAction
    {
        public CalculationServerInfoJob(MessageViewModel e_mvm)
        {
            this.MessageViewModel_ = e_mvm;
        }

        public override void DoJob()
        {
            //this.buildInstrumentInfo();

            // db queue insert

            CALCULATION_SERVER_STATUS_Table_DAO dao = new CALCULATION_SERVER_STATUS_Table_DAO();

            dao.SERVER_NAME_ = this.MessageViewModel_.MessageHeaderViewModel_.Item_code_;
            dao.SERVER_IP_ = "";
            dao.SERVER_PORT_ = "13212";
            dao.SERVER_CORENUM_ = "2";
            dao.SERVER_STATUS_ = "alive";
            dao.SERVER_USE_ = "use";
            dao.SERVER_DESCRIPTION_ = "haha test cal server";
            dao.SERVER_ALIVETIME_ = DateTime.Now.ToString("yyyyMMddffffff");

            string connectionStr = DataBaseConnectManager.ConnectionString_;

            if (dao.SERVER_STATUS_ == "regist")
            {
                dao.insert(DataBaseConnectManager.ConnectionFactory(connectionStr));
            }
            else if (dao.SERVER_STATUS_ == "start")
            {
                dao.update(DataBaseConnectManager.ConnectionFactory(connectionStr));
            }
            else if (dao.SERVER_STATUS_ == "stop")
            {
                dao.update(DataBaseConnectManager.ConnectionFactory(connectionStr));
            }
            else if (dao.SERVER_STATUS_ == "deRegist")
            {
                dao.update(DataBaseConnectManager.ConnectionFactory(connectionStr));
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
