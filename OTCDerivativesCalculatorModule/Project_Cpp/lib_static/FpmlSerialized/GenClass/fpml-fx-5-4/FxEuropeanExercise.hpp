// FxEuropeanExercise.hpp 
#ifndef FpmlSerialized_FxEuropeanExercise_hpp
#define FpmlSerialized_FxEuropeanExercise_hpp

#include <fpml-shared-5-4/Exercise.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <fpml-shared-5-4/BusinessCenterTime.hpp>
#include <fpml-fx-5-4/CutName.hpp>

namespace FpmlSerialized {

class FxEuropeanExercise : public Exercise { 
   public: 
       FxEuropeanExercise(TiXmlNode* xmlNode);

       bool isExpiryDate(){return this->expiryDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getExpiryDate();
      std::string getExpiryDateIDRef(){return expiryDateIDRef_;}

       bool isExpiryTime(){return this->expiryTimeIsNull_;}
       boost::shared_ptr<BusinessCenterTime> getExpiryTime();
      std::string getExpiryTimeIDRef(){return expiryTimeIDRef_;}

       bool isCutName(){return this->cutNameIsNull_;}
       boost::shared_ptr<CutName> getCutName();
      std::string getCutNameIDRef(){return cutNameIDRef_;}

       bool isValueDate(){return this->valueDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getValueDate();
      std::string getValueDateIDRef(){return valueDateIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDate> expiryDate_;
       std::string expiryDateIDRef_;
       bool expiryDateIsNull_;
       boost::shared_ptr<BusinessCenterTime> expiryTime_;
       std::string expiryTimeIDRef_;
       bool expiryTimeIsNull_;
       boost::shared_ptr<CutName> cutName_;
       std::string cutNameIDRef_;
       bool cutNameIsNull_;
       boost::shared_ptr<XsdTypeDate> valueDate_;
       std::string valueDateIDRef_;
       bool valueDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

