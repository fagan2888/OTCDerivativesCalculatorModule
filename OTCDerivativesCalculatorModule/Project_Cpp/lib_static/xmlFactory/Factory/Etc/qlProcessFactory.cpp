#include "qlProcessFactory.hpp"
#include <src/Engine/MonteCarlo/stochasticProcess/all.hpp>
#include <Factory/Etc/qlTimeUnitFactory.hpp>
#include <Factory/Etc/qlYieldTermStructureFactory.hpp>

using namespace QuantLib;

namespace XmlFactory {

void qlProcessFactory::setProcessCode(std::vector<std::string> underListCode)
{
	this->underListCode_ = underListCode;
}

//void qlProcessFactory::makeProcess(const boost::shared_ptr<FpmlSerialized::UnderlyingInformation>& xml_underlingInfo,
//								   const boost::shared_ptr<FpmlSerialized::UnderlyingInfo_para>& xml_underlingInfo_para)
//{
//	const boost::shared_ptr<FpmlSerialized::IndexUnderInfo>& xml_indexInfo = xml_underlingInfo->getIndexUnderInfo();
//
//	std::vector<boost::shared_ptr<FpmlSerialized::Index>> xml_indexList = xml_indexInfo->getIndex();
//	
//	//underListCode_ = std::vector<std::string>(1);
//	//underListCode_ = std::vector<std::string>(xml_indexList.size());
//	//basePrice_.resize(underListCode_.size());
//
//	for ( Size i=0 ; i<xml_indexList.size() ; i++ )
//	{
//		//underListCode_[i] = xml_indexList[i]->getKrCode()->SValue();
//		//underListCode_.push_back(xml_indexList[i]->getKrCode()->SValue());
//		
//		// name으로 변경 2014-04-30 : 영문이름으로 사용 요망
//		underListCode_.push_back(xml_indexList[i]->getName()->SValue());
//
//		//basePrice_[i] = xml_indexList[i]->getBasePrice()->DValue();
//		basePrice_.push_back(xml_indexList[i]->getBasePrice()->DValue());
//	}
//
//	std::vector<boost::shared_ptr<FpmlSerialized::Underlying_para>> xml_underlyingList 
//		= xml_underlingInfo_para->getUnderlying_para();
//
//	//std::vector<boost::shared_ptr<StochasticProcess1D> > process1DList;
//	std::vector<boost::shared_ptr<IProcessWrapper> > process1DListWrapper;
//
//	process1DListWrapper.resize(underListCode_.size());
//	
//	int checkNum = 0;
//
//	for(Size i=0 ; i < xml_underlyingList.size() ; ++i)
//	{
//		for ( Size j=0 ; j < underListCode_.size() ; ++j)
//		{
//			//if(  xml_underlyingList[i]->getKrCode()->SValue() == underListCode_[j] )
//			if(  xml_underlyingList[i]->getUnderName()->SValue() == underListCode_[j] )
//			{
//				process1DListWrapper[j] = this->process1DWrapper(xml_underlyingList[i]);
//				process1DListWrapper[j]->setBasePrice(basePrice_[j]);
//				checkNum += 1;
//				//process1DList[j] = this->process1D(xml_underlyingList[i]);
//				//process1DList[j]->setBasePrice(basePrice_[j]);
//			}
//		}
//	}
//
//	QL_REQUIRE(xml_underlyingList.size() == checkNum , "underlying Process Gen Error" << checkNum );
//
//	boost::shared_ptr<FpmlSerialized::CorrelationInfo_para> xml_corrInfoPara 
//		= xml_underlingInfo_para->getCorrelationInfo_para();
//
//	this->makeMatrix(xml_corrInfoPara);
//
//	//processArr_ = boost::shared_ptr<StochasticProcessArray>(
//	//	new StochasticProcessArray(process1DList,this->matrix_));
//
//	processArrWrapper_ = boost::shared_ptr<ProcessArrayWrapper>(
//		new ProcessArrayWrapper(process1DListWrapper,this->matrix_));
//
//	double _00_ = this->matrix_[0][0];
//	double _01_ = this->matrix_[0][1];
//	double _10_ = this->matrix_[1][0];
//	double _11_ = this->matrix_[1][1];
//
//}


void qlProcessFactory::buildProcess(const boost::shared_ptr<FpmlSerialized::Excel_underlyingCalcInfo_para>& xml_underCalcInfo_para)
{
	if ( xml_underCalcInfo_para->isExcel_underlyingInfo_para() )
	{
		this->processArrWrapper_ = boost::shared_ptr<ProcessArrayWrapper>(new ProcessArrayWrapper());
		
		return;
	}

	std::vector<boost::shared_ptr<FpmlSerialized::Excel_underlyingInfo_para>> xml_under_paraList 
		= xml_underCalcInfo_para->getExcel_underlyingInfo_para();

	//std::vector<boost::shared_ptr<StochasticProcess1D> > process1DList;
	std::vector<boost::shared_ptr<IProcessWrapper> > process1DListWrapper;

	Size underCount = xml_under_paraList.size();
	
	process1DListWrapper.resize(underCount);
	this->underListCode_.resize(underCount);

	int checkNum = 0;

	for(Size i=0 ; i < xml_under_paraList.size() ; ++i)
	{
		process1DListWrapper[i] = this->e_process1DWrapper(xml_under_paraList[i]);

		this->underListCode_[i] = xml_under_paraList[i]->getKrCode()->SValue();

		Real basePrice = xml_under_paraList[i]->getBasePrice()->DValue();

		process1DListWrapper[i]->setBasePrice(basePrice);
		checkNum += 1;
	}

	//QL_REQUIRE(xml_underlyingList.size() == checkNum , "underlying Process Gen Error" << checkNum );

	const boost::shared_ptr<FpmlSerialized::Excel_correlationInfo_para>& e_ci_para 
		= xml_underCalcInfo_para->getExcel_correlationInfo_para();

	this->makeMatrix(e_ci_para);

	processArrWrapper_ = boost::shared_ptr<ProcessArrayWrapper>(
		new ProcessArrayWrapper(process1DListWrapper,this->matrix_));

	//double _00_ = this->matrix_[0][0];
	//double _01_ = this->matrix_[0][1];
	//double _10_ = this->matrix_[1][0];
	//double _11_ = this->matrix_[1][1];
		
}

boost::shared_ptr<QuantLib::StochasticProcess1D> qlProcessFactory::process1D(boost::shared_ptr<FpmlSerialized::Underlying_para> xml_underlingPara)
{

	std::string type = xml_underlingPara->getType()->SValue();

	boost::shared_ptr<QuantLib::StochasticProcess1D> process1D;

	if(type == "geometricBM")
	{
		boost::shared_ptr<FpmlSerialized::GeometricBM> xml_gbm = xml_underlingPara->getGeometricBM();
		double initial = xml_gbm->getCurrentValue()->DValue();
		double drift = xml_gbm->getDrift()->DValue();
		double dividend = xml_gbm->getDividend()->DValue();
		double vol = xml_gbm->getVolatility()->DValue();

		process1D = boost::shared_ptr<StochasticProcess1D>(new GeometricBrownianMotionProcess(initial, drift - dividend , vol));

	}

	return process1D;
}

boost::shared_ptr<QuantLib::IProcessWrapper> qlProcessFactory::e_process1DWrapper(
	boost::shared_ptr<FpmlSerialized::Excel_underlyingInfo_para> xml_under_para)
{
	const boost::shared_ptr<FpmlSerialized::Excel_underlyingModel_para>& e_um_para
		= xml_under_para->getExcel_underlyingModel_para();

	std::string type = e_um_para->getExcel_type()->SValue();

	boost::shared_ptr<QuantLib::IProcessWrapper> process1DWrapper;

	//const std::string& krCode = xml_underlingPara->getKrCode()->SValue();
	const std::string& code = xml_under_para->getKrCode()->SValue();

	if(type == "excel_geometricBM")
	{
		boost::shared_ptr<FpmlSerialized::Excel_geometricBM> xml_gbm = e_um_para->getExcel_geometricBM();

		double currentValue = xml_gbm->getCurrentValue()->DValue();
		double drift = xml_gbm->getDrift()->DValue();
		double dividend = xml_gbm->getDividend()->DValue();
		double vol = xml_gbm->getVolatility()->DValue();
		
		process1DWrapper = boost::shared_ptr<IProcessWrapper>(new GBMProcess1DWrapper(code, 
																					currentValue, 
																					drift - dividend , 
																					vol));

	}
	else if(type == "excel_hullWhiteOneFactor")
	{
		const boost::shared_ptr<FpmlSerialized::Excel_hullWhiteOneFactor>& xml_hullwhite 
			= xml_under_para->getExcel_underlyingModel_para()->getExcel_hullWhiteOneFactor();

		double currentValue = xml_hullwhite->getCurrentValue()->DValue();

		double alpha = xml_hullwhite->getAlpha()->DValue();
		double sigma = xml_hullwhite->getVolatility()->DValue();
		//const boost::shared_ptr<FpmlSerialized::Tenor>& xml_tenor = xml_hullwhite->getTenor();

		std::string periodTenorStr = xml_hullwhite->getExcel_rateInfo()->getTenor()->SValue();
		std::string legTenorStr = xml_hullwhite->getExcel_rateInfo()->getLegTenor()->SValue();

		std::string currency = xml_hullwhite->getExcel_rateInfo()->getCurrency()->SValue();
		std::string rateType = xml_hullwhite->getExcel_rateInfo()->getIndexType()->SValue();

		const boost::shared_ptr<FpmlSerialized::Excel_yieldCurve>& xml_fittingYieldCurve
			= xml_hullwhite->getExcel_yieldCurve();

		qlTimeUnitFactory qlTUF = qlTimeUnitFactory();

		Period periodTenor = qlTUF.timeUnit(periodTenorStr);
		Period legTenor = qlTUF.timeUnit(legTenorStr);
		
		qlYieldTermStructureFactory qlYieldTS = qlYieldTermStructureFactory();

		const boost::shared_ptr<QuantLib::YieldTermStructure>& ql_fittingYieldTS
			= qlYieldTS.e_yieldTSBoost(xml_fittingYieldCurve);

		process1DWrapper = boost::shared_ptr<IProcessWrapper>(
			new HullWhiteProcess1DWrapper(code, 
										currency,
										ql_fittingYieldTS,
										periodTenor,
										legTenor,
										rateType,
										currentValue,
										alpha, 
										sigma));

	}
	else if(type == "excel_forwardModel")
	{
		const boost::shared_ptr<FpmlSerialized::Excel_forwardModel>& xml_forward 
			= xml_under_para->getExcel_underlyingModel_para()->getExcel_forwardModel();

		double currentValue = xml_forward->getCurrentValue()->DValue();

		std::string tenor = xml_forward->getTenor()->SValue();

		const boost::shared_ptr<FpmlSerialized::Excel_yieldCurve>& xml_fittingYieldCurve
			= xml_forward->getExcel_yieldCurve();

		qlTimeUnitFactory qlTUF = qlTimeUnitFactory();

		Period period = qlTUF.timeUnit(tenor);

		qlYieldTermStructureFactory qlYieldTS = qlYieldTermStructureFactory();

		const boost::shared_ptr<QuantLib::YieldTermStructure>& ql_fittingYieldTS
			= qlYieldTS.e_yieldTSBoost(xml_fittingYieldCurve);

		process1DWrapper = boost::shared_ptr<IProcessWrapper>(
			new ForwardRateModelWrapper(code, 
										ql_fittingYieldTS,
										currentValue,
										period));

	}
	else 
	{
		QL_FAIL("unknown underlying model Type : " << type );
	}


	return process1DWrapper;
}


boost::shared_ptr<QuantLib::StochasticProcessArray> qlProcessFactory::process()
{
	return processArr_;
}

QuantLib::Matrix qlProcessFactory::matrix()
{
	return matrix_;
}

void qlProcessFactory::makeMatrix(boost::shared_ptr<FpmlSerialized::Excel_correlationInfo_para> e_corrPara)
{
	Size dimension = e_corrPara->getDimension()->IValue();

	QuantLib::Matrix corrMatrix(dimension,dimension,1.0);
	std::vector<boost::shared_ptr<FpmlSerialized::Excel_correlation_para>> xml_corrListpara
		= e_corrPara->getExcel_correlation_para();

	Size chechCount = 0;

	for( Size row = 0 ; row < dimension ; ++row )
	{
		for( Size col = 0 ; col < dimension ; ++col )
		{
			for ( Size i = 0 ; i < xml_corrListpara.size() ; ++ i )
			{
				if ( boost::to_upper_copy(xml_corrListpara[i]->getFirst()->SValue()) == boost::to_upper_copy(underListCode_[row]) &&
					 boost::to_upper_copy(xml_corrListpara[i]->getSecond()->SValue()) == boost::to_upper_copy(underListCode_[col]) )				
				{
					corrMatrix[row][col] = xml_corrListpara[i]->getValue()->DValue();
					chechCount += 1;
				}
			}
		}
	}

	QL_REQUIRE(chechCount == dimension * dimension , "matrix chechsum error, chesumNum : " << chechCount );

	/*if ( chechCount != dimension * dimension )
	{
		this->matrix_ = QuantLib::Matrix();
	}*/


		for ( Size col=0 ;col<dimension; col++)	
		{
			for ( Size row=0 ;row<dimension; row++)
			{
				std::cout << " " <<	corrMatrix[row][col];
			}
			std::cout << std::endl;
		}

	this->matrix_ = corrMatrix;
			
}

boost::shared_ptr<QuantLib::StochasticProcessArray> qlProcessFactory::getProcessArr()
{
	return this->processArr_;
}

boost::shared_ptr<QuantLib::ProcessArrayWrapper> qlProcessFactory::getProcessArrWrapper()
{
	return this->processArrWrapper_;
	//std::vector<boost::shared_ptr<IProcessWrapper>> ipwList;

	//for ( Size i=0 ; i < processArr_->size() ; i++)
	//{
	//	boost::shared_ptr<IProcessWrapper> ipw = boost::shared_ptr<IProcessWrapper>(
	//		new GBMProcess1DWrapper(processArr_->process(i)->x0(),
	//								processArr_->process(i)->drift(0.0,1.0),
	//								processArr_->process(i)->diffusion(0.0,1.0)));

	//	ipwList.push_back(ipw);
	//}

	//boost::shared_ptr<ProcessArrayWrapper> paw =
	//	boost::shared_ptr<ProcessArrayWrapper>(new ProcessArrayWrapper(ipwList,processArr_->correlation()));

	//return paw;
}

}
