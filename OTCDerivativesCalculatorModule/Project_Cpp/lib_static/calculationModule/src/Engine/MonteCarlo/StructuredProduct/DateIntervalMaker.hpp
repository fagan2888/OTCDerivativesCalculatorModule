#ifndef calculationModule_dateintervalmaker_hpp
#define calculationModule_dateintervalmaker_hpp

//#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/EventCheck/EventCheckBase.hpp>

#include <ql/time/schedule.hpp>
#include <ql/settings.hpp>

namespace QuantLib {

class DateIntervalMaker {
	public:

		enum DateType {Daily , Weekly , OneDay , Dates};
		
		DateIntervalMaker(const Date& date);

		//Daily용
		DateIntervalMaker(const Date& firstDate,
						  const Date& Lastdate,
						  const Period& tenor, // skip에 사용할 tenor
						  const Calendar& calendar);

		//DateIntervalMaker(const Date& firstDate,
		//				  const Date& Lastdate,
		//				  const Calendar& calendar,
		//				  DateType type);

		DateIntervalMaker(const std::vector<Date> dates);
		  
		void duplicateRemove(std::vector<Date>& dates);

		std::vector<Date> dates(){return dates_;}
		std::vector<Date> skippedDates(){return skippedDates_;}
		std::vector<Date> historyDates(){return historyDates_;}
		std::vector<Date> nonSkippedRemainDates(){return nonSkippedRemainDates_;}
		std::vector<Date> skippedRemainDates(){return skippedRemainDates_;}


	private:

		std::vector<Date> dates_;
		std::vector<Date> skippedDates_;

		std::vector<Date> historyDates_;
		std::vector<Date> nonSkippedRemainDates_;
		std::vector<Date> skippedRemainDates_;

		Date firstDate_;
		Date Lastdate_;

		Calendar calendar_;
		Period skipTenor_;
		DateType dateType_;
	
};

}


#endif