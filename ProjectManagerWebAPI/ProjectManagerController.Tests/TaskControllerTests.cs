using System;
using NUnit.Framework;
using System.Net.Http;
using ProjectManagerWebAPI.Controllers;
using System.Web.Http;
using System.Web.Http.Hosting;
using ProjectManager.Shared.ServiceContracts;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net;
using System.Linq;
using NBench;

namespace ProjectManagerController.Tests
{
    [TestFixture]
    public class TaskControllerTests
    {
        private const string ServiceBaseURL = "http://localhost:50875/";

        [PerfBenchmark(NumberOfIterations = 3, RunMode = RunMode.Throughput, RunTimeMilliseconds = 1000, TestMode = TestMode.Test)]
        [CounterThroughputAssertion("TestingCounter", MustBe.GreaterThan, 10000000.0d)]
        [MemoryAssertion(MemoryMetric.TotalBytesAllocated, MustBe.LessThanOrEqualTo, ByteConstants.ThirtyTwoKb)]
        [GcTotalAssertion(GcMetric.TotalCollections, GcGeneration.Gen2, MustBe.ExactlyEqualTo, 0.0d)]
        [Test]
        public void GetTest()
        {
            var taskController = new TaskController()
            {
                Request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(ServiceBaseURL)
                }
            };
            taskController.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());
            var httpActionResult = (HttpResponseMessage)taskController.Get();
            var responseResult = JsonConvert.DeserializeObject<List<TaskModel>>(httpActionResult.Content.ReadAsStringAsync().Result);
            Assert.AreEqual(httpActionResult.StatusCode, HttpStatusCode.OK);
            Assert.AreEqual(responseResult.Any(), true);
        }

        [PerfBenchmark(NumberOfIterations = 3, RunMode = RunMode.Throughput, RunTimeMilliseconds = 1000, TestMode = TestMode.Test)]
        [CounterThroughputAssertion("TestingCounter", MustBe.GreaterThan, 10000000.0d)]
        [MemoryAssertion(MemoryMetric.TotalBytesAllocated, MustBe.LessThanOrEqualTo, ByteConstants.ThirtyTwoKb)]
        [GcTotalAssertion(GcMetric.TotalCollections, GcGeneration.Gen2, MustBe.ExactlyEqualTo, 0.0d)]
        [Test]
        public void SearchTest()
        {
            var taskController = new TaskController()
            {
                Request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(ServiceBaseURL)
                }
            };
            taskController.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());
            var httpActionResult = (HttpResponseMessage)taskController.Search(1);
            var responseResult = JsonConvert.DeserializeObject<TaskModel>(httpActionResult.Content.ReadAsStringAsync().Result);
            Assert.AreEqual(httpActionResult.StatusCode, HttpStatusCode.OK);           
        }

        [PerfBenchmark(NumberOfIterations = 3, RunMode = RunMode.Throughput, RunTimeMilliseconds = 1000, TestMode = TestMode.Test)]
        [CounterThroughputAssertion("TestingCounter", MustBe.GreaterThan, 10000000.0d)]
        [MemoryAssertion(MemoryMetric.TotalBytesAllocated, MustBe.LessThanOrEqualTo, ByteConstants.ThirtyTwoKb)]
        [GcTotalAssertion(GcMetric.TotalCollections, GcGeneration.Gen2, MustBe.ExactlyEqualTo, 0.0d)]
        [Test]
        public void PostTest()
        {
            var task = new TaskModel()
            {
                Task_ID = 1,
                TaskName = "Generate Scripts",
                Parent_ID = 1,
                Project_ID = 1,
                Start_Date = DateTime.Now,
                End_Date = DateTime.Now.AddDays(1),
                Priority = 1,
                Status = true
            };

            var taskController = new TaskController()
            {
                Request = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri(ServiceBaseURL)
                }
            };
            taskController.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());
            var httpActionResult = (HttpResponseMessage)taskController.Post(task);
            var responseResult = JsonConvert.DeserializeObject<bool>(httpActionResult.Content.ReadAsStringAsync().Result);
            Assert.AreEqual(httpActionResult.StatusCode, HttpStatusCode.OK);
            Assert.IsTrue(responseResult);
        }

        [PerfBenchmark(NumberOfIterations = 3, RunMode = RunMode.Throughput, RunTimeMilliseconds = 1000, TestMode = TestMode.Test)]
        [CounterThroughputAssertion("TestingCounter", MustBe.GreaterThan, 10000000.0d)]
        [MemoryAssertion(MemoryMetric.TotalBytesAllocated, MustBe.LessThanOrEqualTo, ByteConstants.ThirtyTwoKb)]
        [GcTotalAssertion(GcMetric.TotalCollections, GcGeneration.Gen2, MustBe.ExactlyEqualTo, 0.0d)]
        [Test]
        public void PutTest()
        {
            var task = new TaskModel()
            {
                Task_ID = 1,
                TaskName = "Deploy",
                Parent_ID = 1,
                Project_ID = 1,
                Start_Date = DateTime.Now,
                End_Date = DateTime.Now.AddDays(1),
                Priority = 1,
                Status = true
            };

            var taskController = new TaskController()
            {
                Request = new HttpRequestMessage
                {
                    Method = HttpMethod.Put,
                    RequestUri = new Uri(ServiceBaseURL)
                }
            };
            taskController.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());
            var httpActionResult = (HttpResponseMessage)taskController.Put(task);
            var responseResult = JsonConvert.DeserializeObject<bool>(httpActionResult.Content.ReadAsStringAsync().Result);
            Assert.AreEqual(httpActionResult.StatusCode, HttpStatusCode.OK);
            Assert.IsTrue(responseResult);
        }        
    }
}
