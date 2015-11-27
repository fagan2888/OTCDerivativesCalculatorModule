// PrincipalExchangeAmount.cpp 
#include "PrincipalExchangeAmount.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PrincipalExchangeAmount::PrincipalExchangeAmount(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //amountRelativeToNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* amountRelativeToNode = xmlNode->FirstChildElement("amountRelativeTo");

   if(amountRelativeToNode){amountRelativeToIsNull_ = false;}
   else{amountRelativeToIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- amountRelativeToNode , address : " << amountRelativeToNode << std::endl;
   #endif
   if(amountRelativeToNode)
   {
      if(amountRelativeToNode->Attribute("href") || amountRelativeToNode->Attribute("id"))
      {
          if(amountRelativeToNode->Attribute("id"))
          {
             amountRelativeToIDRef_ = amountRelativeToNode->Attribute("id");
             amountRelativeTo_ = boost::shared_ptr<AmountReference>(new AmountReference(amountRelativeToNode));
             amountRelativeTo_->setID(amountRelativeToIDRef_);
             IDManager::instance().setID(amountRelativeToIDRef_,amountRelativeTo_);
          }
          else if(amountRelativeToNode->Attribute("href")) { amountRelativeToIDRef_ = amountRelativeToNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { amountRelativeTo_ = boost::shared_ptr<AmountReference>(new AmountReference(amountRelativeToNode));}
   }

   //determinationMethodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* determinationMethodNode = xmlNode->FirstChildElement("determinationMethod");

   if(determinationMethodNode){determinationMethodIsNull_ = false;}
   else{determinationMethodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- determinationMethodNode , address : " << determinationMethodNode << std::endl;
   #endif
   if(determinationMethodNode)
   {
      if(determinationMethodNode->Attribute("href") || determinationMethodNode->Attribute("id"))
      {
          if(determinationMethodNode->Attribute("id"))
          {
             determinationMethodIDRef_ = determinationMethodNode->Attribute("id");
             determinationMethod_ = boost::shared_ptr<DeterminationMethod>(new DeterminationMethod(determinationMethodNode));
             determinationMethod_->setID(determinationMethodIDRef_);
             IDManager::instance().setID(determinationMethodIDRef_,determinationMethod_);
          }
          else if(determinationMethodNode->Attribute("href")) { determinationMethodIDRef_ = determinationMethodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { determinationMethod_ = boost::shared_ptr<DeterminationMethod>(new DeterminationMethod(determinationMethodNode));}
   }

   //principalAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* principalAmountNode = xmlNode->FirstChildElement("principalAmount");

   if(principalAmountNode){principalAmountIsNull_ = false;}
   else{principalAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- principalAmountNode , address : " << principalAmountNode << std::endl;
   #endif
   if(principalAmountNode)
   {
      if(principalAmountNode->Attribute("href") || principalAmountNode->Attribute("id"))
      {
          if(principalAmountNode->Attribute("id"))
          {
             principalAmountIDRef_ = principalAmountNode->Attribute("id");
             principalAmount_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(principalAmountNode));
             principalAmount_->setID(principalAmountIDRef_);
             IDManager::instance().setID(principalAmountIDRef_,principalAmount_);
          }
          else if(principalAmountNode->Attribute("href")) { principalAmountIDRef_ = principalAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { principalAmount_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(principalAmountNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AmountReference> PrincipalExchangeAmount::getAmountRelativeTo()
{
   if(!this->amountRelativeToIsNull_){
        if(amountRelativeToIDRef_ != ""){
             return boost::shared_static_cast<AmountReference>(IDManager::instance().getID(amountRelativeToIDRef_));
        }else{
             return this->amountRelativeTo_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AmountReference>();
   }
}
boost::shared_ptr<DeterminationMethod> PrincipalExchangeAmount::getDeterminationMethod()
{
   if(!this->determinationMethodIsNull_){
        if(determinationMethodIDRef_ != ""){
             return boost::shared_static_cast<DeterminationMethod>(IDManager::instance().getID(determinationMethodIDRef_));
        }else{
             return this->determinationMethod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DeterminationMethod>();
   }
}
boost::shared_ptr<NonNegativeMoney> PrincipalExchangeAmount::getPrincipalAmount()
{
   if(!this->principalAmountIsNull_){
        if(principalAmountIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeMoney>(IDManager::instance().getID(principalAmountIDRef_));
        }else{
             return this->principalAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeMoney>();
   }
}
}

