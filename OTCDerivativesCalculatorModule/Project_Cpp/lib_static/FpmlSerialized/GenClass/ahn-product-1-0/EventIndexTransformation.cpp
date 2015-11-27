// EventIndexTransformation.cpp 
#include "EventIndexTransformation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EventIndexTransformation::EventIndexTransformation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //indexCalculationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* indexCalculationNode = xmlNode->FirstChildElement("indexCalculation");

   if(indexCalculationNode){indexCalculationIsNull_ = false;}
   else{indexCalculationIsNull_ = true;}

   if(indexCalculationNode)
   {
      for(indexCalculationNode; indexCalculationNode; indexCalculationNode = indexCalculationNode->NextSiblingElement("indexCalculation")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- indexCalculationNode , address : " << indexCalculationNode << std::endl;
          #endif
          if(indexCalculationNode->Attribute("href") || indexCalculationNode->Attribute("id"))
          {
              if(indexCalculationNode->Attribute("id"))
              {
                  indexCalculationIDRef_ = indexCalculationNode->Attribute("id");
                  indexCalculation_.push_back(boost::shared_ptr<IndexCalculation>(new IndexCalculation(indexCalculationNode)));
                  indexCalculation_.back()->setID(indexCalculationIDRef_);
                  IDManager::instance().setID(indexCalculationIDRef_, indexCalculation_.back());
              }
              else if(indexCalculationNode->Attribute("href")) { indexCalculationIDRef_ = indexCalculationNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { indexCalculation_.push_back(boost::shared_ptr<IndexCalculation>(new IndexCalculation(indexCalculationNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- indexCalculationNode , address : " << indexCalculationNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<IndexCalculation>> EventIndexTransformation::getIndexCalculation()
{
   if(!this->indexCalculationIsNull_){
        if(indexCalculationIDRef_ != ""){
             return this->indexCalculation_;
        }else{
             return this->indexCalculation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<IndexCalculation>>();
   }
}
}

