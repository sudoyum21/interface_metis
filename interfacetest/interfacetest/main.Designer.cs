namespace Metis_Interface
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ActuatorBox = new System.Windows.Forms.GroupBox();
            this.ReclineBox = new System.Windows.Forms.GroupBox();
            this.LegsBox = new System.Windows.Forms.GroupBox();
            this.Main_DeviceBox = new System.Windows.Forms.GroupBox();
            this.ElevateBox = new System.Windows.Forms.GroupBox();
            this.TiltBox = new System.Windows.Forms.GroupBox();
            this.MiscallenousBox = new System.Windows.Forms.GroupBox();
            this.sauvegardebtnpage1 = new System.Windows.Forms.Button();
            this.inputDeviceBox = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.sauvegardebtnpage2 = new System.Windows.Forms.Button();
            this.fowardbox = new System.Windows.Forms.GroupBox();
            this.reversebox = new System.Windows.Forms.GroupBox();
            this.turnbox = new System.Windows.Forms.GroupBox();
            this.joystick = new System.Windows.Forms.GroupBox();
            this.speedbox = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(842, 716);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage1.Controls.Add(this.ActuatorBox);
            this.tabPage1.Controls.Add(this.ReclineBox);
            this.tabPage1.Controls.Add(this.LegsBox);
            this.tabPage1.Controls.Add(this.Main_DeviceBox);
            this.tabPage1.Controls.Add(this.ElevateBox);
            this.tabPage1.Controls.Add(this.TiltBox);
            this.tabPage1.Controls.Add(this.MiscallenousBox);
            this.tabPage1.Controls.Add(this.sauvegardebtnpage1);
            this.tabPage1.Controls.Add(this.inputDeviceBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(834, 690);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Configuration";
            // 
            // ActuatorBox
            // 
            this.ActuatorBox.Location = new System.Drawing.Point(603, 12);
            this.ActuatorBox.Name = "ActuatorBox";
            this.ActuatorBox.Size = new System.Drawing.Size(251, 198);
            this.ActuatorBox.TabIndex = 9;
            this.ActuatorBox.TabStop = false;
            this.ActuatorBox.Text = "Actuator Control Device";
            // 
            // ReclineBox
            // 
            this.ReclineBox.Location = new System.Drawing.Point(447, 12);
            this.ReclineBox.Name = "ReclineBox";
            this.ReclineBox.Size = new System.Drawing.Size(140, 109);
            this.ReclineBox.TabIndex = 11;
            this.ReclineBox.TabStop = false;
            this.ReclineBox.Text = "Recline";
            // 
            // LegsBox
            // 
            this.LegsBox.Location = new System.Drawing.Point(288, 127);
            this.LegsBox.Name = "LegsBox";
            this.LegsBox.Size = new System.Drawing.Size(122, 123);
            this.LegsBox.TabIndex = 10;
            this.LegsBox.TabStop = false;
            this.LegsBox.Text = "Legs";
            // 
            // Main_DeviceBox
            // 
            this.Main_DeviceBox.Location = new System.Drawing.Point(59, 12);
            this.Main_DeviceBox.Name = "Main_DeviceBox";
            this.Main_DeviceBox.Size = new System.Drawing.Size(206, 109);
            this.Main_DeviceBox.TabIndex = 9;
            this.Main_DeviceBox.TabStop = false;
            this.Main_DeviceBox.Text = "Main Device";
            // 
            // ElevateBox
            // 
            this.ElevateBox.Location = new System.Drawing.Point(447, 127);
            this.ElevateBox.Name = "ElevateBox";
            this.ElevateBox.Size = new System.Drawing.Size(140, 98);
            this.ElevateBox.TabIndex = 12;
            this.ElevateBox.TabStop = false;
            this.ElevateBox.Text = "Elevate";
            // 
            // TiltBox
            // 
            this.TiltBox.Location = new System.Drawing.Point(288, 12);
            this.TiltBox.Name = "TiltBox";
            this.TiltBox.Size = new System.Drawing.Size(140, 109);
            this.TiltBox.TabIndex = 9;
            this.TiltBox.TabStop = false;
            this.TiltBox.Text = "Tilt";
            // 
            // MiscallenousBox
            // 
            this.MiscallenousBox.Location = new System.Drawing.Point(630, 230);
            this.MiscallenousBox.Name = "MiscallenousBox";
            this.MiscallenousBox.Size = new System.Drawing.Size(224, 267);
            this.MiscallenousBox.TabIndex = 9;
            this.MiscallenousBox.TabStop = false;
            this.MiscallenousBox.Text = "Miscallenous";
            // 
            // sauvegardebtnpage1
            // 
            this.sauvegardebtnpage1.Location = new System.Drawing.Point(630, 532);
            this.sauvegardebtnpage1.Name = "sauvegardebtnpage1";
            this.sauvegardebtnpage1.Size = new System.Drawing.Size(75, 23);
            this.sauvegardebtnpage1.TabIndex = 9;
            this.sauvegardebtnpage1.Text = "sauvegarde";
            this.sauvegardebtnpage1.UseVisualStyleBackColor = true;
            this.sauvegardebtnpage1.Click += new System.EventHandler(this.sauvegardebtnpage1_Click);
            // 
            // inputDeviceBox
            // 
            this.inputDeviceBox.Location = new System.Drawing.Point(59, 159);
            this.inputDeviceBox.Name = "inputDeviceBox";
            this.inputDeviceBox.Size = new System.Drawing.Size(154, 296);
            this.inputDeviceBox.TabIndex = 8;
            this.inputDeviceBox.TabStop = false;
            this.inputDeviceBox.Text = "Input Device";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage2.Controls.Add(this.sauvegardebtnpage2);
            this.tabPage2.Controls.Add(this.fowardbox);
            this.tabPage2.Controls.Add(this.reversebox);
            this.tabPage2.Controls.Add(this.turnbox);
            this.tabPage2.Controls.Add(this.joystick);
            this.tabPage2.Controls.Add(this.speedbox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(834, 690);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Performance Ajustement";
            // 
            // sauvegardebtnpage2
            // 
            this.sauvegardebtnpage2.Location = new System.Drawing.Point(713, 465);
            this.sauvegardebtnpage2.Name = "sauvegardebtnpage2";
            this.sauvegardebtnpage2.Size = new System.Drawing.Size(96, 23);
            this.sauvegardebtnpage2.TabIndex = 4;
            this.sauvegardebtnpage2.Text = "Sauvegarde";
            this.sauvegardebtnpage2.UseVisualStyleBackColor = true;
            this.sauvegardebtnpage2.Click += new System.EventHandler(this.sauvegardebtnpage2_Click);
            // 
            // fowardbox
            // 
            this.fowardbox.Location = new System.Drawing.Point(49, 98);
            this.fowardbox.Name = "fowardbox";
            this.fowardbox.Size = new System.Drawing.Size(727, 100);
            this.fowardbox.TabIndex = 1;
            this.fowardbox.TabStop = false;
            this.fowardbox.Text = "Foward";
            // 
            // reversebox
            // 
            this.reversebox.Location = new System.Drawing.Point(49, 228);
            this.reversebox.Name = "reversebox";
            this.reversebox.Size = new System.Drawing.Size(727, 100);
            this.reversebox.TabIndex = 1;
            this.reversebox.TabStop = false;
            this.reversebox.Text = "Reverse";
            // 
            // turnbox
            // 
            this.turnbox.Location = new System.Drawing.Point(49, 359);
            this.turnbox.Name = "turnbox";
            this.turnbox.Size = new System.Drawing.Size(727, 100);
            this.turnbox.TabIndex = 1;
            this.turnbox.TabStop = false;
            this.turnbox.Text = "Turn";
            // 
            // joystick
            // 
            this.joystick.Location = new System.Drawing.Point(49, 497);
            this.joystick.Name = "joystick";
            this.joystick.Size = new System.Drawing.Size(727, 164);
            this.joystick.TabIndex = 2;
            this.joystick.TabStop = false;
            this.joystick.Text = "Joystick Throw";
            // 
            // speedbox
            // 
            this.speedbox.Location = new System.Drawing.Point(49, 6);
            this.speedbox.Name = "speedbox";
            this.speedbox.Size = new System.Drawing.Size(727, 86);
            this.speedbox.TabIndex = 0;
            this.speedbox.TabStop = false;
            
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 733);
            this.Controls.Add(this.tabControl1);
            this.Name = "main";
            this.Text = "Configuration";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox inputDeviceBox;
        private System.Windows.Forms.Button sauvegardebtnpage1;
        private System.Windows.Forms.GroupBox ReclineBox;
        private System.Windows.Forms.GroupBox TiltBox;
        private System.Windows.Forms.GroupBox ElevateBox;
        private System.Windows.Forms.GroupBox MiscallenousBox;
        private System.Windows.Forms.GroupBox Main_DeviceBox;
        private System.Windows.Forms.GroupBox LegsBox;
        private System.Windows.Forms.GroupBox ActuatorBox;

        private System.Windows.Forms.GroupBox speedbox;
        private System.Windows.Forms.GroupBox fowardbox;
        private System.Windows.Forms.GroupBox reversebox;
        private System.Windows.Forms.GroupBox turnbox;
        private System.Windows.Forms.GroupBox joystick;
        private System.Windows.Forms.Button sauvegardebtnpage2;

    }

    
}