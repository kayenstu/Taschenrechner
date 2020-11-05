using System;
using TechTalk.SpecFlow;
using Xunit;

namespace TrigonometrischeFunktionen
{
    [Binding]
    public class TrigonometricFunctionsSteps
    {
        double result;

        double angle;

        [Given(@"the angle is (.*)")]
        public void GivenTheAngleIs(double p0)
        {
            angle = p0;
        }

        [When(@"the sine function is chosen")]
        public void WhenTheSineFunctionIsChosen()
        {
            result = Math.Sin(angle);
        }

        [When(@"the cosine function is chosen")]
        public void WhenTheCosineFunctionIsChosen()
        {
            result = Math.Cos(angle);
        }

        [When(@"the tangen function is chosen")]
        public void WhenTheTangenFunctionIsChosen()
        {
            result = Math.Tan(angle);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(double p0)
        {
            double expected = p0;
            double actual = result;
            Assert.Equal(expected, result, 5);

        }
    }
}
