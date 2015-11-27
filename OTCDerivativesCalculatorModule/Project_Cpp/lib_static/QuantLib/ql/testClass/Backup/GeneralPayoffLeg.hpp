//Leg를 상속받아서 사용함? Leg InterFace를 사용해야 하니까.

//Index는 상품에서 가져와서 여기다가 박아줌. 하지만 Set할수는 있음.

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