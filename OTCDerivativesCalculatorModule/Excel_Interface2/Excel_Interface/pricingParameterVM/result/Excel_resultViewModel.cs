using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_resultViewModel : IXmlData , INotifyPropertyChanged
    {
        public enum SwapSide 
        {
            Party_A,
            Party_B,
            Net
        };

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
    
        // 하위 클래스로 더 만들어야함. 임시로 price만 보는 용도로 만듬
        public Excel_resultViewModel() 
        {
            //this.view_ = new ResultView();
            //this.view_.DataContext = this;

            this.excel_greekResultViewModel_ = new Excel_greekResultViewModel();
        }

        #region Notional_
        private string notional_;
        public string Notional_
        {
            get { return this.notional_; }
            set
            {
                if (this.notional_ != value)
                {
                    this.notional_ = value;
                    this.NotifyPropertyChanged("Notional_");
                }
            }
        }
        #endregion

        #region CalculationDate_
        private DateTime calculationDate_;
        public DateTime CalculationDate_
        {
            get { return this.calculationDate_; }
            set
            {
                if (this.calculationDate_ != value)
                {
                    this.calculationDate_ = value;
                    this.NotifyPropertyChanged("CalculationDate_");
                }
            }
        }
        #endregion
        
        #region Excel_valueResultViewModel_
        private Excel_valueResultViewModel excel_valueResultViewModel_;
        public Excel_valueResultViewModel Excel_valueResultViewModel_
        {
            get { return this.excel_valueResultViewModel_; }
            set
            {
                if (this.excel_valueResultViewModel_ != value)
                {
                    this.excel_valueResultViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_valueResultViewModel_");
                }
            }
        }
        #endregion

        #region Excel_greekResultViewModel_
        private Excel_greekResultViewModel excel_greekResultViewModel_;
        public Excel_greekResultViewModel Excel_greekResultViewModel_
        {
            get { return this.excel_greekResultViewModel_; }
            set
            {
                if (this.excel_greekResultViewModel_ != value)
                {
                    this.excel_greekResultViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_greekResultViewModel_");
                }
            }
        }
        #endregion

        #region Excel_cashFlowsResultViewModel_
        private Excel_cashFlowsResultViewModel excel_cashFlowsResultViewModel_;
        public Excel_cashFlowsResultViewModel Excel_cashFlowsResultViewModel_
        {
            get { return this.excel_cashFlowsResultViewModel_; }
            set
            {
                if (this.excel_cashFlowsResultViewModel_ != value)
                {
                    this.excel_cashFlowsResultViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_cashFlowsResultViewModel_");
                }
            }
        }
        #endregion

        public void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_result");
                xmlWriter.WriteElementString("calculationDate" , StringConverter.xmlDateTimeToDateString(this.calculationDate_));
                    
                this.excel_valueResultViewModel_.buildXml(xmlWriter);
                this.excel_greekResultViewModel_.buildXml(xmlWriter);
                this.excel_cashFlowsResultViewModel_.buildXml(xmlWriter);

            xmlWriter.WriteEndElement();
        }
        
        public void setFromXml(System.Xml.XmlNode node)
        {
            
        }
        
        public void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_result serial_Excel_result = serial_Class as FpmlSerializedCSharp.Excel_result;
        
            this.calculationDate_ = StringConverter.xmlDateToDateTime(serial_Excel_result.CalculationDate_.ValueStr);
            
            FpmlSerializedCSharp.Excel_valueResult serial_excel_valueResult = serial_Excel_result.Excel_valueResult_;
            this.excel_valueResultViewModel_ = new Excel_valueResultViewModel();
            this.excel_valueResultViewModel_.setFromSerial(serial_excel_valueResult);
            
            FpmlSerializedCSharp.Excel_greekResult serial_excel_greekResult = serial_Excel_result.Excel_greekResult_;
            this.excel_greekResultViewModel_ = new Excel_greekResultViewModel();
            this.excel_greekResultViewModel_.setFromSerial(serial_excel_greekResult);
            
            FpmlSerializedCSharp.Excel_cashFlowsResult serial_excel_cashFlowsResult = serial_Excel_result.Excel_cashFlowsResult_;
            this.excel_cashFlowsResultViewModel_ = new Excel_cashFlowsResultViewModel();
            this.excel_cashFlowsResultViewModel_.setFromSerial(serial_excel_cashFlowsResult);
        }

        public void loadResultXml(string result)
        {
            XmlDocument xmlDoc = new XmlDocument();
            
            xmlDoc.LoadXml(result);

            FpmlSerializedCSharp.Excel_result serial_Excel_result =
                new FpmlSerializedCSharp.Excel_result(xmlDoc.SelectSingleNode("pricingResult"));

            this.setFromSerial(serial_Excel_result);
            
            //this.Price_ = result;
            
        }

        public void insertDB()
        { 
            // db 에 
            
        }

        public Control view()
        {
            Control v = new Excel_resultView();

            v.DataContext = this;

            return v;
        }

        public string vba_description(int side = 0)
        {
            // 0 : net
            // 1 : pay
            // 2 : receive

            // default -> net

            string str = "type=empty";

            string type = "net";

            if ( side == 1 )
            {
                type = "pay".ToUpper();
                str += "_pay";
            }
            else if ( side == 2 )
            {
                type = "receive".ToUpper();
                str += "_receive";
            }
            else
            {
            
            }

            foreach (var item in this.excel_valueResultViewModel_.Excel_valueSideResultViewModel_)
	        {
                if (item.Type_.ToUpper() == type.ToUpper() )
                {
                    str = item.vba_description();
                }
	        }

            return str;
        }

        public string vba_description_valuePositionCalc(string notionalStr, int side = 0)
        {
            // 0 : net
            // 1 : pay
            // 2 : receive

            // default -> net

            string str = "";

            string type = "net";

            if (side == 1)
            {
                type = "pay".ToUpper();
            }
            else if (side == 2)
            {
                type = "receive".ToUpper();
            }
            else
            {

            }

            foreach (var item in this.excel_valueResultViewModel_.Excel_valueSideResultViewModel_)
            {
                if (item.Type_.ToUpper() == type)
                {
                    str = item.vba_description_valuePositionCalc(notionalStr);
                }
            }

            return str;

        }

        public void loadResult(string itemCode, DateTime refDate)
        {
            // db 에서 옴. 

            throw new NotImplementedException();
        }

        public string calcValue()
        {
            // 0 : net을 넣음.
            return this.excel_valueResultViewModel_.Excel_valueSideResultViewModel_[0].Dirty_;
        }
    }
    
}

