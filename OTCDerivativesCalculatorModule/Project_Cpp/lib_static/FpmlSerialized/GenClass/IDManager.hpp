#ifndef FpmlSerialized_idmanager_hpp
#define FpmlSerialized_idmanager_hpp

#include <ql/patterns/singleton.hpp>
#include <vector>
#include <string>
#include <boost/shared_ptr.hpp>

using namespace QuantLib;

namespace FpmlSerialized {

	class ISerialized;
    //! global repository for past index fixings
    /*! \note index names are case insensitive */
    class IDManager : public Singleton<IDManager> {

        friend class Singleton<IDManager>;
		
      private:
        IDManager() { this->tap_ = "";}
      public:
        //! returns whether historical fixings were stored for the index
        bool hasID(const std::string& name) const;
		
		//�̹� �ִ� symbol�̸� �ּҸ� ��ȯ����.
		void setID(const std::string& name,const boost::shared_ptr<ISerialized>& id) const;
		void setVID(const std::string& name,const std::vector<boost::shared_ptr<ISerialized>>& id) const;

		boost::shared_ptr<ISerialized> getID(const std::string& name) const;
		std::vector<boost::shared_ptr<ISerialized>> getVID(const std::string& name) const;

        //! clears the historical fixings of the index
        void clearID(const std::string& name);
        //! clears all stored fixings
        void clearID();

      public:
		typedef std::map< std::string, boost::shared_ptr<ISerialized> > id_map;
        mutable id_map data_; //�̳��� �����͸� ���� ����Ұ��� ������ ���Ѵ� �̾߱�.

		typedef std::map< std::string, std::vector<boost::shared_ptr<ISerialized>> > id_vmap;
        mutable id_vmap vdata_; //�̳��� �����͸� ���� ����Ұ��� ������ ���Ѵ� �̾߱�.
		std::string tap_;
    };

}

#endif
