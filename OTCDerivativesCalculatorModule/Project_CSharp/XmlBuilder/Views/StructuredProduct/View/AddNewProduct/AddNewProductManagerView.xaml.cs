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
using XmlBuilder.Views.StructuredProduct.View.AddNewProduct.ViewModel;

namespace XmlBuilder.Views.StructuredProduct.View.AddNewProduct
{
    /// <summary>
    /// AddNewProductManager.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class AddNewProductManagerView : Window
    {

        public ProductTemplateContentsViewModel ptcvm_ {get; set;}
        public DetailViewModel dvm_ { get; set; }
        public LocalTemplateViewModel ltvm_ { get; set; }
        public OnlineTemplateViewModel otvm_ { get; set; }


        public AddNewProductManagerView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
