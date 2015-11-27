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
using XmlBuilder.Views.InstrumentViews.ELSStepDown.Ctrl.EventCalculation;

namespace XmlBuilder.Views.InstrumentViews.ELSStepDown.Ctrl.EventCalculation
{
    /// <summary>
    /// EventEditCtrl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class EventEditCtrl : UserControl
    {
        public IXmlBuild hostVM_ { get; set; }
        public IXmlBuild thisVM_ { get; set; }

        public EventEditCtrl()
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

            if (type == "NormalELSRedemEvent")
            {
                UserControl ctrl = new StepDownEarlyRedemEventCtrl();
                ctrl.DataContext = new StepDownEarlyRedemEventCtrlViewModel();
                this.EventDetailCtrl_.Children.Add(ctrl);
            }
        }

    }
}
