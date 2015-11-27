using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Schema;
using System.IO;

namespace CSharpCodeGen
{
    public class Generator
    {
        public Generator(XmlSchemaComplexType xsCoxType,
                         Dictionary<string, string> elementRef,
                         Dictionary<string, string> includePath,
                         List<KeyValuePair<string, string>> elementSubstitutionRef,
                         Dictionary<string, XmlSchemaGroup> elementGroupRef)
        {
            this.includePath = includePath;
            this.elementRef = elementRef;
            this.elementSubstitutionRef = elementSubstitutionRef;
            this.elementGroupRef = elementGroupRef;
            this.setXsd(xsCoxType);
            
        }

        public Generator(XmlSchemaComplexType xsCoxType) 
        {
            this.setXsd(xsCoxType);
        }

        private ClassGen m_ClassGen = new ClassGen();
        //private ClassGenViewModel m_ClassVMGen = new ClassGenViewModel();

        private Dictionary<string, string> elementRef;
        private Dictionary<string, string> includePath;
        private List<KeyValuePair<string, string>> elementSubstitutionRef;
        private Dictionary<string, XmlSchemaGroup> elementGroupRef;

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

        private List<Variable> m_MemberVariable = new List<Variable>();

        private void setXsd(XmlSchemaComplexType xsCoxType) 
        {
            bool choice = false;

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
                    roopItem(xgb, choice);
                }
            }

            else if (xsCoxType.ContentModel is XmlSchemaComplexContent)
            {
                #region complexContent in ComplexType
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
                        roopItem(xgb,choice);
                    }

                }
                else if (xscc.Content is XmlSchemaComplexContentRestriction)
                {
                    throw new NotImplementedException();
                }
                #endregion
            }
            else if (xsCoxType.ContentModel is XmlSchemaSimpleContent)
            {
                #region SimpleContent in SimpleType
                XmlSchemaSimpleContent xssc = xsCoxType.ContentModel as XmlSchemaSimpleContent;

                if (xssc.Content is XmlSchemaSimpleContentExtension)
                {
                    XmlSchemaSimpleContentExtension xssc_Extension = xssc.Content as XmlSchemaSimpleContentExtension;
                    m_ClassGen.BaseName = xssc_Extension.BaseTypeName.Name;

                    // 위에 (**) 코드랑 같이 가려고 했는데 XmlSchemaComplexType 하고 같은 인터페이스를 사용하지 않음. 아옭 헷갈리

                }
                else if (xssc.Content is XmlSchemaComplexContentRestriction)
                {
                    throw new NotImplementedException();
                }
                #endregion
            }
            
        }

        private void roopItem(XmlSchemaGroupBase xgb, bool tf)
        {
            bool choice = tf;
            bool isVector = false;
            string includePathStr;
            
            if (xgb is XmlSchemaChoice)
            {
                choice = true;
                if (xgb.Id == null)
                {
                    string num = "choiceStr_" + m_ClassGen.ChoiceStr.Count;
                    m_ClassGen.ChoiceStr.Add(num);
                }
                else 
                {
                    string id = "choiceStr_" + xgb.Id;
                    m_ClassGen.ChoiceStr.Add(id);
                }
                
            
            }

            foreach (XmlSchemaObject item in xgb.Items)
            {
                isVector = false;

                if (item is XmlSchemaElement)
                {
                    XmlSchemaElement itemCast = item as XmlSchemaElement;
                    
                    if (itemCast.RefName.IsEmpty)
                    {
                        #region directDef
                        if (itemCast.SchemaTypeName.IsEmpty)
                        {
                            includePathStr = includePath["boolean"];

                            m_MemberVariable.Add(new Variable("boolean",
                                                              itemCast.Name,
                                                              isVector,
                                                              choice));
                        }
                        else
                        {
                            decimal aa = itemCast.MaxOccurs;
                            if (itemCast.MaxOccurs > 1) { isVector = true; }

                            includePathStr = includePath[itemCast.SchemaTypeName.Name];

                            m_MemberVariable.Add(new Variable(itemCast.SchemaTypeName.Name,
                                                              itemCast.Name,
                                                              isVector,
                                                              choice));
                        }
                        #endregion
                    }

                    else
                    {
                        #region refDef
                        string type = elementRef[itemCast.RefName.Name];

                        includePathStr = includePath[type];

                        m_MemberVariable.Add(new Variable(type,
                                                          itemCast.RefName.Name,
                                                          isVector,
                                                          choice));

                        foreach (KeyValuePair<string, string> substiItem in elementSubstitutionRef)
	                    {
		                    if(substiItem.Key == itemCast.RefName.Name)
                            {

                                choice = false;
                                bool substi = true; // 주석을 위한 것
                                string substiStr = elementRef[substiItem.Value];
                                includePathStr = includePath[substiStr];

                                Variable substiVariable = new Variable(substiStr,
                                                                        substiItem.Value,
                                                                        isVector,
                                                                        choice,
                                                                        substi);

                                //substiVariable.SubstitudeStr = itemCast.RefName.Name;  주석에 들어갈건데 먼저 생성자에서 코드가 생성되서리 적용이 안댐 그냥 우선은 패스

                                m_MemberVariable.Add(substiVariable);
                            }
                        }
                        #endregion
                    }

                }
                else if (item is XmlSchemaGroupRef)
                {
                    #region groupRefDef

                    XmlSchemaGroupRef xsgr = item as XmlSchemaGroupRef;

                    XmlSchemaGroup xsg = elementGroupRef[xsgr.RefName.Name];

                    roopItem(xsg.Particle, choice);

                    #endregion

                }
                else if (item is XmlSchemaGroupBase)
                {
                    XmlSchemaGroupBase xgbSub = item as XmlSchemaGroupBase;
                    roopItem(xgbSub,choice);
                }
            }
        }

        public void makeCode()
        {
            m_ClassGen.MemberVariable = this.m_MemberVariable;

            m_ClassGen.BuildCode();

            this.cName = m_ClassGen.CName;
            this.CsCode = m_ClassGen.CsCode;

        }


        public string CsCode { get; set; }

        public bool viewModelFlag_ { get; set; }
    }
}
