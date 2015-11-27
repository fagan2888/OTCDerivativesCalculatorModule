using System;
using System.Windows.Controls;
using SampleApp.ViewModels;
using System.Windows;

namespace SampleApp
{
    public partial class DocumentOverviewPaneView : UserControl
    {
        public DocumentOverviewPaneView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Convenient accessor for the view-model.
        /// </summary>
        private DocumentOverviewPaneViewModel ViewModel
        {
            get
            {
                return (DocumentOverviewPaneViewModel)this.DataContext;
            }
        }
    }
}
