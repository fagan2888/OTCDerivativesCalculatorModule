using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class ContractSubComboViewModel : INotifyPropertyChanged
    {
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

        #region ContractSubComboString_
        protected string contractSubComboString_;
        public string ContractSubComboString_
        {
            get { return this.contractSubComboString_; }
            set
            {
                if (this.contractSubComboString_ != value)
                {
                    this.contractSubComboString_ = value;
                    this.NotifyPropertyChanged("ContractSubComboString_");
                }
            }
        }
        #endregion

        #region ContractSubComboCode_
        private string contractSubComboCode_;
        public string ContractSubComboCode_
        {
            get { return this.contractSubComboCode_; }
            set
            {
                if (this.contractSubComboCode_ != value)
                {
                    this.contractSubComboCode_ = value;
                    this.NotifyPropertyChanged("ContractSubComboCode_");
                }
            }
        }
        #endregion

        #region SelectedIndex_
        private int selectedIndex_;
        public int SelectedIndex_
        {
            get { return this.selectedIndex_; }
            set
            {
                if (this.selectedIndex_ != value)
                {
                    this.selectedIndex_ = value;
                    this.NotifyPropertyChanged("SelectedIndex_");
                }
            }
        }
        #endregion

        public static ContractSubComboViewModel CreateContractSubComboViewModel(string type)
        {
            ContractSubComboViewModel cscvm = new ContractSubComboViewModel(type, "Unkown");

            foreach (var item in ProgramVariable.ContractSubComboDisplayStrList_)
            {
                if (item.ContractSubComboCode_ == type)
                {
                    cscvm = item;
                }
            }

            return cscvm;
        }

        public ContractSubComboViewModel(string contractSubComboCode, string contractSubComboString)
        {
            // TODO: Complete member initialization
            this.contractSubComboCode_ = contractSubComboCode;
            this.contractSubComboString_ = contractSubComboString;
        }


    }
}
