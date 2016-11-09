// ----------------------------------------------------
// COPYRIGHT (C) <TJG> ALL RIGHTS RESERVED. SEE THE LIC
// ENSE FILE FOR THE FULL LICENSE GOVERNING THIS CODE. 
// ----------------------------------------------------

using System.Windows.Forms;

public partial class XMB
{
    public static void Info(string text, string caption = "")
    {
        var result = MessageBox.Show(Form.ActiveForm
        , text
        , caption
        , MessageBoxButtons.OK
        , MessageBoxIcon.Information);
    }

    public static DialogResult Question(string text, string caption = "")
    {
        var result = MessageBox.Show(Form.ActiveForm
        , text
        , caption
        , MessageBoxButtons.YesNo
        , MessageBoxIcon.Question);
        return result;

    }

}

