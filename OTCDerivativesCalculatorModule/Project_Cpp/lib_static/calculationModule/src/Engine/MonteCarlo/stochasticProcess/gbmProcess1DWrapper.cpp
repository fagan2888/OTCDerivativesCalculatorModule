#include "gbmProcess1DWrapper.hpp"

namespace QuantLib {

GBMProcess1DWrapper::GBMProcess1DWrapper(const boost::shared_ptr<GeometricBrownianMotionProcess>& gbmProcess)
: gbmProcess_(gbmProcess)
{

}
GBMProcess1DWrapper::GBMProcess1DWrapper(const std::string& code,
										Real initialValue,
										Real mue,
										Real sigma)
:  mue_(mue), sigma_(sigma)
{
	this->initialValue_ = initialValue;
	this->code_ = code;
	this->perturbation_h_ = initialValue * 0.01;
}
 
void GBMProcess1DWrapper::generatePath(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition)
{
	//random 을 gen함
	targerPath[assetPosition][todayPosition] = S0_;
	Size pathSize = pathSize_;

	for ( Size t=todayPosition+1 ; t < pathSize ; t++ )
	{
		targerPath[assetPosition][t] = 
			targerPath[assetPosition][t-1] * muGrid_[t-1] * std::exp( volGrid_[t-1] * randomSeq[assetPosition][t] );
	}

}

void GBMProcess1DWrapper::generatePath_s_up(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition)
{
		//random 을 gen함
	targerPath[assetPosition][todayPosition] = S0_up_;
	Size pathSize = pathSize_;

	for ( Size t=todayPosition+1 ; t < pathSize ; t++ )
	{
		targerPath[assetPosition][t] = 
			targerPath[assetPosition][t-1] * muGrid_[t-1] * std::exp( volGrid_[t-1] * randomSeq[assetPosition][t] );
	}
}

void GBMProcess1DWrapper::generatePath_s_down(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition)
{
		//random 을 gen함
	targerPath[assetPosition][todayPosition] = S0_down_;
	Size pathSize = pathSize_;

	for ( Size t=todayPosition+1 ; t < pathSize ; t++ )
	{
		targerPath[assetPosition][t] = 
			targerPath[assetPosition][t-1] * muGrid_[t-1] * std::exp( volGrid_[t-1] * randomSeq[assetPosition][t] );
	}
}

void GBMProcess1DWrapper::generatePath_sigma_up(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition)
{
		//random 을 gen함
	targerPath[assetPosition][todayPosition] = S0_;
	Size pathSize = pathSize_;

	for ( Size t=todayPosition+1 ; t < pathSize ; t++ )
	{
		targerPath[assetPosition][t] = 
			targerPath[assetPosition][t-1] * muGrid_volup_[t-1] * std::exp( vol_upGrid_[t-1] * randomSeq[assetPosition][t] );
	}
}

void GBMProcess1DWrapper::generatePath_sigma_down(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition)
{
		//random 을 gen함
	targerPath[assetPosition][todayPosition] = S0_;
	Size pathSize = pathSize_;

	for ( Size t=todayPosition+1 ; t < pathSize ; t++ )
	{
		targerPath[assetPosition][t] = 
			targerPath[assetPosition][t-1] * muGrid_voldown_[t-1] * std::exp( vol_downGrid_[t-1] * randomSeq[assetPosition][t] );
	}
}

void GBMProcess1DWrapper::initialize(const TimeGrid& timeGrid)
{
	this->muGrid_ = std::valarray<Real>(timeGrid.size() - 1);
	this->muGrid_volup_ = std::valarray<Real>(timeGrid.size() - 1);
	this->muGrid_voldown_ = std::valarray<Real>(timeGrid.size() - 1);

	this->volGrid_ = std::valarray<Real>(timeGrid.size() - 1);
	this->vol_upGrid_ = std::valarray<Real>(timeGrid.size() - 1);
	this->vol_downGrid_ = std::valarray<Real>(timeGrid.size() - 1);

	pathSize_ = timeGrid.size();

	//초기화 수익률 or 절대값
	S0_ = this->initialValue_ / this->basePrice_;
	S0_up_ = ( this->initialValue_ + perturbation_h_ ) / this->basePrice_;
	S0_down_ = ( this->initialValue_ - perturbation_h_ ) / this->basePrice_;

	for (Size t = 0 ; t < pathSize_ - 1 ;++t)
	{
		double dt_t = timeGrid.dt(t);

		// exp( ( mu[t] - 0.5 * vol[t] * vol[t] ) * dt[t] )
		muGrid_[t] = std::exp( ( mue_ - 0.5 * sigma_ * sigma_ ) * dt_t );
		muGrid_volup_[t] = std::exp( ( mue_ - 0.5 * ( sigma_ + 0.01 ) * ( sigma_ + 0.01 ) ) * dt_t );
		muGrid_voldown_[t] = std::exp( ( mue_ - 0.5 * ( sigma_ - 0.01 ) * ( sigma_ - 0.01 ) ) * dt_t );

		//  vol[t] * sqrt(dt[t]) 
		volGrid_[t] = sigma_ * std::sqrt(dt_t);
		vol_upGrid_[t] = ( sigma_ + 0.01 )  * std::sqrt(dt_t);
		vol_downGrid_[t] = ( sigma_ - 0.01 ) * std::sqrt(dt_t);
	}
}

Real GBMProcess1DWrapper::volatility() const
{
	return this->sigma_;
}

}