#ifndef quantlib_NullProcessModelWrapper_hpp
#define quantlib_NullProcessModelWrapper_hpp

#include <src/Engine/MonteCarlo/stochasticProcess/IProcessWrapper.hpp>

namespace QuantLib 
{
	// process가 필요없는경우
	class NullProcessModelWrapper : public IProcessWrapper
	{
		public:
			NullProcessModelWrapper();
									//Real r0);				  

			void generatePath(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition);

			void generatePath_s_up(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition = 0);
			void generatePath_s_down(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition = 0);
			void generatePath_sigma_up(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition = 0);
			void generatePath_sigma_down(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition = 0);

			void initialize(const TimeGrid& timeGrid);
			bool isNeedSimul() { return false; }
			Real volatility() const { return 0.0; }

			Real indexAdjustment(Real r);


		private:

			Size pathSize_;

	};
}

#endif