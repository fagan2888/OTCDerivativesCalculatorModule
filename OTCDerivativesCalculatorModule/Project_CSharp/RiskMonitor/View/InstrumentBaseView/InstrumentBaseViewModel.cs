using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Xml;
using System.IO;

namespace RiskMonitor
{
    public abstract class InstrumentBaseViewModel 
    {
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

        #region View_
        protected Control view_;
        public Control View_
        {
            get { return this.view_; }
            set
            {
                if (this.view_ != value)
                {
                    this.view_ = value;
                    this.NotifyPropertyChanged("View_");
                }
            }
        }
        #endregion
        
        public XmlDocument InstXml_ { get; set; }
        public XmlDocument ParaResultXml_ { get; set; }

        public InstUriInfo InstUri_ { get; set; }
        public ResultUriInfo ResultUri_ { get; set; }

        #region Constructor

        public InstrumentBaseViewModel(InstUriInfo instUri) 
        {
            this.InstUri_ = instUri;
            //this.ResultUri_ = resultUri;

            this.itemCode_ = this.InstUri_.itemCode_;
            this.itemType_ = this.InstUri_.itemType_;

            InstXml_ = new XmlDocument();
            ParaResultXml_ = new XmlDocument();

        }

        #endregion

        #region InstPositionInfoViewModel_
        protected InstPositionInfoViewModel instPositionInfoViewModel_;
        public InstPositionInfoViewModel InstPositionInfoViewModel_
        {
            get { return this.instPositionInfoViewModel_; }
            set
            {
                if (this.instPositionInfoViewModel_ != value)
                {
                    this.instPositionInfoViewModel_ = value;
                    this.NotifyPropertyChanged("InstPositionInfoViewModel_");
                }
            }
        }
        #endregion

        #region ItemCode_
        protected string itemCode_;
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

        #region ItemType_
        private string itemType_;
        public string ItemType_
        {
            get { return this.itemType_; }
            set
            {
                if (this.itemType_ != value)
                {
                    this.itemType_ = value;
                    this.NotifyPropertyChanged("ItemType_");
                }
            }
        }
        #endregion

        #region ResultFileInfo_
        private FileInfo resultFileInfo_;
        public FileInfo ResultFileInfo_
        {
            get { return this.resultFileInfo_; }
            set
            {
                if (this.resultFileInfo_ != value)
                {
                    this.resultFileInfo_ = value;
                    this.NotifyPropertyChanged("ResultFileInfo_");
                }
            }
        }
        #endregion

        public void loadAll()
        {
            this.loadInstrument();
            this.loadParaResult();
        }

        public void loadSample()
        {
            InstXml_.Load(this.InstUri_.Uri_.LocalPath);
            this.loadInstrumentFromXml(this.InstXml_);
            this.loadPositionFromXml(this.InstXml_);

            ParaResultXml_.Load(this.ResultUri_.Uri_.LocalPath);
            this.loadParaResultFromXml(this.ParaResultXml_);
        }

        public void buildInstrument()
        {
            try
            {
                this.InstXml_ = new XmlDocument();

                StringBuilder sb = new StringBuilder();
                XmlWriterSettings setting = new XmlWriterSettings();

                setting.Indent = true;
                //setting.Encoding = Encoding.UTF8;

                XmlWriter xmlWriter = XmlWriter.Create(sb, setting);

                xmlWriter.WriteProcessingInstruction("xml", "version='1.0' encoding='UTF-8'");

                this.buildInstrumentXml(xmlWriter);

                xmlWriter.Close();

                this.InstXml_.LoadXml(sb.ToString());

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void buildParaResult()
        {
            try
            {
                this.ParaResultXml_ = new XmlDocument();

                StringBuilder sb = new StringBuilder();
                XmlWriterSettings setting = new XmlWriterSettings();

                setting.Indent = true;
                //setting.Encoding = Encoding.UTF8;

                XmlWriter xmlWriter = XmlWriter.Create(sb, setting);

                xmlWriter.WriteProcessingInstruction("xml", "version='1.0' encoding='UTF-8'");

                this.buildParaResultXml(xmlWriter);

                xmlWriter.Close();

                this.ParaResultXml_.LoadXml(sb.ToString());
                
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void buildPara()
        {
            try
            {
                this.ParaResultXml_ = new XmlDocument();

                StringBuilder sb = new StringBuilder();
                XmlWriterSettings setting = new XmlWriterSettings();

                setting.Indent = true;
                //setting.Encoding = Encoding.UTF8;

                XmlWriter xmlWriter = XmlWriter.Create(sb, setting);

                xmlWriter.WriteProcessingInstruction("xml", "version='1.0' encoding='UTF-8'");

                this.buildParaXml(xmlWriter);

                xmlWriter.Close();

                this.ParaResultXml_.LoadXml(sb.ToString());

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void saveInstrument()
        {
            this.InstXml_.Save(this.instrumentPath());
        }
        public void saveParaResult()
        {
            this.ParaResultXml_.Save(this.paraResultPath(this.ReferenceDate_));
        }

        //load instrument
        public void loadInstrument()
        {
            //XmlDocument instXml = new XmlDocument();

            InstXml_.Load(this.instrumentPath());
            this.loadInstrumentFromXml(this.InstXml_);
            this.loadPositionFromXml(this.InstXml_);

            //try
            //{
            //    InstXml_.Load(this.instrumentPath());
            //    this.loadInstrumentFromXml(this.InstXml_);
            //}
            //catch (Exception e)
            //{
            //    throw;
            //}
        }

        //load parameter & result
        public void loadParaResult()
        {
            XmlDocument instXml = new XmlDocument();

            try
            {
                ParaResultXml_.Load(this.paraResultPath(this.ReferenceDate_));
                this.loadParaResultFromXml(this.ParaResultXml_);
            }
            catch (Exception e)
            {
                string errStr = "Source : " + e.Source + "\n" + 
                                "Message : " +  e.Message + "\n"  + 
                                "Location : " + e.StackTrace;

                //MessageBoxResult result = MessageBox.Show( , "Exception"); 

                OutputLogViewModel.addResult(errStr);
                throw;
            }
        }

        public string instrumentPath()
        {
            //조건부 리턴.
            this.InstUri_ = PositionSingletonManger.CreateInstUriInfo(this.itemCode_, this.itemType_);

            return this.InstUri_.Uri_.LocalPath;
        }

        public string paraResultPath(DateTime dateTime)
        {
            //string paraResultFileName = System.IO.Path.GetFileName(this.ResultUri_.LocalPath);

            //this.ResultUri_.setReferenceDate(ReferenceDate_);

            this.ResultUri_ = ResultSingletonMaster.CreateResultUriInfo(this.itemCode_, this.itemType_, dateTime);

            return this.ResultUri_.Uri_.LocalPath;
        }

        public void calculate()
        {
            this.buildPara();

            XmlNode pricingNode = ParaResultXml_.SelectSingleNode("pricing");

            if (pricingNode.FirstChild["pricingResult"] != null)
            {
                pricingNode.RemoveChild(pricingNode.FirstChild["pricingResult"]);
            }

            string result = this.calculateImpl();

            XmlDocumentFragment frag = ParaResultXml_.CreateDocumentFragment();
            frag.InnerXml = result;
            ParaResultXml_.DocumentElement.AppendChild(frag);
        }

        //calculate
        protected abstract string calculateImpl();

        protected abstract void buildInstrumentXml(XmlWriter xmlWriter);
        protected abstract void buildParaResultXml(XmlWriter xmlWriter);

        protected abstract void buildParaXml(XmlWriter xmlWriter);

        protected abstract void loadInstrumentFromXml(XmlNode node);
        protected abstract void loadParaResultFromXml(XmlNode node);

        protected void loadPositionFromXml(XmlNode node)
        {
            FpmlSerializedCSharp.Root serial_root = new FpmlSerializedCSharp.Root(node);
            FpmlSerializedCSharp.InstPositionInfo serial_instPositionInfo = serial_root.Instrument_.InstPositionInfo_;

            InstPositionInfoViewModel vm = new InstPositionInfoViewModel();
            vm.setFromSerial(serial_instPositionInfo);

            this.InstPositionInfoViewModel_ = vm;

            this.itemCode_ = vm.InstCode_;
            this.itemType_ = vm.InstType_;

        }

        public abstract void loadSampleParaResult();
        
        //public static InstrumentBaseViewModel CreateInstBaseVM(string itemCode, string itemType, MyURI instUri, MyURI resultURI) 
        public static InstrumentBaseViewModel CreateInstBaseVM(InstUriInfo instUri) 
        {
            if ( !instUri.isExist() )
            {
                return new NoExistInstrumentBaseViewModel(instUri);
            }
            else 
            {
                if (instUri.itemType_ == "Group")
                {
                    return new GroupBaseViewModel(instUri);
                }
                else 
                {
                    return new StandardInstBaseViewModel(instUri);
                }
                //else if (itemType == "")
                //{
                //    //return new Cre(itemCode, itemType, fileInfo);
                //}
                //else 
                //{
                //    throw new Exception();
                //}
            }
            
        }

        #region Event

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

    }
}
