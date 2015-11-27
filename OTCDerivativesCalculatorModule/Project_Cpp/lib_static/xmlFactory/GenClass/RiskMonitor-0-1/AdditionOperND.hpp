// AdditionOperND.hpp 
#ifndef FpmlSerialized_AdditionOperND_hpp
#define FpmlSerialized_AdditionOperND_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class AdditionOperND : public ISerialized { 
   public: 
       AdditionOperND(TiXmlNode* xmlNode);

       bool isWeight(){return this->weightIsNull_;}
       std::vector<boost::shared_ptr<XsdTypeToken>> getWeight();


   protected: 
       std::vector<boost::shared_ptr<XsdTypeToken>> weight_;
       
       bool weightIsNull_;

};

} //namespaceFpmlSerialized end
#endif

