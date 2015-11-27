// EventId.cpp 
#include "EventId.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EventId::EventId(TiXmlNode* xmlNode)
: Scheme(xmlNode)
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
