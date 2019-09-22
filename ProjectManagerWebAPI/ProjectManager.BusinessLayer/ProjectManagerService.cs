using POPSService.Manager;
using ProjectManager.DataLayer;
using ProjectManager.DataRepository;
using ProjectManager.Shared.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProjectManager.BusinessLayer
{
    public class ProjectManagerService
    {
        public bool AddTask(TaskModel taskModel)
        {
            EntityMapper<TaskModel, Task> mapObj = new EntityMapper<TaskModel, Task>();
            var task = mapObj.Translate(taskModel);
            return ProjectManagerRepository.InsertTask(task);
        }

        public bool AddProject(ProjectModel projectModel)
        {
            EntityMapper<ProjectModel, Project> mapObj = new EntityMapper<ProjectModel, Project>();
            var project = mapObj.Translate(projectModel);
            return ProjectManagerRepository.InsertProject(project);
        }

        public bool AddUser(UserModel userModel)
        {
            EntityMapper<UserModel, User> mapObj = new EntityMapper<UserModel, User>();
            var user = mapObj.Translate(userModel);
            return ProjectManagerRepository.InsertUser(user);
        }

        public bool AddParentTask(ParentTaskModel parentTaskModel)
        {
            EntityMapper<ParentTaskModel, ParentTask> mapObj = new EntityMapper<ParentTaskModel, ParentTask>();
            var parentTask = mapObj.Translate(parentTaskModel);
            return ProjectManagerRepository.InsertParentTask(parentTask);
        }

        public List<TaskModel> GetTasks()
        {
            EntityMapper<Task, TaskModel> mapObj = new EntityMapper<Task, TaskModel>();
            List<Task> taskList = ProjectManagerRepository.GetTasks();
            List<TaskModel> taskModels = new List<TaskModel>();
            foreach (var task in taskList)
            {
                taskModels.Add(mapObj.Translate(task));
            }

            return taskModels;
        }

        public List<UserModel> GetUsers()
        {
            EntityMapper<User, UserModel> mapObj = new EntityMapper<User, UserModel>();
            List<User> userList = ProjectManagerRepository.SearchUsers();
            List<UserModel> userModels = new List<UserModel>();
            foreach (var user in userList)
            {
                userModels.Add(mapObj.Translate(user));
            }

            return userModels;
        }


        public List<ProjectModel> GetProjects()
        {
            EntityMapper<Project, ProjectModel> mapObj = new EntityMapper<Project, ProjectModel>();
            List<Project> projectList = ProjectManagerRepository.GetProjects();
            List<ProjectModel> projectModels = new List<ProjectModel>();
            foreach (var project in projectList)
            {
                projectModels.Add(mapObj.Translate(project));
            }

            return projectModels;
        }

        public List<UserModel> SearchUsers(string searchKeyWord, string sortBy)
        {
            EntityMapper<User, UserModel> mapObj = new EntityMapper<User, UserModel>();
            List<User> userList = ProjectManagerRepository.SearchUsers(searchKeyWord, sortBy);
            List<UserModel> userModels = new List<UserModel>();
            foreach (var user in userList)
            {
                userModels.Add(mapObj.Translate(user));
            }

            return userModels;
        }

        public List<ProjectModel> SearchProjects(string searchKeyWord, string sortBy)
        {
            EntityMapper<Project, ProjectModel> mapObj = new EntityMapper<Project, ProjectModel>();
            List<Project> projectList = ProjectManagerRepository.SearchProjects(searchKeyWord, sortBy);
            List<ProjectModel> projectModels = new List<ProjectModel>();
            foreach (var project in projectList)
            {
                projectModels.Add(mapObj.Translate(project));
            }

            return projectModels;
        }

        public UserModel GetUser(int userID)
        {
            EntityMapper<User, UserModel> mapObj = new EntityMapper<User, UserModel>();
            User user = ProjectManagerRepository.GetUser(userID);
            UserModel userModel = new UserModel();
            userModel = mapObj.Translate(user);
           
            return userModel;
        }

        public ProjectModel GetProject(int projectID)
        {
            EntityMapper<Project, ProjectModel> mapObj = new EntityMapper<Project, ProjectModel>();
            Project project = ProjectManagerRepository.GetProject(projectID);
            ProjectModel projectModel = new ProjectModel();
            projectModel = mapObj.Translate(project);

            return projectModel;
        }

        public TaskModel GetTask(int taskID)
        {
            EntityMapper<Task, TaskModel> mapObj = new EntityMapper<Task, TaskModel>();
            Task task = ProjectManagerRepository.GetTask(taskID);
            TaskModel taskModel = new TaskModel();
            taskModel = mapObj.Translate(task);

            return taskModel;
        }

        public bool UpdateUser(UserModel userModel)
        {
            EntityMapper<UserModel, User> mapObj = new EntityMapper<UserModel, User>();
            var user = mapObj.Translate(userModel);
            return ProjectManagerRepository.UpdateUser(user);
        }

        public bool UpdateProject(ProjectModel projectModel)
        {
            EntityMapper<ProjectModel, Project> mapObj = new EntityMapper<ProjectModel, Project>();
            var project = mapObj.Translate(projectModel);
            return ProjectManagerRepository.UpdateProject(project);
        }

        public bool UpdateTask(TaskModel taskModel)
        {
            EntityMapper<TaskModel, Task> mapObj = new EntityMapper<TaskModel, Task>();
            var task = mapObj.Translate(taskModel);
            return ProjectManagerRepository.UpdateTask(task);
        }
        
        public bool DeleteProject(int projectID)
        {
            return ProjectManagerRepository.DeleteProject(projectID);
        }

        public bool DeleteUser(int userID)
        {
            return ProjectManagerRepository.DeleteUser(userID);
        }        
    }
}
