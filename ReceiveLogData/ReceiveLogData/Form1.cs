using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReceiveLogData
{
    public partial class GetDataFromQueue : Form
    {
        private readonly RabbitMqManager rabbitManager;
        public GetDataFromQueue()
        {
            InitializeComponent();
            rabbitManager = new RabbitMqManager();
        }

        private void buttonGetFromQueue_Click(object sender, EventArgs e)
        {
            rabbitManager.GetFromQueue();
        }
    }
}
