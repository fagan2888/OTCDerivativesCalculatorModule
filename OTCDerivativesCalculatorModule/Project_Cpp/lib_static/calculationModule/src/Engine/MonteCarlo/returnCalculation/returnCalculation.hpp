#ifndef quantlib_returnCalculation_hpp
#define quantlib_returnCalculation_hpp

#include <ql/timegrid.hpp>
#include <ql/methods/montecarlo/multipath.hpp>
#include <ql/termstructures/yieldtermstructure.hpp>
#include <ql/time/date.hpp>
#include <valarray>
#include <src/Engine/MonteCarlo/PathGeneratorFactory.hpp>
#include <src/Engine/MonteCarlo/referenceCalculation/referenceCalculation.hpp>
#include <src/Engine/MonteCarlo/preCalculation/preCalculation.hpp>
#include <src/Engine/MonteCarlo/postCalculation/postCalculation.hpp>

namespace QuantLib {

	class ReturnCalculation : public IRefVariable
	{
		public:

			virtual ~ReturnCalculation() {}

			ReturnCalculation(const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList);

			void initialize(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			virtual Real calSlice(const std::valarray<Real>& val) = 0;
			virtual Real calSlice(const MultiPath& path,Size position) = 0; 

			virtual std::vector<Date> fixingDates() const = 0;

			void setPreCalculation(const boost::shared_ptr<PreCalculation>& preCal);
			void setPostCalculation(const boost::shared_ptr<PostCalculation>& postCal);
			void setReturnRefVariable(const boost::shared_ptr<VariableInfo>& returnRefVariable );
			void setResetRefVariable(const boost::shared_ptr<VariableInfo>& resetVariableInfo );

			Real calculate(const MultiPath& path,Size endPosition);
			//Real calculateEarlyEx(const MultiPath& path,Size endPosition);


		protected:
			virtual Real calculateImpl(const MultiPath& path,Size endPosition) = 0;

			virtual void initializeImpl(const TimeGrid& timeGrid,
										const boost::shared_ptr<YieldTermStructure>& discountCurve,
										const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory) = 0;

			bool isFixed_;
			std::vector<Date> fixingDates_;
			std::valarray<Size> fixingDatePositions_;

			bool preCalFlag_;
			bool postCalFlag_;
			bool returnRefFlag_;
			bool resetVarFlag_;

			boost::shared_ptr<PreCalculation> preCalculation_;
			boost::shared_ptr<PostCalculation> postCalculation_;

			boost::shared_ptr<VariableInfo> returnRefVariable_;
			boost::shared_ptr<VariableInfo> resetVariableInfo_;
	};

}

#endif