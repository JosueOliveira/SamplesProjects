namespace Solution1.Module.Web.Controllers
{
    partial class ButtonController
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MyBtnSave = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // MyBtnSave
            // 
            this.MyBtnSave.ActionMeaning = DevExpress.ExpressApp.Actions.ActionMeaning.Accept;
            this.MyBtnSave.Caption = "My Save";
            this.MyBtnSave.Category = "PopupActions";
            this.MyBtnSave.ConfirmationMessage = null;
            this.MyBtnSave.Id = "MyButtonSave";
            this.MyBtnSave.ToolTip = null;
            this.MyBtnSave.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.MyBtnSave_Execute);
            // 
            // ButtonController
            // 
            this.Actions.Add(this.MyBtnSave);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction MyBtnSave;
    }
}
