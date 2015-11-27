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
using System.Windows.Shapes;
using XmlBuilder.Views.StructuredProduct.ViewModel;

namespace XmlBuilder.Views.StructuredProduct.View.PayoffCtrl
{
    /// <summary>
    /// PayoffEditView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class PayoffEditView : Window
    {
        public PayoffEditView()
        {
            InitializeComponent();
        }



        private void Payoff_DataGrid__SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PayoffViewModel itvm = Payoff_DataGrid_.SelectedItem as PayoffViewModel;

            detailCtrl_.Children.Clear();
            if (itvm != null)
            {
                detailCtrl_.Children.Add(itvm.payoffDetailCtrl_);
            }
        }
    }
}
