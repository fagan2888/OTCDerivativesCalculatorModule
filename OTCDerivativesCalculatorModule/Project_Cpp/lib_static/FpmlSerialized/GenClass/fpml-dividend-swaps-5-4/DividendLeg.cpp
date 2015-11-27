// DividendLeg.cpp 
#include "DividendLeg.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

DividendLeg::DividendLeg(TiXmlNode* xmlNode)
: DirectionalLegUnderlyer(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //declaredCashDividendPercentageNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* declaredCashDividendPercentageNode = xmlNode->FirstChildElement("declaredCashDividendPercentage");

   if(declaredCashDividendPercentageNode){declaredCashDividendPercentageIsNull_ = false;}
   else{declaredCashDividendPercentageIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- declaredCashDividendPercentageNode , address : " << declaredCashDividendPercentageNode << std::endl;
   #endif
   if(declaredCashDividendPercentageNode)
   {
      if(declaredCashDividendPercentageNode->Attribute("href") || declaredCashDividendPercentageNode->Attribute("id"))
      {
          if(declaredCashDividendPercentageNode->Attribute("id"))
          {
             declaredCashDividendPercentageIDRef_ = declaredCashDividendPercentageNode->Attribute("id");
             declaredCashDividendPercentage_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(declaredCashDividendPercentageNode));
             declaredCashDividendPercentage_->setID(declaredCashDividendPercentageIDRef_);
             IDManager::instance().setID(declaredCashDividendPercentageIDRef_,declaredCashDividendPercentage_);
          }
          else if(declaredCashDividendPercentageNode->Attribute("href")) { declaredCashDividendPercentageIDRef_ = declaredCashDividendPercentageNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { declaredCashDividendPercentage_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(declaredCashDividendPercentageNode));}
   }

   //declaredCashEquivalentDividendPercentageNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* declaredCashEquivalentDividendPercentageNode = xmlNode->FirstChildElement("declaredCashEquivalentDividendPercentage");

   if(declaredCashEquivalentDividendPercentageNode){declaredCashEquivalentDividendPercentageIsNull_ = false;}
   else{declaredCashEquivalentDividendPercentageIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- declaredCashEquivalentDividendPercentageNode , address : " << declaredCashEquivalentDividendPercentageNode << std::endl;
   #endif
   if(declaredCashEquivalentDividendPercentageNode)
   {
      if(declaredCashEquivalentDividendPercentageNode->Attribute("href") || declaredCashEquivalentDividendPercentageNode->Attribute("id"))
      {
          if(declaredCashEquivalentDividendPercentageNode->Attribute("id"))
          {
             declaredCashEquivalentDividendPercentageIDRef_ = declaredCashEquivalentDividendPercentageNode->Attribute("id");
             declaredCashEquivalentDividendPercentage_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(declaredCashEquivalentDividendPercentageNode));
             declaredCashEquivalentDividendPercentage_->setID(declaredCashEquivalentDividendPercentageIDRef_);
             IDManager::instance().setID(declaredCashEquivalentDividendPercentageIDRef_,declaredCashEquivalentDividendPercentage_);
          }
          else if(declaredCashEquivalentDividendPercentageNode->Attribute("href")) { declaredCashEquivalentDividendPercentageIDRef_ = declaredCashEquivalentDividendPercentageNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { declaredCashEquivalentDividendPercentage_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(declaredCashEquivalentDividendPercentageNode));}
   }

   //dividendPeriodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dividendPeriodNode = xmlNode->FirstChildElement("dividendPeriod");

   if(dividendPeriodNode){dividendPeriodIsNull_ = false;}
   else{dividendPeriodIsNull_ = true;}

   if(dividendPeriodNode)
   {
      for(dividendPeriodNode; dividendPeriodNode; dividendPeriodNode = dividendPeriodNode->NextSiblingElement("dividendPeriod")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dividendPeriodNode , address : " << dividendPeriodNode << std::endl;
          #endif
          if(dividendPeriodNode->Attribute("href") || dividendPeriodNode->Attribute("id"))
          {
              if(dividendPeriodNode->Attribute("id"))
              {
                  dividendPeriodIDRef_ = dividendPeriodNode->Attribute("id");
                  dividendPeriod_.push_back(boost::shared_ptr<DividendPeriodPayment>(new DividendPeriodPayment(dividendPeriodNode)));
                  dividendPeriod_.back()->setID(dividendPeriodIDRef_);
                  IDManager::instance().setID(dividendPeriodIDRef_, dividendPeriod_.back());
              }
              else if(dividendPeriodNode->Attribute("href")) { dividendPeriodIDRef_ = dividendPeriodNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { dividendPeriod_.push_back(boost::shared_ptr<DividendPeriodPayment>(new DividendPeriodPayment(dividendPeriodNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dividendPeriodNode , address : " << dividendPeriodNode << std::endl;
       #endif
   }

   //specialDividendsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* specialDividendsNode = xmlNode->FirstChildElement("specialDividends");

   if(specialDividendsNode){specialDividendsIsNull_ = false;}
   else{specialDividendsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- specialDividendsNode , address : " << specialDividendsNode << std::endl;
   #endif
   if(specialDividendsNode)
   {
      if(specialDividendsNode->Attribute("href") || specialDividendsNode->Attribute("id"))
      {
          if(specialDividendsNode->Attribute("id"))
          {
             specialDividendsIDRef_ = specialDividendsNode->Attribute("id");
             specialDividends_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(specialDividendsNode));
             specialDividends_->setID(specialDividendsIDRef_);
             IDManager::instance().setID(specialDividendsIDRef_,specialDividends_);
          }
          else if(specialDividendsNode->Attribute("href")) { specialDividendsIDRef_ = specialDividendsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { specialDividends_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(specialDividendsNode));}
   }

   //materialDividendNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* materialDividendNode = xmlNode->FirstChildElement("materialDividend");

   if(materialDividendNode){materialDividendIsNull_ = false;}
   else{materialDividendIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- materialDividendNode , address : " << materialDividendNode << std::endl;
   #endif
   if(materialDividendNode)
   {
      if(materialDividendNode->Attribute("href") || materialDividendNode->Attribute("id"))
      {
          if(materialDividendNode->Attribute("id"))
          {
             materialDividendIDRef_ = materialDividendNode->Attribute("id");
             materialDividend_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(materialDividendNode));
             materialDividend_->setID(materialDividendIDRef_);
             IDManager::instance().setID(materialDividendIDRef_,materialDividend_);
          }
          else if(materialDividendNode->Attribute("href")) { materialDividendIDRef_ = materialDividendNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { materialDividend_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(materialDividendNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<NonNegativeDecimal> DividendLeg::getDeclaredCashDividendPercentage()
{
   if(!this->declaredCashDividendPercentageIsNull_){
        if(declaredCashDividendPercentageIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeDecimal>(IDManager::instance().getID(declaredCashDividendPercentageIDRef_));
        }else{
             return this->declaredCashDividendPercentage_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeDecimal>();
   }
}
boost::shared_ptr<NonNegativeDecimal> DividendLeg::getDeclaredCashEquivalentDividendPercentage()
{
   if(!this->declaredCashEquivalentDividendPercentageIsNull_){
        if(declaredCashEquivalentDividendPercentageIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeDecimal>(IDManager::instance().getID(declaredCashEquivalentDividendPercentageIDRef_));
        }else{
             return this->declaredCashEquivalentDividendPercentage_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeDecimal>();
   }
}
std::vector<boost::shared_ptr<DividendPeriodPayment>> DividendLeg::getDividendPeriod()
{
   if(!this->dividendPeriodIsNull_){
        if(dividendPeriodIDRef_ != ""){
             return this->dividendPeriod_;
        }else{
             return this->dividendPeriod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<DividendPeriodPayment>>();
   }
}
boost::shared_ptr<XsdTypeBoolean> DividendLeg::getSpecialDividends()
{
   if(!this->specialDividendsIsNull_){
        if(specialDividendsIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(specialDividendsIDRef_));
        }else{
             return this->specialDividends_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> DividendLeg::getMaterialDividend()
{
   if(!this->materialDividendIsNull_){
        if(materialDividendIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(materialDividendIDRef_));
        }else{
             return this->materialDividend_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

