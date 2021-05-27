using Fopex.BAL.Areas.City;
using Fopex.BAL.Areas.Country;
using Fopex.COMMON.Helper;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tracer;

namespace Fopex.Online.Controllers
{
    public class CountryController : ApiController
    {
        // GET: api/Country
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Travel/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Travel
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Travel/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Travel/5
        public void Delete(int id)
        {
        }


        #region TestgetCity(Entity)
        [HttpGet]
        [Route("api/Country/GetCity")]
        public object GetCity()
        {

            using (SysTrace trace = new SysTrace("CountryController", "GetCity"))
            {
                try
                {


                    BOCity objCountry = new BOCity();


                    var result = objCountry.GetCity();


                    if (result != null)
                    {
                        return GenericMethods.CreateResponce(ObjectResponce.Accepted, result);
                    }
                    else
                    {
                        return GenericMethods.CreateResponce(ObjectResponce.Rejected);
                    }
                }

                catch (Exception ex)
                {

                    AuditTrace.Exception("TravelController", "GetCountry", "HttpStatusCode.BadRequest", ex);
                    throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.BadRequest, GenericMethods.Exception(ex)));
                }
            }
        }


        #endregion


        #region TestService get Country by StoredProcedure
        [HttpGet]
        [Route("api/Country/GetCountry")]
        public object GetCountry()
        {

            using (SysTrace trace = new SysTrace("TravelController", "GetCountry"))
            {
                try
                {


                    BOCountry BALobjCountry = new BOCountry();

                   
                    var result = BALobjCountry.GetCountry();

                   
                    if (result != null)
                    {
                        return GenericMethods.CreateResponce(ObjectResponce.Accepted, result);
                    }
                    else
                    {
                        return GenericMethods.CreateResponce(ObjectResponce.Rejected);
                    }
                }

                catch (Exception ex)
                {

                    AuditTrace.Exception("TravelController", "GetCountry", "HttpStatusCode.BadRequest", ex);
                    throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.BadRequest, GenericMethods.Exception(ex)));
                }
            }
        }



        #endregion

    }
}
