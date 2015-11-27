using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

using System.Xml;

namespace XmlBuilder.Views.StructuredProduct.ViewModel
{
    public class PayoffListViewModel
    {
        public PayoffListViewModel(FpmlSerializedCSharp.PayoffBase serial_pb)
        {
            this.serial_pb_ = serial_pb;
            if (serial_pb != null)
            {
                this.buildFromSerialClass();
            }
        }

        private void buildFromSerialClass()
        {
            payoffVMList_ = new ObservableCollection<PayoffViewModel>();

            foreach (FpmlSerializedCSharp.PayoffCalculation item in serial_pb_.PayoffCalculation_)
            {
                payoffVMList_.Add(new PayoffViewModel(item));
            }

        }

        public void buildXml(XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("payoffBase");

            xmlWriter.WriteStartElement("payoffDate");

            xmlWriter.WriteEndElement();

            if (payoffVMList_ != null)
            {
                foreach (PayoffViewModel item in payoffVMList_)
                {
                    item.buildXml(xmlWriter);
                }
            }

            xmlWriter.WriteEndElement();
        }

        public FpmlSerializedCSharp.PayoffBase serial_pb_ { get; set; }

        #region PayoffVMList_
        private ObservableCollection<PayoffViewModel> payoffVMList_;
        public ObservableCollection<PayoffViewModel> PayoffVMList_
        {
            get { return this.payoffVMList_; }
            set
            {
                if (this.payoffVMList_ != value)
                {
                    this.payoffVMList_ = value;
                    this.NotifyPropertyChanged("PayoffVMList_");
                }
            }
        }
        #endregion

        // ---------------------- Event ---------------------------
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


    }

}
