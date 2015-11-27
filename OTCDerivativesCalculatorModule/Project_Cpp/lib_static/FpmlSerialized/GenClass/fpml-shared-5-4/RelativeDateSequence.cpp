// RelativeDateSequence.cpp 
#include "RelativeDateSequence.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

RelativeDateSequence::RelativeDateSequence(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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

   //dateOffsetNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dateOffsetNode = xmlNode->FirstChildElement("dateOffset");

   if(dateOffsetNode){dateOffsetIsNull_ = false;}
   else{dateOffsetIsNull_ = true;}

   if(dateOffsetNode)
   {
      for(dateOffsetNode; dateOffsetNode; dateOffsetNode = dateOffsetNode->NextSiblingElement("dateOffset")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dateOffsetNode , address : " << dateOffsetNode << std::endl;
          #endif
          if(dateOffsetNode->Attribute("href") || dateOffsetNode->Attribute("id"))
          {
              if(dateOffsetNode->Attribute("id"))
              {
                  dateOffsetIDRef_ = dateOffsetNode->Attribute("id");
                  dateOffset_.push_back(boost::shared_ptr<DateOffset>(new DateOffset(dateOffsetNode)));
                  dateOffset_.back()->setID(dateOffsetIDRef_);
                  IDManager::instance().setID(dateOffsetIDRef_, dateOffset_.back());
              }
              else if(dateOffsetNode->Attribute("href")) { dateOffsetIDRef_ = dateOffsetNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { dateOffset_.push_back(boost::shared_ptr<DateOffset>(new DateOffset(dateOffsetNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dateOffsetNode , address : " << dateOffsetNode << std::endl;
       #endif
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

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<DateReference> RelativeDateSequence::getDateRelativeTo()
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
std::vector<boost::shared_ptr<DateOffset>> RelativeDateSequence::getDateOffset()
{
   if(!this->dateOffsetIsNull_){
        if(dateOffsetIDRef_ != ""){
             return this->dateOffset_;
        }else{
             return this->dateOffset_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<DateOffset>>();
   }
}
boost::shared_ptr<BusinessCentersReference> RelativeDateSequence::getBusinessCentersReference()
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
boost::shared_ptr<BusinessCenters> RelativeDateSequence::getBusinessCenters()
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
}

