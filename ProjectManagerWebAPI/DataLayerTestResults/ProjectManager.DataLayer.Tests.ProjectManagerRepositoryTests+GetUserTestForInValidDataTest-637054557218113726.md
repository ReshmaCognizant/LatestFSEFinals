# ProjectManager.DataLayer.Tests.ProjectManagerRepositoryTests+GetUserTestForInValidDataTest
_9/30/2019 3:55:21 PM_
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
|TotalBytesAllocated |           bytes |      600,800.00 |      600,800.00 |      600,800.00 |            0.00 |
|TotalCollections [Gen2] |     collections |            0.00 |            0.00 |            0.00 |            0.00 |
|[Counter] TestingCounter |      operations |            0.00 |            0.00 |            0.00 |            0.00 |

### Per-second Totals
|          Metric |       Units / s |         Max / s |     Average / s |         Min / s |      StdDev / s |
|---------------- |---------------- |---------------- |---------------- |---------------- |---------------- |
|TotalBytesAllocated |           bytes |      667,395.54 |      554,796.91 |      448,360.80 |      109,647.33 |
|TotalCollections [Gen2] |     collections |            0.00 |            0.00 |            0.00 |            0.00 |
|[Counter] TestingCounter |      operations |            0.00 |            0.00 |            0.00 |            0.00 |

### Raw Data
#### TotalBytesAllocated
|           Run # |           bytes |       bytes / s |      ns / bytes |
|---------------- |---------------- |---------------- |---------------- |
|               1 |      600,800.00 |      548,634.40 |        1,822.71 |
|               2 |      600,800.00 |      448,360.80 |        2,230.35 |
|               3 |      600,800.00 |      667,395.54 |        1,498.36 |

#### TotalCollections [Gen2]
|           Run # |     collections | collections / s |ns / collections |
|---------------- |---------------- |---------------- |---------------- |
|               1 |            0.00 |            0.00 |1,095,082,634.86 |
|               2 |            0.00 |            0.00 |1,339,992,265.30 |
|               3 |            0.00 |            0.00 |  900,215,783.39 |

#### [Counter] TestingCounter
|           Run # |      operations |  operations / s | ns / operations |
|---------------- |---------------- |---------------- |---------------- |
|               1 |            0.00 |            0.00 |1,095,082,634.86 |
|               2 |            0.00 |            0.00 |1,339,992,265.30 |
|               3 |            0.00 |            0.00 |  900,215,783.39 |


## Benchmark Assertions

* [FAIL] Expected [Counter] TestingCounter to must be greater than 10,000,000.00 operations; actual value was 0.00 operations.
* [FAIL] Expected TotalBytesAllocated to must be less than or equal to 32,768.00 bytes; actual value was 600,800.00 bytes.
* [PASS] Expected TotalCollections [Gen2] to must be exactly 0.00 collections; actual value was 0.00 collections.

