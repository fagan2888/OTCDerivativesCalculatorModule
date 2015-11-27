#ifndef quantlib_PostCalculation_hpp
#define quantlib_PostCalculation_hpp

#include <ql/timegrid.hpp>
#include <ql/methods/montecarlo/multipath.hpp>
#include <ql/termstructures/yieldtermstructure.hpp>
#include <ql/time/date.hpp>
#include <valarray>
#include <src/Engine/MonteCarlo/PathGeneratorFactory.hpp>
#include <src/Engine/MonteCarlo/IRefVariable.hpp>
#include <src/Engine/MonteCarlo/operator/operator1D.hpp>

namespace QuantLib {

	class PostCalculation : public IRefVariable
	{
		public:

			PostCalculation(const std::vector<boost::shared_ptr<Operator1D>>& operator1DList,
						    const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList = std::vector<boost::shared_ptr<VariableInfo>>() );

			void initialize(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			Real calculate(Real v);

		protected:
			Size oper1DNum_;
			std::vector<boost::shared_ptr<Operator1D>> operator1DList_;
			
	};

}

#endif