using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public abstract class NonKiEventInfoViewModel : KiEventInfoViewModel
    {
    
        public NonKiEventInfoViewModel() { }
        
        #region ConstNonKiTriggerViewModel_
        private ConstNonKiTriggerViewModel constNonKiTriggerViewModel_;
        public ConstNonKiTriggerViewModel ConstNonKiTriggerViewModel_
        {
            get { return this.constNonKiTriggerViewModel_; }
            set
            {
                if (this.constNonKiTriggerViewModel_ != value)
                {
                    this.constNonKiTriggerViewModel_ = value;
                    this.NotifyPropertyChanged("ConstNonKiTriggerViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_nonkiType;
        
        public static NonKiEventInfoViewModel CreateNonKiEventInfo(string typeStr)
        {
            if ( typeStr == "constNonKiTrigger")
            {
                return new ConstNonKiTriggerViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        public static NonKiEventInfoViewModel CreateNonKiEventInfo(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.NonKiEventInfo serial_NonKiEventInfo = serial_Class as FpmlSerializedCSharp.NonKiEventInfo;
            string typeStr = serial_NonKiEventInfo.Type_.ValueStr;
            return NonKiEventInfoViewModel.CreateNonKiEventInfo(typeStr);
        }
        
    
    }
    
}

