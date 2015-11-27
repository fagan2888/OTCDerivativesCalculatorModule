// FixingInformation.cpp 
#include "FixingInformation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FixingInformation::FixingInformation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //initialValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* initialValueNode = xmlNode->FirstChildElement("initialValue");

   if(initialValueNode){initialValueIsNull_ = false;}
   else{initialValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- initialValueNode , address : " << initialValueNode << std::endl;
   #endif
   if(initialValueNode)
   {
       initialValue_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(initialValueNode));
   }

   //fixingNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixingNode = xmlNode->FirstChildElement("fixing");

   if(fixingNode){fixingIsNull_ = false;}
   else{fixingIsNull_ = true;}

   if(fixingNode)
   {
      for(fixingNode; fixingNode; fixingNode = fixingNode->NextSiblingElement("fixing")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixingNode , address : " << fixingNode << std::endl;
          #endif
          fixing_.push_back(boost::shared_ptr<Fixing>(new Fixing(fixingNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixingNode , address : " << fixingNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDouble> FixingInformation::getInitialValue()
{
   if(!this->initialValueIsNull_){
        return this->initialValue_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
std::vector<boost::shared_ptr<Fixing>> FixingInformation::getFixing()
{
   if(!this->fixingIsNull_){
        return this->fixing_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Fixing>>();
   }
}
}

