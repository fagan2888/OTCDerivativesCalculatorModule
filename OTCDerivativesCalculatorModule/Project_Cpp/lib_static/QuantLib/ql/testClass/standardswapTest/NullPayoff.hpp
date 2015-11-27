#ifndef quantlibTest_nullpayoffmanager_hpp
#define quantlibTest_nullpayoffmanager_hpp

#include <ql/testClass/standardswapTest/indextransmanager.hpp>
#include <ql/testClass/standardswapTest/payoffmanager.hpp>

namespace QuantLib {

	class NullPayoffManager : public PayoffManager {
	  public:
		NullPayoffManager(const Date& payoffDate,
						  const std::vector<
									std::pair<std::string,boost::shared_ptr<IndexTransManagerBase>>>& itms);


		void initialize(const TimeGrid& timeGrid, const Calendar& calendar);
		void defineVar(const std::string& varStr){}
		void removeSymbol(std::string symbolName){}
		
		void setBaseIndexValue(const MultiPath& multiPath);
		Date payoffDate(){return payoffDate_;}
		Size payoffDatesPosition(){return payoffDatesPosition_;}
		
		void defineConst(const std::string& varStr,Real constValue){}
		void defineBaseIndex(const std::string& varStr){}

		Real value(const MultiPath& multiPath){return 0.0;}

	};

}
#endif
