#ifndef quantlib_fixingInformation_hpp
#define quantlib_fixingInformation_hpp

#include <ql/time/date.hpp>
#include <vector>

namespace QuantLib {
	class FixingInformation
	{
		public:
			FixingInformation(Real initialValue,
							  const std::vector<Date>& fixingDates,
							  const std::vector<Real>& fixingValues);

			Real fixingValue(const Date& date);

		private:
			Real initialValue_;
			std::vector<Date> fixingDates_;
			std::vector<Real> fixingValues_;
	};
}

#endif