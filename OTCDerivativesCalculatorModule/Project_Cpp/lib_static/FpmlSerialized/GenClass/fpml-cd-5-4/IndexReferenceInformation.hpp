// IndexReferenceInformation.hpp 
#ifndef FpmlSerialized_IndexReferenceInformation_hpp
#define FpmlSerialized_IndexReferenceInformation_hpp

#include <ISerialized.hpp>
#include <fpml-cd-5-4/IndexName.hpp>
#include <fpml-cd-5-4/IndexId.hpp>
#include <built_in_type/XsdTypePositiveInteger.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <fpml-cd-5-4/IndexAnnexSource.hpp>
#include <fpml-shared-5-4/LegalEntity.hpp>
#include <fpml-cd-5-4/Tranche.hpp>
#include <fpml-cd-5-4/SettledEntityMatrix.hpp>

namespace FpmlSerialized {

class IndexReferenceInformation : public ISerialized { 
   public: 
       IndexReferenceInformation(TiXmlNode* xmlNode);

       bool isIndexName(){return this->indexNameIsNull_;}
       boost::shared_ptr<IndexName> getIndexName();
      std::string getIndexNameIDRef(){return indexNameIDRef_;}

       bool isIndexId(){return this->indexIdIsNull_;}
       std::vector<boost::shared_ptr<IndexId>> getIndexId();
      std::string getIndexIdIDRef(){return indexIdIDRef_;}

       bool isIndexSeries(){return this->indexSeriesIsNull_;}
       boost::shared_ptr<XsdTypePositiveInteger> getIndexSeries();
      std::string getIndexSeriesIDRef(){return indexSeriesIDRef_;}

       bool isIndexAnnexVersion(){return this->indexAnnexVersionIsNull_;}
       boost::shared_ptr<XsdTypePositiveInteger> getIndexAnnexVersion();
      std::string getIndexAnnexVersionIDRef(){return indexAnnexVersionIDRef_;}

       bool isIndexAnnexDate(){return this->indexAnnexDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getIndexAnnexDate();
      std::string getIndexAnnexDateIDRef(){return indexAnnexDateIDRef_;}

       bool isIndexAnnexSource(){return this->indexAnnexSourceIsNull_;}
       boost::shared_ptr<IndexAnnexSource> getIndexAnnexSource();
      std::string getIndexAnnexSourceIDRef(){return indexAnnexSourceIDRef_;}

       bool isExcludedReferenceEntity(){return this->excludedReferenceEntityIsNull_;}
       std::vector<boost::shared_ptr<LegalEntity>> getExcludedReferenceEntity();
      std::string getExcludedReferenceEntityIDRef(){return excludedReferenceEntityIDRef_;}

       bool isTranche(){return this->trancheIsNull_;}
       boost::shared_ptr<Tranche> getTranche();
      std::string getTrancheIDRef(){return trancheIDRef_;}

       bool isSettledEntityMatrix(){return this->settledEntityMatrixIsNull_;}
       boost::shared_ptr<SettledEntityMatrix> getSettledEntityMatrix();
      std::string getSettledEntityMatrixIDRef(){return settledEntityMatrixIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!indexNameIsNull_){
                count += 1;
                str = "indexName" ;
           }
           if(!indexIdIsNull_){
                count += 1;
                str = "indexId" ;
           }
           if(!indexIdIsNull_){
                count += 1;
                str = "indexId" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<IndexName> indexName_;     //choice
       std::string indexNameIDRef_;
       bool indexNameIsNull_;
         std::vector<boost::shared_ptr<IndexId>> indexId_;     //choice
       std::string indexIdIDRef_;
       bool indexIdIsNull_;
       boost::shared_ptr<XsdTypePositiveInteger> indexSeries_;
       std::string indexSeriesIDRef_;
       bool indexSeriesIsNull_;
       boost::shared_ptr<XsdTypePositiveInteger> indexAnnexVersion_;
       std::string indexAnnexVersionIDRef_;
       bool indexAnnexVersionIsNull_;
       boost::shared_ptr<XsdTypeDate> indexAnnexDate_;
       std::string indexAnnexDateIDRef_;
       bool indexAnnexDateIsNull_;
       boost::shared_ptr<IndexAnnexSource> indexAnnexSource_;
       std::string indexAnnexSourceIDRef_;
       bool indexAnnexSourceIsNull_;
       std::vector<boost::shared_ptr<LegalEntity>> excludedReferenceEntity_;
       std::string excludedReferenceEntityIDRef_;
       bool excludedReferenceEntityIsNull_;
       boost::shared_ptr<Tranche> tranche_;
       std::string trancheIDRef_;
       bool trancheIsNull_;
       boost::shared_ptr<SettledEntityMatrix> settledEntityMatrix_;
       std::string settledEntityMatrixIDRef_;
       bool settledEntityMatrixIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

