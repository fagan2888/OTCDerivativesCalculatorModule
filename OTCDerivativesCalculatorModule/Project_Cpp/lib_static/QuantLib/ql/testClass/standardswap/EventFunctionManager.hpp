#ifndef quantlib_eventfunctionmanager_hpp
#define quantlib_eventfunctionmanager_hpp

#include <string>
#include <boost/shared_ptr.hpp>
#include <ql/testClass/standardswap/indexsymbolmanager.hpp>
#include <ql/testClass/standardswap/eventfunction.hpp>

namespace QuantLib {

	class EventFunctionManager {
	  public:
//		  EventFunctionManager(){}
		  EventFunctionManager(std::string functionSymbol,
							   std::string indexSymbol,
							   boost::shared_ptr<EventFunction> eventFunction);

		bool eventOcc();
		std::string functionSymbol(){return functionSymbol_;}

	  private:

		  double* indexValuePtr_;
		  std::string functionSymbol_;
		  std::string indexSymbol_;
		  boost::shared_ptr<EventFunction> eventFunction_;
		  //bool thisEventOcc_;
	};

}
#endif
