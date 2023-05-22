namespace Tests.Prj1_App;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        //arange
        int myint = 23;
        double myDouble = 23.1200;

        //act
        string return1 = Prj1_AppPlay.TestDemoMethod(myInt, myDouble); // Update the namespace and class references


        //assert
        Assert.Equal();

    }
}