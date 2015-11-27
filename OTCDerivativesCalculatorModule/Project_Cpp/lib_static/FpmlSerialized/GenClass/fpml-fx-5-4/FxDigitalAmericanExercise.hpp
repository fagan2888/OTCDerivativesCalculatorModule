// FxDigitalAmericanExercise.hpp 
#ifndef FpmlSerialized_FxDigitalAmericanExercise_hpp
#define FpmlSerialized_FxDigitalAmericanExercise_hpp

#include <fpml-shared-5-4/Exercise.hpp>
#include <fpml-shared-5-4/AdjustableOrRelativeDate.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <fpml-shared-5-4/BusinessCenterTime.hpp>
#include <fpml-fx-5-4/CutName.hpp>

namespace FpmlSerialized {

class FxDigitalAmericanExercise : public Exercise { 
   public: 
       FxDigitalAmericanExercise(TiXmlNode* xmlNode);

       bool isCommencementDate(){return this->commencementDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getCommencementDate();
      std::string getCommencementDateIDRef(){return commencementDateIDRef_;}

       bool isExpiryDate(){return this->expiryDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getExpiryDate();
      std::string getExpiryDateIDRef(){return expiryDateIDRef_;}

       bool isExpiryTime(){return this->expiryTimeIsNull_;}
       boost::shared_ptr<BusinessCenterTime> getExpiryTime();
      std::string getExpiryTimeIDRef(){return expiryTimeIDRef_;}

       bool isCutName(){return this->cutNameIsNull_;}
       boost::shared_ptr<CutName> getCutName();
      std::string getCutNameIDRef(){return cutNameIDRef_;}

       bool isLatestValueDate(){return this->latestValueDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getLatestValueDate();
      std::string getLatestValueDateIDRef(){return latestValueDateIDRef_;}

   protected: 
       boost::shared_ptr<AdjustableOrRelativeDate> commencementDate_;
       std::string commencementDateIDRef_;
       bool commencementDateIsNull_;
       boost::shared_ptr<XsdTypeDate> expiryDate_;
       std::string expiryDateIDRef_;
       bool expiryDateIsNull_;
       boost::shared_ptr<BusinessCenterTime> expiryTime_;
       std::string expiryTimeIDRef_;
       bool expiryTimeIsNull_;
       boost::shared_ptr<CutName> cutName_;
       std::string cutNameIDRef_;
       bool cutNameIsNull_;
       boost::shared_ptr<XsdTypeDate> latestValueDate_;
       std::string latestValueDateIDRef_;
       bool latestValueDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

