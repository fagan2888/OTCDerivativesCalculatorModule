#ifndef quantlib_fdm_overwrapEventcondition_hpp
#define quantlib_fdm_overwrapEventcondition_hpp

#include <ql/math/array.hpp>
#include <ql/instruments/payoffs.hpp>

namespace QuantLib {
    
	class OverWrapEventCondition : public StepCondition<Array> {
      public:
		OverWrapCondition(const boost::shared_ptr<FdmMesher>& mesher,
						  const std::vector<boost::shared_ptr<Domain>>& domain,
						  Time t);

        void applyTo(std::valarray<Array>& a , Time t ) const;

		valarray<valarray<Size>> locationIndexes_;
		valarray<Time> locationTimes_;
    };
}

#endif