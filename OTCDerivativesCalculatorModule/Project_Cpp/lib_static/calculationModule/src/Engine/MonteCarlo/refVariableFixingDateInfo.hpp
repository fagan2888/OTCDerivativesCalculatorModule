#ifndef quantlib_refvariablefixingdateinfo_hpp
#define quantlib_refvariablefixingdateinfo_hpp

#include <src/Engine/MonteCarlo/fixingDateInfo.hpp>

namespace QuantLib {

	class RefVariableFixingDateInfo : public FixingDateInfo
	{
		public:
			RefVariableFixingDateInfo(const std::string& refVarName);

			void initialize(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			Date fixingDate();
			Size fixingDatePosition();
			Real discount();

		private:
			std::string refVarName_;
			boost::shared_ptr<variableStore> datePositionPtr_;
	};
}

#endif