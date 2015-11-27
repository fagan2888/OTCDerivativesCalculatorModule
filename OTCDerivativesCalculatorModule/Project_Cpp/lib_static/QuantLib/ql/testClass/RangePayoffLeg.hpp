//Leg를 상속받아서 사용함? Leg InterFace를 사용해야 하니까.

//Index는 상품에서 가져와서 여기다가 박아줌. 하지만 Set할수는 있음.

#include <ql/testClass/PayoffLeg.hpp>
#include <ql/math/matrix.hpp>

#ifndef quantlib_general_payoffLeg_hpp
#define quantlib_general_payoffLeg_hpp

namespace QuantLib{

	class RangePayoffLeg: public PayoffLeg {
	public:
		RangePayoffLeg(const Date& startDate,
					   const Schedule& schedule,
					   std::vector<boost::shared_ptr<Index>>& index,
					   const DayCounter& dayCounter,
					   const std::vector<Real>& couponRate,
				       const Matrix& upperTrigger,
					   const Matrix& lowerTrigger,
					   const std::vector<Real>& gearing,
					   const std::vector<Real>& spread,
					   const std::vector<Real>& capRate,
					   const std::vector<Real>& floorRate,
					   bool accrual,
                       bool isInArrears);

		void value(std::vector<Array> & path, 
					Array   & payments, 
					Array   & exercises, 
					std::vector<Array> & states);

};



}

#endif