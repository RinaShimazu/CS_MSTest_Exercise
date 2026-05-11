using TargetProject.Chap02;
namespace TestProject.Chap03;
/// <summary>
/// Calculatorクラスに実装されたメソッドの単体テストドライバ
/// [DataTestMethod]/[DataRow]属性の利用
/// </summary>
[TestClass]
public class GreetingServiceDataRowTests
{
    private static TestContext? context;
    [ClassInitialize]
    /// <summary>
    /// すべてのテスト前に1度だけ実行する
    /// </summary>
    /// <param name="context"></param>
    public static void ClassSetup(TestContext _context)
    {
        context = _context;
        context.WriteLine($"ClassSetup:{context.TestName}のテストを開始します。");
    }

    [ClassCleanup]
    /// <summary>
    /// すべてのテスト後に1度だけ実行する
    /// </summary>
    /// <param name="context"></param>
    public static void ClassCleanup()
    {
        context!.WriteLine($"ClassCleanup:{context.TestName}のテストを終了しました。");
    }


    /// <summary>
    /// テストターゲットのCalculatorを格納するフィールド
    /// </summary>
    private GreetingService? greet;
    [TestInitialize]
    /// <summary>
    /// テストメソッド実行前処理
    /// </summary>
    public void SetUp()
    {
        // Arrange（準備）
        // テスト対象のオブジェクトを生成する
        greet = new GreetingService();
    }

    [DataTestMethod]
    [DataRow(7, "Good Morning", DisplayName = "テストケース1:7時")]
    [DataRow(11, "Good Morning", DisplayName = "テストケース2:11時")]
    [DataRow(12, "Hello", DisplayName = "テストケース3:12時")]
    [DataRow(19, "Good Evening", DisplayName = "テストケース4:19時")]


    public void Add_ReturnsExpectedResult(int hour, string? expected)
    {
        // Act（実行）
        // テスト対象のメソッドを実行する
        var result = greet!.Greet(hour);

        // Assert（確認）
        // 実行結果が期待した値と一致するか確認する
        Assert.AreEqual(expected, result);
    }
}