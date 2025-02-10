namespace Tvdb.Models;

/// <summary>
/// Api Exception for TVDB
/// </summary>
[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public class ApiException(string message, int statusCode, string response, IReadOnlyDictionary<string, IEnumerable<string>> headers, Exception innerException) 
    : Exception(message + "\n\nStatus: " + statusCode + "\nResponse: \n" + ((response == null) ? "(null)" : response.Substring(0, response.Length >= 512 ? 512 : response.Length)), innerException)
{
    #region Properties
    /// <summary>
    /// Http Status Code
    /// </summary>
    public int StatusCode { get; private set; } = statusCode;

    /// <summary>
    /// Response from the API
    /// </summary>
    public string Response { get; private set; } = response;

    /// <summary>
    /// Headers from the API
    /// </summary>
    public IReadOnlyDictionary<string, IEnumerable<string>> Headers { get; private set; } = headers;
    #endregion

    #region Methods
    /// <summary>
    /// Override of <see cref="object.ToString"/> to provide a more detailed output
    /// </summary>
    /// <returns></returns>
    public override string ToString() => string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
    #endregion
}

/// <summary>
/// Api Exception for TVDB with a <typeparamref name="TResult"/>
/// </summary>
/// <typeparam name="TResult"></typeparam>
[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public class ApiException<TResult>(string message, int statusCode, string response, IReadOnlyDictionary<string, IEnumerable<string>> headers, TResult result, Exception innerException) : ApiException(message, statusCode, response, headers, innerException)
{
    #region Properties
    /// <summary>
    /// Result of the API Call
    /// </summary>
    public TResult Result { get; private set; } = result;
    #endregion
}