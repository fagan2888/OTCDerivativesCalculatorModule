/* -*- mode: c++; tab-width: 4; indent-tabs-mode: nil; c-basic-offset: 4 -*- */

/*
 Copyright (C) 2009 Ferdinando Ametrano

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

/*! \file interpolatedsurvivalprobabilitycurve.hpp
    \brief interpolated survival-probability term structure
*/

#ifndef quantlib_interpolated_survival_probability_curve_hpp
#define quantlib_interpolated_survival_probability_curve_hpp

#include <ql/termstructures/credit/survivalprobabilitystructure.hpp>
#include <ql/termstructures/interpolatedcurve.hpp>
#include <utility>

namespace QuantLib {

    //! DefaultProbabilityTermStructure based on interpolation of survival probabilities
    /*! \ingroup defaultprobabilitytermstructures */
    template <class Interpolator>
    class InterpolatedSurvivalProbabilityCurve
        : public SurvivalProbabilityStructure,
          protected InterpolatedCurve<Interpolator> {
      public:
        InterpolatedSurvivalProbabilityCurve(
            const std::vector<Date>& dates,
            const std::vector<Probability>& probabilities,
            const DayCounter& dayCounter,
            const Calendar& calendar = Calendar(),
            const std::vector<Handle<Quote> >& jumps = std::vector<Handle<Quote> >(),
            const std::vector<Date>& jumpDates = std::vector<Date>(),
            const Interpolator& interpolator = Interpolator());
        //! \name TermStructure interface
        //@{
        Date maxDate() const;
        //@}
        //! \name other inspectors
        //@{
        const std::vector<Time>& times() const;
        const std::vector<Date>& dates() const;
        const std::vector<Real>& data() const;
        const std::vector<Probability>& survivalProbabilities() const;
        std::vector<std::pair<Date, Real> > nodes() const;
        //@}
      protected:
        InterpolatedSurvivalProbabilityCurve(
            const DayCounter&,
            const std::vector<Handle<Quote> >& jumps = std::vector<Handle<Quote> >(),
            const std::vector<Date>& jumpDates = std::vector<Date>(),
            const Interpolator& interpolator = Interpolator());
        InterpolatedSurvivalProbabilityCurve(
            const Date& referenceDate,
            const DayCounter&,
            const std::vector<Handle<Quote> >& jumps = std::vector<Handle<Quote> >(),
            const std::vector<Date>& jumpDates = std::vector<Date>(),
            const Interpolator& interpolator = Interpolator());
        InterpolatedSurvivalProbabilityCurve(
            Natural settlementDays,
            const Calendar&,
            const DayCounter&,
            const std::vector<Handle<Quote> >& jumps = std::vector<Handle<Quote> >(),
            const std::vector<Date>& jumpDates = std::vector<Date>(),
            const Interpolator& interpolator = Interpolator());
        //! \name DefaultProbabilityTermStructure implementation
        //@{
        Probability survivalProbabilityImpl(Time) const;
        Real defaultDensityImpl(Time) const;
        //@}
        mutable std::vector<Date> dates_;
        void initialize();
    };

    // inline definitions

    template <class T>
    inline Date InterpolatedSurvivalProbabilityCurve<T>::maxDate() const {
        return dates_.back();
    }

    template <class T>
    inline const std::vector<Time>&
    InterpolatedSurvivalProbabilityCurve<T>::times() const {
        return this->times_;
    }

    template <class T>
    inline const std::vector<Date>&
    InterpolatedSurvivalProbabilityCurve<T>::dates() const {
        return dates_;
    }

    template <class T>
    inline const std::vector<Real>&
    InterpolatedSurvivalProbabilityCurve<T>::data() const {
        return this->data_;
    }

    template <class T>
    inline const std::vector<Probability>&
    InterpolatedSurvivalProbabilityCurve<T>::survivalProbabilities() const {
        return this->data_;
    }

    template <class T>
    inline std::vector<std::pair<Date,Real> >
    InterpolatedSurvivalProbabilityCurve<T>::nodes() const {
        std::vector<std::pair<Date,Real> > results(dates_.size());
        for (Size i=0; i<dates_.size(); ++i)
            results[i] = std::make_pair(dates_[i],this->data_[i]);
        return results;
    }

    #ifndef __DOXYGEN__

    // template definitions

    template <class T>
    Probability
    InterpolatedSurvivalProbabilityCurve<T>::survivalProbabilityImpl(Time t)
                                                                        const {
        if (t <= this->times_.back())
            return this->interpolation_(t, true);

        // flat hazard rate extrapolation
        Time tMax = this->times_.back();
        Probability sMax = this->data_.back();
        Rate hazardMax = - this->interpolation_.derivative(tMax) / sMax;
        return sMax * std::exp(- hazardMax * (t-tMax));
    }

    template <class T>
    Real
    InterpolatedSurvivalProbabilityCurve<T>::defaultDensityImpl(Time t) const {
        if (t <= this->times_.back())
            return -this->interpolation_.derivative(t, true);

        // flat hazard rate extrapolation
        Time tMax = this->times_.back();
        Probability sMax = this->data_.back();
        Rate hazardMax = - this->interpolation_.derivative(tMax) / sMax;
        return sMax * hazardMax * std::exp(- hazardMax * (t-tMax));
    }

    template <class T>
    InterpolatedSurvivalProbabilityCurve<T>::InterpolatedSurvivalProbabilityCurve(
                                    const DayCounter& dayCounter,
                                    const std::vector<Handle<Quote> >& jumps,
                                    const std::vector<Date>& jumpDates,
                                    const T& interpolator)
    : SurvivalProbabilityStructure(dayCounter, jumps, jumpDates),
      InterpolatedCurve<T>(interpolator) 
	{
	}

    template <class T>
    InterpolatedSurvivalProbabilityCurve<T>::InterpolatedSurvivalProbabilityCurve(
                                    const Date& referenceDate,
                                    const DayCounter& dayCounter,
                                    const std::vector<Handle<Quote> >& jumps,
                                    const std::vector<Date>& jumpDates,
                                    const T& interpolator)
    : SurvivalProbabilityStructure(referenceDate, Calendar(), dayCounter, jumps, jumpDates),
      InterpolatedCurve<T>(interpolator) 
	{
	}

    template <class T>
    InterpolatedSurvivalProbabilityCurve<T>::InterpolatedSurvivalProbabilityCurve(
                                    Natural settlementDays,
                                    const Calendar& calendar,
                                    const DayCounter& dayCounter,
                                    const std::vector<Handle<Quote> >& jumps,
                                    const std::vector<Date>& jumpDates,
                                    const T& interpolator)
    : SurvivalProbabilityStructure(settlementDays, calendar, dayCounter, jumps, jumpDates),
      InterpolatedCurve<T>(interpolator) 
	{
	}

    template <class T>
    InterpolatedSurvivalProbabilityCurve<T>::InterpolatedSurvivalProbabilityCurve(
                                    const std::vector<Date>& dates,
                                    const std::vector<Probability>& probabilities,
                                    const DayCounter& dayCounter,
                                    const Calendar& calendar,
                                    const std::vector<Handle<Quote> >& jumps,
                                    const std::vector<Date>& jumpDates,
                                    const T& interpolator)
    //: SurvivalProbabilityStructure(dates.front(), calendar, dayCounter, jumps, jumpDates), // Tag :: TS_ReferenceDate_Change
	: SurvivalProbabilityStructure(Settings::instance().evaluationDate(), calendar, dayCounter, jumps, jumpDates),
      InterpolatedCurve<T>(std::vector<Time>(), probabilities, interpolator),
      dates_(dates)
    {
        initialize();        
    }

    #endif

	template <class T>
    void InterpolatedSurvivalProbabilityCurve<T>::initialize()
    {
        QL_REQUIRE(dates_.size() >= T::requiredPoints,
                   "not enough input dates given");
        QL_REQUIRE(this->data_.size() == dates_.size(),
                   "dates/data count mismatch");

        
		// 2012-05-25 data_가 하나씩 밀려서 mapping 되어 수정함.
		if((dates_[0]-this->referenceDate())<3){
			this->times_.resize(dates_.size());
			this->times_[0] = 0.0;
			
		}else{
			this->times_.resize(dates_.size()+1);
			//this->times_[0] = 0.0;
			this->data_.insert(data_.begin(),0.0);
			this->dates_.insert(dates_.begin(),this->referenceDate());

		}
        for (Size i=1; i<times_.size(); ++i) {
            QL_REQUIRE(dates_[i] > dates_[i-1],
                       "invalid date (" << dates_[i] << ", vs "
                       << dates_[i-1] << ")");

            this->times_[i] = dayCounter().yearFraction(this->referenceDate(), dates_[i]);

            QL_REQUIRE(!close(this->times_[i], this->times_[i-1]),
                       "two dates correspond to the same time "
                       "under this curve's day count convention");
            QL_REQUIRE(this->data_[i] >= 0.0, "negative hazard rate");
        }

        this->interpolation_ =
            this->interpolator_.interpolate(this->times_.begin(),
                                            this->times_.end(),
                                            this->data_.begin());
        this->interpolation_.update();
    }
}

#endif
