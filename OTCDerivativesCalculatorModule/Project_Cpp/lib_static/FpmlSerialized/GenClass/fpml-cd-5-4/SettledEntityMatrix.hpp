// SettledEntityMatrix.hpp 
#ifndef FpmlSerialized_SettledEntityMatrix_hpp
#define FpmlSerialized_SettledEntityMatrix_hpp

#include <ISerialized.hpp>
#include <fpml-cd-5-4/MatrixSource.hpp>
#include <built_in_type/XsdTypeDate.hpp>

namespace FpmlSerialized {

class SettledEntityMatrix : public ISerialized { 
   public: 
       SettledEntityMatrix(TiXmlNode* xmlNode);

       bool isMatrixSource(){return this->matrixSourceIsNull_;}
       boost::shared_ptr<MatrixSource> getMatrixSource();
      std::string getMatrixSourceIDRef(){return matrixSourceIDRef_;}

       bool isPublicationDate(){return this->publicationDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getPublicationDate();
      std::string getPublicationDateIDRef(){return publicationDateIDRef_;}

   protected: 
       boost::shared_ptr<MatrixSource> matrixSource_;
       std::string matrixSourceIDRef_;
       bool matrixSourceIsNull_;
       boost::shared_ptr<XsdTypeDate> publicationDate_;
       std::string publicationDateIDRef_;
       bool publicationDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

