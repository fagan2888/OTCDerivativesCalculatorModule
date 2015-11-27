#include <ql/testClass/historyCalulatorMC.hpp>
#include <ql/processes/geometricbrownianprocess.hpp>

namespace QuantLib {

HistoryCalculatorMC::HistoryCalculatorMC(const std::vector<Date>& dates,
										 const boost::shared_ptr<Instrument>& instrument,
										 const std::vector<boost::shared_ptr<Index>>& paras)
			: HistoryCalculator(dates,instrument,paras)	{

				values_.resize(dates.size());
				setHistory();
				indexNum_=2;
				/*for(Size j=1;j < paras_.size();++j){
					Size numCorrCoef = 1;
					for(Size i=0;i<paras_.size();++i){
						numCorrCoef +=  (i+2);
						if(paras.size()==numCorrCoef){
							Size indexNum_ = j;
							break;
						}
					}

				}*/
				if (indexNum_==0){QL_FAIL("parametor number need");}

}
void HistoryCalculatorMC::setHistory(){
	//Drift
	for(Size i=0;i<paras_.size();++i) {
		//const std::string& suffix = "dividend";	
		const std::string& indexName = paras_[i]->name();// + "_" + suffix;
		const TimeSeries<Real>& series = 
					IndexManager::instance().getHistory(indexName);

		paraSeries_.push_back(series);

	}

	////vol
	//for(Size i=0;i<paras.size();++i) {
	//	//const std::string& suffix = "vol";	
	//	const std::string& indexName = paras[i]->name();// + "_" + suffix;
	//	const TimeSeries<Real>& paraVolSeries = 
	//				IndexManager::instance().getHistory(indexName);

	//	volSeries.push_back(paraVolSeries);

	//}				
	//
	//Corr
	
	/*for(Size i=0 ; i<numCorrCoef ; ++i) {
		const std::string& suffix = "corr";	
		const std::string& indexName = paras[0]->name() + "_" + suffix;
		const TimeSeries<Real>& paraCorrSeries = 
					IndexManager::instance().getHistory(indexName);

		corrSeries.push_back(paraCorrSeries);

	}*/


}

Real HistoryCalculatorMC::exercute(Date date) const{

	const boost::shared_ptr<PricingEngine>& engineM = instrument_->p_engine();

	//const PricingEngine *engine = instrument_->p_engine();
	const PricingEngine *engine = &(*engineM);
	
	const SetHistoryParametor* seth =
			dynamic_cast<const SetHistoryParametor*>(engine);

	QL_ENSURE(seth != 0, "wrong result type");
	
	
	

	std::vector<Real> drift(indexNum_);
	std::vector<Real> vol(indexNum_);

	std::vector<boost::shared_ptr<StochasticProcess1D> > gbmProcessArray;
	Matrix correlation(indexNum_,indexNum_,0.0);

	//correlation[0][0] = 1.0;		correlation[0][1] = corrSeries[0][date];
	//correlation[1][0] = corrSeries[0][date];	correlation[1][1] = 1.0;

	correlation[0][0] = 1.0;		correlation[0][1] = 0.5;
	correlation[1][0] = 0.5;	correlation[1][1] = 1.0;

	for(Size i=0;i<indexNum_;++i) {
		
		gbmProcessArray.push_back(
			boost::shared_ptr<StochasticProcess1D>(
				new GeometricBrownianMotionProcess(0, 0.0346 - paraSeries_[i+1][date], paraSeries_[i+1+indexNum_][date])));
		
	}

	boost::shared_ptr<StochasticProcessArray> gbmProcess(new StochasticProcessArray(
		gbmProcessArray,correlation));

	seth->setProcess(gbmProcess);

	return instrument_->NPV();

}

void HistoryCalculatorMC::checkParametor() const{


}

std::vector<Real> HistoryCalculatorMC::historyValues(){
	
	  Size dateNum=dates_.size();

	  for(Size i=0;i<dateNum;++i){

			Settings::instance().evaluationDate() = dates_[i];
			values_[i]=exercute(dates_[i]);
			
	  }

	  return values_;

}

//std::vector<std::string> paraList() const{
//
//	std::vector<std::string> 
//
//	indexNum_
//
//	return paraList;
//}



} //namespace QuantLib;