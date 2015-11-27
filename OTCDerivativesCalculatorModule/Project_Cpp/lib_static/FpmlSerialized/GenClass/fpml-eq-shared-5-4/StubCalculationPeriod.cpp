// StubCalculationPeriod.cpp 
#include "StubCalculationPeriod.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

StubCalculationPeriod::StubCalculationPeriod(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //initialStubNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* initialStubNode = xmlNode->FirstChildElement("initialStub");

   if(initialStubNode){initialStubIsNull_ = false;}
   else{initialStubIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- initialStubNode , address : " << initialStubNode << std::endl;
   #endif
   if(initialStubNode)
   {
      if(initialStubNode->Attribute("href") || initialStubNode->Attribute("id"))
      {
          if(initialStubNode->Attribute("id"))
          {
             initialStubIDRef_ = initialStubNode->Attribute("id");
             initialStub_ = boost::shared_ptr<Stub>(new Stub(initialStubNode));
             initialStub_->setID(initialStubIDRef_);
             IDManager::instance().setID(initialStubIDRef_,initialStub_);
          }
          else if(initialStubNode->Attribute("href")) { initialStubIDRef_ = initialStubNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { initialStub_ = boost::shared_ptr<Stub>(new Stub(initialStubNode));}
   }

   //finalStubNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* finalStubNode = xmlNode->FirstChildElement("finalStub");

   if(finalStubNode){finalStubIsNull_ = false;}
   else{finalStubIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- finalStubNode , address : " << finalStubNode << std::endl;
   #endif
   if(finalStubNode)
   {
      if(finalStubNode->Attribute("href") || finalStubNode->Attribute("id"))
      {
          if(finalStubNode->Attribute("id"))
          {
             finalStubIDRef_ = finalStubNode->Attribute("id");
             finalStub_ = boost::shared_ptr<Stub>(new Stub(finalStubNode));
             finalStub_->setID(finalStubIDRef_);
             IDManager::instance().setID(finalStubIDRef_,finalStub_);
          }
          else if(finalStubNode->Attribute("href")) { finalStubIDRef_ = finalStubNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { finalStub_ = boost::shared_ptr<Stub>(new Stub(finalStubNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Stub> StubCalculationPeriod::getInitialStub()
{
   if(!this->initialStubIsNull_){
        if(initialStubIDRef_ != ""){
             return boost::shared_static_cast<Stub>(IDManager::instance().getID(initialStubIDRef_));
        }else{
             return this->initialStub_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Stub>();
   }
}
boost::shared_ptr<Stub> StubCalculationPeriod::getFinalStub()
{
   if(!this->finalStubIsNull_){
        if(finalStubIDRef_ != ""){
             return boost::shared_static_cast<Stub>(IDManager::instance().getID(finalStubIDRef_));
        }else{
             return this->finalStub_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Stub>();
   }
}
}

