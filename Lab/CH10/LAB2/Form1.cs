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
        Industry[] industries;

        Job[] itJobs =
        {
            new Job("Junior Software Devolper", new LinkLabel.Link(){LinkData=https://jobs.boeing.com/job/maryland-heights/mid-level-database-developer-administrator-remote/185/25751278976});
        },

        Job[] autoJobs =
        {
            new Job("Service Technician", new LinkLabel.Link(){LinkData=https://www.tesla.com/careers/search/job/service-technician-st-louis-mo-116359});
        },

        Job[] elexJobs =
        {
            new Job("Electrician-Solar Installation", new LinkLabel.Link(){LinkData=https://construction.jobs.net/Job.asp?jid=J3S4B068SDJFW8ZZ153});
        },

        Job[] aeroJobs =
        {
            new Job("Aerospace Structural Engineer", new LinkLabel.Link(){LinkData=https://donaldson.wd5.myworkdayjobs.com/en-US/DonaldsonCareers/job/Chesterfield-MO-USA/Aerospace-Structural-Engineer_JR-10129});
        }

        public JobDatabase()
        {
            InitializeComponent();
        }

    }
}
