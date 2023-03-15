using AutoMapper;

namespace BuildingWorks.Profilers.Profilers
{
    public abstract class BaseProfiler<T, TForm, TResource> : Profile
    {
        public BaseProfiler()
        {
            CreateMap<T, TForm>().ReverseMap();
            CreateMap<T, TResource>().ReverseMap();
        }
    }

    public abstract class BaseOverviewProfiler<T, TForm, TResource, TOverview> : BaseProfiler<T, TForm, TResource>
    {
        public BaseOverviewProfiler()
        {
            CreateMap<T, TForm>().ReverseMap();
            CreateMap<T, TResource>().ReverseMap();
            ConfigureOverviewProfiling();
        }

        protected virtual void ConfigureOverviewProfiling()
        {
            CreateMap<T, TOverview>().ReverseMap();
        }
    }
}