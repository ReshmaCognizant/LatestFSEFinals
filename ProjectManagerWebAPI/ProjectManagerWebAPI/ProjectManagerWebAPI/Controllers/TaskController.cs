﻿using ProjectManager.BusinessLayer;
using ProjectManager.Shared.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProjectManagerWebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/task")]
    public class TaskController : BaseAPIController
    {
        [Route("get")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            return tryCatchWebMethod(() =>
            {
                var tasks = new ProjectManagerService().GetTasks();
                
                return Json(tasks);
            });
        }

        [Route("search/{taskID}")]
        [HttpGet]
        public IHttpActionResult Search(int taskID)
        {
            return tryCatchWebMethod(() =>
            {
                var task = new ProjectManagerService().GetTask(taskID);

                return Json(task);
            });
        }

        [Route("add")]
        [HttpPost]
        public IHttpActionResult Post([FromBody]TaskModel taskModel)
        {
            return tryCatchWebMethod(() =>
            {
                var isSuccess = new ProjectManagerService().AddTask(taskModel);

                return Json(isSuccess);
            });
        }

        [Route("update")]
        [HttpPut]
        public IHttpActionResult Put([FromBody]TaskModel taskModel)
        {
            return tryCatchWebMethod(() =>
            {
                var isSuccess = new ProjectManagerService().UpdateTask(taskModel);
                
                return Json(isSuccess);
            });
        }        
    }
}