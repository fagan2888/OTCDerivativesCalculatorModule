// ClearQueue.hpp 
#ifndef FpmlSerialized_ClearQueue_hpp
#define FpmlSerialized_ClearQueue_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class ClearQueue : public ISerialized { 
   public: 
       ClearQueue(TiXmlNode* xmlNode);

       bool isActionType(){return this->actionTypeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getActionType();


   protected: 
       boost::shared_ptr<XsdTypeToken> actionType_;
       
       bool actionTypeIsNull_;

};

} //namespaceFpmlSerialized end
#endif

