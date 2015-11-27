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
		  
		  Real* thisPtr_; // variable�� ����� ��.

		  Real* payoffIndexPtr_;

		  //timePayoff�� �迭�� ����.
		  //��� �޾Ƽ� ����Ұ���.
		  // Real* payoffIndexPtr_[NUM];


	};

}
#endif
