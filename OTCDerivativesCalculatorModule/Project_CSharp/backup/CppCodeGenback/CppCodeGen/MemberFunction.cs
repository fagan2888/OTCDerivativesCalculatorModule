using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CppCodeGen
{
    class MemberFunction
    {
        MemberFunction(string returnType,
                       string functionName,
                       List<Variable> parametorVar) 
        {
            m_returnType = returnType;
            m_functionName = functionName;
            m_parametorVar = parametorVar;

        }

        private string m_returnType;
        private string m_functionName;
        private List<Variable> m_parametorVar;

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

        internal string getDeclareCode()
        {
            string variable = "";

            foreach (Variable item in m_parametorVar)
	        {
		        variable += item.getParametor();
	        }

            Code +=
                m_returnType + " " + m_functionName + "(" + variable + ") { }";

            return Code;
            
        }

        
    }
}
