﻿namespace BuildingWorks.Models.Overview
{
    public class WorkerOverview : Overview
    {
        public string FullName { get; set; }

        public DateTime StartWorkDate { get; set; }
        
        public string Post { get; set; }

        public int BrigadeId { get; set; }
    }
}