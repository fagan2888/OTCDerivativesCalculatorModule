/*! \file FdmOSMBlackScholesOp.hpp
*/

#ifndef quantlib_fdm_2d_black_scholes_op_hpp
#define quantlib_fdm_2d_black_scholes_op_hpp

#include <ql/experimental/finitedifferences/ninepointlinearop.hpp>
#include <ql/experimental/finitedifferences/fdmblackscholesop.hpp>
#include <ql/experimental/finitedifferences/fdmlinearopcomposite.hpp>

namespace QuantLib {

    class FdmMesher;
    class GeneralizedBlackScholesProcess;

    class FdmOSMBlackScholesOp : public FdmLinearOpComposite {
      public:
        FdmOSMBlackScholesOp(
            const boost::shared_ptr<FdmMesher>& mesher,
            const boost::shared_ptr<GeneralizedBlackScholesProcess>& p1,
            const boost::shared_ptr<GeneralizedBlackScholesProcess>& p2,
            Real correlation,
            Time maturity,
            bool localVol = false,
            Real illegalLocalVolOverwrite = -Null<Real>());
           
        Size size() const;
        void setTime(Time t1, Time t2);    
        Disposable<Array> apply(const Array& x) const;
        Disposable<Array> apply_mixed(const Array& x) const;
    
        Disposable<Array> apply_direction(Size direction,const Array& x) const;
        
        Disposable<Array> solve_splitting(Size direction,
                                          const Array& x, Real s) const;
        Disposable<Array> preconditioner(const Array& r, Real s) const;
    
      private:
        const boost::shared_ptr<FdmMesher> mesher_;
        const boost::shared_ptr<GeneralizedBlackScholesProcess> p1_, p2_;
        const boost::shared_ptr<LocalVolTermStructure> localVol1_, localVol2_;
        const Array x_, y_;
        
        Real currentForwardRate_;
        FdmBlackScholesOp opX_, opY_;
        NinePointLinearOp corrMapT_;
        const NinePointLinearOp corrMapTemplate_;
        const Real illegalLocalVolOverwrite_;
    };
}
#endif
