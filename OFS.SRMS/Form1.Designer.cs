namespace OFS.SRMS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.Utils.Animation.PushTransition pushTransition1 = new DevExpress.Utils.Animation.PushTransition();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tabFormControl1 = new DevExpress.XtraBars.TabFormControl();
            this.barButtonItemSubjects = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCourse = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 405);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(873, 32);
            this.panelControl1.TabIndex = 2;
            // 
            // tabFormControl1
            // 
            this.tabFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemSubjects,
            this.barButtonItemCourse});
            this.tabFormControl1.Location = new System.Drawing.Point(0, 0);
            this.tabFormControl1.Name = "tabFormControl1";
            this.tabFormControl1.ShowAddPageButton = false;
            this.tabFormControl1.Size = new System.Drawing.Size(873, 71);
            this.tabFormControl1.TabForm = this;
            this.tabFormControl1.TabIndex = 3;
            this.tabFormControl1.TabStop = false;
            this.tabFormControl1.TitleItemLinks.Add(this.barButtonItemSubjects);
            this.tabFormControl1.TitleItemLinks.Add(this.barButtonItemCourse);
            this.tabFormControl1.Transition.AllowTransition = DevExpress.Utils.DefaultBoolean.True;
            this.tabFormControl1.Transition.EasingMode = DevExpress.Data.Utils.EasingMode.EaseInOut;
            pushTransition1.Parameters.EffectOptions = DevExpress.Utils.Animation.PushEffectOptions.FromBottom;
            this.tabFormControl1.Transition.TransitionType = pushTransition1;
            // 
            // barButtonItemSubjects
            // 
            this.barButtonItemSubjects.Caption = "Subjects";
            this.barButtonItemSubjects.Id = 0;
            this.barButtonItemSubjects.Name = "barButtonItemSubjects";
            this.barButtonItemSubjects.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItemSubjects_ItemClick);
            // 
            // barButtonItemCourse
            // 
            this.barButtonItemCourse.Caption = "Courses";
            this.barButtonItemCourse.Id = 0;
            this.barButtonItemCourse.Name = "barButtonItemCourse";
            this.barButtonItemCourse.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItemCourse_ItemClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 437);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.tabFormControl1);
            this.Name = "Form1";
            this.TabFormControl = this.tabFormControl1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.TabFormControl tabFormControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSubjects;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCourse;
    }
}

