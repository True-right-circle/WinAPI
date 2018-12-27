namespace Faker
{
    partial class LoadingForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            this.loadingtime = new System.Windows.Forms.Timer(this.components);
            this.loadingbox = new System.Windows.Forms.PictureBox();
            this.welcomeSound = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.loadingbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.welcomeSound)).BeginInit();
            this.SuspendLayout();
            // 
            // loadingtime
            // 
            this.loadingtime.Enabled = true;
            this.loadingtime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // loadingbox
            // 
            this.loadingbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadingbox.Location = new System.Drawing.Point(0, 0);
            this.loadingbox.Name = "loadingbox";
            this.loadingbox.Size = new System.Drawing.Size(784, 561);
            this.loadingbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadingbox.TabIndex = 0;
            this.loadingbox.TabStop = false;
            this.loadingbox.UseWaitCursor = true;
            this.loadingbox.Paint += new System.Windows.Forms.PaintEventHandler(this.loadingbox_Paint);
            // 
            // welcomeSound
            // 
            this.welcomeSound.Enabled = true;
            this.welcomeSound.Location = new System.Drawing.Point(533, 502);
            this.welcomeSound.Name = "welcomeSound";
            this.welcomeSound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("welcomeSound.OcxState")));
            this.welcomeSound.Size = new System.Drawing.Size(75, 23);
            this.welcomeSound.TabIndex = 1;
            this.welcomeSound.Visible = false;
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.welcomeSound);
            this.Controls.Add(this.loadingbox);
            this.Name = "LoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Loading to Carry";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.loadingbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.welcomeSound)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox loadingbox;
        private System.Windows.Forms.Timer loadingtime;
        private AxWMPLib.AxWindowsMediaPlayer welcomeSound;
    }
}