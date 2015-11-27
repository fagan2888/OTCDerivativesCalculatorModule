#ifndef quantlib_nullpayoffmanager_hpp
#define quantlib_nullpayoffmanager_hpp

#include <ql/testClass/standardswap/indextransmanager.hpp>
#include <ql/testClass/standardswap/payoffmanager.hpp>

namespace QuantLib {

	class NullPayoffManager : public PayoffManager {
	  public:
		NullPayoffManager();

		void initialize(const TimeGrid& timeGrid, const Calendar& calendar){
			payoffDatesPosition_=0;
		}
		void DefineVar(const std::string& varStr){}
		void removeSymbol(std::string symbolName){}
		Real value(const MultiPath& multiPath){return 0.0;}
		void setBaseIndexValue(const MultiPath& multiPath){}
		//Date payoffDate(){return payoffDate_;}
		Size payoffDatesPosition(){return 0;}
		void defineConst(const std::string varStr,Real constValue){}

	  private:

	};

}
#endif
