// QueryParameter.cpp 
#include "QueryParameter.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

QueryParameter::QueryParameter(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //queryParameterIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* queryParameterIdNode = xmlNode->FirstChildElement("queryParameterId");

   if(queryParameterIdNode){queryParameterIdIsNull_ = false;}
   else{queryParameterIdIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- queryParameterIdNode , address : " << queryParameterIdNode << std::endl;
   #endif
   if(queryParameterIdNode)
   {
      if(queryParameterIdNode->Attribute("href") || queryParameterIdNode->Attribute("id"))
      {
          if(queryParameterIdNode->Attribute("id"))
          {
             queryParameterIdIDRef_ = queryParameterIdNode->Attribute("id");
             queryParameterId_ = boost::shared_ptr<QueryParameterId>(new QueryParameterId(queryParameterIdNode));
             queryParameterId_->setID(queryParameterIdIDRef_);
             IDManager::instance().setID(queryParameterIdIDRef_,queryParameterId_);
          }
          else if(queryParameterIdNode->Attribute("href")) { queryParameterIdIDRef_ = queryParameterIdNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { queryParameterId_ = boost::shared_ptr<QueryParameterId>(new QueryParameterId(queryParameterIdNode));}
   }

   //queryParameterValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* queryParameterValueNode = xmlNode->FirstChildElement("queryParameterValue");

   if(queryParameterValueNode){queryParameterValueIsNull_ = false;}
   else{queryParameterValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- queryParameterValueNode , address : " << queryParameterValueNode << std::endl;
   #endif
   if(queryParameterValueNode)
   {
      if(queryParameterValueNode->Attribute("href") || queryParameterValueNode->Attribute("id"))
      {
          if(queryParameterValueNode->Attribute("id"))
          {
             queryParameterValueIDRef_ = queryParameterValueNode->Attribute("id");
             queryParameterValue_ = boost::shared_ptr<XsdTypeNormalizedString>(new XsdTypeNormalizedString(queryParameterValueNode));
             queryParameterValue_->setID(queryParameterValueIDRef_);
             IDManager::instance().setID(queryParameterValueIDRef_,queryParameterValue_);
          }
          else if(queryParameterValueNode->Attribute("href")) { queryParameterValueIDRef_ = queryParameterValueNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { queryParameterValue_ = boost::shared_ptr<XsdTypeNormalizedString>(new XsdTypeNormalizedString(queryParameterValueNode));}
   }

   //queryParameterOperatorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* queryParameterOperatorNode = xmlNode->FirstChildElement("queryParameterOperator");

   if(queryParameterOperatorNode){queryParameterOperatorIsNull_ = false;}
   else{queryParameterOperatorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- queryParameterOperatorNode , address : " << queryParameterOperatorNode << std::endl;
   #endif
   if(queryParameterOperatorNode)
   {
      if(queryParameterOperatorNode->Attribute("href") || queryParameterOperatorNode->Attribute("id"))
      {
          if(queryParameterOperatorNode->Attribute("id"))
          {
             queryParameterOperatorIDRef_ = queryParameterOperatorNode->Attribute("id");
             queryParameterOperator_ = boost::shared_ptr<QueryParameterOperator>(new QueryParameterOperator(queryParameterOperatorNode));
             queryParameterOperator_->setID(queryParameterOperatorIDRef_);
             IDManager::instance().setID(queryParameterOperatorIDRef_,queryParameterOperator_);
          }
          else if(queryParameterOperatorNode->Attribute("href")) { queryParameterOperatorIDRef_ = queryParameterOperatorNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { queryParameterOperator_ = boost::shared_ptr<QueryParameterOperator>(new QueryParameterOperator(queryParameterOperatorNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<QueryParameterId> QueryParameter::getQueryParameterId()
{
   if(!this->queryParameterIdIsNull_){
        if(queryParameterIdIDRef_ != ""){
             return boost::shared_static_cast<QueryParameterId>(IDManager::instance().getID(queryParameterIdIDRef_));
        }else{
             return this->queryParameterId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<QueryParameterId>();
   }
}
boost::shared_ptr<XsdTypeNormalizedString> QueryParameter::getQueryParameterValue()
{
   if(!this->queryParameterValueIsNull_){
        if(queryParameterValueIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeNormalizedString>(IDManager::instance().getID(queryParameterValueIDRef_));
        }else{
             return this->queryParameterValue_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeNormalizedString>();
   }
}
boost::shared_ptr<QueryParameterOperator> QueryParameter::getQueryParameterOperator()
{
   if(!this->queryParameterOperatorIsNull_){
        if(queryParameterOperatorIDRef_ != ""){
             return boost::shared_static_cast<QueryParameterOperator>(IDManager::instance().getID(queryParameterOperatorIDRef_));
        }else{
             return this->queryParameterOperator_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<QueryParameterOperator>();
   }
}
}

