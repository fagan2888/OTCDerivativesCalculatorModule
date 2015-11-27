#ifndef quantlib_system_evolver_OverWrap_hpp
#define quantlib_system_evolver_OverWrap_hpp

#include <ql/methods/finitedifferences/finitedifferencemodel.hpp>
#include <ql/methods/finitedifferences/stepcondition.hpp>
#include <ql/numericalmethod.hpp>
#include <vector>

namespace QuantLib {

    //! Parallel evolver for multiple arrays
    /*! \ingroup findiff */

	// array_type ¿¡¼­ first array ¿¡ ÁË´Ù ¼ø¼­´ë·Î µ¤¾î¾º¿ò.
	
	template <typename array_type>
    class StepOverWrapConditionSet {
        typedef boost::shared_ptr<StepCondition<array_type> > itemType;
		
        std::vector<itemType> stepConditions_;
      public:
        void applyTo(std::valarray<Array>& a, Time t) const {

            for (Size i=0; i < stepConditions_.size(); i++) {
                stepConditions_[i]->applyTo(a, t);
            }
        }
        void push_back(const itemType& a) {
            stepConditions_.push_back(a);
        }
    };

	template <typename traits>
    class ParallelEvolverOverWrapTraits {
      public:
        typedef std::vector<typename traits::array_type> array_type;
        typedef std::vector<typename traits::operator_type> operator_type;
        typedef std::vector<typename traits::bc_type> bc_type;
        typedef BoundaryConditionSet<typename traits::bc_set> bc_set;
        typedef StepOverWrapConditionSet<typename traits::array_type> condition_type;
    };

    template <class Evolver>
    class ParallelEvolverOverWrap  {
      public:
        // typedefs
        typedef ParallelEvolverOverWrapTraits<typename Evolver::traits> traits;
        typedef typename traits::operator_type operator_types;
        typedef typename traits::array_type array_type;
        typedef typename traits::bc_set bc_set;
		typedef std::vector<ContingentEvent> OverWrap_setters_type;

		typedef typename Evolver::traits::operator_type operator_type;
		typedef typename Evolver::traits::bc_type bc_type;
		typedef typename Evolver::traits::OverWrap_setter_type OverWrap_setter;

        // constructors
        ParallelEvolverOverWrap(const operator_types& L,
						       const bc_set& bcs) 
		{
            evolvers_.reserve(L.size());
            for (Size i=0; i < L.size(); i++) {
                evolvers_.push_back(boost::shared_ptr<Evolver>(new
                    Evolver(L[i], bcs[i])));
            }
        }
        void step(array_type& a,Time t) 
		{
            for (Size i=0; i < evolvers_.size(); i++) {
                evolvers_[i]->step(a[i], t);
            }
        }

        void setStep(Time dt) 
		{
            for (Size i=0; i < evolvers_.size(); i++) {
                evolvers_[i]->setStep(dt);
            }
        }

		void addEvolver(const operator_type& L,
						const bc_type& bct,
						const OverWrap_setter_type& OverWrap_setter)
		{
            evolvers_.push_back(boost::shared_ptr<Evolver>(new
						 Evolver(L, bct)));
			OverWrap_.push_back(OverWrap_setter);
		}

		void removeEvolver(const std::string& eventSymbol)
		{
			
		}

      private:
        std::vector<boost::shared_ptr<Evolver> > evolvers_;
		OverWrap_setters_type OverWrap_;
    };

}


#endif
