// ExecutionDateTime.cpp 
#include "ExecutionDateTime.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ExecutionDateTime::ExecutionDateTime(TiXmlNode* xmlNode)
: XsdTypeDateTime(xmlNode)
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

