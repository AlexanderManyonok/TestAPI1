using NUnit.Framework;
using RA;

namespace TestAPI1
{
    class DeleteTest
    {
        [Test]
        public void POST()
        {
           
            new RestAssured()
              .Given()
              .Name("JsonIP Test Sui1te")
              .Header("Content-Type", "application/json")
              .Host("localhost")
              .Port(8081)
              .Uri("/demorest/webapi/skeletonsjson/skeleton/106")
              .When()
              .Delete()
              .Then()
              .TestStatus("test status", x => x == 200)
              .TestBody("test if exists", x => x.id != null)
              .Assert("test status")
              .Assert("test if exists")
              .Debug();
        }
    }
}
