#ifndef calculationModule_hifive_stepDown_hpp
#define calculationModule_hifive_stepDown_hpp

#include <ql/instruments/oneassetoption.hpp>
#include <ql/instruments/barriertype.hpp>
#include <ql/instruments/payoffs.hpp>

namespace QuantLib {

    class GeneralizedBlackScholesProcess;

    //! %Barrier option on a single asset.
    /*! The analytic pricing engine will be used if none if passed.

        \ingroup instruments
    */
    class HifiveStepDown {
      public:
        class arguments;
        class engine;

        HifiveStepDown(const Date& issueDate,
					   const Date& maturityDate,
					   const ContingentLeg& payoffs);

        void setupArguments(PricingEngine::arguments*) const;
        /*! \warning see VanillaOption for notes on implied-volatility
                     calculation.
        */

      protected:
        // arguments
        Real barrier_;
        Real rebate_;
    };

    //! %Arguments for barrier option calculation
    class HifiveStepDown::arguments : public OneAssetOption::arguments {
      public:
        arguments();
        Barrier::Type barrierType;
        Real barrier;
        Real rebate;
        void validate() const;
    };

    //! %Barrier-option %engine base class
    class HifiveStepDown::engine
        : public GenericEngine<HifiveStepDown::arguments,
                               HifiveStepDown::results> {
      protected:
        bool triggered(Real underlying) const;
    };

}

#endif
