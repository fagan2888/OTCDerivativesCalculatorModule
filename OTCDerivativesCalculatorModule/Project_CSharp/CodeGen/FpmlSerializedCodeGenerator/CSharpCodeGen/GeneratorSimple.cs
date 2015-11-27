using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Schema;

namespace CSharpCodeGen
{
    
    public class GeneratorSimple
    {
        private string m_varName = "valueStr";
        private string m_varType = "string";

        public GeneratorSimple(XmlSchemaSimpleType xsSimType) 
        {
            this.setXsd(xsSimType.Name);
            
        }

        public GeneratorSimple(string xsSimName)
        {
            this.setXsd(xsSimName);
        }

        private ClassGen m_ClassGen = new ClassGen();

        private List<Variable> m_MemberVariable = new List<Variable>();
        
        public string CName { get; set; }

        #region CsCode
        private string csCode;
        public string CsCode
        {
            get { return this.csCode; }
            set
            {
                if (this.csCode != value)
                {
                    this.csCode = value;
                    //this.RaisePropertyChanged("Code");
                }
            }
        }
        #endregion


        private void setXsd(string xsSimName)
        {

            CName = xsSimName;

            StringBuilder sb = new StringBuilder();


            sb.AppendLine(this.UsingGen());
            sb.AppendLine("namespace FpmlSerializedCSharp");
            //sb.AppendLine("namespace RiskMonitor");
            sb.AppendLine("{");
            sb.AppendLine("    public class " + CName + " : ISerialized");
            sb.AppendLine("    {");
            sb.AppendLine(Wrapper.TapCode(this.ConstructorCode()));
            sb.AppendLine();
            sb.AppendLine(Wrapper.TapCode(this.setGetterCode()));
            sb.AppendLine();
            sb.AppendLine(Wrapper.TapCode(this.PropertyCode()));
            sb.AppendLine("    }");
            sb.AppendLine("}");

            CsCode = sb.ToString();

        }

        private string ConstructorCode()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("    public " + CName + "(XmlNode xmlNode)");
            sb.AppendLine("    {");
            sb.AppendLine("        if (xmlNode.InnerText != null)");
            sb.AppendLine("        {");
            sb.AppendLine("            this." + m_varName + " = xmlNode.InnerText;");
            sb.AppendLine("        }");
            sb.AppendLine("        else");
            sb.AppendLine("        {");
            sb.AppendLine("            throw new Exception();");
            sb.AppendLine("        }");
            sb.AppendLine("    }");


            return sb.ToString();
        }

        private string setGetterCode() 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("public string StringValue() { return valueStr; }");
            sb.AppendLine("public double DoubleValue() { return Convert.ToDouble(valueStr); }");
            sb.AppendLine("public int IntValue() { return Convert.ToInt32(valueStr); }");
            sb.AppendLine("public Decimal DecimalValue() { return Convert.ToDecimal(valueStr); }");
            sb.AppendLine("public bool BooleanValue() { return Convert.ToBoolean(valueStr); }");
            sb.AppendLine("public DateTime DateTimeValue() { return Convert.ToDateTime(valueStr); }");

            return sb.ToString();

        }

        private string PropertyCode()
        {
            StringBuilder sb = new StringBuilder();

            StringBuilder UpperStr = new StringBuilder(m_varName);
            UpperStr[0] = m_varName.ToUpper()[0];

            sb.AppendLine("#region " + UpperStr);
            sb.AppendLine("private " + m_varType + " " + m_varName + ";");
            sb.AppendLine("public " + m_varType + " " + UpperStr);
            sb.AppendLine("{");
            sb.AppendLine("    get { return this." + m_varName + "; }");
            sb.AppendLine("    set");
            sb.AppendLine("    {");
            sb.AppendLine("        if (this." + m_varName + " != value)");
            sb.AppendLine("        {");
            sb.AppendLine("            this." + m_varName + " = value;");
            sb.AppendLine("            //this.RaisePropertyChanged(\"ValueStr\");");
            sb.AppendLine("        }");
            sb.AppendLine("    }");
            sb.AppendLine("}");
            sb.AppendLine("#endregion");

            return sb.ToString();
        }

        private string UsingGen()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("using System;");
            sb.AppendLine("using System.Text;");
            sb.AppendLine("using System.Xml;");
            //sb.AppendLine("using CSharpCodeGen;");

            return sb.ToString();
        }
        
        
    }
}
