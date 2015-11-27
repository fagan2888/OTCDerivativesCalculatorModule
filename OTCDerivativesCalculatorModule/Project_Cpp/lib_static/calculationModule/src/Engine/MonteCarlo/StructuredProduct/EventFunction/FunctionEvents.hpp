#ifndef calculationModule_functionEvents_hpp
#define calculationModule_functionEvents_hpp

#include <string>
#include <boost/shared_ptr.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/SymbolManager/indexsymbolmanager.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/EventFunction/functionEventsBase.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/EventFunction/eventfunction.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/EventFunction/eventfunctionBase.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/JointEvent/JointEvent.hpp>


namespace QuantLib {

	class EventFunctionManager;

	//aggregate Class
	class FunctionEvents {
	  public:
		  FunctionEvents(std::valarray<boost::shared_ptr<EventFunctionManager>> eventFunctions,
						 const boost::shared_ptr<JointEvent>& joint);

  		  bool eventOcc();
		  Size eventNum();
		  void variableBind();
		  void variablePtrBind();
		  void validFixingDates(const std::vector<Date>& eventDates);

	  private:

		std::valarray<EventFunctionManager*> eventFunctions_;
		std::valarray<boost::shared_ptr<EventFunctionManager>> eventFunctionsMBoostPtr_;
		std::string symbol_;
		boost::shared_ptr<JointEvent> joint_;
		JointEvent* jointPtr_;
		Size EfNum_;
		  //bool thisEventOcc_;
	};

	

	//each class		
	class EventFunctionManager { //: public EventFunctionBase {
	  public:
		  EventFunctionManager(const std::string& functionSymbol,
							   const std::string& indexSymbol,
							   const boost::shared_ptr<EventFunction>& eventFunction);

		inline bool eventOcc(){return eventFunctions_->checkEventOcc(*indexValuePtr_);}
		inline std::string functionSymbol(){return functionSymbol_;}
		void variableBind();
		void variablePtrBind();
		void validFixingDates(const std::vector<Date>& eventDates);

	  private:
		  
		  double* indexValuePtr_;
		  std::string functionSymbol_;
		  std::string indexSymbol_;
		  EventFunction* eventFunctions_;
		  boost::shared_ptr<EventFunction> eventFunctionsBoostPtr_;

		  boost::shared_ptr<VariableValue> thisVariableValue_;
		  

	};


}

#endif
