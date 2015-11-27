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

namespace XmlBuilder.Ctrl
{
    /// <summary>
    /// VariableGridCtrl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class VariableGridCtrl : UserControl
    {
        public VariableGridCtrl()
        {
            InitializeComponent();
        }

        //#region VariableModelList_
        //private ObservableCollection<VariableModel> variableModelList_;
        //public ObservableCollection<VariableModel> VariableModelList_
        //{
        //    get { return this.variableModelList_; }
        //    set
        //    {
        //        if (this.variableModelList_ != value)
        //        {
        //            this.variableModelList_ = value;
        //            this.NotifyPropertyChanged("VariableModelList_");
        //        }
        //    }
        //}
        //#endregion

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
