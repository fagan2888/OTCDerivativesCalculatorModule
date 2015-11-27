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

namespace XmlBuilder.Views.StructuredProduct.View.IndexTransCtrlView
{
    /// <summary>
    /// ReturnCtrlView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ReturnCtrlView : UserControl
    {
        private ViewModel.ReturnCtrlViewModel rcVM_;

        public ReturnCtrlView()
        {
            InitializeComponent();
            
        }

        public ReturnCtrlView(ViewModel.ReturnCtrlViewModel rcVM)
        {
            InitializeComponent();
            this.rcVM_ = rcVM;
            CtrlName_ = "return h";
            variableGrid_Ctrl.DataContext = rcVM_;
            variableGrid_Ctrl.Detail_DataGrid.ItemsSource = rcVM_.VariableModelList_;
        }

        public string CtrlName_ { get; set; }

    }
}
