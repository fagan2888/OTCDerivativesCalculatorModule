// AssetValuation.cpp 
#include "AssetValuation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

AssetValuation::AssetValuation(TiXmlNode* xmlNode)
: Valuation(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //quoteNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* quoteNode = xmlNode->FirstChildElement("quote");

   if(quoteNode){quoteIsNull_ = false;}
   else{quoteIsNull_ = true;}

   if(quoteNode)
   {
      for(quoteNode; quoteNode; quoteNode = quoteNode->NextSiblingElement("quote")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- quoteNode , address : " << quoteNode << std::endl;
          #endif
          if(quoteNode->Attribute("href") || quoteNode->Attribute("id"))
          {
              if(quoteNode->Attribute("id"))
              {
                  quoteIDRef_ = quoteNode->Attribute("id");
                  quote_.push_back(boost::shared_ptr<Quotation>(new Quotation(quoteNode)));
                  quote_.back()->setID(quoteIDRef_);
                  IDManager::instance().setID(quoteIDRef_, quote_.back());
              }
              else if(quoteNode->Attribute("href")) { quoteIDRef_ = quoteNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { quote_.push_back(boost::shared_ptr<Quotation>(new Quotation(quoteNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- quoteNode , address : " << quoteNode << std::endl;
       #endif
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
std::vector<boost::shared_ptr<Quotation>> AssetValuation::getQuote()
{
   if(!this->quoteIsNull_){
        if(quoteIDRef_ != ""){
             return this->quote_;
        }else{
             return this->quote_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Quotation>>();
   }
}
std::vector<boost::shared_ptr<FxRate>> AssetValuation::getFxRate()
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

