#ifndef quantlib_referenceCalculation_hpp
#define quantlib_referenceCalculation_hpp

#include <ql/timegrid.hpp>
#include <ql/methods/montecarlo/multipath.hpp>
#include <ql/termstructures/yieldtermstructure.hpp>
#include <ql/time/date.hpp>
#include <src/Engine/MonteCarlo/PathGeneratorFactory.hpp>
#include <src/Engine/MonteCarlo/fixingDateInfo.hpp>
#include <src/Engine/MonteCarlo/fixingInformation.hpp>
#include <src/Engine/MonteCarlo/IRefVariable.hpp>
#include <src/Engine/MonteCarlo/postCalculation/postCalculation.hpp>


namespace QuantLib {

	class ReferenceCalculation : public IRefVariable
	{
		public:

			virtual ~ReferenceCalculation() { }

			ReferenceCalculation(const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList);

			virtual void initialize(const TimeGrid& timeGrid,
									const boost::shared_ptr<YieldTermStructure>& discountCurve,
									const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			Real calculate(const MultiPath& path,Size endPosition);
			//Real calculateEarlyEx(const MultiPath& path);

			virtual Real calSlice(const MultiPath& path,Size position) = 0; 

			virtual Real calSlice(const std::valarray<Real>& val) = 0; 

			virtual std::vector<Date> fixingDates() const = 0;

			// setter
			void setFixingInformation(const boost::shared_ptr<FixingInformation>& fixingInfo);
			void setPostCalculation(const boost::shared_ptr<PostCalculation>& postCal);
			void setReferenceRefVariable(const boost::shared_ptr<VariableInfo>& referenceRefVariable );

		protected:
			virtual Real calculateImpl(const MultiPath& path,Size endPosition) = 0;
			//virtual Real calculateImplEarlyEx(const MultiPath& path);

			virtual void initializeImpl(const TimeGrid& timeGrid,
										const boost::shared_ptr<YieldTermStructure>& discountCurve,
										const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory) = 0;

			void initializeSelectedUnder();

			//virtual void pastFixingInitialize(const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory) = 0;
			virtual void pastFixingInitialize(const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory) {}

			bool preFixedFlag_;
			Real preFixingValue_;

			boost::shared_ptr<FixingDateInfo> fixingDateInfo_;
			boost::shared_ptr<FixingInformation> fixingInfo_;

			std::valarray<Size> fixingDatePositions_;
			

			bool postCalFlag_;
			bool referenceRefFlag_;

			boost::shared_ptr<PostCalculation> postCalculation_;
			boost::shared_ptr<VariableInfo> referenceRefVariable_;

	};

}

#endif