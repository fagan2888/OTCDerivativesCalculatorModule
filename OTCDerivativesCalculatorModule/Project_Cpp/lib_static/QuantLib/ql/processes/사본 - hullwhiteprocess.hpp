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
		void setRefRateDt(Real dt){dt_=dt;};
		Real indexAdjustment(Real x,Size z) const;

		//저장된 데이터를 사용하기 위한 함수
		Real evolve(Time t0, Real x0, Time dt, Real dw) const;
		Real evolve(Time t0, Real x0, Time dt, Real dw,Size z) const;

		//Bond Price
		//void setRefRate(Real x0,Time t, Time dt) const;

		//getData
		const Array& getForwardData() const;
		const Array& getDiscountData() const;
		const Array& getDiscountTData() const;

		//
		Period tenor() const{return tenor_;}
			//@}
    protected:
        boost::shared_ptr<QuantLib::OrnsteinUhlenbeckProcess> process_;
        Handle<YieldTermStructure> h_;
        Real a_, sigma_;
		Period tenor_;
		mutable bool savedDataFlag_;
		mutable Array savedForwardData_;
		mutable Array savedDiscountData_;
		mutable Array savedDiscountDataT_;
		mutable Array refRateData_;
		mutable Array savedTime_;
		mutable Size z_;
		mutable Real dt_;
		
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
