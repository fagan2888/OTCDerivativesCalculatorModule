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
using XmlBuilder.Views.StructuredProduct.ViewModel;

namespace XmlBuilder.Views.InstrumentViews.ELSStepDown.Ctrl.PayoffCalculation
{
    /// <summary>
    /// PayoffEditCtrl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class PayoffEditCtrl : UserControl
    {
        public IXmlBuild hostVM_ { get; set; }
        public IXmlBuild thisVM_ { get; set; }

        public PayoffEditCtrl()
        {
            InitializeComponent();
        }


        private void update()
        {
            this.hostVM_ = thisVM_;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string type = "";

            if (type == "ConstPayoff") 
            {
                UserControl ctrl = new ConstantPayoffCtrl();
                ctrl.DataContext = new ConstantPayoffCtrlViewModel();
                this.PayoffDetailCtrl_.Children.Add(ctrl);
            }
        }
    }
}
