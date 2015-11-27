// Clearing.hpp 
#ifndef FpmlSerialized_Clearing_hpp
#define FpmlSerialized_Clearing_hpp

#include <ISerialized.hpp>
#include <fpml-confirmation-processes-5-4/TradeWrapper.hpp>

namespace FpmlSerialized {

class Clearing : public ISerialized { 
   public: 
       Clearing(TiXmlNode* xmlNode);

       bool isSubmitted(){return this->submittedIsNull_;}
       boost::shared_ptr<TradeWrapper> getSubmitted();
      std::string getSubmittedIDRef(){return submittedIDRef_;}

       bool isCleared(){return this->clearedIsNull_;}
       std::vector<boost::shared_ptr<TradeWrapper>> getCleared();
      std::string getClearedIDRef(){return clearedIDRef_;}

   protected: 
       boost::shared_ptr<TradeWrapper> submitted_;
       std::string submittedIDRef_;
       bool submittedIsNull_;
       std::vector<boost::shared_ptr<TradeWrapper>> cleared_;
       std::string clearedIDRef_;
       bool clearedIsNull_;

};

} //namespaceFpmlSerialized end
#endif

