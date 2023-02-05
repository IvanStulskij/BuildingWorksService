﻿using AutoMapper;
using BuildingWorks.Databasable.Entities.Plans;
using BuildingWorks.Models.Resources.Plans;

namespace BuildingWorks.Profilers.Profilers.Plans
{
    public class PlanDetailsProfiler : Profile
    {
        public PlanDetailsProfiler()
        {
            CreateMap<PlanDetail, PlanDetailResource>().ReverseMap();
            CreateMap<PlanDetail, PlanDetailForm>().ReverseMap();
        }
    }
}
