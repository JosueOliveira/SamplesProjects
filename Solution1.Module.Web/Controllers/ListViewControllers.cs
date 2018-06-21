using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using DevExpress.ExpressApp.Web.SystemModule;

namespace Solution1.Module.Web.Controllers
{
     
    public partial class ListViewControllers : ViewController<ListView>
    {
        ListViewController controller;
        IObjectSpace os;
        public ListViewControllers()
        {
            InitializeComponent();
             
        }
        protected override void OnActivated()
        {
            base.OnActivated();
             
        }

        protected override void OnFrameAssigned()
        {
            base.OnFrameAssigned();

            controller = Frame.GetController<ListViewController>();
            if(controller != null)
            {
                controller.EditAction.Execute += EditAction_Execute;
            }

        }

        private void EditAction_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            os = View.ObjectSpace;
            os.Committed += Os_Committed;
        }

        private void Os_Committed(object sender, EventArgs e)
        {
            os.Refresh();            
        }

        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
             
        }
        protected override void OnDeactivated()
        {
             
            base.OnDeactivated();
        }
    }
}
