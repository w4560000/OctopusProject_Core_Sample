namespace OctopusProject_Core_Sample.Repository
{
    public class TestRepository : ITestRepository
    {
        public string Test()
        {
            return nameof(TestRepository);
        }
    }
}