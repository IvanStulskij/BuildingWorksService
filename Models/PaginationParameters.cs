namespace BuildingWorks.Models
{
    public abstract class PaginationParameters
    {
        public int EntitiesPerPage { get; set; }

        public int CurrentPage { get; set; }
    }
}