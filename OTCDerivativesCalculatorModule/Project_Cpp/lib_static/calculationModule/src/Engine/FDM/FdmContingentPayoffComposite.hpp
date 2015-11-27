#ifndef quantlib_fdm_step_condition_composite_hpp
#define quantlib_fdm_step_condition_composite_hpp

#include <ql/methods/finitedifferences/stepcondition.hpp>
#include <set>

namespace QuantLib {

    class FdmContingentPayoffComposite : public StepCondition<std::valarray<Array>> {
    
	public:
        typedef std::list<boost::shared_ptr<FdmContingentPayoff> > ContigentPayoffs;

        FdmContingentPayoffComposite(const ContigentPayoffs& payoffs);  // 각각을 어떻게 적용할지 정의하는 class

		Size size();

		void build(const boost::shared_ptr<FdmMesher>& mesher);

		void applyTo(std::valarray<Array>& a, Time t) const;

		void payoffCalculate(std::valarray<Array>& payoffs);
		
		boost::shared_ptr<FdmContingentPayoff> getFCP(const std::string& eventName);

        const std::vector<Date>& stoppingDates() const;
        const ContigentPayoffs& payoffs() const;

        //static boost::shared_ptr<FdmContingentPayoffComposite> joinConditions(
        //            const boost::shared_ptr<FdmSnapshotCondition>& c1,
        //            const boost::shared_ptr<FdmContingentPayoffComposite>& c2);
        
    private:
        std::vector<Date> stoppingDates_;
		std::vector<Time> stoppingTimes_;

        const ContigentPayoffs contigentPayoffs_;
    };
}
#endif
