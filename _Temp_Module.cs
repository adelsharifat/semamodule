using Desktop.Core.Handler;
using Desktop.Module._Temp_.Views;
using System.Drawing;

namespace Desktop.Module._Temp_
{
    public class _Temp_Module : Core.Module.Module
    {
        public const string BaseMenu = "_Temp_";
        public const string Schema = "_Schema_";

        public override string AppCategory => "_Temp_";

        public override string AppFullName => "_Temp_";

        public override string AppName => "_Temp_";

        public override string AppVersion => "1.0.0";

        public override string AppSchema => Schema;

        public override Color AppColor => Color.DodgerBlue;

        public override void Initialize()
        {
            //Create Menu Here
            TreeMenuHandler.AddIcon($"{BaseMenu}/_Temp_", Core.CoreResource.FolderPanel_16x16);
            TreeMenuHandler.AddMenu<_Temp_View > ($"{BaseMenu}/_Temp_/_Temp_View");
        }
    }
}
