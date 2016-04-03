using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Metis_Interface
{
    public partial class main : Form
    {
        static private List<CheckBox> DeviceCheckBoxList = new List<CheckBox>();
        static private List<CheckBox> MainCheckBoxList = new List<CheckBox>();
        static private List<CheckBox> TiltCheckBoxList = new List<CheckBox>();
        static private List<CheckBox> LegsCheckBoxList = new List<CheckBox>();
        static private List<CheckBox> RecCheckBoxList = new List<CheckBox>();
        static private List<CheckBox> ElevateCheckBoxList = new List<CheckBox>();
        static private List<CheckBox> ActCheckBoxList = new List<CheckBox>();
        static private List<CheckBox> MiscCheckBoxList = new List<CheckBox>();
        static private List<CheckBox> AllCheckBoxList = new List<CheckBox>();

        static private List<TextBox> speedList = new List<TextBox>();
        static private List<TextBox> fowardList = new List<TextBox>();
        static private List<TextBox> reverseList = new List<TextBox>();
        static private List<TextBox> turnList = new List<TextBox>();
        static private List<TextBox> joystickList = new List<TextBox>();
        static private List<TextBox> AllTextBoxList = new List<TextBox>();

        static protected string ConfigXML = "Configuration";
        static protected string PerfAjustXML = "PerformanceAjustment";

        //number of col in tabpage2
        static private int numbColumn = 4;

        public main()
        {  
            InitializeAll();
        }

        private void InitializeAll()
        {
            string[] device_name = { "Compact", "RM", "Mom", "ASL_Digital", "Analog", "Reachtime", "Sip_N_Pull_Digital", "PACMS" };
            string[] main_device_name = { "Display", "RMPJ" };
            string[] tilt_name = { "None", "Formula", "CG", "Conventional" };
            string[] legs_name = { "None", "Center Mount", "Dual Independent" };
            string[] rec_name = { "None", "Formula", "Conventional" };
            string[] elevate_name = { "None", "Beniste" };
            string[] actuator_name = { "None", "4_Switch", "Multi-Activator", "SANODE" };
            string[] misc_name = { "ECU_1_2", "ECU_3_4", "ACC1", "ACC2", "TNC", "ASL_528", "SM_1_2", "IR_Module" };

            string[] speed_name = { "speed", "response" };
            string[] foward_name = { "Foward_speed", "Foward_Accel", "Foward_Braking" };
            string[] reverse_name = { "Reverse_speed", "Reverse_Accel", "Reverse_Braking" };
            string[] turn_name = { "Turn_speed", "Turn_Accel", "Turn_Braking" };
            string[] joystick_name = { "Tremor_Dampening", "Power_Level", "G_Track_Enable", "Torque", "Traction" };


            InitializeComponent();

            InitializeCheckBoxList(Main_DeviceBox, MainCheckBoxList, main_device_name);
            InitializeCheckBoxList(inputDeviceBox, DeviceCheckBoxList, device_name);
            InitializeCheckBoxList(TiltBox, TiltCheckBoxList, tilt_name);
            InitializeCheckBoxList(LegsBox, LegsCheckBoxList, legs_name);
            InitializeCheckBoxList(ReclineBox, RecCheckBoxList, rec_name);
            InitializeCheckBoxList(ElevateBox, ElevateCheckBoxList, elevate_name);
            InitializeCheckBoxList(ActuatorBox, ActCheckBoxList, actuator_name);
            InitializeCheckBoxList(MiscallenousBox, MiscCheckBoxList, misc_name);

            InitializeTextBoxList(speedbox, speedList, speed_name);
            InitializeTextBoxList(fowardbox, fowardList, foward_name);
            InitializeTextBoxList(reversebox, reverseList, reverse_name);
            InitializeTextBoxList(turnbox, turnList, turn_name);
            InitializeTextBoxList(joystick, joystickList, joystick_name);

            InitializeLabel(speedbox, speedList);
            InitializeLabel(fowardbox, fowardList);
            InitializeLabel(reversebox, reverseList);
            InitializeLabel(turnbox, turnList);
            InitializeLabel(joystick, joystickList);


        }

        void InitializeCheckBoxList(GroupBox box, List<CheckBox> list, string[] listname)
        {
            int topPosition = 30;

            foreach (string name in listname)
            {
                CheckBox checkBox = new CheckBox();

                checkBox.Top = topPosition;
                checkBox.Left = 10;
                checkBox.Text = name;
                checkBox.Name = name;

                topPosition += 30;

                box.Controls.Add(checkBox);

                list.Add(checkBox);
                AllCheckBoxList.Add(checkBox);
            }
        }

        void InitializeTextBoxList(GroupBox box, List<TextBox> list, string[] listname)
        {
            int topValue = 25;
            int topPosition = topValue;
            int posX = 0;
            int column = 0;
            
            int previousLeft = box.Left+50;
            int previousRight = box.Right;
            while(numbColumn>column)
            { 
                foreach (string name in listname)
                {
                    TextBox textbox = new TextBox();
                    
                    textbox.Top = topPosition;

                    textbox.Name = name + column;

                    textbox.Width = 40;
                    posX = textbox.Width +1;
                    textbox.Left = previousLeft + posX;

                    topPosition += topValue;

                    box.Controls.Add(textbox);

                    list.Add(textbox);
                    AllTextBoxList.Add(textbox);

                    previousRight = textbox.Right;
                
                }
                previousLeft = previousRight + posX;
                topPosition = topValue;
                column++;
            }
        }
        void InitializeLabel(GroupBox box, List<TextBox> list)
        {
            for (int i = 0; i < list.Count / numbColumn; i++)
            {
                Label lbl = new Label();
                lbl.Top = list[i].Top;
                lbl.Left = Math.Abs(list[i].Left - 100);

                if (list[i].Name[list[i].Name.Length - 1] != '0')
                    lbl.Text = list[i].Name;
                else
                    lbl.Text = list[i].Name.Remove(list[i].Name.Length - 1);
                    
                lbl.Name = list[i].Name;
                box.Controls.Add(lbl);
            }
        }

        private void sauvegardebtnpage1_Click(object sender, EventArgs e)
        {

            int parsedValue = 0;
            var root = new XElement("Root","");
            var Main_DeviceBox = new XElement("Main_DeviceBox", "");
            var inputDeviceBox = new XElement("inputDeviceBox", "");
            var ActuatorBox = new XElement("ActuatorBox", "");
            var ReclineBox = new XElement("ReclineBox", "");
            var LegsBox = new XElement("LegsBox", "");
            var ElevateBox = new XElement("ElevateBox", "");
            var TiltBox = new XElement("TiltBox", "");
            var MiscallenousBox = new XElement("MiscallenousBox", "");

            for (int pos = 0; pos < AllCheckBoxList.Count; pos++)
            {

                CheckBox chk = AllCheckBoxList[pos];
                if (chk.Checked)
                {
                        string temp = chk.Name.Trim();
                        MessageBox.Show("For " + temp + " value is " + chk.Text + "and parent is " + chk.Parent.Name);

                        switch (chk.Parent.Name)
                        {

                            case "Main_DeviceBox":
                                //childSpeed.Add(txt.Name);
                                Main_DeviceBox.SetElementValue(chk.Name, chk.Checked.ToString());
                                break;
                            case "inputDeviceBox":
                                //childFoward.Add(txt.Name);
                                inputDeviceBox.SetElementValue(chk.Name, chk.Checked.ToString());
                                break;
                            case "ActuatorBox":
                                //childReverse.Add(txt.Name);
                                ActuatorBox.SetElementValue(chk.Name, chk.Checked.ToString());
                                break;
                            case "ReclineBox":
                                //childTurn.Add(txt.Name);
                                ReclineBox.SetElementValue(chk.Name, chk.Checked.ToString());
                                break;
                            case "LegsBox":
                                //childJoystick.Add(txt.Name);
                                LegsBox.SetElementValue(chk.Name, chk.Checked.ToString());
                                break;
                            case "ElevateBox":
                                //childReverse.Add(txt.Name);
                                ElevateBox.SetElementValue(chk.Name, chk.Checked.ToString());
                                break;
                            case "TiltBox":
                                //childTurn.Add(txt.Name);
                                TiltBox.SetElementValue(chk.Name, chk.Checked.ToString());
                                break;
                            case "MiscallenousBox":
                                //childJoystick.Add(txt.Name);
                                MiscallenousBox.SetElementValue(chk.Name, chk.Checked.ToString());
                                break;

                            default: break;
                        }
                }
            }
            root.Add(Main_DeviceBox, inputDeviceBox, ActuatorBox, ReclineBox, LegsBox, ElevateBox, TiltBox, MiscallenousBox);      
            root.Save(ConfigXML); 
        }

        

        private void sauvegardebtnpage2_Click(object sender, EventArgs e)
        {
            int parsedValue = 0;
            var root = new XElement("Root","");
            var childSpeed = new XElement("Speed", "");
            var childFoward = new XElement("Foward", "");
            var childReverse = new XElement("Reverse", "");
            var childTurn = new XElement("Turn", "");
            var childJoystick = new XElement("Joystick", "");

            for (int pos = 0; pos < AllTextBoxList.Count; pos++)
            {

                TextBox txt = AllTextBoxList[pos];
                if (int.TryParse(txt.Text, out parsedValue))
                {
                        string temp = txt.Name.Trim();
                        MessageBox.Show("For " + temp + " value is " + txt.Text + "and parent is " + txt.Parent.Name);

                        switch (txt.Parent.Name)
                        { 
                            case "speedbox":
                                //childSpeed.Add(txt.Name);
                                childSpeed.SetElementValue(txt.Name, txt.Text.ToString());
                                break;
                            case "fowardbox":
                                //childFoward.Add(txt.Name);
                                childFoward.SetElementValue(txt.Name, txt.Text.ToString());
                                break;
                            case "reversebox":
                                //childReverse.Add(txt.Name);
                                childReverse.SetElementValue(txt.Name, txt.Text.ToString());
                                break;
                            case "turnbox":
                                //childTurn.Add(txt.Name);
                                childTurn.SetElementValue(txt.Name, txt.Text.ToString());
                                break;
                            case "joystickbox":
                                //childJoystick.Add(txt.Name);
                                childJoystick.SetElementValue(txt.Name, txt.Text.ToString());
                                break;

                            default: break;
                        }
                }
            }
            root.Add(childSpeed,childFoward,childReverse,childTurn,childJoystick);      
            root.Save(PerfAjustXML); 
        }
    }
}


