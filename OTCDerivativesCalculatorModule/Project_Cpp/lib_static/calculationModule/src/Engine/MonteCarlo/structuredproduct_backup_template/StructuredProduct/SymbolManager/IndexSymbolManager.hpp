#ifndef calculationModule_index_symbol_manager_hpp
#define calculationModule_index_symbol_manager_hpp

#include <ql/patterns/singleton.hpp>

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
		
		//�̹� �ִ� symbol�̸� �ּҸ� ��ȯ����.
		double* setSymbol(const std::string& name) const;

        //! clears the historical fixings of the index
        void clearSymbol(const std::string& name);
        //! clears all stored fixings
        void clearSymbol();

      public:
        typedef std::map< std::string, Real > symbol_map;
		
        mutable symbol_map data_; //�̳��� �����͸� ���� ����Ұ��� ������ ���Ѵ� �̾߱�.
    };

}


#endif
