#ifndef quantlib_amortizemanager_hpp
#define quantlib_amortizemanager_hpp

#include <string>
#include <boost/shared_ptr.hpp>
#include <ql/testClass/standardswap/eventfunction.hpp>
#include <ql/testClass/standardswap/indexsymbolmanager.hpp>

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
