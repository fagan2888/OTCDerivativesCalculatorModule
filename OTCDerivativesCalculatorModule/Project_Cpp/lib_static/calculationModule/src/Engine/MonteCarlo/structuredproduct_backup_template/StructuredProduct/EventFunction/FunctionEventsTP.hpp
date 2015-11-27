#ifndef calculationModule_functionEventsTP_hpp
#define calculationModule_functionEventsTP_hpp

#include <string>
#include <boost/shared_ptr.hpp>
#include <src/Engine/MonteCarlo/StructuredProduct/SymbolManager/indexsymbolmanager.hpp>
#include <src/Engine/MonteCarlo/StructuredProduct/EventFunction/eventfunctionbase.hpp>

namespace QuantLib {

	//aggregate Class
	template <class EF,class Joint>
	class FunctionEventsTP : public FunctionEventsBase {
	  public:
		  FunctionEventsTP(std::string symbol,
						 std::vector<EventFunctionManagerTP<EF>> eventFunctions
						 Joint joint);
		  	
		template<class EF,Joint> bool eventOcc();

	  private:

		  std::vector<EventFunctionManagerTP<EF>> eventFunctions_;
		  //bool thisEventOcc_;
	};

	//each class
	template<class EF>
	class EventFunctionManagerTP : public EventFunctionBase {
	  public:
		  EventFunctionManagerTP(std::string functionSymbol,
							   std::string indexSymbol,
							   const EF& eventFunction);

		template<class EF> bool eventOcc();

	  private:

		  EF eventFunction_;

	};

}
#endif
