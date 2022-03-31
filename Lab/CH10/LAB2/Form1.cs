using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2
{
    public partial class JobDatabase : Form
    {
        Industry[] selectedIndustries;

        Job[] itJobs =
        {
            new Job("Junior Software Devolper", new LinkLabel.Link(){LinkData="https://jobs.boeing.com/job/maryland-heights/mid-level-database-developer-administrator-remote/185/25751278976"}),
            new Job("Generalist Programmer", new LinkLabel.Link(){LinkData="https://gearboxsoftware.bamboohr.com/jobs/view.php?id=329"}),
            new Job("Web Developer", new LinkLabel.Link(){LinkData="https://www.dice.com/jobs/detail/Web-Developer-SAIC-Arnold-MO-63010/10111346/2202267"})
        };

        Job[] autoJobs =
        {
            new Job("Service Technician", new LinkLabel.Link(){LinkData="https://www.tesla.com/careers/search/job/service-technician-st-louis-mo-116359"})
        };

        Job[] elexJobs =
        {
            new Job("Electrician-Solar Installation", new LinkLabel.Link(){LinkData="https://construction.jobs.net/Job.asp?jid=J3S4B068SDJFW8ZZ153"})
        };

        Job[] aeroJobs =
        {
            new Job("Aerospace Structural Engineer", new LinkLabel.Link(){LinkData="https://donaldson.wd5.myworkdayjobs.com/en-US/DonaldsonCareers/job/Chesterfield-MO-USA/Aerospace-Structural-Engineer_JR-10129"})
        };

        Job[] constJobs =
        {
            new Job("", new LinkLabel.Link(){LinkData=""})
        };

        Job[] mechJobs =
        {
            new Job("", new LinkLabel.Link(){LinkData=""})
        };

        Job[] hvacJobs =
        {
            new Job("HVAC Service Technician", new LinkLabel.Link(){LinkData="https://www.galmicheandsons.com/hvac-technician-jobs.html"})
        };

        public JobDatabase()
        {
            InitializeComponent();

            listIndustry.Items.AddRange(new Industry[]
            {
                new Industry ("Aerospace Engineering", aeroJobs),
                new Industry ("Automotive", autoJobs),
                new Industry ("Construction", constJobs),
                new Industry ("Electrical Engineering", elexJobs),
                new Industry ("HVAC", hvacJobs),
                new Industry ("Information Technology", itJobs),
                new Industry ("Mechanical Engineering", mechJobs),
            });
        }

        private void listIndustry_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndustries = new Industry[listIndustry.SelectedItems.Count];

            for (int i = 0; i < listIndustry.SelectedItems.Count; i++)
            {
                selectedIndustries[i] = (Industry)listIndustry.SelectedItems[i];
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmJobsList jobsList = new frmJobsList(selectedIndustries);
            jobsList.ShowDialog();
        }
    }
}
