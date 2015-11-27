using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLNet;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Xml;

namespace RiskMonitor
{
    public class MatrixViewModel
    {
        public int Dimension_ { get; set; }
        private Matrix matrix_;

        public MatrixViewModel() 
        {
            this.matrix_ = new Matrix(2, 2, 0.5);
        }

        public void loadFromXml(XmlNode node) 
        {
            Matrix matrix = new Matrix();

            #region BuildMatrix
            
            #endregion

            this.matrix_ = matrix;
        }

        public double this[int i, int j]
        {
            get { return this.matrix_[i, j]; }
            set { this.matrix_[i, j] = value; }
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
