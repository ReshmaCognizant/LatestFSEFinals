﻿# ProjectManager.BusinessLayer.Tests.ProjectManagerServiceTests+TranslateTest_TaskToTaskModel
_9/30/2019 4:22:08 PM_
### System Info
```ini
NBench=NBench, Version=1.2.2.0, Culture=neutral, PublicKeyToken=null
OS=Microsoft Windows NT 6.2.9200.0
ProcessorCount=8
CLR=4.0.30319.42000,IsMono=False,MaxGcGeneration=2
```

### NBench Settings
```ini
RunMode=Throughput, TestMode=Test
NumberOfIterations=3, MaximumRunTime=00:00:01
Concurrent=False
Tracing=False
```

## Data
-------------------

### Totals
|          Metric |           Units |             Max |         Average |             Min |          StdDev |
|---------------- |---------------- |---------------- |---------------- |---------------- |---------------- |
|TotalBytesAllocated |           bytes |            0.00 |            0.00 |            0.00 |            0.00 |
|TotalCollections [Gen2] |     collections |            0.00 |            0.00 |            0.00 |            0.00 |
|[Counter] TestingCounter |      operations |            0.00 |            0.00 |            0.00 |            0.00 |

### Per-second Totals
|          Metric |       Units / s |         Max / s |     Average / s |         Min / s |      StdDev / s |
|---------------- |---------------- |---------------- |---------------- |---------------- |---------------- |
|TotalBytesAllocated |           bytes |            0.00 |            0.00 |            0.00 |            0.00 |
|TotalCollections [Gen2] |     collections |            0.00 |            0.00 |            0.00 |            0.00 |
|[Counter] TestingCounter |      operations |            0.00 |            0.00 |            0.00 |            0.00 |

### Raw Data
#### TotalBytesAllocated
|           Run # |           bytes |       bytes / s |      ns / bytes |
|---------------- |---------------- |---------------- |---------------- |
|               1 |            0.00 |            0.00 |          410.55 |

#### TotalCollections [Gen2]
|           Run # |     collections | collections / s |ns / collections |
|---------------- |---------------- |---------------- |---------------- |
|               1 |            0.00 |            0.00 |          410.55 |

#### [Counter] TestingCounter
|           Run # |      operations |  operations / s | ns / operations |
|---------------- |---------------- |---------------- |---------------- |
|               1 |            0.00 |            0.00 |          410.55 |


## Benchmark Assertions

* [FAIL] Expected [Counter] TestingCounter to must be greater than 10,000,000.00 operations; actual value was 0.00 operations.
* [PASS] Expected TotalBytesAllocated to must be less than or equal to 32,768.00 bytes; actual value was 0.00 bytes.
* [PASS] Expected TotalCollections [Gen2] to must be exactly 0.00 collections; actual value was 0.00 collections.

```
NBench.NBenchException: Error occurred during $ProjectManager.BusinessLayer.Tests.ProjectManagerServiceTests+TranslateTest_TaskToTaskModel RUN. ---> AutoMapper.AutoMapperMappingException: Missing type map configuration or unsupported mapping.

Mapping types:
TaskModel -> Task
ProjectManager.Shared.ServiceContracts.TaskModel -> System.Threading.Tasks.Task
   at lambda_method(Closure , TaskModel , Task , ResolutionContext )
   at lambda_method(Closure , Object , Object , ResolutionContext )
   at AutoMapper.Mapper.Map[TDestination](Object source)
   at ProjectManager.BusinessLayer.EntityMapper`2.Translate(TSource obj) in C:\Reshma\FinalCertification\LatestFSEFinals\ProjectManagerWebAPI\ProjectManager.BusinessLayer\EntityMapper.cs:line 24
   at ProjectManager.BusinessLayer.Tests.ProjectManagerServiceTests.TranslateTest_TaskToTaskModel() in C:\Reshma\FinalCertification\LatestFSEFinals\ProjectManagerWebAPI\ProjectManager.BusinessLayer.Tests\ProjectManagerServiceTests.cs:line 611
   at NBench.Sdk.ReflectionBenchmarkInvoker.<>c__DisplayClass10_0.<InvokePerfSetup>b__0(BenchmarkContext ctx)
   at NBench.Sdk.Benchmark.WarmUp()
   --- End of inner exception stack trace ---
```

