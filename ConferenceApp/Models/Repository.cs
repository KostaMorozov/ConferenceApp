using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceApp.Models
{
    public static class Repository
    {
        private static List<Invites> responses = new List<Invites>();

        public static IEnumerable<Invites> Responses = responses;

        public static void AddResponse(Invites response)
        {
            responses.Add(response);
        }
    }
}
