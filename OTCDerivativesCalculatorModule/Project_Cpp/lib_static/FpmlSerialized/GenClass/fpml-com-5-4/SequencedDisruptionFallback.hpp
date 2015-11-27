// SequencedDisruptionFallback.hpp 
#ifndef FpmlSerialized_SequencedDisruptionFallback_hpp
#define FpmlSerialized_SequencedDisruptionFallback_hpp

#include <ISerialized.hpp>
#include <fpml-com-5-4/DisruptionFallback.hpp>
#include <built_in_type/XsdTypePositiveInteger.hpp>

namespace FpmlSerialized {

class SequencedDisruptionFallback : public ISerialized { 
   public: 
       SequencedDisruptionFallback(TiXmlNode* xmlNode);

       bool isFallback(){return this->fallbackIsNull_;}
       boost::shared_ptr<DisruptionFallback> getFallback();
      std::string getFallbackIDRef(){return fallbackIDRef_;}

       bool isSequence(){return this->sequenceIsNull_;}
       boost::shared_ptr<XsdTypePositiveInteger> getSequence();
      std::string getSequenceIDRef(){return sequenceIDRef_;}

   protected: 
       boost::shared_ptr<DisruptionFallback> fallback_;
       std::string fallbackIDRef_;
       bool fallbackIsNull_;
       boost::shared_ptr<XsdTypePositiveInteger> sequence_;
       std::string sequenceIDRef_;
       bool sequenceIsNull_;

};

} //namespaceFpmlSerialized end
#endif

