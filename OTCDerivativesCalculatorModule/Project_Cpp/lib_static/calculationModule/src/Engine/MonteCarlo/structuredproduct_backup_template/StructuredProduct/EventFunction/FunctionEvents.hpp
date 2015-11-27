#ifndef calculationModule_functionEvents_hpp
#define calculationModule_functionEvents_hpp

#include <string>
#include <boost/shared_ptr.hpp>
#include <src/Engine/MonteCarlo/StructuredProduct/SymbolManager/indexsymbolmanager.hpp>
#include <src/Engine/MonteCarlo/StructuredProduct/EventFunction/functionEventsBase.hpp>
#include <src/Engine/MonteCarlo/StructuredProduct/EventFunction/eventfunction.hpp>
#include <src/Engine/MonteCarlo/StructuredProduct/EventFunction/eventfunctionBase.hpp>


namespace QuantLib {

	class EventFunctionManager;

	//aggregate Class
	class FunctionEvents {
	  public:
		  FunctionEvents(std::vector<boost::shared_ptr<EventFunctionManager>> eventFunctions,
						 const boost::shared_ptr<JointEvent>& joint);

		inline bool eventOcc();

	  private:

		std::vector<EventFunction*> eventFunctions_;
		std::vector<boost::shared_ptr<EventFunction>> eventFunctionsBoostPtr_;
		std::string symbol_;
		boost::shared_ptr<JointEvent> jointBoostPtr_;
		JointEvent* joint_;
		  //bool thisEventOcc_;
	};

	

	//each class		
	class EventFunctionManager //: public EventFunctionBase {
	  public:
		  EventFunctionManager(std::string functionSymbol,
							   std::string indexSymbol,
							   const boost::shared_ptr<EventFunction>& eventFunction);

		inline bool eventOcc(){eventFunctions_->checkEventOcc(*indexValuePtr_);}
		inline std::string functionSymbol(){return functionSymbol_;}

	  private:

		  double* indexValuePtr_;
		  std::string functionSymbol_;
		  std::string indexSymbol_;
		  EventFunction* eventFunctions_;
		  boost::shared_ptr<EventFunction> eventFunctionsBoostPtr_;
		  

	};


}
#endif
