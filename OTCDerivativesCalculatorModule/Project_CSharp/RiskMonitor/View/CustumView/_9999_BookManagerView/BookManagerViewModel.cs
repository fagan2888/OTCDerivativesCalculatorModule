using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.IO;

namespace RiskMonitor
{
    public class BookManagerViewModel
    {
        #region BookList_
        private ObservableCollection<BookInfoViewModel> bookList_;
        public ObservableCollection<BookInfoViewModel> BookList_
        {
            get { return this.bookList_; }
            set
            {
                if (this.bookList_ != value)
                {
                    this.bookList_ = value;
                    this.NotifyPropertyChanged("BookList_");
                }
            }
        }
        #endregion

        public BookManagerViewModel()
        {
            this.initialize();        
        }

        private void initialize()
        {
            this.bookList_ = new ObservableCollection<BookInfoViewModel>();

            string bookFilePath_ = "D:\\Project File\\OTCDerivativesCalculatorModule\\Project_CSharp\\RiskMonitor\\XmlFile\\book";

            // Get the root directory and print out some information about it.
            System.IO.DirectoryInfo dirInfo = new DirectoryInfo(bookFilePath_);
            Console.WriteLine(dirInfo.Attributes.ToString());

            //System.IO.FileInfo[] fileNames = dirInfo.GetFiles("*.xsd");
            System.IO.FileInfo[] fileNames = dirInfo.GetFiles("*.xml");

            foreach (System.IO.FileInfo fi in fileNames)
            {
                this.bookList_.Add(new BookInfoViewModel(fi));
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
