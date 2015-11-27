using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class StandardStreamViewModel : SwapStreamViewModel
    {
    
        public StandardStreamViewModel() { }

        #region ScheduleInfoViewModel_
        private ScheduleInfoViewModel scheduleInfoViewModel_;
        public ScheduleInfoViewModel ScheduleInfoViewModel_
        {
            get { return this.scheduleInfoViewModel_; }
            set
            {
                if (this.scheduleInfoViewModel_ != value)
                {
                    this.scheduleInfoViewModel_ = value;
                    this.NotifyPropertyChanged("ScheduleInfoViewModel_");
                }
            }
        }
        #endregion

        #region IRCalculationViewModel_
        private ObservableCollection<IRCalculationViewModel> irCalculationViewModel_;
        public ObservableCollection<IRCalculationViewModel> IRCalculationViewModel_
        {
            get { return this.irCalculationViewModel_; }
            set
            {
                if (this.irCalculationViewModel_ != value)
                {
                    this.irCalculationViewModel_ = value;
                    this.NotifyPropertyChanged("IRCalculationViewModel_");
                }
            }
        }
        #endregion
        
        
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.SwapStream serial_SwapStream = serial_Class as FpmlSerializedCSharp.SwapStream;
            FpmlSerializedCSharp.StandardStream serial_StandardStream = serial_SwapStream.StandardStream_;

            FpmlSerializedCSharp.ScheduleInfo serial_scheduleInfo = serial_StandardStream.ScheduleInfo_;
            this.scheduleInfoViewModel_ = new ScheduleInfoViewModel();
            this.scheduleInfoViewModel_.setFromSerial(serial_scheduleInfo);

            List<FpmlSerializedCSharp.IRCalculation> serial_irCalculation = serial_StandardStream.IrCalculation_;
            this.irCalculationViewModel_ = new ObservableCollection<IRCalculationViewModel>();
            foreach (var item in serial_irCalculation)
            {
                IRCalculationViewModel viewModel = new IRCalculationViewModel();
                viewModel.setFromSerial(item);
                this.irCalculationViewModel_.Add(viewModel);
            }
            
            this.view_ = new StandardStreamView();
            this.view_.DataContext = this;
        }
    
    }
    
}

