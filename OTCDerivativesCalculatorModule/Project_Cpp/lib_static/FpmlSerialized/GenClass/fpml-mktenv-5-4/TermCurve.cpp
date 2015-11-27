// TermCurve.cpp 
#include "TermCurve.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

TermCurve::TermCurve(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //interpolationMethodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* interpolationMethodNode = xmlNode->FirstChildElement("interpolationMethod");

   if(interpolationMethodNode){interpolationMethodIsNull_ = false;}
   else{interpolationMethodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- interpolationMethodNode , address : " << interpolationMethodNode << std::endl;
   #endif
   if(interpolationMethodNode)
   {
      if(interpolationMethodNode->Attribute("href") || interpolationMethodNode->Attribute("id"))
      {
          if(interpolationMethodNode->Attribute("id"))
          {
             interpolationMethodIDRef_ = interpolationMethodNode->Attribute("id");
             interpolationMethod_ = boost::shared_ptr<InterpolationMethod>(new InterpolationMethod(interpolationMethodNode));
             interpolationMethod_->setID(interpolationMethodIDRef_);
             IDManager::instance().setID(interpolationMethodIDRef_,interpolationMethod_);
          }
          else if(interpolationMethodNode->Attribute("href")) { interpolationMethodIDRef_ = interpolationMethodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { interpolationMethod_ = boost::shared_ptr<InterpolationMethod>(new InterpolationMethod(interpolationMethodNode));}
   }

   //extrapolationPermittedNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* extrapolationPermittedNode = xmlNode->FirstChildElement("extrapolationPermitted");

   if(extrapolationPermittedNode){extrapolationPermittedIsNull_ = false;}
   else{extrapolationPermittedIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- extrapolationPermittedNode , address : " << extrapolationPermittedNode << std::endl;
   #endif
   if(extrapolationPermittedNode)
   {
      if(extrapolationPermittedNode->Attribute("href") || extrapolationPermittedNode->Attribute("id"))
      {
          if(extrapolationPermittedNode->Attribute("id"))
          {
             extrapolationPermittedIDRef_ = extrapolationPermittedNode->Attribute("id");
             extrapolationPermitted_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(extrapolationPermittedNode));
             extrapolationPermitted_->setID(extrapolationPermittedIDRef_);
             IDManager::instance().setID(extrapolationPermittedIDRef_,extrapolationPermitted_);
          }
          else if(extrapolationPermittedNode->Attribute("href")) { extrapolationPermittedIDRef_ = extrapolationPermittedNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { extrapolationPermitted_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(extrapolationPermittedNode));}
   }

   //pointNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* pointNode = xmlNode->FirstChildElement("point");

   if(pointNode){pointIsNull_ = false;}
   else{pointIsNull_ = true;}

   if(pointNode)
   {
      for(pointNode; pointNode; pointNode = pointNode->NextSiblingElement("point")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- pointNode , address : " << pointNode << std::endl;
          #endif
          if(pointNode->Attribute("href") || pointNode->Attribute("id"))
          {
              if(pointNode->Attribute("id"))
              {
                  pointIDRef_ = pointNode->Attribute("id");
                  point_.push_back(boost::shared_ptr<TermPoint>(new TermPoint(pointNode)));
                  point_.back()->setID(pointIDRef_);
                  IDManager::instance().setID(pointIDRef_, point_.back());
              }
              else if(pointNode->Attribute("href")) { pointIDRef_ = pointNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { point_.push_back(boost::shared_ptr<TermPoint>(new TermPoint(pointNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- pointNode , address : " << pointNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<InterpolationMethod> TermCurve::getInterpolationMethod()
{
   if(!this->interpolationMethodIsNull_){
        if(interpolationMethodIDRef_ != ""){
             return boost::shared_static_cast<InterpolationMethod>(IDManager::instance().getID(interpolationMethodIDRef_));
        }else{
             return this->interpolationMethod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<InterpolationMethod>();
   }
}
boost::shared_ptr<XsdTypeBoolean> TermCurve::getExtrapolationPermitted()
{
   if(!this->extrapolationPermittedIsNull_){
        if(extrapolationPermittedIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(extrapolationPermittedIDRef_));
        }else{
             return this->extrapolationPermitted_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
std::vector<boost::shared_ptr<TermPoint>> TermCurve::getPoint()
{
   if(!this->pointIsNull_){
        if(pointIDRef_ != ""){
             return this->point_;
        }else{
             return this->point_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<TermPoint>>();
   }
}
}

