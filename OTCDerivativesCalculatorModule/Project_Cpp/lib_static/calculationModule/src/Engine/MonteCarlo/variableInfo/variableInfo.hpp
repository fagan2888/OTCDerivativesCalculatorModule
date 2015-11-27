#ifndef quantlib_variableinfo_hpp
#define quantlib_variableinfo_hpp

#include <valarray>
#include <string>
#include <src/Engine/MonteCarlo/PathGeneratorFactory.hpp>
#include <src/Engine/MonteCarlo/fixingInformation.hpp>

namespace QuantLib {

	//µ¤¾î , ´õÇØ , ³ª´²
	class VariableInfo 
	{
		public:
			//VariableInfo(const std::string& usingRefVarName,
			//			 const std::string& refInstanceName,
			//			 //Real initialValue,
			//			 const boost::shared_ptr<FixingInformation>& fixingInfo,
			//			 bool saveFlag);

			VariableInfo(const std::string& usingRefVarName,
						 const std::string& refInstanceName,
						 Real initialValue,
						 bool saveFlag);

			virtual void initialize(const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			virtual Real execute(Real value) = 0;
			
			boost::shared_ptr<variableStore> valueTypeRefPosition_;

			std::string refInstanceName();
			void reset();

		protected:

			std::string usingRefVarName_;
			std::string refInstanceName_;

			//boost::shared_ptr<FixingInformation> fixingInfo_;

			Real initialValue_;
			bool saveFlag_;

			

	};
}

#endif