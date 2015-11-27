using System;
using System.ComponentModel;

namespace RiskMonitor
{
    public class Task : System.ComponentModel.INotifyPropertyChanged
    {
        // The Task class implements INotifyPropertyChanged so that 
        // the datagrid row will be notified of changes to the data
        // that are made in the row details section.

        // Private task data.
        private string m_Name;
        private DateTime m_DueDate;
        private bool m_Complete;
        private string m_Notes;

        // Define the public properties.
        public string Name
        {
            get { return this.m_Name; }
            set
            {
                if (value != this.m_Name)
                {
                    this.m_Name = value;
                    NotifyPropertyChanged("Name");
                }
            }
        }

        public DateTime DueDate
        {
            get { return this.m_DueDate; }
            set
            {
                if (value != this.m_DueDate)
                {
                    this.m_DueDate = value;
                    NotifyPropertyChanged("DueDate");
                }
            }
        }

        public bool Complete
        {
            get { return this.m_Complete; }
            set
            {
                if (value != this.m_Complete)
                {
                    this.m_Complete = value;
                    NotifyPropertyChanged("Complete");
                }
            }
        }

        public string Notes
        {
            get { return this.m_Notes; }
            set
            {
                if (value != this.m_Notes)
                {
                    this.m_Notes = value;
                    NotifyPropertyChanged("Notes");
                }
            }
        }

        // Implement INotifyPropertyChanged interface.
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}