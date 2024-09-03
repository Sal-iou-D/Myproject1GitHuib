namespace myPorject1
{
    partial class btnHello_Click
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
            btnPushMe = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnPushMe
            // 
            btnPushMe.Location = new Point(321, 193);
            btnPushMe.Name = "btnPushMe";
            btnPushMe.Size = new Size(112, 34);
            btnPushMe.TabIndex = 0;
            btnPushMe.Text = "button1";
            btnPushMe.UseVisualStyleBackColor = true;
            btnPushMe.Click += button1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Cooper Black", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(560, 68);
            label1.Name = "label1";
            label1.Size = new Size(174, 128);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // btnHello_Click
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnPushMe);
            Name = "btnHello_Click";
            Text = "Our First form";
            Load += button1_Click;
            ResumeLayout(false);
        }

        #endregion

        private Button btnPushMe;
        private Label label1;
    }
}
