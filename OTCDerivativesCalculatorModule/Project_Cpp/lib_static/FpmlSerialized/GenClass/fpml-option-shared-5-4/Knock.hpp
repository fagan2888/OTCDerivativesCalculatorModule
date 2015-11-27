// Knock.hpp 
#ifndef FpmlSerialized_Knock_hpp
#define FpmlSerialized_Knock_hpp

#include <ISerialized.hpp>
#include <fpml-option-shared-5-4/TriggerEvent.hpp>

namespace FpmlSerialized {

class Knock : public ISerialized { 
   public: 
       Knock(TiXmlNode* xmlNode);

       bool isKnockIn(){return this->knockInIsNull_;}
       boost::shared_ptr<TriggerEvent> getKnockIn();
      std::string getKnockInIDRef(){return knockInIDRef_;}

       bool isKnockOut(){return this->knockOutIsNull_;}
       boost::shared_ptr<TriggerEvent> getKnockOut();
      std::string getKnockOutIDRef(){return knockOutIDRef_;}

   protected: 
       boost::shared_ptr<TriggerEvent> knockIn_;
       std::string knockInIDRef_;
       bool knockInIsNull_;
       boost::shared_ptr<TriggerEvent> knockOut_;
       std::string knockOutIDRef_;
       bool knockOutIsNull_;

};

} //namespaceFpmlSerialized end
#endif

