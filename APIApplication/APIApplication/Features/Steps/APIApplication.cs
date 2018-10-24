using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace APIApplication.Features.Steps
{
    [Binding]
    public sealed class APIApplication
    {
        [Given(@"I have an endpoint (.*)")]
        public void GivenIHaveAnEndpointEndpoint(string endpoint)
        {
            RestApiHelper.SetUrl(endpoint);
        }

        [When(@"I call get method of the API")]
        public void WhenICallGetMethodOfTheAPI()
        {
            RestApiHelper.CreateRequest();
        }

        [Then(@"I get the API response in json format")]
        public void ThenIGetTheAPIResponseInJsonFormat()
        {
            var expected = "something";
            var response = RestApiHelper.GetResponse();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Assert.That(response.Content, Is.EqualTo(expected), "Error Message");
            }
        }

    }
}
