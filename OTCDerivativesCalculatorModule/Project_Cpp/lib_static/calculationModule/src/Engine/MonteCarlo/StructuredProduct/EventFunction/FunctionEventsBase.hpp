//#ifndef calculationModule_functionEventsBase_hpp
//#define calculationModule_functionEventsBase_hpp
//
//#include <string>
//#include <boost/shared_ptr.hpp>
//
//namespace QuantLib {
//
//	class FunctionEventsBase {
//		public:
//			FunctionEventsBase(std::string symbol,
//							   const boost::shared_ptr<JointEvent>& joint)
//			: jointBoostPtr_(joint)
//			{
//				joint_ = joint.get();
//			}
//		  	
//		virtual bool eventOcc() = 0; // 밑에서 template로 상속이 되나..?
//		std::string functionSymbol(){return functionSymbol_;}
//
//		private:
//
//
//		//bool thisEventOcc_;
//	};
//}
//
//
//#endif