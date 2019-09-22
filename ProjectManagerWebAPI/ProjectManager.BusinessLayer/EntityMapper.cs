using AutoMapper;
using ProjectManager.DataLayer;
using ProjectManager.Shared.ServiceContracts;

namespace ProjectManager.BusinessLayer
{
    public class EntityMapper<TSource, TDestination> where TSource : class where TDestination : class
    {
        public EntityMapper()
        {
            Mapper.CreateMap<ProjectModel, Project>();
            Mapper.CreateMap<ParentTaskModel, ParentTask>();
            Mapper.CreateMap<UserModel, User>();
            Mapper.CreateMap<TaskModel, Task>();
        }
        public TDestination Translate(TSource obj)
        {
            return Mapper.Map<TDestination>(obj);
        }
    }
}
