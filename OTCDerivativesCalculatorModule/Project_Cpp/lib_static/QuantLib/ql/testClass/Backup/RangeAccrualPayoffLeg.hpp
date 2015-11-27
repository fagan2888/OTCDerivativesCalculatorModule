//Leg�� ��ӹ޾Ƽ� �����? Leg InterFace�� ����ؾ� �ϴϱ�.

//Index�� ��ǰ���� �����ͼ� ����ٰ� �ھ���. ������ Set�Ҽ��� ����.

#include <ql/cashflow.hpp>
#include <iostream>
#include <ql/math/matrix.hpp> 
#include <ql/option.hpp>
#include <ql/handle.hpp>
#include <ql/indexes/iborindex.hpp>
#include <ql/RangeAccrualPayoffLeg.hpp>


#ifndef quantlib_rangeaccrualpayoffLeg_hpp
#define quantlib_rangeaccrualpayoffLeg_hpp

#include "RangeAccrualCoupon.hpp"

namespace QuantLib{

class RangeAccrualPayoffLeg {
	public:
		RangeAccrualPayoffLeg(const std::vector<Date>& dates,
							  const std::vector<boost::shared_ptr<RangeAccrualCoupon>>& payoff,
				  //std::vector<boost::shared_ptr<InterestRateIndex>>& refIndex
				  );

		void value(Matrix & path, 
					Array   & payments, 
					Array   & exercises, 
					std::vector<Array> & states);
		
		// void setRefIndex(const std::vector<boost::shared_ptr<InterestRateIndex>>& refIndex);
		//void setPastFixing(Matrix & path);
		//void setPastCashflow();
		const std::vector<Date>& dates(){return dates_;}
		std::vector<boost::shared_ptr<RangeAccrualCoupon>> payoff() const;
		//std::vector<Real>& pastCashflow() const;

		void initialize();

		Leg& leg();

	protected:
		bool earlyExFlag_;
		std::vector<Date> dates_;
		std::vector<boost::shared_ptr<RangeAccrualCoupon>> payoff_;
		//std::vector<boost::shared_ptr<InterestRateIndex>> refIndex_;
		//Size pastFixingNum_;
		//Size totalFixingNum_;
		//std::vector<Real> pastCashflow_;
		Leg leg_;

};



}

#endif