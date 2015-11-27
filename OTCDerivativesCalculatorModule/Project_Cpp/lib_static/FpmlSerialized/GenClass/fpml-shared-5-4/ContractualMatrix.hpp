// ContractualMatrix.hpp 
#ifndef FpmlSerialized_ContractualMatrix_hpp
#define FpmlSerialized_ContractualMatrix_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/MatrixType.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <fpml-shared-5-4/MatrixTerm.hpp>

namespace FpmlSerialized {

class ContractualMatrix : public ISerialized { 
   public: 
       ContractualMatrix(TiXmlNode* xmlNode);

       bool isMatrixType(){return this->matrixTypeIsNull_;}
       boost::shared_ptr<MatrixType> getMatrixType();
      std::string getMatrixTypeIDRef(){return matrixTypeIDRef_;}

       bool isPublicationDate(){return this->publicationDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getPublicationDate();
      std::string getPublicationDateIDRef(){return publicationDateIDRef_;}

       bool isMatrixTerm(){return this->matrixTermIsNull_;}
       boost::shared_ptr<MatrixTerm> getMatrixTerm();
      std::string getMatrixTermIDRef(){return matrixTermIDRef_;}

   protected: 
       boost::shared_ptr<MatrixType> matrixType_;
       std::string matrixTypeIDRef_;
       bool matrixTypeIsNull_;
       boost::shared_ptr<XsdTypeDate> publicationDate_;
       std::string publicationDateIDRef_;
       bool publicationDateIsNull_;
       boost::shared_ptr<MatrixTerm> matrixTerm_;
       std::string matrixTermIDRef_;
       bool matrixTermIsNull_;

};

} //namespaceFpmlSerialized end
#endif

