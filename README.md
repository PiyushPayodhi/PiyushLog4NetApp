# PiyushLog4NetApps
A simple **log4net** implementation in a console application.

# Steps
1. Use nuget pakage manager to add log4net The Apache Software Foundation.
2. Add following inside <configuration> of your app.config
3. ```
      <!--Note: The configSections must be the first element in configuration-->
        <configSections>
          <section name="log4net" type="log4net.Config.Log4NetConfigurationSectionHandler, log4net" />
        </configSections>
   ```
4. ``` 
    <log4net>
        This will show the logs in Console
        <appender name="ConsoleAppender" type="log4net.Appender.ColoredConsoleAppender">
          <layout type="log4net.Layout.PatternLayout">
            <conversionPattern value="%date %level [%thread] %logger{1} %username - %message%newline" />
          </layout>
          <mapping>
            <level value="WARN" />
            <foreColor value="Yellow, HighIntensity" />
          </mapping>
          <mapping>
            <level value="ERROR" />
            <foreColor value="Red, HighIntensity" />
          </mapping>
        </appender>
      
        <appender name="RollingFile" type="log4net.Appender.RollingFileAppender">
          <file value="./logs/log.log" />
          <rollingStyle value="Date" />
          <appendToFile value="true" />
          <lockingModel type="log4net.Appender.FileAppender+MinimalLock" />
          <datePattern value="yyyyMMdd" />
          <layout type="log4net.Layout.PatternLayout">
            <conversionPattern value="%date %level [%thread] %logger{1} - %message%newline" />
          </layout>
        </appender>
      
        <!--This will show the logs in Log file-->
        <appender name="LogFileAppender" type="log4net.Appender.RollingFileAppender">
          <param name="File" value="xxx\\MyApps.log"/>
          <lockingModel type="log4net.Appender.FileAppender+MinimalLock" />
          <appendToFile value="true" />
          <rollingStyle value="Size" />
          <maxSizeRollBackups value="10" />
          <maximumFileSize value="1MB" />
          <staticLogFileName value="true" />
          <layout type="log4net.Layout.PatternLayout">
            <conversionPattern value="%date [%thread] %level %logger - %message%newline" />
          </layout>
        </appender>
        
        <root>
          <level value="ALL" />
          <appender-ref ref="ConsoleAppender" />
          <appender-ref ref="RollingFile" />
          <appender-ref ref="LogFileAppender" />
        </root>
    </log4net>
  ```
