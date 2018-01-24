using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVK.Controllers
{   
    [Authorize]
    public class EventsController : ApiController
    {
        // GET: api/Events
        public IEnumerable<Event> Get()
        {
            using (VolunteerEntities entities = new VolunteerEntities()) {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Events.ToList();
            }
        }

        // GET: api/Events/5
        public Event Get(string id)
        {
            using (VolunteerEntities entities = new VolunteerEntities()) {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Events.FirstOrDefault(e => e.eventID == id);
            }
        }

        // POST: api/Events
        public HttpResponseMessage Post([FromBody]Event value)
        {
            try {
                using (VolunteerEntities entities = new VolunteerEntities()) {
                    entities.Events.Add(value);
                    entities.SaveChanges();

                    var message = Request.CreateResponse(HttpStatusCode.Created, value);
                    message.Headers.Location = new Uri(Request.RequestUri + value.eventID.ToString());
                    return message;
                }
            } catch (Exception ex) {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);

            }
        }

        // PUT: api/Events/5
        public HttpResponseMessage Put(string id, [FromBody]Event value)
        {
            try {
                using (VolunteerEntities entities = new VolunteerEntities()) {

                    var entity = entities.Events.FirstOrDefault(e => e.eventID == id);    
                    if(entity == null) {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "EventID " + id + " NOT FOUND");
                    } else {
                        /*
                        entity.eventName = value.eventName;
                        entity.eventInfo = value.eventInfo;
                        entity.eventDate = value.eventDate;
                        entity.eventStartTime = value.eventStartTime;
                        entity.eventEndTime = value.eventEndTime;
                        entity.eventSetupTime = value.eventSetupTime;
                        entity.eventTeardownTime = value.eventTeardownTime;
                        entity.eventConcessionStartTime = value.eventConcessionStartTime;
                        entity.eventConcessionEndTime = value.eventConcessionEndTime;
                        entity.eventConcessionSlots = value.eventConcessionSlots;
                        entity.eventFrontDeskStartTime = value.eventFrontDeskStartTime;
                        entity.eventFrontDeskEndTime = value.eventFrontDeskEndTime;
                        entity.eventFrontDeskSlots = value.eventFrontDeskSlots;
                        entity.orgID = value.orgID;
                        */
                        entities.Events.Remove(entity);
                        entities.SaveChanges();
                        entities.Events.Add(value);
                        entities.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK,entity);
                    }
                }
            }
            catch(Exception ex) {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // DELETE: api/Events/5
        public HttpResponseMessage Delete(string id)
        {
            try {
                using(VolunteerEntities entities = new VolunteerEntities()) {
                    var entity = entities.Events.FirstOrDefault(e => e.eventID == id);
                    if(entity == null) {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound,"EventID " + id + " NOT FOUND");
                    } else {
                        entities.Events.Remove(entity);
                        entities.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK);
                    }
                }

            }
            catch(Exception ex) {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
