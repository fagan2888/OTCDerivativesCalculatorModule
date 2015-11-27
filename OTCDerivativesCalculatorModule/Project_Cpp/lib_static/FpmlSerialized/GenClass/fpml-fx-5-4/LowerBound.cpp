// LowerBound.cpp 
#include "LowerBound.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

LowerBound::LowerBound(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //minimumInclusiveNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* minimumInclusiveNode = xmlNode->FirstChildElement("minimumInclusive");

   if(minimumInclusiveNode){minimumInclusiveIsNull_ = false;}
   else{minimumInclusiveIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- minimumInclusiveNode , address : " << minimumInclusiveNode << std::endl;
   #endif
   if(minimumInclusiveNode)
   {
      if(minimumInclusiveNode->Attribute("href") || minimumInclusiveNode->Attribute("id"))
      {
          if(minimumInclusiveNode->Attribute("id"))
          {
             minimumInclusiveIDRef_ = minimumInclusiveNode->Attribute("id");
             minimumInclusive_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(minimumInclusiveNode));
             minimumInclusive_->setID(minimumInclusiveIDRef_);
             IDManager::instance().setID(minimumInclusiveIDRef_,minimumInclusive_);
          }
          else if(minimumInclusiveNode->Attribute("href")) { minimumInclusiveIDRef_ = minimumInclusiveNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { minimumInclusive_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(minimumInclusiveNode));}
   }

   //minimumExclusiveNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* minimumExclusiveNode = xmlNode->FirstChildElement("minimumExclusive");

   if(minimumExclusiveNode){minimumExclusiveIsNull_ = false;}
   else{minimumExclusiveIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- minimumExclusiveNode , address : " << minimumExclusiveNode << std::endl;
   #endif
   if(minimumExclusiveNode)
   {
      if(minimumExclusiveNode->Attribute("href") || minimumExclusiveNode->Attribute("id"))
      {
          if(minimumExclusiveNode->Attribute("id"))
          {
             minimumExclusiveIDRef_ = minimumExclusiveNode->Attribute("id");
             minimumExclusive_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(minimumExclusiveNode));
             minimumExclusive_->setID(minimumExclusiveIDRef_);
             IDManager::instance().setID(minimumExclusiveIDRef_,minimumExclusive_);
          }
          else if(minimumExclusiveNode->Attribute("href")) { minimumExclusiveIDRef_ = minimumExclusiveNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { minimumExclusive_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(minimumExclusiveNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PositiveDecimal> LowerBound::getMinimumInclusive()
{
   if(!this->minimumInclusiveIsNull_){
        if(minimumInclusiveIDRef_ != ""){
             return boost::shared_static_cast<PositiveDecimal>(IDManager::instance().getID(minimumInclusiveIDRef_));
        }else{
             return this->minimumInclusive_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PositiveDecimal>();
   }
}
boost::shared_ptr<PositiveDecimal> LowerBound::getMinimumExclusive()
{
   if(!this->minimumExclusiveIsNull_){
        if(minimumExclusiveIDRef_ != ""){
             return boost::shared_static_cast<PositiveDecimal>(IDManager::instance().getID(minimumExclusiveIDRef_));
        }else{
             return this->minimumExclusive_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PositiveDecimal>();
   }
}
}

