#ifndef quantlib_testClass_ELS_ELSGeneralPricer_hpp
#define quantlib_testClass_ELS_ELSGeneralPricer_hpp

#include <ql/processes/stochasticprocessarray.hpp>
#include <ql/math/matrix.hpp>
#include <ql/math/statistics/statistics.hpp>
#include <ql/math/matrixutilities/choleskydecomposition.hpp>
#include <ql/testClass/ELSStepDown.hpp>
#include <ql/math/randomnumbers/rngtraits.hpp>
#include <ql/testClass/checkKIType.hpp>


namespace QuantLib {

class OptionPayoffPricer {
      public:
		OptionPayoffPricer();
        OptionPayoffPricer(const boost::shared_ptr<StochasticProcessArray>& process,
                           const Array & discounts,
						   const OptionPayoff& optionPayoff
							 );

		Real values(Size simulNum) const;

	  protected:

		boost::shared_ptr<StochasticProcessArray>  process_;
        Array discounts_;
		
    };


}

#endif