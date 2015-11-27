// InstPositionInfo.hpp 
#ifndef FpmlSerialized_InstPositionInfo_hpp
#define FpmlSerialized_InstPositionInfo_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class InstPositionInfo : public ISerialized { 
   public: 
       InstPositionInfo(TiXmlNode* xmlNode);

       bool isKrCode(){return this->krCodeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getKrCode();


       bool isInstName(){return this->instNameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getInstName();


       bool isInstCode(){return this->instCodeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getInstCode();


       bool isInstType(){return this->instTypeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getInstType();


       bool isBookedDate(){return this->bookedDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getBookedDate();


       bool isUnBookedDate(){return this->unBookedDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getUnBookedDate();


       bool isMaturityDate(){return this->maturityDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getMaturityDate();


       bool isFileName(){return this->fileNameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getFileName();


       bool isPositionName(){return this->positionNameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getPositionName();


       bool isCounterParty(){return this->counterPartyIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCounterParty();


       bool isNotional(){return this->notionalIsNull_;}
       boost::shared_ptr<XsdTypeToken> getNotional();


       bool isCurrency(){return this->currencyIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCurrency();


       bool isFundCode(){return this->fundCodeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getFundCode();


       bool isFundName(){return this->fundNameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getFundName();


   protected: 
       boost::shared_ptr<XsdTypeToken> krCode_;
       
       bool krCodeIsNull_;
       boost::shared_ptr<XsdTypeToken> instName_;
       
       bool instNameIsNull_;
       boost::shared_ptr<XsdTypeToken> instCode_;
       
       bool instCodeIsNull_;
       boost::shared_ptr<XsdTypeToken> instType_;
       
       bool instTypeIsNull_;
       boost::shared_ptr<XsdTypeToken> bookedDate_;
       
       bool bookedDateIsNull_;
       boost::shared_ptr<XsdTypeToken> unBookedDate_;
       
       bool unBookedDateIsNull_;
       boost::shared_ptr<XsdTypeToken> maturityDate_;
       
       bool maturityDateIsNull_;
       boost::shared_ptr<XsdTypeToken> fileName_;
       
       bool fileNameIsNull_;
       boost::shared_ptr<XsdTypeToken> positionName_;
       
       bool positionNameIsNull_;
       boost::shared_ptr<XsdTypeToken> counterParty_;
       
       bool counterPartyIsNull_;
       boost::shared_ptr<XsdTypeToken> notional_;
       
       bool notionalIsNull_;
       boost::shared_ptr<XsdTypeToken> currency_;
       
       bool currencyIsNull_;
       boost::shared_ptr<XsdTypeToken> fundCode_;
       
       bool fundCodeIsNull_;
       boost::shared_ptr<XsdTypeToken> fundName_;
       
       bool fundNameIsNull_;

};

} //namespaceFpmlSerialized end
#endif

