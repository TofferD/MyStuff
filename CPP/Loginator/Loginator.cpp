#include "Loginator.h"

void LogOutput(std::string msg)
{
    std::ofstream logFile;
    logFile.open("ToffsLogfile.txt");
    logFile << msg;
    logFile.close();
}

//std::ostringstream& Loginator::Get(TLogLevel level)
//{
//    //os << "- " << NowTime();
//    //os << " " << ToString(level) << ": ";
//    os << std::string(level > logDEBUG ? 0 : level - logDEBUG, '\t');
//    messageLevel = level;
//    return os;
//}
//
//Loginator::~Loginator()
//{
//    if (messageLevel >= Loginator::ReportingLevel())
//    {
//        os << std::endl;
//        fprintf(stderr, "%s", os.str().c_str());
//        fflush(stderr);
//    }
//}