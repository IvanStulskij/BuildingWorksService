namespace BuildingWorks.Models.RequestParameters
{
    public abstract class RequestParameters
    {
        public const int MaxPageSize = 20;
        public int PageNumber { get; set; }

        private int _pageSize = 10;
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
            }
        }
    }
}
