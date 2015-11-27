// Excel_underlyingInfo.hpp 
#ifndef FpmlSerialized_Excel_underlyingInfo_hpp
#define FpmlSerialized_Excel_underlyingInfo_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_stockIndex.hpp>
#include <RiskMonitor-0-1/Excel_interestRate.hpp>
#include <RiskMonitor-0-1/Excel_indexType.hpp>

namespace FpmlSerialized {

class Excel_underlyingInfo : public ISerialized { 
   public: 
       Excel_underlyingInfo(TiXmlNode* xmlNode);

       bool isExcel_type(){return this->excel_typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getExcel_type();


       bool isExcel_stockIndex(){return this->excel_stockIndexIsNull_;}
       boost::shared_ptr<Excel_stockIndex> getExcel_stockIndex();


       bool isExcel_interestRate(){return this->excel_interestRateIsNull_;}
       boost::shared_ptr<Excel_interestRate> getExcel_interestRate();


       bool isExcel_indexType(){return this->excel_indexTypeIsNull_;}
       boost::shared_ptr<Excel_indexType> getExcel_indexType();


       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!excel_stockIndexIsNull_){
                count += 1;
                str = "excel_stockIndex" ;
           }
           if(!excel_interestRateIsNull_){
                count += 1;
                str = "excel_interestRate" ;
           }
           if(!excel_indexTypeIsNull_){
                count += 1;
                str = "excel_indexType" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> excel_type_;
       
       bool excel_typeIsNull_;
         boost::shared_ptr<Excel_stockIndex> excel_stockIndex_;     //choice
       
       bool excel_stockIndexIsNull_;
         boost::shared_ptr<Excel_interestRate> excel_interestRate_;     //choice
       
       bool excel_interestRateIsNull_;
         boost::shared_ptr<Excel_indexType> excel_indexType_;     //choice
       
       bool excel_indexTypeIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

