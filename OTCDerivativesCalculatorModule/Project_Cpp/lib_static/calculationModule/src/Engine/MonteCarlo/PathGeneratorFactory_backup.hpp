#ifndef quantlib_pathgenerator_hpp
#define quantlib_pathgenerator_hpp

#include <ql/methods/montecarlo/multipath.hpp>
#include <ql/methods/montecarlo/mctraits.hpp>
#include <valarray>
#include <random>
#include <ql/math/matrixutilities/choleskydecomposition.hpp>
#include <ql/math/matrix.hpp>
#include <ql/processes/all.hpp>
#include <ql/math/array.hpp>

namespace QuantLib 
{
class PathGeneratorFactory {
	
	public:
		PathGeneratorFactory(const boost::shared_ptr<StochasticProcessArray>& processes,
							const TimeGrid& timeGrid);

		const MultiPath& next(bool antithetic);

		const MultiPath& myNext();
		const MultiPath& myNextAntithetic();

		void bridgeInitialize(Size bridgeNum);

		//void makeProcess(Real rand);

		Size numAssets() const;
		Size pathSize() const;
		Size getProcessNum(const std::string& code) const;

	private:
		Matrix muGrid_;
		Matrix volGrid_;
		Size numAssets_;
		Size pathSize_;

		std::valarray<double> S0_;
		std::valarray<double> randArrs_;

		mutable Matrix previousRand_;

		std::tr1::normal_distribution<double> dist_;
		std::tr1::mt19937 rand_;
		mutable MultiPath next_;
		mutable MultiPath random_;
		mutable bool antitheticFlag_;
		//mutable Array testRandom_;
		TimeGrid grid_;
		boost::shared_ptr<MultiVariate<PseudoRandom>::path_generator_type> gen_;
		boost::shared_ptr<StochasticProcessArray> processes_;
		Matrix chol_;
};

}

#endif


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