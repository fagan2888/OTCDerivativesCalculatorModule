//Leg를 상속받아서 사용함? Leg InterFace를 사용해야 하니까.

//Index는 상품에서 가져와서 여기다가 박아줌. 하지만 Set할수는 있음.


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