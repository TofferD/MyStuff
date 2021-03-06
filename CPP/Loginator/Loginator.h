// Loginator.h : Defines the exported functions for the DLL application.
//
#pragma once

#ifdef LOGINATOR_EXPORTS
#define LOGINATOR_API __declspec(dllexport)
#else
#define LOGINATOR_API __declspec(dllimport)
#endif

#include "stdafx.h"

extern "C" LOGINATOR_API void LogOutput(std::string msg);

//enum TLogLevel 
//{
//    logERROR, 
//    logWARNING, 
//    logINFO, 
//    logDEBUG, 
//    logDEBUG1, 
//    logDEBUG2, 
//    logDEBUG3, 
//    logDEBUG4
//};
//
//class Loginator
//{
//    public:
//        Loginator();
//
//        virtual ~Loginator();
//
//        std::ostringstream& Get(TLogLevel level = logINFO);
//
//    public:
//        static TLogLevel& ReportingLevel();
//
//    protected:
//        std::ostringstream os;
//
//    private:
//        Loginator(const Loginator&);
//
//        Loginator& operator =(const Loginator&);
//
//    private:
//        TLogLevel messageLevel;
//};
