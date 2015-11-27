#ifndef quantlibTest_functionEvents_hpp
#define quantlibTest_functionEvents_hpp

#include <string>
#include <boost/shared_ptr.hpp>
#include <ql/testClass/standardswapTest/indexsymbolmanager.hpp>
#include <ql/testClass/standardswapTest/eventfunction.hpp>

namespace QuantLib {

	//aggregate Class
	template<class Joint>
	class FunctionEvents : public FunctionEventsBase<Joint> {
	  public:
		  FunctionEvents(std::string symbol,
						 std::vector<boost::shared_ptr<EventFunctionManager>> eventFunction,
						 Joint joint);
		  	

		template<class Joint> bool eventOcc();

	  private:

		  boost::shared_ptr<EventFunction> eventFunction_;
		  //bool thisEventOcc_;
	};

	//each class		
	class EventFunctionManager {
	  public:
		  EventFunctionManager(std::string functionSymbol,
							   std::string indexSymbol,
							   const boost::shared_ptr<EventFunction>& eventFunction);

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
