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
        private List<MemberFunction> m_MemberFunction = new List<MemberFunction>();

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
                    roopItem(xgb, choice,"");
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
                        roopItem(xgb,choice,"");
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


        private void roopItem(XmlSchemaGroupBase xgb, bool tf, string choiceStr)
        {
            bool choice = tf;
            bool isVector = false;
            string includePathStr;
            string cStr = choiceStr; 

            if (xgb is XmlSchemaChoice)
            {
                choice = true;
                if (xgb.Id == null)
                {
                    choiceStr = "choiceStr_" + m_ClassGen.ChoiceStr.Count;
                    
                }
                else 
                {
                    choiceStr = "choiceStr_" + xgb.Id;
                }

                m_ClassGen.ChoiceStr.Add(choiceStr);
                m_ClassGen.ChoiceStrMember.Add(choiceStr, new List<string>());
                
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
                        if (choice) { m_ClassGen.ChoiceStrMember[choiceStr].Add(itemCast.Name); }

                        if (itemCast.SchemaTypeName.IsEmpty)
                        {
                            includePathStr = includePath["boolean"];

                            m_MemberVariable.Add(new Variable("boolean",
                                                              itemCast.Name,
                                                              includePathStr,
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
                                                              includePathStr,
                                                              isVector,
                                                              choice));
                        }
                        #endregion
                    }

                    else
                    {
                        #region refDef
                        
                        string type = elementRef[itemCast.RefName.Name];
                        if (choice) { m_ClassGen.ChoiceStrMember[choiceStr].Add(itemCast.RefName.Name); }

                        includePathStr = includePath[type];

                        m_MemberVariable.Add(new Variable(type,
                                                          itemCast.RefName.Name,
                                                          includePathStr,
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
                                                                        includePathStr,
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

                    roopItem(xsg.Particle, choice, choiceStr);

                    #endregion

                }
                else if (item is XmlSchemaGroupBase)
                {
                    XmlSchemaGroupBase xgbSub = item as XmlSchemaGroupBase;
                    roopItem(xgbSub, choice, choiceStr);
                }
            }
        }

        public void makeCode()
        {
            m_ClassGen.MemberVariable = this.m_MemberVariable;
            
            if (m_ClassGen.BaseName != null)
            {
                m_ClassGen.BasePathName = includePath[m_ClassGen.BaseName];
            }
            m_ClassGen.makeHppCode();
            m_ClassGen.makeCppCode();

            this.cName = m_ClassGen.CName;
            this.CppCode = m_ClassGen.CppCode;
            this.HppCode = m_ClassGen.HppCode;

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

        public string HppCode { get; set; }

        public string CppCode { get; set; }
    }
}
