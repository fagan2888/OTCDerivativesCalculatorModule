#ifndef quantlib_fdm_payoff_function_hpp
#define quantlib_fdm_payoff_function_hpp


namespace QuantLib {

	class FdmPayoffFunction {
		
		~FdmPayoffFunction(){}
		Real calculate(const std::valarray<Real> values ) = 0;
		

	};

}


#endif