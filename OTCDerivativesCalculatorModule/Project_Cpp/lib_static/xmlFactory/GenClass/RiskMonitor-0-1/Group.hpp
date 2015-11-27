// Group.hpp 
#ifndef FpmlSerialized_Group_hpp
#define FpmlSerialized_Group_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Header.hpp>

namespace FpmlSerialized {

class Group : public ISerialized { 
   public: 
       Group(TiXmlNode* xmlNode);

       bool isHeader(){return this->headerIsNull_;}
       boost::shared_ptr<Header> getHeader();


   protected: 
       boost::shared_ptr<Header> header_;
       
       bool headerIsNull_;

};

} //namespaceFpmlSerialized end
#endif

