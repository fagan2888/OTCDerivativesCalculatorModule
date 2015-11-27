using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XmlBuilder.DataModel
{
    public class IndexData : IData
    {
        private string name_;
        private string code_;

        public IndexData(string name, string code)
        {
            // TODO: Complete member initialization
            this.name_ = name;
            this.code_ = code;
        }
    }
}
