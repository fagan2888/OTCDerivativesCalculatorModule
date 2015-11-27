#ifndef quantlib_testClass_portfolioAgg_hpp
#define quantlib_testClass_portfolioAgg_hpp

#include <ql/testClass/EquityLinkedSecurity.hpp>
#include <ql/instrumenst/bond.hpp>

namespace QuantLib {

class PortfolioELS
	public:
		PortfolioELS(boost::shared_ptr<EquityLinkedSecurity>& ELS,
					 std::vector<std::pair<Real,boost::shared_ptr<Bond>>>& bond,
				//	 std::vector<std::pair<Real,boost::shared_ptr<DLS>>>& dls,
				//	 std::vector<std::pair<Real,boost::shared_ptr<EquitySwap>>>& equitySwap,
					 boost::shared_ptr<EquityLinkedSecurity>& ELS_BTB);
		
		Real misMatch(Date date) const;
		std::string IssueSide() const;
		std::string BTBSide() const;
		Real netValue() const;
		Bond& bond() const;
		std::string hedgeType() const;
		


}

#endif