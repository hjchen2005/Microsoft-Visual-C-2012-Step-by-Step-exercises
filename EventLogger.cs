// Logging class
using System;
using System.IO;

public class EventLogger{
  static private StreamWriter eventLog;
  static private string strLogName;
  
  static EventLogger(){
    evetLog = File.CreateText("logfile.txt");
    
    // statement below will throw an exception
    strLogName = (string) strLogName.Clone();
  }
  
  static public void WriteLog(string someText){
    eventLog.Write(someText);
  }
}
