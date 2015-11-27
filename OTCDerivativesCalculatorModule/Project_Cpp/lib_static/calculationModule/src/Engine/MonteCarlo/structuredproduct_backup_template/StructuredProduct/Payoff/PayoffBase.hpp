#ifndef calculationModule_payoffmanager_hpp
#define calculationModule_payoffmanager_hpp

#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/IndexTran/indextransBase.hpp>

namespace QuantLib {

	class PayoffBase {
	  public:
		PayoffBase(){}
		virtual ~PayoffBase(){}

	    PayoffBase(const std::string& symbolName,
				   const Date& payoffDate,
				   std::string payoffExpr);

		virtual void initialize(const TimeGrid& timeGrid, const Calendar& calendar);

		virtual void defineVar(const std::string& varStr);
		virtual void removeSymbol(std::string symbolName);
		
		virtual Date payoffDate(){return payoffDate_;}
		virtual Size payoffDatesPosition(){return payoffDatesPosition_;}
		
		virtual void defineConst(const std::string& varStr,Real constValue);
		virtual void defineBaseIndex(const std::string& varStr);

		virtual Real value() = 0;

		virtual bool expired()
		{
			return false;
		}

	  protected:
		  std::string symbolName_;
		  Size symbolNum_;
		  Date payoffDate_;
		  Size payoffDatesPosition_;
		  std::string payoffExpr_;

	};

}
#endif
