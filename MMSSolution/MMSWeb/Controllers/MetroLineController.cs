using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MMSWeb.Controllers
{
    public class MetroSystemController : ApiController
    {

        public MetroSystem GetAllMetroLines()
        {

            System.IO.StreamReader fileStream = new System.IO.StreamReader(System.Web.Hosting.HostingEnvironment.MapPath("~/metrosystem.htm"));

            var json= fileStream.ReadToEnd();

            var retval = Newtonsoft.Json.JsonConvert.DeserializeObject<MetroSystem>(json);

            fileStream.Dispose();

            

            return retval;
            
            //return new List<MetroLine>
            //{
            //    new MetroLine{Name="Victoria", From="Brixton",To="Walthomstow", Cost=1234}
            //};
        
        }

    }


    public class MetroSystem
    {
        public string Name { get; set; }



        public string Colour { get; set; }       
 
        public IEnumerable<Line> Lines {get;set;}
        
    }

    public class Line
    {
        public string Name;
        public string Colour;

    }


    
    



}
