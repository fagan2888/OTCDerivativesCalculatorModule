// BaseInformation.hpp 
#ifndef FpmlSerialized_BaseInformation_hpp
#define FpmlSerialized_BaseInformation_hpp

#include <ISerialized.hpp>
#include <ahn-product-1-0/BaseIndexes.hpp>
#include <ahn-product-1-0/ConventionSet.hpp>

namespace FpmlSerialized {

class BaseInformation : public ISerialized { 
   public: 
       BaseInformation(TiXmlNode* xmlNode);

       bool isBaseIndexes(){return this->baseIndexesIsNull_;}
       boost::shared_ptr<BaseIndexes> getBaseIndexes();
      std::string getBaseIndexesIDRef(){return baseIndexesIDRef_;}

       bool isConventionSet(){return this->conventionSetIsNull_;}
       boost::shared_ptr<ConventionSet> getConventionSet();
      std::string getConventionSetIDRef(){return conventionSetIDRef_;}

   protected: 
       boost::shared_ptr<BaseIndexes> baseIndexes_;
       std::string baseIndexesIDRef_;
       bool baseIndexesIsNull_;
       boost::shared_ptr<ConventionSet> conventionSet_;
       std::string conventionSetIDRef_;
       bool conventionSetIsNull_;

};

} //namespaceFpmlSerialized end
#endif

