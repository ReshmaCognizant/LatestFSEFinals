﻿# ProjectManager.DataLayer.Tests.ProjectManagerRepositoryTests+GetUsersTest
_9/30/2019 3:54:08 PM_
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
|TotalBytesAllocated |           bytes |    1,679,584.00 |    1,679,584.00 |    1,679,584.00 |            0.00 |
|TotalCollections [Gen2] |     collections |            0.00 |            0.00 |            0.00 |            0.00 |
|[Counter] TestingCounter |      operations |            0.00 |            0.00 |            0.00 |            0.00 |

### Per-second Totals
|          Metric |       Units / s |         Max / s |     Average / s |         Min / s |      StdDev / s |
|---------------- |---------------- |---------------- |---------------- |---------------- |---------------- |
|TotalBytesAllocated |           bytes |    1,743,103.64 |    1,608,773.23 |    1,529,114.92 |      117,002.45 |
|TotalCollections [Gen2] |     collections |            0.00 |            0.00 |            0.00 |            0.00 |
|[Counter] TestingCounter |      operations |            0.00 |            0.00 |            0.00 |            0.00 |

### Raw Data
#### TotalBytesAllocated
|           Run # |           bytes |       bytes / s |      ns / bytes |
|---------------- |---------------- |---------------- |---------------- |
|               1 |    1,679,584.00 |    1,743,103.64 |          573.69 |
|               2 |    1,679,584.00 |    1,554,101.12 |          643.46 |
|               3 |    1,679,584.00 |    1,529,114.92 |          653.97 |

#### TotalCollections [Gen2]
|           Run # |     collections | collections / s |ns / collections |
|---------------- |---------------- |---------------- |---------------- |
|               1 |            0.00 |            0.00 |  963,559,457.03 |
|               2 |            0.00 |            0.00 |1,080,743,056.83 |
|               3 |            0.00 |            0.00 |1,098,402,726.69 |

#### [Counter] TestingCounter
|           Run # |      operations |  operations / s | ns / operations |
|---------------- |---------------- |---------------- |---------------- |
|               1 |            0.00 |            0.00 |  963,559,457.03 |
|               2 |            0.00 |            0.00 |1,080,743,056.83 |
|               3 |            0.00 |            0.00 |1,098,402,726.69 |


## Benchmark Assertions

* [FAIL] Expected [Counter] TestingCounter to must be greater than 10,000,000.00 operations; actual value was 0.00 operations.
* [FAIL] Expected TotalBytesAllocated to must be less than or equal to 32,768.00 bytes; actual value was 1,679,584.00 bytes.
* [PASS] Expected TotalCollections [Gen2] to must be exactly 0.00 collections; actual value was 0.00 collections.
