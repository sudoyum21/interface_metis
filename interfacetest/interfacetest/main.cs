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
using System.Security.Cryptography.X509Certificates;


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

        static private List<XElement> XEl1 = new List<XElement>();
        static private List<XElement> XEl2 = new List<XElement>();

        static protected string ConfigXML = "Configuration";
        static protected string PerfAjustXML = "PerformanceAjustment";

        static protected string[] element2 = { "root", "speedbox", "fowardbox", "reversebox", "turnbox", "joystickbox" };
        static protected string[] element1 = { "root", "inputDeviceBox", "MiscallenousBox", "TiltBox", "ElevateBox", "Main_DeviceBox", "LegsBox", "ReclineBox", "ActuatorBox" };


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
            string[] legs_name = { "None", "Center_Mount", "Dual_Independent" };
            string[] rec_name = { "None", "Formula", "Conventional" };
            string[] elevate_name = { "None", "Beniste" };
            string[] actuator_name = { "None", "four_Switch", "Multi-Activator", "SANODE" };
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

            

            for (int i = 0; i < element1.Length; i++)
            {       
                XElement temp1 = new XElement(element1[i]);
                XEl1.Add(temp1);
            }
            for (int i = 0; i < element2.Length; i++)
            {
                XElement temp2 = new XElement(element2[i]);
                XEl2.Add(temp2);
            }


        }
        //initialisation de tous les checkbox dans page 1
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
        //initialisation de tous les textbox dans page 2
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
               
                  
                    textbox.Click += new EventHandler(this.ClearColorOnClick);

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

        //Clear le background color 
        private void ClearColorOnClick(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            txt.BackColor = Color.White;
        }
        //intialisation de tous les noms des textbox dans page 2
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
        //handler du click save de page 1
        private void sauvegardebtnpage1_Click(object sender, EventArgs e)
        {
            for (int pos = 0; pos < AllCheckBoxList.Count; pos++)
            {

                CheckBox chk = AllCheckBoxList[pos];
                if (chk.Checked)
                {
                        string temp = chk.Name.Trim();
                        //MessageBox.Show("For " + temp + " value is " + chk.Text);
                        for (int i = 1; i < XEl1.Count; i++)
                        {
                            if (chk.Parent.Name == XEl1[i].Name)
                            {
                                XEl1[i].SetElementValue(chk.Name, chk.Checked.ToString());
                            }
                        }
                }
            }
            for (int i = 1; i < XEl1.Count; i++)
            {
                XEl1[0].Add(XEl1[i]);
            } 

            XEl1[0].Save(ConfigXML);
            ClearAndResetXML(XEl1, element1);
        }


        
        //handler du click save de page 2
        private void sauvegardebtnpage2_Click(object sender, EventArgs e)
        {
            int parsedValue = 0;
            for (int pos = 0; pos < AllTextBoxList.Count; pos++)
            {
                TextBox txt = AllTextBoxList[pos];
                if (int.TryParse(txt.Text, out parsedValue) && Convert.ToDouble (txt.Text) <= 100  && Convert.ToDouble(txt.Text) >= 0)
                {
                    {
                        string temp = txt.Name.Trim();
                        //MessageBox.Show("For " + temp + " value is " + txt.Text);
                        for(int i = 1 ; i < XEl2.Count; i++)
                        {
                            if (txt.Parent.Name == XEl2[i].Name)
                            {
                                XEl2[i].SetElementValue(txt.Name, txt.Text.ToString());
                            }
                        }
                    }
                   
                }
                else
                {
                    txt.Text = "";
                    txt.BackColor = Color.Red;
                }
            }
            for (int i = 1; i < XEl2.Count; i++)
            {
                XEl2[0].Add(XEl2[i]);
            }
            XEl2[0].Save(PerfAjustXML);
            ClearAndResetXML(XEl2, element2);
        }

        private void ClearAndResetXML(List<XElement> XEl, string [] element)
        {
            XEl.Clear();

            for (int i = 0; i < element.Length; i++)
            {
                XElement temp1 = new XElement(element[i]);
                XEl.Add(temp1);
            }
        }

        private void Clear1_Click(object sender, EventArgs e)
        {
            foreach (CheckBox box in AllCheckBoxList)
            {
                box.Checked = false;
            }
        }

        private void Clear2_Click(object sender, EventArgs e)
        {
            foreach (TextBox txt in AllTextBoxList)
            {
                txt.Text = "";
                txt.BackColor = Color.White;
            }
        }

    }

    public class X509
    {

        public static void cert_main()
        {

            // The path to the certificate.
            string Certificate = "sitem.cer";

            // Load the certificate into an X509Certificate object.
            X509Certificate cert = new X509Certificate(Certificate);

            // Get the value.
            string resultsTrue = cert.ToString(true);

            // Display the value to the console.
            Console.WriteLine(resultsTrue);

            // Get the value.
            string resultsFalse = cert.ToString(false);

            // Display the value to the console.
            Console.WriteLine(resultsFalse);

        }

    }
}


