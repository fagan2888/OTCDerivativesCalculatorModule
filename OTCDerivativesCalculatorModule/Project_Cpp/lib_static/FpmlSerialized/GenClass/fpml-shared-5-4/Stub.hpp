// Stub.hpp 
#ifndef FpmlSerialized_Stub_hpp
#define FpmlSerialized_Stub_hpp

#include <fpml-shared-5-4/StubValue.hpp>
#include <fpml-shared-5-4/AdjustableOrRelativeDate.hpp>

namespace FpmlSerialized {

class Stub : public StubValue { 
   public: 
       Stub(TiXmlNode* xmlNode);

       bool isStubStartDate(){return this->stubStartDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getStubStartDate();
      std::string getStubStartDateIDRef(){return stubStartDateIDRef_;}

       bool isStubEndDate(){return this->stubEndDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getStubEndDate();
      std::string getStubEndDateIDRef(){return stubEndDateIDRef_;}

   protected: 
       boost::shared_ptr<AdjustableOrRelativeDate> stubStartDate_;
       std::string stubStartDateIDRef_;
       bool stubStartDateIsNull_;
       boost::shared_ptr<AdjustableOrRelativeDate> stubEndDate_;
       std::string stubEndDateIDRef_;
       bool stubEndDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

