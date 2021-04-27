using System;
using Xunit;
using People;
public class PeopleTests
{
    [Fact]
    public void PersonTalkToConsole_ReturnsHejSpecialist()
    {
        string expected = "Hello World!";
        string actual = new Person().TalkToPerson();

        Assert.NotEqual(expected, actual);
    }

    [Fact]
    public void PersonTalkToConsole_NotReturnHejSpecialist()
    {
        string expected = "Hello World!";
        string actual = new Person().TalkToPerson();

        Assert.Equal(expected, actual);
    }

}