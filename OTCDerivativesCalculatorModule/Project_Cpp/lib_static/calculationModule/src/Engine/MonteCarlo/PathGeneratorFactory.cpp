#include "PathGeneratorFactory.hpp"
#include <ql/indexes/indexmanager.hpp>
#include <iostream>

namespace QuantLib {

PathGeneratorFactory::PathGeneratorFactory(const boost::shared_ptr<ProcessArrayWrapper>& processArrWrapper,
										   const TimeGrid& timeGrid,
										   const std::vector<Date>& fixingDatesFromToday)
: processArrWrapper_(processArrWrapper), grid_(timeGrid), fixingDatesFromToday_(fixingDatesFromToday)
{
	this->processArrWrapper_->initialize(timeGrid);

	unsigned long myseed = static_cast<unsigned long>(1);
	rand_ = std::tr1::mt19937(myseed);

	this->numAssets_ = processArrWrapper->size();
	this->pathSize_ = timeGrid.size();

	PseudoRandom::rsg_type gen =
		PseudoRandom::make_sequence_generator(numAssets_*(timeGrid.size()-1),1);

	//gen_ = boost::shared_ptr<MultiVariate<PseudoRandom>::path_generator_type>(
	//	new MultiVariate<PseudoRandom>::path_generator_type(processes,timeGrid, gen, false));

	//S0_ = std::valarray<double>(numAssets_);
	//randArrs_ = std::valarray<double>(numAssets_);

	//this->testRandom_ = Array(numAssets_ * pathSize_);
	//reviousRand_ = Matrix(numAssets_, pathSize_);

	Matrix corr = processArrWrapper_->correlation();
	chol_=CholeskyDecomposition(corr);

	random_ = MultiPath(numAssets_,timeGrid);

	this->setPastFixing();

	// num - 1
	
}

void PathGeneratorFactory::setPastFixing()
{
	this->next_ = MultiPath(numAssets_,this->grid_);
	this->greekPath_ = MultiPath(numAssets_,this->grid_);

	Date today = Settings::instance().evaluationDate();
	Date startDate = this->grid_.dateAt(0);

	this->todayPosition_ = this->grid_.dateIndex(today);

	std::vector<std::string> names;

	for ( Size i=0 ; i < this->numAssets_ ; i++ )
	{
		const boost::shared_ptr<IProcessWrapper>& process
			= this->processArrWrapper_->processWrapper(i);

		names.push_back(process->code());
	}

	for ( Size i=0 ; i<this->numAssets_; i++ )
	{
		const boost::shared_ptr<IProcessWrapper>& process
			= this->processArrWrapper_->processWrapper(i);

		if ( process->isNeedSimul() )
		{
			QL_REQUIRE(IndexManager::instance().hasHistory(names[i]),"index doesn't exist! , indexName : " << names[i] );
		
			//Real basePrice = process->basePrice();

			const TimeSeries<Real>& ts = IndexManager::instance().getHistory(names[i]);
			const std::vector<Real>& values = ts.values(startDate,today);
			//const std::vector<Real>& values = ts.values(startDate,startDate+1);

			for ( Size j=0 ; j<this->todayPosition_; j++ )
			{
				//this->next_[i][j] = values[j] / basePrice;
				this->next_[i][j] = process->generatedValueConverting( values[j] );
				this->greekPath_[i][j] = process->generatedValueConverting( values[j] );
			}
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

const MultiPath& PathGeneratorFactory::next_s_up(Size underCount)
{
	const boost::shared_ptr<IProcessWrapper>& process
			= this->processArrWrapper_->processWrapper(underCount);

	process->generatePath_s_up(greekPath_, this->random_, this->todayPosition_,underCount);

	return greekPath_;
}

const MultiPath& PathGeneratorFactory::next_s_down(Size underCount)
{
	const boost::shared_ptr<IProcessWrapper>& process
			= this->processArrWrapper_->processWrapper(underCount);

	process->generatePath_s_down(greekPath_, this->random_, this->todayPosition_,underCount);

	return greekPath_;
}

const MultiPath& PathGeneratorFactory::next_sigma_up(Size underCount)
{
	const boost::shared_ptr<IProcessWrapper>& process
			= this->processArrWrapper_->processWrapper(underCount);

	process->generatePath_sigma_up(greekPath_, this->random_, this->todayPosition_,underCount);

	return greekPath_;
}

const MultiPath& PathGeneratorFactory::next_sigma_down(Size underCount)
{
	const boost::shared_ptr<IProcessWrapper>& process
			= this->processArrWrapper_->processWrapper(underCount);

	process->generatePath_sigma_down(greekPath_, this->random_, this->todayPosition_,underCount);

	return greekPath_;
}

void PathGeneratorFactory::greekPathReset(Size underCount)
{
	for (Size t = this->todayPosition_ ; t < this->pathSize_ ;++t)
	{
		this->greekPath_[underCount][t] = this->next_[underCount][t];
	}
}

const MultiPath& PathGeneratorFactory::myNext() 
{
	//rand를 gen함
	for (Size t = this->todayPosition_ ; t < pathSize_ ;++t)
	{
		for (Size asset = 0 ; asset<numAssets_ ;++asset)
		{	
			random_[asset][t] = dist_(rand_);
			//random_[asset][t] = 0.0;
		}

		for(Size assetRow=1;assetRow<numAssets_;++assetRow)
		{
			double rand = 0.0;
			for(Size assetCol=0;assetCol<assetRow+1;++assetCol)
			{
				//std::cout << " assetRow : " << assetRow << " assetCol : " << assetCol << " corr : " << chol_[assetRow][assetCol];
				//rand += randArrs_[assetCol]*chol_[assetRow][assetCol];
				rand += random_[assetCol][t] * chol_[assetRow][assetCol];
			}
			random_[assetRow][t] =  rand;
			//std::cout << std::endl;;
		}
	}

	this->processArrWrapper_->generatePath(next_,random_,this->todayPosition_);

	for (Size t = this->todayPosition_ ; t < pathSize_ ;++t)
	{
		for (Size asset = 0 ; asset<numAssets_ ;++asset)
		{	
			this->greekPath_[asset][t] = this->next_[asset][t];
		}
	}

	return next_;

}

const MultiPath& PathGeneratorFactory::myNextAntithetic() 
{
	for (Size t = this->todayPosition_ ; t < pathSize_ ;++t)
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

	}

	processArrWrapper_->generatePath(this->next_,this->random_,this->todayPosition_);

	return next_;
				
}

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
	Size processNum = this->processArrWrapper_->size();

	for ( Size i=0 ; i < processNum ; i++ )
	{
		if( this->processArrWrapper_->processWrapper(i)->code() == code )
		{
			return i;
		}
	}

	return 99;
}

Size PathGeneratorFactory::getTodayPosition() const
{
	return this->todayPosition_;
}

//refValue store space
boost::shared_ptr<variableStore> PathGeneratorFactory::getCountTypeReference(const std::string& code)
{
	Size count = countTypeStore_.size();

	boost::shared_ptr<variableStore> ptr;

	for ( Size i=0 ; i<count ; i++ )
	{
		if ( countTypeStore_[i]->name_ == code )
		{
			//ptr = boost::shared_ptr<Real>( &(countTypeStore_[i].value_) );
			ptr = countTypeStore_[i];
		}
	}

	QL_REQUIRE(ptr != 0,"reference doesn't registed" << code);

	return ptr;
}

boost::shared_ptr<variableStore> PathGeneratorFactory::getValueTypeReference(const std::string& code)
{
	Size count = valueTypeStore_.size();

	boost::shared_ptr<variableStore> ptr;

	for ( Size i=0 ; i<count ; i++ )
	{
		if ( valueTypeStore_[i]->name_ == code )
		{
			//ptr = boost::shared_ptr<Real>( &(valueTypeStore_[i].value_) );
			ptr = valueTypeStore_[i];
		}
	}

	QL_REQUIRE(ptr != 0,"reference doesn't registed" << code);

	return ptr;
}

boost::shared_ptr<variableStore> PathGeneratorFactory::getDateTypeReference(const std::string& code)
{
	return boost::shared_ptr<variableStore>();
}

//refValue store space
boost::shared_ptr<variableStore> PathGeneratorFactory::registCountTypeReferenceValue(const std::string& code)
{
	Size count = countTypeStore_.size();

	boost::shared_ptr<variableStore> v = boost::shared_ptr<variableStore>(new variableStore(code,count,0.0));

	countTypeStore_.push_back(v);
	//countTypeStore_[count].value_;

	//const boost::shared_ptr<variableStore>& ptr = countTypeStore_[count];

	return v;
}

boost::shared_ptr<variableStore> PathGeneratorFactory::registValueTypeReferenceValue(const std::string& code)
{
	Size count = valueTypeStore_.size();

	//variableStore v(code,count,0.0);
	boost::shared_ptr<variableStore> v = boost::shared_ptr<variableStore>(new variableStore(code,count,0.0));

	valueTypeStore_.push_back(v);
	//valueTypeStore_[count].value_;

	//const boost::shared_ptr<variableStore>& ptr = valueTypeStore_[count];

	//const boost::shared_ptr<Real>& ptr 
	//	= boost::shared_ptr<Real>( &(valueTypeStore_[count]->value_) );

	return v;
}

boost::shared_ptr<variableStore> PathGeneratorFactory::registDateTypeReferenceValue(const std::string& code)
{
	return boost::shared_ptr<variableStore>();
}


Date PathGeneratorFactory::getFixingDate(Size position)
{
	return this->fixingDatesFromToday_[position];
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