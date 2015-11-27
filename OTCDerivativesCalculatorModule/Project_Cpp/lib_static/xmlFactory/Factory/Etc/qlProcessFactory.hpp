#ifndef xmlFactory_processfactory_hpp
#define xmlFactory_processfactory_hpp

#include <GenClass/RiskMonitor-0-1/all.hpp>
#include <ql/math/matrix.hpp>
#include <ql/processes/all.hpp>
#include <src/Engine/MonteCarlo/stochasticProcess/all.hpp>

using namespace QuantLib;

namespace XmlFactory {

	class qlProcessFactory {
		public:
			qlProcessFactory()
			{
			}

			void setProcessCode(std::vector<std::string> underListCode);
			void makeProcess(const boost::shared_ptr<FpmlSerialized::UnderlyingInformation>& xml_underlingInfo,
							 const boost::shared_ptr<FpmlSerialized::UnderlyingInfo_para>& xml_underlingInfo_para);

			void buildProcess(const boost::shared_ptr<FpmlSerialized::Excel_underlyingCalcInfo_para>& xml_underlyingCalcInfo_para);

			boost::shared_ptr<QuantLib::StochasticProcess1D> process1D(boost::shared_ptr<FpmlSerialized::Underlying_para> xml_underlingPara);
			//boost::shared_ptr<QuantLib::IProcessWrapper> process1DWrapper(boost::shared_ptr<FpmlSerialized::Underlying_para> xml_underlingPara);
			boost::shared_ptr<QuantLib::IProcessWrapper> e_process1DWrapper(boost::shared_ptr<FpmlSerialized::Excel_underlyingInfo_para> xml_under_para);

			boost::shared_ptr<QuantLib::StochasticProcessArray> process();
			QuantLib::Matrix matrix();
			boost::shared_ptr<QuantLib::Matrix> matrixPtr();
			void makeMatrix(boost::shared_ptr<FpmlSerialized::Excel_correlationInfo_para> e_corrPara);
			boost::shared_ptr<QuantLib::StochasticProcessArray> getProcessArr();
			boost::shared_ptr<QuantLib::ProcessArrayWrapper> getProcessArrWrapper();

		private:

			

			boost::shared_ptr<QuantLib::StochasticProcessArray> processArr_;
			boost::shared_ptr<QuantLib::ProcessArrayWrapper> processArrWrapper_;
			//std::vector<boost::shared_ptr<StochasticProcess1D> > process1DList_;
			QuantLib::Matrix matrix_;

			std::vector<std::string> underListCode_;
			std::vector<Real> basePrice_;
	};

}
#endif