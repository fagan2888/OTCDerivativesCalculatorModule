// ConstPayoff.hpp 
#ifndef FpmlSerialized_ConstPayoff_hpp
#define FpmlSerialized_ConstPayoff_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDouble.hpp>

namespace FpmlSerialized {

class ConstPayoff : public ISerialized { 
   public: 
       ConstPayoff(TiXmlNode* xmlNode);

       bool isConstValue(){return this->constValueIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getConstValue();
      std::string getConstValueIDRef(){return constValueIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDouble> constValue_;
       std::string constValueIDRef_;
       bool constValueIsNull_;

};

} //namespaceFpmlSerialized end
#endif

