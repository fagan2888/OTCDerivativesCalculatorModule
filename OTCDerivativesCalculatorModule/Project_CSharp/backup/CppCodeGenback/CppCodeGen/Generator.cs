using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Schema;
using System.IO;

namespace CppCodeGen
{
    public class Generator
    {
        public Generator(XmlSchemaComplexType xsCoxType) 
        {
            this.setXsd(xsCoxType);
        }

        private ClassGen m_ClassGen = new ClassGen();

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
                    //this.RaisePropertyChanged("Code");
                }
            }
        }
        #endregion

        private List<Constructor> m_Constructor = new List<Constructor>();
        private List<Variable> m_MemberVariable = new List<Variable>();
        private List<MemberFunction> m_MemberFunction = new List<MemberFunction>();

        

        private void setXsd(XmlSchemaComplexType xsCoxType) 
        {
            
            m_ClassGen.CName = xsCoxType.Name;

            if (xsCoxType.ContentModel == null)
            {
                if (xsCoxType.Particle is XmlSchemaGroupRef)
                {
                    // 만듬.
                }

                else if (xsCoxType.Particle is XmlSchemaGroupBase)
                {
                    XmlSchemaGroupBase xgb = xsCoxType.Particle as XmlSchemaGroupBase;
                    roopItem(xgb);
                }
            }

            else if (xsCoxType.ContentModel is XmlSchemaComplexContent)
            {
                XmlSchemaComplexContent xscc = xsCoxType.ContentModel as XmlSchemaComplexContent;

                if (xscc.Content is XmlSchemaComplexContentExtension)
                {
                    XmlSchemaComplexContentExtension xscc_Extension = xscc.Content as XmlSchemaComplexContentExtension;
                    m_ClassGen.BaseName = xscc_Extension.BaseTypeName.Name;

                    // 위에 (**) 코드랑 같이 가려고 했는데 XmlSchemaComplexType 하고 같은 인터페이스를 사용하지 않음. 아옭 헷갈리
                    if (xscc_Extension.Particle is XmlSchemaGroupRef)
                    {
                        // 만듬.
                    }

                    else if (xscc_Extension.Particle is XmlSchemaGroupBase)
                    {
                        XmlSchemaGroupBase xgb = xscc_Extension.Particle as XmlSchemaGroupBase;
                        roopItem(xgb);
                    }

                }
                else if (xscc.Content is XmlSchemaComplexContentRestriction)
                {
                    throw new NotImplementedException();
                }
                
            }
            
        }


        private void roopItem(XmlSchemaGroupBase xgb)
        {
            bool choice = false;

            if (xgb is XmlSchemaChoice)
            {
                choice = true;
            }

            foreach (XmlSchemaObject item in xgb.Items)
            {
                if (item is XmlSchemaElement)
                {
                    XmlSchemaElement itemCast = item as XmlSchemaElement;

                    if (itemCast.RefName.IsEmpty)
                    {
                        m_MemberVariable.Add(new Variable(itemCast.SchemaTypeName.Name, itemCast.Name,choice));
                        
                    }
                    else 
                    { 
                        // 처리
                    }

                }

                else if (item is XmlSchemaGroupBase)
                {
                    XmlSchemaGroupBase xgbSub = item as XmlSchemaGroupBase;
                    roopItem(xgbSub);
                }
            }
        }

        public void makeCode()
        {

            m_ClassGen.MemberVariable = this.m_MemberVariable;

            m_ClassGen.makeCode();

            this.cName = m_ClassGen.CName;
            this.code = m_ClassGen.Code;
            //foreach (Constructor item in m_Constructor)
            //{
            //    m_ClassGen.addConstructor(item);    
            //}

            //foreach (MemberFunction item in m_MemberFunction)
            //{
            //    m_ClassGen.addMemberFunction(item);
            //}

            //foreach (MemberVariable item in m_MemberVariable)
            //{
            //    m_ClassGen.addMeberVariable(item);
            //}
        }

    }
}
