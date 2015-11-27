// Range1D.cpp 
#include "Range1D.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Range1D::Range1D(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //lowerBoundNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* lowerBoundNode = xmlNode->FirstChildElement("lowerBound");

   if(lowerBoundNode){lowerBoundIsNull_ = false;}
   else{lowerBoundIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- lowerBoundNode , address : " << lowerBoundNode << std::endl;
   #endif
   if(lowerBoundNode)
   {
       lowerBound_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(lowerBoundNode));
   }

   //upperBoundNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* upperBoundNode = xmlNode->FirstChildElement("upperBound");

   if(upperBoundNode){upperBoundIsNull_ = false;}
   else{upperBoundIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- upperBoundNode , address : " << upperBoundNode << std::endl;
   #endif
   if(upperBoundNode)
   {
       upperBound_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(upperBoundNode));
   }

   //lowerBoundEqualityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* lowerBoundEqualityNode = xmlNode->FirstChildElement("lowerBoundEquality");

   if(lowerBoundEqualityNode){lowerBoundEqualityIsNull_ = false;}
   else{lowerBoundEqualityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- lowerBoundEqualityNode , address : " << lowerBoundEqualityNode << std::endl;
   #endif
   if(lowerBoundEqualityNode)
   {
       lowerBoundEquality_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(lowerBoundEqualityNode));
   }

   //upperBoundEqualityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* upperBoundEqualityNode = xmlNode->FirstChildElement("upperBoundEquality");

   if(upperBoundEqualityNode){upperBoundEqualityIsNull_ = false;}
   else{upperBoundEqualityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- upperBoundEqualityNode , address : " << upperBoundEqualityNode << std::endl;
   #endif
   if(upperBoundEqualityNode)
   {
       upperBoundEquality_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(upperBoundEqualityNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDouble> Range1D::getLowerBound()
{
   if(!this->lowerBoundIsNull_){
        return this->lowerBound_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
boost::shared_ptr<XsdTypeDouble> Range1D::getUpperBound()
{
   if(!this->upperBoundIsNull_){
        return this->upperBound_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
boost::shared_ptr<XsdTypeDouble> Range1D::getLowerBoundEquality()
{
   if(!this->lowerBoundEqualityIsNull_){
        return this->lowerBoundEquality_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
boost::shared_ptr<XsdTypeDouble> Range1D::getUpperBoundEquality()
{
   if(!this->upperBoundEqualityIsNull_){
        return this->upperBoundEquality_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
}

