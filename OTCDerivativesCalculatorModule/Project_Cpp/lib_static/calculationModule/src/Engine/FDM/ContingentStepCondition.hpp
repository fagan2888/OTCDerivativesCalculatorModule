#ifndef quantlib_contingent_step_condition_hpp
#define quantlib_contingent_step_condition_hpp

#include <ql/math/array.hpp>
#include <ql/instruments/payoffs.hpp>

namespace QuantLib {

    //! condition to be applied at every time step
    /*! \ingroup findiff */
    class ContingentStepCondition : public StepCondition<Array> {
      public:
        virtual void build(const boost::shared_ptr<FdmMesher>& mesher) const = 0;
    };

}


#endif
