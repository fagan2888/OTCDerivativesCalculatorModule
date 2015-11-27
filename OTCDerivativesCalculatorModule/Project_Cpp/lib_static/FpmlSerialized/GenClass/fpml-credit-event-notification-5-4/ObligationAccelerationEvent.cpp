// ObligationAccelerationEvent.cpp 
#include "ObligationAccelerationEvent.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ObligationAccelerationEvent::ObligationAccelerationEvent(TiXmlNode* xmlNode)
: CreditEvent(xmlNode)
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

