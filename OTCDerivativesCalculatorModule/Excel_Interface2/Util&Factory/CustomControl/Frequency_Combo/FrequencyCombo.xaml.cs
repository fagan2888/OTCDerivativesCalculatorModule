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

namespace Excel_Interface
{
    /// <summary>
    /// FrequencyCombo.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class FrequencyComboBox : UserControl
    {
        public List<I_FrequencyComboBoxItem> FrequencyItemList_ { get; set; }

        public FrequencyComboBox()
        {
            InitializeComponent();
        }

        public void initialize()
        {
            //
            this.FrequencyItemList_ = new List<I_FrequencyComboBoxItem>();

            this.FrequencyItemList_.Add(new Once_ComboBoxItem());
            this.FrequencyItemList_.Add(new Monthly_ComboBoxItem());
            this.FrequencyItemList_.Add(new SemiAnnual_ComboBoxItem());
            this.FrequencyItemList_.Add(new Annual_ComboBoxItem());

            thisComboBox_.DataContext = this;

            thisComboBox_.ItemsSource = this.FrequencyItemList_;

            //Once_ComboBoxItem it = new Once_ComboBoxItem();

            thisComboBox_.SelectedIndex = 0;

        }

        private string selectedFrequency_;

        public string selectedFrequency()
        {
            return selectedFrequency_;
        }

        //public DateTime addFrequency(DateTime refDate,DateTime maturityDate)
        public DateTime addFrequency(DateTime refDate)
        {
            I_FrequencyComboBoxItem selectedItem = this.thisComboBox_.SelectedItem as I_FrequencyComboBoxItem;
            //string name = selectedItem.;

            DateTime d = selectedItem.nextDate(refDate);

            return d;
        }

        //private void thisComboBox__SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    ComboBoxItem selectedItem = this.thisComboBox_.SelectedItem as ComboBoxItem;
        //    string name = selectedItem.Name;

        //    switch (name)
        //    {
        //        case "Once":
        //            {
        //                this.selectedFrequency_ = "0M";
        //                break;

        //            }
        //        case "Monthly":
        //            {
        //                this.selectedFrequency_ = "1M";
        //                break;

        //            }
        //        case "Quarterly":
        //            {
        //                this.selectedFrequency_ = "3M";
        //                break;
        //            }
        //        case "EveryFourthMonth":
        //            {
        //                this.selectedFrequency_ = "4M";
        //                break;
        //            }
        //        case "Semiannual":
        //            {
        //                this.selectedFrequency_ = "6M";
        //                break;
        //            }
        //        case "Annual":
        //            {
        //                this.selectedFrequency_ = "12M";
        //                break;
        //            }

        //    }

            
        //}

    }
}
