using AutoMapper;
using ProjectManager.DataLayer;
using ProjectManager.Shared.ServiceContracts;

namespace ProjectManager.BusinessLayer
{
    public class EntityMapper <TSource, TDestination> where TSource : class where TDestination : class
    {
        MapperConfiguration _mapperConfiguration;

        public EntityMapper()
        {
            _mapperConfiguration = new MapperConfiguration(cfg => {
                cfg.CreateMap<ProjectModel, Project>();
                cfg.CreateMap<ParentTaskModel, ParentTask>();
                cfg.CreateMap<UserModel, User>();
                cfg.CreateMap<TaskModel, Task>();
            });           
        }

        public TDestination Translate(TSource obj)
        {
            var mapper = _mapperConfiguration.CreateMapper();
            return mapper.Map<TDestination>(obj);
        }
    }
}
