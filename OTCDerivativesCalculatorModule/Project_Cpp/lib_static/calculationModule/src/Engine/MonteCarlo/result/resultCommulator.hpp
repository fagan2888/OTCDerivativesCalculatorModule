#ifndef quantlib_ResultCommulator_hpp
#define quantlib_ResultCommulator_hpp

#include <ql/methods/montecarlo/multipath.hpp>
#include <src/Engine/MonteCarlo/stochasticProcess/processArrayWrapper.hpp>
namespace QuantLib 
{
	class ResultCommulator
	{
		public:
			ResultCommulator(Size pathSize);

			void recode(const MultiPath& multiPath);
			void setDate(const MultiPath& multiPath);
			void save(const std::string& name);
			void setBasePrice(const boost::shared_ptr<ProcessArrayWrapper>& processArr);

		private:	
			Size pathSize_;
			std::vector<std::valarray<double>> resultGrid_;
			std::valarray<double> basePrice_;
	};
}

#endif
