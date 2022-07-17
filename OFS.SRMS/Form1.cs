using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OFS.SRMS
{
    public partial class Form1 : DevExpress.XtraBars.TabForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BarButtonItemSubjects_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Views.UC.SubjectUC subjectUC = new Views.UC.SubjectUC();
            Controllers.UIController.SetTabPage(this.tabFormControl1, "SUB", "SUBJECTS", subjectUC);
        }

        private void BarButtonItemCourse_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Controllers.UIController.SetTabPage(this.tabFormControl1, "COURSE", "COURSES", new Views.UC.CourseUC());
        }
    }
}
