#ifndef quantlib_datelist_hpp
#define quantlib_datelist_hpp

#include <src/Engine/MonteCarlo/eventCalculation/dateInformation/dateInformation.hpp>

namespace QuantLib {

	class DateList : public DateInformation {
		public:
			DateList(const std::vector<Date>& dateList);

			void initialize(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);
			
			std::valarray<Size> pastFixingDatePositions();
			std::valarray<Size> fixingDatePositions(); 
			std::vector<Date> fixingDates() const;

		private:
			Size dateNum_;
			std::valarray<Size> fixingDatePositions_;
			std::valarray<Size> pastFixingDatePositions_;
			std::vector<Date> dateList_;

	};


}

#endif