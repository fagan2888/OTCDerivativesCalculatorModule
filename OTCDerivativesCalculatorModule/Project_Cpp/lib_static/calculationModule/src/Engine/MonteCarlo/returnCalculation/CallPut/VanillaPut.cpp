#include "VanillaPut.hpp"

namespace QuantLib {

VanillaPut::VanillaPut(Real partiRate,
						Real strike,
						Real spread)
: partiRate_(partiRate), strike_(strike), spread_(spread)
{

}
	
Real VanillaPut::calculate(Real v)
{
	return this->partiRate_ * std::max(this->strike_ - v,0.0) + this->spread_;
}
	
}

