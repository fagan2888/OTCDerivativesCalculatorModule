#ifndef calculationModule_payoffmanager_hpp
#define calculationModule_payoffmanager_hpp

#include <ql/time/date.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/IndexTran/indextransBase.hpp>

namespace QuantLib {

	class PayoffBase {
	  public:
		PayoffBase(){}
		virtual ~PayoffBase(){}

	    PayoffBase(const std::string& symbolName);

		virtual std::vector<Date> payoffDates() = 0;
		
		virtual void calculate() = 0;
		virtual bool expired() = 0;
		virtual void variableBind() = 0;
		virtual void variablePtrBind() = 0;

		void setThisVariable(const boost::shared_ptr<VariableValue>& thisVariable);

		std::string symbolName();

	  protected:
		  std::string symbolName_;
		  Size symbolNum_;
		  Size payoffDatesPosition_;
		  boost::shared_ptr<VariableValue> thisVariableValue_;
		  
		  Real* thisPtr_; // variable과 연결된 것.

		  Real* payoffIndexPtr_;

		  //timePayoff는 배열을 가짐.
		  //상속 받아서 사용할거임.
		  // Real* payoffIndexPtr_[NUM];


	};

}
#endif
