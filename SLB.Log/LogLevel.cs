namespace SLB.Log
{
    /// <summary>
    /// General log level set.
    /// Reason of "duplicating" this here is escaping from exposing any class/type of particular log provider implementation 
    /// </summary>
    public enum LogLevel
    {
        Verbose,
        Debug,
        Information,
        Warning,
        Error,
        Fatal
    }
}
