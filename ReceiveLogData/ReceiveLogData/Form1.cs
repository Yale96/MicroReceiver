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
        private SeqManager seqManager;
        public GetDataFromQueue()
        {
            InitializeComponent();
            rabbitManager = new RabbitMqManager();
            seqManager = new SeqManager();
        }

        private void buttonGetFromQueue_Click(object sender, EventArgs e)
        {
            dataFromQueue.Items.Clear();
            rabbitManager.GetFromQueue();
            FillListbox();
        }

        private void FillListbox()
        {
            
            foreach(Message m in rabbitManager.allMessages)
            {
                dataFromQueue.Items.Add(m);
            }
        }

        private void buttonLogData_Click(object sender, EventArgs e)
        {
            seqManager.WriteLogData(rabbitManager.allMessages);
        }
    }
}
