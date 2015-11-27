//Leg�� ��ӹ޾Ƽ� �����? Leg InterFace�� ����ؾ� �ϴϱ�.

//Index�� ��ǰ���� �����ͼ� ����ٰ� �ھ���. ������ Set�Ҽ��� ����.

#include <ql/testClass/PayoffLeg.hpp>

#ifndef quantlib_general_payoffLeg_hpp
#define quantlib_general_payoffLeg_hpp

namespace QuantLib{

	class GeneralPayoffLeg : public PayoffLeg {
	public:
		GeneralPayoffLeg (const std::vector<Date>& dates,
				  const std::vector<boost::shared_ptr<MonteCoupon>>& payoff,
				  std::vector<boost::shared_ptr<Index>>& refIndex,
				  bool isInArrears = false);

		void value(std::vector<Array> & path, 
					Array   & payments, 
					Array   & exercises, 
					std::vector<Array> & states);
	protected:
		bool isInArrears_;
		Real accrualRate_;
		Real remaintime_;

};



}

#endif