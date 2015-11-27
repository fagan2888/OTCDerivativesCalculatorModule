using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpCodeGen
{
    public class XsdBuiltInVariable
    {
        private string built_in_type;

        public XsdBuiltInVariable(string built_in_type) 
        {
            this.built_in_type = built_in_type;
            this.makeCode();
        }
        
        #region Code
        private string code;
        public string Code
        {
            get { return this.code; }
            set
            {
                if (this.code != value)
                {
                    this.code = value;
                }
            }
        }
        #endregion

        #region CName
        private string cName;
        public string CName
        {
            get { return this.cName; }
            set
            {
                if (this.cName != value)
                {
                    this.cName = value;
                   // this.RaisePropertyChanged("CName");
                }
            }
        }
        #endregion

        private void makeCode()
        {

            StringBuilder upperChange = new StringBuilder(built_in_type);
            upperChange[0] = built_in_type.ToUpper()[0];

            this.cName = "XsdType" + upperChange;
            GeneratorSimple gs = new GeneratorSimple(cName);
            code += gs.CsCode;
            code += "\r\n";
        }

        

    }
}
