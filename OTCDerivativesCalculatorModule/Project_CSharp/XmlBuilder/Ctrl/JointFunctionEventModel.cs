using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Xml;

namespace XmlBuilder.Ctrl
{
    public class JointFunctionEventModel
    {
        private FpmlSerializedCSharp.JointFunctionEvent jointFunctionEvent_;

        public JointFunctionEventModel(FpmlSerializedCSharp.JointFunctionEvent jointFunctionEvent)
        {
            // TODO: Complete member initialization
            this.jointFunctionEvent_ = jointFunctionEvent;
        }

        private void buildFromSerialClass()
        {
            this.jointType_ = jointFunctionEvent_.JointType_.StringValue();

            functionNameList_ = new ObservableCollection<string>();
            tfList_ = new ObservableCollection<bool>();

            foreach (FpmlSerializedCSharp.Function item in jointFunctionEvent_.Functions_.Function_)
            {
                functionNameList_.Add(item.Name_.StringValue());
                tfList_.Add(item.Truefalse_.BooleanValue());
            }
        }

        #region JointType_
        private string jointType_;
        public string JointType_
        {
            get { return this.jointType_; }
            set
            {
                if (this.jointType_ != value)
                {
                    this.jointType_ = value;
                    this.NotifyPropertyChanged("JointType_");
                }
            }
        }
        #endregion

        #region FunctionNameList_
        private ObservableCollection<string> functionNameList_;
        public ObservableCollection<string> FunctionNameList_
        {
            get { return this.functionNameList_; }
            set
            {
                if (this.functionNameList_ != value)
                {
                    this.functionNameList_ = value;
                    this.NotifyPropertyChanged("FunctionNameList_");
                }
            }
        }
        #endregion

        #region TFList_
        private ObservableCollection<bool> tfList_;
        public ObservableCollection<bool> TFList_
        {
            get { return this.tfList_; }
            set
            {
                if (this.tfList_ != value)
                {
                    this.tfList_ = value;
                    this.NotifyPropertyChanged("TFList_");
                }
            }
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public StringBuilder buildXml()
        {
            StringBuilder sb = new StringBuilder("");
            //XmlWriterSettings setting = new XmlWriterSettings();
            //setting.Indent = true;

            //XmlWriter xmlWriter = XmlWriter.Create(sb, setting);

            //xmlWriter.WriteStartElement("jointFunctionEvent");
            
            //    xmlWriter.WriteStartElement("jointType");
            //        xmlWriter.WriteString(this.jointType_);
            //    xmlWriter.WriteEndElement();

            //    xmlWriter.WriteStartElement("functions");

            //    for (int i = 0; i < functionNameList_.Count ; i++)
            //    {
            //        xmlWriter.WriteStartElement("function");
            //            xmlWriter.WriteStartElement("refName");
            //                xmlWriter.WriteString(functionNameList_[i]);    
            //            xmlWriter.WriteEndElement();

            //            xmlWriter.WriteStartElement("truefalse");
            //                xmlWriter.WriteValue(tfList_[i]);
            //            xmlWriter.WriteEndElement();
            //        xmlWriter.WriteEndElement();
            //    }
                
            //    xmlWriter.WriteEndElement();    
            
            //xmlWriter.WriteEndElement();

            //xmlWriter.Close();

            return sb;
        }
    }
}
