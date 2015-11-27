#ifndef quantlib_fdm_payoff_function_hpp
#define quantlib_fdm_payoff_function_hpp


namespace QuantLib {

	class FdmLinearFunction {
		FdmLinearFunction(Real gearing,
						  Real spread)
		: gearing_(gearing), spread_(spread)
		{
			
		}
		
		Real calculate(Real a , Real b)
		{
			return gearing_ * a + spread_;
		}

		Real calculate(Real a , Real b)
		{
			
		}

	};

}


#endif