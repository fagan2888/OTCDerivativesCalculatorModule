// SettledEntityMatrix.cpp 
#include "SettledEntityMatrix.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SettledEntityMatrix::SettledEntityMatrix(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //matrixSourceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* matrixSourceNode = xmlNode->FirstChildElement("matrixSource");

   if(matrixSourceNode){matrixSourceIsNull_ = false;}
   else{matrixSourceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- matrixSourceNode , address : " << matrixSourceNode << std::endl;
   #endif
   if(matrixSourceNode)
   {
      if(matrixSourceNode->Attribute("href") || matrixSourceNode->Attribute("id"))
      {
          if(matrixSourceNode->Attribute("id"))
          {
             matrixSourceIDRef_ = matrixSourceNode->Attribute("id");
             matrixSource_ = boost::shared_ptr<MatrixSource>(new MatrixSource(matrixSourceNode));
             matrixSource_->setID(matrixSourceIDRef_);
             IDManager::instance().setID(matrixSourceIDRef_,matrixSource_);
          }
          else if(matrixSourceNode->Attribute("href")) { matrixSourceIDRef_ = matrixSourceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { matrixSource_ = boost::shared_ptr<MatrixSource>(new MatrixSource(matrixSourceNode));}
   }

   //publicationDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* publicationDateNode = xmlNode->FirstChildElement("publicationDate");

   if(publicationDateNode){publicationDateIsNull_ = false;}
   else{publicationDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- publicationDateNode , address : " << publicationDateNode << std::endl;
   #endif
   if(publicationDateNode)
   {
      if(publicationDateNode->Attribute("href") || publicationDateNode->Attribute("id"))
      {
          if(publicationDateNode->Attribute("id"))
          {
             publicationDateIDRef_ = publicationDateNode->Attribute("id");
             publicationDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(publicationDateNode));
             publicationDate_->setID(publicationDateIDRef_);
             IDManager::instance().setID(publicationDateIDRef_,publicationDate_);
          }
          else if(publicationDateNode->Attribute("href")) { publicationDateIDRef_ = publicationDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { publicationDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(publicationDateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<MatrixSource> SettledEntityMatrix::getMatrixSource()
{
   if(!this->matrixSourceIsNull_){
        if(matrixSourceIDRef_ != ""){
             return boost::shared_static_cast<MatrixSource>(IDManager::instance().getID(matrixSourceIDRef_));
        }else{
             return this->matrixSource_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MatrixSource>();
   }
}
boost::shared_ptr<XsdTypeDate> SettledEntityMatrix::getPublicationDate()
{
   if(!this->publicationDateIsNull_){
        if(publicationDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(publicationDateIDRef_));
        }else{
             return this->publicationDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
}

