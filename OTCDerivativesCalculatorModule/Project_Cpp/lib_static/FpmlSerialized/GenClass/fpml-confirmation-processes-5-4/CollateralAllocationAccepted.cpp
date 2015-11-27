// CollateralAllocationAccepted.cpp 
#include "CollateralAllocationAccepted.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CollateralAllocationAccepted::CollateralAllocationAccepted(TiXmlNode* xmlNode)
: ResponseMessage(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
}

