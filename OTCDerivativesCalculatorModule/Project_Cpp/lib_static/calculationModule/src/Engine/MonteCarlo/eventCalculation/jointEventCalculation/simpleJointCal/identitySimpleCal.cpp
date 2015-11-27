#include "IdentitySimpleCal.hpp"

namespace QuantLib {

IdentitySimpleCal::IdentitySimpleCal(bool pastOcc)
: pastOcc_(pastOcc)
{
}

bool IdentitySimpleCal::jointCal(const std::valarray<bool>& tfs)
{
	return tfs[0];
}


bool IdentitySimpleCal::jointCal(const std::valarray<Real>& tfs)
{
	return tfs[0];
}

}