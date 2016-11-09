// ----------------------------------------------------
// COPYRIGHT (C) <TJG> ALL RIGHTS RESERVED. SEE THE LIC
// ENSE FILE FOR THE FULL LICENSE GOVERNING THIS CODE. 
// ----------------------------------------------------

using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text;
using System.Diagnostics;
using System.Threading;

public partial class MainWindow : Form
{
    public MainWindow()
    {
        InitializeComponent();

        RequestText.Text = "";
        RequestText.SelectionStart = 0;
        RequestText.SelectionLength = 0;
        ResponseText.Text = "";
        ProductText.Text = $"{ProductInfo.Author} {ProductInfo.Name} {ProductInfo.Version} {ProcessGetPointerSize()} Bit";
    }

    public void SendButton_Click(object sender, EventArgs e)
    {
        SendRequest();
    }
    private void RunButton_Click(object sender, EventArgs e)
    {
        var command = RequestText.Text;
        var code = "";
        if(XString.Eq(command, "1"))
        {
            code = IdexLab.MainResource.Request_1;
        }
        else if(XString.Eq(command, "2"))
        {
            code = IdexLab.MainResource.Request_2;
        }
        else if (XString.Eq(command, "all"))
        {
            code = IdexLab.MainResource.Request_All;
        }
        else
        {
            XMB.Info("Command is unknown.", ProductInfo.Name);
        }
        RequestText.Text = code;
    }
    private void RequestCopyLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        XCache.SetTextSafe(RequestText.Text);
    }
    private void RequestClearLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        RequestText.Text = "";
    }
    private void ResponseCopyLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        XCache.SetTextSafe(ResponseText.Text);
    }
    private void ResponseClearLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        ResponseText.Text = "";
    }
    private void RequestText_KeyDown(object sender, KeyEventArgs e)
    {
        if (ModifierKeys == Keys.Alt)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                SendRequest();
            }
            else if(e.KeyCode == Keys.Back)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                ResponseText.Text = "";
            }
        }
    }

    public void SendRequest()
    {
        IdexPipe.Encoding = IdexPipe.Unicode;
        ResponseText.Text = IdexPipe.Send(RequestText.Text);
    }
    public static int ProcessGetPointerSize()
    {
        if (IntPtr.Size == 4)
        {
            return 32;
        }
        if (IntPtr.Size == 8)
        {
            return 64;
        }
        return IntPtr.Size * 8;
    }
}

