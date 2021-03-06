// MaximumOperND.hpp 
#ifndef FpmlSerialized_MaximumOperND_hpp
#define FpmlSerialized_MaximumOperND_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class MaximumOperND : public ISerialized { 
   public: 
       MaximumOperND(TiXmlNode* xmlNode);

       bool isWeight(){return this->weightIsNull_;}
       std::vector<boost::shared_ptr<XsdTypeToken>> getWeight();


   protected: 
       std::vector<boost::shared_ptr<XsdTypeToken>> weight_;
       
       bool weightIsNull_;

};

} //namespaceFpmlSerialized end
#endif

