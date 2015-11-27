#include "qlOperatorFactory.hpp"



using namespace QuantLib;

namespace XmlFactory {

boost::shared_ptr<QuantLib::Operator1D> qlOperatorFactory::operator1D(const boost::shared_ptr<FpmlSerialized::Operator1D>& xml_serial)
{
	boost::shared_ptr<QuantLib::Operator1D> ql_oper;

	std::string oper1DType = xml_serial->getType()->SValue();

	if ( oper1DType == "additionOper1D" )
	{
		const boost::shared_ptr<FpmlSerialized::AdditionOper1D>& xml_additionOper1D
			= xml_serial->getAdditionOper1D();

		ql_oper = this->additionOper1D(xml_additionOper1D);
	}
	else if ( oper1DType == "multipleOper1D" )
	{
		const boost::shared_ptr<FpmlSerialized::MultipleOper1D>& xml_multipleOper1D
			= xml_serial->getMultipleOper1D();

		ql_oper = this->multipleOper1D(xml_multipleOper1D);
	}
	else if ( oper1DType == "maximumOper1D" )
	{
		const boost::shared_ptr<FpmlSerialized::MaximumOper1D>& xml_maximumOper1D
			= xml_serial->getMaximumOper1D();

		ql_oper = this->maximumOper1D(xml_maximumOper1D);
	}

	else
	{
		QL_FAIL("unknown oper1DType : " << oper1DType);
	}

	return ql_oper;
}

boost::shared_ptr<QuantLib::OperatorND> qlOperatorFactory::operatorND(const boost::shared_ptr<FpmlSerialized::OperatorND>& xml_serial)
{
	boost::shared_ptr<QuantLib::OperatorND> ql_oper;

	std::string operNDType = xml_serial->getType()->SValue();

	if ( operNDType == "additionOperND" )
	{
		const boost::shared_ptr<FpmlSerialized::AdditionOperND>& xml_operND
			= xml_serial->getAdditionOperND();

		ql_oper = this->additionOperND(xml_operND);
	}
	else if ( operNDType == "multipleOperND" )
	{
		const boost::shared_ptr<FpmlSerialized::MultipleOperND>& xml_operND
			= xml_serial->getMultipleOperND();

		ql_oper = this->multipleOperND(xml_operND);
	}
	else if ( operNDType == "maximumOperND" )
	{
		const boost::shared_ptr<FpmlSerialized::MaximumOperND>& xml_operND
			= xml_serial->getMaximumOperND();

		ql_oper = this->maximumOperND(xml_operND);
	}
	else if ( operNDType == "divisionOperND" )
	{
		const boost::shared_ptr<FpmlSerialized::DivisionOperND>& xml_operND
			= xml_serial->getDivisionOperND();

		ql_oper = this->divisionOperND(xml_operND);
	}
	else if ( operNDType == "identityOperND" )
	{
		ql_oper = this->identityOperND();
	}
	else
	{
		QL_FAIL("unknown operNDType : " << operNDType);
	}

	return ql_oper;
}



// operator1D
boost::shared_ptr<QuantLib::Operator1D> qlOperatorFactory::additionOper1D(const boost::shared_ptr<FpmlSerialized::AdditionOper1D>& xml_serial)
{
	boost::shared_ptr<QuantLib::Operator1D> ql_oper;

	if ( !xml_serial->isConstValue() )
	{
		Real constValue = xml_serial->getConstValue()->DValue();
		ql_oper = boost::shared_ptr<QuantLib::Operator1D>(new AdditionOperator1D(constValue));
	}
	else if ( !xml_serial->isRefName() )
	{
		const std::string& refName = xml_serial->getRefName()->SValue();
		ql_oper = boost::shared_ptr<QuantLib::Operator1D>(new AdditionOperator1D(refName));
	}else
	{
		QL_FAIL("operator need value");
	}

	return ql_oper;

}

boost::shared_ptr<QuantLib::Operator1D> qlOperatorFactory::multipleOper1D(const boost::shared_ptr<FpmlSerialized::MultipleOper1D>& xml_serial)
{
	boost::shared_ptr<QuantLib::Operator1D> ql_oper;

	if ( !xml_serial->isConstValue() )
	{
		Real constValue = xml_serial->getConstValue()->DValue();
		ql_oper = boost::shared_ptr<QuantLib::Operator1D>(new MultipleOperator1D(constValue));
	}
	else if ( !xml_serial->isRefName() )
	{
		const std::string& refName = xml_serial->getRefName()->SValue();
		ql_oper = boost::shared_ptr<QuantLib::Operator1D>(new MultipleOperator1D(refName));
	}else
	{
		QL_FAIL("operator need value");
	}

	return ql_oper;

}

boost::shared_ptr<QuantLib::Operator1D> qlOperatorFactory::maximumOper1D(const boost::shared_ptr<FpmlSerialized::MaximumOper1D>& xml_serial)
{
	boost::shared_ptr<QuantLib::Operator1D> ql_oper;

	if ( !xml_serial->isConstValue() )
	{
		Real constValue = xml_serial->getConstValue()->DValue();
		ql_oper = boost::shared_ptr<QuantLib::Operator1D>(new MaximumOperator1D(constValue));
	}
	else if ( !xml_serial->isRefName() )
	{
		const std::string& refName = xml_serial->getRefName()->SValue();
		ql_oper = boost::shared_ptr<QuantLib::Operator1D>(new MaximumOperator1D(refName));
	}else
	{
		QL_FAIL("operator need value");
	}

	return ql_oper;

}


// operatorND
boost::shared_ptr<QuantLib::OperatorND> qlOperatorFactory::identityOperND()
{
	boost::shared_ptr<QuantLib::OperatorND> ql_oper;

	ql_oper = boost::shared_ptr<QuantLib::OperatorND>(
						new QuantLib::IdentityOperatorND());

	return ql_oper;
}

boost::shared_ptr<QuantLib::OperatorND> qlOperatorFactory::additionOperND(const boost::shared_ptr<FpmlSerialized::AdditionOperND>& xml_serial)
{
	boost::shared_ptr<QuantLib::OperatorND> ql_oper;

	return ql_oper;
}

boost::shared_ptr<QuantLib::OperatorND> qlOperatorFactory::multipleOperND(const boost::shared_ptr<FpmlSerialized::MultipleOperND>& xml_serial)
{
	boost::shared_ptr<QuantLib::OperatorND> ql_oper;

	return ql_oper;
}

boost::shared_ptr<QuantLib::OperatorND> qlOperatorFactory::maximumOperND(const boost::shared_ptr<FpmlSerialized::MaximumOperND>& xml_serial)
{
	boost::shared_ptr<QuantLib::OperatorND> ql_oper;

	//Weight
	std::vector<Real> ql_weight; 

	for ( Size i=0 ;i<xml_serial->getWeight().size(); i++)
	{
		ql_weight.push_back(xml_serial->getWeight()[i]->DValue());
	}

	ql_oper = boost::shared_ptr<QuantLib::OperatorND>(new MaximumOperatorND(ql_weight));

	return ql_oper;

}

boost::shared_ptr<QuantLib::OperatorND> qlOperatorFactory::divisionOperND(const boost::shared_ptr<FpmlSerialized::DivisionOperND>& xml_serial)
{
	boost::shared_ptr<QuantLib::OperatorND> ql_oper;

	//Weight
	std::vector<Real> ql_weight; 

	for ( Size i=0 ;i<xml_serial->getWeight().size(); i++)
	{
		ql_weight.push_back(xml_serial->getWeight()[i]->DValue());
	}

	ql_oper = boost::shared_ptr<QuantLib::OperatorND>(new DivisionOperatorND(ql_weight));

	return ql_oper;
}

// ------------------------------------------- ConditionOperator -----------------------------------------------------------------------------------------

boost::shared_ptr<QuantLib::ConditionOperator> qlOperatorFactory::conditionOperator(const boost::shared_ptr<FpmlSerialized::ConditionOperator>& xml_serial)
{
	boost::shared_ptr<QuantLib::ConditionOperator> ql_conditionOper;

	return ql_conditionOper;

}


}
