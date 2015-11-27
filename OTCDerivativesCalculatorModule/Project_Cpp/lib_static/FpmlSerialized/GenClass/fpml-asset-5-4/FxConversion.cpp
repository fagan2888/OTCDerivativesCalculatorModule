// FxConversion.cpp 
#include "FxConversion.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FxConversion::FxConversion(TiXmlNode* xmlNode)
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

   //fxRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fxRateNode = xmlNode->FirstChildElement("fxRate");

   if(fxRateNode){fxRateIsNull_ = false;}
   else{fxRateIsNull_ = true;}

   if(fxRateNode)
   {
      for(fxRateNode; fxRateNode; fxRateNode = fxRateNode->NextSiblingElement("fxRate")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fxRateNode , address : " << fxRateNode << std::endl;
          #endif
          if(fxRateNode->Attribute("href") || fxRateNode->Attribute("id"))
          {
              if(fxRateNode->Attribute("id"))
              {
                  fxRateIDRef_ = fxRateNode->Attribute("id");
                  fxRate_.push_back(boost::shared_ptr<FxRate>(new FxRate(fxRateNode)));
                  fxRate_.back()->setID(fxRateIDRef_);
                  IDManager::instance().setID(fxRateIDRef_, fxRate_.back());
              }
              else if(fxRateNode->Attribute("href")) { fxRateIDRef_ = fxRateNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { fxRate_.push_back(boost::shared_ptr<FxRate>(new FxRate(fxRateNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fxRateNode , address : " << fxRateNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AmountReference> FxConversion::getAmountRelativeTo()
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
std::vector<boost::shared_ptr<FxRate>> FxConversion::getFxRate()
{
   if(!this->fxRateIsNull_){
        if(fxRateIDRef_ != ""){
             return this->fxRate_;
        }else{
             return this->fxRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<FxRate>>();
   }
}
}

