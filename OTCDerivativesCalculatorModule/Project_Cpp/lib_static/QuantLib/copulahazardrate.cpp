#include <ql/termstructures/credit/copulahazardrate.hpp>

namespace QuantLib{


	template<class TraitProb,class Interpolation>
	void CopulaHazardRate<TraitProb,Interpolation>::calculate() const
	{
		Size dataSize=probabilities_[0]->size();
		for(i=0;i<dataSize;i++){
			this.data_[i]=defaultProbability(dates_[i]);
		}
		

	}
	template<class TraitProb,class Interpolation>
	void CopulaHazardRate<TraitProb,Interpolation>::initialize() const
	{
		this.dates_=probabilities_[0]->jumpDates();
		
	}
	template<class TraitProb,class Interpolation>
	void CopulaHazardRate<TraitProb,Interpolation>::performCalculations() const
	{
		calculate();
		
	}
}