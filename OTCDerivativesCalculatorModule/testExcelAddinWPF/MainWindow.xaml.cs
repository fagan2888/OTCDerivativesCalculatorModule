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
using Microsoft.Research.DynamicDataDisplay.PointMarkers;
using System.Diagnostics;
using Excel_Interface;
using System.Xml;


namespace testExcelAddinWPF
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            object oo = new object();
            RoutedEventArgs era = new RoutedEventArgs();

            //this.batchPLBtn_Click(oo, era);
            //this.tapViewTestBtn_Click(oo, era);

        }

        private void testtest()
        {
            ////XmlWriter w = new XmlWriter();

            //System.Xml.XmlElement xmlEle = new System.Xml.XmlElement();
            //XmlWriter.Create(
            //xmlEle.InnerText = "";

            //string kk = xmlEle.InnerXml;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Excel_Interface.Excel_hifiveViewModel e_hvm = new Excel_Interface.Excel_hifiveViewModel();

            Window w = new Window();
            w.Width = 400;
            w.Height = 300;
            w.Content = e_hvm.view();
            w.Visibility = 0;

            //e_hvm.buildHifive();

            //string kk = e_hvm.testString();

            //Console.Write(kk);

            //System.IO.File.WriteAllText("testResult.xml", kk);

            //MessageBoxResult result = MessageBox.Show(kk);
        }

        private void instrumentBtn_Click(object sender, RoutedEventArgs e)
        {
            Excel_Interface.Excel_instrumentViewModel e_instVM = new Excel_instrument_hifiveViewModel();

            Window w = new Window();
            w.Width = 400;
            w.Height = 300;
            //w.Content = e_instVM.View_;
            w.Content = e_instVM.view(true);
            w.Visibility = 0;

            //e_hvm.buildHifive();
        }

        private void marketDataBtn_Click(object sender, RoutedEventArgs e)
        {
            YahooMarketDataLoader loader = new YahooMarketDataLoader();

            loader.loadTickerList();
            loader.loadData();
            loader.dbInsert();

        }

        private void historyMarketDataBtn_Click(object sender, RoutedEventArgs e)
        {
            YahooMarketDataLoader loader = new YahooMarketDataLoader();

            loader.loadTickerList();
            loader.loadHistoryData(new DateTime(2011,1,1),new DateTime(2014,4,8));
            loader.dbInsertHistory();

        }

        private void dataManagerBtn_Click(object sender, RoutedEventArgs e)
        {
            MarketDataManagerViewModel mdmvm = new MarketDataManagerViewModel();
            mdmvm.loadDefinedIndexSymbolFromDB();

            Window w = new Window();
            w.Width = 400;
            w.Height = 300;
            w.Content = mdmvm.view();
            w.Visibility = 0;
        }

        private void testDataGridActionBtn_Click(object sender, RoutedEventArgs e)
        {
            var col = new DataGridTextColumn();
            col.Header = "d";
            col.Binding = new Binding("RoomNumber");

            this.testDataGrid_.Columns.Add(col);
            this.testDataGrid_.Columns.RemoveAt(0);
        }

        private void testCalculateBtn_Click(object sender, RoutedEventArgs e)
        {
            string k = "5M";
            string kk = "12M";
            string kkk = "120M";

            int len = k.Length;

            string periodMultiplier = k.Substring(0, len - 1);
            string period = k.Substring(len - 1, 1);
            
            int len2 = kk.Length;

            string periodMultiplierk = kk.Substring(0, len2 - 1);
            string periodk = kk.Substring(len2 - 1, 1);

            int len3 = kkk.Length;

            string periodMultiplierkk = kkk.Substring(0, len3 - 1);
            string periodkk = kkk.Substring(len3 - 1, 1);

            // file 로드
            
            //calculation

            string path = @"D:\Project File\OTCDerivativesCalculatorModule\testExcelAddinWPF\bin\Debug\";

            XmlDocument productXmlDoc = new XmlDocument();
            productXmlDoc.Load(path + "testProductInfo.xml");
            string productXmlStr = productXmlDoc.InnerXml;

            XmlDocument paraXmlDoc = new XmlDocument();
            paraXmlDoc.Load(path + "testParameterInfo.xml");
            string parameterXmlStr = paraXmlDoc.InnerXml;

            XmlDocument dataXmlDoc = new XmlDocument();
            dataXmlDoc.Load(path + "testUnderHistDataInfo.xml");
            string underHistData = dataXmlDoc.InnerXml;

            //string result = CalculationModuleDLL.calculationLibCall(productXmlStr, parameterXmlStr);
            //string result = CalculationModuleDLL.calculationLibCall("HIFIVE",
            //                                                        productXmlStr,
            //                                                        parameterXmlStr,
            //                                                        underHistData
            //                                                        );

            //MessageBox.Show(result);

        }

        private void treeViewTestBtn_Click(object sender, RoutedEventArgs e)
        {
            //System.GC.Collect();

            DataBaseConnectManager.DBConnection_
                = DataBaseConnectManager.ConnectionFactory(EnvironmentVariable.MarketDataDBFile_);

            //EVENT_INFO_Table_DAOManager d = new EVENT_INFO_Table_DAOManager();

            //d.delete(DataBaseConnectManager.DBConnection_);
            
            ProgramVariable.initialize_CurrencyStringList();

            RootBookViewModel.setRootBookReferenceDate(DateTime.Now);

            BookFolderView bfv = new BookFolderView();

            bfv.ReferenceDate_ = this.loadLastPositionDate();
            bfv.positionXmlReload();

            //RootBookViewModel root_bvm = new RootBookViewModel();

            //root_bvm.loadPosition();

            //RootFavoriteViewModel root_fvm = new RootFavoriteViewModel();

            //root_fvm.loadPosition();

            //bfv.RootBookViewModel_ = root_bvm;
            //bfv.RootFavoriteViewModel_ = root_fvm;

            Window w = new Window();
            w.Width = 600;
            w.Height = 400;
            w.Content = bfv;
            w.Visibility = 0;

        }

        private DateTime loadLastPositionDate()
        {
            return DateTime.Now;
        }

        private void testDockPanelBtn_Click(object sender, RoutedEventArgs e)
        {
            Window w = new Window1();
            w.Width = 800;
            w.Height = 400;
            w.Visibility = 0;
        }

        private void ETLButton_Click_1(object sender, RoutedEventArgs e)
        {
            //ETL_POSIOTION_PL etl = new ETL_POSIOTION_PL();

            //DateTime d = new DateTime(2014,6,5);

            //etl.exercute(d);
        }

        private void batchPLBtn_Click(object sender, RoutedEventArgs e)
        {
            //PL_Calculator pl_cal = new PL_Calculator();

            //pl_cal.dataLoad();
            //pl_cal.doDBInsertJob();

            SettingInitializer ini = new SettingInitializer();

            ini.initialze(1);

            OutputLogViewModel.OutputList_ = new System.Collections.ObjectModel.ObservableCollection<IOutput>();

            DataInterfaceManager dim = new DataInterfaceManager();

            //DateTime refDate = new DateTime();
            DateTime refDate = DateTime.Now;

            dim.generateParaXml(refDate);

        }

        private void tapViewTestBtn_Click(object sender, RoutedEventArgs e)
        {
            OTCApplicationViewModel otcAppVM = new OTCApplicationViewModel();
            
            Window w = new Window();
            //w.Width = 800;
            //w.Height = 400;
            w.Content = otcAppVM.View_;
            w.Visibility = 0;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.test_.initialize();
        }

        private void yieldTestBtn_Click(object sender, RoutedEventArgs e)
        {
            //Excel_irCurveSymbolViewModel test = new Excel_irCurveSymbolViewModel();

            //test.Symbol_ = "111000";

            //DataBaseConnectManager.DBConnection_
            //    = DataBaseConnectManager.ConnectionFactory(EnvironmentVariable.MarketDataDBFile_,"RMS");

            //test.dataLoad(new DateTime(2014, 10, 24));

            CurveManager cm = new CurveManager();

            cm.load("111000", ProgramVariable.ReferenceDate_);

            //QLNet.YieldTermStructure ts = cm.yieldTS();
            QLNet.YieldTermStructure ts = cm.yieldTSBuild();

            double[] sumY = Enumerable.Repeat<double>(0.0, 100).ToArray<double>();
            double[] x = Enumerable.Range(0, 200).Select(i => i / 100.0).ToArray();
            double[] y = new double[x.Length];

            for (int i = 0; i < x.Length; i++)
            {
                y[i] = ts.zeroRate(x[i], QLNet.Compounding.Compounded).value();
            }

            ChartPlotter cp = new ChartPlotter();

            var xData = x.AsXDataSource();
            var yData = y.AsYDataSource();

            CompositeDataSource compositeDataSource = xData.Join(yData);

            LineGraph lineG = new LineGraph(compositeDataSource);

            lineG.Description = new PenDescription("합계");
            cp.Children.Add(lineG);

            //this.chartGrid_.Children.Add(cp);

            Window w = new Window();
            w.Content = cp;
            w.ShowDialog();

        }

        private void genTestBtn_Click(object sender, RoutedEventArgs e)
        {
            SettingInitializer ini = new SettingInitializer();

            ini.initialze(1);
            ProgramVariable.initialize_ComboStr();

            AutoBookingManager abm = new AutoBookingManager();

            List<string> productStringList = new List<string>() 
            {
                "Type=2 Stock Step Down Double Callable;Underlyings=우리투자증권,하나금융지주;Tenor=3y;Observation period=6m;Trigger level=92.5/92.5/87.5/87.5/82.5/82.5;Knock In barrier=57.499;Coupon(p.a)=11.3;EffectiveDate=2013-07-08;ExportCode=50507A3709S0;Notional=300000000;Name=IBK 제882회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=우리투자증권,한국금융지주;Tenor=3y;Observation period=6m;Trigger level=92.5/92.5/87.5/87.5/82.5/82.5;Knock In barrier=57.499;Coupon(p.a)=12;EffectiveDate=2013-07-12;ExportCode=50507A3726S0;Notional=500000000;Name=IBK 제911회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=우리투자증권,한국전력;Tenor=3y;Observation period=6m;Trigger level=92.5/92.5/87.5/87.5/82.5/82.5;Knock In barrier=57.499;Coupon(p.a)=11.6;EffectiveDate=2013-07-12;ExportCode=50507A3727S0;Notional=400000000;Name=IBK 제912회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=삼성전기,LG화학;Tenor=3y;Observation period=6m;Trigger level=90/90/85/85/80/80;Knock In barrier=59.999;Coupon(p.a)=9;EffectiveDate=2014-03-24;ExportCode=50507A4345S0;Notional=38000000;Name=IBK 제1111회 공모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=POSCO,롯데케미칼;Tenor=3y;Observation period=6m;Trigger level=90/90/85/85/80/80;Knock In barrier=59.999;Coupon(p.a)=9.5;EffectiveDate=2014-03-31;ExportCode=50507A4355S0;Notional=10000000;Name=IBK 제1114회 공모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=POSCO,롯데케미칼;Tenor=3y;Observation period=6m;Trigger level=90/90/85/85/80/80;Knock In barrier=59.999;Coupon(p.a)=9.5;EffectiveDate=2014-04-07;ExportCode=50507A4417S0;Notional=30000000;Name=IBK 제1132회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=SK,한라홀딩스;Tenor=3y;Observation period=6m;Trigger level=92.5/92.5/87.5/87.5/82.5/82.5;Knock In barrier=57.499;Coupon(p.a)=12.5;EffectiveDate=2014-05-12;ExportCode=50507A4514S0;Notional=300000000;Name=IBK 제1165회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=현대차,하나금융지주;Tenor=3y;Observation period=6m;Trigger level=92.5/92.5/87.5/87.5/82.5/82.5;Knock In barrier=57.499;Coupon(p.a)=10.8;EffectiveDate=2014-05-14;ExportCode=50507A4516S0;Notional=300000000;Name=IBK 제1172회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=현대차,롯데쇼핑;Tenor=3y;Observation period=6m;Trigger level=92.5/92.5/87.5/87.5/82.5/82.5;Knock In barrier=57.499;Coupon(p.a)=10.17;EffectiveDate=2014-05-14;ExportCode=50507A4517S0;Notional=300000000;Name=IBK 제1173회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=우리금융,하나금융지주;Tenor=3y;Observation period=6m;Trigger level=92.5/92.5/87.5/87.5/82.5/82.5;Knock In barrier=57.499;Coupon(p.a)=10.95;EffectiveDate=2014-05-23;ExportCode=50507A4536S0;Notional=300000000;Name=IBK 제1187회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=삼성전자,LG전자;Tenor=3y;Observation period=6m;Trigger level=90/90/85/85/80/80;Knock In barrier=59.999;Coupon(p.a)=7.5;EffectiveDate=2014-05-26;ExportCode=50507A4543S0;Notional=830000000;Name=IBK 제1182회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=현대차,한라홀딩스;Tenor=3y;Observation period=6m;Trigger level=92.5/92.5/87.5/87.5/82.5/82.5;Knock In barrier=57.499;Coupon(p.a)=11.82;EffectiveDate=2014-05-29;ExportCode=50507A4553S0;Notional=600000000;Name=IBK 제1192회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=현대차,한라홀딩스;Tenor=3y;Observation period=6m;Trigger level=92.5/92.5/87.5/87.5/82.5/82.5;Knock In barrier=57.499;Coupon(p.a)=11.82;EffectiveDate=2014-05-29;ExportCode=50507A4554S0;Notional=300000000;Name=IBK 제1193회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=삼성전자,LG전자;Tenor=3y;Observation period=6m;Trigger level=90/90/85/85/80/80;Knock In barrier=59.999;Coupon(p.a)=7.5;EffectiveDate=2014-06-02;ExportCode=50507A4605S0;Notional=1024350000;Name=IBK 제1186회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=삼성전자,LG전자;Tenor=3y;Observation period=6m;Trigger level=90/90/85/85/80/80;Knock In barrier=59.999;Coupon(p.a)=7.2;EffectiveDate=2014-06-09;ExportCode=50507A4611S0;Notional=444000000;Name=IBK 제1195회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=현대차,하나금융지주;Tenor=3y;Observation period=6m;Trigger level=92.5/92.5/87.5/87.5/82.5/82.5;Knock In barrier=57.499;Coupon(p.a)=10.62;EffectiveDate=2014-06-11;ExportCode=50507A4614S0;Notional=300000000;Name=IBK 제1207회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=삼성전자,LG전자;Tenor=3y;Observation period=6m;Trigger level=90/90/85/85/80/80;Knock In barrier=59.999;Coupon(p.a)=7.3;EffectiveDate=2014-06-16;ExportCode=50507A4622S0;Notional=754130000;Name=IBK 제1199회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=현대차,한라홀딩스;Tenor=3y;Observation period=6m;Trigger level=95/95/90/90/85/85;Knock In barrier=54.999;Coupon(p.a)=10.62;EffectiveDate=2014-06-16;ExportCode=50507A4623S0;Notional=162000000;Name=IBK 제1210회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=현대차,하나금융지주;Tenor=3y;Observation period=6m;Trigger level=92.5/92.5/87.5/87.5/82.5/82.5;Knock In barrier=57.499;Coupon(p.a)=10.56;EffectiveDate=2014-06-16;ExportCode=50507A4624S0;Notional=300000000;Name=IBK 제1212회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=삼성전자,LG전자;Tenor=3y;Observation period=6m;Trigger level=90/90/85/85/80/80;Knock In barrier=59.999;Coupon(p.a)=7.3;EffectiveDate=2014-06-23;ExportCode=50507A4640S0;Notional=874800000;Name=IBK 제1208회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=삼성전자,LG전자;Tenor=3y;Observation period=6m;Trigger level=90/90/85/85/80/80;Knock In barrier=59.999;Coupon(p.a)=7.3;EffectiveDate=2014-06-30;ExportCode=50507A4659S0;Notional=335000000;Name=IBK 제1217회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=삼성전자,LG전자;Tenor=3y;Observation period=6m;Trigger level=90/90/85/85/80/80;Knock In barrier=59.999;Coupon(p.a)=7.2;EffectiveDate=2014-07-07;ExportCode=50507A4717S0;Notional=1583370000;Name=IBK 제1221회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=삼성전자,LG전자;Tenor=3y;Observation period=6m;Trigger level=90/90/85/85/80/80;Knock In barrier=59.999;Coupon(p.a)=7;EffectiveDate=2014-07-14;ExportCode=50507A4736S0;Notional=926110000;Name=IBK 제1227회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=현대차,우리금융;Tenor=3y;Observation period=6m;Trigger level=92.5/92.5/87.5/87.5/82.5/82.5;Knock In barrier=57.499;Coupon(p.a)=10.11;EffectiveDate=2014-07-23;ExportCode=50507A4761S0;Notional=300000000;Name=IBK 제1244회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=삼성전자,LG전자;Tenor=3y;Observation period=6m;Trigger level=90/90/85/85/80/80;Knock In barrier=59.999;Coupon(p.a)=6.8;EffectiveDate=2014-07-28;ExportCode=50507A4768S0;Notional=621700000;Name=IBK 제1238회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=삼성전자,LG전자;Tenor=3y;Observation period=6m;Trigger level=90/90/85/85/80/80;Knock In barrier=59.999;Coupon(p.a)=6.8;EffectiveDate=2014-08-01;ExportCode=50507A4807S0;Notional=546700000;Name=IBK 제1246회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=삼성전자,LG전자;Tenor=3y;Observation period=6m;Trigger level=90/90/85/85/80/80;Knock In barrier=59.999;Coupon(p.a)=6.8;EffectiveDate=2014-08-11;ExportCode=50507A4841S0;Notional=608500000;Name=IBK 제1253회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=LS,우리금융;Tenor=3y;Observation period=6m;Trigger level=92.5/92.5/87.5/87.5/82.5/82.5;Knock In barrier=57.499;Coupon(p.a)=11;EffectiveDate=2014-08-11;ExportCode=50507A4843S0;Notional=400000000;Name=IBK 제1267회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=우리금융,한라홀딩스;Tenor=3y;Observation period=6m;Trigger level=92.5/92.5/87.5/87.5/82.5/82.5;Knock In barrier=57.499;Coupon(p.a)=12;EffectiveDate=2014-08-13;ExportCode=50507A4849S0;Notional=300000000;Name=IBK 제1272회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=우리금융,한라홀딩스;Tenor=3y;Observation period=6m;Trigger level=92.5/92.5/87.5/87.5/82.5/82.5;Knock In barrier=57.499;Coupon(p.a)=12;EffectiveDate=2014-08-13;ExportCode=50507A4850S0;Notional=300000000;Name=IBK 제1273회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=LS,한라홀딩스;Tenor=3y;Observation period=6m;Trigger level=92.5/92.5/87.5/87.5/82.5/82.5;Knock In barrier=57.499;Coupon(p.a)=12;EffectiveDate=2014-08-13;ExportCode=50507A4851S0;Notional=300000000;Name=IBK 제1274회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=LS,한라홀딩스;Tenor=3y;Observation period=6m;Trigger level=92.5/92.5/87.5/87.5/82.5/82.5;Knock In barrier=57.499;Coupon(p.a)=12;EffectiveDate=2014-08-13;ExportCode=50507A4852S0;Notional=300000000;Name=IBK 제1275회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=우리금융,한라홀딩스;Tenor=3y;Observation period=6m;Trigger level=92.5/92.5/87.5/87.5/82.5/82.5;Knock In barrier=57.499;Coupon(p.a)=11.4;EffectiveDate=2014-08-14;ExportCode=50507A4859S0;Notional=300000000;Name=IBK 제1281회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=삼성전자,LG전자;Tenor=3y;Observation period=6m;Trigger level=90/90/85/85/80/80;Knock In barrier=59.999;Coupon(p.a)=6.8;EffectiveDate=2014-08-18;ExportCode=50507A4870S0;Notional=427840000;Name=IBK 제1282회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=삼성전자,LG전자;Tenor=3y;Observation period=6m;Trigger level=90/90/85/85/80/80;Knock In barrier=59.999;Coupon(p.a)=6.8;EffectiveDate=2014-08-25;ExportCode=50507A48A7S0;Notional=896260000;Name=IBK 제1283회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=현대차,우리금융;Tenor=3y;Observation period=6m;Trigger level=92.5/92.5/87.5/87.5/82.5/82.5;Knock In barrier=57.499;Coupon(p.a)=10.11;EffectiveDate=2014-08-20;ExportCode=50507A4875S0;Notional=300000000;Name=IBK 제1284회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=현대차,LS;Tenor=3y;Observation period=6m;Trigger level=92.5/92.5/87.5/87.5/82.5/82.5;Knock In barrier=57.499;Coupon(p.a)=10.11;EffectiveDate=2014-08-20;ExportCode=50507A4876S0;Notional=200000000;Name=IBK 제1285회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=우리금융,SK이노베이션;Tenor=3y;Observation period=6m;Trigger level=92.5/92.5/87.5/87.5/82.5/82.5;Knock In barrier=57.499;Coupon(p.a)=10.11;EffectiveDate=2014-08-22;ExportCode=50507A4885S0;Notional=400000000;Name=IBK 제1290회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=삼성전자,LG전자;Tenor=3y;Observation period=6m;Trigger level=90/90/85/85/80/80;Knock In barrier=59.999;Coupon(p.a)=6.8;EffectiveDate=2014-09-01;ExportCode=50507A4918S0;Notional=591700000;Name=IBK 제1287회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=현대차,우리금융;Tenor=3y;Observation period=6m;Trigger level=90/90/87.5/87.5/82.5/82.5;Knock In barrier=57.499;Coupon(p.a)=10.8;EffectiveDate=2014-09-24;ExportCode=50507A4970S0;Notional=300000000;Name=IBK 제1334회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=LS,SK이노베이션;Tenor=3y;Observation period=6m;Trigger level=90/90/87.5/87.5/82.5/82.5;Knock In barrier=57.499;Coupon(p.a)=10.8;EffectiveDate=2014-09-24;ExportCode=50507A4962S0;Notional=300000000;Name=IBK 제1326회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=LS,우리금융;Tenor=3y;Observation period=6m;Trigger level=90/90/87.5/87.5/82.5/82.5;Knock In barrier=57.499;Coupon(p.a)=10.8;EffectiveDate=2014-09-24;ExportCode=50507A4966S0;Notional=200000000;Name=IBK 제1330회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=삼성전자,LG전자;Tenor=3y;Observation period=6m;Trigger level=90/90/85/85/80/80;Knock In barrier=59.999;Coupon(p.a)=7.2;EffectiveDate=2014-09-24;ExportCode=50507A4964S0;Notional=200000000;Name=IBK 제1328회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=LS,SK이노베이션;Tenor=3y;Observation period=6m;Trigger level=90/90/87.5/87.5/82.5/82.5;Knock In barrier=57.499;Coupon(p.a)=10.8;EffectiveDate=2014-09-24;ExportCode=50507A4963S0;Notional=100000000;Name=IBK 제1327회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=현대차,우리금융;Tenor=3y;Observation period=6m;Trigger level=90/90/87.5/87.5/82.5/82.5;Knock In barrier=57.499;Coupon(p.a)=10.8;EffectiveDate=2014-09-24;ExportCode=50507A4971S0;Notional=200000000;Name=IBK 제1335회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=현대차,우리금융;Tenor=3y;Observation period=6m;Trigger level=90/90/87.5/87.5/82.5/82.5;Knock In barrier=57.499;Coupon(p.a)=10.8;EffectiveDate=2014-09-24;ExportCode=50507A4969S0;Notional=200000000;Name=IBK 제1333회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=LS,우리금융;Tenor=3y;Observation period=6m;Trigger level=90/90/87.5/87.5/82.5/82.5;Knock In barrier=57.499;Coupon(p.a)=10.8;EffectiveDate=2014-09-24;ExportCode=50507A4965S0;Notional=300000000;Name=IBK 제1329회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=현대모비스,우리금융;Tenor=3y;Observation period=6m;Trigger level=90/90/87.5/87.5/82.5/82.5;Knock In barrier=57.499;Coupon(p.a)=10.8;EffectiveDate=2014-09-24;ExportCode=50507A4967S0;Notional=200000000;Name=IBK 제1331회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=현대모비스,우리금융;Tenor=3y;Observation period=6m;Trigger level=90/90/87.5/87.5/82.5/82.5;Knock In barrier=57.499;Coupon(p.a)=10.8;EffectiveDate=2014-09-24;ExportCode=50507A4968S0;Notional=200000000;Name=IBK 제1332회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=LS,SK이노베이션;Tenor=3y;Observation period=6m;Trigger level=90/90/87.5/87.5/82.5/82.5;Knock In barrier=57.499;Coupon(p.a)=10.8;EffectiveDate=2014-09-24;ExportCode=50507A4961S0;Notional=200000000;Name=IBK 제1325회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=LS,우리금융;Tenor=3y;Observation period=6m;Trigger level=90/90/87.5/87.5/82.5/82.5;Knock In barrier=57.499;Coupon(p.a)=11;EffectiveDate=2014-09-25;ExportCode=50507A4975S0;Notional=300000000;Name=IBK 제1336회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=LS,하나금융지주;Tenor=3y;Observation period=6m;Trigger level=90/90/87.5/87.5/82.5/82.5;Knock In barrier=57.499;Coupon(p.a)=10.2;EffectiveDate=2014-10-14;ExportCode=50507A4A27S0;Notional=200000000;Name=IBK 제1348회 사모ELS;",
                "Type=2 Stock Step Down Double Callable;Underlyings=LS,하나금융지주;Tenor=3y;Observation period=6m;Trigger level=90/90/87.5/87.5/82.5/82.5;Knock In barrier=57.499;Coupon(p.a)=10.2;EffectiveDate=2014-10-14;ExportCode=50507A4A28S0;Notional=100000000;Name=IBK 제1349회 사모ELS;"

            };

            foreach (var item in productStringList)
            {
                TradeString ts = new StepDownKI_TradeString();
                ts.parsingString(item);
                abm.addInstrument(ts);    
            }
            

        }

        private void serverCliTestBtn_Click(object sender, RoutedEventArgs e)
        {
            AsynchronousClient.StartClient();
        }

        private void serverStartTestBtn_Click(object sender, RoutedEventArgs e)
        {
            // process 존재 여부 확인.

            // 없으면 띄움.

            // 있으면 이미 존재 리턴.
            Process calcServerProcess = new Process();
            ProcessStartInfo psl = new ProcessStartInfo(@"D:\Project File\OTCDerivativesCalculatorModule\CalculationSocketServer\bin\Release\CalculationSocketServer.exe");

            psl.UseShellExecute = false;
            psl.RedirectStandardInput = true;
            psl.RedirectStandardOutput = true;
            psl.RedirectStandardError = true;
            psl.CreateNoWindow = true;

            calcServerProcess.StartInfo = psl;
            calcServerProcess.Start();

            //AsynchronousClient.StartClient();
        }


    }
}
