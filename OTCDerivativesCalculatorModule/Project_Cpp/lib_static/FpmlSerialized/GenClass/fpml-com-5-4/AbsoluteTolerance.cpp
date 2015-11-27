// AbsoluteTolerance.cpp 
#include "AbsoluteTolerance.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

AbsoluteTolerance::AbsoluteTolerance(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //positiveNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* positiveNode = xmlNode->FirstChildElement("positive");

   if(positiveNode){positiveIsNull_ = false;}
   else{positiveIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- positiveNode , address : " << positiveNode << std::endl;
   #endif
   if(positiveNode)
   {
      if(positiveNode->Attribute("href") || positiveNode->Attribute("id"))
      {
          if(positiveNode->Attribute("id"))
          {
             positiveIDRef_ = positiveNode->Attribute("id");
             positive_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(positiveNode));
             positive_->setID(positiveIDRef_);
             IDManager::instance().setID(positiveIDRef_,positive_);
          }
          else if(positiveNode->Attribute("href")) { positiveIDRef_ = positiveNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { positive_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(positiveNode));}
   }

   //negativeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* negativeNode = xmlNode->FirstChildElement("negative");

   if(negativeNode){negativeIsNull_ = false;}
   else{negativeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- negativeNode , address : " << negativeNode << std::endl;
   #endif
   if(negativeNode)
   {
      if(negativeNode->Attribute("href") || negativeNode->Attribute("id"))
      {
          if(negativeNode->Attribute("id"))
          {
             negativeIDRef_ = negativeNode->Attribute("id");
             negative_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(negativeNode));
             negative_->setID(negativeIDRef_);
             IDManager::instance().setID(negativeIDRef_,negative_);
          }
          else if(negativeNode->Attribute("href")) { negativeIDRef_ = negativeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { negative_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(negativeNode));}
   }

   //unitNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* unitNode = xmlNode->FirstChildElement("unit");

   if(unitNode){unitIsNull_ = false;}
   else{unitIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- unitNode , address : " << unitNode << std::endl;
   #endif
   if(unitNode)
   {
      if(unitNode->Attribute("href") || unitNode->Attribute("id"))
      {
          if(unitNode->Attribute("id"))
          {
             unitIDRef_ = unitNode->Attribute("id");
             unit_ = boost::shared_ptr<QuantityUnit>(new QuantityUnit(unitNode));
             unit_->setID(unitIDRef_);
             IDManager::instance().setID(unitIDRef_,unit_);
          }
          else if(unitNode->Attribute("href")) { unitIDRef_ = unitNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { unit_ = boost::shared_ptr<QuantityUnit>(new QuantityUnit(unitNode));}
   }

   //optionOwnerPartyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* optionOwnerPartyReferenceNode = xmlNode->FirstChildElement("optionOwnerPartyReference");

   if(optionOwnerPartyReferenceNode){optionOwnerPartyReferenceIsNull_ = false;}
   else{optionOwnerPartyReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- optionOwnerPartyReferenceNode , address : " << optionOwnerPartyReferenceNode << std::endl;
   #endif
   if(optionOwnerPartyReferenceNode)
   {
      if(optionOwnerPartyReferenceNode->Attribute("href") || optionOwnerPartyReferenceNode->Attribute("id"))
      {
          if(optionOwnerPartyReferenceNode->Attribute("id"))
          {
             optionOwnerPartyReferenceIDRef_ = optionOwnerPartyReferenceNode->Attribute("id");
             optionOwnerPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(optionOwnerPartyReferenceNode));
             optionOwnerPartyReference_->setID(optionOwnerPartyReferenceIDRef_);
             IDManager::instance().setID(optionOwnerPartyReferenceIDRef_,optionOwnerPartyReference_);
          }
          else if(optionOwnerPartyReferenceNode->Attribute("href")) { optionOwnerPartyReferenceIDRef_ = optionOwnerPartyReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { optionOwnerPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(optionOwnerPartyReferenceNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDecimal> AbsoluteTolerance::getPositive()
{
   if(!this->positiveIsNull_){
        if(positiveIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(positiveIDRef_));
        }else{
             return this->positive_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDecimal> AbsoluteTolerance::getNegative()
{
   if(!this->negativeIsNull_){
        if(negativeIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(negativeIDRef_));
        }else{
             return this->negative_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<QuantityUnit> AbsoluteTolerance::getUnit()
{
   if(!this->unitIsNull_){
        if(unitIDRef_ != ""){
             return boost::shared_static_cast<QuantityUnit>(IDManager::instance().getID(unitIDRef_));
        }else{
             return this->unit_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<QuantityUnit>();
   }
}
boost::shared_ptr<PartyReference> AbsoluteTolerance::getOptionOwnerPartyReference()
{
   if(!this->optionOwnerPartyReferenceIsNull_){
        if(optionOwnerPartyReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(optionOwnerPartyReferenceIDRef_));
        }else{
             return this->optionOwnerPartyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
}

