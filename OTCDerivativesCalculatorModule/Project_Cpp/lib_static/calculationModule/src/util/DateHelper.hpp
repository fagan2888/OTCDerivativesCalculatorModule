#ifndef quantlib_dateHelper_hpp
#define quantlib_dateHelper_hpp

#include <boost/shared_ptr.hpp>
#include <ql/time/date.hpp>
#include <ql/time/calendar.hpp>


namespace QuantLib {
	class DateHelper {
	
		public:
			DateHelper();

			std::vector<Date> remainDates(Date referenceDate, 
										  std::vector<Date> dates,
										  bool includeRefDate);

			std::vector<Date> removeDuplicateDate(std::vector<Date> dates);

			void mergeDates(std::vector<Date>& targer,const std::vector<Date>& newDates);
			void mergeDates(std::vector<Date>& targer,const Date& newDate);

			//bool compETIEventDate(const boost::shared_ptr<EventTriggerInfo>& _first ,
			//					  const boost::shared_ptr<EventTriggerInfo>& _second);


	};


}

#endif