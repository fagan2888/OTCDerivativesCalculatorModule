// StubValue.cpp 
#include "StubValue.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

StubValue::StubValue(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //floatingRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* floatingRateNode = xmlNode->FirstChildElement("floatingRate");

   if(floatingRateNode){floatingRateIsNull_ = false;}
   else{floatingRateIsNull_ = true;}

   if(floatingRateNode)
   {
      for(floatingRateNode; floatingRateNode; floatingRateNode = floatingRateNode->NextSiblingElement("floatingRate")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- floatingRateNode , address : " << floatingRateNode << std::endl;
          #endif
          if(floatingRateNode->Attribute("href") || floatingRateNode->Attribute("id"))
          {
              if(floatingRateNode->Attribute("id"))
              {
                  floatingRateIDRef_ = floatingRateNode->Attribute("id");
                  floatingRate_.push_back(boost::shared_ptr<FloatingRate>(new FloatingRate(floatingRateNode)));
                  floatingRate_.back()->setID(floatingRateIDRef_);
                  IDManager::instance().setID(floatingRateIDRef_, floatingRate_.back());
              }
              else if(floatingRateNode->Attribute("href")) { floatingRateIDRef_ = floatingRateNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { floatingRate_.push_back(boost::shared_ptr<FloatingRate>(new FloatingRate(floatingRateNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- floatingRateNode , address : " << floatingRateNode << std::endl;
       #endif
   }

   //stubRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* stubRateNode = xmlNode->FirstChildElement("stubRate");

   if(stubRateNode){stubRateIsNull_ = false;}
   else{stubRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- stubRateNode , address : " << stubRateNode << std::endl;
   #endif
   if(stubRateNode)
   {
      if(stubRateNode->Attribute("href") || stubRateNode->Attribute("id"))
      {
          if(stubRateNode->Attribute("id"))
          {
             stubRateIDRef_ = stubRateNode->Attribute("id");
             stubRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(stubRateNode));
             stubRate_->setID(stubRateIDRef_);
             IDManager::instance().setID(stubRateIDRef_,stubRate_);
          }
          else if(stubRateNode->Attribute("href")) { stubRateIDRef_ = stubRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { stubRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(stubRateNode));}
   }

   //stubAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* stubAmountNode = xmlNode->FirstChildElement("stubAmount");

   if(stubAmountNode){stubAmountIsNull_ = false;}
   else{stubAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- stubAmountNode , address : " << stubAmountNode << std::endl;
   #endif
   if(stubAmountNode)
   {
      if(stubAmountNode->Attribute("href") || stubAmountNode->Attribute("id"))
      {
          if(stubAmountNode->Attribute("id"))
          {
             stubAmountIDRef_ = stubAmountNode->Attribute("id");
             stubAmount_ = boost::shared_ptr<Money>(new Money(stubAmountNode));
             stubAmount_->setID(stubAmountIDRef_);
             IDManager::instance().setID(stubAmountIDRef_,stubAmount_);
          }
          else if(stubAmountNode->Attribute("href")) { stubAmountIDRef_ = stubAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { stubAmount_ = boost::shared_ptr<Money>(new Money(stubAmountNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<FloatingRate>> StubValue::getFloatingRate()
{
   if(!this->floatingRateIsNull_){
        if(floatingRateIDRef_ != ""){
             return this->floatingRate_;
        }else{
             return this->floatingRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<FloatingRate>>();
   }
}
boost::shared_ptr<XsdTypeDecimal> StubValue::getStubRate()
{
   if(!this->stubRateIsNull_){
        if(stubRateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(stubRateIDRef_));
        }else{
             return this->stubRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<Money> StubValue::getStubAmount()
{
   if(!this->stubAmountIsNull_){
        if(stubAmountIDRef_ != ""){
             return boost::shared_static_cast<Money>(IDManager::instance().getID(stubAmountIDRef_));
        }else{
             return this->stubAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Money>();
   }
}
}

