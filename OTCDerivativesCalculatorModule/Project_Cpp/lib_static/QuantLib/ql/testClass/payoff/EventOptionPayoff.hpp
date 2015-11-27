#ifndef quantlib_EventOptionPayoff_hpp
#define quantlib_EventOptionPayoff_hpp

#include <ql/payoff.hpp>
#include <ql/math/array.hpp>
#include <ql/testClass/payoff/eventcheck.hpp>
#include <iostream>

namespace QuantLib {

	enum UnderType { MIN,MAX,AVER };

	class EventOptionPayoff  {
	public:
		EventOptionPayoff(const std::vector<boost::shared_ptr<ConcreteEvent>>& eventChecks,

					 const UnderType& underTypes,
					 //const std::vector<boost::shared_ptr<Payoff>>& OccEventEuPayoff,
					 const std::vector<std::vector<boost::shared_ptr<Payoff>>>& OccEventEuPayoff,

					 const std::vector<boost::shared_ptr<Payoff>>& noOccEventEuPayoff,
					 const std::vector<boost::shared_ptr<Payoff>>& underlyingTransform);
	
		Real underlyingFunc(const Array& indexValue) const;
		Real value(const Array& indexValue) const;
		void eventChecks(const Array& indexValue) const;
		void reset() const;
		

	private:

		mutable bool barrierHit_;
		Size hitEupayoffSize_,nohitEupayoffSize_;
		Size indexSize_;
		Array weights_;
		mutable Array underValue_;

		std::vector<boost::shared_ptr<BarrierCheck>> eventChecks_;


		UnderType underTypes_;
		std::vector<boost::shared_ptr<Payoff>> hitEuPayoff_;
		
		std::vector<boost::shared_ptr<Payoff>> nohitEuPayoff_;


		std::vector<boost::shared_ptr<Payoff>> underlyingTransform_;

		// 함수 포인터 사용해야함..


	};
}

#endif