using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class ContractComboViewModel : INotifyPropertyChanged
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

        #region ContractComboString_
        protected string contractComboString_;
        public string ContractComboString_
        {
            get { return this.contractComboString_; }
            set
            {
                if (this.contractComboString_ != value)
                {
                    this.contractComboString_ = value;
                    this.NotifyPropertyChanged("ContractComboString_");
                }
            }
        }
        #endregion

        #region ContractComboCode_
        private string contractComboCode_;
        public string ContractComboCode_
        {
            get { return this.contractComboCode_; }
            set
            {
                if (this.contractComboCode_ != value)
                {
                    this.contractComboCode_ = value;
                    this.NotifyPropertyChanged("ContractComboCode_");
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

        public static ContractComboViewModel CreateContractComboViewModel(string type)
        {
            //Dictionary<string, string> contractMap = new Dictionary<string, string>();

            ContractComboViewModel ccvm = new ContractComboViewModel(type, "Unkown");

            foreach (var item in ProgramVariable.ContractComboDisplayStrList_)
            {
                if (item.ContractComboCode_ == type)
                {
                    ccvm = item;
                }
            }

            return ccvm;
        }

        public ContractComboViewModel(string contractComboCode, string contractComboString)
        {
            // TODO: Complete member initialization
            this.contractComboCode_ = contractComboCode;
            this.contractComboString_ = contractComboString;
        }
    }
}
