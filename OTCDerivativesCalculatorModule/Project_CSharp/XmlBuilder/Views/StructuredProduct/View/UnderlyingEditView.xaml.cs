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
using XmlBuilder.DataModel;

namespace XmlBuilder.Views.StructuredProduct.View
{
    /// <summary>
    /// UnderlyingEditView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class UnderlyingEditView : Window
    {
        public UnderlyingEditViewModel uevm_ { get; set; }

        public UnderlyingEditView()
        {
            InitializeComponent();
            //this.Underlying_DataGrid_.DataContext = uevm_;
            
        }

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // if selection is not null 이면 update 침.
            // 

            IData underlyingData = sender as IData;

            this.uevm_.addUnderlying(underlyingData);
        }
    }
}
