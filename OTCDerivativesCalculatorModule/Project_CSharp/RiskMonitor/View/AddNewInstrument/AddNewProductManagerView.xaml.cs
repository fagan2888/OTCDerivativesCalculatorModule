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

namespace RiskMonitor
{
    /// <summary>
    /// AddNewProductManager.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class AddNewProductManagerView : Window
    {

        private MainWindow mainWindow_;

        public ContentsListViewModel contentsListVM_ {get; set;}
        public DetailViewModel dvm_ { get; set; }

        public LocalTemplateViewModel localTemplateVM_ { get; set; }
        public OnlineTemplateViewModel otvm_ { get; set; }


        public AddNewProductManagerView(MainWindow mainWindow)
        {

            InitializeComponent();
            this.mainWindow_ = mainWindow;
            initializeList();

        }

        // 나중에 여기를 메타 데이터로 받아야하는건지 모르겠네...
        private void initializeList()
        {
            //foreach (var item in collection)
            //{

            //    this.LocalTemplateListView_.Items.Add(new TreeViewItem() { Header = "USA" });
            //}
            localTemplateVM_ = new LocalTemplateViewModel();

        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            //string fileName = FileNameTb_.Text;

            //string path = "";
            //// selected item 골라

            ////InstrumentTemplate template = ContentListView_.SelectedItem as InstrumentTemplate; 
            //InstrumentTemplate template = new TemplateStepDownWithKI(); 

            ////StepDownInstViewModel instVM = new StepDownInstViewModel(fileName);

            //mainWindow_.AddToLayoutDocumentOnMainWindow(template.documentView(), RiskMonitor.Activate.Show);

            ////file 생성 & 저장

            //template.Path_ = path;
            //template.saveFile();

            //mainWindow_.InstrumentExplorerVM_.Add(template.instrumentBaseVM());

            ////mainWindow_.AddToLayoutDocumentOnMainWindow(ContentListView_.SelectedItem as Control);
            ////mainWindow_.AddToLayoutDocumentOnMainWindow(new StepDownInstView());

            //this.Close();

        }

        private void LocalTemplateListView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            TemplateHirachyModel vm = LocalTemplateListView_.SelectedItem as TemplateHirachyModel;
            ContentListView_.ItemsSource = vm.InstrumentTemplateList_;

        }

        private void ContentListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.AddBtn_Click(sender, e);
        }

        private void ContentListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Detail에 세부 설정을 함.
        }



    }
}
