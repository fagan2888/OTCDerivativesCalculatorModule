#ifndef quantlib_multi_path_generatorfixedpath_hpp
#define quantlib_multi_path_generatorfixedpath_hpp

#include <ql/methods/montecarlo/multipath.hpp>
#include <ql/methods/montecarlo/sample.hpp>
#include <ql/stochasticprocess.hpp>

namespace QuantLib {

    //! Generates a multipath from a random number generator.
    /*! RSG is a sample generator which returns a random sequence.
        It must have the minimal interface:
        \code
        RSG {
            Sample<Array> next();
        };
        \endcode

        \ingroup mcarlo

        \test the generated paths are checked against cached results
    */
    template <class GSG>
    class MultiPathGeneratorFixedPath {
      public:
        typedef Sample<MultiPath> sample_type;

        MultiPathGeneratorFixedPath(const boost::shared_ptr<StochasticProcess>&,
                           const TimeGrid&,
                           GSG generator,
                           bool brownianBridge = false);
		MultiPathGeneratorFixedPath();

        void next() const;
		boost::shared_ptr<MultiPath> multiPath() const;
      private:
        boost::shared_ptr<StochasticProcess> process_;
        GSG generator_;
        mutable boost::shared_ptr<MultiPath> next_;
		MultiPath* nextPtr_;
		bool brownianBridge_;
    };


    // template definitions

	template <class GSG>
	MultiPathGeneratorFixedPath<GSG>::MultiPathGeneratorFixedPath()
	{
	
	}

    template <class GSG>
    MultiPathGeneratorFixedPath<GSG>::MultiPathGeneratorFixedPath(
                   const boost::shared_ptr<StochasticProcess>& process,
                   const TimeGrid& times,
                   GSG generator,
                   bool brownianBridge)
    : brownianBridge_(brownianBridge), process_(process),
      generator_(generator), next_(boost::shared_ptr<MultiPath>(new MultiPath(process->size(), times)))
	{
		nextPtr_ = next_.get();

        QL_REQUIRE(generator_.dimension() ==
                   process->factors()*(times.size()-1),
                   "dimension (" << generator_.dimension()
                   << ") is not equal to ("
                   << process->factors() << " * " << times.size()-1
                   << ") the number of factors "
                   << "times the number of time steps");
        QL_REQUIRE(times.size() > 1,
                   "no times given");
    }

	template <class GSG>
    inline boost::shared_ptr<MultiPath> MultiPathGeneratorFixedPath<GSG>::multiPath() const 
	{
		return this->next_;
	}

    template <class GSG>
    inline void MultiPathGeneratorFixedPath<GSG>::next() const 
	{
        typedef typename GSG::sample_type sequence_type;
        const sequence_type& sequence_ = generator_.nextSequence();

        Size m = process_->size();
        Size n = process_->factors();

        MultiPath& path = *nextPtr_;

        Array asset = process_->initialValues();
        
		for (Size j=0; j<m; j++)
            path[j].front() = asset[j];

        Array temp(n);

        TimeGrid timeGrid = path[0].timeGrid();
        Time t, dt;
        
		for (Size i = 1; i < path.pathSize(); i++) {
            Size offset = (i-1)*n;
            t = timeGrid[i-1];
            dt = timeGrid.dt(i-1);
            
			std::copy(sequence_.value.begin()+offset,
                            sequence_.value.begin()+offset+n,
                            temp.begin());

            asset = process_->evolve(t, asset, dt, temp,i-1);

            for (Size j=0; j<m; j++)
                path[j][i] = asset[j];
		}
    }

 //   template <class GSG>
 //   inline const typename MultiPathGeneratorFixedPath<GSG>::sample_type&
 //   MultiPathGeneratorFixedPath<GSG>::antithetic() const 
	//{
	//	QL_FAIL("not impemated antithetic");
 //       return next(true);
 //   }

 //   template <class GSG>
 //   const typename MultiPathGeneratorFixedPath<GSG>::sample_type&
 //   MultiPathGeneratorFixedPath<GSG>::next(bool antithetic) const 
	//{
 //       QL_FAIL("not impemated antithetic");
	//	return next(true);
 //   }

}
#endif
