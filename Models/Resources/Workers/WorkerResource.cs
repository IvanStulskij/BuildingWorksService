﻿using Models.Interfaces;

namespace Models.Resources.Workers
{
    public class WorkerResource : WorkerForm, IResource
    {
        public int Id { get; set; }

        public int PersonnelNumber { get; set; }
    }

    public class WorkerForm
    {
        public string FullName { get; set; }

        public DateTime StartWorkDate { get; set; }

        public DateTime EndWorkDate { get; set; }

        public string WorkerPost { get; set; }

        public int BrigadeId { get; set; }
    }
}
