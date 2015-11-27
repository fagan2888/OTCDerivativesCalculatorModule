#ifndef quantlib_dailyInterval_hpp
#define quantlib_dailyInterval_hpp

#include <src/Engine/MonteCarlo/eventCalculation/dateInformation/dateInformation.hpp>

namespace QuantLib {

	class DailyInterval : public DateInformation {
		public:
			DailyInterval(const Date& observationStartDate,
							  const Date& observationEndDate);

			void initialize(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);
			
			std::valarray<Size> pastFixingDatePositions(); 
			std::valarray<Size> fixingDatePositions(); 
			std::vector<Date> fixingDates() const ;

		private:
			//Size intervalNum_;
			//Size pastIntervalNum_;
			std::valarray<Size> fixingDatePositions_;
			std::valarray<Size> pastFixingDatePositions_;
			Date observationStartDate_;
			Date observationEndDate_;

	};


}

#endif