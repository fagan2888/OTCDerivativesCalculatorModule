// Future.cpp 
#include "Future.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Future::Future(TiXmlNode* xmlNode)
: ExchangeTraded(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //multiplierNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* multiplierNode = xmlNode->FirstChildElement("multiplier");

   if(multiplierNode){multiplierIsNull_ = false;}
   else{multiplierIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- multiplierNode , address : " << multiplierNode << std::endl;
   #endif
   if(multiplierNode)
   {
      if(multiplierNode->Attribute("href") || multiplierNode->Attribute("id"))
      {
          if(multiplierNode->Attribute("id"))
          {
             multiplierIDRef_ = multiplierNode->Attribute("id");
             multiplier_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(multiplierNode));
             multiplier_->setID(multiplierIDRef_);
             IDManager::instance().setID(multiplierIDRef_,multiplier_);
          }
          else if(multiplierNode->Attribute("href")) { multiplierIDRef_ = multiplierNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { multiplier_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(multiplierNode));}
   }

   //futureContractReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* futureContractReferenceNode = xmlNode->FirstChildElement("futureContractReference");

   if(futureContractReferenceNode){futureContractReferenceIsNull_ = false;}
   else{futureContractReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- futureContractReferenceNode , address : " << futureContractReferenceNode << std::endl;
   #endif
   if(futureContractReferenceNode)
   {
      if(futureContractReferenceNode->Attribute("href") || futureContractReferenceNode->Attribute("id"))
      {
          if(futureContractReferenceNode->Attribute("id"))
          {
             futureContractReferenceIDRef_ = futureContractReferenceNode->Attribute("id");
             futureContractReference_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(futureContractReferenceNode));
             futureContractReference_->setID(futureContractReferenceIDRef_);
             IDManager::instance().setID(futureContractReferenceIDRef_,futureContractReference_);
          }
          else if(futureContractReferenceNode->Attribute("href")) { futureContractReferenceIDRef_ = futureContractReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { futureContractReference_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(futureContractReferenceNode));}
   }

   //maturityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* maturityNode = xmlNode->FirstChildElement("maturity");

   if(maturityNode){maturityIsNull_ = false;}
   else{maturityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- maturityNode , address : " << maturityNode << std::endl;
   #endif
   if(maturityNode)
   {
      if(maturityNode->Attribute("href") || maturityNode->Attribute("id"))
      {
          if(maturityNode->Attribute("id"))
          {
             maturityIDRef_ = maturityNode->Attribute("id");
             maturity_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(maturityNode));
             maturity_->setID(maturityIDRef_);
             IDManager::instance().setID(maturityIDRef_,maturity_);
          }
          else if(maturityNode->Attribute("href")) { maturityIDRef_ = maturityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { maturity_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(maturityNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypePositiveInteger> Future::getMultiplier()
{
   if(!this->multiplierIsNull_){
        if(multiplierIDRef_ != ""){
             return boost::shared_static_cast<XsdTypePositiveInteger>(IDManager::instance().getID(multiplierIDRef_));
        }else{
             return this->multiplier_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypePositiveInteger>();
   }
}
boost::shared_ptr<XsdTypeString> Future::getFutureContractReference()
{
   if(!this->futureContractReferenceIsNull_){
        if(futureContractReferenceIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(futureContractReferenceIDRef_));
        }else{
             return this->futureContractReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
boost::shared_ptr<XsdTypeDate> Future::getMaturity()
{
   if(!this->maturityIsNull_){
        if(maturityIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(maturityIDRef_));
        }else{
             return this->maturity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
}

