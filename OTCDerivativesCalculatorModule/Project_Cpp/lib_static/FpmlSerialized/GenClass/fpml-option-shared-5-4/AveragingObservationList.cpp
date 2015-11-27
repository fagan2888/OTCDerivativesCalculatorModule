// AveragingObservationList.cpp 
#include "AveragingObservationList.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

AveragingObservationList::AveragingObservationList(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //averagingObservationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* averagingObservationNode = xmlNode->FirstChildElement("averagingObservation");

   if(averagingObservationNode){averagingObservationIsNull_ = false;}
   else{averagingObservationIsNull_ = true;}

   if(averagingObservationNode)
   {
      for(averagingObservationNode; averagingObservationNode; averagingObservationNode = averagingObservationNode->NextSiblingElement("averagingObservation")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- averagingObservationNode , address : " << averagingObservationNode << std::endl;
          #endif
          if(averagingObservationNode->Attribute("href") || averagingObservationNode->Attribute("id"))
          {
              if(averagingObservationNode->Attribute("id"))
              {
                  averagingObservationIDRef_ = averagingObservationNode->Attribute("id");
                  averagingObservation_.push_back(boost::shared_ptr<WeightedAveragingObservation>(new WeightedAveragingObservation(averagingObservationNode)));
                  averagingObservation_.back()->setID(averagingObservationIDRef_);
                  IDManager::instance().setID(averagingObservationIDRef_, averagingObservation_.back());
              }
              else if(averagingObservationNode->Attribute("href")) { averagingObservationIDRef_ = averagingObservationNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { averagingObservation_.push_back(boost::shared_ptr<WeightedAveragingObservation>(new WeightedAveragingObservation(averagingObservationNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- averagingObservationNode , address : " << averagingObservationNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<WeightedAveragingObservation>> AveragingObservationList::getAveragingObservation()
{
   if(!this->averagingObservationIsNull_){
        if(averagingObservationIDRef_ != ""){
             return this->averagingObservation_;
        }else{
             return this->averagingObservation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<WeightedAveragingObservation>>();
   }
}
}

