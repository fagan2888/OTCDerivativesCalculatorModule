/* -*- mode: c++; tab-width: 4; indent-tabs-mode: nil; c-basic-offset: 4 -*- */

/*
 Copyright (C) 2006 Banca Profilo S.p.A.

 This file is part of QuantLib, a free-software/open-source library
 for financial quantitative analysts and developers - http://quantlib.org/

 QuantLib is free software: you can redistribute it and/or modify it
 under the terms of the QuantLib license.  You should have received a
 copy of the license along with this program; if not, please email
 <quantlib-dev@lists.sf.net>. The license is also available online at
 <http://quantlib.org/license.shtml>.

 This program is distributed in the hope that it will be useful, but WITHOUT
 ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
 FOR A PARTICULAR PURPOSE.  See the license for more details.
*/

/*! \file hullwhiteprocess.hpp
    \brief Hull-White stochastic processes
*/

#ifndef quantlib_hull_white_processes_hpp
#define quantlib_hull_white_processes_hpp

#include <ql/processes/forwardmeasureprocess.hpp>
#include <ql/processes/ornsteinuhlenbeckprocess.hpp>
#include <ql/termstructures/yieldtermstructure.hpp>
#include <ql/math/solvers1d/bisection.hpp>
#include <ql/time/period.hpp>
#include <ql/timegrid.hpp>

namespace QuantLib {

    //! Hull-White stochastic process
    /*! \ingroup processes */
    class HullWhiteProcess: public StochasticProcess1D {
      public:
        HullWhiteProcess(const Handle<YieldTermStructure>& h,
                         Real a,
                         Real sigma);
		HullWhiteProcess(const Handle<YieldTermStructure>& h,
						 Period& tenor,
                         Real a,
                         Real sigma);
        //! \name StochasticProcess1D interface
        //@{
        Real x0() const;
        Real drift(Time t, Real x) const;
        Real diffusion(Time t, Real x) const;
        Real expectation(Time t0, Real x0, Time dt) const;
        Real stdDeviation(Time t0, Real x0, Time dt) const;
        Real variance(Time t0, Real x0, Time dt) const;

        Real a() const;
        Real sigma() const;
        Real alpha(Time t) const;
		Time time(const Date& d) const;
		
		Real forwardRate(Time t) const;

		//저장된 데이터를 초기화함
		void setPreCalculation(const TimeGrid& timeGrid) const;
		void indexAdjustment(std::vector<Array>& path,std::vector<Real>& randz,IndexType type) const;
		//Real evolveSaved(Real x0,Real z,Size i) const;


		Real evolve(Time t0, Real x0, Time dt, Real dw) const;

		Period tenor() const{return tenor_;}
			//@}
    protected:
        boost::shared_ptr<QuantLib::OrnsteinUhlenbeckProcess> process_;
        Handle<YieldTermStructure> h_;
        Real a_, sigma_,swapTenorDt_;
		Period tenor_;
		IndexType indexType_;
		mutable Array multiple_;
		mutable Array paraLnA_;
		
		mutable std::vector<Array> paraA_;
		mutable Array paraCMSB_;
		mutable Real paraCMTB_;

		mutable Real tenorDt_;
		mutable Array savedDrift_;
		mutable Array savedVol_;
		
		friend class CMSRate;

		class CMSRate {
		  
		  friend class HullWhiteProcess;
		  
		  public:
			CMSRate(const HullWhiteProcess* hw,Real initialX)
				:hw_(hw),initialX_(initialX){}
			Real operator()(Real x) const;
			//Real derivative(Real x) const { return 2.0*x; }
		  private:
			const HullWhiteProcess* hw_;
			Real initialX_;
		};

		
		
    };
 
    //! %Forward Hull-White stochastic process
    /*! \ingroup processes */
    class HullWhiteForwardProcess: public ForwardMeasureProcess1D {
      public:
        HullWhiteForwardProcess(const Handle<YieldTermStructure>& h,
                                Real a,
                                Real sigma);
        //! \name StochasticProcess1D interface
        //@{
        Real x0() const;
        Real drift(Time t, Real x) const;
        Real diffusion(Time t, Real x) const;
        Real expectation(Time t0, Real x0, Time dt) const;
        Real stdDeviation(Time t0, Real x0, Time dt) const;
        Real variance(Time t0, Real x0, Time dt) const;
		
		//@}

        Real a() const;
        Real sigma() const;
        Real alpha(Time t) const;
        Real M_T(Real s, Real t, Real T) const;
        Real B(Time t, Time T) const;
		Time time(const Date& d) const;
		

    protected:
        boost::shared_ptr<QuantLib::OrnsteinUhlenbeckProcess> process_;
        Handle<YieldTermStructure> h_;
        Real a_, sigma_;
    };

	

}


#endif
