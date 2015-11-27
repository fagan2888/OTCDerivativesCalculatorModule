#include "resultCommulator.hpp"
#include <iostream>
#include <fstream>


namespace QuantLib {
	
ResultCommulator::ResultCommulator(Size pathSize)
: pathSize_(pathSize)
{
	std::valarray<double> v = std::valarray<double>(this->pathSize_);

	for ( Size j=0 ;j<this->pathSize_; j++)
	{
		v[j] = j;
	}	

	resultGrid_.push_back(v);
}

void ResultCommulator::setDate(const MultiPath& multiPath)
{
	Size assetNum = multiPath.assetNumber();

		std::valarray<double> v = std::valarray<double>(this->pathSize_);

		const TimeGrid& grid = multiPath[0].timeGrid();

		for ( Size j=0 ;j<this->pathSize_; j++)
		{
			v[j] = grid.dateAt(j).serialNumber();
		}	

		this->resultGrid_.push_back(v);
		
}


void ResultCommulator::setBasePrice(const boost::shared_ptr<ProcessArrayWrapper>& processArr)
{
	Size assetNum = processArr->size();
	this->basePrice_ = std::valarray<double>(assetNum);
	
	std::valarray<double> v = std::valarray<double>(this->pathSize_);

	for ( Size j=0 ;j<assetNum; j++)
	{
		v[j] = processArr->processWrapper(j)->basePrice();
	}	

	this->resultGrid_.push_back(v);
}


void ResultCommulator::recode(const MultiPath& multiPath)
{
	if ( this->resultGrid_.size() < 100 )
	{
		Size assetNum = multiPath.assetNumber();

		for ( Size i=0 ;i<assetNum; i++)
		{
			std::valarray<double> v = std::valarray<double>(this->pathSize_);

			for ( Size j=0 ;j<this->pathSize_; j++)
			{
				v[j] = multiPath[i][j];
			}	

			this->resultGrid_.push_back(v);
		}
	
	}

}

void ResultCommulator::save(const std::string& name)
{
	std::ofstream myfile;
	myfile.open(name);
	
	for ( Size j=0 ;j<this->pathSize_; j++)
	{
		//for ( Size i=0 ; i<100 ; i++ )
		for ( Size i=0 ; i<resultGrid_.size() ; i++ )
		{
			myfile << resultGrid_[i][j] << " ";
		}

		myfile << "\n";
	
	}

	myfile.close();
}
	
}
