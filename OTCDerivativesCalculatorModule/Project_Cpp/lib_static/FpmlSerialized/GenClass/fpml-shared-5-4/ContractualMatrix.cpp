// ContractualMatrix.cpp 
#include "ContractualMatrix.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ContractualMatrix::ContractualMatrix(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //matrixTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* matrixTypeNode = xmlNode->FirstChildElement("matrixType");

   if(matrixTypeNode){matrixTypeIsNull_ = false;}
   else{matrixTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- matrixTypeNode , address : " << matrixTypeNode << std::endl;
   #endif
   if(matrixTypeNode)
   {
      if(matrixTypeNode->Attribute("href") || matrixTypeNode->Attribute("id"))
      {
          if(matrixTypeNode->Attribute("id"))
          {
             matrixTypeIDRef_ = matrixTypeNode->Attribute("id");
             matrixType_ = boost::shared_ptr<MatrixType>(new MatrixType(matrixTypeNode));
             matrixType_->setID(matrixTypeIDRef_);
             IDManager::instance().setID(matrixTypeIDRef_,matrixType_);
          }
          else if(matrixTypeNode->Attribute("href")) { matrixTypeIDRef_ = matrixTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { matrixType_ = boost::shared_ptr<MatrixType>(new MatrixType(matrixTypeNode));}
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

   //matrixTermNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* matrixTermNode = xmlNode->FirstChildElement("matrixTerm");

   if(matrixTermNode){matrixTermIsNull_ = false;}
   else{matrixTermIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- matrixTermNode , address : " << matrixTermNode << std::endl;
   #endif
   if(matrixTermNode)
   {
      if(matrixTermNode->Attribute("href") || matrixTermNode->Attribute("id"))
      {
          if(matrixTermNode->Attribute("id"))
          {
             matrixTermIDRef_ = matrixTermNode->Attribute("id");
             matrixTerm_ = boost::shared_ptr<MatrixTerm>(new MatrixTerm(matrixTermNode));
             matrixTerm_->setID(matrixTermIDRef_);
             IDManager::instance().setID(matrixTermIDRef_,matrixTerm_);
          }
          else if(matrixTermNode->Attribute("href")) { matrixTermIDRef_ = matrixTermNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { matrixTerm_ = boost::shared_ptr<MatrixTerm>(new MatrixTerm(matrixTermNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<MatrixType> ContractualMatrix::getMatrixType()
{
   if(!this->matrixTypeIsNull_){
        if(matrixTypeIDRef_ != ""){
             return boost::shared_static_cast<MatrixType>(IDManager::instance().getID(matrixTypeIDRef_));
        }else{
             return this->matrixType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MatrixType>();
   }
}
boost::shared_ptr<XsdTypeDate> ContractualMatrix::getPublicationDate()
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
boost::shared_ptr<MatrixTerm> ContractualMatrix::getMatrixTerm()
{
   if(!this->matrixTermIsNull_){
        if(matrixTermIDRef_ != ""){
             return boost::shared_static_cast<MatrixTerm>(IDManager::instance().getID(matrixTermIDRef_));
        }else{
             return this->matrixTerm_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MatrixTerm>();
   }
}
}

