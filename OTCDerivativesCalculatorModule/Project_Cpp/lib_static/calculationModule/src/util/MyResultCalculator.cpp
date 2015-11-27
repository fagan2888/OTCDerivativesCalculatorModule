#include "MyResultCalculator.hpp"

namespace QuantLib 
{

MyResultCalculator::MyResultCalculator()
{}

void MyResultCalculator::calculation(const boost::shared_ptr<MCPricer>& pricer,
								   const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{

	const MultiPath& multiPath = pathGenFactory->next(false);
	
	Real r = pricer->calculate(multiPath,9999);
	multiPath.log_.push_back(ConvertFunction::to_string(r));

	// calcValue part
	this->value_ += r;

	const std::vector<boost::shared_ptr<CalcValueResult>>& calcValue_results 
		= pricer->valueResults();

	for ( Size i=0 ; i < calcValue_results.size() ; ++i )
	{
		this->valueResults_[i].cumulate(calcValue_results[i]);
	}

	// cashflow part

	const std::vector<boost::shared_ptr<CashFlowResult>>& cf_results 
		= pricer->cashFlowResults();

	for ( Size i=0 ; i < cf_results.size() ; ++i )
	{
		this->cashFlowResults_[i].cumulate(cf_results[i]);
	}

	pricer->reset();

	//multiPath.log_.reserve(100);
	//multiPath.log_.clear();

	//if ( multiPath.log_.size() < 100 )
	//{
	//	#ifdef LogPrint
	//		std::ostringstream ss;
	//		ss << multiPath.log_.size();
	//		multiPath.log_.push_back(ss.str());
	//	#endif
	//}

	for ( Size i=0 ; i < pathGenFactory->numAssets() ; ++i )
	{
		this->S_up_[i] += pricer->calculate(pathGenFactory->next_s_up(i),9999);
		pricer->reset();

		this->S_down_[i] += pricer->calculate(pathGenFactory->next_s_down(i),9999);
		pricer->reset();

		this->sigma_up_[i] += pricer->calculate(pathGenFactory->next_sigma_up(i),9999);
		pricer->reset();

		pathGenFactory->greekPathReset(i);
		//this->sigma_down_[i] += pricer->calculate(pathGenFactory->next_sigma_down(i),9999);

		
	}

	//if ( logList_.size() < 100 )
	//	this->resultCommulator_->recode(multiPath);

	//if ( logList_.size() < 100 )
	//	this->logList_.push_back(multiPath.log_);
	
}

void MyResultCalculator::initialize(const boost::shared_ptr<MCPricer>& pricer,
									const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory,
									Real simulNum)
{
	this->resultCommulator_ = boost::shared_ptr<ResultCommulator>( 
						new ResultCommulator(pathGenFactory->pathSize()));

	this->resultCommulator_->setDate(pathGenFactory->currentPath());
	this->resultCommulator_->setBasePrice(pathGenFactory->getProcessArrWrapper());

	this->numAssets_ = pathGenFactory->numAssets();
	
	this->simulNum_ = simulNum;
	this->value_ = 0.0;

	this->S_h_ = std::vector<double>(this->numAssets_,0.0) ;
	this->S_up_ = std::vector<double>(this->numAssets_,0.0) ;
	this->S_down_ = std::vector<double>(this->numAssets_,0.0) ;
	this->sigma_up_ = std::vector<double>(this->numAssets_,0.0) ;
	this->sigma_down_ = std::vector<double>(this->numAssets_,0.0) ;

	this->delta_ = std::vector<double>(this->numAssets_,0.0) ;
	this->gamma_ = std::vector<double>(this->numAssets_,0.0) ;
	this->vega_ = std::vector<double>(this->numAssets_,0.0) ;
	this->rho_ = std::vector<double>(this->numAssets_,0.0) ;
	
	Size timeHorizonSize = (pricer->valueTimeHorizon()).size() ;

	const std::vector<boost::shared_ptr<CalcValueResult>>& calcValue_results 
		= pricer->valueResults();

	this->valueResults_ = std::vector<CalcValueResult>( calcValue_results.size() );

	for ( Size i=0 ; i<calcValue_results.size() ; i++ )
	{
		this->valueResults_[i].initialize(calcValue_results[i],simulNum);
	}

	this->cashFlowResults_ = std::vector<CashFlowResult>(timeHorizonSize);

	const std::vector<boost::shared_ptr<CashFlowResult>>& cf_results 
		= pricer->cashFlowResults();

	for ( Size i=0 ; i<cf_results.size() ; i++ )
	{
		this->cashFlowResults_[i].initialize(cf_results[i],simulNum);
		//this->cashFlowResults_[i].payoffDate_= etiList[i]->getp();
	}

	this->underlyingName_ = std::vector<std::string>(this->numAssets_) ;
	this->underlyingValue_ = std::vector<double>(this->numAssets_,0.0) ;
	this->basePrice_ = std::vector<double>(this->numAssets_,0.0) ;
	this->volatility_ = std::vector<double>(this->numAssets_,0.0) ;

	for ( Size i=0 ; i<this->numAssets_ ; i++ )
	{
		this->S_h_[i] = pathGenFactory->getProcessArrWrapper()->processWrapper(i)->perturbation_h();
		this->underlyingName_[i] = pathGenFactory->getProcessArrWrapper()->processWrapper(i)->code();
		this->underlyingValue_[i] = pathGenFactory->getProcessArrWrapper()->processWrapper(i)->initialValue();
		this->basePrice_[i] = pathGenFactory->getProcessArrWrapper()->processWrapper(i)->basePrice();
		this->volatility_[i] = pathGenFactory->getProcessArrWrapper()->processWrapper(i)->volatility();
	}

	//this->earlyExProbability_ = std::vector<double>(this->numAssets_,0.0) ;

}


void MyResultCalculator::reset(const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	this->value_ = 0.0;

	for ( Size i=0 ; i < this->numAssets_ ; i++ )
	{
		this->S_up_[i] = 0.0;
		this->S_down_[i] = 0.0;
		this->sigma_up_[i] = 0.0;
		this->sigma_down_[i] = 0.0;
	}
}

void MyResultCalculator::calculateGreek()
{
	for ( Size i=0 ; i < this->numAssets_ ; i++ )
	{
		this->delta_[i] = ( ( S_up_[i] - S_down_[i] ) 
							/ ( 2 * S_h_[i] ) ) / this->simulNum_;
		
		this->gamma_[i] = ( ( S_up_[i] + S_down_[i] - ( 2 * this->value_ ) ) 
							/ ( S_h_[i] * S_h_[i] ) ) / this->simulNum_;

		this->vega_[i] = ( this->sigma_up_[i] - this->value_ ) / this->simulNum_;
	}
}

void MyResultCalculator::save()
{

	//CalculationLogCommulator clc = CalculationLogCommulator();

	//#ifdef LogPrint
	//	std::ostringstream pathCalcFile;
	//		
	//	//pathCalcFile << this->arguments_.code << "_" << "pathCalcLog.txt";
	//	pathCalcFile << "_" << "pathCalcLog.txt";
	//	clc.save(pathCalcFile.str() ,this->logList_);

	//#endif

	//std::ostringstream pathGenFile;
	////pathGenFile << this->arguments_.code << "_" << "generatedPath.txt";
	//pathGenFile << "_" << "generatedPath.txt";
	//this->resultCommulator_.save(pathGenFile.str());
}

double MyResultCalculator::value()
{
	return this->value_ / this->simulNum_;
}

std::vector<double> MyResultCalculator::delta()
{
	std::vector<double> _delta;

	for ( Size i =0 ; i < numAssets_; i++ )
	{
		_delta.push_back(this->delta_[i] );
	}

	return _delta;
}

std::vector<double> MyResultCalculator::gamma()
{
	std::vector<double> _gamma;

	for ( Size i =0 ; i < numAssets_; i++ )
	{
		_gamma.push_back(this->gamma_[i] );
	}

	return _gamma;
}

std::vector<double> MyResultCalculator::vega()
{
	std::vector<double> _vega;

	for ( Size i =0 ; i < numAssets_; i++ )
	{
		_vega.push_back(this->vega_[i] );
	}

	return _vega;
}

std::vector<double> MyResultCalculator::rho()
{
	std::vector<double> _rho;

	for ( Size i =0 ; i < numAssets_; i++ )
	{
		_rho.push_back(this->rho_[i] );
	}

	return _rho;
}

double MyResultCalculator::theta()
{
	return this->theta_;
}


}
