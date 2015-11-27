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


namespace Excel_Interface
{
    /// <summary>
    /// BookFolderView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class BookFolderView : UserControl
    {
        #region ReferenceDate_
        private DateTime referenceDate_;
        public DateTime ReferenceDate_
        {
            get { return this.referenceDate_; }
            set
            {
                if (this.referenceDate_ != value)
                {
                    this.referenceDate_ = value;
                    this.referenceDateDatePicker_.SelectedDate = value;
                    this.referenceDateDatePicker_.DisplayDate = value;
                    //this.NotifyPropertyChanged("ReferenceDate_");
                }
            }
        }
        #endregion

        private void rootBookViewModelReload()
        {
            this.RootBookViewModel_ = null;
            this.RootFavoriteViewModel_ = null;

            RootBookViewModel.setRootBookReferenceDate(ProgramVariable.ReferenceDate_);
            //RootBookViewModel.setRootBookReferenceDate(this.referenceDate_);

            RootBookViewModel root_bvm = new RootBookViewModel();

            root_bvm.loadPosition();

            RootFavoriteViewModel root_fvm = new RootFavoriteViewModel();

            root_fvm.loadPosition();

            this.RootBookViewModel_ = root_bvm;
            this.RootBookViewModelChanged();

            this.RootFavoriteViewModel_ = root_fvm;
            this.RootFavoriteViewModelChanged();
        }

        #region RootFavoriteViewModel_
        private RootFavoriteViewModel rootFavoriteViewModel_;
        public RootFavoriteViewModel RootFavoriteViewModel_
        {
            get { return this.rootFavoriteViewModel_; }
            set
            {
                if (this.rootFavoriteViewModel_ != value)
                {
                    this.rootFavoriteViewModel_ = value;
                    
                }
            }
        }
        #endregion

        #region RootBookViewModel_
        private RootBookViewModel rootBookViewModel_;
        public RootBookViewModel RootBookViewModel_
        {
            get { return this.rootBookViewModel_; }
            set
            {
                if (this.rootBookViewModel_ != value)
                {
                    this.rootBookViewModel_ = value;
                    
                }
            }
        }
        #endregion

        private IFolderAction selectedFolder_;
        private IFileAction selectedViewModel_;

        public BookFolderView()
        {
            InitializeComponent();
            //this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);

            outPutLogGrid_.Children.Add(new OutputLogView());

            this.Unloaded += new RoutedEventHandler(BookFolderView_Unloaded);
        }

        public void positionXmlReload()
        {
            this.rootBookViewModelReload();
        }

        private void BookFolderView_Unloaded(object sender, RoutedEventArgs e)
        {
            this.rootFavoriteViewModel_.saveXml();
            this.rootBookViewModel_.saveXml();
        }

        private void RootBookViewModelChanged()
        {
            // 걍 북 folder 가 로드 댈때 master까지 죄다 로드함..
            // xml 에 있는 정보만 밖혀있어서 data 검색할때 좀 그럼..
            // detail vm까지 로드할지는 아직 미정 2014-05-14

            this.rootBookViewModel_.loadChildBookMasterInfo();
            this.bookFolderTreeView_.ItemsSource = this.rootBookViewModel_.ChildBookList_;
            //this.bookFolderTreeView_.DataContext = this.rootBookViewModel_.AncestorBookViewModel_;
        }

        private void RootFavoriteViewModelChanged()
        {
            //FavoriteViewModel unclassified_fvm = this.unclassified_listViewItem_.DataContext as FavoriteViewModel;

            this.favoritesListView_.ItemsSource = this.rootFavoriteViewModel_.FavoriteList_;
        }

        //private void loadBookItemList()
        //{ 
        //    // selected book

        //    // load item in book

        //    BookViewModel bvm = new BookViewModel();

        //    //bvm.addTestInstrumentLoad();

        //    this.instrumentListListView_.ItemsSource = bvm.InstrumentList_;
        //}

        //private void TreeViewItem_Selected(object sender, RoutedEventArgs e)
        //{

        //}

        #region MenuEvent

        private void menuBookingItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem mi = e.Source as MenuItem;

            switch (mi.Name.ToUpper())
            {
                case "FIXEDBOND":
                { //do something;
                    Excel_instrumentViewModel e_instVM = new Excel_instrument_fixedBondViewModel(true);
                    this.menuBooking(e_instVM);
                    break;
                }

                case "IRS":
                { //do something;
                    Excel_instrumentViewModel e_instVM = new Excel_instrument_irsViewModel(true);
                    this.menuBooking(e_instVM);
                    break;
                }

                case "CRS":
                { //do something;
                    Excel_instrumentViewModel e_instVM = new Excel_instrument_crsViewModel(true);
                    this.menuBooking(e_instVM);
                    break;
                }

                case "CDS":
                { //do something;
                    Excel_instrumentViewModel e_instVM = new Excel_instrument_cdsViewModel(true);
                    this.menuBooking(e_instVM);
                    break;
                }

                case "TWO":
                { //do something else
                    Excel_instrumentViewModel e_instVM = new Excel_instrument_hifiveViewModel(true);
                    this.menuBooking(e_instVM);
                    break;
                }

                case "HIFIVE":
                { //something else again
                    Excel_instrumentViewModel e_instVM = new Excel_instrument_hifiveViewModel(true);

                    this.menuBooking(e_instVM);
                    break;
                }

                case "STEPDOWN2":
                { //something else again
                    Excel_instrumentViewModel e_instVM = new Excel_instrument_stepDownKICustomViewModel(true);

                    this.menuBooking(e_instVM);
                    break;
                }

                case "COMPOSITEOPTION":
                { //something else again
                    Excel_instrumentViewModel e_instVM = new Excel_instrument_compositeOptionViewModel(true);

                    this.menuBooking(e_instVM);
                    break;
                }
                case "MULTIASSETCOMPOSITEOPTION":
                { //something else again
                    Excel_instrumentViewModel e_instVM = new Excel_instrument_multiAssetCompositeOptionViewModel(true);

                    this.menuBooking(e_instVM);
                    break;
                }
                case "GENERAL":
                { //something else again
                    Excel_instrumentViewModel e_instVM = new Excel_instrument_generalViewModel(true);

                    this.menuBooking(e_instVM);
                    break;
                }
                case "VANILLAFLOATINGBOND":
                { //something else again
                    Excel_instrumentViewModel e_instVM = new Excel_instrument_vanillaFloatingBondViewModel(true);

                    this.menuBooking(e_instVM);
                    break;
                }
                case "FXFORWARD":
                { //something else again
                    Excel_instrumentViewModel e_instVM = new Excel_instrument_fxForwardViewModel(true);

                    this.menuBooking(e_instVM);
                    break;
                }
                case "FXSWAP":
                { //something else again
                    Excel_instrumentViewModel e_instVM = new Excel_instrument_fxSwapViewModel(true);

                    this.menuBooking(e_instVM);
                    break;
                }
                case "FXEXCHANGE":
                { //something else again
                    Excel_instrumentViewModel e_instVM = new Excel_instrument_fxSpotViewModel(true);

                    this.menuBooking(e_instVM);
                    break;
                }

            }

            
        }

        //private void fixedBondButton_Click(object sender, RoutedEventArgs e)
        //{
        //    Excel_instrumentViewModel e_instVM = new Excel_instrument_fixedBondViewModel(true);
        //    this.menuBooking(e_instVM);
            
        //}

        //private void elsStepDownKIButton_Click(object sender, RoutedEventArgs e)
        //{
        //    Excel_instrumentViewModel e_instVM = new Excel_instrument_hifiveViewModel(true);

        //    this.menuBooking(e_instVM);
        //}

        //private void elsStepDownKICustomButton_Click(object sender, RoutedEventArgs e)
        //{
        //    Excel_instrumentViewModel e_instVM = new Excel_instrument_stepDownKICustomViewModel(true);

        //    this.menuBooking(e_instVM);
        //}

        //private void compositeOptionButton_Click(object sender, RoutedEventArgs e)
        //{
        //    Excel_instrumentViewModel e_instVM = new Excel_instrument_compositeOptionViewModel(true);

        //    this.menuBooking(e_instVM);
        //}

        //private void makeInstButton_Click(object sender, RoutedEventArgs e)
        //{
        //    Excel_instrumentViewModel e_instVM = new Excel_instrument_generalViewModel(true);

        //    this.menuBooking(e_instVM);

        //}


        //private void vanillaFloatingBondButton_Click(object sender, RoutedEventArgs e)
        //{

        //}

        //private void etcFloatingBondButton_Click(object sender, RoutedEventArgs e)
        //{

        //}

        private void menuBooking(Excel_instrumentViewModel e_instVM)
        {
            Window w = new Window();
            w.Width = 400;
            w.Height = 400;
            w.Content = e_instVM.view(true);

            e_instVM.linkEventPass();

            w.Visibility = 0;

            // booking button 눌리면
            if (w.ShowDialog() == true)
            {
                // master db에 박고
                // file 저장하고
                e_instVM.bookingInstrument(); // db에 박음.
                
                XMLFileLoader.SaveInstrument(e_instVM);

                MasterInformationViewModel.WholeMasterPosition_.Add(e_instVM);
                // 우선은 미분류로 보냄
                // favoriteViewModel에 instrument List 에 더하고
                this.rootFavoriteViewModel_.UnClassifiedFavoriteViewModel_.AddInstrument(e_instVM);

                ////이놈은 상품 xml 저장이 아니고 favor xml 저장
                this.rootFavoriteViewModel_.saveXml();

                //unclassified_fvm.InstrumentList_.Add(e_instVM);

                // menu booking의 경우 refDate기준으로 임시 파라메터를 만들어줌.

                e_instVM.buildParameterFromInstrument(ProgramVariable.ReferenceDate_);

                XMLFileLoader.SaveParameter(e_instVM.Excel_parameterViewModel_);
                XMLFileLoader.SaveHistoryData(e_instVM);
            }
            else
            {

            }
            
        }

        #endregion

        private void typeSettingButton_Click(object sender, RoutedEventArgs e)
        {

        }

        //private void bookFolderTreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        //{
        //    if (this.bookFolderTreeView_.SelectedItem != null)
        //    {
        //        BookViewModel bvm = this.bookFolderTreeView_.SelectedItem as BookViewModel;

        //        this.instrumentListListView_.ItemsSource = bvm.InstrumentList_;

        //        selectedFolder_ = bvm;
        //        selectedViewModel_ = this.rootBookViewModel_;
        //        favoritesListView_.SelectedItem = null;
        //    }
        //}

        //private void favoritesListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    if (this.favoritesListView_.SelectedItem != null)
        //    {
        //        FavoriteViewModel fvm = this.favoritesListView_.SelectedItem as FavoriteViewModel;

        //        this.instrumentListListView_.ItemsSource = fvm.InstrumentList_;

        //        selectedFolder_ = fvm;
        //    }
        //    //selectedViewModel_ = this.rootFavoriteViewModel_;
        //}

        private void bookFolderTreeView_MouseUp(object sender, RoutedEventArgs e)
        {
            // 중복 선택의 경우 다시 로드 안하는 코드

            if (bookFolderTreeView_.SelectedItem == null)
                return; // return if there's no row selected

            BookViewModel bvm = this.bookFolderTreeView_.SelectedItem as BookViewModel;

            //현재 List에 있는 상품들에 대해서 Master를 로드함.
            bvm.loadMasterInformation();
            //bvm.refreshInstrument();
            
            this.instrumentListListView_.ItemsSource = bvm.InstrumentList_;

            selectedFolder_ = bvm;
            selectedViewModel_ = this.rootBookViewModel_;

            //this.rootBookViewModel_.clearSelection();
            //this.bookFolderTreeView_.Items.Refresh();

            // do something with the Selected row here
        }

        private void favoritesListView_MouseUp(object sender, RoutedEventArgs e)
        {
            if (favoritesListView_.SelectedItem == null)
                return; // return if there's no row selected

            FavoriteViewModel fvm = this.favoritesListView_.SelectedItem as FavoriteViewModel;

            //현재 List에 있는 상품들에 대해서 Master를 로드함.
            fvm.loadMasterInformation();

            this.instrumentListListView_.ItemsSource = fvm.InstrumentList_;

            selectedFolder_ = fvm;
            selectedViewModel_ = this.rootFavoriteViewModel_;

            // do something with the Selected row here
        }

        // delete key event가 아니고 이거로 해도 대나...ㅡ.ㅡ;;
        //Occurs when a ListViewRow object becomes available for reuse.
        //private void instrumentListListView__UnloadingRow(object sender, ListViewRowEventArgs e)
        //{

        //}

        private void instrumentListListView__PreviewKeyDown(object sender, KeyEventArgs e)
        {
            Excel_instrumentViewModel e_ivm = ((ListView)sender).SelectedItem as Excel_instrumentViewModel;

            if (Key.Delete == e.Key && e_ivm != null)
            {
                int selectionCount = ((ListView)sender).SelectedIndex;

                //bool fileEdited = selectedFolder_.removeInstrument(e_ivm);
                bool fileEdited = false;

                bool masterEdited = selectedFolder_.removeInstrument(e_ivm);

                MasterFavoriteViewModel vm = this.selectedFolder_ as MasterFavoriteViewModel;
                
                if (vm != null)
                { 
                    // masterfavor이면 rookbook에서 지워야함.
                    fileEdited = rootBookViewModel_.removeInstrument(e_ivm);
                }

                if (fileEdited)
                {
                    this.selectedViewModel_.saveXml();
                }

                e_ivm.Excel_eventManagerViewModel_.deleteEvent();

                this.instrumentListListView_.Items.Refresh();
                ((ListView)sender).SelectedIndex = selectionCount;


            }

            //((ListView)sender).SelectionMode

            //e.Handled = true;
        }

        private void instrumentListListView__PreviewKeyUp(object sender, KeyEventArgs e)
        {

            if (Key.Down == e.Key || Key.Up == e.Key )
            {
                Excel_instrumentViewModel e_inst = ((ListView)sender).SelectedItem as Excel_instrumentViewModel;
                this.loadInstrumentList(e_inst);
            }
        }

        private void instrumentListListView_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            ListView listView = sender as ListView;
            
            if (listView != null && e.LeftButton == MouseButtonState.Pressed)
            {
                double distance = 0.0;

                if (distance < 0.1)
                {
                    if (instrumentListListView_.SelectedItems.Count > 0)
                    {
                        //
                        DataObject dataObj = new DataObject(instrumentListListView_.SelectedItem);
                        DataObject dragData = new DataObject("e_instrument", instrumentListListView_.SelectedItem);

                        DragDrop.DoDragDrop(instrumentListListView_,
                                             dragData,
                                             DragDropEffects.Copy);
                    }
                }
            }

            //{
            //    DragDrop.DoDragDrop(ellipse,
            //                         ellipse.Fill.ToString(),
            //                         DragDropEffects.Copy);
            //}
        }

        private void instrumentListListView_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // pointer를 저장
            
            //Point p = e.GetPosition();
        }

        private void instrumentListListView_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Excel_instrumentViewModel e_inst = ((ListView)sender).SelectedItem as Excel_instrumentViewModel;

            if (e_inst != null && e_inst.Trade_id_ != null)
            {
                this.loadInstrumentList(e_inst);
            }
        }

        private void loadInstrumentList(Excel_instrumentViewModel e_inst)
        {
            //bold로 표시한거 푸는것
            this.rootBookViewModel_.clearSelection();

            if (e_inst != null)
            {
                try
                {
                    e_inst.loadDetailContext();

                    //this.rootBookViewModel_.clearSelection();
                    this.rootBookViewModel_.hasTradeInstrument(e_inst.Trade_id_);

                    this.detailContentsGrid_.Children.Clear();
                    //e_inst.View_.UpdateLayout();
                    e_inst.dataContextRefesh();
                    this.detailContentsGrid_.Children.Add(e_inst.view(false));

                    this.bookFolderTreeView_.Items.Refresh();

                }
                catch (Exception e)
                {
                    OutputLogViewModel.addResult(e.Message);
                    //throw;
                }
                


            }
        }

        #region Favorite DragAndDrop EventHandler

        private void FavoriteTextBlock_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void FavoriteTextBlock_DragOver(object sender, DragEventArgs e)
        {

        }

        private void FavoriteTextBlock_Drop(object sender, DragEventArgs e)
        {
            TextBlock txb = sender as TextBlock;
            FavoriteViewModel fvm = txb.DataContext as FavoriteViewModel;

            Excel_instrumentViewModel e_ivm = e.Data.GetData("e_instrument") as Excel_instrumentViewModel;

            fvm.AddInstrument(e_ivm);
        }

        #endregion

        #region BookFolder DragAndDrop EventHandler

        private void bookFolderTextBlock_DragEnter(object sender, DragEventArgs e)
        {
            // if abstract 이면 펼쳐 //time을 찍고 얼마 이상이면 펼쳐
        }

        private void bookFolderTextBlock_DragOver(object sender, DragEventArgs e)
        {


        }

        private void bookFolderTextBlock_Drop(object sender, DragEventArgs e)
        {
            //check

            TextBlock txb = sender as TextBlock;
            BookViewModel bvm = txb.DataContext as BookViewModel;

            Excel_instrumentViewModel e_ivm = e.Data.GetData("e_instrument") as Excel_instrumentViewModel;

            bvm.AddInstrument(e_ivm);

            this.rootBookViewModel_.saveXml();
        }

        #endregion

        #region Context Menu Event

        private void changeFavoriteName_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bookProperty_Click(object sender, RoutedEventArgs e)
        {
            BookViewModel bvm = this.bookFolderTreeView_.SelectedItem as BookViewModel;

            BookPropertyViewModel vpbm = new BookPropertyViewModel();
            vpbm.BookViewModel_ = bvm.clone();

            Window w = new Window();
            w.Width = 400;
            w.Height = 300;
            w.Content = vpbm.view();
            w.Visibility = 0;

            // booking button 눌리면
            if (w.ShowDialog() == true)
            {
                bvm.bookInfoCopy(vpbm.BookViewModel_);
                // xml 수정함
                bvm.updateBookInfo();

                this.rootBookViewModel_.saveXml();

                this.bookFolderTreeView_.Items.Refresh();
            }
            else
            {

            }
        }

        //private void NCRPosition_Click(object sender, RoutedEventArgs e)
        //{
        //    BookViewModel bvm = this.bookFolderTreeView_.SelectedItem as BookViewModel;

        //    DeltaHedgeMonitorViewModel dhmvm = new DeltaHedgeMonitorViewModel();

        //    dhmvm.setInstrumentList(bvm.InstrumentList_);

        //    //dhmv.BookViewModel_ = bvm.clone();

        //    Window w = new Window();
        //    w.Width = 400;
        //    w.Height = 300;
        //    w.Content = dhmvm.view();
        //    w.Visibility = 0;

        //}

        private void addFavorite_Click(object sender, RoutedEventArgs e)
        {

        }

        private void addBook_Click(object sender, RoutedEventArgs e)
        {
            BookViewModel bvm = this.bookFolderTreeView_.SelectedItem as BookViewModel;

            bvm.addBook("testBook");

            this.rootBookViewModel_.saveXml();

        }

        #endregion

        private void bookFolderTextBlock_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock txb = sender as TextBlock;
            BookViewModel bvm = txb.DataContext as BookViewModel;

        }

        private void bookFolderTreeView_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            BookViewModel bvm = ((TreeView)sender).SelectedItem as BookViewModel;

            if (Key.Delete == e.Key)
            {

                bvm.removeThisBook();
                //int selectionCount = ((ListView)sender).SelectedIndex;

                //bool fileEdited = selectedFolder_.removeInstrument(e_ivm);

                //MasterFavoriteViewModel vm = this.selectedFolder_ as MasterFavoriteViewModel;

                //if (vm != null)
                //{
                //    // 싹다 지워
                //}

                //if (fileEdited)
                //{
                //    this.selectedViewModel_.saveXml();
                //}


                //this.bookFolderTreeView_.Items.Refresh();
                //((ListView)sender).SelectedIndex = selectionCount;

                this.rootBookViewModel_.saveXml();
            }
        }

        private void groupMake_Click(object sender, RoutedEventArgs e)
        {
            BookViewModel bvm = this.bookFolderTreeView_.SelectedItem as BookViewModel;

            foreach (var item in this.instrumentListListView_.SelectedItems)
	        {
                Excel_instrumentViewModel e_ivm = item as Excel_instrumentViewModel;

	        } 
        }

        private void instrumentListListView__SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //double nowTime = DateTime.Now.Millisecond;

            //double gap = nowTime - this.preTime_;
            //this.preTime_ = nowTime;

            //if (gap < 100)
            //{
            //    return;
            //}

            //Excel_instrumentViewModel e_inst = this.instrumentListListView_.SelectedItem as Excel_instrumentViewModel;
            
            //this.rootBookViewModel_.clearSelection();

            //if (e_inst != null)
            //{
            //    e_inst.loadDetailContext();

            //    //this.rootBookViewModel_.clearSelection();
            //    this.rootBookViewModel_.hasTradeInstrument(e_inst.TradeID_);

            //    this.detailContentsGrid_.Children.Clear();
            //    //e_inst.View_.UpdateLayout();
            //    e_inst.dataContextRefesh();
            //    this.detailContentsGrid_.Children.Add(e_inst.View_);

            //    this.bookFolderTreeView_.Items.Refresh();

            //}
        }

        private void PositionReloadBtn_Click(object sender, RoutedEventArgs e)
        {
            ProgramVariable.ReferenceDate_ = this.referenceDateDatePicker_.SelectedDate.Value;
            this.rootBookViewModelReload();
        }

        private void parameterBuildButton_Click(object sender, RoutedEventArgs e)
        {
            DataInterfaceManager dim = new DataInterfaceManager();

            dim.generateParaXml(ProgramVariable.ReferenceDate_);
        }

    }
}
