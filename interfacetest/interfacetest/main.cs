using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

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

        static protected XmlDocument conf;
        static protected XmlDocument perfajust;

        //number of col in tabpage2
        static private int numbColumn = 4;

        public main()
        {  
            InitializeAll();
        }

        private void InitializeAll()
        {
            string[] device_name = { "Compact", "RM", "Mom", "ASL Digital", "Analog", "Reachtime", "Sip N Pull/Digital", "PACMS" };
            string[] main_device_name = { "Display", "RMPJ" };
            string[] tilt_name = { "None", "Formula", "CG", "Conventional" };
            string[] legs_name = { "None", "Center Mount", "Dual Independent" };
            string[] rec_name = { "None", "Formula", "Conventional" };
            string[] elevate_name = { "None", "Beniste" };
            string[] actuator_name = { "None", "4 Switch", "Multi-Activator", "SANODE" };
            string[] misc_name = { "ECU 1/2", "ECU 3/4", "ACC1", "ACC2", "TNC", "ASL 528", "SM 1/2", "IR Module" };

            string[] speed_name = { "speed", "response" };
            string[] foward_name = { "Foward speed", "Foward Accel", "Foward Braking" };
            string[] reverse_name = { "Reverse speed", "Reverse Accel", "Reverse Braking" };
            string[] turn_name = { "Turn speed", "Turn Accel", "Turn Braking" };
            string[] joystick_name = { "Tremor Dampening", "Power Level", "G Track Enable", "Torque", "Traction" };


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
                    
                    if(column != 0)
                        textbox.Name = name + column;
                    else
                        textbox.Name = name;
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
                lbl.Name = list[i].Name;
                lbl.Text = list[i].Name;
                box.Controls.Add(lbl);
            }
        }

        private void sauvegarde_Click(object sender, EventArgs e)
        {
            foreach (CheckBox chk in AllCheckBoxList)
            {
                if(chk.Checked)
                    MessageBox.Show(chk.Name);
            }
        }

        private void sauvegardebtnpage1_Click(object sender, EventArgs e)
        {
            foreach (CheckBox chk in AllCheckBoxList)
            {
                if (chk.Checked)
                    MessageBox.Show(chk.Name);
            }
        }

        //XML create or overwrite
        private Boolean writeXML(string name)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement el = (XmlElement)doc.AppendChild(doc.CreateElement("Foo"));
            el.SetAttribute("Bar", "some & value");
            el.AppendChild(doc.CreateElement("Nested")).InnerText = "data";
            Console.WriteLine(doc.OuterXml);
            return true;
        }

        private void sauvegardebtnpage2_Click(object sender, EventArgs e)
        {
            int parsedValue = 0;
            for (int pos = 0; pos < AllTextBoxList.Count; pos++)
            {
                TextBox txt = AllTextBoxList[pos];
                if (int.TryParse(txt.Text, out parsedValue))
                {
                    MessageBox.Show("For "+txt.Name+" value is "  + txt.Text);
                    writeXML("gg");
                }
            }
        }
    }
}


