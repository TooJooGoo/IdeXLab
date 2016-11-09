
partial class MainWindow
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.RequestText = new System.Windows.Forms.TextBox();
            this.ResponseText = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.RunButton = new System.Windows.Forms.Button();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.RequestCopyLink = new System.Windows.Forms.LinkLabel();
            this.RequestClearLink = new System.Windows.Forms.LinkLabel();
            this.ResponseClearLink = new System.Windows.Forms.LinkLabel();
            this.ResponseCopyLink = new System.Windows.Forms.LinkLabel();
            this.ProductText = new System.Windows.Forms.TextBox();
            this.RequestLinkLabel = new System.Windows.Forms.LinkLabel();
            this.ResponseLinkLabel = new System.Windows.Forms.LinkLabel();
            this.ButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // RequestText
            // 
            this.RequestText.BackColor = System.Drawing.SystemColors.Window;
            this.RequestText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RequestText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RequestText.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestText.Location = new System.Drawing.Point(12, 18);
            this.RequestText.Multiline = true;
            this.RequestText.Name = "RequestText";
            this.RequestText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RequestText.Size = new System.Drawing.Size(448, 129);
            this.RequestText.TabIndex = 1;
            this.RequestText.Text = "IDEX\r\nServerId = IdexServer\r\nClientId = IdexClient\r\ng Server.Id";
            this.RequestText.WordWrap = false;
            this.RequestText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RequestText_KeyDown);
            // 
            // ResponseText
            // 
            this.ResponseText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResponseText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResponseText.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResponseText.Location = new System.Drawing.Point(12, 18);
            this.ResponseText.Multiline = true;
            this.ResponseText.Name = "ResponseText";
            this.ResponseText.ReadOnly = true;
            this.ResponseText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResponseText.Size = new System.Drawing.Size(448, 131);
            this.ResponseText.TabIndex = 6;
            this.ResponseText.TabStop = false;
            this.ResponseText.Text = "IDEX\r\nIdexServer";
            this.ResponseText.WordWrap = false;
            // 
            // SendButton
            // 
            this.SendButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SendButton.Location = new System.Drawing.Point(0, 0);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(150, 20);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "Send Request";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // RunButton
            // 
            this.RunButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.RunButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RunButton.Location = new System.Drawing.Point(150, 0);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(150, 20);
            this.RunButton.TabIndex = 4;
            this.RunButton.Text = "Run Command";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonPanel.Controls.Add(this.RunButton);
            this.ButtonPanel.Controls.Add(this.SendButton);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonPanel.Location = new System.Drawing.Point(12, 147);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(448, 20);
            this.ButtonPanel.TabIndex = 7;
            // 
            // SplitContainer
            // 
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer.Name = "SplitContainer";
            this.SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.SplitContainer.Panel1.Controls.Add(this.RequestLinkLabel);
            this.SplitContainer.Panel1.Controls.Add(this.RequestCopyLink);
            this.SplitContainer.Panel1.Controls.Add(this.RequestClearLink);
            this.SplitContainer.Panel1.Controls.Add(this.RequestText);
            this.SplitContainer.Panel1.Controls.Add(this.ButtonPanel);
            this.SplitContainer.Panel1.Padding = new System.Windows.Forms.Padding(12, 18, 12, 0);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.ResponseLinkLabel);
            this.SplitContainer.Panel2.Controls.Add(this.ResponseClearLink);
            this.SplitContainer.Panel2.Controls.Add(this.ResponseCopyLink);
            this.SplitContainer.Panel2.Controls.Add(this.ResponseText);
            this.SplitContainer.Panel2.Controls.Add(this.ProductText);
            this.SplitContainer.Panel2.Padding = new System.Windows.Forms.Padding(12, 18, 12, 0);
            this.SplitContainer.Size = new System.Drawing.Size(472, 333);
            this.SplitContainer.SplitterDistance = 167;
            this.SplitContainer.TabIndex = 8;
            this.SplitContainer.TabStop = false;
            // 
            // RequestCopyLink
            // 
            this.RequestCopyLink.ActiveLinkColor = System.Drawing.Color.Blue;
            this.RequestCopyLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RequestCopyLink.AutoSize = true;
            this.RequestCopyLink.BackColor = System.Drawing.SystemColors.Control;
            this.RequestCopyLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestCopyLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.RequestCopyLink.LinkColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RequestCopyLink.Location = new System.Drawing.Point(361, 2);
            this.RequestCopyLink.Name = "RequestCopyLink";
            this.RequestCopyLink.Size = new System.Drawing.Size(30, 13);
            this.RequestCopyLink.TabIndex = 5;
            this.RequestCopyLink.TabStop = true;
            this.RequestCopyLink.Text = "copy";
            this.RequestCopyLink.VisitedLinkColor = System.Drawing.SystemColors.ControlText;
            this.RequestCopyLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RequestCopyLink_LinkClicked);
            // 
            // RequestClearLink
            // 
            this.RequestClearLink.ActiveLinkColor = System.Drawing.Color.Blue;
            this.RequestClearLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RequestClearLink.AutoSize = true;
            this.RequestClearLink.BackColor = System.Drawing.SystemColors.Control;
            this.RequestClearLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestClearLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.RequestClearLink.LinkColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RequestClearLink.Location = new System.Drawing.Point(408, 2);
            this.RequestClearLink.Name = "RequestClearLink";
            this.RequestClearLink.Size = new System.Drawing.Size(30, 13);
            this.RequestClearLink.TabIndex = 6;
            this.RequestClearLink.TabStop = true;
            this.RequestClearLink.Text = "clear";
            this.RequestClearLink.VisitedLinkColor = System.Drawing.SystemColors.ControlText;
            this.RequestClearLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RequestClearLink_LinkClicked);
            // 
            // ResponseClearLink
            // 
            this.ResponseClearLink.ActiveLinkColor = System.Drawing.Color.Blue;
            this.ResponseClearLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResponseClearLink.AutoSize = true;
            this.ResponseClearLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResponseClearLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ResponseClearLink.LinkColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ResponseClearLink.Location = new System.Drawing.Point(408, 2);
            this.ResponseClearLink.Name = "ResponseClearLink";
            this.ResponseClearLink.Size = new System.Drawing.Size(30, 13);
            this.ResponseClearLink.TabIndex = 8;
            this.ResponseClearLink.TabStop = true;
            this.ResponseClearLink.Text = "clear";
            this.ResponseClearLink.VisitedLinkColor = System.Drawing.SystemColors.ControlText;
            this.ResponseClearLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ResponseClearLink_LinkClicked);
            // 
            // ResponseCopyLink
            // 
            this.ResponseCopyLink.ActiveLinkColor = System.Drawing.Color.Blue;
            this.ResponseCopyLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResponseCopyLink.AutoSize = true;
            this.ResponseCopyLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResponseCopyLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ResponseCopyLink.LinkColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ResponseCopyLink.Location = new System.Drawing.Point(361, 2);
            this.ResponseCopyLink.Name = "ResponseCopyLink";
            this.ResponseCopyLink.Size = new System.Drawing.Size(30, 13);
            this.ResponseCopyLink.TabIndex = 7;
            this.ResponseCopyLink.TabStop = true;
            this.ResponseCopyLink.Text = "copy";
            this.ResponseCopyLink.VisitedLinkColor = System.Drawing.SystemColors.ControlText;
            this.ResponseCopyLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ResponseCopyLink_LinkClicked);
            // 
            // ProductText
            // 
            this.ProductText.BackColor = System.Drawing.SystemColors.Control;
            this.ProductText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProductText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ProductText.HideSelection = false;
            this.ProductText.Location = new System.Drawing.Point(12, 149);
            this.ProductText.Name = "ProductText";
            this.ProductText.ReadOnly = true;
            this.ProductText.Size = new System.Drawing.Size(448, 13);
            this.ProductText.TabIndex = 9;
            this.ProductText.TabStop = false;
            this.ProductText.Text = "Product Name";
            // 
            // RequestLinkLabel
            // 
            this.RequestLinkLabel.ActiveLinkColor = System.Drawing.Color.Blue;
            this.RequestLinkLabel.AutoSize = true;
            this.RequestLinkLabel.BackColor = System.Drawing.SystemColors.Control;
            this.RequestLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.RequestLinkLabel.LinkColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RequestLinkLabel.Location = new System.Drawing.Point(12, 2);
            this.RequestLinkLabel.Name = "RequestLinkLabel";
            this.RequestLinkLabel.Size = new System.Drawing.Size(50, 13);
            this.RequestLinkLabel.TabIndex = 8;
            this.RequestLinkLabel.TabStop = true;
            this.RequestLinkLabel.Text = "Request:";
            this.RequestLinkLabel.VisitedLinkColor = System.Drawing.SystemColors.ControlText;
            // 
            // ResponseLinkLabel
            // 
            this.ResponseLinkLabel.ActiveLinkColor = System.Drawing.Color.Blue;
            this.ResponseLinkLabel.AutoSize = true;
            this.ResponseLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResponseLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ResponseLinkLabel.LinkColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ResponseLinkLabel.Location = new System.Drawing.Point(12, 2);
            this.ResponseLinkLabel.Name = "ResponseLinkLabel";
            this.ResponseLinkLabel.Size = new System.Drawing.Size(58, 13);
            this.ResponseLinkLabel.TabIndex = 10;
            this.ResponseLinkLabel.TabStop = true;
            this.ResponseLinkLabel.Text = "Response:";
            this.ResponseLinkLabel.VisitedLinkColor = System.Drawing.SystemColors.ControlText;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 333);
            this.Controls.Add(this.SplitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "MainWindow";
            this.Text = "IdeX Laboratory";
            this.ButtonPanel.ResumeLayout(false);
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel1.PerformLayout();
            this.SplitContainer.Panel2.ResumeLayout(false);
            this.SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

    }
    private System.Windows.Forms.TextBox RequestText;
    private System.Windows.Forms.TextBox ResponseText;
    private System.Windows.Forms.Button SendButton;
    private System.Windows.Forms.Button RunButton;
    private System.Windows.Forms.Panel ButtonPanel;
    private System.Windows.Forms.SplitContainer SplitContainer;
    private System.Windows.Forms.LinkLabel ResponseCopyLink;
    private System.Windows.Forms.LinkLabel ResponseClearLink;
    private System.Windows.Forms.LinkLabel RequestCopyLink;
    private System.Windows.Forms.LinkLabel RequestClearLink;
    private System.Windows.Forms.TextBox ProductText;
    private System.Windows.Forms.LinkLabel RequestLinkLabel;
    private System.Windows.Forms.LinkLabel ResponseLinkLabel;
}


