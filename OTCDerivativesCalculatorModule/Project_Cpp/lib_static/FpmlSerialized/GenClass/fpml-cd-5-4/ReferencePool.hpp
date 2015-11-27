// ReferencePool.hpp 
#ifndef FpmlSerialized_ReferencePool_hpp
#define FpmlSerialized_ReferencePool_hpp

#include <ISerialized.hpp>
#include <fpml-cd-5-4/ReferencePoolItem.hpp>

namespace FpmlSerialized {

class ReferencePool : public ISerialized { 
   public: 
       ReferencePool(TiXmlNode* xmlNode);

       bool isReferencePoolItem(){return this->referencePoolItemIsNull_;}
       std::vector<boost::shared_ptr<ReferencePoolItem>> getReferencePoolItem();
      std::string getReferencePoolItemIDRef(){return referencePoolItemIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<ReferencePoolItem>> referencePoolItem_;
       std::string referencePoolItemIDRef_;
       bool referencePoolItemIsNull_;

};

} //namespaceFpmlSerialized end
#endif

