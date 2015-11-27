/* -*- mode: c++; tab-width: 4; indent-tabs-mode: nil; c-basic-offset: 4 -*- */

/*
 Copyright (C) 2003 Ferdinando Ametrano
 Copyright (C) 2001, 2002, 2003 Sadruddin Rejeb
 Copyright (C) 2004, 2005 StatPro Italia srl

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

#include <ql/processes/geometricbrownianprocess.hpp>
#include <ql/processes/eulerdiscretization.hpp>

namespace QuantLib {

    GeometricBrownianMotionProcess::GeometricBrownianMotionProcess(
                                                          double initialValue,
                                                          double mue,
                                                          double sigma)
    : StochasticProcess1D(boost::shared_ptr<discretization>(
                                                    new EulerDiscretization)),
      initialValue_(initialValue), mue_(mue), sigma_(sigma) {}

    Real GeometricBrownianMotionProcess::x0() const {
        return initialValue_;
    }

    Real GeometricBrownianMotionProcess::drift(Time, Real x) const {
        return mue_ * x;
    }

    Real GeometricBrownianMotionProcess::diffusion(Time, Real x) const {
        return sigma_ * x;
    }
	void GeometricBrownianMotionProcess::setPreCalculation(const TimeGrid& timeGrid) const{
		Size gridNum=timeGrid.size();
		std::vector<Real> timedt(gridNum-1);
		
		for(Size i=0;i<gridNum-1;++i){
			timedt[i]=timeGrid.dt(i);
		}
		timedt_=timedt;
	
	}
	void GeometricBrownianMotionProcess::indexAdjustment(std::vector<Array>& path,std::vector<Real>& randz,IndexType type) const{
	
		std::vector<Real>::const_iterator randSeqIter = randz.begin();
		const Size simul=path.size();
		const Size numberOfTimes=path[0].size();

		QL_REQUIRE(randz.size()+1 > (simul*numberOfTimes),"not enough random variable");

		for(Size k=0;k<simul;++k){
			
			path[k][0]=initialValue_*(1 + mue_*timedt_[0] + sigma_*std::pow(timedt_[0],0.5)*(*randSeqIter));
			randSeqIter++;

			for(Size i=0;i<numberOfTimes-1;++i){
				path[k][i+1]=path[k][i]*(1 + mue_*timedt_[i] + sigma_*std::pow(timedt_[i],0.5)*(*randSeqIter));
				randSeqIter++;
			}
		}
	}
}
