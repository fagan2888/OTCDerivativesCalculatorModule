#ifndef calculationModule_contingentEvent_hpp
#define calculationModule_contingentEvent_hpp

#include <vector>
#include <valarray>

#include <src/Engine/FDM/math/domain.hpp>

namespace QuantLib {
    class ContingentEvent {
      public:
		ContingentEvent(const std::vector<Date>& eventDates,
						const std::vector<boost::shared_ptr<Domain>>& domains);

        virtual ~ContingentEvent() {}

		std::vector<Date> dates() const
		{
			return this->dates_;
		}
        
		bool hasOccurred(
            const Date& refDate = Date(),
            boost::optional<bool> includeRefDate = boost::none) const;


        bool eventOcc(const std::valarray<Real>& values) const
		{
			return this->domain_(values);
		}

		valarray<Date> eventDates()
		{
			return dates_;
		}

		valarray<Time> eventTimes()
		{

			return dates_;
		}

	  private:
		std::valarray<Date> dates_;





    };

}

#endif
