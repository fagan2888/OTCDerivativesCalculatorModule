#ifndef xmlFactory_operatorfactory_hpp
#define xmlFactory_operatorfactory_hpp

#include <GenClass/RiskMonitor-0-1/all.hpp>
#include <src/Engine/MonteCarlo/operator/operator1D.hpp>
#include <src/Engine/MonteCarlo/operator/operatorND.hpp>
#include <src/Engine/MonteCarlo/operator/condition/conditionOperator.hpp>
#include <src/Engine/MonteCarlo/operator/all.hpp>

using namespace QuantLib;

namespace XmlFactory {

	class qlOperatorFactory {
		public:
			qlOperatorFactory()
			{
			}

			boost::shared_ptr<QuantLib::Operator1D> operator1D(const boost::shared_ptr<FpmlSerialized::Operator1D>& xml_serial);
			boost::shared_ptr<QuantLib::OperatorND> operatorND(const boost::shared_ptr<FpmlSerialized::OperatorND>& xml_serial);

			// operator1D
			boost::shared_ptr<QuantLib::Operator1D> additionOper1D(const boost::shared_ptr<FpmlSerialized::AdditionOper1D>& xml_serial);
			boost::shared_ptr<QuantLib::Operator1D> multipleOper1D(const boost::shared_ptr<FpmlSerialized::MultipleOper1D>& xml_serial);
			boost::shared_ptr<QuantLib::Operator1D> maximumOper1D(const boost::shared_ptr<FpmlSerialized::MaximumOper1D>& xml_serial);

			// operatorND
			boost::shared_ptr<QuantLib::OperatorND> identityOperND();
			boost::shared_ptr<QuantLib::OperatorND> additionOperND(const boost::shared_ptr<FpmlSerialized::AdditionOperND>& xml_serial);
			boost::shared_ptr<QuantLib::OperatorND> multipleOperND(const boost::shared_ptr<FpmlSerialized::MultipleOperND>& xml_serial);
			boost::shared_ptr<QuantLib::OperatorND> maximumOperND(const boost::shared_ptr<FpmlSerialized::MaximumOperND>& xml_serial);
			boost::shared_ptr<QuantLib::OperatorND> divisionOperND(const boost::shared_ptr<FpmlSerialized::DivisionOperND>& xml_serial);
			

			boost::shared_ptr<QuantLib::ConditionOperator> conditionOperator(const boost::shared_ptr<FpmlSerialized::ConditionOperator>& xml_serial);

	};

}
#endif