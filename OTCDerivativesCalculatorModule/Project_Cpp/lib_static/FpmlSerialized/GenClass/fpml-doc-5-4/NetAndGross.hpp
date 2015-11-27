// NetAndGross.hpp 
#ifndef FpmlSerialized_NetAndGross_hpp
#define FpmlSerialized_NetAndGross_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>

namespace FpmlSerialized {

class NetAndGross : public ISerialized { 
   public: 
       NetAndGross(TiXmlNode* xmlNode);

       bool isNet(){return this->netIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getNet();
      std::string getNetIDRef(){return netIDRef_;}

       bool isGross(){return this->grossIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getGross();
      std::string getGrossIDRef(){return grossIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!netIsNull_){
                count += 1;
                str = "net" ;
           }
           if(!grossIsNull_){
                count += 1;
                str = "gross" ;
           }
           if(!netIsNull_){
                count += 1;
                str = "net" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<XsdTypeDecimal> net_;     //choice
       std::string netIDRef_;
       bool netIsNull_;
         boost::shared_ptr<XsdTypeDecimal> gross_;     //choice
       std::string grossIDRef_;
       bool grossIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

