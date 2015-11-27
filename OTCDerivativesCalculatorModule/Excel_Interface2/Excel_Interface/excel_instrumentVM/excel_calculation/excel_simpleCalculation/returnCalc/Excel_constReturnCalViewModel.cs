using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_constReturnCalViewModel : Excel_returnCalcInfoViewModel
    {
        public Excel_constReturnCalViewModel() 
        {
            this.Excel_type_ = "excel_constReturnCal";
        }
    
        #region ConstReturn_
        private string constReturn_;
        public string ConstReturn_
        {
            get { return this.constReturn_; }
            set
            {
                if (this.constReturn_ != value)
                {
                    this.constReturn_ = value;
                    this.NotifyPropertyChanged("ConstReturn_");
                }
            }
        }
        #endregion

        public override void attributeSetXml(XmlWriter xmlWriter)
        {
            if (this.attributeValue_ != "")
            {
                xmlWriter.WriteAttributeString("usingType", this.attributeValue_);
            }
        }

        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_returnCalcInfo");

                this.attributeSetXml(xmlWriter);

                xmlWriter.WriteElementString("excel_type" , "excel_constReturnCal");
                xmlWriter.WriteStartElement("excel_constReturnCal");
                    xmlWriter.WriteElementString("constReturn" , this.constReturn_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_returnCalcInfo serial_Excel_returnCalcInfo = serial_Class as FpmlSerializedCSharp.Excel_returnCalcInfo;
            FpmlSerializedCSharp.Excel_constReturnCal serial_Excel_constReturnCal = serial_Excel_returnCalcInfo.Excel_constReturnCal_;

            this.constReturn_ = serial_Excel_constReturnCal.ConstReturn_.ValueStr;

        }

        //public override ReturnCalculationInfoViewModel returnCalcInfoVM()
        //{
        //    ReturnCalculationInfoViewModel rcivm = new ReturnCalculationInfoViewModel();

        //    ConstReturnCalViewModel crcvm = new ConstReturnCalViewModel();

        //    rcivm.ReturnCalculationViewModel_.Add(crcvm);

        //    crcvm.ConstReturn_ = this.constReturn_;

        //    return rcivm;

        //}

        public override Control view()
        {
            Control v = new Excel_constReturnCalView();

            v.DataContext = this;

            return v;
        }

        public override void setUnderlying(Excel_underlyingCalcInfoViewModel excel_under)
        {
            this.Excel_underlyingCalcInfoViewModel_ = this.excel_underlyingCalcInfoViewModel_;
        }

        public override void defaultSetting()
        {
            this.constReturn_ = "0.0";
        }


    }
    
}

