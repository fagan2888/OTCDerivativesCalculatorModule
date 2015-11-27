// ReturnSwapLegUnderlyer.cpp 
#include "ReturnSwapLegUnderlyer.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ReturnSwapLegUnderlyer::ReturnSwapLegUnderlyer(TiXmlNode* xmlNode)
: DirectionalLeg(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //strikeDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* strikeDateNode = xmlNode->FirstChildElement("strikeDate");

   if(strikeDateNode){strikeDateIsNull_ = false;}
   else{strikeDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- strikeDateNode , address : " << strikeDateNode << std::endl;
   #endif
   if(strikeDateNode)
   {
      if(strikeDateNode->Attribute("href") || strikeDateNode->Attribute("id"))
      {
          if(strikeDateNode->Attribute("id"))
          {
             strikeDateIDRef_ = strikeDateNode->Attribute("id");
             strikeDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(strikeDateNode));
             strikeDate_->setID(strikeDateIDRef_);
             IDManager::instance().setID(strikeDateIDRef_,strikeDate_);
          }
          else if(strikeDateNode->Attribute("href")) { strikeDateIDRef_ = strikeDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { strikeDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(strikeDateNode));}
   }

   //underlyerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* underlyerNode = xmlNode->FirstChildElement("underlyer");

   if(underlyerNode){underlyerIsNull_ = false;}
   else{underlyerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- underlyerNode , address : " << underlyerNode << std::endl;
   #endif
   if(underlyerNode)
   {
      if(underlyerNode->Attribute("href") || underlyerNode->Attribute("id"))
      {
          if(underlyerNode->Attribute("id"))
          {
             underlyerIDRef_ = underlyerNode->Attribute("id");
             underlyer_ = boost::shared_ptr<Underlyer>(new Underlyer(underlyerNode));
             underlyer_->setID(underlyerIDRef_);
             IDManager::instance().setID(underlyerIDRef_,underlyer_);
          }
          else if(underlyerNode->Attribute("href")) { underlyerIDRef_ = underlyerNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { underlyer_ = boost::shared_ptr<Underlyer>(new Underlyer(underlyerNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AdjustableOrRelativeDate> ReturnSwapLegUnderlyer::getStrikeDate()
{
   if(!this->strikeDateIsNull_){
        if(strikeDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableOrRelativeDate>(IDManager::instance().getID(strikeDateIDRef_));
        }else{
             return this->strikeDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableOrRelativeDate>();
   }
}
boost::shared_ptr<Underlyer> ReturnSwapLegUnderlyer::getUnderlyer()
{
   if(!this->underlyerIsNull_){
        if(underlyerIDRef_ != ""){
             return boost::shared_static_cast<Underlyer>(IDManager::instance().getID(underlyerIDRef_));
        }else{
             return this->underlyer_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Underlyer>();
   }
}
}

