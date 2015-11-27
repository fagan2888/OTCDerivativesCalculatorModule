// Index.cpp 
#include "Index.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Index::Index(TiXmlNode* xmlNode)
: ExchangeTradedCalculatedPrice(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //futureIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* futureIdNode = xmlNode->FirstChildElement("futureId");

   if(futureIdNode){futureIdIsNull_ = false;}
   else{futureIdIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- futureIdNode , address : " << futureIdNode << std::endl;
   #endif
   if(futureIdNode)
   {
      if(futureIdNode->Attribute("href") || futureIdNode->Attribute("id"))
      {
          if(futureIdNode->Attribute("id"))
          {
             futureIdIDRef_ = futureIdNode->Attribute("id");
             futureId_ = boost::shared_ptr<FutureId>(new FutureId(futureIdNode));
             futureId_->setID(futureIdIDRef_);
             IDManager::instance().setID(futureIdIDRef_,futureId_);
          }
          else if(futureIdNode->Attribute("href")) { futureIdIDRef_ = futureIdNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { futureId_ = boost::shared_ptr<FutureId>(new FutureId(futureIdNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<FutureId> Index::getFutureId()
{
   if(!this->futureIdIsNull_){
        if(futureIdIDRef_ != ""){
             return boost::shared_static_cast<FutureId>(IDManager::instance().getID(futureIdIDRef_));
        }else{
             return this->futureId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FutureId>();
   }
}
}

