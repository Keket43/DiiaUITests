using System;
using TechTalk.SpecFlow;

namespace DiiaUITests.Steps
{
    [Binding]
    public class SearchSteps
    {
        [When(@"I input ""(.*)"" in search field")]
        public void WhenIInputInSearchField(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
