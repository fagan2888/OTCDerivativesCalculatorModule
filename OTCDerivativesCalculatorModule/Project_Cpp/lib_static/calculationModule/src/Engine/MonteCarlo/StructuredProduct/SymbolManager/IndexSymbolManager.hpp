#ifndef calculationModule_index_symbol_manager_hpp
#define calculationModule_index_symbol_manager_hpp

#include <ql/patterns/singleton.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/variableValue/variableValue.hpp>

namespace QuantLib {

    //! global repository for past index fixings
    /*! \note index names are case insensitive */
    class IndexSymbolManager : public Singleton<IndexSymbolManager> {
        friend class Singleton<IndexSymbolManager>;
      private:
        IndexSymbolManager() {}
      public:
        //! returns whether historical fixings were stored for the index
        bool hasSymbol(const std::string& name) const;
		
		//�̹� �ִ� symbol�� �V �Ұ�� error�� ��ȯ����.
		void setSymbol(const std::string& name,const boost::shared_ptr<VariableValue>& variableValue) const;
		void setOverWriteSymbol(const std::string& name,const boost::shared_ptr<VariableValue>& variableValue) const;

		void setSymbol(const std::string& name,VariableValue* variableValue) const;

		void addConstVariableForPreFixed(const boost::shared_ptr<VariableValue>& variableValue);

		boost::shared_ptr<VariableValue> getSymbol(const std::string& name,const std::vector<std::string>& circulationCheckString = std::vector<std::string>()) const;

        //! clears the historical fixings of the index
        void clearSymbol(const std::string& name);
		void clearFixingDate(const std::string& name);

        //! clears all stored fixings
        void clearSymbol();
		void clearFixingDate();

      public:
        //typedef std::map< std::string, Real > symbol_map;
		typedef std::map< std::string, boost::shared_ptr<VariableValue> > symbol_ptr_map;

		mutable std::vector<boost::shared_ptr<VariableValue>> constVariables_; //pointer �����

        //mutable symbol_map data_; //�̳��� �����͸� ���� ����Ұ��� ������ ���Ѵ� �̾߱�.
		mutable symbol_ptr_map ptr_data_;
    };

}


#endif
