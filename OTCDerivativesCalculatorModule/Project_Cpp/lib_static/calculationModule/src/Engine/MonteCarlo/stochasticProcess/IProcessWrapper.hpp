#ifndef quantlib_iprocessWrapper_hpp
#define quantlib_iprocessWrapper_hpp

#include <ql/processes/all.hpp>
#include <random>
#include <ql/methods/montecarlo/multipath.hpp>
#include <ql/timegrid.hpp>
#include <valarray>

namespace QuantLib 
{
	class IProcessWrapper
	{
		public:
			virtual ~IProcessWrapper() {}

			virtual void generatePath(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition) = 0;

			virtual void generatePath_s_up(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition) = 0;
			virtual void generatePath_s_down(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition) = 0;
			virtual void generatePath_sigma_up(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition) = 0;
			virtual void generatePath_sigma_down(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition) = 0;

			virtual void initialize(const TimeGrid& timeGrid) = 0 ;

			virtual Real basePrice() const { return this->basePrice_; }
			virtual Real perturbation_h() const { return this->perturbation_h_; }
			virtual void setBasePrice(Real value) { this->basePrice_ = value; }
			virtual std::string code() const { return this->code_; }
			virtual Real initialValue() const { return this->initialValue_; }
			virtual void setCode(std::string value) { this->code_ = value; }
			virtual Real generatedValueConverting(Real v) { return v; }
			virtual bool isNeedSimul() { return true; }

			virtual Real volatility() const = 0;

		protected:
			Real initialValue_;
			Real perturbation_h_;
			mutable std::string code_;
			mutable Real basePrice_;

	};
}

#endif