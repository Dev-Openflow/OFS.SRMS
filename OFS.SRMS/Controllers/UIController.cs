using DevExpress.XtraBars;
using System.Windows.Forms;

namespace OFS.SRMS.Controllers
{
    public static class UIController
    {

        public static void SetTabPage(TabFormControl tabFormControl, string tag, string tabName, Control control)
        {
            if(!IsActive(tabFormControl, tag))
            {
                TabFormPage page = new TabFormPage();
                TabFormContentContainer contentContainer = new TabFormContentContainer();

                tabFormControl.BeginLayout();
                contentContainer.Controls.Add(control);
                control.Dock = DockStyle.Fill;

                contentContainer.Dock = DockStyle.Fill;
                page.Text = tabName;
                page.Tag = tag;
                
                page.ContentContainer = contentContainer;

                tabFormControl.Pages.Add(page);

                tabFormControl.SelectedPage = page;
                tabFormControl.EndLayout();
            }
            else
            {
                //SELECT EXISTING TAB
                foreach (TabFormPage item in tabFormControl.Pages)
                {
                    if(item.Tag.ToString() == tag)
                    {
                        tabFormControl.BeginLayout();
                        tabFormControl.SelectedPage = null;
                        tabFormControl.SelectedPage = item;
                        tabFormControl.EndLayout();
                    }
                }
            }
        }

        private static bool IsActive(TabFormControl tabFormControl, string tag)
        {
            foreach (TabFormPage item in tabFormControl.Pages)
            {
                    if (item.Tag.ToString() == tag)
                    {
                        return true;
                    }
            }
            return false;
        }
    }
}
