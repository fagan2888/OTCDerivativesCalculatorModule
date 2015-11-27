using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Xml;
using System.IO;

namespace RiskMonitor
{
    public class MainWindowViewModel
    {

        public DateTime ReferenceDate_ { get; set; }

        public ExplorerBookInstViewModel ExplorerBookInstVM_ { get; set; }

        public BookInfoViewModel BookInfoVM_ { get; set; }
        private MainWindow mainWindow_;

        public MainWindowViewModel(MainWindow mainWindow,BookInfoViewModel bookInfoVM)
        {
            this.mainWindow_ = mainWindow;
            this.ExplorerBookInstVM_ = new ExplorerBookInstViewModel(mainWindow, bookInfoVM);
            this.BookInfoVM_ = bookInfoVM;
        }

        //public static Dictionary<string, BookInfoViewModel> BookList_ = new Dictionary<string, BookInfoViewModel>();

        //public static string BookFileName_ = "bookconfig.xml";

        //public void bookLoad()
        //{ 
        //    BookList_.Clear();

        //    //InstrumentDataLoader dataLoader = new InstrumentDataLoader(PortfolioPath_);

        //    //FileInfo fileInfo = bookinfo

        //    // new FileInfo(PortfolioPath_ + BookFileName_);

        //    //bookInfo.InstHierarchyList_ = dataLoader.listLoad_test();

        //    //BookList_.Add("test", bookInfo);

        //}



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
