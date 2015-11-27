#ifndef calculationModule_indextransCustom_hpp
#define calculationModule_indextransCustom_hpp

#include <src/Engine/MonteCarlo/StructuredProduct/IndexTran/IndexTransManagerBase.hpp>
#include <ql/methods/montecarlo/multipath.hpp>

namespace QuantLib {
	
	namespace TransFunction {

	class ReturnTrans : public IndexTransBase {
	
		public:
			ReturnTrans(std::string baseIndex)
			: baseIndex_(baseIndex) 
			{
				baseIndexNum_ = PathInfomation::getPathNum(baseIndex);
			}

			ReturnTrans(std::string baseIndex,
						std::string symbolName,
						const Date& numerDate,
						const Date& denumerDate ) 
			: baseIndex_(baseIndex), numerDate_(numerDate_), denumerDate_(denumerDate)
			{
				baseIndexNum_ = PathInfomation::getPathNum(baseIndex);
				symbolValuesPtr_ = IndexSymbolManager::instance().setSymbol(symbolName);
			}
			// for specific path

			void setPtr()
			{
				//			" numer / denumer "
				numer_ = &(multiPath[baseIndexNum_][numerPosition_]); //ºÐÀÚ
				denumer_ = &(multiPath[baseIndexNum_][denumerPosition_]);
			}

			void initialize(const TimeGrid& timeGrid, const Calendar& calendar)
			{
				
				numerposition_ = calendar.businessDaysBetween(issueDate,numerDate,true,false);
				denumerposition_ = calendar.businessDaysBetween(issueDate,denumerDate,true,false);

				this->setPtr();
				
			}

			inline void calValue()
			{
				*symbolValuesPtr_ = (*numer_)/(*denumer_);
			}
			inline void calValue(int refDatePosition)
			{
				*symbolValuesPtr_ = PathInfomation::multiPath[baseIndexNum_][refDatePosition];
			}
		private:
			std::string baseIndex_;
			Size baseIndexNum_;

			Size numerPosition_;
			Size denumerPosition_;

			Date numerDate_;
			Date denumerDate_;

			Real *numer_;
			Real *denumer_;
	};

	//class BasketTrans : public IndexTransBase {
	//
	//	public:
	//		BasketTrans(std::vector<Date> averDates);

	//		inline void calValue()
	//		{
	//			*symbolValuesPtr_ = CommonPath::multiPath[baseIndexNum_][position_];
	//		}
	//		inline void calValue(int refDatePosition)
	//		{
	//			*symbolValuesPtr_ = CommonPath::multiPath[baseIndexNum_][refDatePosition];
	//		}
	//	private:
	//		Real[] *basket;
	//		

	//};

}

#endif