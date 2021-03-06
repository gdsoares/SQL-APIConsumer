using SQLAPI_Consumer;
using System;
using System.Data.SqlTypes;

/// <summary>
/// Generic Post Api Consumer thought CLR Proc
/// </summary>
public partial class StoredProcedures
{
    /// <summary>
    /// It's a generic procedure used to consume Api throught POST method.
    /// It could either returns a result or not.
    /// </summary>
    /// <param name="URL">Consumer POST Method of Api</param>
    /// <param name="JsonBody">Json to be sent as body</param>
    [Microsoft.SqlServer.Server.SqlProcedure]
    public static void APICaller_POST(SqlString URL, SqlString JsonBody)
    {
        try
        {
            string Result = APIConsumer.POSTMethod(URL.ToString(), JsonBody.ToString());

            Helper.SendResultValue("Result", Result);

        }
        catch (Exception ex)
        {
            Helper.SendResultValue("Error", ex.Message.ToString());
        }
    }

    /// <summary>
    /// It's a generic procedure used to consume Api throught POST method.
    /// It could either returns a result or not.
    /// </summary>
    /// <param name="URL">Consumer POST Method of Api</param>
    /// <param name="Authorization">Authorization Header</param>
    /// <param name="JsonBody">Json to be sent as body</param>
    [Microsoft.SqlServer.Server.SqlProcedure]
    public static void APICaller_POST_Auth(SqlString URL, SqlString Authorization, SqlString JsonBody)
    {
        try
        {
            string Result = APIConsumer.POSTMethod(URL.ToString(), JsonBody.ToString(), Authorization.ToString());

            Helper.SendResultValue("Result", Result);

        }
        catch (Exception ex)
        {
            Helper.SendResultValue("Error", ex.Message.ToString());
        }
    }

    /// <summary>
    /// It's a generic procedure used to consume Api throught POST method.
    /// It could either returns a result or not.
    /// </summary>
    /// <param name="URL">Consumer POST Method of Api</param>
    /// <param name="Headers">Authorization Header</param>
    /// <param name="JsonBody">Json to be sent as body</param>
    [Microsoft.SqlServer.Server.SqlProcedure]
    public static void APICaller_POST_JsonBody_Headers(SqlString URL, SqlString Headers, SqlString JsonBody)
    {
        try
        {
            string Result = APIConsumer.POSTMethod_Header(URL.ToString(), JsonBody.ToString(), Headers.ToString());

            Helper.SendResultValue("Result", Result);

        }
        catch (Exception ex)
        {
            Helper.SendResultValue("Error", ex.Message.ToString());
        }
    }

    /// <summary>
    /// It's a generic procedure used to consume Api throught POST method.
    /// It could either returns a result or not.
    /// </summary>
    /// <param name="URL">Consumer POST Method of Api</param>
    /// <param name="Headers">Authorization Header</param>
    [Microsoft.SqlServer.Server.SqlProcedure]
    public static void APICaller_POST_Headers(SqlString URL, SqlString Headers)
    {
        try
        {
            string Result = APIConsumer.POSTMethod_Header(URL.ToString(), Headers.ToString());

            Helper.SendResultValue("Result", Result);

        }
        catch (Exception ex)
        {
            Helper.SendResultValue("Error", ex.Message.ToString());
        }
    }
}
