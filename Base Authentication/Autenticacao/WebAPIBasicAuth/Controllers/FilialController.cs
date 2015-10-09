using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIBasicAuth.BUS;
using WebAPIBasicAuth.DAL;
using WebAPIBasicAuth.Models;

namespace WebAPIBasicAuth.Controllers
{
     [CustomAuthorize(Roles = "ListaFilial")]
    public class FilialController : ApiController
    {
       
        public HttpResponseMessage GetAllFilial(String Token)
        {
            try
            {
                ListaFilial listaFilial = new ListaFilial();


                listaFilial = FilialDAL.ListaFilial("0");
                return Request.CreateResponse(HttpStatusCode.OK, listaFilial);

            }
            catch (HttpResponseException ex)
            {
                return ex.Response;
            }
            catch (InvalidCastException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadGateway, ex.Message);
            }
        }
    }
}
