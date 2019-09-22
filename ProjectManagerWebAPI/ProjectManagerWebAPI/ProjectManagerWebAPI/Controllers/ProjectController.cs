using ProjectManager.BusinessLayer;
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
    [RoutePrefix("api/project")]
    public class ProjectController : BaseAPIController
    {        
            [Route("get")]
            [HttpGet]
            public IHttpActionResult Get()
            {
                return tryCatchWebMethod(() =>
                {
                    var projects = new ProjectManagerService().GetProjects();

                    return Json(projects);
                });
            }

            [Route("search/{projectID}")]
            [HttpGet]
            public IHttpActionResult Search(int projectID)
            {
                return tryCatchWebMethod(() =>
                {
                    var project = new ProjectManagerService().GetProject(projectID);

                    return Json(project);
                });
            }

            [Route("searchProjects/{searchKeyWord}/{sortBy}")]
            [HttpGet]
            public IHttpActionResult SearchProjects(string searchKeyWord, string sortBy)
            {
                return tryCatchWebMethod(() =>
                {
                    var project = new ProjectManagerService().SearchProjects(searchKeyWord, sortBy);

                    return Json(project);
                });
            }

            [Route("add")]
            [HttpPost]
            public IHttpActionResult Post([FromBody]ProjectModel projectModel)
            {
                return tryCatchWebMethod(() =>
                {
                    var isSuccess = new ProjectManagerService().AddProject(projectModel);
                    
                    return Json(isSuccess);
                });
            }

            [Route("update")]
            [HttpPut]
            public IHttpActionResult Put([FromBody]ProjectModel projectModel)
            {
                return tryCatchWebMethod(() =>
                {
                    var isSuccess = new ProjectManagerService().UpdateProject(projectModel);
                    
                    return Json(isSuccess);
                });
            }

            [Route("delete/{projectID}")]
            [HttpDelete]
            public IHttpActionResult Delete(int projectID)
            {
                return tryCatchWebMethod(() =>
                {
                    var isSuccess = new ProjectManagerService().DeleteProject(projectID);
                    
                    return Json(isSuccess);
                });
            }
        }
    
}
