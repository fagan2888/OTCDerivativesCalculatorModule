// StandardProduct.cpp 
#include "StandardProduct.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

StandardProduct::StandardProduct(TiXmlNode* xmlNode)
: Product(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //notionalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notionalNode = xmlNode->FirstChildElement("notional");

   if(notionalNode){notionalIsNull_ = false;}
   else{notionalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notionalNode , address : " << notionalNode << std::endl;
   #endif
   if(notionalNode)
   {
      if(notionalNode->Attribute("href") || notionalNode->Attribute("id"))
      {
          if(notionalNode->Attribute("id"))
          {
             notionalIDRef_ = notionalNode->Attribute("id");
             notional_ = boost::shared_ptr<CashflowNotional>(new CashflowNotional(notionalNode));
             notional_->setID(notionalIDRef_);
             IDManager::instance().setID(notionalIDRef_,notional_);
          }
          else if(notionalNode->Attribute("href")) { notionalIDRef_ = notionalNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notional_ = boost::shared_ptr<CashflowNotional>(new CashflowNotional(notionalNode));}
   }

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
                  quote_.push_back(boost::shared_ptr<BasicQuotation>(new BasicQuotation(quoteNode)));
                  quote_.back()->setID(quoteIDRef_);
                  IDManager::instance().setID(quoteIDRef_, quote_.back());
              }
              else if(quoteNode->Attribute("href")) { quoteIDRef_ = quoteNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { quote_.push_back(boost::shared_ptr<BasicQuotation>(new BasicQuotation(quoteNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- quoteNode , address : " << quoteNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CashflowNotional> StandardProduct::getNotional()
{
   if(!this->notionalIsNull_){
        if(notionalIDRef_ != ""){
             return boost::shared_static_cast<CashflowNotional>(IDManager::instance().getID(notionalIDRef_));
        }else{
             return this->notional_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CashflowNotional>();
   }
}
std::vector<boost::shared_ptr<BasicQuotation>> StandardProduct::getQuote()
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
      return std::vector<boost::shared_ptr<BasicQuotation>>();
   }
}
}

