using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    /// <summary>
    /// OutputLogView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class OutputLogView : UserControl
    {
        #region OutputLogList_
        private ObservableCollection<IOutput> outputLogList_;
        public ObservableCollection<IOutput> OutputLogList_
        {
            get 
            { 
                return this.outputLogList_; 
            }
            set
            {
                if (this.outputLogList_ != value)
                {
                    this.outputLogList_ = value;
                    this.NotifyPropertyChanged("OutputLogList_");
                }
            }
        }
        #endregion

        public OutputLogView()
        {
            InitializeComponent();

            OutputLogViewModel.initialize(); //밖에서 initialize함.
            // 미리 에러가 날수 있으므로..
            
            //OutputLogViewModel.registerLogView(OutputAddTextBlock);
            //this.outputLogList_ = OutputLogViewModel.OutputList_;
            //this.OutputListView_.ItemsSource = this.OutputLogList_;
            this.OutputListView_.ItemsSource = OutputLogViewModel.OutputList_;
            //OutputLogViewModel.addResult("testError");
        }

        //private void OutputAddTextBlock(IOutput output)
        //{
        //    this.outputLogList_.Add(output);
        //}

        public void clear() 
        {
        }

        public void exportTxtFile() 
        {
        
        }

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

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            OutputLogViewModel.clear();
        }

    }
}
