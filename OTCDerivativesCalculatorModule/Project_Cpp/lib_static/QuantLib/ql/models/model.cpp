/* -*- mode: c++; tab-width: 4; indent-tabs-mode: nil; c-basic-offset: 4 -*- */

/*
 Copyright (C) 2001, 2002, 2003 Sadruddin Rejeb

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

#include <ql/models/model.hpp>
#include <ql/math/optimization/problem.hpp>

namespace QuantLib {

    namespace {
        void no_deletion(CalibratedModel*) {}
    }

    CalibratedModel::CalibratedModel(Size nArguments)
    : arguments_(nArguments),
      constraint_(new PrivateConstraint(arguments_)),
      shortRateEndCriteria_(EndCriteria::None) {}

    class CalibratedModel::CalibrationFunction : public CostFunction {
      public:
        CalibrationFunction(
                  CalibratedModel* model,
                  const std::vector<boost::shared_ptr<CalibrationHelper> >&
                                                                  instruments,
                  const std::vector<Real>& weights)
        : model_(model, no_deletion), instruments_(instruments),
          weights_(weights) {}

        virtual ~CalibrationFunction() {}

        virtual Real value(const Array& params) const {
            model_->setParams(params);

            Real value = 0.0;
            for (Size i=0; i<instruments_.size(); i++) {
                Real diff = instruments_[i]->calibrationError();
                value += diff*diff*weights_[i];
            }

            return std::sqrt(value);
        }

        virtual Disposable<Array> values(const Array& params) const {
            model_->setParams(params);

            Array values(instruments_.size());
            for (Size i=0; i<instruments_.size(); i++) {
                values[i] = instruments_[i]->calibrationError()
                           *std::sqrt(weights_[i]);
            }

            return values;
        }

        virtual Real finiteDifferenceEpsilon() const { return 1e-6; }
      private:
        boost::shared_ptr<CalibratedModel> model_;
        const std::vector<boost::shared_ptr<CalibrationHelper> >& instruments_;
        std::vector<Real> weights_;
    };

    void CalibratedModel::calibrate(
        const std::vector<boost::shared_ptr<CalibrationHelper> >& instruments,
        OptimizationMethod& method,
        const EndCriteria& endCriteria,
        const Constraint& additionalConstraint,
        const std::vector<Real>& weights) {

        QL_REQUIRE(weights.empty() ||
                   weights.size() == instruments.size(),
                   "mismatch between number of instruments and weights");

        Constraint c;
        if (additionalConstraint.empty())
            c = *constraint_;
        else
            c = CompositeConstraint(*constraint_,additionalConstraint);
        std::vector<Real> w = weights.empty() ?
                              std::vector<Real>(instruments.size(), 1.0):
                              weights;
        CalibrationFunction f(this, instruments, w);

        Problem prob(f, c, params());
        shortRateEndCriteria_ = method.minimize(prob, endCriteria);
        Array result(prob.currentValue());
        setParams(result);
        Array shortRateProblemValues_ = prob.values(result);

        notifyObservers();
    }

    EndCriteria::Type CalibratedModel::endCriteria() {
        return shortRateEndCriteria_;
    }

    Real CalibratedModel::value(const Array& params,
       const std::vector<boost::shared_ptr<CalibrationHelper> >& instruments) {
        std::vector<Real> w = std::vector<Real>(instruments.size(), 1.0);
        CalibrationFunction f(this, instruments, w);
        return f.value(params);
    }

    Disposable<Array> CalibratedModel::params() const {
        Size size = 0, i;
        for (i=0; i<arguments_.size(); i++)
            size += arguments_[i].size();
        Array params(size);
        Size k = 0;
        for (i=0; i<arguments_.size(); i++) {
            for (Size j=0; j<arguments_[i].size(); j++, k++) {
                params[k] = arguments_[i].params()[j];
            }
        }
        return params;
    }

    void CalibratedModel::setParams(const Array& params) {
        Array::const_iterator p = params.begin();
        for (Size i=0; i<arguments_.size(); ++i) {
            for (Size j=0; j<arguments_[i].size(); ++j, ++p) {
                QL_REQUIRE(p!=params.end(),"parameter array too small");
                arguments_[i].setParam(j, *p);
            }
        }
        QL_REQUIRE(p==params.end(),"parameter array too big!");
        update();
    }

    ShortRateModel::ShortRateModel(Size nArguments)
    : CalibratedModel(nArguments) {}

}
