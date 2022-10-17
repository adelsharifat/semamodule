using Desktop.Core.Extention;
using Desktop.Core.Helper;
using Desktop.Core.Security;
using Desktop.Core.UserControl;
using DevExpress.XtraBars;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Module._Temp_.Views
{
    public partial class _Temp_View : ViewControl
    {
        private BarItem btnSave, btnPost;
        public _Temp_View()
        {
            InitializeComponent();
        }

        private void _Temp_View_RibbonPageAdded(object sender, Core.Contract.CustomEventArgs.RibbonPageEventArgs e)
        {
            //Declare menus here
            btnSave = e.RibbonPage.AddSaveItem();
            btnPost = e.RibbonPage.AddPostItem();

            //Declare delegate events here
            btnSave.ItemClick += BtnSave_ItemClick;
            btnPost.ItemClick += BtnPost_ItemClick;
        }

        private void BtnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (Msg.Confirm("Are you sure to save item") == DialogResult.No) return;
                Msg.Show("Save btn clicked!");
            }
            catch (Exception ex)// ex is favorite name if you want
            {
                ex.ShowMessage();// ShowMessage is an extention for display error in error message box simply
            }
        }

        private void BtnPost_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (Msg.Confirm("Are you sure to post item") == DialogResult.No) return;
                Msg.Show("Post btn clicked!");
            }
            catch (Exception err)// err is favorite name if you want
            {
                err.ShowMessage();// ShowMessage is an extention for display error in error message box simply 
            }
        }

        private void _Temp_View_BeforeViewLoad(object sender, System.EventArgs e)
        {
            // You can load some data here before form loaded
        }

        private async void _Temp_View_ViewLoaded(object sender, System.EventArgs e)
        {
            // You can load some data and set any logic here on loaded view
            await Task.WhenAll(LoadGridData(),LoadComboData());
        }

        private async Task LoadGridData()
        {
            // Replace ypu fetching api code with below code
            // For example api 
            // await $safeitemname$Api.GetTempist(UserInfo.ProjectId)).ToList()

            await System.Threading.Tasks.Task.Run(()=>Msg.Show("Load Data"));
        }

        private async Task LoadComboData()
        {
            // Replace ypu fetching api code with below code
            await System.Threading.Tasks.Task.Run(() => Msg.Show("Load Data"));
        }

    }
}
