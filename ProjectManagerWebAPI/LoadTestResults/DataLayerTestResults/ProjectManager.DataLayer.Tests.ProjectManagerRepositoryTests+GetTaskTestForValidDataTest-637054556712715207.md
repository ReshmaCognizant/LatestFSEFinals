# ProjectManager.DataLayer.Tests.ProjectManagerRepositoryTests+GetTaskTestForValidDataTest
_9/30/2019 3:54:31 PM_
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
NBench.NBenchException: Error occurred during $ProjectManager.DataLayer.Tests.ProjectManagerRepositoryTests+GetTaskTestForValidDataTest RUN. ---> NUnit.Framework.AssertionException: Multiple failures or warnings in test:
  1)   Expected: True
  But was:  False

  2)   Expected: True
  But was:  False

  3)   Expected: True
  But was:  False

  4)   Expected: True
  But was:  False

  5)   Expected: not equal to 0
  But was:  0

  6)   Expected: not null
  But was:  null


   at NUnit.Framework.Assert.ReportFailure(String message) in D:\a\1\s\src\NUnitFramework\framework\Assert.cs:line 394
   at NUnit.Framework.Assert.That[TActual](TActual actual, IResolveConstraint expression, String message, Object[] args) in D:\a\1\s\src\NUnitFramework\framework\Assert.That.cs:line 241
   at NUnit.Framework.Assert.IsNotNull(Object anObject) in D:\a\1\s\src\NUnitFramework\framework\Assert.Conditions.cs:line 264
   at ProjectManager.DataLayer.Tests.ProjectManagerRepositoryTests.GetTaskTestForValidDataTest() in C:\Reshma\FinalCertification\LatestFSEFinals\ProjectManagerWebAPI\ProjectManager.DataLayer.Tests\ProjectManagerRepositoryTests.cs:line 241
   at NBench.Sdk.ReflectionBenchmarkInvoker.<>c__DisplayClass10_0.<InvokePerfSetup>b__0(BenchmarkContext ctx)
   at NBench.Sdk.Benchmark.WarmUp()
   --- End of inner exception stack trace ---
```

