using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class UnderlyingComboViewModel : INotifyPropertyChanged
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

        #region UnderlyingComboString_
        protected string underlyingComboString_;
        public string UnderlyingComboString_
        {
            get { return this.underlyingComboString_; }
            set
            {
                if (this.underlyingComboString_ != value)
                {
                    this.underlyingComboString_ = value;
                    this.NotifyPropertyChanged("UnderlyingComboString_");
                }
            }
        }
        #endregion

        #region UnderlyingComboCode_
        private string underlyingComboCode_;
        public string UnderlyingComboCode_
        {
            get { return this.underlyingComboCode_; }
            set
            {
                if (this.underlyingComboCode_ != value)
                {
                    this.underlyingComboCode_ = value;
                    this.NotifyPropertyChanged("UnderlyingComboCode_");
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

        public static UnderlyingComboViewModel CreateContractComboViewModel(string type)
        {
            //Dictionary<string, string> contractMap = new Dictionary<string, string>();

            UnderlyingComboViewModel ucvm = new UnderlyingComboViewModel(type, "Unkown");

            foreach (var item in ProgramVariable.UnderlyingComboDisplayStrList_)
            {
                if (item.UnderlyingComboCode_ == type)
                {
                    ucvm = item;
                }
            }

            return ucvm;
        }

        public UnderlyingComboViewModel(string underlyingComboCode, string underlyingComboString)
        {
            // TODO: Complete member initialization
            this.underlyingComboCode_ = underlyingComboCode;
            this.underlyingComboString_ = underlyingComboString;


        }

    }
}
