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

namespace RiskMonitor
{
    /// <summary>
    /// HedgePositionGridCtrl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class HedgePositionGridCtrl : UserControl
    {
        public HedgePositionGridCtrl()
        {
            InitializeComponent();

            

            //this.loadData();

        }

        public void loadData()
        {
            
            this.hivm_ = new HedgeInformationViewModel(5);
            this.dataGrid1.ItemsSource = hivm_.HedgeInformationModels_;
            CountTxb.Text = Convert.ToString(hivm_.HedgeInformationModels_.Count);
        }
        //private void dataLoad() 
        //{
        //    //포지션 가져옴

        //    //Factory 에서 상품에 맞게 build함

        //    //result link 함

        //    //result load함

        //    //load 하는 코드
        //    ObservableCollection<Instrument> Instruments = new ObservableCollection<Instrument>();

        //    this.dataGrid1.ItemsSource = hivm_.HedgeInformationModels_;
        //}

        public HedgeInformationViewModel hivm_ { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.loadData();
        }

        //// Set the row details visibility to the option selected in the combo box.
        //private void cbRowDetailsVis_SelectionChanged(object sender, RoutedEventArgs e)
        //{
        //    ComboBox cb = sender as ComboBox;
        //    ComboBoxItem cbi = cb.SelectedItem as ComboBoxItem;
        //    if (this.dataGrid1 != null)
        //    {
        //        if (cbi.Content.ToString() == "Selected Row (Default)")
        //            dataGrid1.RowDetailsVisibilityMode = DataGridRowDetailsVisibilityMode.VisibleWhenSelected;
        //        else if (cbi.Content.ToString() == "None")
        //            dataGrid1.RowDetailsVisibilityMode = DataGridRowDetailsVisibilityMode.Collapsed;
        //        else if (cbi.Content.ToString() == "All")
        //            dataGrid1.RowDetailsVisibilityMode = DataGridRowDetailsVisibilityMode.Visible;
        //    }
        //}
        //// Freeze the row details if the check box is checked.
        //private void cbFreezeRowDetails_Changed(object sender, RoutedEventArgs e)
        //{
        //    CheckBox cb = sender as CheckBox;
        //    if (this.dataGrid1 != null)
        //        this.dataGrid1.AreRowDetailsFrozen = (bool)cb.IsChecked;
        //}
    }
}
