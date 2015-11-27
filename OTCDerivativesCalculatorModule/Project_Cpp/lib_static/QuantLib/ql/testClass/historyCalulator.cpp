#include <ql/testClass/historyCalulator.hpp>

namespace QuantLib {

HistoryCalculator::HistoryCalculator(const std::vector<Date>& dates,
									 const boost::shared_ptr<Instrument>& instrument,
									 const std::vector<boost::shared_ptr<Index>>& paras)
				: dates_(dates),instrument_(instrument),paras_(paras)	{
			
}

std::vector<Real> HistoryCalculator::historyValues(){
			  	
			  for(Size i=0;i<dates_.size();++i){
					Date aa;
					//Date today=Settings::instance().evaluationDate();
					//exercute(aa  );

			  }

			  return values_;

}

}