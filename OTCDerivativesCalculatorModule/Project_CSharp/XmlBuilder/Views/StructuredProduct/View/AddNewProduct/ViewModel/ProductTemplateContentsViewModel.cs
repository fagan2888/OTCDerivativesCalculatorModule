using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace XmlBuilder.Views.StructuredProduct.View.AddNewProduct.ViewModel
{
    public class ProductTemplateContentsViewModel
    {
        // Data 위치 및 어쩌구

        public ProductTemplateContentsViewModel() 
        {
            




        }

        #region ProductTemplate_
        private ObservableCollection<ProductTemplate> productTemplate_;
        public ObservableCollection<ProductTemplate> ProductTemplate_
        {
            get { return this.productTemplate_; }
            set
            {
                if (this.productTemplate_ != value)
                {
                    this.productTemplate_ = value;
                    this.NotifyPropertyChanged("ProductTemplate_");
                }
            }
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
