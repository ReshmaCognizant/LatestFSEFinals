# ProjectManager.BusinessLayer.Tests.ProjectManagerServiceTests+UpdateTaskForValidDataTest
_9/30/2019 4:18:40 PM_
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
|TotalBytesAllocated |           bytes |    2,965,512.00 |    1,548,357.33 |      711,480.00 |    1,233,979.90 |
|TotalCollections [Gen2] |     collections |            0.00 |            0.00 |            0.00 |            0.00 |
|[Counter] TestingCounter |      operations |            0.00 |            0.00 |            0.00 |            0.00 |

### Per-second Totals
|          Metric |       Units / s |         Max / s |     Average / s |         Min / s |      StdDev / s |
|---------------- |---------------- |---------------- |---------------- |---------------- |---------------- |
|TotalBytesAllocated |           bytes |    3,015,009.24 |    1,568,177.86 |      709,610.26 |    1,260,260.62 |
|TotalCollections [Gen2] |     collections |            0.00 |            0.00 |            0.00 |            0.00 |
|[Counter] TestingCounter |      operations |            0.00 |            0.00 |            0.00 |            0.00 |

### Raw Data
#### TotalBytesAllocated
|           Run # |           bytes |       bytes / s |      ns / bytes |
|---------------- |---------------- |---------------- |---------------- |
|               1 |      968,080.00 |      979,914.07 |        1,020.50 |
|               2 |      711,480.00 |      709,610.26 |        1,409.22 |
|               3 |    2,965,512.00 |    3,015,009.24 |          331.67 |

#### TotalCollections [Gen2]
|           Run # |     collections | collections / s |ns / collections |
|---------------- |---------------- |---------------- |---------------- |
|               1 |            0.00 |            0.00 |  987,923,355.84 |
|               2 |            0.00 |            0.00 |1,002,634,889.25 |
|               3 |            0.00 |            0.00 |  983,583,055.26 |

#### [Counter] TestingCounter
|           Run # |      operations |  operations / s | ns / operations |
|---------------- |---------------- |---------------- |---------------- |
|               1 |            0.00 |            0.00 |  987,923,355.84 |
|               2 |            0.00 |            0.00 |1,002,634,889.25 |
|               3 |            0.00 |            0.00 |  983,583,055.26 |


## Benchmark Assertions

* [FAIL] Expected [Counter] TestingCounter to must be greater than 10,000,000.00 operations; actual value was 0.00 operations.
* [FAIL] Expected TotalBytesAllocated to must be less than or equal to 32,768.00 bytes; actual value was 1,548,357.33 bytes.
* [PASS] Expected TotalCollections [Gen2] to must be exactly 0.00 collections; actual value was 0.00 collections.

