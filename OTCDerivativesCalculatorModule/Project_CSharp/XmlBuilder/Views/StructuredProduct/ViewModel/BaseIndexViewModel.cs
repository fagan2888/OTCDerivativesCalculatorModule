using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Xml;

namespace XmlBuilder.Views.StructuredProduct.ViewModel
{
    public class BaseIndexViewModel : IXmlBuild
    {
        private FpmlSerializedCSharp.UnderlyingIndex serial_under_;

        public BaseIndexViewModel(FpmlSerializedCSharp.UnderlyingIndex serial_under)
        {
            this.serial_under_ = serial_under;
            this.buildFromSerialClass();
        }

        public BaseIndexViewModel() 
        {
        
        }

        public BaseIndexViewModel(string sym,
                                  string code,
                                  string name,
                                  string type,
                                  string description) 
        {
            this.sym_ = sym;
            this.code_ = code;
            this.name_ = name;
            this.type_ = type;
            this.description_ = description;
        }

        private void buildFromSerialClass() 
        {
            if (serial_under_.ID_ == null)
            {
                throw new Exception();
            }
            else 
            {
                this.sym_ = serial_under_.ID_;

                if(serial_under_.StockIndex_ != null)
                {
                    this.code_ = serial_under_.StockIndex_.Code_.StringValue();
                    this.name_ = serial_under_.StockIndex_.Name_.StringValue();
                    viewModel_ = new StockIndexViewModel(serial_under_.StockIndex_);
                }
                else if (serial_under_.InterestrateIndex_ != null)
                {
                    this.code_ = serial_under_.InterestrateIndex_.Code_.StringValue();
                    this.name_ = serial_under_.InterestrateIndex_.Name_.StringValue();
                    viewModel_ = new IRIndexViewModel(serial_under_.InterestrateIndex_);
                }
                else if (serial_under_.CommodityIndex_ != null)
                {
                    this.code_ = serial_under_.CommodityIndex_.Code_.StringValue();
                    this.name_ = serial_under_.CommodityIndex_.Name_.StringValue();
                    viewModel_ = new CommodityIndexViewModel(serial_under_.CommodityIndex_);

                }
                else 
                {
                    throw new Exception();
                }

            }
        }

        public void buildXml(XmlWriter xmlWriter)
        {
            //return this.viewModel_.buildXml();
        }

        #region Sym_
        private string sym_;
        public string Sym_
        {
            get { return this.sym_; }
            set
            {
                if (this.sym_ != value)
                {
                    this.sym_ = value;
                    this.NotifyPropertyChanged("Sym_");
                }
            }
        }
        #endregion

        #region Code_
        private string code_;
        public string Code_
        {
            get { return this.code_; }
            set
            {
                if (this.code_ != value)
                {
                    this.code_ = value;
                    this.NotifyPropertyChanged("Code_");
                }
            }
        }
        #endregion

        #region Name_
        private string name_;
        public string Name_
        {
            get { return this.name_; }
            set
            {
                if (this.name_ != value)
                {
                    this.name_ = value;
                    this.NotifyPropertyChanged("Name_");
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
                    this.NotifyPropertyChanged("Type_");
                }
            }
        }
        #endregion

        #region Description_
        private string description_;
        public string Description_
        {
            get { return this.description_; }
            set
            {
                if (this.description_ != value)
                {
                    this.description_ = value;
                    this.NotifyPropertyChanged("Description_");
                }
            }
        }
        #endregion

        private IXmlBuild viewModel_;

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
