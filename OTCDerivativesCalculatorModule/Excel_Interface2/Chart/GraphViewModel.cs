using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace Excel_Interface
{
    public class GraphViewModel
    {
        public enum type
        { 
            Line
        };

        #region XData_
        private List<double> xData_;
        public List<double> XData_
        {
            get { return this.xData_; }
            set
            {
                if (this.xData_ != value)
                {
                    this.xData_ = value;
                    //this.NotifyPropertyChanged("XData_");
                }
            }
        }
        #endregion

        #region YData_
        private List<double> yData_;
        public List<double> YData_
        {
            get { return this.yData_; }
            set
            {
                if (this.yData_ != value)
                {
                    this.yData_ = value;
                    //this.NotifyPropertyChanged("YData_");
                }
            }
        }
        #endregion

        public GraphViewModel()
        { 
        
        }

        public Control view()
        {
            Control v = new GraphView();

            v.DataContext = this;

            return v;

        }



    }
}
