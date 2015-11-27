// StartingDate.cpp 
#include "StartingDate.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

StartingDate::StartingDate(TiXmlNode* xmlNode)
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

   //adjustableDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* adjustableDateNode = xmlNode->FirstChildElement("adjustableDate");

   if(adjustableDateNode){adjustableDateIsNull_ = false;}
   else{adjustableDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- adjustableDateNode , address : " << adjustableDateNode << std::endl;
   #endif
   if(adjustableDateNode)
   {
      if(adjustableDateNode->Attribute("href") || adjustableDateNode->Attribute("id"))
      {
          if(adjustableDateNode->Attribute("id"))
          {
             adjustableDateIDRef_ = adjustableDateNode->Attribute("id");
             adjustableDate_ = boost::shared_ptr<AdjustableDate>(new AdjustableDate(adjustableDateNode));
             adjustableDate_->setID(adjustableDateIDRef_);
             IDManager::instance().setID(adjustableDateIDRef_,adjustableDate_);
          }
          else if(adjustableDateNode->Attribute("href")) { adjustableDateIDRef_ = adjustableDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { adjustableDate_ = boost::shared_ptr<AdjustableDate>(new AdjustableDate(adjustableDateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<DateReference> StartingDate::getDateRelativeTo()
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
boost::shared_ptr<AdjustableDate> StartingDate::getAdjustableDate()
{
   if(!this->adjustableDateIsNull_){
        if(adjustableDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableDate>(IDManager::instance().getID(adjustableDateIDRef_));
        }else{
             return this->adjustableDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableDate>();
   }
}
}

