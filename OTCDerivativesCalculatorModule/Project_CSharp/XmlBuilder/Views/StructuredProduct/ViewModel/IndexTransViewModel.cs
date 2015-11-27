using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Xml;
using XmlBuilder.Views.StructuredProduct.View.IndexTransCtrlView;
using XmlBuilder.Views.StructuredProduct.ViewModel;
using XmlBuilder.Views.StructuredProduct.View.IndexTransCtrl;
using XmlBuilder.Views.StructuredProduct.View.IndexTransCtrl.Setting;

namespace XmlBuilder.Views.StructuredProduct.ViewModel
{
    public class IndexTransViewModel : IXmlBuild
    {
        public IndexTransViewModel(FpmlSerializedCSharp.IndexCalculation serial_ic)
        {
            this.serial_ic_ = serial_ic;
            this.buildFromSerialClass();
            
        }

        private void loadIndexTransEditView() 
        {
            IndexTransEditView itev = new IndexTransEditView();
            
        }

        private void setDetailCtrl(string type) 
        {
            if (type == "Return")
            {
            
            }
            else if(type == "Minimum")
            {
            
            }
        }

        private void buildFromSerialClass() 
        {
            if (serial_ic_.Return_ != null || serial_ic_.returnIDRef_ != null)
            {
                this.type_ = "Return";
                this.xmlTypeStr_ = "return";
                this.symbol_ = serial_ic_.Return_.SymbolName_.StringValue();
                ReturnCtrlViewModel rcVM = new ReturnCtrlViewModel(serial_ic_.Return_);
                this.viewModel_ = rcVM;
                indexDetailCtrl_ = new ReturnCtrlView(rcVM);
                

                
            }
            else if (serial_ic_.Minimum_ != null || serial_ic_.minimumIDRef_ != null)
            {
                this.type_ = "Minimum";
                this.xmlTypeStr_ = "minimum";
                this.symbol_ = serial_ic_.Minimum_.SymbolName_.StringValue();
                MinimumViewModel mVM = new MinimumViewModel(serial_ic_.Minimum_);
                this.viewModel_ = mVM;
                //throw new NotImplementedException();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public void buildXml(XmlWriter xmlWriter)
        {

            xmlWriter.WriteStartElement("indexCalculation");

                xmlWriter.WriteStartElement(this.xmlTypeStr_);
                    xmlWriter.WriteStartElement("symbolName");
                        xmlWriter.WriteValue(this.symbol_);
                    xmlWriter.WriteEndElement();

                    this.viewModel_.buildXml(xmlWriter);

                xmlWriter.WriteEndElement();

            xmlWriter.WriteEndElement();

        }

        public FpmlSerializedCSharp.IndexCalculation serial_ic_ { get; set; }

        #region Symbol_
        private string symbol_;
        public string Symbol_
        {
            get { return this.symbol_; }
            set
            {
                if (this.symbol_ != value)
                {
                    this.symbol_ = value;
                    this.NotifyPropertyChanged("Symbol_");
                }
            }
        }
        #endregion

        #region Type_
        private string type_;
        public string Type_
        {
            get { return this.type_; }
            set
            {
                if (this.type_ != value)
                {
                    this.type_ = value;
                    this.setDetailCtrl(value);
                    this.NotifyPropertyChanged("Type_");
                }
            }
        }
        #endregion

        #region RefIndex_
        private string refIndex_;
        public string RefIndex_
        {
            get { return this.refIndex_; }
            set
            {
                if (this.refIndex_ != value)
                {
                    this.refIndex_ = value;
                    this.NotifyPropertyChanged("refIndex_");
                }
            }
        }
        #endregion

        #region ViewModel_
        private IXmlBuild viewModel_;
        public IXmlBuild ViewModel_
        {
            get { return this.viewModel_; }
            set
            {
                if (this.viewModel_ != value)
                {
                    this.viewModel_ = value;
                    this.NotifyPropertyChanged("ViewModel_");
                }
            }
        }
        #endregion

        #region IndexListSetting_
        private IndexListSetting indexListSetting_;
        public IndexListSetting IndexListSetting_
        {
            get { return this.indexListSetting_; }
            set
            {
                if (this.indexListSetting_ != value)
                {
                    this.indexListSetting_ = value;
                    this.NotifyPropertyChanged("IndexListSetting_");
                }
            }
        }
        #endregion

        public UserControl indexDetailCtrl_ {get; set;}

        private string xmlTypeStr_;

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
