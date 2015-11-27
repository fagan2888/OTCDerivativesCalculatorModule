// RangeEventCheck.hpp 
#ifndef FpmlSerialized_RangeEventCheck_hpp
#define FpmlSerialized_RangeEventCheck_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDouble.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class RangeEventCheck : public ISerialized { 
   public: 
       RangeEventCheck(TiXmlNode* xmlNode);

       bool isHighCheckValue(){return this->highCheckValueIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getHighCheckValue();
      std::string getHighCheckValueIDRef(){return highCheckValueIDRef_;}

       bool isHighEquality(){return this->highEqualityIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getHighEquality();
      std::string getHighEqualityIDRef(){return highEqualityIDRef_;}

       bool isLowCheckValue(){return this->lowCheckValueIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getLowCheckValue();
      std::string getLowCheckValueIDRef(){return lowCheckValueIDRef_;}

       bool isLowEquality(){return this->lowEqualityIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getLowEquality();
      std::string getLowEqualityIDRef(){return lowEqualityIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDouble> highCheckValue_;
       std::string highCheckValueIDRef_;
       bool highCheckValueIsNull_;
       boost::shared_ptr<XsdTypeBoolean> highEquality_;
       std::string highEqualityIDRef_;
       bool highEqualityIsNull_;
       boost::shared_ptr<XsdTypeDouble> lowCheckValue_;
       std::string lowCheckValueIDRef_;
       bool lowCheckValueIsNull_;
       boost::shared_ptr<XsdTypeBoolean> lowEquality_;
       std::string lowEqualityIDRef_;
       bool lowEqualityIsNull_;

};

} //namespaceFpmlSerialized end
#endif

