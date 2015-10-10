using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO; 


using System.Data;

namespace NewOSEKGen
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class OSEKForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TreeView OStree;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.ContextMenu MyContext;
		private System.Windows.Forms.ComboBox TaskType;
		private System.Windows.Forms.TextBox TaskPriority;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TaskActivation;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox TaskSchedule;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox TaskStackSize;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox Comment1;
		private System.Windows.Forms.TextBox Comment2;
		private System.Windows.Forms.TextBox Comment3;
		private System.Windows.Forms.TextBox Comment4;
		private System.Windows.Forms.TextBox Comment5;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.ComboBox TaskEvent;
		private System.Windows.Forms.ComboBox TaskResource;
		private System.Windows.Forms.GroupBox TaskProperty;
		private System.Windows.Forms.ComboBox TskCallScheduler;
		private System.Windows.Forms.TextBox Comment6;
		private System.Windows.Forms.TextBox Comment8;
		private System.Windows.Forms.TextBox Comment7;
		// Task propperty
		private Task[] TaskList = new Task[16];
		private int TaskCounter = 0;
		private System.Windows.Forms.PictureBox TULogo;
		private System.Windows.Forms.Button NewFileButton;
		private System.Windows.Forms.Button OpenFileButton;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.Button GenerateButton;
		private System.Windows.Forms.Button StatisticsButton;
		private System.Windows.Forms.ToolTip toolTipNew;
		private System.Windows.Forms.Button ValidateIt;
		private System.ComponentModel.IContainer components;

		public OSEKForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(OSEKForm));
			this.OStree = new System.Windows.Forms.TreeView();
			this.MyContext = new System.Windows.Forms.ContextMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.TaskProperty = new System.Windows.Forms.GroupBox();
			this.label15 = new System.Windows.Forms.Label();
			this.Comment8 = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.Comment7 = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.TaskResource = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.Comment6 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.Comment5 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.Comment4 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.Comment3 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.Comment2 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.TskCallScheduler = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.TaskStackSize = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.TaskSchedule = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.TaskActivation = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.TaskType = new System.Windows.Forms.ComboBox();
			this.TaskPriority = new System.Windows.Forms.TextBox();
			this.Comment1 = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.TaskEvent = new System.Windows.Forms.ComboBox();
			this.TULogo = new System.Windows.Forms.PictureBox();
			this.NewFileButton = new System.Windows.Forms.Button();
			this.OpenFileButton = new System.Windows.Forms.Button();
			this.SaveButton = new System.Windows.Forms.Button();
			this.ValidateIt = new System.Windows.Forms.Button();
			this.GenerateButton = new System.Windows.Forms.Button();
			this.StatisticsButton = new System.Windows.Forms.Button();
			this.toolTipNew = new System.Windows.Forms.ToolTip(this.components);
			this.TaskProperty.SuspendLayout();
			this.SuspendLayout();
			// 
			// OStree
			// 
			this.OStree.ImageIndex = -1;
			this.OStree.LabelEdit = true;
			this.OStree.Location = new System.Drawing.Point(8, 64);
			this.OStree.Name = "OStree";
			this.OStree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
																			   new System.Windows.Forms.TreeNode("OSEK_CONF", new System.Windows.Forms.TreeNode[] {
																																									  new System.Windows.Forms.TreeNode("OS"),
																																									  new System.Windows.Forms.TreeNode("TASK"),
																																									  new System.Windows.Forms.TreeNode("ISR"),
																																									  new System.Windows.Forms.TreeNode("COUNTER"),
																																									  new System.Windows.Forms.TreeNode("MESSAGE"),
																																									  new System.Windows.Forms.TreeNode("APPMODE"),
																																									  new System.Windows.Forms.TreeNode("ALARM"),
																																									  new System.Windows.Forms.TreeNode("EVENT"),
																																									  new System.Windows.Forms.TreeNode("RESOURCE")})});
			this.OStree.SelectedImageIndex = -1;
			this.OStree.Size = new System.Drawing.Size(232, 504);
			this.OStree.TabIndex = 0;
			this.OStree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseIsClick);
			this.OStree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.NewSelectedItem);
			this.OStree.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.OStree_AfterLabelEdit);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = -1;
			this.menuItem1.Text = "";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = -1;
			this.menuItem2.Text = "";
			// 
			// menuItem3
			// 
			this.menuItem3.Index = -1;
			this.menuItem3.Text = "";
			// 
			// TaskProperty
			// 
			this.TaskProperty.Controls.Add(this.label15);
			this.TaskProperty.Controls.Add(this.Comment8);
			this.TaskProperty.Controls.Add(this.label16);
			this.TaskProperty.Controls.Add(this.Comment7);
			this.TaskProperty.Controls.Add(this.label14);
			this.TaskProperty.Controls.Add(this.TaskResource);
			this.TaskProperty.Controls.Add(this.label12);
			this.TaskProperty.Controls.Add(this.Comment6);
			this.TaskProperty.Controls.Add(this.label11);
			this.TaskProperty.Controls.Add(this.Comment5);
			this.TaskProperty.Controls.Add(this.label10);
			this.TaskProperty.Controls.Add(this.Comment4);
			this.TaskProperty.Controls.Add(this.label9);
			this.TaskProperty.Controls.Add(this.Comment3);
			this.TaskProperty.Controls.Add(this.label8);
			this.TaskProperty.Controls.Add(this.Comment2);
			this.TaskProperty.Controls.Add(this.label7);
			this.TaskProperty.Controls.Add(this.label6);
			this.TaskProperty.Controls.Add(this.TskCallScheduler);
			this.TaskProperty.Controls.Add(this.label5);
			this.TaskProperty.Controls.Add(this.TaskStackSize);
			this.TaskProperty.Controls.Add(this.label4);
			this.TaskProperty.Controls.Add(this.TaskSchedule);
			this.TaskProperty.Controls.Add(this.label3);
			this.TaskProperty.Controls.Add(this.TaskActivation);
			this.TaskProperty.Controls.Add(this.label2);
			this.TaskProperty.Controls.Add(this.label1);
			this.TaskProperty.Controls.Add(this.TaskType);
			this.TaskProperty.Controls.Add(this.TaskPriority);
			this.TaskProperty.Controls.Add(this.Comment1);
			this.TaskProperty.Controls.Add(this.label13);
			this.TaskProperty.Controls.Add(this.TaskEvent);
			this.TaskProperty.Location = new System.Drawing.Point(256, 112);
			this.TaskProperty.Name = "TaskProperty";
			this.TaskProperty.Size = new System.Drawing.Size(536, 328);
			this.TaskProperty.TabIndex = 1;
			this.TaskProperty.TabStop = false;
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(248, 264);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(80, 16);
			this.label15.TabIndex = 28;
			this.label15.Text = "Comment";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Comment8
			// 
			this.Comment8.AutoSize = false;
			this.Comment8.Location = new System.Drawing.Point(336, 264);
			this.Comment8.Name = "Comment8";
			this.Comment8.Size = new System.Drawing.Size(176, 20);
			this.Comment8.TabIndex = 27;
			this.Comment8.Text = "";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(248, 232);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(80, 16);
			this.label16.TabIndex = 26;
			this.label16.Text = "Comment";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Comment7
			// 
			this.Comment7.AutoSize = false;
			this.Comment7.Location = new System.Drawing.Point(336, 232);
			this.Comment7.Name = "Comment7";
			this.Comment7.Size = new System.Drawing.Size(176, 20);
			this.Comment7.TabIndex = 25;
			this.Comment7.Text = "";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(16, 264);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(80, 16);
			this.label14.TabIndex = 24;
			this.label14.Text = "Resource";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// TaskResource
			// 
			this.TaskResource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TaskResource.Location = new System.Drawing.Point(104, 264);
			this.TaskResource.Name = "TaskResource";
			this.TaskResource.Size = new System.Drawing.Size(121, 21);
			this.TaskResource.TabIndex = 23;
			this.TaskResource.SelectionChangeCommitted += new System.EventHandler(this.TaskResource_TextChanged);
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(248, 200);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(80, 16);
			this.label12.TabIndex = 22;
			this.label12.Text = "Comment";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Comment6
			// 
			this.Comment6.AutoSize = false;
			this.Comment6.Location = new System.Drawing.Point(336, 200);
			this.Comment6.Name = "Comment6";
			this.Comment6.Size = new System.Drawing.Size(176, 20);
			this.Comment6.TabIndex = 21;
			this.Comment6.Text = "";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(248, 168);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(80, 16);
			this.label11.TabIndex = 20;
			this.label11.Text = "Comment";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Comment5
			// 
			this.Comment5.AutoSize = false;
			this.Comment5.Location = new System.Drawing.Point(336, 168);
			this.Comment5.Name = "Comment5";
			this.Comment5.Size = new System.Drawing.Size(176, 20);
			this.Comment5.TabIndex = 19;
			this.Comment5.Text = "";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(248, 136);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(80, 16);
			this.label10.TabIndex = 18;
			this.label10.Text = "Comment";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Comment4
			// 
			this.Comment4.AutoSize = false;
			this.Comment4.Location = new System.Drawing.Point(336, 136);
			this.Comment4.Name = "Comment4";
			this.Comment4.Size = new System.Drawing.Size(176, 20);
			this.Comment4.TabIndex = 17;
			this.Comment4.Text = "";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(248, 104);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 16);
			this.label9.TabIndex = 16;
			this.label9.Text = "Comment";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Comment3
			// 
			this.Comment3.AutoSize = false;
			this.Comment3.Location = new System.Drawing.Point(336, 104);
			this.Comment3.Name = "Comment3";
			this.Comment3.Size = new System.Drawing.Size(176, 20);
			this.Comment3.TabIndex = 15;
			this.Comment3.Text = "";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(248, 72);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 16);
			this.label8.TabIndex = 14;
			this.label8.Text = "Comment";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Comment2
			// 
			this.Comment2.AutoSize = false;
			this.Comment2.Location = new System.Drawing.Point(336, 72);
			this.Comment2.Name = "Comment2";
			this.Comment2.Size = new System.Drawing.Size(176, 20);
			this.Comment2.TabIndex = 13;
			this.Comment2.Text = "";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(248, 40);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 16);
			this.label7.TabIndex = 12;
			this.label7.Text = "Comment";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 200);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 16);
			this.label6.TabIndex = 11;
			this.label6.Text = "Call Scheduler";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// TskCallScheduler
			// 
			this.TskCallScheduler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TskCallScheduler.Items.AddRange(new object[] {
																  "",
																  "DONTKNOW",
																  "YES",
																  "NO"});
			this.TskCallScheduler.Location = new System.Drawing.Point(104, 200);
			this.TskCallScheduler.Name = "TskCallScheduler";
			this.TskCallScheduler.Size = new System.Drawing.Size(121, 21);
			this.TskCallScheduler.TabIndex = 10;
			this.TskCallScheduler.SelectionChangeCommitted += new System.EventHandler(this.TskCallScheduler_TextChanged);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 168);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 16);
			this.label5.TabIndex = 9;
			this.label5.Text = "Task Stack Size";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// TaskStackSize
			// 
			this.TaskStackSize.Location = new System.Drawing.Point(104, 168);
			this.TaskStackSize.Name = "TaskStackSize";
			this.TaskStackSize.Size = new System.Drawing.Size(120, 20);
			this.TaskStackSize.TabIndex = 8;
			this.TaskStackSize.Text = "";
			this.TaskStackSize.TextChanged += new System.EventHandler(this.TaskStackSize_TextChanged);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 16);
			this.label4.TabIndex = 7;
			this.label4.Text = "Task Schedule";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// TaskSchedule
			// 
			this.TaskSchedule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TaskSchedule.Items.AddRange(new object[] {
															  "",
															  "FULL",
															  "NON"});
			this.TaskSchedule.Location = new System.Drawing.Point(104, 136);
			this.TaskSchedule.Name = "TaskSchedule";
			this.TaskSchedule.Size = new System.Drawing.Size(121, 21);
			this.TaskSchedule.TabIndex = 6;
			this.TaskSchedule.SelectionChangeCommitted += new System.EventHandler(this.TaskSchedule_TextChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 16);
			this.label3.TabIndex = 5;
			this.label3.Text = "Task Activation";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// TaskActivation
			// 
			this.TaskActivation.Location = new System.Drawing.Point(104, 104);
			this.TaskActivation.Name = "TaskActivation";
			this.TaskActivation.Size = new System.Drawing.Size(120, 20);
			this.TaskActivation.TabIndex = 4;
			this.TaskActivation.Text = "";
			this.TaskActivation.TextChanged += new System.EventHandler(this.TaskActivation_TextChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Task Priority";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(32, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Task Type";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// TaskType
			// 
			this.TaskType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TaskType.Items.AddRange(new object[] {
														  "",
														  "AUTO",
														  "BASIC",
														  "EXTENDED"});
			this.TaskType.Location = new System.Drawing.Point(104, 40);
			this.TaskType.Name = "TaskType";
			this.TaskType.Size = new System.Drawing.Size(121, 21);
			this.TaskType.TabIndex = 1;
			this.TaskType.SelectionChangeCommitted += new System.EventHandler(this.TaskType_TextChanged);
			// 
			// TaskPriority
			// 
			this.TaskPriority.AutoSize = false;
			this.TaskPriority.Location = new System.Drawing.Point(104, 72);
			this.TaskPriority.MaxLength = 255;
			this.TaskPriority.Name = "TaskPriority";
			this.TaskPriority.Size = new System.Drawing.Size(120, 20);
			this.TaskPriority.TabIndex = 0;
			this.TaskPriority.Text = "";
			this.TaskPriority.TextChanged += new System.EventHandler(this.TaskPriority_TextChanged);
			// 
			// Comment1
			// 
			this.Comment1.AutoSize = false;
			this.Comment1.Location = new System.Drawing.Point(336, 40);
			this.Comment1.Name = "Comment1";
			this.Comment1.Size = new System.Drawing.Size(176, 20);
			this.Comment1.TabIndex = 2;
			this.Comment1.Text = "";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(16, 232);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(80, 16);
			this.label13.TabIndex = 13;
			this.label13.Text = "Event";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// TaskEvent
			// 
			this.TaskEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TaskEvent.Items.AddRange(new object[] {
														   ""});
			this.TaskEvent.Location = new System.Drawing.Point(104, 232);
			this.TaskEvent.Name = "TaskEvent";
			this.TaskEvent.Size = new System.Drawing.Size(121, 21);
			this.TaskEvent.TabIndex = 12;
			this.TaskEvent.SelectionChangeCommitted += new System.EventHandler(this.TaskEvent_TextChanged);
			// 
			// TULogo
			// 
			this.TULogo.Location = new System.Drawing.Point(688, 464);
			this.TULogo.Name = "TULogo";
			this.TULogo.Size = new System.Drawing.Size(104, 104);
			this.TULogo.TabIndex = 2;
			this.TULogo.TabStop = false;
			// 
			// NewFileButton
			// 
			this.NewFileButton.Image = ((System.Drawing.Image)(resources.GetObject("NewFileButton.Image")));
			this.NewFileButton.Location = new System.Drawing.Point(16, 16);
			this.NewFileButton.Name = "NewFileButton";
			this.NewFileButton.Size = new System.Drawing.Size(40, 40);
			this.NewFileButton.TabIndex = 3;
			this.toolTipNew.SetToolTip(this.NewFileButton, "toolTipNew");
			this.NewFileButton.Click += new System.EventHandler(this.NewFileButton_Click);
			this.NewFileButton.MouseHover += new System.EventHandler(this.MouseOver_NewButton);
			// 
			// OpenFileButton
			// 
			this.OpenFileButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenFileButton.Image")));
			this.OpenFileButton.Location = new System.Drawing.Point(72, 16);
			this.OpenFileButton.Name = "OpenFileButton";
			this.OpenFileButton.Size = new System.Drawing.Size(40, 40);
			this.OpenFileButton.TabIndex = 4;
			this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
			this.OpenFileButton.MouseHover += new System.EventHandler(this.MouseOver_OpenButton);
			// 
			// SaveButton
			// 
			this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
			this.SaveButton.Location = new System.Drawing.Point(128, 16);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(40, 40);
			this.SaveButton.TabIndex = 5;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			this.SaveButton.MouseHover += new System.EventHandler(this.MouseOver_SaveButton);
			// 
			// ValidateIt
			// 
			this.ValidateIt.Image = ((System.Drawing.Image)(resources.GetObject("ValidateIt.Image")));
			this.ValidateIt.Location = new System.Drawing.Point(184, 16);
			this.ValidateIt.Name = "ValidateIt";
			this.ValidateIt.Size = new System.Drawing.Size(40, 40);
			this.ValidateIt.TabIndex = 7;
			this.ValidateIt.MouseHover += new System.EventHandler(this.MouseOver_);
			// 
			// GenerateButton
			// 
			this.GenerateButton.Image = ((System.Drawing.Image)(resources.GetObject("GenerateButton.Image")));
			this.GenerateButton.Location = new System.Drawing.Point(240, 16);
			this.GenerateButton.Name = "GenerateButton";
			this.GenerateButton.Size = new System.Drawing.Size(40, 40);
			this.GenerateButton.TabIndex = 8;
			this.GenerateButton.MouseHover += new System.EventHandler(this.MouseOver_Generated);
			// 
			// StatisticsButton
			// 
			this.StatisticsButton.Image = ((System.Drawing.Image)(resources.GetObject("StatisticsButton.Image")));
			this.StatisticsButton.Location = new System.Drawing.Point(304, 16);
			this.StatisticsButton.Name = "StatisticsButton";
			this.StatisticsButton.Size = new System.Drawing.Size(40, 40);
			this.StatisticsButton.TabIndex = 29;
			this.StatisticsButton.MouseHover += new System.EventHandler(this.MouseOver_StatisticsButton);
			// 
			// OSEKForm
			// 
			this.AccessibleDescription = "OSEK Generator";
			this.AccessibleName = "OSEK_Generator";
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(800, 581);
			this.Controls.Add(this.GenerateButton);
			this.Controls.Add(this.ValidateIt);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.OpenFileButton);
			this.Controls.Add(this.NewFileButton);
			this.Controls.Add(this.TULogo);
			this.Controls.Add(this.TaskProperty);
			this.Controls.Add(this.OStree);
			this.Controls.Add(this.StatisticsButton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "OSEKForm";
			this.Text = "OSEK Generator";
			this.Load += new System.EventHandler(this.LoadForm);
			this.TaskProperty.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		//==============================================================================
		// DESCRIPTION :		
		//
		// PARAMETERS (Type,Name,Min,Max) :
		//
		// RETURN VALUE :
		//
		// DESIGN INFORMATION :
		//==============================================================================
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new OSEKForm());
		}
		//==============================================================================
		// DESCRIPTION :		
		//
		// PARAMETERS (Type,Name,Min,Max) :
		//
		// RETURN VALUE :
		//
		// DESIGN INFORMATION :
		//==============================================================================
		private void LoadForm(object sender, System.EventArgs e)
		{
			OStree.ExpandAll();
			OStree.ContextMenu = MyContext;	
			ManageTaskProperty(false);
			//TULogo.Image=new Bitmap("D:\\Projects\\Development\\NewOSEKGen\\NewOSEKGen\\icons\\logo_tu.jpg"); 
		//LogoImage.Image = new Bitmap("D:\\Projects\\Development\\NewOSEKGen\\NewOSEKGen\\icons\\logo_tu.jpg"); 
			SaveButton.Enabled = false;
			ValidateIt.Enabled = false;
			GenerateButton.Enabled = false;
			StatisticsButton.Enabled = false;
			OStree.Enabled = false;
			OStree.Visible = false;

		}
		//==============================================================================
		// DESCRIPTION :		
		//
		// PARAMETERS (Type,Name,Min,Max) :
		//
		// RETURN VALUE :
		//
		// DESIGN INFORMATION :
		//==============================================================================	
		private void NewSelectedItem(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			FormContextMenu();
			ManagePropertyMenu();
			ManageTskValues(false);
		}


		
		//==============================================================================
		// DESCRIPTION :		
		//
		// PARAMETERS (Type,Name,Min,Max) :
		//
		// RETURN VALUE :
		//
		// DESIGN INFORMATION :
		//==============================================================================	
		private void ManagePropertyMenu()
		{
			ManageTaskProperty(false);
			// First level
			if("OSEK_CONF" == OStree.SelectedNode.Text)
			{
			}
				//Second Level
			else if(
				    (null != OStree.SelectedNode.Parent)&&				
				    ("OSEK_CONF" == OStree.SelectedNode.Parent.Text)
				   )
			{
			
			}
				// Third level
			else if(
					(null != OStree.SelectedNode.Parent)&&
					(null != OStree.SelectedNode.Parent.Parent)&&
					("OSEK_CONF" == OStree.SelectedNode.Parent.Parent.Text)
					)
			{
				if("TASK" == OStree.SelectedNode.Parent.Text)
				{
					TaskProperty.Text = OStree.SelectedNode.Text;
					ManageTaskProperty(true);
				}
			}
			else
			{
				MessageBox.Show("Unknown selection!");
			}
			
			
			}
		//==============================================================================
		// DESCRIPTION :		
		//
		// PARAMETERS (Type,Name,Min,Max) :
		//
		// RETURN VALUE :
		//
		// DESIGN INFORMATION :
		//==============================================================================
		private void MouseIsClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)  
			{  
				TreeNode CurrentSelectedNode = OStree.GetNodeAt(e.X, e.Y);
				if(null != CurrentSelectedNode)
				{			
					OStree.SelectedNode = CurrentSelectedNode;
					// FormContextMenu(); was here move to NewSelectedItem ==EXCEPTION==
					
				}								  
			}  
		}
		//==============================================================================
		// DESCRIPTION :		
		//
		// PARAMETERS (Type,Name,Min,Max) :
		//
		// RETURN VALUE :
		//
		// DESIGN INFORMATION :
		//==============================================================================
		private void OnMiceClick(object sender, EventArgs e)
		{
			DisableEvents();
			MenuItem miClicked = (MenuItem)sender;
			string item = miClicked.Text;
			string t = MyContext.ToString();
			if("OSEK_CONF" == OStree.SelectedNode.Text)
			{
				return;
			}
			else
			{
				if( (null != OStree.SelectedNode.Parent)&&
					("OSEK_CONF" == OStree.SelectedNode.Parent.Text)
					)
				{
					if("New" == item)
					{											
						OStree.SelectedNode.Nodes.Add("OSEK Properties");

						try
						{
							// OS should have only one set of property
							MyContext.MenuItems.Clear();
		
						}
						catch
						{
							MessageBox.Show("Problem in the clear context menu");
						}															
					}
					else if("Add" == item)
					{
						string NameForm = OStree.SelectedNode.Text + "_Child" + (TaskCounter + (int)1).ToString();
						OStree.SelectedNode.Nodes.Add(NameForm);
						if("TASK" == OStree.SelectedNode.Text)
						{
							// Allocate space for task's struct
							TaskList[TaskCounter++] = new Task();
							if(TaskCounter >= (int)16)
							{
								MessageBox.Show("Exceeeded max number of tasks");
							}

						}
						
					}
					else
					{
						MessageBox.Show("Unkown context menu item for first deptch!");
					}
				}
				else if(
					(null != OStree.SelectedNode.Parent)&&
					(null != OStree.SelectedNode.Parent.Parent)&&
					("OSEK_CONF" == OStree.SelectedNode.Parent.Parent.Text)
					)
				{
					if("Delete" == item)
					{
						int i;
						if("TASK"  == OStree.SelectedNode.Parent.Text)
						{
							if(0 < TaskCounter)
							{
								TaskCounter--;
							}
							
							try
							{
								TaskList[OStree.SelectedNode.Index].SetTaskCallScheduler("");
								TaskList[OStree.SelectedNode.Index].SetTaskEvent("");
								TaskList[OStree.SelectedNode.Index].SetTaskName("");
								TaskList[OStree.SelectedNode.Index].SetTaskPrio("");
								TaskList[OStree.SelectedNode.Index].SetTaskResource("");
								TaskList[OStree.SelectedNode.Index].SetTaskResource("");
								TaskList[OStree.SelectedNode.Index].SetTaskScheduler("");
								TaskList[OStree.SelectedNode.Index].SetTaskStackSize("");
								TaskList[OStree.SelectedNode.Index].SetTaskActivation("");
								TaskList[OStree.SelectedNode.Index].SetTaskType("");							
									
								for(i = OStree.SelectedNode.Index; (i < 16 && (null != TaskList[i+1])); i++)
								{																
									TaskList[i] = TaskList[i+1];								
								}														
								TaskList[i] = null;								
								OStree.SelectedNode.Nodes.Remove(OStree.SelectedNode);
								if(0 < TaskCounter)
								{
									TaskCounter--;
								}
								
							}
							catch
							{
								MessageBox.Show("Failed remove a child node");						
							}
						}
						
						FormContextMenu();
					}
					else if("Edit" == item)
					{
						if(!OStree.SelectedNode.IsEditing)
						{
					
							OStree.SelectedNode.BeginEdit();
						}
					
					}
					else
					{
						MessageBox.Show("Unkown context menu item for second deptch!");
					}
				}
			}
			OStree.ExpandAll();
			EnableEvents();
		}
		//==============================================================================
		// DESCRIPTION :		
		//
		// PARAMETERS (Type,Name,Min,Max) :
		//
		// RETURN VALUE :
		//
		// DESIGN INFORMATION :
		//==============================================================================
		private void FormContextMenu()
		{
			if(null != MyContext.MenuItems)
			{
				MyContext.MenuItems.Clear();
			}
			else
			{
				MessageBox.Show("Problem in the clear context menu");
			}
			
			if(
				(null != this.OStree.SelectedNode.Parent) &&
				("OSEK_CONF" == this.OStree.SelectedNode.Parent.Text)
				)
			{
				if("OS" == this.OStree.SelectedNode.Text)					
				{															
					if(null == OStree.SelectedNode.FirstNode)
					{
						try
						{
							this.menuItem1.Index = 1;
							MyContext.MenuItems.Add("New",new EventHandler(OnMiceClick));
						}
						catch
						{
							MessageBox.Show("Problem adding a new child to treeview");
						}
							
					}					
				}
				else if(("TASK" == this.OStree.SelectedNode.Text))
				{
					this.menuItem1.Index = 1;
					MyContext.MenuItems.Add("Add",new EventHandler(OnMiceClick));				
				}
				else if("ISR" == this.OStree.SelectedNode.Text)
				{
					this.menuItem1.Index = 1;
					MyContext.MenuItems.Add("Add",new EventHandler(OnMiceClick));
				}
				else if("COUNTER" == this.OStree.SelectedNode.Text)
				{
					this.menuItem1.Index = 1;
					MyContext.MenuItems.Add("Add",new EventHandler(OnMiceClick));								
				}
				else if("MESSAGE" == this.OStree.SelectedNode.Text)
				{
					this.menuItem1.Index = 1;
					MyContext.MenuItems.Add("Add",new EventHandler(OnMiceClick));				
				}
				else if("APPMODE" == this.OStree.SelectedNode.Text)
				{
					this.menuItem1.Index = 1;
					MyContext.MenuItems.Add("Add",new EventHandler(OnMiceClick));				
				}
				else if("ALARM" == this.OStree.SelectedNode.Text)
				{
					this.menuItem1.Index = 1;
					MyContext.MenuItems.Add("Add",new EventHandler(OnMiceClick));				
				}
				else if("EVENT" == this.OStree.SelectedNode.Text)
				{
					this.menuItem1.Index = 1;
					MyContext.MenuItems.Add("Add",new EventHandler(OnMiceClick));				
				}
				else if("RESOURCE" == this.OStree.SelectedNode.Text)
				{
					this.menuItem1.Index = 1;
					MyContext.MenuItems.Add("Add",new EventHandler(OnMiceClick));				
				}	
			}
				// Second level of depth in the tree view
			else if(
				   (null != this.OStree.SelectedNode.Parent) &&
				   (null != this.OStree.SelectedNode.Parent.Parent) &&
				   ("OSEK_CONF" == this.OStree.SelectedNode.Parent.Parent.Text)
				   )
			{
				
				this.menuItem1.Index = 1;
				MyContext.MenuItems.Add("Edit",new EventHandler(OnMiceClick));
				this.menuItem1.Index = 2;
				MyContext.MenuItems.Add("Delete",new EventHandler(OnMiceClick));
								
			}
		}
		//==============================================================================
		// DESCRIPTION :		
		//
		// PARAMETERS (Type,Name,Min,Max) :
		//
		// RETURN VALUE :
		//
		// DESIGN INFORMATION :
		//==============================================================================			
		private void ManageTaskProperty(bool state)
		{
			TaskProperty.Visible = state;
			TaskType.Visible = state;
			label1.Visible = state;
			label2.Visible = state;
			label3.Visible = state;
			label4.Visible = state;
			label5.Visible = state;
			label6.Visible = state;
			label7.Visible = state;
			label8.Visible = state;
			label9.Visible = state;
			label10.Visible = state;
			label11.Visible = state;
			label12.Visible = state;
			label13.Visible = state;
			label14.Visible = state;
			label15.Visible = state;
			label16.Visible = state;
			TaskPriority.Visible = state;
			TaskActivation.Visible = state;
			TaskSchedule.Visible = state;
			TaskStackSize.Visible = state;
			TskCallScheduler.Visible = state;
			TaskEvent.Visible = state;
			TaskResource.Visible = state;
			Comment1.Visible = state;
			Comment2.Visible = state;
			Comment3.Visible = state;
			Comment4.Visible = state;
			Comment5.Visible = state;
			Comment6.Visible = state;
			Comment7.Visible = state;
			Comment8.Visible = state;
		}

		private void TaskType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			ManageTskValues(true);
		}		
		private void ManageTskValues(bool direction)
		{
			if((null != OStree.SelectedNode.Parent) &&
               ("TASK" == OStree.SelectedNode.Parent.Text)
				)
			{
				
				// true means - from the property to structure
				if(direction)
				{					
					TaskList[OStree.SelectedNode.Index].SetTaskCallScheduler(TskCallScheduler.Text);
					TaskList[OStree.SelectedNode.Index].SetTaskEvent(TaskEvent.Text);					
					TaskList[OStree.SelectedNode.Index].SetTaskPrio(TaskPriority.Text);
					TaskList[OStree.SelectedNode.Index].SetTaskResource(TaskResource.Text);					
					TaskList[OStree.SelectedNode.Index].SetTaskScheduler(TaskSchedule.Text);
					TaskList[OStree.SelectedNode.Index].SetTaskStackSize(TaskStackSize.Text);
					TaskList[OStree.SelectedNode.Index].SetTaskActivation(TaskActivation.Text);
					TaskList[OStree.SelectedNode.Index].SetTaskType(TaskType.Text);
				}
				else
				{
					try{
						DisableEvents();
						TskCallScheduler.Text = TaskList[OStree.SelectedNode.Index].GetTaskCallScheduler();
						TaskEvent.Text = TaskList[OStree.SelectedNode.Index].GetTaskEvent();						
						TaskType.Text = TaskList[OStree.SelectedNode.Index].GetTaskName();
						TaskPriority.Text = TaskList[OStree.SelectedNode.Index].GetTaskPrio();
						TaskType.Text = TaskList[OStree.SelectedNode.Index].GetTaskType();
						TaskStackSize.Text = TaskList[OStree.SelectedNode.Index].GetTaskStackSize();						
						TaskActivation.Text = TaskList[OStree.SelectedNode.Index].GetTaskTaskActivation();						
						TaskSchedule.Text = TaskList[OStree.SelectedNode.Index].GetTaskScheduler();
					    EnableEvents();
					}
					catch
					{
						MessageBox.Show("Problem with loading information for tasks in form");
					}
				}
				
			}
			
		}

		private void TaskType_TextChanged(object sender, System.EventArgs e)
		{
			ManageTskValues(true);
		}

		private void TaskPriority_TextChanged(object sender, System.EventArgs e)
		{
			ManageTskValues(true);
		}

		private void TaskActivation_TextChanged(object sender, System.EventArgs e)
		{
			ManageTskValues(true);
		}

		private void TaskSchedule_TextChanged(object sender, System.EventArgs e)
		{
			ManageTskValues(true);
		}

		private void TaskStackSize_TextChanged(object sender, System.EventArgs e)
		{
			ManageTskValues(true);
		}

		private void TskCallScheduler_TextChanged(object sender, System.EventArgs e)
		{
			ManageTskValues(true);
		}

		private void TaskEvent_TextChanged(object sender, System.EventArgs e)
		{
			ManageTskValues(true);
		}

		private void TaskResource_TextChanged(object sender, System.EventArgs e)
		{
			ManageTskValues(true);
		}
		private void DisableEvents()
		{
			
			this.TaskResource.SelectionChangeCommitted -= new System.EventHandler(this.TaskResource_TextChanged);
			this.TskCallScheduler.SelectionChangeCommitted -= new System.EventHandler(this.TskCallScheduler_TextChanged);
			this.TaskStackSize.TextChanged -= new System.EventHandler(this.TaskStackSize_TextChanged);
			this.TaskSchedule.SelectionChangeCommitted -= new System.EventHandler(this.TaskSchedule_TextChanged);
			this.TaskActivation.TextChanged -= new System.EventHandler(this.TaskActivation_TextChanged);
			this.TaskType.SelectionChangeCommitted -= new System.EventHandler(this.TaskType_TextChanged);
			this.TaskPriority.TextChanged -= new System.EventHandler(this.TaskPriority_TextChanged);
			this.TaskEvent.SelectionChangeCommitted -= new System.EventHandler(this.TaskEvent_TextChanged);			

			this.OStree.MouseDown -= new System.Windows.Forms.MouseEventHandler(this.MouseIsClick);
			this.OStree.AfterSelect -= new System.Windows.Forms.TreeViewEventHandler(this.NewSelectedItem);
			this.OStree.AfterLabelEdit -= new System.Windows.Forms.NodeLabelEditEventHandler(this.OStree_AfterLabelEdit);
		}
		private void EnableEvents()
		{
			this.TaskResource.SelectionChangeCommitted += new System.EventHandler(this.TaskResource_TextChanged);
			this.TskCallScheduler.SelectionChangeCommitted += new System.EventHandler(this.TskCallScheduler_TextChanged);
			this.TaskStackSize.TextChanged += new System.EventHandler(this.TaskStackSize_TextChanged);
			this.TaskSchedule.SelectionChangeCommitted += new System.EventHandler(this.TaskSchedule_TextChanged);
			this.TaskActivation.TextChanged += new System.EventHandler(this.TaskActivation_TextChanged);
			this.TaskType.SelectionChangeCommitted += new System.EventHandler(this.TaskType_TextChanged);
			this.TaskPriority.TextChanged += new System.EventHandler(this.TaskPriority_TextChanged);
			this.TaskEvent.SelectionChangeCommitted += new System.EventHandler(this.TaskEvent_TextChanged);			

			this.OStree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseIsClick);
			this.OStree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.NewSelectedItem);
			this.OStree.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.OStree_AfterLabelEdit);
		}

		private void OStree_AfterLabelEdit(object sender, System.Windows.Forms.NodeLabelEditEventArgs e)
		{
			if(
				(null != OStree.SelectedNode.Parent)&&
				("TASK" == OStree.SelectedNode.Parent.Text)
				)
			{
				if((null != e.Label))
				{
					if((e.Label.Length > 0))
					{
						TaskList[OStree.SelectedNode.Index].SetTaskName(e.Label);
						TaskProperty.Text = TaskList[OStree.SelectedNode.Index].GetTaskName();
						e.Node.EndEdit(false);

					}
					else
					{
						e.CancelEdit = true;
						MessageBox.Show("It is not allowed to have empty name for element");
						e.Node.BeginEdit();
						
					}
				}				  				  				
			}
		}
		
		
		// MouseOver_NewButton
		private void MouseOver_NewButton(object sender, System.EventArgs e)
		{
			toolTipNew.SetToolTip(NewFileButton,"New OIL");
		}

		private void MouseOver_OpenButton(object sender, System.EventArgs e)
		{
			toolTipNew.SetToolTip(OpenFileButton,"Open existing OIL");
		}

		private void MouseOver_SaveButton(object sender, System.EventArgs e)
		{
			toolTipNew.SetToolTip(SaveButton,"Save current configuration");
		}

		private void MouseOver_(object sender, System.EventArgs e)
		{
			toolTipNew.SetToolTip(ValidateIt,"Validate current project");
		}

		private void MouseOver_Generated(object sender, System.EventArgs e)
		{
			toolTipNew.SetToolTip(GenerateButton,"Generate OSEK");
		}

		private void MouseOver_StatisticsButton(object sender, System.EventArgs e)
		{
			toolTipNew.SetToolTip(StatisticsButton,"Check statistics");
		}

		private void OpenFileButton_Click(object sender, System.EventArgs e)
		{
			Stream myStream = null;
			OpenFileDialog openFileDialog1 = new OpenFileDialog();

			openFileDialog1.InitialDirectory = "c:\\" ;
			openFileDialog1.Filter = "OSEK Implementation Language (*.oil)|*.OIL" ;
			openFileDialog1.FilterIndex = 2 ;
			openFileDialog1.RestoreDirectory = true ;

			if(openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					if ((myStream = openFileDialog1.OpenFile()) != null)
					{
						using (myStream)
						{
							// Insert code to read the stream here.
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
				}
			}

		}

		private void NewFileButton_Click(object sender, System.EventArgs e)
		{
			OStree.Enabled = true;
			OStree.Visible = true;
			SaveButton.Enabled = true;
			
		}

		private void SaveButton_Click(object sender, System.EventArgs e)
		{
			ValidateIt.Enabled = true;
			GenerateButton.Enabled = true;
			StatisticsButton.Enabled = true;
		
		}
	
	
		
	}
}
