//Leg�� ��ӹ޾Ƽ� �����? Leg InterFace�� ����ؾ� �ϴϱ�.

//Index�� ��ǰ���� �����ͼ� ����ٰ� �ھ���. ������ Set�Ҽ��� ����.

#include "PayoffLeg.hpp"

#ifndef quantlib_general_payoffLeg_hpp
#define quantlib_general_payoffLeg_hpp

namespace QuantLib{

	class GeneralPayoffLeg : public PayoffLeg {
	public:
		GeneralPayoffLeg (const std::vector<Date>& dates,
				  const std::vector<boost::shared_ptr<MonteCoupon>>& payoff,
				  std::vector<boost::shared_ptr<Index>>& refIndex);

		void value(Matrix & path, 
					Array   & payments, 
					Array   & exercises, 
					std::vector<Array> & states);

};



}

#endif