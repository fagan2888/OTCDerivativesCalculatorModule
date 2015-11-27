#ifndef quantlib_fdm_step_condition_composite_hpp
#define quantlib_fdm_step_condition_composite_hpp

#include <ql/methods/finitedifferences/contingentstepcondition.hpp>
#include <set>

namespace QuantLib {

    class FdmContingentStepCondition;
    
    class FdmContingentStepConditionComposite : public ContingentStepCondition<Array> {
    public:
        typedef std::list<boost::shared_ptr<ContingentStepCondition<Array> > > Conditions;

        FdmContingentStepConditionComposite(
            const std::list<std::vector<Time> > & stoppingTimes,
            const Conditions & conditions);

		void build(const boost::shared_ptr<FdmMesher>& mesher);

        void applyTo(Array& a, Time t) const;
        const std::vector<Time>& stoppingTimes() const;
        const Conditions& conditions() const;

        static boost::shared_ptr<FdmContingentStepConditionComposite> joinConditions(
                    const boost::shared_ptr<FdmContingentStepCondition>& c1,
                    const boost::shared_ptr<FdmContingentStepConditionComposite>& c2);
        
    private:
        std::vector<Time> stoppingTimes_;
        const Conditions conditions_;
    };
}
#endif
