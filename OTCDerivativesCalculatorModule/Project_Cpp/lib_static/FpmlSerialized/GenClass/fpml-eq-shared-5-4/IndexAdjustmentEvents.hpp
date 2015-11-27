// IndexAdjustmentEvents.hpp 
#ifndef FpmlSerialized_IndexAdjustmentEvents_hpp
#define FpmlSerialized_IndexAdjustmentEvents_hpp

#include <ISerialized.hpp>
#include <fpml-enum-5-4/IndexEventConsequenceEnum.hpp>

namespace FpmlSerialized {

class IndexAdjustmentEvents : public ISerialized { 
   public: 
       IndexAdjustmentEvents(TiXmlNode* xmlNode);

       bool isIndexModification(){return this->indexModificationIsNull_;}
       boost::shared_ptr<IndexEventConsequenceEnum> getIndexModification();
      std::string getIndexModificationIDRef(){return indexModificationIDRef_;}

       bool isIndexCancellation(){return this->indexCancellationIsNull_;}
       boost::shared_ptr<IndexEventConsequenceEnum> getIndexCancellation();
      std::string getIndexCancellationIDRef(){return indexCancellationIDRef_;}

       bool isIndexDisruption(){return this->indexDisruptionIsNull_;}
       boost::shared_ptr<IndexEventConsequenceEnum> getIndexDisruption();
      std::string getIndexDisruptionIDRef(){return indexDisruptionIDRef_;}

   protected: 
       boost::shared_ptr<IndexEventConsequenceEnum> indexModification_;
       std::string indexModificationIDRef_;
       bool indexModificationIsNull_;
       boost::shared_ptr<IndexEventConsequenceEnum> indexCancellation_;
       std::string indexCancellationIDRef_;
       bool indexCancellationIsNull_;
       boost::shared_ptr<IndexEventConsequenceEnum> indexDisruption_;
       std::string indexDisruptionIDRef_;
       bool indexDisruptionIsNull_;

};

} //namespaceFpmlSerialized end
#endif

