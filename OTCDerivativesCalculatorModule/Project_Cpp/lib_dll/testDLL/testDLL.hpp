#include "stdafx.h"
#include <string>
#include <iostream>

#include <Factory/instrumentFactory.hpp>
#include <xmlFactory/Factory/qlTypeFactory.hpp>

unsigned int resultStrLen = 5000;

#define DllExport __declspec(dllexport) 

extern "C" DllExport void __stdcall testFunction(const char* calculationType,
												const char* instInfo, 
												const char* paraInfo ,
												const char* historyInfo ,
												int dateSerialNumber,
												char* result,
												char* log,
												unsigned int resultStrLen);

extern "C" DllExport void __stdcall calculate(const char* fileName,
											  char* result);

// testDLL.cpp : DLL ���� ���α׷��� ���� ������ �Լ��� �����մϴ�.
//


