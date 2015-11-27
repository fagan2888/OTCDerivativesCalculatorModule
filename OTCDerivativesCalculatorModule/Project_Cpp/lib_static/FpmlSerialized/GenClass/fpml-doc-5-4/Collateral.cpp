// Collateral.cpp 
#include "Collateral.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Collateral::Collateral(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //independentAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* independentAmountNode = xmlNode->FirstChildElement("independentAmount");

   if(independentAmountNode){independentAmountIsNull_ = false;}
   else{independentAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- independentAmountNode , address : " << independentAmountNode << std::endl;
   #endif
   if(independentAmountNode)
   {
      if(independentAmountNode->Attribute("href") || independentAmountNode->Attribute("id"))
      {
          if(independentAmountNode->Attribute("id"))
          {
             independentAmountIDRef_ = independentAmountNode->Attribute("id");
             independentAmount_ = boost::shared_ptr<IndependentAmount>(new IndependentAmount(independentAmountNode));
             independentAmount_->setID(independentAmountIDRef_);
             IDManager::instance().setID(independentAmountIDRef_,independentAmount_);
          }
          else if(independentAmountNode->Attribute("href")) { independentAmountIDRef_ = independentAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { independentAmount_ = boost::shared_ptr<IndependentAmount>(new IndependentAmount(independentAmountNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<IndependentAmount> Collateral::getIndependentAmount()
{
   if(!this->independentAmountIsNull_){
        if(independentAmountIDRef_ != ""){
             return boost::shared_static_cast<IndependentAmount>(IDManager::instance().getID(independentAmountIDRef_));
        }else{
             return this->independentAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IndependentAmount>();
   }
}
}

