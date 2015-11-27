//Leg�� ��ӹ޾Ƽ� �����? Leg InterFace�� ����ؾ� �ϴϱ�.

//Index�� ��ǰ���� �����ͼ� ����ٰ� �ھ���. ������ Set�Ҽ��� ����.


#ifndef quantlib_earlyex_payoffLeg_hpp
#define quantlib_earlyex_payoffLeg_hpp

#include "RedemptionPayoff.hpp"
#include "PayoffLeg.hpp"

namespace QuantLib{

	class EarlyExPayoffLeg : public PayoffLeg {
	public:
		EarlyExPayoffLeg(const std::vector<Date>& dates,
				  const std::vector<boost::shared_ptr<MonteCoupon>>& payoff,
				  const boost::shared_ptr<RedemptionPayoff>& exPayoff,
				  std::vector<boost::shared_ptr<Index>>& refIndex);

		void value(Matrix & path, 
					Array   & payments, 
					Array   & exercises, 
					std::vector<Array> & states);
		
		//std::vector<Real>& pastCashflow() const;

		//void initialize();

		//Leg& leg();

	protected:
		bool earlyExFlag_;
		boost::shared_ptr<RedemptionPayoff> exPayoff_;

};



}

#endif