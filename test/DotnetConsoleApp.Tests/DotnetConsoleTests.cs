using System;
using Xunit;
using People;
using DotnetConsoleApp;

namespace DotnetConsoleAppTest
{

    public class PeopleSmokeTests
    {
        [Fact, Trait("Category", "SmokeTest")]
        public void PersonTalkToConsole_ReturnHejSpecialist()
        {
            string expected = "Hello World!";
            string actual = new Person().TalkToPerson();

            Assert.NotEqual(expected, actual);
        }

    }
    public class PeopleTests
    {
        [Fact, Trait("Category", "FullTest")]
        public void PersonTalkToConsole_NotReturnHejSpecialist()
        {
            string expected = "Hej Specialist nr1!";
            string actual = new Person().TalkToPerson();

            Assert.Equal(expected, actual);
        }

        [Fact, Trait("Category", "FullTest")]
        public void IsPrime_ReturnTrue()
        {

            var primeService = new PrimeService();
            bool result = primeService.IsPrime(1);

            Assert.False(result, "1 should not be prime");
        }

    }
}