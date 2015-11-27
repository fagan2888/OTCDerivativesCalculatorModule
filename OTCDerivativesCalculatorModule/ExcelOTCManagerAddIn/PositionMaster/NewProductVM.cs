using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using RiskMonitor;

namespace ExcelOTCManagerAddIn
{
    public class NewProductVM
    {
        #region ProductExcelWBList_
        private ObservableCollection<ProductExcelWB> productExcelWBList_;
        public ObservableCollection<ProductExcelWB> ProductExcelWBList_
        {
            get { return this.productExcelWBList_; }
            set
            {
                if (this.productExcelWBList_ != value)
                {
                    this.productExcelWBList_ = value;
                    this.NotifyPropertyChanged("ProductExcelWBList_");
                }
            }
        }
        #endregion

        public NewProductVM()
        { 
        
        }

        public void loadProductExcelWB()
        {
            this.productExcelWBList_ = new ObservableCollection<ProductExcelWB>();

            // load
            string fileName = @"D:\Project File\OTCDerivativesCalculatorModule\Project_CSharp\ExcelInterface\bin\Debug\product\hifive_ki.xlsm";
            ProductExcelWB wb = new ProductExcelWB(fileName);
            this.productExcelWBList_.Add(wb);

        }

        public void testStepDownKI()
        {
            Excel_hifiveViewModel e_hifive = new Excel_hifiveViewModel();

            {
                Excel_noteInfoViewModel e_nivm = new Excel_noteInfoViewModel();

                e_nivm.Notional_ = "10000";

                e_hifive.Excel_issueInfoViewModel_ = e_nivm;

            }



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
    }
}
