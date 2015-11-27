// Range1D.hpp 
#ifndef FpmlSerialized_Range1D_hpp
#define FpmlSerialized_Range1D_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDouble.hpp>

namespace FpmlSerialized {

class Range1D : public ISerialized { 
   public: 
       Range1D(TiXmlNode* xmlNode);

       bool isLowerBound(){return this->lowerBoundIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getLowerBound();


       bool isUpperBound(){return this->upperBoundIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getUpperBound();


       bool isLowerBoundEquality(){return this->lowerBoundEqualityIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getLowerBoundEquality();


       bool isUpperBoundEquality(){return this->upperBoundEqualityIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getUpperBoundEquality();


   protected: 
       boost::shared_ptr<XsdTypeDouble> lowerBound_;
       
       bool lowerBoundIsNull_;
       boost::shared_ptr<XsdTypeDouble> upperBound_;
       
       bool upperBoundIsNull_;
       boost::shared_ptr<XsdTypeDouble> lowerBoundEquality_;
       
       bool lowerBoundEqualityIsNull_;
       boost::shared_ptr<XsdTypeDouble> upperBoundEquality_;
       
       bool upperBoundEqualityIsNull_;

};

} //namespaceFpmlSerialized end
#endif

