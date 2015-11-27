// StepDownKI_DLL.cpp : DLL 응용 프로그램을 위해 내보낸 함수를 정의합니다.
//

#include "StepDownKI_DLL.hpp"
#include <xmlFactory/Factory/qlTypeFactory.hpp>

using namespace XmlFactory;

//void __stdcall stepDownELSFactory(const char* instInfo,
//								  const char* paraInfo,
//								  char* result,
//								  unsigned int resultStrLen)
//{
//	qlStepDownKIFactory factory = qlStepDownKIFactory(instInfo,paraInfo);
//
//	factory.calculate();
//
//	const char *cstr = factory.result().c_str();
//
//	if( resultStrLen < strlen(cstr)+1 ) {
//		result = NULL;
//		return;
//	}
//
//	sprintf(result, cstr);
//}

double __stdcall testFunction(double input)
{
	return input * 2.0;
}

void __stdcall calculationModule(const char* typeStr,
								  const char* instInfo,
								  const char* paraInfo,
								  char* result,
								  unsigned int resultStrLen)
{
	qlTypeFactory typeFactory = qlTypeFactory();

	boost::shared_ptr<InstrumentFactory> instFactory = typeFactory.getInstFactory(typeStr);

	instFactory->calculate(instInfo,paraInfo);

	const char *cstr = instFactory->result().c_str();

	if( resultStrLen < strlen(cstr)+1 ) {
		result = NULL;
		return;
	}

	sprintf(result, cstr);

}


//void __stdcall HazardRateCurveFactory(const char* instInfo,
//									  const char* paraInfo,
//									  char* result,
//									  unsigned int resultStrLen)
//{
//	qlStepDownELSFactory factory = qlStepDownELSFactory(instInfo,paraInfo);
//
//	factory.calculate();
//
//	const char *cstr = factory.result().c_str();
//
//	if( resultStrLen < strlen(cstr)+1 ) {
//		result = NULL;
//		return;
//	}
//
//	sprintf(result, cstr);
//}