#ifndef calculationModule_contingentcashflow_hpp
#define calculationModule_contingentcashflow_hpp

#include <ql/event.hpp>
#include <ql/settings.hpp>
#include <ql/math/comparison.hpp>
#include <vector>
#include <valarray>

#include <src/Engine/FDM/math/domain.hpp>
#include <src/Engine/FDM/math/payoffFunction.hpp>

namespace QuantLib {
    class ContingentCashFlow {
      public:
		ContingentCashFlow(const Date& payoffDate,
						   const boost::shared_ptr<PayoffFunction>& payoffFunction,
						   const boost::shared_ptr<Domain>& domain,
						   const boost::shared_ptr<ContingentEvent>& contingentEvent,
						   ExerciseType exerciseType); //autoCall 을 여기서 정의함.

        virtual ~ContingentCashFlow() {}

		virtual Date date() const
		{
			return this->date_;
		}
        
		bool hasOccurred(
                    const Date& refDate = Date(),
                    boost::optional<bool> includeRefDate = boost::none) const;

        Real amount(const std::valarray<Real>& values) const
		{
			if(this->domain_(values))
				return payoffFunction->calculate(values);

		}

		Date date_;
		Domain domain_;

    };

    //! Sequence of cash-flows
    typedef std::vector<boost::shared_ptr<ContingentCashFlow> > ContingentLeg;



    template <>
    struct earlier_than<ContingentCashFlow>
            : public std::binary_function<ContingentCashFlow,ContingentCashFlow,bool> {
        bool operator()(const ContingentCashFlow& c1,
                        const ContingentCashFlow& c2) {
            return c1.date() < c2.date();
        }
    };

	

}

#endif
