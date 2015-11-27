#ifndef calculationModule_constPayoffmanager_hpp
#define calculationModule_constPayoffmanager_hpp

#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/IndexTran/indextransmanager.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/Payoff/payoffBase.hpp>

namespace QuantLib {

	class ConstPayoff : public PayoffBase {
	  public:
		ConstPayoff(const std::string& symbolName,
					const Date& payoffDate,
					Real constValue)
		: symbolName_(symbolName), payoffDate_(payoffDate), constValue_(constValue)
		{
			this->initialize();
		}

		void initialize(const TimeGrid& timeGrid, const Calendar& calendar);
		void defineVar(const std::string& varStr){}
		void removeSymbol(std::string symbolName){}
		
		void setBaseIndexValue(const MultiPath& multiPath);
		Date payoffDate(){return payoffDate_;}
		Size payoffDatesPosition(){return payoffDatesPosition_;}
		
		void defineConst(const std::string& varStr,Real constValue){}
		void defineBaseIndex(const std::string& varStr){}

		Real value()
		{
			//#ifndef DEBUG
			//	if(!this->expired());
			//	QLERROR("")
			//#endif
			return constValue_;

		}
	private:
		Real constValue_;

	};

}
#endif
