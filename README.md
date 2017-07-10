# DFQ to JSON Converter
#### DFQ to JSON Converter is a Q-DAS ASCII transfer format to JSON converter. 

### Features
-	Reads part, characteristics and measurement data according to requirements and rules stated in [QDAS technical document](http://www.q-das.com/fileadmin/files2/dataformat/Q-DAS_ASCII-Transfer-Format_ENG_V12_ec.pdf). 
-	Supports all part, characteristic and measurement K-fields
-	Supports inline and K-field notations  

### Technology
Entire solution is written in [.NET Core](https://github.com/dotnet/core). [Json.NET](https://github.com/JamesNK/Newtonsoft.Json) is used for data serialization and tests are done using [xUnit](https://github.com/xunit/xunit).

### Requirements
.NET Core 1.1 SDK

### License
MIT
