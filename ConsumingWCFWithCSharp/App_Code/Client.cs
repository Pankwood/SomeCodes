
#region reference
using System.Collections.Generic;
using System.Net;
using System.Runtime.Serialization.Json;
#endregion

/// <summary>
/// Consuming WCF with C#
/// </summary>
public class Client
{

    /// <summary>
    /// List of Cities
    /// </summary>
    public static List<CidadeResult> MyList()  
    {
        //Initializes a new WebRequest instance for the specified URI scheme.
        WebRequest request = WebRequest.Create("IMPUT WEBAPI LINK");
        //Returns a response from an Internet resource.
        WebResponse ws = request.GetResponse();
        //Deserialize the string and transform in memory object
        DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(ListCityResult));
        //Read the object in memory and casting to class
        ListCityResult response = (ListCityResult)jsonSerializer.ReadObject(ws.GetResponseStream());
        //Return a DataSource
        return response.CidadeResult;
    }

}