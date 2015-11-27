// stepdownexe.cpp : �ܼ� ���� ���α׷��� ���� �������� �����մϴ�.
//

#include <xmlFactory/Factory\ELS\StepDown\qlStepDownELSFactory.hpp>

#include "stdafx.h"
#include <iostream>

using namespace XmlFactory;

//int _tmain(int argc, _TCHAR* argv[])
int _tmain(int argc, char* argv[])
{
	//check argument ����
	if ( argc != 3)
	{
		std::cout << "need 3 file";
	}

	qlStepDownELSFactory factory = qlStepDownELSFactory(argv[1],argv[2]);

	factory.calculate();



	////std::cout << argc << std::endl;
	////std::cout << argv[1] << std::endl;;
	////std::cout << argv[2][1] << std::endl;;
	////std::cout << argv[3] << std::endl;;
	//  std::cout << "The name used to start the program: " << argv[ 0 ]
 //      << "\nArguments are:\n";
 // for (int n = 1; n < argc; n++)
 //   std::cout << n << ": " << argv[ n ] << '\n';

  return 0;
}

