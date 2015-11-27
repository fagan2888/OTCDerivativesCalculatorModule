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

namespace RiskMonitor
{
    /// <summary>
    /// MatrixView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MatrixView : UserControl
    {

        #region MatrixViewModel_
        private MatrixViewModel matrixViewModel_;
        public MatrixViewModel MatrixViewModel_
        {
            get { return this.matrixViewModel_; }
            set
            {
                if (this.matrixViewModel_ != value)
                {
                    this.matrixViewModel_ = value;
                    this.buildMatrix();
                    this.NotifyPropertyChanged("MatrixViewModel_");
                }
            }
        }
        #endregion

        public MatrixView()
        {
            InitializeComponent();
        }

        private void buildMatrix() 
        {
            int dim = this.matrixViewModel_.Dimension_;


            #region BuildMatrixGrid

            for (int row = 0; row < dim; row++)
            {
                this.MatrixGrid_.RowDefinitions.Add(new RowDefinition());

                for (int col = 0; col < dim; col++)
                {
                    this.MatrixGrid_.ColumnDefinitions.Add(new ColumnDefinition());
                }
            }

            #endregion

            #region SetValue
            
            for (int row = 0; row < dim; row++)
            {
                for (int col = 0; col < dim; col++)
                {
                    Label label = new Label();
                    label.Content = this.matrixViewModel_[row,col];
                    Grid.SetRow(label, row);
                    Grid.SetColumn(label, col);
                    this.MatrixGrid_.Children.Add(label);
                }
            }

            #endregion

        }

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
