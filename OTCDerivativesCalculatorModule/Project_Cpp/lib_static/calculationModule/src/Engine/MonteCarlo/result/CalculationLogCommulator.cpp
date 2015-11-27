#include "CalculationLogCommulator.hpp"
#include <iostream>
#include <fstream>


namespace QuantLib {
	
CalculationLogCommulator::CalculationLogCommulator()
{
}

void CalculationLogCommulator::save(const std::string& name,const std::vector<std::vector<std::string>>& log)
{
	std::ofstream myfile;
	myfile.open(name);
	
	Size simulNum = log.size();

	for ( Size j=0 ;j < simulNum; j++)
	{
		Size logLineCount = log[j].size();

		for ( Size i=0 ; i<logLineCount ; i++ )
		{
			myfile << log[j][i] << "|";
		}

		myfile << "\n";
	
	}

	myfile.close();
}
	
}
