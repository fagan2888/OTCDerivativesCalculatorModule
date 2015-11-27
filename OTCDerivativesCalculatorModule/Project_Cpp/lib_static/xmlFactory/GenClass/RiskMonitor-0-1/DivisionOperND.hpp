// DivisionOperND.hpp 
#ifndef FpmlSerialized_DivisionOperND_hpp
#define FpmlSerialized_DivisionOperND_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class DivisionOperND : public ISerialized { 
   public: 
       DivisionOperND(TiXmlNode* xmlNode);

       bool isWeight(){return this->weightIsNull_;}
       std::vector<boost::shared_ptr<XsdTypeToken>> getWeight();


   protected: 
       std::vector<boost::shared_ptr<XsdTypeToken>> weight_;
       
       bool weightIsNull_;

};

} //namespaceFpmlSerialized end
#endif

