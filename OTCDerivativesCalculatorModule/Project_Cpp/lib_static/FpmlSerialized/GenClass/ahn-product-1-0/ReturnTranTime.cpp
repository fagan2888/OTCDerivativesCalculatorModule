// ReturnTranTime.cpp 
#include "ReturnTranTime.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ReturnTranTime::ReturnTranTime(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //nameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nameNode = xmlNode->FirstChildElement("name");

   if(nameNode){nameIsNull_ = false;}
   else{nameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nameNode , address : " << nameNode << std::endl;
   #endif
   if(nameNode)
   {
      if(nameNode->Attribute("href") || nameNode->Attribute("id"))
      {
          if(nameNode->Attribute("id"))
          {
             nameIDRef_ = nameNode->Attribute("id");
             name_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(nameNode));
             name_->setID(nameIDRef_);
             IDManager::instance().setID(nameIDRef_,name_);
          }
          else if(nameNode->Attribute("href")) { nameIDRef_ = nameNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { name_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(nameNode));}
   }

   //returnTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* returnTypeNode = xmlNode->FirstChildElement("returnType");

   if(returnTypeNode){returnTypeIsNull_ = false;}
   else{returnTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- returnTypeNode , address : " << returnTypeNode << std::endl;
   #endif
   if(returnTypeNode)
   {
      if(returnTypeNode->Attribute("href") || returnTypeNode->Attribute("id"))
      {
          if(returnTypeNode->Attribute("id"))
          {
             returnTypeIDRef_ = returnTypeNode->Attribute("id");
             returnType_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(returnTypeNode));
             returnType_->setID(returnTypeIDRef_);
             IDManager::instance().setID(returnTypeIDRef_,returnType_);
          }
          else if(returnTypeNode->Attribute("href")) { returnTypeIDRef_ = returnTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { returnType_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(returnTypeNode));}
   }

   //underlyingIndexRefNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* underlyingIndexRefNode = xmlNode->FirstChildElement("underlyingIndexRef");

   if(underlyingIndexRefNode){underlyingIndexRefIsNull_ = false;}
   else{underlyingIndexRefIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- underlyingIndexRefNode , address : " << underlyingIndexRefNode << std::endl;
   #endif
   if(underlyingIndexRefNode)
   {
      if(underlyingIndexRefNode->Attribute("href") || underlyingIndexRefNode->Attribute("id"))
      {
          if(underlyingIndexRefNode->Attribute("id"))
          {
             underlyingIndexRefIDRef_ = underlyingIndexRefNode->Attribute("id");
             underlyingIndexRef_ = boost::shared_ptr<UnderlyingIndex>(new UnderlyingIndex(underlyingIndexRefNode));
             underlyingIndexRef_->setID(underlyingIndexRefIDRef_);
             IDManager::instance().setID(underlyingIndexRefIDRef_,underlyingIndexRef_);
          }
          else if(underlyingIndexRefNode->Attribute("href")) { underlyingIndexRefIDRef_ = underlyingIndexRefNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { underlyingIndexRef_ = boost::shared_ptr<UnderlyingIndex>(new UnderlyingIndex(underlyingIndexRefNode));}
   }

   //symbolNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* symbolNameNode = xmlNode->FirstChildElement("symbolName");

   if(symbolNameNode){symbolNameIsNull_ = false;}
   else{symbolNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- symbolNameNode , address : " << symbolNameNode << std::endl;
   #endif
   if(symbolNameNode)
   {
      if(symbolNameNode->Attribute("href") || symbolNameNode->Attribute("id"))
      {
          if(symbolNameNode->Attribute("id"))
          {
             symbolNameIDRef_ = symbolNameNode->Attribute("id");
             symbolName_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(symbolNameNode));
             symbolName_->setID(symbolNameIDRef_);
             IDManager::instance().setID(symbolNameIDRef_,symbolName_);
          }
          else if(symbolNameNode->Attribute("href")) { symbolNameIDRef_ = symbolNameNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { symbolName_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(symbolNameNode));}
   }

   //numerCalculationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* numerCalculationNode = xmlNode->FirstChildElement("numerCalculation");

   if(numerCalculationNode){numerCalculationIsNull_ = false;}
   else{numerCalculationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- numerCalculationNode , address : " << numerCalculationNode << std::endl;
   #endif
   if(numerCalculationNode)
   {
      if(numerCalculationNode->Attribute("href") || numerCalculationNode->Attribute("id"))
      {
          if(numerCalculationNode->Attribute("id"))
          {
             numerCalculationIDRef_ = numerCalculationNode->Attribute("id");
             numerCalculation_ = boost::shared_ptr<VariableValue>(new VariableValue(numerCalculationNode));
             numerCalculation_->setID(numerCalculationIDRef_);
             IDManager::instance().setID(numerCalculationIDRef_,numerCalculation_);
          }
          else if(numerCalculationNode->Attribute("href")) { numerCalculationIDRef_ = numerCalculationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { numerCalculation_ = boost::shared_ptr<VariableValue>(new VariableValue(numerCalculationNode));}
   }

   //denumerCalculationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* denumerCalculationNode = xmlNode->FirstChildElement("denumerCalculation");

   if(denumerCalculationNode){denumerCalculationIsNull_ = false;}
   else{denumerCalculationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- denumerCalculationNode , address : " << denumerCalculationNode << std::endl;
   #endif
   if(denumerCalculationNode)
   {
      if(denumerCalculationNode->Attribute("href") || denumerCalculationNode->Attribute("id"))
      {
          if(denumerCalculationNode->Attribute("id"))
          {
             denumerCalculationIDRef_ = denumerCalculationNode->Attribute("id");
             denumerCalculation_ = boost::shared_ptr<VariableValue>(new VariableValue(denumerCalculationNode));
             denumerCalculation_->setID(denumerCalculationIDRef_);
             IDManager::instance().setID(denumerCalculationIDRef_,denumerCalculation_);
          }
          else if(denumerCalculationNode->Attribute("href")) { denumerCalculationIDRef_ = denumerCalculationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { denumerCalculation_ = boost::shared_ptr<VariableValue>(new VariableValue(denumerCalculationNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> ReturnTranTime::getName()
{
   if(!this->nameIsNull_){
        if(nameIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeToken>(IDManager::instance().getID(nameIDRef_));
        }else{
             return this->name_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> ReturnTranTime::getReturnType()
{
   if(!this->returnTypeIsNull_){
        if(returnTypeIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeToken>(IDManager::instance().getID(returnTypeIDRef_));
        }else{
             return this->returnType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<UnderlyingIndex> ReturnTranTime::getUnderlyingIndexRef()
{
   if(!this->underlyingIndexRefIsNull_){
        if(underlyingIndexRefIDRef_ != ""){
             return boost::shared_static_cast<UnderlyingIndex>(IDManager::instance().getID(underlyingIndexRefIDRef_));
        }else{
             return this->underlyingIndexRef_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<UnderlyingIndex>();
   }
}
boost::shared_ptr<XsdTypeToken> ReturnTranTime::getSymbolName()
{
   if(!this->symbolNameIsNull_){
        if(symbolNameIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeToken>(IDManager::instance().getID(symbolNameIDRef_));
        }else{
             return this->symbolName_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<VariableValue> ReturnTranTime::getNumerCalculation()
{
   if(!this->numerCalculationIsNull_){
        if(numerCalculationIDRef_ != ""){
             return boost::shared_static_cast<VariableValue>(IDManager::instance().getID(numerCalculationIDRef_));
        }else{
             return this->numerCalculation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<VariableValue>();
   }
}
boost::shared_ptr<VariableValue> ReturnTranTime::getDenumerCalculation()
{
   if(!this->denumerCalculationIsNull_){
        if(denumerCalculationIDRef_ != ""){
             return boost::shared_static_cast<VariableValue>(IDManager::instance().getID(denumerCalculationIDRef_));
        }else{
             return this->denumerCalculation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<VariableValue>();
   }
}
}

