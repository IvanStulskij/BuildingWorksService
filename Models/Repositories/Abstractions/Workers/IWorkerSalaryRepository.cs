namespace Models.Repositories.Abstractions.Workers
{
    public interface IWorkerSalaryRepository
    {
        float GetObjectTotalSalaries(int objectCode);
    }
}