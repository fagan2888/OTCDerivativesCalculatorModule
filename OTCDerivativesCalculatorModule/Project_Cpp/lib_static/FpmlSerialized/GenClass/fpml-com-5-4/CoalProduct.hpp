// CoalProduct.hpp 
#ifndef FpmlSerialized_CoalProduct_hpp
#define FpmlSerialized_CoalProduct_hpp

#include <ISerialized.hpp>
#include <fpml-com-5-4/CoalProductType.hpp>
#include <fpml-com-5-4/CoalProductSpecifications.hpp>
#include <fpml-com-5-4/CoalProductSource.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-com-5-4/CoalQualityAdjustments.hpp>

namespace FpmlSerialized {

class CoalProduct : public ISerialized { 
   public: 
       CoalProduct(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<CoalProductType> getType();
      std::string getTypeIDRef(){return typeIDRef_;}

       bool isCoalProductSpecifications(){return this->coalProductSpecificationsIsNull_;}
       boost::shared_ptr<CoalProductSpecifications> getCoalProductSpecifications();
      std::string getCoalProductSpecificationsIDRef(){return coalProductSpecificationsIDRef_;}

       bool isSource(){return this->sourceIsNull_;}
       std::vector<boost::shared_ptr<CoalProductSource>> getSource();
      std::string getSourceIDRef(){return sourceIDRef_;}

       bool isSCoTASpecifications(){return this->sCoTASpecificationsIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getSCoTASpecifications();
      std::string getSCoTASpecificationsIDRef(){return sCoTASpecificationsIDRef_;}

       bool isBtuQualityAdjustment(){return this->btuQualityAdjustmentIsNull_;}
       boost::shared_ptr<CoalQualityAdjustments> getBtuQualityAdjustment();
      std::string getBtuQualityAdjustmentIDRef(){return btuQualityAdjustmentIDRef_;}

       bool isSo2QualityAdjustment(){return this->so2QualityAdjustmentIsNull_;}
       boost::shared_ptr<CoalQualityAdjustments> getSo2QualityAdjustment();
      std::string getSo2QualityAdjustmentIDRef(){return so2QualityAdjustmentIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!typeIsNull_){
                count += 1;
                str = "type" ;
           }
           if(!coalProductSpecificationsIsNull_){
                count += 1;
                str = "coalProductSpecifications" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<CoalProductType> type_;     //choice
       std::string typeIDRef_;
       bool typeIsNull_;
         boost::shared_ptr<CoalProductSpecifications> coalProductSpecifications_;     //choice
       std::string coalProductSpecificationsIDRef_;
       bool coalProductSpecificationsIsNull_;
       std::vector<boost::shared_ptr<CoalProductSource>> source_;
       std::string sourceIDRef_;
       bool sourceIsNull_;
       boost::shared_ptr<XsdTypeBoolean> sCoTASpecifications_;
       std::string sCoTASpecificationsIDRef_;
       bool sCoTASpecificationsIsNull_;
       boost::shared_ptr<CoalQualityAdjustments> btuQualityAdjustment_;
       std::string btuQualityAdjustmentIDRef_;
       bool btuQualityAdjustmentIsNull_;
       boost::shared_ptr<CoalQualityAdjustments> so2QualityAdjustment_;
       std::string so2QualityAdjustmentIDRef_;
       bool so2QualityAdjustmentIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

