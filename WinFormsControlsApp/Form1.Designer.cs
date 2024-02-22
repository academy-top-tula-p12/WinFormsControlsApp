namespace WinFormsControlsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblHello = new Label();
            linkLabel1 = new LinkLabel();
            btnOk = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblHello
            // 
            lblHello.AutoSize = true;
            lblHello.Location = new Point(22, 19);
            lblHello.Name = "lblHello";
            lblHello.Size = new Size(38, 15);
            lblHello.TabIndex = 0;
            lblHello.Text = "label1";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 24F);
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.Location = new Point(505, 19);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(256, 45);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Идем на Яндекс";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnOk
            // 
            btnOk.BackgroundImageLayout = ImageLayout.Center;
            btnOk.Cursor = Cursors.Hand;
            btnOk.Font = new Font("Segoe UI", 24F);
            btnOk.Image = (Image)resources.GetObject("btnOk.Image");
            btnOk.Location = new Point(410, 171);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(256, 136);
            btnOk.TabIndex = 2;
            btnOk.Text = "&Ok";
            btnOk.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.MouseDown += btnOk_MouseDown;
            // 
            // btnCancel
            // 
            btnCancel.BackgroundImageLayout = ImageLayout.Center;
            btnCancel.Font = new Font("Segoe UI", 24F);
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.Location = new Point(89, 171);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(256, 136);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "&Cancel";
            btnCancel.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Form1
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(linkLabel1);
            Controls.Add(lblHello);
            Name = "Form1";
            Text = "Controls";
            MouseMove += Form1_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHello;
        private LinkLabel linkLabel1;
        private Button btnOk;
        private Button btnCancel;
    }
}
