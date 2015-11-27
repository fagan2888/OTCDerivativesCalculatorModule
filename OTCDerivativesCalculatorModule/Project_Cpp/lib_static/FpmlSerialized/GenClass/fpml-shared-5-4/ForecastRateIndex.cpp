// ForecastRateIndex.cpp 
#include "ForecastRateIndex.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ForecastRateIndex::ForecastRateIndex(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //floatingRateIndexNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* floatingRateIndexNode = xmlNode->FirstChildElement("floatingRateIndex");

   if(floatingRateIndexNode){floatingRateIndexIsNull_ = false;}
   else{floatingRateIndexIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- floatingRateIndexNode , address : " << floatingRateIndexNode << std::endl;
   #endif
   if(floatingRateIndexNode)
   {
      if(floatingRateIndexNode->Attribute("href") || floatingRateIndexNode->Attribute("id"))
      {
          if(floatingRateIndexNode->Attribute("id"))
          {
             floatingRateIndexIDRef_ = floatingRateIndexNode->Attribute("id");
             floatingRateIndex_ = boost::shared_ptr<FloatingRateIndex>(new FloatingRateIndex(floatingRateIndexNode));
             floatingRateIndex_->setID(floatingRateIndexIDRef_);
             IDManager::instance().setID(floatingRateIndexIDRef_,floatingRateIndex_);
          }
          else if(floatingRateIndexNode->Attribute("href")) { floatingRateIndexIDRef_ = floatingRateIndexNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { floatingRateIndex_ = boost::shared_ptr<FloatingRateIndex>(new FloatingRateIndex(floatingRateIndexNode));}
   }

   //indexTenorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* indexTenorNode = xmlNode->FirstChildElement("indexTenor");

   if(indexTenorNode){indexTenorIsNull_ = false;}
   else{indexTenorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- indexTenorNode , address : " << indexTenorNode << std::endl;
   #endif
   if(indexTenorNode)
   {
      if(indexTenorNode->Attribute("href") || indexTenorNode->Attribute("id"))
      {
          if(indexTenorNode->Attribute("id"))
          {
             indexTenorIDRef_ = indexTenorNode->Attribute("id");
             indexTenor_ = boost::shared_ptr<Period>(new Period(indexTenorNode));
             indexTenor_->setID(indexTenorIDRef_);
             IDManager::instance().setID(indexTenorIDRef_,indexTenor_);
          }
          else if(indexTenorNode->Attribute("href")) { indexTenorIDRef_ = indexTenorNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { indexTenor_ = boost::shared_ptr<Period>(new Period(indexTenorNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<FloatingRateIndex> ForecastRateIndex::getFloatingRateIndex()
{
   if(!this->floatingRateIndexIsNull_){
        if(floatingRateIndexIDRef_ != ""){
             return boost::shared_static_cast<FloatingRateIndex>(IDManager::instance().getID(floatingRateIndexIDRef_));
        }else{
             return this->floatingRateIndex_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FloatingRateIndex>();
   }
}
boost::shared_ptr<Period> ForecastRateIndex::getIndexTenor()
{
   if(!this->indexTenorIsNull_){
        if(indexTenorIDRef_ != ""){
             return boost::shared_static_cast<Period>(IDManager::instance().getID(indexTenorIDRef_));
        }else{
             return this->indexTenor_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Period>();
   }
}
}

