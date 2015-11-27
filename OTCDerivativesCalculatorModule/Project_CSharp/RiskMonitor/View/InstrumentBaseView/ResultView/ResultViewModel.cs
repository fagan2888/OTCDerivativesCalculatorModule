using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace RiskMonitor
{
    public abstract class ResultViewModel : IXmlData , INotifyPropertyChanged
    {

        public ResultViewModel()
        {
            // TODO: Complete member initialization
        }

        #region ReferencDateResult_
        private ReferenceDateResultViewModel referenceDateResult_;
        public ReferenceDateResultViewModel ReferencDateResult_
        {
            get { return this.referenceDateResult_; }
            set
            {
                if (this.referenceDateResult_ != value)
                {
                    this.referenceDateResult_ = value;
                    this.NotifyPropertyChanged("ReferencDateResult_");
                }
            }
        }
        #endregion

        #region HistoryResultViewModel_
        private HistoryResultViewModel historyResultViewModel_;
        public HistoryResultViewModel HistoryResultViewModel_
        {
            get { return this.historyResultViewModel_; }
            set
            {
                if (this.historyResultViewModel_ != value)
                {
                    this.historyResultViewModel_ = value;
                    this.NotifyPropertyChanged("HistoryResultViewModel_");
                }
            }
        }
        #endregion

        #region ItemCode_
        private string itemCode_;
        public string ItemCode_
        {
            get { return this.itemCode_; }
            set
            {
                if (this.itemCode_ != value)
                {
                    this.itemCode_ = value;
                    this.NotifyPropertyChanged("ItemCode_");
                }
            }
        }
        #endregion

        #region UnitPrice_
        private double unitPrice_;
        public double UnitPrice_
        {
            get { return this.unitPrice_; }
            set
            {
                if (this.unitPrice_ != value)
                {
                    this.unitPrice_ = value;
                    this.NotifyPropertyChanged("UnitPrice_");
                }
            }
        }
        #endregion

        #region Price_
        private long price_;
        public long Price_
        {
            get { return this.price_; }
            set
            {
                if (this.price_ != value)
                {
                    this.price_ = value;
                    this.NotifyPropertyChanged("Price_");
                }
            }
        }
        #endregion

        public void loadHistory() 
        {
            this.historyResultViewModel_.loadHistory();
        }

        public void loadHistory(DateTime? InitialDate, DateTime? LastDate)
        {
            throw new NotImplementedException();
        }

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

        public void loadResult(DateTime? selectedDate)
        {
            throw new NotImplementedException();
        }

        public void setResult(ResultModel resultModel)
        {
            this.itemCode_ = resultModel.ItemCode_;
            this.price_ = resultModel.Price_;
            this.unitPrice_ = resultModel.UnitPrice_;
            this.referenceDateResult_ = new ReferenceDateResultViewModel(resultModel);
            this.historyResultViewModel_ = new HistoryResultViewModel();
        }

        public Control view()
        {
            System.Windows.Controls.Control v = new ResultView();

            v.DataContext = this;

            return v;

        }


        public void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }

        public void setFromXml(System.Xml.XmlNode InstNode)
        {
            //DateTime referenceDate = CustomFunction.StrToDate(resultparaXml.SelectSingleNode("pricing/evaluationTime").InnerText);
            //string itemCode = resultparaXml.SelectSingleNode("pricing/itemCode").InnerText;

            //this.Result_.ReferenceDate_ = referenceDate;
            //this.Result_.ItemCode_ = itemCode;

            //XmlNode pricingNode = resultparaXml.SelectSingleNode("pricing");
            //XmlNode resultparaNode = pricingNode.SelectSingleNode("pricingResult");

            OutputLogViewModel.addResult(new ErrorOutput("", ItemCode_, "Result Calulation Not yet"));

        }

        public void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            throw new NotImplementedException();
        }
    }
}
