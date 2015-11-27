#include "IRefVariable.hpp"

namespace QuantLib {

IRefVariable::IRefVariable(const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: usingVariableInfoList_(usingVariableInfoList) 
{

}

void IRefVariable::setRefVariable(const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	//Size usingRefNum = usingVariableInfoList_.size();
	//Size definedRefNum = definedVarNameList_.size();

	//usedVarFlagList_ = std::vector<bool>(definedRefNum,false);
	//valueTypeRefPosition_ = std::valarray<boost::shared_ptr<variableStore>>(definedRefNum);

	//for ( Size i=0 ; i<usingRefNum ; i++ )
	//{
	//	for ( Size j=0 ; j<definedRefNum ; j++ )
	//	{
	//		if ( usingVariableInfoList_[i].usingRefVarName_ == definedVarNameList_[j] )
	//		{
	//			usedVarFlagList_[j] = true;
	//		}
	//	}
	//}

	//for ( Size i = 0 ; i < usingRefNum ; i++ )
	//{
	//	if ( this->usedVarFlagList_[i] == true )
	//	{
	//		this->valueTypeRefPosition_[i] = pathGenFactory->registValueTypeReferenceValue(usingVariableInfoList_[i].refInstanceName_);
	//	}
	//}

	//return usingRefNum;

	Size usingRefNum = usingVariableInfoList_.size();
	
	usingVariableInfoList_ = std::vector<boost::shared_ptr<VariableInfo>>(usingRefNum);

	for ( Size i=0 ; i<usingRefNum ; i++ )
	{
		usingVariableInfoList_[i]->initialize(pathGenFactory);
	}

}

//ReferenceCalculation::ReferenceCalculation(const std::vector<std::pair<std::string,std::string>>& variablesAndType)
//: variablesAndType_(variablesAndType)
//	if ( variablesAndType_.size() > 0 )
//	{
//		this->referenceVarExistFlag_ = true;
//	}
//
//	this->valueTypeRefVariables_ = std::valarray<std::string>(1);
//	this->valueTypeRefVariables_[0] = minRefVarName;
//
//	this->valueTypeRefPosition_ = std::valarray<Size>(1);
//
//}

}

