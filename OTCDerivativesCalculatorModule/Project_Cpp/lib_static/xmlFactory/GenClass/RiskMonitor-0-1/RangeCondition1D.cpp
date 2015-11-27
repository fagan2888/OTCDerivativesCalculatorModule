// RangeCondition1D.cpp 
#include "RangeCondition1D.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

RangeCondition1D::RangeCondition1D(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //range1DNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* range1DNode = xmlNode->FirstChildElement("range1D");

   if(range1DNode){range1DIsNull_ = false;}
   else{range1DIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- range1DNode , address : " << range1DNode << std::endl;
   #endif
   if(range1DNode)
   {
       range1D_ = boost::shared_ptr<Range1D>(new Range1D(range1DNode));
   }

   //constValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* constValueNode = xmlNode->FirstChildElement("constValue");

   if(constValueNode){constValueIsNull_ = false;}
   else{constValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- constValueNode , address : " << constValueNode << std::endl;
   #endif
   if(constValueNode)
   {
       constValue_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(constValueNode));
   }

   //refNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* refNameNode = xmlNode->FirstChildElement("refName");

   if(refNameNode){refNameIsNull_ = false;}
   else{refNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- refNameNode , address : " << refNameNode << std::endl;
   #endif
   if(refNameNode)
   {
       refName_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(refNameNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Range1D> RangeCondition1D::getRange1D()
{
   if(!this->range1DIsNull_){
        return this->range1D_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Range1D>();
   }
}
boost::shared_ptr<XsdTypeToken> RangeCondition1D::getConstValue()
{
   if(!this->constValueIsNull_){
        return this->constValue_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> RangeCondition1D::getRefName()
{
   if(!this->refNameIsNull_){
        return this->refName_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

