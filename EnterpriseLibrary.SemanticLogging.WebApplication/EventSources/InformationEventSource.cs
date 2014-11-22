using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Web;

namespace EnterpriseLibrary.SemanticLogging.WebApplication.EventSources
{
    [EventSource(Name = "Information")]
    public class InformationEventSource : EventSource
    {
        [Event(1, Level = EventLevel.Informational)]
        internal void Startup(string message)
        {
            if (IsEnabled())
            {
                WriteEvent(1, message);
            }
        }

        public static readonly InformationEventSource Log = new InformationEventSource();
    }
}