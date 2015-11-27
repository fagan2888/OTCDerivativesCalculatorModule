using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class GridCalculationViewModel : MessageBodyViewModel
    {

        #region Inst_code_
        private string inst_code_;
        public string Inst_code_
        {
            get { return this.inst_code_; }
            set
            {
                if (this.inst_code_ != value)
                {
                    this.inst_code_ = value;
                    this.NotifyPropertyChanged("Inst_code_");
                }
            }
        }
        #endregion

        #region Inst_name_
        private string inst_name_;
        public string Inst_name_
        {
            get { return this.inst_name_; }
            set
            {
                if (this.inst_name_ != value)
                {
                    this.inst_name_ = value;
                    this.NotifyPropertyChanged("Inst_name_");
                }
            }
        }
        #endregion

        #region Inst_type_
        private string inst_type_;
        public string Inst_type_
        {
            get { return this.inst_type_; }
            set
            {
                if (this.inst_type_ != value)
                {
                    this.inst_type_ = value;
                    this.NotifyPropertyChanged("Inst_type_");
                }
            }
        }
        #endregion

        #region Para_refDate_
        private DateTime para_refDate_;
        public DateTime Para_refDate_
        {
            get { return this.para_refDate_; }
            set
            {
                if (this.para_refDate_ != value)
                {
                    this.para_refDate_ = value;
                    this.NotifyPropertyChanged("Para_refDate_");
                }
            }
        }
        #endregion

        public GridCalculationViewModel() 
        {
            
        }
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("messageBody");
                xmlWriter.WriteElementString("msg_type", "gridCalculation");
                xmlWriter.WriteStartElement("gridCalculation");
            
                    xmlWriter.WriteElementString("inst_code", this.inst_code_);
                    xmlWriter.WriteElementString("inst_name", this.inst_name_);
                    xmlWriter.WriteElementString("inst_type", this.inst_type_);
                    xmlWriter.WriteElementString("para_refDate", StringConverter.xmlDateTimeToDateString(this.para_refDate_));

                    xmlWriter.WriteStartElement("productInnerXml");
                        xmlWriter.WriteRaw(this.InnerXml_);
                        
                    xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.MessageBody serial_MessageBody = serial_Class as FpmlSerializedCSharp.MessageBody;
            FpmlSerializedCSharp.GridCalculation serial_GridCalculation = serial_MessageBody.GridCalculation_;

            this.inst_code_ = serial_GridCalculation.Inst_code_.ValueStr;
            this.inst_name_ = serial_GridCalculation.Inst_name_.ValueStr;
            this.inst_type_ = serial_GridCalculation.Inst_type_.ValueStr;
            //this.para_refDate_ = serial_GridCalculation.Para_refDate_.ValueStr;

            this.InnerXml_ = serial_GridCalculation.Node_.InnerXml;
            
        }


        public void mergeSetXml(string productXmlStr, string parameterXmlStr, string underHistData)
        {
            StringBuilder sb = new StringBuilder();

            //sb.AppendLine("<gridCalculation>");
                sb.AppendLine(productXmlStr);
                sb.AppendLine(parameterXmlStr);
                sb.AppendLine(underHistData);
            //sb.Append("</gridCalculation>");

                this.InnerXml_ = sb.ToString();

            ////XmlDocument InstXml = new XmlDocument();

            //StringBuilder sb = new StringBuilder();
            //XmlWriterSettings setting = new XmlWriterSettings();

            //setting.Indent = true;
            ////setting.Encoding = Encoding.UTF8;

            //XmlWriter xmlWriter = XmlWriter.Create(sb, setting);

            //xmlWriter.WriteStartElement("pricing");

            //xmlWriter.WriteElementString("evaluationTime", this.referenceDate_.ToString("yyyy-MM-dd"));


            //xmlWriter.WriteEndElement();

            //xmlWriter.Close();

            ////InstXml.LoadXml(sb.ToString());

            //return sb.ToString();
        }

        public void mergeSetXml(Excel_instrumentViewModel e_inst,DateTime refDate)
        {
            this.inst_code_ = e_inst.Item_code_;
            this.inst_type_ = e_inst.MasterInformationViewModel_.Booking_type_;
            this.inst_name_ = e_inst.MasterInformationViewModel_.Item_name_;
            this.para_refDate_ = refDate;

            this.InnerXml_ = e_inst.mergedXml(this.para_refDate_);
        }
    }
    
}

