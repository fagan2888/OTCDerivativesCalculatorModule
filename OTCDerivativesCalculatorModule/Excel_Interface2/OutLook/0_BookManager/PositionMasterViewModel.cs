using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class PositionMasterViewModel : SubViewModel
    {

        public PositionMasterViewModel()
        { 
        
        }

        #region PositionMasterToolBarViewModel_
        private PositionMasterToolBarViewModel positionMasterToolBarViewModel_;
        public PositionMasterToolBarViewModel PositionMasterToolBarViewModel_
        {
            get { return this.positionMasterToolBarViewModel_; }
            set
            {
                if (this.positionMasterToolBarViewModel_ != value)
                {
                    this.positionMasterToolBarViewModel_ = value;
                    this.NotifyPropertyChanged("PositionMasterToolBarViewModel_");
                }
            }
        }
        #endregion

        #region FavoriteViewModel_
        private FavoriteViewModel favoriteViewModel;
        public FavoriteViewModel FavoriteViewModel_
        {
            get { return this.favoriteViewModel; }
            set
            {
                if (this.favoriteViewModel != value)
                {
                    this.favoriteViewModel = value;
                    this.NotifyPropertyChanged("FavoriteViewModel_");
                }
            }
        }
        #endregion

        #region FolderViewModel_
        private FolderViewModel folderViewModel_;
        public FolderViewModel FolderViewModel_
        {
            get { return this.folderViewModel_; }
            set
            {
                if (this.folderViewModel_ != value)
                {
                    this.folderViewModel_ = value;
                    this.NotifyPropertyChanged("FolderViewModel_");
                }
            }
        }
        #endregion

        #region InstrumentViewModelList_
        private ObservableCollection<Excel_instrumentViewModel> instrumentViewModelList;
        public ObservableCollection<Excel_instrumentViewModel> InstrumentViewModelList_
        {
            get { return this.instrumentViewModelList; }
            set
            {
                if (this.instrumentViewModelList != value)
                {
                    this.instrumentViewModelList = value;
                    this.NotifyPropertyChanged("InstrumentViewModelList_");
                }
            }
        }
        #endregion

        

        #region Event

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

    }
}
