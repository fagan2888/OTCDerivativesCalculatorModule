#ifndef quantlib_processArrayWrapper_hpp
#define quantlib_processArrayWrapper_hpp

#include <src/Engine/MonteCarlo/stochasticProcess/IProcessWrapper.hpp>
#include <src/Engine/MonteCarlo/stochasticProcess/nullProcessModelWrapper.hpp>
#include <ql/math/matrix.hpp>

namespace QuantLib 
{
	class ProcessArrayWrapper : IProcessWrapper
	{
		public:
			// empty process¸¦ À§ÇÔ
			ProcessArrayWrapper();

			ProcessArrayWrapper(const std::vector<boost::shared_ptr<IProcessWrapper>>& processArrWrapper,
								const Matrix& correlation);

			void generatePath(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition = 0);

			void generatePath_s_up(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition = 0);
			void generatePath_s_down(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition = 0);
			void generatePath_sigma_up(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition = 0);
			void generatePath_sigma_down(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition = 0);

			void initialize(const TimeGrid& timeGrid);
			boost::shared_ptr<IProcessWrapper> processWrapper(Size i) const;
			Real volatility() const { return 0.0; }

			Size size();
			
			Matrix correlation();
			bool isNeedSimul();

		private:
			std::vector<boost::shared_ptr<IProcessWrapper>> processArrWrapper_;
			Matrix correlation_;
	};
}

#endif