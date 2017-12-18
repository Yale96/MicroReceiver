using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Serilog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiveLogData
{
    public class SeqManager
    {
        
        public SeqManager()
        {

        }
        
        public void WriteLogData(List<Message> messages)
        {
            Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .WriteTo.Seq("http://localhost:5341")
            .CreateLogger();

            foreach(Message m in messages)
            {
                Log.Information("Message:, {Name}!", m.ToString());
            }
            

            // Important to call at exit so that batched events are flushed.
            Log.CloseAndFlush();
        }
    }
}
