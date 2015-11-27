// UpperBound.cpp 
#include "UpperBound.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

UpperBound::UpperBound(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //maximumInclusiveNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* maximumInclusiveNode = xmlNode->FirstChildElement("maximumInclusive");

   if(maximumInclusiveNode){maximumInclusiveIsNull_ = false;}
   else{maximumInclusiveIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- maximumInclusiveNode , address : " << maximumInclusiveNode << std::endl;
   #endif
   if(maximumInclusiveNode)
   {
      if(maximumInclusiveNode->Attribute("href") || maximumInclusiveNode->Attribute("id"))
      {
          if(maximumInclusiveNode->Attribute("id"))
          {
             maximumInclusiveIDRef_ = maximumInclusiveNode->Attribute("id");
             maximumInclusive_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(maximumInclusiveNode));
             maximumInclusive_->setID(maximumInclusiveIDRef_);
             IDManager::instance().setID(maximumInclusiveIDRef_,maximumInclusive_);
          }
          else if(maximumInclusiveNode->Attribute("href")) { maximumInclusiveIDRef_ = maximumInclusiveNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { maximumInclusive_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(maximumInclusiveNode));}
   }

   //maximumExclusiveNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* maximumExclusiveNode = xmlNode->FirstChildElement("maximumExclusive");

   if(maximumExclusiveNode){maximumExclusiveIsNull_ = false;}
   else{maximumExclusiveIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- maximumExclusiveNode , address : " << maximumExclusiveNode << std::endl;
   #endif
   if(maximumExclusiveNode)
   {
      if(maximumExclusiveNode->Attribute("href") || maximumExclusiveNode->Attribute("id"))
      {
          if(maximumExclusiveNode->Attribute("id"))
          {
             maximumExclusiveIDRef_ = maximumExclusiveNode->Attribute("id");
             maximumExclusive_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(maximumExclusiveNode));
             maximumExclusive_->setID(maximumExclusiveIDRef_);
             IDManager::instance().setID(maximumExclusiveIDRef_,maximumExclusive_);
          }
          else if(maximumExclusiveNode->Attribute("href")) { maximumExclusiveIDRef_ = maximumExclusiveNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { maximumExclusive_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(maximumExclusiveNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PositiveDecimal> UpperBound::getMaximumInclusive()
{
   if(!this->maximumInclusiveIsNull_){
        if(maximumInclusiveIDRef_ != ""){
             return boost::shared_static_cast<PositiveDecimal>(IDManager::instance().getID(maximumInclusiveIDRef_));
        }else{
             return this->maximumInclusive_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PositiveDecimal>();
   }
}
boost::shared_ptr<PositiveDecimal> UpperBound::getMaximumExclusive()
{
   if(!this->maximumExclusiveIsNull_){
        if(maximumExclusiveIDRef_ != ""){
             return boost::shared_static_cast<PositiveDecimal>(IDManager::instance().getID(maximumExclusiveIDRef_));
        }else{
             return this->maximumExclusive_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PositiveDecimal>();
   }
}
}

