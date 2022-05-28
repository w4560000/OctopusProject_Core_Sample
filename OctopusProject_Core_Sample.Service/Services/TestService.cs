using OctopusProject_Core_Sample.Repository;

namespace OctopusProject_Core_Sample.Service
{
    public class TestService : ITestService
    {
        private readonly ITestRepository _testRepository;

        public TestService(
            ITestRepository testRepository)
        {
            _testRepository = testRepository;
        }

        public string Test()
        {
            return $"{nameof(TestService)} {_testRepository.Test()}";
        }
    }
}