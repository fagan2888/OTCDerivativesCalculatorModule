//#ifndef calculationModule_eventfunctionBase_hpp
//#define calculationModule_eventfunctionBase_hpp
//
//#include <string>
//#include <boost/shared_ptr.hpp>
//#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/SymbolManager/indexsymbolmanager.hpp>
//#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/EventFunction/eventfunction.hpp>
//
//namespace QuantLib {
//
//	
//	class EventFunctionBase {
//	  public:
//		  EventFunctionBase(std::string functionSymbol,
//						    std::string indexSymbol,)
//		  {
//			indexValuePtr_ = IndexSymbolManager::instance().setSymbol(indexSymbol);
//		  }
//
//		virtual bool eventOcc();
//		std::string functionSymbol(){return functionSymbol_;}
//
//	  private:
//
//		  double* indexValuePtr_;
//		  std::string functionSymbol_;
//		  std::string indexSymbol_;
//		  EventFunction* eventFunctions_;
//		  boost::shared_ptr<EventFunction> eventFunctionsBoostPtr_;
//		  //bool thisEventOcc_;
//	};
//
//
//
//}
//#endif
