#ifndef quantlib_testClass_Pricer_hpp
#define quantlib_testClass_Pricer_hpp

#include <iostream>
#include <ql/types.hpp>
#include <vector>
#include <ql/math/matrixutilities/choleskydecomposition.hpp>

namespace QuantLib {

class Pricer {
    public:
        virtual ~Pricer() {}
		virtual Real values(const std::vector<Real>& rand,Size simul) const=0;
    };

}

#endif