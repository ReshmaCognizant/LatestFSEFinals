# ProjectManager.DataLayer.Tests.ProjectManagerRepositoryTests+InsertParentTaskForInValidDataTest
_9/30/2019 3:53:22 PM_
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
|TotalBytesAllocated |           bytes |   11,395,984.00 |    9,596,506.67 |    8,348,760.00 |    1,596,777.56 |
|TotalCollections [Gen2] |     collections |            1.00 |            0.67 |            0.00 |            0.58 |
|[Counter] TestingCounter |      operations |            0.00 |            0.00 |            0.00 |            0.00 |

### Per-second Totals
|          Metric |       Units / s |         Max / s |     Average / s |         Min / s |      StdDev / s |
|---------------- |---------------- |---------------- |---------------- |---------------- |---------------- |
|TotalBytesAllocated |           bytes |   10,934,433.07 |    9,214,338.85 |    7,974,775.43 |    1,537,229.89 |
|TotalCollections [Gen2] |     collections |            0.97 |            0.64 |            0.00 |            0.55 |
|[Counter] TestingCounter |      operations |            0.00 |            0.00 |            0.00 |            0.00 |

### Raw Data
#### TotalBytesAllocated
|           Run # |           bytes |       bytes / s |      ns / bytes |
|---------------- |---------------- |---------------- |---------------- |
|               1 |    9,044,776.00 |    8,733,808.06 |          114.50 |
|               2 |    8,348,760.00 |    7,974,775.43 |          125.40 |
|               3 |   11,395,984.00 |   10,934,433.07 |           91.45 |

#### TotalCollections [Gen2]
|           Run # |     collections | collections / s |ns / collections |
|---------------- |---------------- |---------------- |---------------- |
|               1 |            1.00 |            0.97 |1,035,605,080.27 |
|               2 |            1.00 |            0.96 |1,046,895,937.89 |
|               3 |            0.00 |            0.00 |1,042,210,778.00 |

#### [Counter] TestingCounter
|           Run # |      operations |  operations / s | ns / operations |
|---------------- |---------------- |---------------- |---------------- |
|               1 |            0.00 |            0.00 |1,035,605,080.27 |
|               2 |            0.00 |            0.00 |1,046,895,937.89 |
|               3 |            0.00 |            0.00 |1,042,210,778.00 |


## Benchmark Assertions

* [FAIL] Expected [Counter] TestingCounter to must be greater than 10,000,000.00 operations; actual value was 0.00 operations.
* [FAIL] Expected TotalBytesAllocated to must be less than or equal to 32,768.00 bytes; actual value was 9,596,506.67 bytes.
* [FAIL] Expected TotalCollections [Gen2] to must be exactly 0.00 collections; actual value was 0.67 collections.

