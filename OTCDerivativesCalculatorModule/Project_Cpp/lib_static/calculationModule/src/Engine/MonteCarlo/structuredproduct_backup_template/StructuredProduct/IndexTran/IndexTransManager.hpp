#ifndef calculationModule_indextransmanager_hpp
#define calculationModule_indextransmanager_hpp

#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/IndexTran/IndexTransSetting.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/IndexTran/IndexTransBase.hpp>

namespace QuantLib {
	
	class IndexTransManager : public IndexTransBase {
		public:	
			IndexTransManager(const std::string& symbolName,
				std::vector<boost::shared_ptr<IndexTransBase>> transBases)
			{

				//이거 설정하는 클래스 필요
				baseIndexNum_ = 0;

				for(Size i=0;i<transBases.size();++i){
					transBasesPtr_[i]=transBases[i].get();
				}
			}

			void defineVar(const std::string varStr)
			{
				for(Size i=0;i<tranNum_;++i){
					parser_.DefineVar(varStr,IndexSymbolManager::instance().setSymbol(varStr));
				}
			}
			void defineConst(const std::string varStr,Real constValue)
			{
				for(Size i=0;i<tranNum_;++i){
					parser_.DefineConst(varStr,constValue);
				}
			}
			void defineBaseIndex(const std::string varStr)
			{
				for(Size i=0;i<tranNum_;++i){
					parser_.DefineVar(varStr,IndexSymbolManager::instance().setSymbol(varStr));
				}
			}

			void calValue(const MultiPath& multiPath)
			{
				transBasesPtr_[baseIndexNum_]->calValue();
			}
			void calValue(const MultiPath& multiPath,int refDatePosition)
			{
				
				//*symbolValuesPtr_ = parser_.Eval();
			}

		private:
			mu::Parser parser_;
			const std::vector<std::string> addedSymbols_;
			IndexTransBase *transBasesPtr_[INDEXMAXNUM]; //
			Size tranNum_;
			int baseIndexNum_;
	
	};

}

#endif