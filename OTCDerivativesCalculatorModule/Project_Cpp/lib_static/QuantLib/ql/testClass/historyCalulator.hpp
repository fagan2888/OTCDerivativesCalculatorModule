#ifndef quantlib_history_calculator_hpp
#define quantlib_history_calculator_hpp

#include <ql/instrument.hpp>
#include <ql/index.hpp>
#include <ql/time/date.hpp>
#include <ql/settings.hpp>
//#include <iostream>
#include <vector>


namespace QuantLib {

    class HistoryCalculator {
      public:
		  HistoryCalculator(const std::vector<Date>& dates,
							const boost::shared_ptr<Instrument>& instrument,
							const std::vector<boost::shared_ptr<Index>>& paras);
		  
		  void calculate() const;
          virtual Real exercute(Date) const= 0;
		  virtual void checkParametor() const = 0 ;
		  std::vector<Real> historyValues();
		  

	protected:
		bool calculated_;
		std::vector<Date> dates_;
		std::vector<Real> values_;
		boost::shared_ptr<Instrument> instrument_;
		std::vector<boost::shared_ptr<Index> > paras_;

	};


}

#endif