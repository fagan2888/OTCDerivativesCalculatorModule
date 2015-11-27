#include "VanillaCall.hpp"

namespace QuantLib {

VanillaCall::VanillaCall(Real partiRate,
						Real strike,
						Real spread)
: partiRate_(partiRate), strike_(strike), spread_(spread)
{

}
	
Real VanillaCall::calculate(Real v)
{
	return this->partiRate_ * std::max(v - this->strike_,0.0) + this->spread_;
}
	
}

