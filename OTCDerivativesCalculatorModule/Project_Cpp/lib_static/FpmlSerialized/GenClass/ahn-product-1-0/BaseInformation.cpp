// BaseInformation.cpp 
#include "BaseInformation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

BaseInformation::BaseInformation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //baseIndexesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* baseIndexesNode = xmlNode->FirstChildElement("baseIndexes");

   if(baseIndexesNode){baseIndexesIsNull_ = false;}
   else{baseIndexesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- baseIndexesNode , address : " << baseIndexesNode << std::endl;
   #endif
   if(baseIndexesNode)
   {
      if(baseIndexesNode->Attribute("href") || baseIndexesNode->Attribute("id"))
      {
          if(baseIndexesNode->Attribute("id"))
          {
             baseIndexesIDRef_ = baseIndexesNode->Attribute("id");
             baseIndexes_ = boost::shared_ptr<BaseIndexes>(new BaseIndexes(baseIndexesNode));
             baseIndexes_->setID(baseIndexesIDRef_);
             IDManager::instance().setID(baseIndexesIDRef_,baseIndexes_);
          }
          else if(baseIndexesNode->Attribute("href")) { baseIndexesIDRef_ = baseIndexesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { baseIndexes_ = boost::shared_ptr<BaseIndexes>(new BaseIndexes(baseIndexesNode));}
   }

   //conventionSetNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* conventionSetNode = xmlNode->FirstChildElement("conventionSet");

   if(conventionSetNode){conventionSetIsNull_ = false;}
   else{conventionSetIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- conventionSetNode , address : " << conventionSetNode << std::endl;
   #endif
   if(conventionSetNode)
   {
      if(conventionSetNode->Attribute("href") || conventionSetNode->Attribute("id"))
      {
          if(conventionSetNode->Attribute("id"))
          {
             conventionSetIDRef_ = conventionSetNode->Attribute("id");
             conventionSet_ = boost::shared_ptr<ConventionSet>(new ConventionSet(conventionSetNode));
             conventionSet_->setID(conventionSetIDRef_);
             IDManager::instance().setID(conventionSetIDRef_,conventionSet_);
          }
          else if(conventionSetNode->Attribute("href")) { conventionSetIDRef_ = conventionSetNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { conventionSet_ = boost::shared_ptr<ConventionSet>(new ConventionSet(conventionSetNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<BaseIndexes> BaseInformation::getBaseIndexes()
{
   if(!this->baseIndexesIsNull_){
        if(baseIndexesIDRef_ != ""){
             return boost::shared_static_cast<BaseIndexes>(IDManager::instance().getID(baseIndexesIDRef_));
        }else{
             return this->baseIndexes_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BaseIndexes>();
   }
}
boost::shared_ptr<ConventionSet> BaseInformation::getConventionSet()
{
   if(!this->conventionSetIsNull_){
        if(conventionSetIDRef_ != ""){
             return boost::shared_static_cast<ConventionSet>(IDManager::instance().getID(conventionSetIDRef_));
        }else{
             return this->conventionSet_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ConventionSet>();
   }
}
}

