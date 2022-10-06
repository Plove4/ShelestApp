using PriyatniyShelestApp.Models;
using PriyatniyShelestApp.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriyatniyShelestApp.Views
{
    public partial class AddEditAgentForm : Form
    {
        Agent agent { get; set; } = null;
        public AddEditAgentForm(Agent current)
        {
            InitializeComponent();
            if (current != null)
            {
                agent = current;
                DeletBtn.Visible = true;
            }
            else
            {
                agent = new Agent();
                DeletBtn.Visible = false;
            }
        }

        private void AddEditAgentForm_Load(object sender, EventArgs e)
        {
            agentTypeBindingSource.DataSource = DBContex.Context.AgentType.ToList();
            if (agent.ID != 0)
            {
                agentBindingSource.Add(agent);
                if (!string.IsNullOrWhiteSpace(agent.Logo))
                {
                    logoPictureBox.ImageLocation = agent.Logo;
                }
                else
                {
                    logoPictureBox.ImageLocation = "..\\..\\Resources\\picture.png";
                    agent.Logo = "..\\..\\Resources\\picture.png";
                }
            }
            else
            {
                agentBindingSource.AddNew();
                logoPictureBox.ImageLocation = "..\\..\\Resources\\picture.png";
                agent.Logo = "..\\..\\Resources\\picture.png";
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            agent = (Agent)agentBindingSource.Current;

            if (agent.ID == 0)
            {
                DBContex.Context.Agent.Add(agent);
            }

            try
            {
                if (agent.Logo == "..\\..\\Resources\\picture.png")
                    agent.Logo = "";
                DBContex.Context.SaveChanges();
                MessageBox.Show("Данные успешно сохранены");
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeletBtn_Click(object sender, EventArgs e)
        {
            agent = (Agent)agentBindingSource.Current;
            DialogResult result = MessageBox.Show("Вы точно хотите удалить текущую запись", "Удалениe", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    DBContex.Context.Agent.Remove(agent);
                    DBContex.Context.SaveChanges();
                    MessageBox.Show("Данные успешно удалены");
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
