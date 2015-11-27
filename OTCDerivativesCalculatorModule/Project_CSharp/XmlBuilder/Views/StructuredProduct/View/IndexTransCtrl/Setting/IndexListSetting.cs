using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace XmlBuilder.Views.StructuredProduct.View.IndexTransCtrl.Setting
{
    public class IndexListSetting
    {
        public IndexListSetting() 
        {
            this.initialize();
        }

        private void initialize() 
        {
            IndexListStr_ = new List<string>();
            IndexListStr_.Add("Return");
            IndexListStr_.Add("Minimum");
            //indexListStr_.Add("");
            //indexListStr_.Add("");
            //indexListStr_.Add("");
            //indexListStr_.Add("");

        }

        public List<string> IndexListStr_ {get; set; }

    }
}
