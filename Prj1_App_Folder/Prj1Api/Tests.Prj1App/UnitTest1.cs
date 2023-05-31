using Prj1ApiBusiness;
using Prj1ApiModels;

namespace Tests.Prj1_App;

public class UnitTest1
{
   // private readonly static Customer c1 = new Customer("Ishmael", "Primus");
    // Facts are tests which are always true, zero arguments
    [Fact]
    public void DemoMethodReturnsConcatenatedString1()
    {
        // arrange 
        int myint = 23;
        double myDouble = 23.102031;
        string expected = "23 23.102031";


        // act
        string return1 = Prj1_AppPlay.TestDemoMethod(myint, myDouble);

        // assert
        Assert.Equal(expected, return1);
    }

    // Theory which is multiple tests with different inputs
    [Theory]
    [InlineData(Int32.MaxValue, Double.MaxValue, "2147483647 1.7976931348623157E+308")]
    [InlineData(Int32.MinValue, Double.MinValue, "-2147483648 -1.7976931348623157E+308")]
    [InlineData(Int32.MaxValue, Double.MinValue, "2147483647 -1.7976931348623157E+308")]
    public void DemoMethodReturnsConcatenatedString2(int myint, double myDouble, string expected)
    {
        // arrange 
        // done in [InlineData]

        // act
        string return1 = Prj1_AppPlay.TestDemoMethod(myint, myDouble);

        // assert
        Assert.Equal(expected, return1);
    }

    [Fact]
    public void RegisterPlayerReturnsCorrectPlayerObject()
    {
        // arrange 
        string expected = "Primus";

        // act
        Customer actual = Prj1_AppPlay.RegisterCustomer("Ishmael");

        // assert
        Assert.Equal(expected, actual.Lname);

    }
}