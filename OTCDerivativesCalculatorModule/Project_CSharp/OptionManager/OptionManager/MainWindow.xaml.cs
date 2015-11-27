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
using Microsoft.Research.DynamicDataDisplay;
using Microsoft.Research.DynamicDataDisplay.DataSources;
namespace OptionManager
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //plotter

            //LineGraph lineGraph = new LineGraph(
            //plotter.AddLineGraph(source1, 2, "Data row 1");

            //List<double> x = new List<double>();
            ObservableDataSource<Point> source1 = new ObservableDataSource<Point>();

            Point x = new Point();

            for (int i = 0; i < 4 ; i++)
            {
                x.X = i;
                x.Y = i * i;
                source1.Collection.Add(x);
            }
            
            //source1.SetXMapping(x);
            plotter.AddLineGraph(source1);

        }
    }

    

}
