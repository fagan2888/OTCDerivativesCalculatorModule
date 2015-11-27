#ifndef quantlibTest_amortizemanager_hpp
#define quantlibTest_amortizemanager_hpp

#include <string>
#include <boost/shared_ptr.hpp>
#include <ql/testClass/standardswapTest/eventfunction.hpp>
#include <ql/testClass/standardswapTest/indexsymbolmanager.hpp>

namespace QuantLib {

	class AmortizeManager {
	  public:
//		  EventFunctionManager(){}
		  AmortizeManager(std::string indexSymbol,
						  boost::shared_ptr<EventFunction> eventFunction);

		bool eventOcc();

	  private:

		  double* indexValuePtr_;
		  std::string indexSymbol_;
		  boost::shared_ptr<EventFunction> eventFunction_;
	};

}
#endif
