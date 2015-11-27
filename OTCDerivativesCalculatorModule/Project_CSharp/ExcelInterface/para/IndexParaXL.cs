using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using RiskMonitor;

namespace ExcelInterface
{
    public abstract class IndexParaXL
    {
        public abstract void buildXml();

        #region ViewModel_ 
		protected Underlying_paraViewModel viewModel_;
		public Underlying_paraViewModel ViewModel_ 
		{ 
			get { return this.viewModel_; }
			set
			{
			if (this.viewModel_ != value)
			{
				this.viewModel_ = value;
			}
			}
		}
		#endregion
    }
}
