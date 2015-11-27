#ifndef FpmlSerialized_filemanager_hpp
#define FpmlSerialized_filemanager_hpp

#include <ql/patterns/singleton.hpp>
#include <vector>
#include <string>
#include <iostream>
#include <fstream>

using namespace QuantLib;

namespace FpmlSerialized {

	class ISerialized;
    //! global repository for past index fixings
    /*! \note index names are case insensitive */
    class FileManager : public Singleton<FileManager> {
        friend class Singleton<FileManager>;
		
      private:
        FileManager() {
			outFile_ = std::ofstream("default.txt");
			this->tap_ = "";
		}
      public:
		  void newfile(const std::string& fileName)
		  {
			  outFile_ = std::ofstream(fileName.c_str());
		  }
		  void closeFile()
		  {
			  outFile_.close();
		  }

      public:
		std::ofstream outFile_;
		std::string tap_;
    };

}

#endif
