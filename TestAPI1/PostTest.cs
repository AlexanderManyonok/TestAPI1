using NUnit.Framework;
using RA;

namespace TestAPI1
{
    public class PostTest
    {
        [Test]
        public void POST()
        {
            var body = new
            {
                id = 108,
                name = "kavo",
                points = 95
            };
            new RestAssured()
              .Given()
              .Name("JsonIP Test Sui1te")
              .Header("Content-Type", "application/json")
              .Body(body)
              .Host("localhost")
              .Port(8081)
              .Uri("/demorest/webapi/skeletonsjson/skeleton/")
              .When()
              .Post()
              .Then()
              .TestStatus("test status", x => x == 200)
              .TestBody("test if exists", x => x.id != null)
              .Assert("test status")
              .Assert("test if exists")
              .Debug();
        }
    }
}