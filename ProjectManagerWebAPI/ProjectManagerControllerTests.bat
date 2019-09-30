@ECHO OFF

REM OpenCover-NUnit.bat

REM Run opencover against NUnit tests in your test project and show report of code coverage

SET DllContainingTests=%~dp0ProjectManagerController.Tests\bin\Debug\ProjectManagerController.Tests.dll

REM *** IMPORTANT - Change DllContainingTests variable (above) to point to the DLL 
REM ***             in your solution containing your NUnit tests
REM ***
REM ***             You may also want to change the include/exclude filters (below) 
REM ***             for OpenCover
REM ***
REM ***             This batch file should dbe placed in the root folder of your solution

REM NUnit Test Runner (done this way so we dont have to change the code 
REM when the version number changes)
for /R "%~dp0packages" %%a in (*) do if /I "%%~nxa"=="nunit3-console.exe" SET TestRunnerExe=%%~dpnxa

REM Get OpenCover Executable (done this way so we dont have to change the 
REM code when the version number changes)
for /R "%~dp0packages" %%a in (*) do if /I "%%~nxa"=="OpenCover.Console.exe" SET OpenCoverExe=%%~dpnxa

REM Get Report Generator (done this way so we dont have to change the code 
REM when the version number changes)
for /R "%~dp0packages" %%a in (*) do if /I "%%~nxa"=="ReportGenerator.exe" SET ReportGeneratorExe=%%~dpnxa

REM Create a 'GeneratedReports' folder if it does not exist
if not exist "%~dp0GeneratedReports" mkdir "%~dp0GeneratedReports"

REM Run the tests against the targeted output
call :RunOpenCoverUnitTestMetrics

REM Generate the report output based on the test results
if %errorlevel% equ 0 ( 
 call :RunReportGeneratorOutput 
)

REM Launch the report
if %errorlevel% equ 0 ( 
 call :RunLaunchReport 
)
exit /b %errorlevel%

:RunOpenCoverUnitTestMetrics 
REM *** Change the filter to include/exclude parts of the solution you want 
REM *** to check for test coverage
"%OpenCoverExe%" ^
 -target:"%TestRunnerExe%" ^
 -targetargs:"\"%DllContainingTests%\"" ^
 -filter:"+[ProjectManagerController*]* -[*.Tests*]* -[*]*.*Config" ^
 -mergebyhash ^
 -skipautoprops ^
 -register:user ^
 -output:"%~dp0GeneratedReports\CoverageReport_Controller.xml"
exit /b %errorlevel%

:RunReportGeneratorOutput
"%ReportGeneratorExe%" ^
 -reports:"%~dp0\GeneratedReports\CoverageReport_Controller.xml" ^
 -targetdir:"%~dp0\GeneratedReports\ReportGenerator Output"
exit /b %errorlevel%

:RunLaunchReport
start "report" "%~dp0\GeneratedReports\ReportGenerator Output\index.htm"
exit /b %errorlevel%