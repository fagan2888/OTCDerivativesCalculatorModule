using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Excel_Interface
{
    public class CalculationBatchController
    {
        public enum CalcType
        { 
            Local,
            Server
        };

        #region CalculationDate_
        private DateTime calculationDate_;
        public DateTime CalculationDate_
        {
            get { return this.calculationDate_; }
            set
            {
                if (this.calculationDate_ != value)
                {
                    
                    this.calculationDate_ = value;

                    this.loadParameter();
                }
            }
        }


        #endregion

        private DateTime calculationStartTime_;
        private DateTime calculationEndTime_;

        private List<TargetServerInfoViewModel> serverInfoList_;
        private TargetServerInfoViewModel localServerInfo_;
        
        private bool useLocalServerTF_ = true;

        public List<BatchItemViewModel> BatchItemViewModelQueueList_;

        public void useLocalServer(bool tf)
        {
            useLocalServerTF_ = tf;

            if (useLocalServerTF_)
            {
                this.startLocalCalcServer();
            }
        }

        private void startLocalCalcServer()
        {
            string kk = "";

            if ( this.existProcess() )
            {
                Process p = new Process();

                ProcessStartInfo psi = new ProcessStartInfo("localCalcServer.exe");

                p.StartInfo = psi;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.Start();

                StreamReader sOut = p.StandardOutput;

                kk = sOut.ReadToEnd();
            }

        }

        private bool existProcess()
        {
            // process list를 가져욤.
            throw new NotImplementedException();
        }

        // constructor
        public CalculationBatchController()
        {
            this.BatchItemViewModelQueueList_ = new List<BatchItemViewModel>();
            this.serverInfoList_ = new List<TargetServerInfoViewModel>();

            this.localServerInfo_ = new TargetServerInfoViewModel();

            IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            int port = 12000;
            IPEndPoint remoteEP = new IPEndPoint(ipAddress, port);

            this.localServerInfo_.IPHostInfo_ = ipHostInfo;
            this.localServerInfo_.IPAddress_ = ipAddress;
            this.localServerInfo_.IPEndPoint_ = remoteEP;
            

        }

        public string status()
        { 
            // db 접속

            return "busy";

        }

        public void calculateStart()
        {
            this.calculationStartTime_ = DateTime.Now;
            
            //List<AsynchronousClient> clients = new List<AsynchronousClient>();
            //List<string> messageXmls = new List<string>();

            List<Task> taskList = new List<Task>();

            // 여기서는 task 를 띄움( multi-thread 로 가도됨 )
            if (useLocalServerTF_)
            {

                for (int i = 0; i < this.BatchItemViewModelQueueList_.Count; i++)
                {
                    AsynchronousClient client = new AsynchronousClient();

                    MessageViewModel mvm = new MessageViewModel();

                    mvm.MessageHeaderViewModel_.CreationTimestamp_ = DateTime.Now.ToString();
                    mvm.MessageHeaderViewModel_.Item_code_ = this.BatchItemViewModelQueueList_[i].ItemCode_;
                    mvm.MessageHeaderViewModel_.MessageId_ = "testID";
                    mvm.MessageHeaderViewModel_.MessageType_ = "gridCalculation";
                    mvm.MessageHeaderViewModel_.SendTo_ = "localServer";
                    mvm.MessageHeaderViewModel_.SentBy_ = "localServer";
                    mvm.MessageHeaderViewModel_.SequenceNumber_ = "testSerialNum";

                    GridCalculationViewModel gcvm = new GridCalculationViewModel();

                    gcvm.mergeSetXml(this.BatchItemViewModelQueueList_[i].Excel_instrumentViewModel_,this.calculationDate_);

                    mvm.MessageBodyViewModel_ = gcvm;

                    //client.StartClient(mvm, localServerInfo_);

                    //messageXmls.Add(mvm.getMessegeStr());
                    //clients.Add(client);

                    Task taskA = new Task(() => client.StartClient(mvm.getMessegeStr(), localServerInfo_));

                    taskList.Add(taskA);

                    taskA.Start();

                }



                Task.WaitAll(taskList.ToArray());

            }
        }

        public int availableCore()
        {
            return Environment.ProcessorCount;
        }

        public void enqueue_intrument(string itemCode)
        { 
            // itemCode 를 master에서 찾아서 만들어서 넣음

            try
            {
                Excel_instrumentViewModel e_ivm = MasterInformationViewModel.loadInstrumentVM(itemCode);

                // inst xml
                e_ivm.loadInterfaceVMFromXml(XMLFileLoader.LoadInstrument(itemCode));

                // para xml
                e_ivm.loadParameterFromXml(XMLFileLoader.LoadParameter(itemCode, this.calculationDate_));

                BatchItemViewModel bvm = new BatchItemViewModel(e_ivm);

                this.BatchItemViewModelQueueList_.Add(bvm);
            }
            catch (Exception e)
            {
                throw e;
            }

            // 
        }

        public void enqueue_intrument(Excel_instrumentViewModel e_instVM)
        {
            BatchItemViewModel bvm = new BatchItemViewModel(e_instVM);

            this.BatchItemViewModelQueueList_.Add(bvm);
        }

        private void loadParameter()
        {
            foreach (var item in this.BatchItemViewModelQueueList_)
	        {
                item.Excel_instrumentViewModel_.loadParameterFromXml(
                    XMLFileLoader.LoadParameter(item.ItemCode_, this.calculationDate_));
	        }
            
        }


    }
}
