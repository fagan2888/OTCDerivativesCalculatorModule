using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class BatchItemViewModel : INotifyPropertyChanged
    {
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

        #region Excel_instrumentViewModel_
        private Excel_instrumentViewModel excel_instrumentViewModel_;
        public Excel_instrumentViewModel Excel_instrumentViewModel_
        {
            get { return this.excel_instrumentViewModel_; }
            set
            {
                if (this.excel_instrumentViewModel_ != value)
                {
                    this.excel_instrumentViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_instrumentViewModel_");
                }
            }
        }
        #endregion

        #region ItemCode_
        public string ItemCode_
        {
            get 
            { 
                return this.excel_instrumentViewModel_.MasterInformationViewModel_.Item_code_; 
            }
        }
        #endregion

        #region Name_
        public string Name_
        {
            get { return this.excel_instrumentViewModel_.MasterInformationViewModel_.Item_name_; }
        }
        #endregion

        #region ParameterStatus_
        private string parameterStatus_;
        public string ParameterStatus_
        {
            get { return this.parameterStatus_; }
            set
            {
                if (this.parameterStatus_ != value)
                {
                    this.parameterStatus_ = value;
                    this.NotifyPropertyChanged("ParameterStatus_");
                }
            }
        }
        #endregion

        #region CalculationStatus_
        private string calculationStatus_;
        public string CalculationStatus_
        {
            get { return this.calculationStatus_; }
            set
            {
                if (this.calculationStatus_ != value)
                {
                    this.calculationStatus_ = value;
                    this.NotifyPropertyChanged("CalculationStatus_");
                }
            }
        }
        #endregion

        #region ResultPrice_
        private string resultPrice_;
        public string ResultPrice_
        {
            get { return this.resultPrice_; }
            set
            {
                if (this.resultPrice_ != value)
                {
                    this.resultPrice_ = value;
                    this.NotifyPropertyChanged("ResultPrice_");
                }
            }
        }
        #endregion

        public BatchItemViewModel(Excel_instrumentViewModel e_inst)
        {
            this.excel_instrumentViewModel_ = e_inst;
        }

        public void checkParameterBuild(DateTime refDate)
        {
            try
            {
                
                bool tf = XMLFileLoader.isFileExist(this.excel_instrumentViewModel_.Item_code_, refDate);

                if (tf)
                {
                    this.ParameterStatus_ = "OK";
                }
                else
                {
                    this.ParameterStatus_ = "Fail";
                }
            }
            catch (Exception )
            {
                this.ParameterStatus_ = "Fail";
            }
        }

        public void parameterBuild(DateTime refDate)
        {
            try
            {
                this.excel_instrumentViewModel_.loadBatchDetailContext();

                this.excel_instrumentViewModel_.buildParameterFromInstrument(refDate);

                XMLFileLoader.SaveParameter(this.excel_instrumentViewModel_.Excel_parameterViewModel_);

                this.ParameterStatus_ = "OK";


            }
            catch (Exception e)
            {
                this.ParameterStatus_ = "error : " + e.Message;
                //throw;
            }

        }

        public string calculate(DateTime refDate)
        {
            //try
            //{
            this.excel_instrumentViewModel_.calculateSavedXml(refDate); // parameter의 refDate를 기준으로 돌아감. 바꿔야하나..?
            this.CalculationStatus_ = "OK";
                
            //this.ResultPrice_ = this.excel_instrumentViewModel_.Excel_parameterViewModel_.Excel_resultViewModel_.Price_;

            return this.resultPrice_;
            //}
            //catch (Exception e)
            //{
            //    this.CalculationStatus_ = "error : " + e.Message;
            //    //throw;
            //}
            

        }



    }
}
