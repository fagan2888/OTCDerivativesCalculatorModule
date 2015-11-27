#ifndef xmlFactory_qlindextransformationFactory_hpp
#define xmlFactory_qlindextransformationFactory_hpp

#include <xmlFactory/util/xmlUtilHeader.hpp>

#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/IndexTran/returnTrans.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/IndexTran/minimumTrans.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/IndexTran/EventIndexTransformation.hpp>

#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/VariableValue/all.hpp>

#include <fpmlserialized/genclass/ahn-product-1-0/EventIndexTransformation.hpp>
#include <fpmlserialized/genclass/ahn-product-1-0/ReturnTran.hpp>
#include <fpmlserialized/genclass/ahn-product-1-0/MinimumTran.hpp>

namespace XmlFactory {

	class qlEventIndexTransformationFactory {
		public:
			qlEventIndexTransformationFactory(){}
			void setSerialClass(const boost::shared_ptr<FpmlSerialized::EventIndexTransformation>& eitf);
			boost::shared_ptr<QuantLib::EventIndexTransformation> getEIT();

		private:
			boost::shared_ptr<QuantLib::VariableValue> getItb(const boost::shared_ptr<FpmlSerialized::IndexCalculation>& ic);
			

			boost::shared_ptr<QuantLib::VariableValue> getReturnTrans(const boost::shared_ptr<FpmlSerialized::ReturnTran>& rt, bool timeFlag);
			boost::shared_ptr<QuantLib::VariableValue> getMinimumTrans(const boost::shared_ptr<FpmlSerialized::MinimumTran>& mt, bool timeFlag);
		private:
			boost::shared_ptr<QuantLib::EventIndexTransformation> eventIndexTransformation_;
			
	};


}

#endif
