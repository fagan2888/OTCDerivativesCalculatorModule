//Leg를 상속받아서 사용함? Leg InterFace를 사용해야 하니까.

//Index는 상품에서 가져와서 여기다가 박아줌. 하지만 Set할수는 있음.

#include <iostream>
#include <vector>
#include <ql/types.hpp>
#include <ql/math/array.hpp>

#ifndef quantlib_redemption_payoff_hpp
#define quantlib_redemption_payoff_hpp

namespace QuantLib{

class RedemptionPayoff {
	public:
		RedemptionPayoff(){}

		virtual bool isExpiry(Size,const Array&) = 0;
		virtual Real value(const Array&) = 0;

	protected:
		bool earlyExFlag_;

};

}

#endif