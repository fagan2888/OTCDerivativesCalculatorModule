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
    /// OTCApplilcationEventView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class OTCApplicationEventView : UserControl
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
                    //this.referenceDateDatePicker_.SelectedDate = value;
                    //this.referenceDateDatePicker_.DisplayDate = value;
                    //this.NotifyPropertyChanged("ReferenceDate_");
                }
            }
        }
        #endregion

        #region ViewModel_
        private OTCApplicationEventViewModel viewModel_;
        public OTCApplicationEventViewModel ViewModel_
        {
            get { return this.viewModel_; }
            set
            {
                if (this.viewModel_ != value)
                {
                    this.viewModel_ = value;
                    //this.NotifyPropertyChanged("ViewModel_");
                }
            }
        }
        #endregion

        private void rootBookViewModelReload()
        {
            this.RootBookViewModel_ = null;
            this.RootFavoriteViewModel_ = null;

            RootBookViewModel.setRootBookReferenceDate(this.referenceDate_);

            RootBookViewModel root_bvm = new RootBookViewModel();

            root_bvm.loadPosition();

            RootFavoriteViewModel root_fvm = new RootFavoriteViewModel();

            root_fvm.loadPosition();

            this.RootBookViewModel_ = root_bvm;
            this.RootBookViewModelChanged();

            this.RootFavoriteViewModel_ = root_fvm;
            this.RootFavoriteViewModelChanged();
        }

        public OTCApplicationEventView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);

        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (this.DataContext != null)
            {
                this.viewModel_ = this.DataContext as OTCApplicationEventViewModel;

                
            }
        }

        private void favoritesListView_MouseUp(object sender, MouseButtonEventArgs e)
        {

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

        public void positionXmlReload()
        {
            this.rootBookViewModelReload();
        }

        private void RootBookViewModelChanged()
        {
            // 걍 북 folder 가 로드 댈때 master까지 죄다 로드함..
            // xml 에 있는 정보만 밖혀있어서 data 검색할때 좀 그럼..
            // detail vm까지 로드할지는 아직 미정 2014-05-14

            //this.rootBookViewModel_.loadChildBookMasterInfo();
            this.bookFolderTreeView_.ItemsSource = this.rootBookViewModel_.ChildBookList_;
            //this.bookFolderTreeView_.DataContext = this.rootBookViewModel_.AncestorBookViewModel_;
        }

        private void RootFavoriteViewModelChanged()
        {
            //FavoriteViewModel unclassified_fvm = this.unclassified_listViewItem_.DataContext as FavoriteViewModel;

            this.favoritesListView_.ItemsSource = this.rootFavoriteViewModel_.FavoriteList_;
        }

        private void bookFolderTreeView_MouseUp(object sender, MouseButtonEventArgs e)
        {
            // 중복 선택의 경우 다시 로드 안하는 코드

            if (bookFolderTreeView_.SelectedItem == null)
                return; // return if there's no row selected

            BookViewModel bvm = this.bookFolderTreeView_.SelectedItem as BookViewModel;

            //현재 List에 있는 상품들에 대해서 eventList를 가져옴.
            //bvm.loadMasterInformation();
            //bvm.refreshInstrument();
            ObservableCollection<EventViewModel> e_vmList = new ObservableCollection<EventViewModel>();

            //EventViewModel e1 = new EventViewModel();
            
            //e_vmList.Add(new EventViewModel());
            //e_vmList.Add(new EventViewModel());

            bvm.getEventList(e_vmList,false);

            this.eventListListView_.ItemsSource = e_vmList;

            selectedFolder_ = bvm;
            selectedViewModel_ = this.rootBookViewModel_;

            //this.rootBookViewModel_.clearSelection();
            //this.bookFolderTreeView_.Items.Refresh();

            // do something with the Selected row here
        }

        private void bookProperty_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NCRPosition_Click(object sender, RoutedEventArgs e)
        {

        }

        private void eventListListView_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void eventListListView_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void eventListListView__SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AllButton_Click(object sender, RoutedEventArgs e)
        {
            this.eventListListView_.ItemsSource = OTCApplicationEventViewModel.WholeEventViewModel_;
            this.eventListListView_.Items.Refresh();
        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            Calendar cal = sender as Calendar;

            SelectedDatesCollection col = cal.SelectedDates;

            this.viewModel_.reloadEventViewModel(col);

            this.eventListListView_.ItemsSource = this.viewModel_.BindingEventViewModel_;
            //this.eventListListView_.Items.Refresh();

            
            //this.viewModel_.

        }
    }
}
