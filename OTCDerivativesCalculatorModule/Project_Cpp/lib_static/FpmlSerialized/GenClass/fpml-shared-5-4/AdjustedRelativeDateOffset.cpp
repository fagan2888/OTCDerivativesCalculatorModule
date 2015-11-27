// AdjustedRelativeDateOffset.cpp 
#include "AdjustedRelativeDateOffset.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

AdjustedRelativeDateOffset::AdjustedRelativeDateOffset(TiXmlNode* xmlNode)
: RelativeDateOffset(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //relativeDateAdjustmentsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* relativeDateAdjustmentsNode = xmlNode->FirstChildElement("relativeDateAdjustments");

   if(relativeDateAdjustmentsNode){relativeDateAdjustmentsIsNull_ = false;}
   else{relativeDateAdjustmentsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- relativeDateAdjustmentsNode , address : " << relativeDateAdjustmentsNode << std::endl;
   #endif
   if(relativeDateAdjustmentsNode)
   {
      if(relativeDateAdjustmentsNode->Attribute("href") || relativeDateAdjustmentsNode->Attribute("id"))
      {
          if(relativeDateAdjustmentsNode->Attribute("id"))
          {
             relativeDateAdjustmentsIDRef_ = relativeDateAdjustmentsNode->Attribute("id");
             relativeDateAdjustments_ = boost::shared_ptr<BusinessDayAdjustments>(new BusinessDayAdjustments(relativeDateAdjustmentsNode));
             relativeDateAdjustments_->setID(relativeDateAdjustmentsIDRef_);
             IDManager::instance().setID(relativeDateAdjustmentsIDRef_,relativeDateAdjustments_);
          }
          else if(relativeDateAdjustmentsNode->Attribute("href")) { relativeDateAdjustmentsIDRef_ = relativeDateAdjustmentsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { relativeDateAdjustments_ = boost::shared_ptr<BusinessDayAdjustments>(new BusinessDayAdjustments(relativeDateAdjustmentsNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<BusinessDayAdjustments> AdjustedRelativeDateOffset::getRelativeDateAdjustments()
{
   if(!this->relativeDateAdjustmentsIsNull_){
        if(relativeDateAdjustmentsIDRef_ != ""){
             return boost::shared_static_cast<BusinessDayAdjustments>(IDManager::instance().getID(relativeDateAdjustmentsIDRef_));
        }else{
             return this->relativeDateAdjustments_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessDayAdjustments>();
   }
}
}

