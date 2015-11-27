#include "PathGeneratorFactory.hpp"
#include <iostream>

namespace QuantLib {

PathGeneratorFactory::PathGeneratorFactory(const boost::shared_ptr<StochasticProcessArray>& processes,
										   const TimeGrid& timeGrid)
: processes_(processes), grid_(timeGrid)
{
	unsigned long myseed = static_cast<unsigned long>(1);
	rand_ = std::tr1::mt19937(myseed);

	this->numAssets_ = processes->size();
	this->pathSize_ = timeGrid.size();

	PseudoRandom::rsg_type gen =
		PseudoRandom::make_sequence_generator(numAssets_*(timeGrid.size()-1),1);

	gen_ = boost::shared_ptr<MultiVariate<PseudoRandom>::path_generator_type>(new MultiVariate<PseudoRandom>::path_generator_type(processes,
                                timeGrid, gen, false));
				
	this->next_ = MultiPath(numAssets_,this->grid_);

	S0_ = std::valarray<double>(numAssets_);
	randArrs_ = std::valarray<double>(numAssets_);

	//this->testRandom_ = Array(numAssets_ * pathSize_);
	previousRand_ = Matrix(numAssets_, pathSize_);

	Matrix corr = processes->correlation();
	chol_=CholeskyDecomposition(corr);

	random_ = MultiPath(numAssets_,timeGrid);

	// num - 1
	this->muGrid_ = Matrix(numAssets_, timeGrid.size() - 1);
	this->volGrid_ = Matrix(numAssets_,timeGrid.size() - 1);

	antitheticFlag_ = false;

	for (Size asset = 0 ; asset<numAssets_ ;++asset)
	{
		//초기화 수익률 or 절대값
		S0_[asset] = processes->process(asset)->x0() / processes->process(asset)->basePrice();

		for (Size t = 0 ; t < pathSize_ - 1 ;++t)
		{
			double mu_t = processes->process(asset)->drift(timeGrid[t],1.0);
			double sigma_t = processes->process(asset)->diffusion(timeGrid[t],1.0);
			double dt_t = timeGrid.dt(t);

			// exp( ( mu[t] - 0.5 * vol[t] * vol[t] ) * dt[t] )
			muGrid_[asset][t] = std::exp( ( mu_t - 0.5 * sigma_t * sigma_t ) * dt_t );

			//  vol[t] * sqrt(dt[t]) 
			volGrid_[asset][t] = sigma_t * std::sqrt(dt_t);
		}

	}
}

const MultiPath& PathGeneratorFactory::next(bool antithetic) 
{ 
	if ( antithetic == false )
		return this->myNext();
	else
		return this->myNextAntithetic();
}

const MultiPath& PathGeneratorFactory::myNext() 
{
	for (Size asset = 0 ; asset<numAssets_ ;++asset)
	{	
		//
		//next_[asset][0] = S0_[asset];
		next_[asset][0] = S0_[asset];
	}

	for (Size t = 1 ; t < pathSize_ ;++t)
	{
		for (Size asset = 0 ; asset<numAssets_ ;++asset)
		{	
			randArrs_[asset] = dist_(rand_);
			previousRand_[asset][t] = randArrs_[asset];
			//std::cout << "randArrs_ " << randArrs_[asset] << std::endl;
		}

		for(Size assetRow=1;assetRow<numAssets_;++assetRow)
		{
			double rand = 0.0;
			for(Size assetCol=0;assetCol<assetRow+1;++assetCol)
			{
				//std::cout << " assetRow : " << assetRow << " assetCol : " << assetCol << " corr : " << chol_[assetRow][assetCol];
				rand += randArrs_[assetCol]*chol_[assetRow][assetCol];
			}
			randArrs_[assetRow] =  rand;
			//std::cout << std::endl;;
		}

		for ( Size asset = 0 ; asset<numAssets_ ;++asset )
		{
			//std::cout << std::exp( volGrid_[asset][t-1] * randArrs_[asset]) << std::endl;
			
			// St_n = St_n-1 * exp ( ... )
			next_[asset][t] = next_[asset][t-1] * muGrid_[asset][t-1] * std::exp( volGrid_[asset][t-1] * randArrs_[asset]);

			//std::cout << next_[asset][t] << std::endl;
		}
	}

	return next_;
				
}

const MultiPath& PathGeneratorFactory::myNextAntithetic() 
{
	for (Size asset = 0 ; asset<numAssets_ ;++asset)
	{	
		next_[asset][0] = S0_[asset];
	}

	for (Size t = 1 ; t < pathSize_ ;++t)
	{
		for (Size asset = 0 ; asset<numAssets_ ;++asset)
		{	
			randArrs_[asset] = -previousRand_[asset][t];
			//std::cout << "randArrs_ " << randArrs_[asset] << std::endl;
		}

		for(Size assetRow=1;assetRow<numAssets_;++assetRow)
		{
			double rand = 0.0;
			for(Size assetCol=0;assetCol<assetRow+1;++assetCol)
			{
				//std::cout << " assetRow : " << assetRow << " assetCol : " << assetCol << " corr : " << chol_[assetRow][assetCol];
				rand += randArrs_[assetCol]*chol_[assetRow][assetCol];
			}
			randArrs_[assetRow] =  rand;
			//std::cout << std::endl;;
		}

		for ( Size asset = 0 ; asset<numAssets_ ;++asset )
		{
			//std::cout << std::exp( volGrid_[asset][t-1] * randArrs_[asset]) << std::endl;
			next_[asset][t] = next_[asset][t-1] * muGrid_[asset][t-1] * std::exp( volGrid_[asset][t-1] * randArrs_[asset]);
			//std::cout << next_[asset][t] << std::endl;
		}
	}

	return next_;
				
}

//void PathGeneratorFactory::makeProcess()
//{
//	//correlated rand를 Gen 
//	for (Size t = 1 ; t < pathSize_ ;++t)
//	{
//		random_[][t]
//	}
//
//	for ( Size i=0 ; i < numAssets_ ; i++)
//	{
//		processes_[i]->calculatePath(this->next_,this->random_);
//	}
//	
//}


//getter
Size PathGeneratorFactory::numAssets() const
{
	return this->numAssets_;
}

Size PathGeneratorFactory::pathSize() const
{
	return this->pathSize_;
}

Size PathGeneratorFactory::getProcessNum(const std::string& code) const
{
	Size choicedAssetNum = 0;

	for ( Size i=0 ; i < this->numAssets_ ; i++ )
	{
		if( this->processes_->process(i)->code() == code )
		{
			return i;
		}
	}

	return 99;

	
}

//const MultiPath& PathGeneratorFactory::myNext() 
//{
//	for (Size asset = 0 ; asset<numAssets_ ;++asset)
//	{	
//		next_[asset][0] = S0_[asset];
//	}
//
//	for (Size t = 1 ; t < pathSize_ ;++t)
//	{
//		for (Size asset = 0 ; asset<numAssets_ ;++asset)
//		{	
//			randArrs_[asset] = dist_(rand_);
//			//std::cout << "randArrs_ " << randArrs_[asset] << std::endl;
//		}
//
//		for(Size assetRow=1;assetRow<numAssets_;++assetRow)
//		{
//			double rand = 0.0;
//			for(Size assetCol=0;assetCol<assetRow+1;++assetCol)
//			{
//				//std::cout << " assetRow : " << assetRow << " assetCol : " << assetCol << " corr : " << chol_[assetRow][assetCol];
//				rand += randArrs_[assetCol]*chol_[assetRow][assetCol];
//			}
//			randArrs_[assetRow] =  rand;
//			//std::cout << std::endl;;
//		}
//
//		for ( Size asset = 0 ; asset<numAssets_ ;++asset )
//		{
//			//std::cout << std::exp( volGrid_[asset][t-1] * randArrs_[asset]) << std::endl;
//			next_[asset][t] = next_[asset][t-1] * muGrid_[asset][t-1] * std::exp( volGrid_[asset][t-1] * randArrs_[asset]);
//			//std::cout << next_[asset][t] << std::endl;
//		}
//	}
//
//	return next_;
//				
//}

}

//std::vector<std::vector<Real>> bridge(Real startTime, Real endTime, Real start , Real end , Size bridgeNum , Size seed )
		//{
		//	Size numberOfAssets = 2;
		//	Size m_=6;
		//	std::valarray<double> bridgePath(numberOfAssets);
		//	std::valarray<double> bridgeRand(numberOfAssets);

		//	Matrix W(2,bridgeNum,0.0);
		//	std::valarray<double> bb(m_,0.0);

		//	Size h,jmax,imin,ii,ll,rr;
		//	Real aa=0.0;  //bridge aa + bb*Z 형태 Drift에 해당.

		//	unsigned long myseed = static_cast<unsigned long>(seed);
		//	std::tr1::mt19937 eng(myseed);
		//	std::tr1::normal_distribution<double> dist;

		//	for(Size i=0;i<m_;++i)
		//	{		
		//		//bb[i]=std::pow(pow(times_[0]/std::pow(2.0,static_cast<double>(i+1)),2.0)/(times_[0]/std::pow(2.0,static_cast<double>(i))),0.5);

		//		bb[i]=std::pow(pow(( endTime - startTime )/std::pow(2.0,static_cast<double>(i+1)),2.0)/((endTime - startTime)/std::pow(2.0,static_cast<double>(i))),0.5);
		//	}

		//		for(Size asset=0;asset<numberOfAssets;++asset)
		//		{
		//			W[asset][0]=start;
		//			W[asset][bridgeNum-1]=end;
		//		}
		//		
		//		h=bridgeNum-1;jmax=1;

		//		for(Size l=0;l<m_;++l){

		//			imin=h/2;ii=imin;
		//			ll=0,rr=h;
		//			for(Size jj=0;jj<jmax;++jj){
		//	
		//				for(Size randCount=0;randCount<numberOfAssets;++randCount){
		//					bridgePath[randCount]=dist(eng);
		//				}

		//				for(Size assetRow=0;assetRow<numberOfAssets;++assetRow){
		//					aa=(W[assetRow][ll]+W[assetRow][rr])/2;
		//					Real randZ=0.0;
		//					
		//					for(Size assetCol=0;assetCol<assetRow+1;++assetCol){
		//						//randZ+=(*(bridgeiter+assetCol))*chol_[assetRow][assetCol];
		//						randZ+=bridgePath[assetCol]*chol_[assetRow][assetCol];
		//						//bridgemyCount = bridgemyCount + 1 ;

		//					}
		//					
		//					W[assetRow][ii]=aa+randZ*bb[j][l] * vol_[assetRow]; //matrix 곱하기 나중에 구현.
		//					bridgeRand[assetRow]=W[assetRow][ii];
		//					
		//				}

		//				ii=ii+h;	ll=ll+h;	rr=rr+h;
		//			
		//			}
		//			jmax=2*jmax;
		//			h=imin;
		//			
		//		
		//	

		//}
		//}