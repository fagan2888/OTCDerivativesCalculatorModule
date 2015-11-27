// VanillaSwapPayoff.cpp 
#include "VanillaSwapPayoff.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

VanillaSwapPayoff::VanillaSwapPayoff(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //recieveSwapPartNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* recieveSwapPartNode = xmlNode->FirstChildElement("recieveSwapPart");

   if(recieveSwapPartNode){recieveSwapPartIsNull_ = false;}
   else{recieveSwapPartIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- recieveSwapPartNode , address : " << recieveSwapPartNode << std::endl;
   #endif
   if(recieveSwapPartNode)
   {
       recieveSwapPart_ = boost::shared_ptr<RecieveSwapPart>(new RecieveSwapPart(recieveSwapPartNode));
   }

   //paySwapPartNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paySwapPartNode = xmlNode->FirstChildElement("paySwapPart");

   if(paySwapPartNode){paySwapPartIsNull_ = false;}
   else{paySwapPartIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paySwapPartNode , address : " << paySwapPartNode << std::endl;
   #endif
   if(paySwapPartNode)
   {
       paySwapPart_ = boost::shared_ptr<PaySwapPart>(new PaySwapPart(paySwapPartNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<RecieveSwapPart> VanillaSwapPayoff::getRecieveSwapPart()
{
   if(!this->recieveSwapPartIsNull_){
        return this->recieveSwapPart_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RecieveSwapPart>();
   }
}
boost::shared_ptr<PaySwapPart> VanillaSwapPayoff::getPaySwapPart()
{
   if(!this->paySwapPartIsNull_){
        return this->paySwapPart_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PaySwapPart>();
   }
}
}

