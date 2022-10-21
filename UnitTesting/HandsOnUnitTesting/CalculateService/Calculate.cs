namespace CalculateService
{
    public class Calculate
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
        public int Mul(int a,int b)
        {
            return a * b;
        }
        public int Sub(int a,int b)
        {
            return a - b;
        }
        public int Div(int a,int b)
        {
            return a / b;
        }
        public List<int> GetNumbers()
        {
            return new List<int>() { 12, 23, 34, 45, 56, 67 };
        }
    }
}