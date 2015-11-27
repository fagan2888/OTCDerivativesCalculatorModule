#include "stdafx.h"
#include <string>


#define DllExport __declspec(dllexport) 

extern "C" DllExport void __stdcall stepDownELSFactory(const char* instInfo,
														const char* paraInfo,
														char* result,
														unsigned int resultStrLen);

extern "C" DllExport double __stdcall testFunction(double input);

extern "C" DllExport void __stdcall HazardRateCurveFactory(const char* instInfo,
															const char* paraInfo,
															char* result,
															unsigned int resultStrLen);

extern "C" DllExport void __stdcall calculationModule(const char* typeStr,
													  const char* instInfo,
													  const char* paraInfo,
													  char* result,
													  unsigned int resultStrLen);