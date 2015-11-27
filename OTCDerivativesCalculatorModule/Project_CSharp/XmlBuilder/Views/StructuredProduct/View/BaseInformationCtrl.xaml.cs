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
using XmlBuilder.ViewModel;
using XmlBuilder.Views.StructuredProduct.ViewModel;

namespace XmlBuilder.Views.StructuredProduct.View
{
    /// <summary>
    /// UserControl1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class BaseInformationCtrl : UserControl
    {
        public BaseInformationViewModel bivm_ {get; set;}
     
        public BaseInformationCtrl()
        {
            InitializeComponent();
        }

        private void Edit_Button_Click(object sender, RoutedEventArgs e)
        {
            if (bivm_ != null)
            {
                UnderlyingEditView uev = new UnderlyingEditView();
                UnderlyingEditViewModel uevm = new UnderlyingEditViewModel();
                uevm.BaseIndexList_ = bivm_.BaseIndexList_;
                uev.uevm_ = uevm;
                uev.DataContext = uevm;
                uev.Show();
            }
        }
    }
}
