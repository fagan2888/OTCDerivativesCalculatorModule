using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Excel_Interface;

namespace ParallelCalculationMangerServer
{
    public class CalculationStartJob : JobAction
    {
        private List<string> instrumentXml;

        public CalculationStartJob(MessageViewModel e_mvm)
        {

        }

        private void instrumentListLoad()
        { 
            // 읽어옴
        }

        public override void DoJob()
        {
            //List<InstrumentDataEnQueueJob> jobList = new List<InstrumentDataEnQueueJob>();

            //List<AsynchronousClient> asynchronousClientList = new List<AsynchronousClient>();

            //foreach (var item in jobList)
            //{
            //    AsynchronousClient client = new AsynchronousClient();
            //    asynchronousClientList.Add(client);
            //}

            // check number calc server

            List<Task> taskList = new List<Task>();

            while ( this.calculationComplete() )
            {
                // 쌓인 것중에 하나 가져옴 다 가져왔음?
                InstrumentData instrumentData = this.getInstrumentData();

                // 살아있는 서버 찾음.
                TargetServerInfoViewModel tsivm = this.AliveServer();

                // 연결함.
                AsynchronousClient client = new AsynchronousClient(tsivm);

                //
                Task task = new Task(() => { client.StartClient(instrumentData); });
                task.Start();
                taskList.Add(task);

                if (!this.calculationAvailable())
                {
                    int completeIndex = Task.WaitAny(taskList.ToArray());
                }
                
            }

            //for (int i = 0; i < taskArray.Length; i++)
            //{
            //    Console.WriteLine(asynchronousClientList[i].RecieveData_);
            //    //results[i] = taskArray[i].Result;
            //}
        }

        private bool calculationComplete()
        {
            throw new NotImplementedException();
        }

        private bool calculationAvailable()
        {
            throw new NotImplementedException();
        }

        private InstrumentData getInstrumentData()
        {
            CALCULATION_QUEUE_INFO_Table_DAOManager daoM = new CALCULATION_QUEUE_INFO_Table_DAOManager();

            daoM.select(DataBaseConnectManager.ConnectionFactory(DataBaseConnectManager.ConnectionString_));

            InstrumentData instrumentData = new InstrumentData();

            instrumentData.InstrumentCode_ = daoM.DAOList_[0].INST_CODE_;
            instrumentData.InstrumentType_ = daoM.DAOList_[0].INST_TYPE_;
            //instrumentData.InstrumentXml_= daoM.DAOList_[0].INST_MSGXML;

            return instrumentData;
            
        }

        private TargetServerInfoViewModel AliveServer()
        {
            CALCULATION_SERVER_STATUS_Table_DAOManager daoM = new CALCULATION_SERVER_STATUS_Table_DAOManager();

            daoM.SERVER_STATUS_ = "idle";

            daoM.select(DataBaseConnectManager.ConnectionFactory(DataBaseConnectManager.ConnectionString_));

            TargetServerInfoViewModel tsivm = new TargetServerInfoViewModel();

            //tsivm.buildFromDAO(daoM.DAOList_[0]);

            return tsivm;

        }
    }
}
