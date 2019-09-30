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
    public class ProjectControllerTests
    {
        private const string ServiceBaseURL = "http://localhost:61012/";

        [PerfBenchmark(NumberOfIterations = 3, RunMode = RunMode.Throughput, RunTimeMilliseconds = 1000, TestMode = TestMode.Test)]
        [CounterThroughputAssertion("TestingCounter", MustBe.GreaterThan, 10000000.0d)]
        [MemoryAssertion(MemoryMetric.TotalBytesAllocated, MustBe.LessThanOrEqualTo, ByteConstants.ThirtyTwoKb)]
        [GcTotalAssertion(GcMetric.TotalCollections, GcGeneration.Gen2, MustBe.ExactlyEqualTo, 0.0d)]
        [Test]
        public void GetTest()
        {
            var projectController = new ProjectController()
            {
                Request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(ServiceBaseURL)
                }
            };
            projectController.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());
            var httpActionResult = (HttpResponseMessage)projectController.Get();
            var responseResult = JsonConvert.DeserializeObject<List<ProjectModel>>(httpActionResult.Content.ReadAsStringAsync().Result);
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
            var projectController = new ProjectController()
            {
                Request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(ServiceBaseURL)
                }
            };
            projectController.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());
            var httpActionResult = (HttpResponseMessage)projectController.Search(1);
            var responseResult = JsonConvert.DeserializeObject<ProjectModel>(httpActionResult.Content.ReadAsStringAsync().Result);
            Assert.AreEqual(httpActionResult.StatusCode, HttpStatusCode.OK);
        }

        [PerfBenchmark(NumberOfIterations = 3, RunMode = RunMode.Throughput, RunTimeMilliseconds = 1000, TestMode = TestMode.Test)]
        [CounterThroughputAssertion("TestingCounter", MustBe.GreaterThan, 10000000.0d)]
        [MemoryAssertion(MemoryMetric.TotalBytesAllocated, MustBe.LessThanOrEqualTo, ByteConstants.ThirtyTwoKb)]
        [GcTotalAssertion(GcMetric.TotalCollections, GcGeneration.Gen2, MustBe.ExactlyEqualTo, 0.0d)]
        [Test]
        public void PostTest()
        {
            var project = new ProjectModel()
            {
                Project_ID = 1,
                ProjectName = "Microsoft",
                Start_Date = null,
                End_Date = null,
                Priority = 1
            };

            var projectController = new ProjectController()
            {
                Request = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri(ServiceBaseURL)
                }
            };
            projectController.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());
            var httpActionResult = (HttpResponseMessage)projectController.Post(project);
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
            var project = new ProjectModel()
            {
                Project_ID = 1,
                ProjectName = "Bosch",
                Start_Date = null,
                End_Date = null,
                Priority = 1
            };

            var projectController = new ProjectController()
            {
                Request = new HttpRequestMessage
                {
                    Method = HttpMethod.Put,
                    RequestUri = new Uri(ServiceBaseURL)
                }
            };
            projectController.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());
            var httpActionResult = (HttpResponseMessage)projectController.Put(project);
            var responseResult = JsonConvert.DeserializeObject<bool>(httpActionResult.Content.ReadAsStringAsync().Result);
            Assert.AreEqual(httpActionResult.StatusCode, HttpStatusCode.OK);
            Assert.IsTrue(responseResult);
        }
    }
}
