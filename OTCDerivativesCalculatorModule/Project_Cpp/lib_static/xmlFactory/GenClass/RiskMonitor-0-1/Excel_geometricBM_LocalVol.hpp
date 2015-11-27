// Excel_geometricBM_LocalVol.hpp 
#ifndef FpmlSerialized_Excel_geometricBM_LocalVol_hpp
#define FpmlSerialized_Excel_geometricBM_LocalVol_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_volSurface.hpp>

namespace FpmlSerialized {

class Excel_geometricBM_LocalVol : public ISerialized { 
   public: 
       Excel_geometricBM_LocalVol(TiXmlNode* xmlNode);

       bool isCurrentValue(){return this->currentValueIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCurrentValue();


       bool isDrift(){return this->driftIsNull_;}
       boost::shared_ptr<XsdTypeToken> getDrift();


       bool isDividend(){return this->dividendIsNull_;}
       boost::shared_ptr<XsdTypeToken> getDividend();


       bool isLinkedSurfaceCode(){return this->linkedSurfaceCodeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getLinkedSurfaceCode();


       bool isExcel_volSurface(){return this->excel_volSurfaceIsNull_;}
       boost::shared_ptr<Excel_volSurface> getExcel_volSurface();


       bool isVba_description(){return this->vba_descriptionIsNull_;}
       boost::shared_ptr<XsdTypeToken> getVba_description();


   protected: 
       boost::shared_ptr<XsdTypeToken> currentValue_;
       
       bool currentValueIsNull_;
       boost::shared_ptr<XsdTypeToken> drift_;
       
       bool driftIsNull_;
       boost::shared_ptr<XsdTypeToken> dividend_;
       
       bool dividendIsNull_;
       boost::shared_ptr<XsdTypeToken> linkedSurfaceCode_;
       
       bool linkedSurfaceCodeIsNull_;
       boost::shared_ptr<Excel_volSurface> excel_volSurface_;
       
       bool excel_volSurfaceIsNull_;
       boost::shared_ptr<XsdTypeToken> vba_description_;
       
       bool vba_descriptionIsNull_;

};

} //namespaceFpmlSerialized end
#endif

