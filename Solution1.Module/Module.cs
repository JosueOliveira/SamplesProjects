using System;
using System.Text;
using System.Linq;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using System.Collections.Generic;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp.Model.Core;
using DevExpress.ExpressApp.Model.DomainLogics;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.Xpo;
using Solution1.Module.BusinessObjects;
using Solution1.Module.Views;

namespace Solution1.Module {
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppModuleBasetopic.aspx.
    public sealed partial class Solution1Module : ModuleBase {
        public Solution1Module() {
            InitializeComponent();
			BaseObject.OidInitializationMode = OidInitializationMode.AfterConstruction;
        }
        public override IEnumerable<ModuleUpdater> GetModuleUpdaters(IObjectSpace objectSpace, Version versionFromDB) {
            ModuleUpdater updater = new DatabaseUpdate.Updater(objectSpace, versionFromDB);
            return new ModuleUpdater[] { updater };
        }
        public override void Setup(XafApplication application) {
            base.Setup(application);
            application.CustomProcessShortcut += application_CustomProcessShortcut;
        }

        private void application_CustomProcessShortcut(object sender, CustomProcessShortcutEventArgs e)
        {
            if (e.Shortcut.ViewId == "ConsultarPedido_DetailView")
            {
                IObjectSpace objectSpace = Application.CreateObjectSpace();
                ConsultarPedido log = objectSpace.CreateObject<ConsultarPedido>();
                DetailView createdView = Application.CreateDetailView(objectSpace, log, true);
                createdView.ViewEditMode = ViewEditMode.Edit;
                e.View = createdView;
                e.Handled = true;
            }
        }

        public override void CustomizeTypesInfo(ITypesInfo typesInfo) {
            base.CustomizeTypesInfo(typesInfo);
            CalculatedPersistentAliasHelper.CustomizeTypesInfo(typesInfo);
        }
    }
}
