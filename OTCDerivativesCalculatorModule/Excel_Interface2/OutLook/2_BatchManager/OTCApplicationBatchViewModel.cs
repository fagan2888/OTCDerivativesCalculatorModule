using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Excel_Interface
{
    public class OTCApplicationBatchViewModel : INotifyPropertyChanged
    {
        #region Event

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region ReferenceDate_
        private DateTime referenceDate_;
        public DateTime ReferenceDate_
        {
            get { return this.referenceDate_; }
            set
            {
                if (this.referenceDate_ != value)
                {
                    this.referenceDate_ = value;
                    this.NotifyPropertyChanged("ReferenceDate_");
                }
            }
        }
        #endregion

        #region CalculationStartTime_
        private DateTime calculationStartTime_;
        public DateTime CalculationStartTime_
        {
            get { return this.calculationStartTime_; }
            set
            {
                if (this.calculationStartTime_ != value)
                {
                    this.calculationStartTime_ = value;
                    this.NotifyPropertyChanged("CalculationStartTime_");
                }
            }
        }
        #endregion

        #region CalculationEndTime_
        private DateTime calculationEndTime_;
        public DateTime CalculationEndTime_
        {
            get { return this.calculationEndTime_; }
            set
            {
                if (this.calculationEndTime_ != value)
                {
                    this.calculationEndTime_ = value;
                    this.NotifyPropertyChanged("CalculationEndTime_");
                }
            }
        }
        #endregion

        #region TimeSpan_
        private TimeSpan timeSpan_;
        public TimeSpan TimeSpan_
        {
            get { return this.timeSpan_; }
            set
            {
                if (this.timeSpan_ != value)
                {
                    this.timeSpan_ = value;
                    this.NotifyPropertyChanged("TimeSpan_");
                }
            }
        }
        #endregion

        #region ParallelFlag_
        private bool parallelFlag_;
        public bool ParallelFlag_
        {
            get 
            { 
                return this.parallelFlag_; 
            }
            set
            {
                if (this.parallelFlag_ != value)
                {
                    this.parallelFlag_ = value;
                    this.NotifyPropertyChanged("ParallelFlag_");
                }
            }
        }


        #endregion

        #region AvailableCore_
        private string availableCore_;
        public string AvailableCore_
        {
            get { return this.availableCore_; }
            set
            {
                if (this.availableCore_ != value)
                {
                    this.availableCore_ = value;
                    this.NotifyPropertyChanged("AvailableCore_");
                }
            }
        }
        #endregion

        public ObservableCollection<BatchItemViewModel> WholeBatchItemViewModel_;
        public ObservableCollection<BatchItemViewModel> BindingBatchItemViewModel_;

        public OTCApplicationBatchViewModel()
        {
            this.WholeBatchItemViewModel_ = new ObservableCollection<BatchItemViewModel>();
            this.BindingBatchItemViewModel_ = new ObservableCollection<BatchItemViewModel>();
            this.setAvailableCore();
        }

        public void loadWholeBatchItem(DateTime d)
        {
            this.WholeBatchItemViewModel_.Clear();
            this.BindingBatchItemViewModel_.Clear();

            foreach (Excel_instrumentViewModel item in MasterInformationViewModel.WholeMasterPosition_)
            {
                BatchItemViewModel bivm = new BatchItemViewModel(item);

                bivm.checkParameterBuild(d);

                this.WholeBatchItemViewModel_.Add(bivm);
            }
        }

        //public void parameterBuildBatch(DateTime refDate)
        public void parameterBuildBatch()
        {
            foreach (var item in this.WholeBatchItemViewModel_)
            {
                item.parameterBuild(this.referenceDate_);
            }
        }

        private void setAvailableCore()
        {
            this.AvailableCore_ = Convert.ToString(Environment.ProcessorCount);
        }

        public void calculateBatch()
        {
            this.CalculationStartTime_ = DateTime.Now;

            if (this.parallelFlag_)
            {
                int itemCount = this.WholeBatchItemViewModel_.Count;

                //Task<string>[] taskArray = new Task<string>[itemCount];

                //for (int i = 0; i < itemCount ; i++)
                //{
                //    //taskArray[i] = Task<string>.Factory.StartNew(() => this.WholeBatchItemViewModel_[i].calculate(this.referenceDate_));
                //    if ( i != itemCount )
                //        taskArray[i] = new Task<string>( () => this.WholeBatchItemViewModel_[i].calculate(this.referenceDate_) );
                //}

                Task<string>[] taskArray = { Task<string>.Factory.StartNew(() => this.WholeBatchItemViewModel_[0].calculate(this.referenceDate_)),
                                     Task<string>.Factory.StartNew(() => this.WholeBatchItemViewModel_[1].calculate(this.referenceDate_)),
                                     Task<string>.Factory.StartNew(() => this.WholeBatchItemViewModel_[2].calculate(this.referenceDate_)),
                                     Task<string>.Factory.StartNew(() => this.WholeBatchItemViewModel_[3].calculate(this.referenceDate_)),
                                     Task<string>.Factory.StartNew(() => this.WholeBatchItemViewModel_[4].calculate(this.referenceDate_)) 
                                           };
                                     //{ Task<string>.Factory.StartNew(() => this.WholeBatchItemViewModel_[0].calculate(this.referenceDate_)),
                //                         Task<string>.Factory.StartNew(() => this.WholeBatchItemViewModel_[1].calculate(this.referenceDate_)) };

                //for (int i = 0; i < itemCount; i++)
                //{
                //    taskArray[i].Start();
                //}

                Task<string>.WaitAll(taskArray);

                var results = new string[taskArray.Length];
                
                Double sum = 0;
                
                //Task<string>.WaitAll(taskArray);

                for (int i = 0; i < taskArray.Length; i++)
                {
                    results[i] = taskArray[i].Result;
                    //Console.Write("{0:N1} {1}", results[i],
                    //                  i == taskArray.Length - 1 ? "= " : "+ ");
                    sum += Convert.ToDouble(results[i]);
                }

                //Console.WriteLine("{0:N1}", sum);
            }
            else
            {
                foreach (var item in this.WholeBatchItemViewModel_)
                {
                    item.calculate(this.referenceDate_);
                }
            }
            this.CalculationEndTime_ = DateTime.Now;
            this.TimeSpan_ = this.calculationEndTime_ - this.calculationStartTime_;
        }

        public Control view()
        {
            Control v = new OTCApplicationBatchView();

            v.DataContext = this;

            return v;
        }

    }
}

