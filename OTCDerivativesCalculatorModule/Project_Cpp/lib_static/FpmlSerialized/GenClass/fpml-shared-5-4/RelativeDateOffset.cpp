// RelativeDateOffset.cpp 
#include "RelativeDateOffset.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

RelativeDateOffset::RelativeDateOffset(TiXmlNode* xmlNode)
: Offset(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //businessDayConventionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* businessDayConventionNode = xmlNode->FirstChildElement("businessDayConvention");

   if(businessDayConventionNode){businessDayConventionIsNull_ = false;}
   else{businessDayConventionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessDayConventionNode , address : " << businessDayConventionNode << std::endl;
   #endif
   if(businessDayConventionNode)
   {
      if(businessDayConventionNode->Attribute("href") || businessDayConventionNode->Attribute("id"))
      {
          if(businessDayConventionNode->Attribute("id"))
          {
             businessDayConventionIDRef_ = businessDayConventionNode->Attribute("id");
             businessDayConvention_ = boost::shared_ptr<BusinessDayConventionEnum>(new BusinessDayConventionEnum(businessDayConventionNode));
             businessDayConvention_->setID(businessDayConventionIDRef_);
             IDManager::instance().setID(businessDayConventionIDRef_,businessDayConvention_);
          }
          else if(businessDayConventionNode->Attribute("href")) { businessDayConventionIDRef_ = businessDayConventionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { businessDayConvention_ = boost::shared_ptr<BusinessDayConventionEnum>(new BusinessDayConventionEnum(businessDayConventionNode));}
   }

   //businessCentersReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* businessCentersReferenceNode = xmlNode->FirstChildElement("businessCentersReference");

   if(businessCentersReferenceNode){businessCentersReferenceIsNull_ = false;}
   else{businessCentersReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessCentersReferenceNode , address : " << businessCentersReferenceNode << std::endl;
   #endif
   if(businessCentersReferenceNode)
   {
      if(businessCentersReferenceNode->Attribute("href") || businessCentersReferenceNode->Attribute("id"))
      {
          if(businessCentersReferenceNode->Attribute("id"))
          {
             businessCentersReferenceIDRef_ = businessCentersReferenceNode->Attribute("id");
             businessCentersReference_ = boost::shared_ptr<BusinessCentersReference>(new BusinessCentersReference(businessCentersReferenceNode));
             businessCentersReference_->setID(businessCentersReferenceIDRef_);
             IDManager::instance().setID(businessCentersReferenceIDRef_,businessCentersReference_);
          }
          else if(businessCentersReferenceNode->Attribute("href")) { businessCentersReferenceIDRef_ = businessCentersReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { businessCentersReference_ = boost::shared_ptr<BusinessCentersReference>(new BusinessCentersReference(businessCentersReferenceNode));}
   }

   //businessCentersNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* businessCentersNode = xmlNode->FirstChildElement("businessCenters");

   if(businessCentersNode){businessCentersIsNull_ = false;}
   else{businessCentersIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessCentersNode , address : " << businessCentersNode << std::endl;
   #endif
   if(businessCentersNode)
   {
      if(businessCentersNode->Attribute("href") || businessCentersNode->Attribute("id"))
      {
          if(businessCentersNode->Attribute("id"))
          {
             businessCentersIDRef_ = businessCentersNode->Attribute("id");
             businessCenters_ = boost::shared_ptr<BusinessCenters>(new BusinessCenters(businessCentersNode));
             businessCenters_->setID(businessCentersIDRef_);
             IDManager::instance().setID(businessCentersIDRef_,businessCenters_);
          }
          else if(businessCentersNode->Attribute("href")) { businessCentersIDRef_ = businessCentersNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { businessCenters_ = boost::shared_ptr<BusinessCenters>(new BusinessCenters(businessCentersNode));}
   }

   //dateRelativeToNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dateRelativeToNode = xmlNode->FirstChildElement("dateRelativeTo");

   if(dateRelativeToNode){dateRelativeToIsNull_ = false;}
   else{dateRelativeToIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dateRelativeToNode , address : " << dateRelativeToNode << std::endl;
   #endif
   if(dateRelativeToNode)
   {
      if(dateRelativeToNode->Attribute("href") || dateRelativeToNode->Attribute("id"))
      {
          if(dateRelativeToNode->Attribute("id"))
          {
             dateRelativeToIDRef_ = dateRelativeToNode->Attribute("id");
             dateRelativeTo_ = boost::shared_ptr<DateReference>(new DateReference(dateRelativeToNode));
             dateRelativeTo_->setID(dateRelativeToIDRef_);
             IDManager::instance().setID(dateRelativeToIDRef_,dateRelativeTo_);
          }
          else if(dateRelativeToNode->Attribute("href")) { dateRelativeToIDRef_ = dateRelativeToNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dateRelativeTo_ = boost::shared_ptr<DateReference>(new DateReference(dateRelativeToNode));}
   }

   //adjustedDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* adjustedDateNode = xmlNode->FirstChildElement("adjustedDate");

   if(adjustedDateNode){adjustedDateIsNull_ = false;}
   else{adjustedDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- adjustedDateNode , address : " << adjustedDateNode << std::endl;
   #endif
   if(adjustedDateNode)
   {
      if(adjustedDateNode->Attribute("href") || adjustedDateNode->Attribute("id"))
      {
          if(adjustedDateNode->Attribute("id"))
          {
             adjustedDateIDRef_ = adjustedDateNode->Attribute("id");
             adjustedDate_ = boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(adjustedDateNode));
             adjustedDate_->setID(adjustedDateIDRef_);
             IDManager::instance().setID(adjustedDateIDRef_,adjustedDate_);
          }
          else if(adjustedDateNode->Attribute("href")) { adjustedDateIDRef_ = adjustedDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { adjustedDate_ = boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(adjustedDateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<BusinessDayConventionEnum> RelativeDateOffset::getBusinessDayConvention()
{
   if(!this->businessDayConventionIsNull_){
        if(businessDayConventionIDRef_ != ""){
             return boost::shared_static_cast<BusinessDayConventionEnum>(IDManager::instance().getID(businessDayConventionIDRef_));
        }else{
             return this->businessDayConvention_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessDayConventionEnum>();
   }
}
boost::shared_ptr<BusinessCentersReference> RelativeDateOffset::getBusinessCentersReference()
{
   if(!this->businessCentersReferenceIsNull_){
        if(businessCentersReferenceIDRef_ != ""){
             return boost::shared_static_cast<BusinessCentersReference>(IDManager::instance().getID(businessCentersReferenceIDRef_));
        }else{
             return this->businessCentersReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessCentersReference>();
   }
}
boost::shared_ptr<BusinessCenters> RelativeDateOffset::getBusinessCenters()
{
   if(!this->businessCentersIsNull_){
        if(businessCentersIDRef_ != ""){
             return boost::shared_static_cast<BusinessCenters>(IDManager::instance().getID(businessCentersIDRef_));
        }else{
             return this->businessCenters_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessCenters>();
   }
}
boost::shared_ptr<DateReference> RelativeDateOffset::getDateRelativeTo()
{
   if(!this->dateRelativeToIsNull_){
        if(dateRelativeToIDRef_ != ""){
             return boost::shared_static_cast<DateReference>(IDManager::instance().getID(dateRelativeToIDRef_));
        }else{
             return this->dateRelativeTo_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DateReference>();
   }
}
boost::shared_ptr<IdentifiedDate> RelativeDateOffset::getAdjustedDate()
{
   if(!this->adjustedDateIsNull_){
        if(adjustedDateIDRef_ != ""){
             return boost::shared_static_cast<IdentifiedDate>(IDManager::instance().getID(adjustedDateIDRef_));
        }else{
             return this->adjustedDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IdentifiedDate>();
   }
}
}

