using TargetProject.Chap02;
/// <summary>
/// Calculatorクラスに実装されたメソッドの単体テストドライバ
/// </summary>
namespace TestProject.Chap02;

[TestClass]
public class GreetingServiceTests
{
    [TestMethod("テストケース1:7時ではGood Morningを返す")]
    public void Greet_ShouldReturnGM_WhenMorning()
    {
        // Arrange(準備)
        var greet = new GreetingService();
        int hour = 7;
        // Act(実行)
        var result = greet.Greet(hour);
        // Assert(確認)
        Assert.AreEqual("Good Morning", result);
    }
    [
        TestMethod("テストケース2:12時ではHelloを返す")]
    public void Greet_ShouldReturnHello_WhenNoon()
    {
        // Arrange(準備)
        var greet = new GreetingService();
        int hour = 12;
        // Act(実行)
        var result = greet.Greet(hour);
        // Assert(確認)
        Assert.AreEqual("Hello", result);
    }
}