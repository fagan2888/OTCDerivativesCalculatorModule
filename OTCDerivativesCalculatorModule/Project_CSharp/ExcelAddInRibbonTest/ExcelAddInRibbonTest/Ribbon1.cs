using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using System.Windows;
using MahApps.Metro.Controls;
using System.Reflection;
using System.IO;

namespace ExcelAddInRibbonTest
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(ResolveAssembly);
        }

        static Assembly ResolveAssembly(object sender, ResolveEventArgs args)
        {
            //We dont' care about System Assembies and so on...
            //if (!args.Name.ToLower().StartsWith("Test")) return null;

            Assembly thisAssembly = Assembly.GetExecutingAssembly();

            //Get the Name of the AssemblyFile
            var name = args.Name.Substring(0, args.Name.IndexOf(',')) + ".dll";

            //Load form Embedded Resources - This Function is not called if the Assembly is in the Application Folder
            var resources = thisAssembly.GetManifestResourceNames().Where(s => s.EndsWith(name));
            if (resources.Count() > 0)
            {
                var resourceName = resources.First();
                using (Stream stream = thisAssembly.GetManifestResourceStream(resourceName))
                {
                    if (stream == null) return null;
                    var block = new byte[stream.Length];
                    stream.Read(block, 0, block.Length);
                    return Assembly.Load(block);
                }
            }
            return null;
        }

        private void VanillaOptionBtn_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                Excel.Worksheet activeWorksheet = ((Excel.Worksheet)Globals.ThisAddIn.Application.ActiveSheet);
                //object cellValue = activeWorksheet.get_Range("A1", System.Type.Missing).Value2;
                //activeWorksheet.get_Range("A1", System.Type.Missing).Value2 = "My new value";

                //Excel.Range range1 = activeWorksheet.get_Range("A1", "B2");
                //object[,] s = (object[,])range1.Value2;
                //Excel.Range range2 = activeWorksheet.get_Range("A3", "B4");
                //range2.Value2 = (string)s[1, 2];

                OptionManagerViewModel omvm = new OptionManagerViewModel();

                omvm.loadDataFromExcelSheet(activeWorksheet);

                MetroWindow w = new MetroWindow();

                ResourceDictionary merge = new ResourceDictionary();

                ResourceDictionary rd1 = new ResourceDictionary();
                rd1.Source = new Uri("pack://application:,,,/MahApps.Metro;component/Styles/Controls.xaml");
                merge.MergedDictionaries.Add(rd1);

                ResourceDictionary rd2 = new ResourceDictionary();
                rd2.Source = new Uri("pack://application:,,,/MahApps.Metro;component/Styles/Fonts.xaml");
                merge.MergedDictionaries.Add(rd2);

                ResourceDictionary rd3 = new ResourceDictionary();
                rd3.Source = new Uri("pack://application:,,,/MahApps.Metro;component/Styles/Colors.xaml");
                merge.MergedDictionaries.Add(rd3);

                ResourceDictionary rd4 = new ResourceDictionary();
                rd4.Source = new Uri("pack://application:,,,/MahApps.Metro;component/Styles/Accents/Steel.xaml");
                merge.MergedDictionaries.Add(rd4);

                ResourceDictionary rd5 = new ResourceDictionary();
                rd5.Source = new Uri("pack://application:,,,/MahApps.Metro;component/Styles/Accents/BaseLight.xaml");
                merge.MergedDictionaries.Add(rd5);

                w.Resources = merge;

                w.Title = "8586 지수옵션 민감도 비교";

                //w.Width = 800;
                w.Height = 560;
                w.Content = omvm.view();
                w.Visibility = Visibility.Visible;
                w.Show();

            }
            catch (Exception)
            {
                
            }

            
        }

        private void GreekPosition1928_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                Excel.Worksheet activeWorksheet = ((Excel.Worksheet)Globals.ThisAddIn.Application.ActiveSheet);
                //object cellValue = activeWorksheet.get_Range("A1", System.Type.Missing).Value2;
                //activeWorksheet.get_Range("A1", System.Type.Missing).Value2 = "My new value";

                //Excel.Range range1 = activeWorksheet.get_Range("A1", "B2");
                //object[,] s = (object[,])range1.Value2;
                //Excel.Range range2 = activeWorksheet.get_Range("A3", "B4");
                //range2.Value2 = (string)s[1, 2];

                OptionGreekPositionViewModel_1928 ogpvm = new OptionGreekPositionViewModel_1928();

                ogpvm.loadDataFromExcelSheet(activeWorksheet);

                MetroWindow w = new MetroWindow();

                ResourceDictionary merge = new ResourceDictionary();

                ResourceDictionary rd1 = new ResourceDictionary();
                rd1.Source = new Uri("pack://application:,,,/MahApps.Metro;component/Styles/Controls.xaml");
                merge.MergedDictionaries.Add(rd1);

                ResourceDictionary rd2 = new ResourceDictionary();
                rd2.Source = new Uri("pack://application:,,,/MahApps.Metro;component/Styles/Fonts.xaml");
                merge.MergedDictionaries.Add(rd2);

                ResourceDictionary rd3 = new ResourceDictionary();
                rd3.Source = new Uri("pack://application:,,,/MahApps.Metro;component/Styles/Colors.xaml");
                merge.MergedDictionaries.Add(rd3);

                ResourceDictionary rd4 = new ResourceDictionary();
                rd4.Source = new Uri("pack://application:,,,/MahApps.Metro;component/Styles/Accents/Steel.xaml");
                merge.MergedDictionaries.Add(rd4);

                ResourceDictionary rd5 = new ResourceDictionary();
                rd5.Source = new Uri("pack://application:,,,/MahApps.Metro;component/Styles/Accents/BaseLight.xaml");
                merge.MergedDictionaries.Add(rd5);

                w.Resources = merge;

                w.Title = "1928 자기선물옵션 펀드별 위험현황";

                //w.Width = 800;
                w.Height = 610;
                w.Content = ogpvm.view();
                w.Visibility = Visibility.Visible;
                w.ShowDialog();
            }
            catch (Exception)
            {
                
            }

        }



    }
}
