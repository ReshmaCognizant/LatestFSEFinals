# ProjectManagerController.Tests.PerformanceBenchmarkTests+Benchmark
_9/30/2019 4:23:30 PM_
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
|[Counter] TestingCounter |      operations |   22,365,878.00 |   22,365,878.00 |   22,365,878.00 |            0.00 |

### Per-second Totals
|          Metric |       Units / s |         Max / s |     Average / s |         Min / s |      StdDev / s |
|---------------- |---------------- |---------------- |---------------- |---------------- |---------------- |
|TotalBytesAllocated |           bytes |            0.00 |            0.00 |            0.00 |            0.00 |
|TotalCollections [Gen2] |     collections |            0.00 |            0.00 |            0.00 |            0.00 |
|[Counter] TestingCounter |      operations |  114,625,454.16 |  113,372,662.20 |  112,467,781.85 |    1,120,120.23 |

### Raw Data
#### TotalBytesAllocated
|           Run # |           bytes |       bytes / s |      ns / bytes |
|---------------- |---------------- |---------------- |---------------- |
|               1 |            0.00 |            0.00 |  198,864,756.04 |
|               2 |            0.00 |            0.00 |  195,121,390.47 |
|               3 |            0.00 |            0.00 |  197,884,780.87 |

#### TotalCollections [Gen2]
|           Run # |     collections | collections / s |ns / collections |
|---------------- |---------------- |---------------- |---------------- |
|               1 |            0.00 |            0.00 |  198,864,756.04 |
|               2 |            0.00 |            0.00 |  195,121,390.47 |
|               3 |            0.00 |            0.00 |  197,884,780.87 |

#### [Counter] TestingCounter
|           Run # |      operations |  operations / s | ns / operations |
|---------------- |---------------- |---------------- |---------------- |
|               1 |   22,365,878.00 |  112,467,781.85 |            8.89 |
|               2 |   22,365,878.00 |  114,625,454.16 |            8.72 |
|               3 |   22,365,878.00 |  113,024,750.57 |            8.85 |


## Benchmark Assertions

* [PASS] Expected [Counter] TestingCounter to must be greater than 10,000,000.00 operations; actual value was 113,372,662.20 operations.
* [PASS] Expected TotalBytesAllocated to must be less than or equal to 32,768.00 bytes; actual value was 0.00 bytes.
* [PASS] Expected TotalCollections [Gen2] to must be exactly 0.00 collections; actual value was 0.00 collections.

