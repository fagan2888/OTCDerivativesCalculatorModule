#ifndef xmlFactory_qlRangeEventFactory_hpp
#define xmlFactory_qlRangeEventFactory_hpp

#include <ql/time/period.hpp>
#include <string>
#include <boost/algorithm/string.hpp>
#include <src/Engine/MonteCarlo/IRProduct/rateCalculation/range1D.hpp>
#include <src/Engine/MonteCarlo/IRProduct/rateCalculation/rangeND.hpp>

using namespace QuantLib;

namespace XmlFactory {

	class qlRangeEventFactory {
		public:
			qlRangeEventFactory() { }

			boost::shared_ptr<QuantLib::Range1D> range1D(const boost::shared_ptr<FpmlSerialized::Range1D>& xml_serial)
			{
				double upperBound = xml_serial->getUpperBound()->DValue();
				double lowerBound = xml_serial->getLowerBound()->DValue();

				bool upperBoundEquality = xml_serial->getUpperBoundEquality()->BValue();
				bool lowerBoundEquality = xml_serial->getUpperBoundEquality()->BValue();

				const boost::shared_ptr<QuantLib::Range1D>& range1D 
					= boost::shared_ptr<QuantLib::Range1D>(new QuantLib::Range1D(upperBound,upperBoundEquality,lowerBound,lowerBoundEquality));

				return range1D;
			}

			boost::shared_ptr<QuantLib::RangeND> rangeND(const boost::shared_ptr<FpmlSerialized::Excel_multi_rangeND>& xml_serial)
			{
				qlReferenceCalculationFactory ql_ref_factory = qlReferenceCalculationFactory();

				std::string jointType = xml_serial->getJoint_type()->SValue();

				std::vector<boost::shared_ptr<FpmlSerialized::Range1D>>& range1DList 
					= xml_serial->getRange1D();

				std::vector<boost::shared_ptr<QuantLib::Range1D>> ql_rng1DList;

				for ( Size i=0 ; i<range1DList.size() ; i++)
				{
					ql_rng1DList.push_back(this->range1D(range1DList[i]));
				}

				// refCalculation
				std::vector<boost::shared_ptr<Excel_underlyingCalcID>>& e_underCalcIDList
					= xml_serial->getExcel_underlyingCalcID();

				std::vector<boost::shared_ptr<QuantLib::ReferenceCalculation>> ql_refCalList;
		
				for ( Size i=0 ; i<e_underCalcIDList.size() ; i++ )
				{
					ql_refCalList.push_back(ql_ref_factory.underlyingCalc(e_underCalcIDList[i]));

				}

				const boost::shared_ptr<QuantLib::RangeND>& rangeND
					= boost::shared_ptr<QuantLib::RangeND>(
						new QuantLib::RangeND(jointType,ql_rng1DList,ql_refCalList));

				return rangeND;
			}

	};
}

#endif