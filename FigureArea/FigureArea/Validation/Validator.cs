namespace Core.Validation
{
    internal class Validator
    {
        public bool IsValid => _isValid;

        private bool _isValid = true;

        public Validator IsPositive(double value)
        {
            if (value < 0)
            {
                _isValid = false;
            }

            return this;
        }

        public Validator IsTriangle(double sideA, double sideB, double sideC)
        {
            if (sideA > sideB + sideC ||
                sideB > sideA + sideC ||
                sideC > sideA + sideB)
                {
                    _isValid = false;
                }

            return this;
        }
    }
}
