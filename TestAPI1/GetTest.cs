using NUnit.Framework;
using RA;

namespace TestAPI1
{
    public class GetTest

    {
        [Test]
        public void GET()
        {

            new RestAssured()
              .Given()
              .Name("JsonIP Test Suite")
              .Header("Content-Type", "application/json")
              .Header("Accept", "application/json")
              .Host("localhost")
              .Port(8081)
              .Uri("/demorest/webapi/skeletonsjson/skeleton/101")      
              .When()
              .Get()
              .Then()
              .TestStatus("test status", x=> x == 200)
              .TestBody("test if exists", x => x.id != null)
              .Assert("test status")
              .Assert("test if exists");
        }
    }
}