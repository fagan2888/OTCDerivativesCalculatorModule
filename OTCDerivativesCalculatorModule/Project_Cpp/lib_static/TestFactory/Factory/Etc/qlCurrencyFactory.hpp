#ifndef xmlFactory_currencyfactory_hpp
#define xmlFactory_currencyfactory_hpp

namespace XmlFactory {

	class qlCurrencyFactory {
		public:
			enum CurrencyType 
			{
				KRW = 0,
				USD = 1,
				JPY = 2,
				EUR = 3
			};

			qlCurrencyFactory()
			{
			
			}

			boost::shared_ptr<QuantLib::Currency> currency(const std::string& ctStr)
			{
				CurrencyType ct = this->type(ctStr);
				boost::shared_ptr<QuantLib::Currency> curPtr;

				switch (ct) {
					case KRW :
						curPtr = boost::shared_ptr<QuantLib::Currency>(new KRWCurrency());
						break;
					case USD :
						curPtr = boost::shared_ptr<QuantLib::Currency>(new USDCurrency());
						break;
					case JPY :
						curPtr = boost::shared_ptr<QuantLib::Currency>(new JPYCurrency());
						break;
					case EUR :
						curPtr = boost::shared_ptr<QuantLib::Currency>(new EURCurrency());
						break;
					default:
						QL_FAIL("unknown type currency");
						break;
				}

				return curPtr;
			}

			CurrencyType type(const std::string& ctStr)
			{
				if(ctStr == "KRW"){return KRW;}
				else
				{
					QL_FAIL("unknown type currency string");
				}
			}
	};

}
#endif