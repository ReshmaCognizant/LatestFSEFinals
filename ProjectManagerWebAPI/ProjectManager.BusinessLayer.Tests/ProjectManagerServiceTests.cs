using NUnit.Framework;
using ProjectManager.Shared.ServiceContracts;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectManager.BusinessLayer;

namespace ProjectManager.BusinessLayer.Tests
{
    [TestFixture]
    public class ProjectManagerServiceTests
    {
        public ProjectManagerService _projectManagerService;

        public ProjectManagerServiceTests()
        {
            _projectManagerService = new ProjectManagerService();
        }

        [Test]
        public bool AddTaskForValidData()
        {
            var validData = new TaskModel()
            {
                Task_ID = 1,
                TaskName = "Generate Scripts",
                Parent_ID = null,
                Project_ID = 1,

            }
            _projectManagerService.AddTask();
        }

        [Test]
        public bool AddTaskForInValidData()
        {
            
        }

        public bool AddTaskForNull()
        {
            
        }

        public bool AddTaskForNull(TaskModel taskModel)
        {
            EntityMapper<TaskModel, Task> mapObj = new EntityMapper<TaskModel, Task>();
            var task = mapObj.Translate(taskModel);
            return ProjectManagerRepository.InsertTask(task);
        }

        [Test]
        public bool AddProject(ProjectModel projectModel)
        {
            EntityMapper<ProjectModel, Project> mapObj = new EntityMapper<ProjectModel, Project>();
            var project = mapObj.Translate(projectModel);
            return ProjectManagerRepository.InsertProject(project);
        }

        [Test]
        public bool AddUser(UserModel userModel)
        {
            EntityMapper<UserModel, User> mapObj = new EntityMapper<UserModel, User>();
            var user = mapObj.Translate(userModel);
            return ProjectManagerRepository.InsertUser(user);
        }

        [Test]
        public bool AddParentTask(ParentTaskModel parentTaskModel)
        {
            EntityMapper<ParentTaskModel, ParentTask> mapObj = new EntityMapper<ParentTaskModel, ParentTask>();
            var parentTask = mapObj.Translate(parentTaskModel);
            return ProjectManagerRepository.InsertParentTask(parentTask);
        }

        [Test]
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

        [Test]
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

        [Test]
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

        [Test]
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

        [Test]
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

        [Test]
        public UserModel GetUser(int userID)
        {
            EntityMapper<User, UserModel> mapObj = new EntityMapper<User, UserModel>();
            User user = ProjectManagerRepository.GetUser(userID);
            UserModel userModel = new UserModel();
            userModel = mapObj.Translate(user);

            return userModel;
        }

        [Test]
        public ProjectModel GetProject(int projectID)
        {
            EntityMapper<Project, ProjectModel> mapObj = new EntityMapper<Project, ProjectModel>();
            Project project = ProjectManagerRepository.GetProject(projectID);
            ProjectModel projectModel = new ProjectModel();
            projectModel = mapObj.Translate(project);

            return projectModel;
        }

        [Test]
        public TaskModel GetTask(int taskID)
        {
            EntityMapper<Task, TaskModel> mapObj = new EntityMapper<Task, TaskModel>();
            Task task = ProjectManagerRepository.GetTask(taskID);
            TaskModel taskModel = new TaskModel();
            taskModel = mapObj.Translate(task);

            return taskModel;
        }

        [Test]
        public bool UpdateUser(UserModel userModel)
        {
            EntityMapper<UserModel, User> mapObj = new EntityMapper<UserModel, User>();
            var user = mapObj.Translate(userModel);
            return ProjectManagerRepository.UpdateUser(user);
        }

        [Test]
        public bool UpdateProject(ProjectModel projectModel)
        {
            EntityMapper<ProjectModel, Project> mapObj = new EntityMapper<ProjectModel, Project>();
            var project = mapObj.Translate(projectModel);
            return ProjectManagerRepository.UpdateProject(project);
        }

        [Test]
        public bool UpdateTask(TaskModel taskModel)
        {
            EntityMapper<TaskModel, Task> mapObj = new EntityMapper<TaskModel, Task>();
            var task = mapObj.Translate(taskModel);
            return ProjectManagerRepository.UpdateTask(task);
        }

        [Test]
        public bool DeleteProject(int projectID)
        {
            return ProjectManagerRepository.DeleteProject(projectID);
        }

        [Test]
        public bool DeleteUser(int userID)
        {
            return ProjectManagerRepository.DeleteUser(userID);
        }
    }
}
