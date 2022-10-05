using PriyatniyShelestApp.Models;
using PriyatniyShelestApp.Utilities;
using PriyatniyShelestApp.Views.UtilView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriyatniyShelestApp
{
    public partial class MainForm : Form
    {
        List<Agent> agents = new List<Agent>();
        public MainForm()
        {
            InitializeComponent();
            agents = DBContex.Context.Agent.ToList();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GeneredAgentcard(agents);
            var allType = DBContex.Context.AgentType.Select(p => p.Title).ToList();
            allType.Insert(0, "Все типы");
            FiltrcomboBox.DataSource = allType;
            FiltrcomboBox.SelectedIndex = 0;
            SortcomboBox.SelectedIndex = 0;
        }

        private void GeneredAgentcard(List<Agent> agent)
        {
            foreach (var item in agent)
            {
                Agentcard card = new Agentcard();
                card.GeneradDataAgentcard(item);
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void SortingAgentCards()
        {
            flowLayoutPanel1.Controls.Clear();
            List<Agent> updatelist = DBContex.Context.Agent.ToList();

            if (!string.IsNullOrWhiteSpace(SearchtextBox.Text))
                updatelist = updatelist.Where(
                    a => a.Title.ToLower().Contains(SearchtextBox.Text.ToLower())
                    || a.Phone.Contains(SearchtextBox.Text)
                    || a.Email.Contains(SearchtextBox.Text)).ToList();
            if (FiltrcomboBox.SelectedIndex > 0)
                updatelist = updatelist.Where(p => p.AgentType.Title == FiltrcomboBox.SelectedItem.ToString()).ToList();
            switch (SortcomboBox.SelectedIndex)
            {
                case 1:
                    if (checkBox.Checked)
                        updatelist = updatelist.OrderBy(p => p.Title).ToList();
                    else
                        updatelist = updatelist.OrderByDescending(p => p.Title).ToList();
                    break;
                case 2:
                    if (checkBox.Checked)
                        updatelist = updatelist.OrderBy(p => p.Discount).ToList();
                    else
                        updatelist = updatelist.OrderByDescending(p => p.Discount).ToList();
                    break;
                case 3:
                    if (checkBox.Checked)
                        updatelist = updatelist.OrderBy(p => p.Priority).ToList();
                    else
                        updatelist = updatelist.OrderByDescending(p => p.Priority).ToList();
                    break;
            }
             
            GeneredAgentcard(updatelist);
        }

        private void SearchtextBox_TextChanged(object sender, EventArgs e)
        {
            SortingAgentCards();
        }

        private void FiltrcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortingAgentCards();
        }

        private void SortcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortingAgentCards();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SortcomboBox.SelectedIndex > 0)
                SortingAgentCards();
        }
    }
}
