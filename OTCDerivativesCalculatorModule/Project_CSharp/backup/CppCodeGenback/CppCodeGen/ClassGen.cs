using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CppCodeGen
{
    public class ClassGen
    {
        public ClassGen() { }
        private DerivedClass m_DerivedClass;

        #region MemberVariable
        private List<Variable> memberVariable;
        public List<Variable> MemberVariable
        {
            get { return this.memberVariable; }
            set
            {
                if (this.memberVariable != value)
                {
                    this.memberVariable = value;
                    //this.RaisePropertyChanged("MemberVariable");
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
                    //this.RaisePropertyChanged("CName");
                }
            }
        }
        #endregion

        #region BaseName
        private string baseName;
        public string BaseName
        {
            get { return this.baseName; }
            set
            {
                if (this.baseName != value)
                {
                    this.baseName = value;
                    //this.RaisePropertyChanged("BaseName");
                }
            }
        }
        #endregion

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

        #region ConstructorCode
        private string constructorCode;
        public string ConstructorCode
        {
            get { return this.constructorCode; }
            set
            {
                if (this.constructorCode != value)
                {
                    this.constructorCode = value;
                }
            }
        }
        #endregion

        #region Path
        private string path;
        public string Path
        {
            get { return this.path; }
            set
            {
                if (this.path != value)
                {
                    this.path = value;
                    //this.RaisePropertyChanged("Path");
                }
            }
        }
        #endregion

        // Category subDirectory 가 만들어져서 거기에 들어감
        #region Category 
        private string category;
        public string Category
        {
            get { return this.category; }
            set
            {
                if (this.category != value)
                {
                    this.category = value;
                    //this.RaisePropertyChanged("Category");
                }
            }
        }
        #endregion

        private List<Constructor> m_Constructor;
        private List<MemberFunction> m_MemberFunction;

        public void makeCode()
        {
            this.includeGen();

            string baseClass = "";
            if (this.baseName != null) 
            {
                baseClass += " : public " + baseName;
            }

            Code += "class " + cName + baseClass +" { \r\n";
            Code += "   public: \r\n";

            this.ConstructorGen();

            Code += constructorCode + "       {\r\n";

            foreach (Variable item in memberVariable)
            {
                Code += item.XmlParsingCode;
                Code += "\r\n";
            }

            Code += "       }";

            Code += "\r\n";

            //foreach (Constructor item in m_Constructor)
            //{
            //    Code += item.getDeclareCode();    
            //}

            Code += "   protected: \r\n";

            foreach (Variable item in MemberVariable)
            {
                Code += "       ";
                Code += item.getParametor();
                Code += "\r\n";
            }
            //foreach (MemberFunction item in m_MemberFunction)
            //{
            //    Code += item.getDeclareCode();
            //}

            Code += "};\r\n";
            Code += "#endif\r\n";

        }

        private void includeGen() 
        {
            Code += "// " + cName + ".hpp \r\n";
            Code += "#ifndef CppCodeGen_" + cName + "_hpp\r\n";
            Code += "#define CppCodeGen_" + cName + "_hpp\r\n";
            Code += "\r\n";
            //foreach (var item in collection)
            //{
            //    Code += "#inlucde <" + path;    
            //}
        }

        private void ConstructorGen() 
        {
            constructorCode += "       " + cName + "(TiXmlNode* xmlNode)\r\n";
            
        }


 
    }
}
