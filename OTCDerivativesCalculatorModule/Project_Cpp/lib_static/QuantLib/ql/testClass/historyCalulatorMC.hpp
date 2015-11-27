#ifndef quantlib_history_calculatorMC_hpp
#define quantlib_history_calculatorMC_hpp


#include <ql/testclass/sethistoryparametor.hpp>
#include <ql/timeseries.hpp>
#include <ql/testClass/historyCalulator.hpp>
#include <ql/processes/stochasticprocessarray.hpp>
#include <ql/handle.hpp>


namespace QuantLib {

	class HistoryCalculatorMC : public HistoryCalculator {
      public:
		  HistoryCalculatorMC(const std::vector<Date>& dates,
							  const boost::shared_ptr<Instrument>& instrument,
							  const std::vector<boost::shared_ptr<Index>>& paras);
			
		  void setHistory();

		  Real exercute(Date) const;	
		  
		  void checkParametor() const;

		  std::vector<Real> historyValues();

		  //std::vector<std::string> paraList() const;

		  
	protected:
		Size indexNum_;
		std::vector<Date> dates_;
		std::vector<Real> values_;
		boost::shared_ptr<SetHistoryParametor> setHistoryParametor_;

		//std::vector<std::string> paraDrift_;
		std::vector< TimeSeries<Real>> paraSeries_;
		
		//std::vector<std::string> paraVol_;
		//std::vector< TimeSeries<Real>> volSeries;

		//std::vector<std::string> paraCorr_;
		//std::vector< TimeSeries<Real>> corrSeries;

	};
}

#endif