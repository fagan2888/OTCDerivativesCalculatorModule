// QueryPortfolio.cpp 
#include "QueryPortfolio.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

QueryPortfolio::QueryPortfolio(TiXmlNode* xmlNode)
: Portfolio(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //queryParameterNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* queryParameterNode = xmlNode->FirstChildElement("queryParameter");

   if(queryParameterNode){queryParameterIsNull_ = false;}
   else{queryParameterIsNull_ = true;}

   if(queryParameterNode)
   {
      for(queryParameterNode; queryParameterNode; queryParameterNode = queryParameterNode->NextSiblingElement("queryParameter")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- queryParameterNode , address : " << queryParameterNode << std::endl;
          #endif
          if(queryParameterNode->Attribute("href") || queryParameterNode->Attribute("id"))
          {
              if(queryParameterNode->Attribute("id"))
              {
                  queryParameterIDRef_ = queryParameterNode->Attribute("id");
                  queryParameter_.push_back(boost::shared_ptr<QueryParameter>(new QueryParameter(queryParameterNode)));
                  queryParameter_.back()->setID(queryParameterIDRef_);
                  IDManager::instance().setID(queryParameterIDRef_, queryParameter_.back());
              }
              else if(queryParameterNode->Attribute("href")) { queryParameterIDRef_ = queryParameterNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { queryParameter_.push_back(boost::shared_ptr<QueryParameter>(new QueryParameter(queryParameterNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- queryParameterNode , address : " << queryParameterNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<QueryParameter>> QueryPortfolio::getQueryParameter()
{
   if(!this->queryParameterIsNull_){
        if(queryParameterIDRef_ != ""){
             return this->queryParameter_;
        }else{
             return this->queryParameter_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<QueryParameter>>();
   }
}
}

