#ifndef calculationModule_constPayoffmanager_hpp
#define calculationModule_constPayoffmanager_hpp

#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/IndexTran/eventIndexTransformation.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/Payoff/payoffBase.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/symbolmanager/IndexSymbolManager.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/symbolmanager/payoffInformation.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/variablevalue/constvariablevalue.hpp>

namespace QuantLib {

	
	class ConstPayoff : public PayoffBase {
	  public:
		ConstPayoff(const std::string& symbolName,
					const Date& payoffDate,
					Real constValue)
		: PayoffBase(symbolName) ,payoffDate_(payoffDate), constValue_(constValue)
		{
		}

		std::vector<Date> payoffDates()
		{
			std::vector<Date> dates;
			dates.push_back(this->payoffDate_);

			return dates;
		}
		void variableBind()
		{
			this->thisVariableValue_ = IndexSymbolManager::instance().getSymbol(this->symbolName_);
		}

		void variablePtrBind()
		{
			this->payoffIndexPtr_ = PayoffInformation::instance().getPositionPtr(payoffDate_);
			//this->thisPtr_ = this->thisVariableValue_->getPtr();
		}

		bool expired()
		{
			Date today = Settings::instance().evaluationDate();
			if( payoffDate_ < today )	{ return true; }
			else { return false; }
		}

		void calculate()
		{
			//thisVariableValue_->calculate() 사용안함. 왜냐면 어차피 fix이므로.

			//*thisPtr_ = constValue_;
			*payoffIndexPtr_ = constValue_;

			//#ifndef DEBUG
			//	if(!this->expired());
			//	QLERROR("")
			//#endif
		}

	private:
		Date payoffDate_;
		std::string symbolName_;
		Real constValue_;
	};

}
#endif
