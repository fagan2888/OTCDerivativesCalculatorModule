#ifndef quantlib_optionpayoff_hpp
#define quantlib_optionpayoff_hpp

#include <ql/payoff.hpp>
#include <ql/math/array.hpp>
#include <ql/testClass/standardswap/eventcheck.hpp>
#include <iostream>

namespace QuantLib {

	enum UnderType { MIN,MAX,AVER };

	class OptionPayoff  {
	public:
		OptionPayoff(const std::vector<boost::shared_ptr<EventCheck>>& eventChecks,
					 const UnderType& underTypes,
					 const std::vector<std::vector<boost::shared_ptr<Payoff>>>& hitEuPayoff,
					 const std::vector<boost::shared_ptr<Payoff>>& nohitEuPayoff,
					 const std::vector<boost::shared_ptr<Payoff>>& underlyingTransform);
	
		Real underlyingFunc(const Array& indexValue) const;
		Real value(const Array& indexValue) const;
		std::vector<boost::shared_ptr<EventCheck>> eventChecks() const;

		void checkEventOcc(const Array& indexValue,Size k) const;
		void reset() const;
		

	private:

		mutable std::vector<bool> eventOcc_;
		Size hitEupayoffSize_,nohitEupayoffSize_;
		Size indexSize_,eventSize_;
		Array weights_;
		mutable Array underValue_;

		//체크해야할 이벤트를 죄다 모아놈 
		std::vector<boost::shared_ptr<EventCheck>> eventChecks_;

		UnderType underTypes_;

		// 2 dim vector < event별 payoff , 개별 payoff (더해서 사용할거임) >
		std::vector<std::vector<boost::shared_ptr<Payoff>>> hitEuPayoff_;
		
		// 개별 payoff (더해서 사용할거임)
		std::vector<boost::shared_ptr<Payoff>> nohitEuPayoff_;
		
		// 인덱스별 transform 할것
		std::vector<boost::shared_ptr<Payoff>> underlyingTransform_;


	};
}

#endif