namespace Models
{
    public class PlanCompletePercent
    {
        private readonly float _totalAmount;
        private readonly float _completeAmount;

        public PlanCompletePercent(float totalAmount, float completeAmount)
        {
            _totalAmount = totalAmount;
            _completeAmount = completeAmount;
        }

        public float Count()
        {
            return _completeAmount / _totalAmount;
        }
    }
}
