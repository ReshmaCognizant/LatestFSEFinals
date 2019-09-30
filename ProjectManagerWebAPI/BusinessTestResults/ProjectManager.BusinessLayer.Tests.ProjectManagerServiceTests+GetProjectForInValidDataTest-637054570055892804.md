# ProjectManager.BusinessLayer.Tests.ProjectManagerServiceTests+GetProjectForInValidDataTest
_9/30/2019 4:16:45 PM_
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
|TotalBytesAllocated |           bytes |    2,946,440.00 |    2,946,440.00 |    2,946,440.00 |            0.00 |
|TotalCollections [Gen2] |     collections |            0.00 |            0.00 |            0.00 |            0.00 |
|[Counter] TestingCounter |      operations |            0.00 |            0.00 |            0.00 |            0.00 |

### Per-second Totals
|          Metric |       Units / s |         Max / s |     Average / s |         Min / s |      StdDev / s |
|---------------- |---------------- |---------------- |---------------- |---------------- |---------------- |
|TotalBytesAllocated |           bytes |    3,106,496.68 |    2,957,124.18 |    2,878,282.48 |      129,427.11 |
|TotalCollections [Gen2] |     collections |            0.00 |            0.00 |            0.00 |            0.00 |
|[Counter] TestingCounter |      operations |            0.00 |            0.00 |            0.00 |            0.00 |

### Raw Data
#### TotalBytesAllocated
|           Run # |           bytes |       bytes / s |      ns / bytes |
|---------------- |---------------- |---------------- |---------------- |
|               1 |    2,946,440.00 |    2,886,593.38 |          346.43 |
|               2 |    2,946,440.00 |    3,106,496.68 |          321.91 |
|               3 |    2,946,440.00 |    2,878,282.48 |          347.43 |

#### TotalCollections [Gen2]
|           Run # |     collections | collections / s |ns / collections |
|---------------- |---------------- |---------------- |---------------- |
|               1 |            0.00 |            0.00 |1,020,732,612.52 |
|               2 |            0.00 |            0.00 |  948,476,789.33 |
|               3 |            0.00 |            0.00 |1,023,679,927.88 |

#### [Counter] TestingCounter
|           Run # |      operations |  operations / s | ns / operations |
|---------------- |---------------- |---------------- |---------------- |
|               1 |            0.00 |            0.00 |1,020,732,612.52 |
|               2 |            0.00 |            0.00 |  948,476,789.33 |
|               3 |            0.00 |            0.00 |1,023,679,927.88 |


## Benchmark Assertions

* [FAIL] Expected [Counter] TestingCounter to must be greater than 10,000,000.00 operations; actual value was 0.00 operations.
* [FAIL] Expected TotalBytesAllocated to must be less than or equal to 32,768.00 bytes; actual value was 2,946,440.00 bytes.
* [PASS] Expected TotalCollections [Gen2] to must be exactly 0.00 collections; actual value was 0.00 collections.

