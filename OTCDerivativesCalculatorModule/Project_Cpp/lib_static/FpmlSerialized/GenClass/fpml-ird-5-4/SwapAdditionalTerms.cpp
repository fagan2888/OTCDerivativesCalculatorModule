// SwapAdditionalTerms.cpp 
#include "SwapAdditionalTerms.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SwapAdditionalTerms::SwapAdditionalTerms(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //bondReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* bondReferenceNode = xmlNode->FirstChildElement("bondReference");

   if(bondReferenceNode){bondReferenceIsNull_ = false;}
   else{bondReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- bondReferenceNode , address : " << bondReferenceNode << std::endl;
   #endif
   if(bondReferenceNode)
   {
      if(bondReferenceNode->Attribute("href") || bondReferenceNode->Attribute("id"))
      {
          if(bondReferenceNode->Attribute("id"))
          {
             bondReferenceIDRef_ = bondReferenceNode->Attribute("id");
             bondReference_ = boost::shared_ptr<BondReference>(new BondReference(bondReferenceNode));
             bondReference_->setID(bondReferenceIDRef_);
             IDManager::instance().setID(bondReferenceIDRef_,bondReference_);
          }
          else if(bondReferenceNode->Attribute("href")) { bondReferenceIDRef_ = bondReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { bondReference_ = boost::shared_ptr<BondReference>(new BondReference(bondReferenceNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<BondReference> SwapAdditionalTerms::getBondReference()
{
   if(!this->bondReferenceIsNull_){
        if(bondReferenceIDRef_ != ""){
             return boost::shared_static_cast<BondReference>(IDManager::instance().getID(bondReferenceIDRef_));
        }else{
             return this->bondReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BondReference>();
   }
}
}

