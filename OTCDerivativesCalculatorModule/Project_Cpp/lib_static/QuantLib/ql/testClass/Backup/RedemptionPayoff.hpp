//Leg�� ��ӹ޾Ƽ� �����? Leg InterFace�� ����ؾ� �ϴϱ�.

//Index�� ��ǰ���� �����ͼ� ����ٰ� �ھ���. ������ Set�Ҽ��� ����.

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