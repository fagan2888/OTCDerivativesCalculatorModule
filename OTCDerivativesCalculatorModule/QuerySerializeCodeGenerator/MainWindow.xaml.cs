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

namespace QuerySerializeCodeGenerator
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.queryTb_.Text == null || this.queryTb_.Text == "" || this.nameTB_.Text == "")
                return;

            //Table builder
            if (this.tableRB_.IsChecked == true)
            {
                //string path = @"D:\Project File\OTCDerivativesCalculatorModule\QuerySerializeCodeGenerator\QuerySerializer\baseCodeTemplate\view\sampleViewQuery\";
                //string sampleViewQuery = System.IO.File.ReadAllText(path + "sampleViewQuery.txt");

                //string query1 = Clipboard.GetText;

                string query = this.queryTb_.Text;

                QueryBuilder qm = new QueryBuilder(query);
                qm.TableName_ = this.nameTB_.Text;

                QueryDAOTableManagerSerializer qtm = new QueryDAOTableManagerSerializer(qm);
                QueryDAOTableSerializer qt = new QueryDAOTableSerializer(qm);
                ViewModelSerializer vms = new ViewModelSerializer(qm);
                ViewXamlSerializer vxs = new ViewXamlSerializer(qm);

                this.managerResultTb_.Text = qtm.build();
                this.daoTb_.Text = qt.build();
                this.ViewModelTb_.Text = vms.build();
                this.ViewTb_.Text = vxs.build();


                this.columnListGrid_.ItemsSource = qm.ColumnList_;

            }
            //View builder
            else if (this.viewRB_.IsChecked == true)
            {
                string query = this.queryTb_.Text;

                QueryBuilder qm = new QueryBuilder(query);
                qm.ViewName_ = this.nameTB_.Text;

                QueryDAOViewManagerSerializer qvm = new QueryDAOViewManagerSerializer(qm);
                QueryDAOViewSerializer qv = new QueryDAOViewSerializer(qm);
                ViewModelSerializer vms = new ViewModelSerializer(qm);
                ViewXamlSerializer vxs = new ViewXamlSerializer(qm);

                this.managerResultTb_.Text = qvm.build();
                this.daoTb_.Text = qv.build();
                this.ViewModelTb_.Text = vms.build();
                this.ViewTb_.Text = vxs.build();
            }
            else
            { 
            
            }
        }

    }
}
