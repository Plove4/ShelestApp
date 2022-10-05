using PriyatniyShelestApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriyatniyShelestApp.Views.UtilView
{
    public partial class Agentcard : UserControl
    {
        public Agentcard()
        {
            InitializeComponent();
        }

        public void GeneradDataAgentcard (Agent agent)
        {
            AgentpictureBox.ImageLocation = agent.Logo;
            AgentTypeAndName.Text = $"{agent.AgentType.Title} | {agent.Title}";
            AgentSales.Text = $"{agent.Sales} продаж за год";
            AgentPhone.Text = agent.Phone;
            AgentPriority.Text = $"Приоритетность: {agent.Priority}";
            AgentDiscount.Text = agent.Discount;
        }
    }
}
