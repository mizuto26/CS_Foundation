/// <summary>
/// 独自例外クラス
/// </summary>
public class MyException : Exception
{
    /// <summary>
    /// アプリケーション独自のエラーコード
    /// </summary>
    private string appErrorCode;
    public string AppErrorCode
    {
        get { return appErrorCode; }
    }
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    public MyException(string message)
    : base(message)
    {
    }
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="AppErrorCode">アプリケーション独自のエラーコード</param>
    /// <param name="message">エラーメッセージ</param>
    public MyException(string AppErrorCode, string message)
    : this(message)
    {
        this.appErrorCode = AppErrorCode;
    }
}