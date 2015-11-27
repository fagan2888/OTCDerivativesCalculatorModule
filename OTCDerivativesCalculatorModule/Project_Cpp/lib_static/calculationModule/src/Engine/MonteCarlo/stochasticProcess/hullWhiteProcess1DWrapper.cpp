#include "hullWhiteProcess1DWrapper.hpp"
#include <ql/math/solvers1d/bisection.hpp>
#include <iostream>

namespace QuantLib {

//HullWhiteProcess1DWrapper::HullWhiteProcess1DWrapper(const boost::shared_ptr<HullWhiteProcess>& hullWhiteProcess)
//: hullWhiteProcess_(hullWhiteProcess)
//{
//
//}

HullWhiteProcess1DWrapper::HullWhiteProcess1DWrapper(const std::string& code,
													 const std::string& currency,
													 const boost::shared_ptr<YieldTermStructure>& fittingCurve,
													 Period& tenor,					  
													 Period& legTenor,
													 const std::string& rateType,
													 Real initialValue,
													 Real a,
													 Real sigma)
: fittingCurve_(fittingCurve), currency_(currency), tenor_(tenor), legTenor_(legTenor),
  rateType_(rateType), a_(a), sigma_(sigma)
{
	this->initialValue_ = initialValue;
	this->r0_ = initialValue;
	this->code_ = code;
	this->perturbation_h_ = 0.001;
	this->sigma_perturbation_ = 0.01;

	//// default
	//legTenor_ = Period(6,Months);
	//rateType_ = "ir"; // or cmt or cms
}

void HullWhiteProcess1DWrapper::generatePath(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition)
{
	//random 을 gen함
	//targerPath[assetPosition][todayPosition] = this->initialValue_;
	targerPath[assetPosition][todayPosition] = this->r0_;
	//std::cout << r0_;
	Size pathSize = pathSize_;

	//std::cout << std::endl;
	//std::cout << "--------------------------" << std::endl;

	// 1개월 단위로 Gen함.
	for ( Size t=todayPosition + 1 ; t < pathSize ; t++ )
	{
		double r = targerPath[assetPosition][t-1];

		targerPath[assetPosition][t] = r + 
									   ( thetaGrid_[t-1] - a_ * r ) * dtGrid_[t] + 
									   sigma_ * std::sqrt(dtGrid_[t]) * randomSeq[assetPosition][t];

		//std::cout << "t: " << t << " - " << targerPath[assetPosition][t] << std::endl;

	}

	#ifdef LogPrint
	
	std::ostringstream ss;

	for ( Size t=0 ; t < pathSize ; t++ )
	{
		//ss << "t: " << t << " - " << targerPath[assetPosition][t] << std::endl;
		ss << targerPath[assetPosition][t] << std::endl;
		
	}

	targerPath.log_.push_back(ss.str());

	#endif

	this->convertingPath(targerPath,randomSeq,todayPosition,assetPosition);

	// 남은 사이 구간을 선형으로 보간함.

}

void HullWhiteProcess1DWrapper::generatePath_s_up(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition)
{
	//random 을 gen함
	//targerPath[assetPosition][todayPosition] = this->initialValue_ + perturbation_h_;
	targerPath[assetPosition][todayPosition] = this->r0_ + perturbation_h_;
	//std::cout << r0_;
	Size pathSize = pathSize_;

	//std::cout << std::endl;
	//std::cout << "--------------------------" << std::endl;

	for ( Size t=todayPosition + 1 ; t < pathSize ; t++ )
	{
		double r = targerPath[assetPosition][t-1];
		targerPath[assetPosition][t] = r + 
									   ( thetaGrid_[t-1] - a_ * r ) * dtGrid_[t] + 
									   sigma_ * std::sqrt(dtGrid_[t]) * randomSeq[assetPosition][t];
		//std::cout << "t: " << t << " - " << targerPath[position][t] << std::endl;
		//targerPath[position][t] = evolve
	}
}

void HullWhiteProcess1DWrapper::generatePath_s_down(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition)
{
	//random 을 gen함
	//targerPath[assetPosition][todayPosition] = this->initialValue_ - perturbation_h_;
	targerPath[assetPosition][todayPosition] = this->r0_- perturbation_h_;
	//std::cout << r0_;
	Size pathSize = pathSize_;

	//std::cout << std::endl;
	//std::cout << "--------------------------" << std::endl;

	for ( Size t=todayPosition + 1 ; t < pathSize ; t++ )
	{
		double r = targerPath[assetPosition][t-1];
		targerPath[assetPosition][t] = r + 
									   ( thetaGrid_[t-1] - a_ * r ) * dtGrid_[t] + 
									   sigma_ * std::sqrt(dtGrid_[t]) * randomSeq[assetPosition][t];
		//std::cout << "t: " << t << " - " << targerPath[position][t] << std::endl;
		//targerPath[position][t] = evolve
	}
}

void HullWhiteProcess1DWrapper::generatePath_sigma_up(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition)
{
	//random 을 gen함
	//targerPath[assetPosition][todayPosition] = this->initialValue_ ;
	targerPath[assetPosition][todayPosition] = this->r0_ ;
	//std::cout << r0_;
	Size pathSize = pathSize_;

	//std::cout << std::endl;
	//std::cout << "--------------------------" << std::endl;

	for ( Size t=todayPosition + 1 ; t < pathSize ; t++ )
	{
		double r = targerPath[assetPosition][t-1];
		targerPath[assetPosition][t] = r + 
									   ( thetaGrid_sigma_up_[t-1] - a_ * r ) * dtGrid_[t] + 
									   ( sigma_ + sigma_perturbation_ ) * std::sqrt(dtGrid_[t]) * randomSeq[assetPosition][t];
		//std::cout << "t: " << t << " - " << targerPath[position][t] << std::endl;
		//targerPath[position][t] = evolve
	}
}

void HullWhiteProcess1DWrapper::generatePath_sigma_down(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition)
{
	//random 을 gen함
	//targerPath[assetPosition][todayPosition] = this->initialValue_ ;
	targerPath[assetPosition][todayPosition] = this->r0_ ;
	//std::cout << r0_;
	Size pathSize = pathSize_;

	//std::cout << std::endl;
	//std::cout << "--------------------------" << std::endl;

	for ( Size t=todayPosition + 1 ; t < pathSize ; t++ )
	{
		double r = targerPath[assetPosition][t-1];
		targerPath[assetPosition][t] = r + 
									   ( thetaGrid_sigma_down_[t-1] - a_ * r ) * dtGrid_[t] + 
									   ( sigma_ - sigma_perturbation_ ) * std::sqrt(dtGrid_[t]) * randomSeq[assetPosition][t];
		//std::cout << "t: " << t << " - " << targerPath[position][t] << std::endl;
		//targerPath[position][t] = evolve
	}
}

void HullWhiteProcess1DWrapper::initialize(const TimeGrid& timeGrid)
{
	//hullWhiteProcess_->setPreCalculation(timeGrid);

	//r0_ = fittingCurve_->forwardRate(0.0,years(tenor_),Continuous,NoFrequency);
	//r0_ = fittingCurve_->zeroRate(years(tenor_),Continuous,NoFrequency);
	//r0_ = this->basePrice_;

	//this->thetaGrid_ = std::valarray<Real>(timeGrid.size() - 1);
	//this->dtGrid_ = std::valarray<Real>(timeGrid.size() - 1);

	this->thetaGrid_ = std::valarray<Real>(timeGrid.size());
	this->thetaGrid_s_up_ = std::valarray<Real>(timeGrid.size());
	this->thetaGrid_s_down_ = std::valarray<Real>(timeGrid.size());
	this->thetaGrid_sigma_up_ = std::valarray<Real>(timeGrid.size());
	this->thetaGrid_sigma_down_ = std::valarray<Real>(timeGrid.size());

	this->tGrid_ = std::valarray<Real>(timeGrid.size());
	this->dtGrid_ = std::valarray<Real>(timeGrid.size());

	Real T = this->periodToTime(this->tenor_) ;
	this->legFraction_ = this->periodToTime(this->legTenor_);
	this->legTenorNum_ = static_cast<Size>( T / this->legFraction_ );

	pathSize_ = timeGrid.size();

	//초기화 수익률 or 절대값
	//S0_ = gbmProcess_->x0() / gbmProcess_->basePrice();

	Real alpha_drift = 0.0;
    Real shift = 0.0001;
    Real f = 0.0;
    Real fup = 0.0;
    Real f_prime_t = 0.0;

	dtGrid_[0] = 0.0;

	for (Size t = 1 ; t < pathSize_ ;++t)
	{
		tGrid_[t] = timeGrid.at(t);
		dtGrid_[t] = timeGrid.dt(t-1);
	}

	for (Size t = 1 ; t < pathSize_ ;++t)
	{
		alpha_drift = sigma_*sigma_/(2*a_)*(1-std::exp(-2*a_*t));

		f = fittingCurve_->forwardRate(timeGrid[t], timeGrid[t], Continuous, NoFrequency);
		fup = fittingCurve_->forwardRate(timeGrid[t]+shift, timeGrid[t]+shift, Continuous, NoFrequency);
		f_prime_t = (fup-f)/shift;
		alpha_drift += a_*f+f_prime_t;

		// ft(0,t) + aF(0,t) + (sigma^2 / 2*sigma) * ( 1 - exp(-2at) )
		thetaGrid_[t] = f_prime_t + a_*f + alpha_drift;
	}

	// s_up
	for (Size t = 1 ; t < pathSize_ ;++t)
	{
		alpha_drift = sigma_*sigma_/(2*a_)*(1-std::exp(-2*a_*t));

		f = fittingCurve_->forwardRate(timeGrid[t], timeGrid[t], Continuous, NoFrequency) + this->perturbation_h_;
		fup = fittingCurve_->forwardRate(timeGrid[t]+shift, timeGrid[t]+shift, Continuous, NoFrequency) + this->perturbation_h_;
		f_prime_t = (fup-f)/shift;
		alpha_drift += a_*f+f_prime_t;

		// ft(0,t) + aF(0,t) + (sigma^2 / 2*sigma) * ( 1 - exp(-2at) )
		thetaGrid_s_up_[t] = f_prime_t + a_*f + alpha_drift;
	}

	// s_down
	for (Size t = 1 ; t < pathSize_ ;++t)
	{
		alpha_drift = sigma_*sigma_/(2*a_)*(1-std::exp(-2*a_*t));

		f = fittingCurve_->forwardRate(timeGrid[t], timeGrid[t], Continuous, NoFrequency) - this->perturbation_h_;
		fup = fittingCurve_->forwardRate(timeGrid[t]+shift, timeGrid[t]+shift, Continuous, NoFrequency) - this->perturbation_h_;
		f_prime_t = (fup-f)/shift;
		alpha_drift += a_*f+f_prime_t;

		// ft(0,t) + aF(0,t) + (sigma^2 / 2*sigma) * ( 1 - exp(-2at) )
		thetaGrid_s_down_[t] = f_prime_t + a_*f + alpha_drift;
	}

	// vol_up
	for (Size t = 1 ; t < pathSize_ ;++t)
	{
		alpha_drift = (sigma_ + sigma_perturbation_)*(sigma_+sigma_perturbation_)/(2*a_)*(1-std::exp(-2*a_*t));
		f = fittingCurve_->forwardRate(timeGrid[t], timeGrid[t], Continuous, NoFrequency);
		fup = fittingCurve_->forwardRate(timeGrid[t]+shift, timeGrid[t]+shift, Continuous, NoFrequency);
		f_prime_t = (fup-f)/shift;
		alpha_drift += a_*f+f_prime_t;

		// ft(0,t) + aF(0,t) + (sigma^2 / 2*sigma) * ( 1 - exp(-2at) )
		thetaGrid_sigma_up_[t] = f_prime_t + a_*f + alpha_drift;
	}

	// vol_down
	for (Size t = 1 ; t < pathSize_ ;++t)
	{
		alpha_drift = ( sigma_ - sigma_perturbation_ ) * ( sigma_ - sigma_perturbation_)/(2*a_)*(1-std::exp(-2*a_*t));
		f = fittingCurve_->forwardRate(timeGrid[t], timeGrid[t], Continuous, NoFrequency);
		fup = fittingCurve_->forwardRate(timeGrid[t]+shift, timeGrid[t]+shift, Continuous, NoFrequency);
		f_prime_t = (fup-f)/shift;
		alpha_drift += a_*f+f_prime_t;

		// ft(0,t) + aF(0,t) + (sigma^2 / 2*sigma) * ( 1 - exp(-2at) )
		thetaGrid_sigma_down_[t] = f_prime_t + a_*f + alpha_drift;
	}
	
	// converting initialize

	this->convertingInitialize(timeGrid);

}

void HullWhiteProcess1DWrapper::convertingInitialize(const TimeGrid& timeGrid)
{
	Date today = Settings::instance().evaluationDate();

	// for converting 
	this->convertingPathNum_ = 12 * timeGrid.back() + 2;
	this->todayConvPosition_ = 0;
	this->converting_tGrid_ = std::valarray<Real>(this->convertingPathNum_);
	this->converting_tPos_ = std::valarray<Size>(this->convertingPathNum_);
	
	//this->converting_dtGrid_ = std::valarray<Real>(legNum);

	this->converting_tGrid_[0] = 0.0;

	for (Size t = 1 ; t < this->convertingPathNum_ ; ++t)
	{
		if (t != ( pathSize_ - 1 ) )
		{
			Size t_pos = timeGrid.closestIndex( t * ( 1.0/12.0 ) );
			converting_tPos_[t] = t_pos;
			converting_tGrid_[t] = timeGrid.at(t_pos);
		}else
		{
			converting_tPos_[t] = timeGrid.size()  - 1;
			converting_tGrid_[t] = timeGrid.back();
		}


	}

	// conv 될 leg의 시작점을 찾아서 넣음.
	for (Size t = 0 ; t < this->convertingPathNum_ ; ++t)
	{
		if ( today < timeGrid.dateAt(converting_tPos_[t]) )
		{
			this->todayConvPosition_ = t;
			break;
		}
	}

	if ( this->rateType_== "CMT" )
	{
		// for converting 
		this->B_ti_T_ = std::vector<std::vector<Real>>(
			this->convertingPathNum_, std::vector<Real>( 1 ,0.0));

		this->A_t_T_  = std::vector<std::vector<Real>>(
			this->convertingPathNum_, std::vector<Real>( 1 ,0.0));

		Real T = this->periodToTime(this->tenor_) ;

		// ex) P(time_t,10Y + time_t) 하나만 구함
		for ( Size tPos=0 ; tPos < this->convertingPathNum_ ; tPos++ )
		{
			Real time_t = this->converting_tGrid_[tPos];

			Real Pm_0_T = this->fittingCurve_->discount( T + time_t );

			Real Pm_0_t = this->fittingCurve_->discount(time_t);
			Real fm_0_t = this->fittingCurve_->forwardRate(time_t,time_t + 0.25,Compounded);

			Real B_ti_T = ( 1.0 / this->a_ ) * ( 1 - std::exp( - this->a_ * ( T ) ) );
			this->B_ti_T_[tPos][0] = B_ti_T;

			this->A_t_T_[tPos][0] = ( Pm_0_T / Pm_0_t ) * 
				std::exp( 
				B_ti_T * fm_0_t - ( ( this->sigma_ * this->sigma_ ) / ( 4*this->a_ ) ) * (1 - std::exp( -2 * this->a_ * time_t ) ) * B_ti_T * B_ti_T 
				);

		}

		// optimization 
		Real conv_initial = ( 1 / this->B_ti_T_[0][0] ) 
							   * ( T * std::log( 1.0 + this->initialValue_ ) + std::log( this->A_t_T_[0][0] ) ) ;

		this->r0_ = conv_initial ;
		//Real P_t_T = this->A_t_T_[0][0] * std::exp( -B_ti_T_[0][0] * conv_initial );

		//Real kk = std::pow( (1 / P_t_T ) , ( 1 / T ) ) - 1;

		//Real ssk = 0.0;

	}
	else if ( this->rateType_== "CMS" || this->rateType_== "SWAP")
	{

		// for converting 
		this->B_ti_T_ = std::vector<std::vector<Real>>(
			this->convertingPathNum_, std::vector<Real>(this->legTenorNum_,0.0));

		this->A_t_T_  = std::vector<std::vector<Real>>(
			this->convertingPathNum_, std::vector<Real>(this->legTenorNum_,0.0));

		Real leg_ti =0.0;
		Real T = this->periodToTime(this->tenor_) ;

		// ex) P(time_t,10Y + time_t) , P(time_t + 0.5,10Y + time_t) 구함
		for ( Size tPos=0 ; tPos < this->convertingPathNum_ ; tPos++ )
		{
			Real time_t = this->converting_tGrid_[tPos];

			Real Pm_0_T = this->fittingCurve_->discount( T + time_t );

			for ( Size i=0 ; i < this->legTenorNum_ ; i++ )
			{
				leg_ti = this->legFraction_ * i ;

				Real ti = time_t + leg_ti ; 

				Real Pm_0_ti = this->fittingCurve_->discount(ti);
				Real fm_0_ti = this->fittingCurve_->forwardRate(ti,ti + this->legFraction_,Compounded);

				Real B_ti_T = ( 1.0 / this->a_ ) * ( 1 - std::exp( - this->a_ * ( T - leg_ti ) ) );
				this->B_ti_T_[tPos][i] = B_ti_T;

				this->A_t_T_[tPos][i] = ( Pm_0_T / Pm_0_ti ) * 
					std::exp( 
					B_ti_T * fm_0_ti - ( ( this->sigma_ * this->sigma_ ) / ( 4*this->a_ ) ) * (1 - std::exp( -2 * this->a_ * time_t ) ) * B_ti_T * B_ti_T 
					);
			}

		}

		CMSRate cmsRate(this->A_t_T_[0] ,this->B_ti_T_[0] ,this->legFraction_, this->initialValue_);
		
		Bisection solver=Bisection();
			
		Real scope = 0.01;
		Real initialRate = solver.solve(cmsRate,0.00001,this->initialValue_,this->initialValue_ - scope,this->initialValue_ + scope);

		this->r0_ = initialRate;

		//std::cout << cmsRate(initialRate);
		

	}
	else
	{
	
	}

}

void HullWhiteProcess1DWrapper::convertingPath(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition)
{
	Size tPos = 0;
	Size pre_tPos = todayPosition;

	Real rt = 0.0 ;
	Real dt = 0.0 ;
	Real slope = 0.0 ;
	Real conv_r = 0.0;

	Real pre_rt = targerPath[assetPosition][ todayPosition ];

	// converting함. 또는 converting을 구간만함.
	for ( Size t = this->todayConvPosition_ ; t < this->convertingPathNum_ ; t++ )
	{
		tPos = this->converting_tPos_[t];

		rt = targerPath[assetPosition][ tPos ];
		conv_r = this->indexAdjustment(rt, t );

		//std::cout << "r[" << t << "] : " << rt << " conv_rt : " << conv_r << std::endl;

		targerPath[assetPosition][ tPos ] = conv_r;
		
		slope = ( conv_r - pre_rt ) / ( this->tGrid_[tPos] - this->tGrid_[pre_tPos] ); 

		for ( Size k = pre_tPos + 1 ; k < tPos ; k++ )
		{
			dt = this->tGrid_[k] - this->tGrid_[pre_tPos];
			//targerPath[assetPosition][ k ] = slope * dt + targerPath[assetPosition][ k ];
			targerPath[assetPosition][ k ] = slope * dt + pre_rt;

			// tb + (1-t)a + t(b-r_k) + (1-t)(a-r_k) -> 이걸로...?

		}

		pre_rt = conv_r;
		pre_tPos = tPos;

	}

	#ifdef LogPrint
	
	std::ostringstream ss;

	for ( Size t=0 ; t < targerPath.pathSize() ; t++ )
	{
		//ss << "conv_t: " << t << " - " << targerPath[assetPosition][t] << std::endl;
		ss << targerPath[assetPosition][t] << std::endl;
		
	}

	targerPath.log_.push_back(ss.str());

	#endif

}

//void HullWhiteProcess1DWrapper::initialize(const TimeGrid& timeGrid)
//{
//	Size legNum = 12 * timeGrid.back() + 2;
//
//	this->thetaGrid_ = std::valarray<Real>(legNum );
//	this->thetaGrid_s_up_ = std::valarray<Real>(legNum);
//	this->thetaGrid_s_down_ = std::valarray<Real>(legNum);
//	this->thetaGrid_sigma_up_ = std::valarray<Real>(legNum);
//	this->thetaGrid_sigma_down_ = std::valarray<Real>(legNum);
//
//	this->tGrid_ = std::valarray<Real>(legNum);
//	this->dtGrid_ = std::valarray<Real>(legNum);
//
//	this->pathSize_ = legNum;
//
//	//초기화 수익률 or 절대값
//	//S0_ = gbmProcess_->x0() / gbmProcess_->basePrice();
//
//	Real alpha_drift = 0.0;
//    Real shift = 0.0001;
//    Real f = 0.0;
//    Real fup = 0.0;
//    Real f_prime_t = 0.0;
//
//	dtGrid_[0] = 0.0;
//	tGrid_[0] = 0.0;
//
//	for (Size t = 1 ; t < pathSize_  ;++t)
//	{
//		if (t != ( pathSize_ - 1 ) )
//		{
//			Size t_pos = timeGrid.closestIndex( t * ( 1.0/12.0 ) );
//			tGrid_[t] = timeGrid.at(t_pos);
//		}else
//		{
//			tGrid_[t] = timeGrid.back();
//		}
//	}
//
//	for (Size t = 1 ; t < pathSize_ ;++t)
//	{
//		dtGrid_[t] = tGrid_[t] - tGrid_[t-1] ;
//	}
//
//	for (Size t = 1 ; t < pathSize_ ;++t)
//	{
//		alpha_drift = sigma_*sigma_/(2*a_)*(1-std::exp(-2*a_*t));
//
//		f = fittingCurve_->forwardRate(tGrid_[t], tGrid_[t], Continuous, NoFrequency);
//		fup = fittingCurve_->forwardRate(tGrid_[t]+shift, tGrid_[t]+shift, Continuous, NoFrequency);
//		f_prime_t = (fup-f)/shift;
//		alpha_drift += a_*f+f_prime_t;
//
//		// ft(0,t) + aF(0,t) + (sigma^2 / 2*sigma) * ( 1 - exp(-2at) )
//		thetaGrid_[t] = f_prime_t + a_*f + alpha_drift;
//	}
//
//	// s_up
//	for (Size t = 1 ; t < pathSize_ ;++t)
//	{
//		alpha_drift = sigma_*sigma_/(2*a_)*(1-std::exp(-2*a_*t));
//
//		f = fittingCurve_->forwardRate(tGrid_[t], tGrid_[t], Continuous, NoFrequency);
//		fup = fittingCurve_->forwardRate(tGrid_[t]+shift, tGrid_[t]+shift, Continuous, NoFrequency);
//		f_prime_t = (fup-f)/shift;
//		alpha_drift += a_*f+f_prime_t;
//
//		// ft(0,t) + aF(0,t) + (sigma^2 / 2*sigma) * ( 1 - exp(-2at) )
//		thetaGrid_s_up_[t] = f_prime_t + a_*f + alpha_drift;
//	}
//
//	// s_down
//	for (Size t = 1 ; t < pathSize_ ;++t)
//	{
//		alpha_drift = sigma_*sigma_/(2*a_)*(1-std::exp(-2*a_*t));
//
//		f = fittingCurve_->forwardRate(tGrid_[t], tGrid_[t], Continuous, NoFrequency);
//		fup = fittingCurve_->forwardRate(tGrid_[t]+shift, tGrid_[t]+shift, Continuous, NoFrequency);
//		f_prime_t = (fup-f)/shift;
//		alpha_drift += a_*f+f_prime_t;
//
//		// ft(0,t) + aF(0,t) + (sigma^2 / 2*sigma) * ( 1 - exp(-2at) )
//		thetaGrid_s_down_[t] = f_prime_t + a_*f + alpha_drift;
//	}
//
//	// vol_up
//	for (Size t = 1 ; t < pathSize_ ;++t)
//	{
//		alpha_drift = (sigma_ + sigma_perturbation_)*(sigma_+sigma_perturbation_)/(2*a_)*(1-std::exp(-2*a_*t));
//		
//		f = fittingCurve_->forwardRate(tGrid_[t], tGrid_[t], Continuous, NoFrequency);
//		fup = fittingCurve_->forwardRate(tGrid_[t]+shift, tGrid_[t]+shift, Continuous, NoFrequency);
//		f_prime_t = (fup-f)/shift;
//		alpha_drift += a_*f+f_prime_t;
//
//		// ft(0,t) + aF(0,t) + (sigma^2 / 2*sigma) * ( 1 - exp(-2at) )
//		thetaGrid_sigma_up_[t] = f_prime_t + a_*f + alpha_drift;
//	}
//
//	// vol_down
//	for (Size t = 1 ; t < pathSize_ ;++t)
//	{
//		alpha_drift = ( sigma_ - sigma_perturbation_ ) * ( sigma_ - sigma_perturbation_)/(2*a_)*(1-std::exp(-2*a_*t));
//		
//		f = fittingCurve_->forwardRate(tGrid_[t], tGrid_[t], Continuous, NoFrequency);
//		fup = fittingCurve_->forwardRate(tGrid_[t]+shift, tGrid_[t]+shift, Continuous, NoFrequency);
//		f_prime_t = (fup-f)/shift;
//		alpha_drift += a_*f+f_prime_t;
//
//		// ft(0,t) + aF(0,t) + (sigma^2 / 2*sigma) * ( 1 - exp(-2at) )
//		thetaGrid_sigma_down_[t] = f_prime_t + a_*f + alpha_drift;
//	}
//}

Real HullWhiteProcess1DWrapper::periodToTime(Period p)
{
	Integer len = p.length();
	TimeUnit tu = p.units();

	if ( tu == Months )
	{
		return static_cast<Real>(len) / 12.0;
	}
	else if ( tu == Years )
	{
		return static_cast<Real>(len) ;
	}
	else
	{
		return 0.0;
	}
}

Real HullWhiteProcess1DWrapper::CMSRate::operator()(Real x) const
{
	const Size paraCMSB_Num = this->A_t_T_.size();

	//std::cout << this->A_t_T_[0] << std::endl; 5.5
	//std::cout << this->B_t_T_[0] << std::endl;
	//std::cout << x << std::endl;
	//std::cout << std::exp(-this->B_t_T_[0]*x) << std::endl; 0.98

	Real PtT = this->A_t_T_[0]*std::exp(-this->B_t_T_[0]*x);

	Real PtTsum = PtT;

	for(Size j=1;j<paraCMSB_Num;++j)
	{
		PtTsum += this->A_t_T_[j]*std::exp(-this->B_t_T_[j]*x); ;
	}
	
	Real pt_pT = 1.0 - PtT;

	return ( pt_pT / ( this->swapTenor_ * PtTsum ) ) - initialX_;
}

Real HullWhiteProcess1DWrapper::indexAdjustment(Real r_t,Size t_convPos)
{
	// converting this tenor;

	Real adjust = 0.0;
	//Real time_t = 1개월 단위?;
	//Real time_t = 1/12;
	Real time_t = tGrid_[this->converting_tPos_[t_convPos]];

	Real T = this->periodToTime(this->tenor_) ;

	if ( this->rateType_== "CMT" )
	{


		Real P_t_T = this->A_t_T_[t_convPos][0] * std::exp( -B_ti_T_[t_convPos][0] * r_t );

		adjust = std::pow( (1 / P_t_T ) , ( 1 / T ) ) - 1;
	} 
	else if ( this->rateType_== "CMS" || this->rateType_== "SWAP")
	{
		// ex) P(time_t,10Y + time_t) , P(time_t + 0.5,10Y + time_t) 구함
		Real P_ti_T_sum = 0.0;

		//std::cout << this->A_t_T_[t_convPos][0] << std::endl;
		//std::cout << this->B_ti_T_[t_convPos][0] << std::endl;
		//std::cout << r_t << std::endl;
		//std::cout << std::exp(-this->B_ti_T_[t_convPos][0]*r_t) << std::endl;

		Real P_t0_T_ = A_t_T_[t_convPos][0] * std::exp( -B_ti_T_[t_convPos][0] * r_t );

		P_ti_T_sum += P_t0_T_;

		for ( Size i=1 ; i< this->legTenorNum_ ; i++ )
		{
			P_ti_T_sum += A_t_T_[t_convPos][i] * std::exp( -B_ti_T_[t_convPos][i] * r_t );
		}

		Real pt_pT = 1.0 - P_t0_T_;
		
		adjust = pt_pT / ( this->legFraction_ * P_ti_T_sum );
		
	}
	//P(ti,T+ti)를 구함
	else
	{
		//Real B_t_T = ( 1 / this->a_ ) * ( 1 - std::exp( - this->a_ * ( T ) ) );
		//
		//Real Pm_0_t = this->fittingCurve_->discount(time_t);
		//Real Pm_0_T = this->fittingCurve_->discount(T + time_t);
		//Real fm_0_t = this->fittingCurve_->forwardRate(time_t,time_t+T,Compounded);

		//Real A_t_T = ( Pm_0_T / Pm_0_t ) * 
		//	std::exp( 
		//	B_t_T * fm_0_t - ( ( this->sigma_ * this->sigma_ ) / ( 4*this->a_ ) ) * (1 - std::exp( -2 * this->a_ * time_t ) ) * B_t_T * B_t_T 
		//	);
	
		//Real P_t_T = A_t_T * std::exp( -B_t_T * r_t );

		//adjust = std::pow( (1 / P_t_T ) , ( 1 / T ) ) - 1;

		adjust = r_t;
	}

	return adjust;
}

//Real HullWhiteProcess1DWrapper::indexAdjustment(Real r_t,Size tPos)
//{
//	// converting this tenor;
//
//	Real adjust = 0.0;
//	//Real time_t = 1개월 단위?;
//	//Real time_t = 1/12;
//	Real time_t = tGrid_[tPos];
//
//	Real T = this->periodToTime(this->tenor_) ;
//
//	//Real T = this->tenor_.frequency() / 365;
//
//	//B(t,T) = ( 1 / this->a_ ) * ( 1 - std::exp( this->a_ * ( T - t ) ) );
//
//	//A(t,T) = ( Pm(0,T) / Pm(0,t) ) * 
//	//	std::exp( 
//	//	B(t,T) * fm(0,t) - ( this->sigma_ / ( 4*this->a_ ) ) * (1 - std::exp( 2 * this->a_ * t ) ) * B(t,T) * B(t,T) );
//	//
//	//P(t,T) = A(t,T) * std::exp( -B(t,T) * r_t );
//
//	if ( this->rateType_== "CMT" )
//	{
//		//
//	} 
//	else if ( this->rateType_== "CMS" || this->rateType_== "SWAP")
//	{
//		//10 년
//		
//		//Real tenorFraction = this->periodToTime(this->tenor_);
//		Real legFraction = this->periodToTime(this->legTenor_);
//		
//		Size legTenorNum = static_cast<Size>( T / legFraction );
//
//		std::vector<Real> P_ti_T = std::vector<Real>(legTenorNum,0.0);
//
//		std::vector<Real> Pm_0_ti = std::vector<Real>(legTenorNum);
//		std::vector<Real> fm_0_ti = std::vector<Real>(legTenorNum);
//
//		//Real Pm_0_T = this->fittingCurve_->discount(T + time_t);
//
//		//Real fm_0_t = this->fittingCurve_->forwardRate(time_t,time_t+legFraction,Compounded);
//
//		//// setting
//		//for ( Size i=0 ; i< legTenorNum ; i++ )
//		//{
//		//	time_t = legFraction * i ;
//		//}
//
//		Real leg_ti =0.0;
//
//		// ex) P(time_t,10Y + time_t) , P(time_t + 0.5,10Y + time_t) 구함
//		for ( Size i=0 ; i< legTenorNum ; i++ )
//		{
//			leg_ti = legFraction * i ;
//
//			Real ti = time_t + leg_ti ; 
//			Real Pm_0_T = this->fittingCurve_->discount( T + time_t );
//
//			Pm_0_ti[i] = this->fittingCurve_->discount(ti);
//			fm_0_ti[i] = this->fittingCurve_->forwardRate(ti,ti + legFraction,Compounded);
//
//			Real B_ti_T = ( 1.0 / this->a_ ) * ( 1 - std::exp( - this->a_ * ( T - leg_ti ) ) );
//
//			Real A_t_T = ( Pm_0_T / Pm_0_ti[i] ) * 
//				std::exp( 
//				B_ti_T * fm_0_ti[i] - ( ( this->sigma_ * this->sigma_ ) / ( 4*this->a_ ) ) * (1 - std::exp( -2 * this->a_ * time_t ) ) * B_ti_T * B_ti_T 
//				);
//	
//			P_ti_T[i] = A_t_T * std::exp( -B_ti_T * r_t );
//		}
//
//		Real pt_pT = 1.0 - P_ti_T[0];
//		Real P_ti_T_sum = 0.0;
//
//		for ( Size i=0 ; i< legTenorNum ; i++ )
//		{
//			P_ti_T_sum += legFraction * P_ti_T[i];
//			// forward swap rate 구하기
//		}
//
//		adjust = pt_pT / P_ti_T_sum ;
//		
//	}
//	//P(ti,T+ti)를 구함
//	else
//	{
//		Real B_t_T = ( 1 / this->a_ ) * ( 1 - std::exp( - this->a_ * ( T ) ) );
//		
//		Real Pm_0_t = this->fittingCurve_->discount(time_t);
//		Real Pm_0_T = this->fittingCurve_->discount(T + time_t);
//		Real fm_0_t = this->fittingCurve_->forwardRate(time_t,time_t+T,Compounded);
//
//		Real A_t_T = ( Pm_0_T / Pm_0_t ) * 
//			std::exp( 
//			B_t_T * fm_0_t - ( ( this->sigma_ * this->sigma_ ) / ( 4*this->a_ ) ) * (1 - std::exp( -2 * this->a_ * time_t ) ) * B_t_T * B_t_T 
//			);
//	
//		Real P_t_T = A_t_T * std::exp( -B_t_T * r_t );
//
//		adjust = std::pow( (1 / P_t_T ) , ( 1 / T ) ) - 1;
//	}
//
//	return adjust;
//}

Real HullWhiteProcess1DWrapper::volatility() const
{
	return this->sigma_;
}

}