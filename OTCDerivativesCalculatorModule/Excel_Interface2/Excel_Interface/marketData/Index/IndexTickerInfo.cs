using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class IndexTickerInfo
    {
        public string Name_ { get; set; }
        public string KrCode_ { get; set; }
        public string Yahoo_ticker_ { get; set; }
        public string Bloomberg_ticker_ { get; set; }
        public string Kap_ticker_ { get; set; }
        public string Kis_ticker_ { get; set; }
        public string Datasource_ { get; set; }
        public string Time_download_ { get; set; }
        public string Index_type_ { get; set; }

        public IndexTickerInfo()
        { 
        
        }

        public IndexTickerInfo(string name, string krcode, string yahoo_ticker, string bloomberg_ticker, string kap_ticker, string kis_ticker, string datasource, string time_download,string index_type)
        {
            // TODO: Complete member initialization
            this.Name_ = name;
            this.KrCode_ = krcode;
            this.Yahoo_ticker_ = yahoo_ticker;
            this.Bloomberg_ticker_ = bloomberg_ticker;
            this.Kap_ticker_ = kap_ticker;
            this.Kis_ticker_ = kis_ticker;
            this.Datasource_ = datasource;
            this.Time_download_ = time_download;
            this.Index_type_ = index_type;
        }
    }
}
