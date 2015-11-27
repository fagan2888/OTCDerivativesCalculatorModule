﻿using System;
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

namespace Excel_Interface
{
    /// <summary>
    /// Excel_creditEventInfoView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_creditEventInfoView : UserControl
    {
        #region ViewModel_
        private Excel_creditEventInfoViewModel viewModel_;
        public Excel_creditEventInfoViewModel ViewModel_
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

        public Excel_creditEventInfoView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Excel_creditEventInfoViewModel;

            this.swapIssueInfoGrid_.Children.Clear();
            this.swapIssueInfoGrid_.Children.Add(this.viewModel_.Excel_issueInfoViewModel_.view());

            this.jointInfoGrid_.Children.Clear();
            this.jointInfoGrid_.Children.Add(this.viewModel_.Excel_jointProbabilityTraitViewModel_.view());

            this.referenceListGrid_.Children.Clear();
            this.referenceListGrid_.Children.Add(this.viewModel_.Excel_referenceInformationListViewModel_.view());

            this.protectionGrid_.Children.Clear();
            this.protectionGrid_.Children.Add(this.viewModel_.Excel_protectionTermsViewModel_.view());
        }
    }
}