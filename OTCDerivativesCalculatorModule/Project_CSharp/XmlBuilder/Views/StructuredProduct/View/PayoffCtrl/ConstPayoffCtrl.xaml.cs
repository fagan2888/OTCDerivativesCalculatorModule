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

namespace XmlBuilder.Views.StructuredProduct.View.PayoffCtrl
{
    /// <summary>
    /// ConstPayoffCtrl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ConstPayoffCtrl : UserControl
    {
        private ConstPayoffCtrlModel ccm;

        public ConstPayoffCtrl()
        {
            InitializeComponent();
        }

        public ConstPayoffCtrl(ConstPayoffCtrlModel ccm)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.ccm = ccm;
        }
    }
}
