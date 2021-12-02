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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HideEditorButton.Module.Win.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class HideEditorButtonController : ViewController<DetailView>
    {
        public HideEditorButtonController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            View.CustomizeViewItemControl(this, customizeActio);
        }
        void customizeActio(ViewItem obj)
        {
            bool isReadOnly = (bool)obj.Control.GetType().GetProperty("ReadOnly").GetValue(obj.Control);
            if (isReadOnly)
            {
                var buttonEdit = obj.Control as DevExpress.XtraEditors.ButtonEdit;
                if (buttonEdit != null)
                {
                    int countBb = buttonEdit.Properties.Buttons.Count;
                    for (int i = 0; i < countBb; i++)
                    {
                        buttonEdit.Properties.Buttons[i].Visible = false;
                    }
                }
            }
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }
    }
}
