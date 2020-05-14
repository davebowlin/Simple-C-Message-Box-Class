//

using System.Windows.Forms;

namespace SMB___Simple_Message_Box
{
    public class Simple
    {
        // Global
        private MessageBoxButtons buttons;

        public DialogResult smb(string msg, string title, int btns)
        {
            switch (btns)
            {
                case 1:
                    buttons = MessageBoxButtons.OK;
                    break;

                case 2:
                    buttons = MessageBoxButtons.YesNo;
                    break;

                case 3:
                    buttons = MessageBoxButtons.OKCancel;
                    break;

                default:
                    break;
            }

            DialogResult result = MessageBox.Show(msg, title, buttons);

            return result;
        }
    }
}