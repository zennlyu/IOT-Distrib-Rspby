/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2013-11-14
 * Time: 13:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace USB7660
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox49 = new System.Windows.Forms.TextBox();
            this.cobAIAmp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cobAIrange = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cobChCnt = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cobChMode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cobABFlag = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.textBox45 = new System.Windows.Forms.TextBox();
            this.textBox46 = new System.Windows.Forms.TextBox();
            this.textBox47 = new System.Windows.Forms.TextBox();
            this.textBox48 = new System.Windows.Forms.TextBox();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.QUIT = new System.Windows.Forms.Button();
            this.timerAD = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox49);
            this.groupBox1.Controls.Add(this.cobAIAmp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cobAIrange);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cobChCnt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cobChMode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cobABFlag);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(291, 387);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数设置";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 274);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "读取每通道数据个数";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 345);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "错误号:";
            // 
            // textBox49
            // 
            this.textBox49.Location = new System.Drawing.Point(183, 268);
            this.textBox49.Margin = new System.Windows.Forms.Padding(4);
            this.textBox49.Name = "textBox49";
            this.textBox49.Size = new System.Drawing.Size(80, 28);
            this.textBox49.TabIndex = 53;
            this.textBox49.TabStop = false;
            this.textBox49.Text = "100";
            // 
            // cobAIAmp
            // 
            this.cobAIAmp.FormattingEnabled = true;
            this.cobAIAmp.Location = new System.Drawing.Point(98, 207);
            this.cobAIAmp.Margin = new System.Windows.Forms.Padding(4);
            this.cobAIAmp.Name = "cobAIAmp";
            this.cobAIAmp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cobAIAmp.Size = new System.Drawing.Size(166, 26);
            this.cobAIAmp.TabIndex = 52;
            this.cobAIAmp.TabStop = false;
            this.cobAIAmp.SelectedIndexChanged += new System.EventHandler(this.CobAIAmpSelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "增益";
            // 
            // cobAIrange
            // 
            this.cobAIrange.FormattingEnabled = true;
            this.cobAIrange.Location = new System.Drawing.Point(98, 166);
            this.cobAIrange.Margin = new System.Windows.Forms.Padding(4);
            this.cobAIrange.Name = "cobAIrange";
            this.cobAIrange.Size = new System.Drawing.Size(166, 26);
            this.cobAIrange.TabIndex = 51;
            this.cobAIrange.TabStop = false;
            this.cobAIrange.SelectedIndexChanged += new System.EventHandler(this.CobAIrangeSelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "采集量程";
            // 
            // cobChCnt
            // 
            this.cobChCnt.FormattingEnabled = true;
            this.cobChCnt.Location = new System.Drawing.Point(98, 126);
            this.cobChCnt.Margin = new System.Windows.Forms.Padding(4);
            this.cobChCnt.Name = "cobChCnt";
            this.cobChCnt.Size = new System.Drawing.Size(166, 26);
            this.cobChCnt.TabIndex = 50;
            this.cobChCnt.TabStop = false;
            this.cobChCnt.SelectedIndexChanged += new System.EventHandler(this.CobChCntSelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "通道数";
            // 
            // cobChMode
            // 
            this.cobChMode.FormattingEnabled = true;
            this.cobChMode.Location = new System.Drawing.Point(98, 86);
            this.cobChMode.Margin = new System.Windows.Forms.Padding(4);
            this.cobChMode.Name = "cobChMode";
            this.cobChMode.Size = new System.Drawing.Size(166, 26);
            this.cobChMode.TabIndex = 49;
            this.cobChMode.TabStop = false;
            this.cobChMode.SelectedIndexChanged += new System.EventHandler(this.CobChModeSelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "通道方式";
            // 
            // cobABFlag
            // 
            this.cobABFlag.FormattingEnabled = true;
            this.cobABFlag.Location = new System.Drawing.Point(98, 45);
            this.cobABFlag.Margin = new System.Windows.Forms.Padding(4);
            this.cobABFlag.Name = "cobABFlag";
            this.cobABFlag.Size = new System.Drawing.Size(166, 26);
            this.cobABFlag.TabIndex = 48;
            this.cobABFlag.TabStop = false;
            this.cobABFlag.SelectedIndexChanged += new System.EventHandler(this.CobABFlagSelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "型号";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox41);
            this.groupBox2.Controls.Add(this.textBox42);
            this.groupBox2.Controls.Add(this.textBox43);
            this.groupBox2.Controls.Add(this.textBox44);
            this.groupBox2.Controls.Add(this.textBox45);
            this.groupBox2.Controls.Add(this.textBox46);
            this.groupBox2.Controls.Add(this.textBox47);
            this.groupBox2.Controls.Add(this.textBox48);
            this.groupBox2.Controls.Add(this.textBox33);
            this.groupBox2.Controls.Add(this.textBox34);
            this.groupBox2.Controls.Add(this.textBox35);
            this.groupBox2.Controls.Add(this.textBox36);
            this.groupBox2.Controls.Add(this.textBox37);
            this.groupBox2.Controls.Add(this.textBox38);
            this.groupBox2.Controls.Add(this.textBox39);
            this.groupBox2.Controls.Add(this.textBox40);
            this.groupBox2.Controls.Add(this.textBox25);
            this.groupBox2.Controls.Add(this.textBox26);
            this.groupBox2.Controls.Add(this.textBox27);
            this.groupBox2.Controls.Add(this.textBox28);
            this.groupBox2.Controls.Add(this.textBox29);
            this.groupBox2.Controls.Add(this.textBox30);
            this.groupBox2.Controls.Add(this.textBox31);
            this.groupBox2.Controls.Add(this.textBox32);
            this.groupBox2.Controls.Add(this.textBox17);
            this.groupBox2.Controls.Add(this.textBox18);
            this.groupBox2.Controls.Add(this.textBox19);
            this.groupBox2.Controls.Add(this.textBox20);
            this.groupBox2.Controls.Add(this.textBox21);
            this.groupBox2.Controls.Add(this.textBox22);
            this.groupBox2.Controls.Add(this.textBox23);
            this.groupBox2.Controls.Add(this.textBox24);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.textBox10);
            this.groupBox2.Controls.Add(this.textBox11);
            this.groupBox2.Controls.Add(this.textBox12);
            this.groupBox2.Controls.Add(this.textBox13);
            this.groupBox2.Controls.Add(this.textBox14);
            this.groupBox2.Controls.Add(this.textBox15);
            this.groupBox2.Controls.Add(this.textBox16);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(318, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(975, 300);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据显示(单位：mV)";
            // 
            // textBox41
            // 
            this.textBox41.Location = new System.Drawing.Point(10, 244);
            this.textBox41.Margin = new System.Windows.Forms.Padding(4);
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(109, 28);
            this.textBox41.TabIndex = 47;
            // 
            // textBox42
            // 
            this.textBox42.Location = new System.Drawing.Point(130, 244);
            this.textBox42.Margin = new System.Windows.Forms.Padding(4);
            this.textBox42.Name = "textBox42";
            this.textBox42.Size = new System.Drawing.Size(109, 28);
            this.textBox42.TabIndex = 46;
            // 
            // textBox43
            // 
            this.textBox43.Location = new System.Drawing.Point(250, 244);
            this.textBox43.Margin = new System.Windows.Forms.Padding(4);
            this.textBox43.Name = "textBox43";
            this.textBox43.Size = new System.Drawing.Size(109, 28);
            this.textBox43.TabIndex = 45;
            // 
            // textBox44
            // 
            this.textBox44.Location = new System.Drawing.Point(370, 243);
            this.textBox44.Margin = new System.Windows.Forms.Padding(4);
            this.textBox44.Name = "textBox44";
            this.textBox44.Size = new System.Drawing.Size(109, 28);
            this.textBox44.TabIndex = 44;
            // 
            // textBox45
            // 
            this.textBox45.Location = new System.Drawing.Point(490, 243);
            this.textBox45.Margin = new System.Windows.Forms.Padding(4);
            this.textBox45.Name = "textBox45";
            this.textBox45.Size = new System.Drawing.Size(109, 28);
            this.textBox45.TabIndex = 43;
            // 
            // textBox46
            // 
            this.textBox46.Location = new System.Drawing.Point(610, 243);
            this.textBox46.Margin = new System.Windows.Forms.Padding(4);
            this.textBox46.Name = "textBox46";
            this.textBox46.Size = new System.Drawing.Size(109, 28);
            this.textBox46.TabIndex = 42;
            // 
            // textBox47
            // 
            this.textBox47.Location = new System.Drawing.Point(730, 243);
            this.textBox47.Margin = new System.Windows.Forms.Padding(4);
            this.textBox47.Name = "textBox47";
            this.textBox47.Size = new System.Drawing.Size(109, 28);
            this.textBox47.TabIndex = 41;
            // 
            // textBox48
            // 
            this.textBox48.Location = new System.Drawing.Point(850, 244);
            this.textBox48.Margin = new System.Windows.Forms.Padding(4);
            this.textBox48.Name = "textBox48";
            this.textBox48.Size = new System.Drawing.Size(109, 28);
            this.textBox48.TabIndex = 40;
            // 
            // textBox33
            // 
            this.textBox33.Location = new System.Drawing.Point(10, 206);
            this.textBox33.Margin = new System.Windows.Forms.Padding(4);
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(109, 28);
            this.textBox33.TabIndex = 39;
            // 
            // textBox34
            // 
            this.textBox34.Location = new System.Drawing.Point(130, 206);
            this.textBox34.Margin = new System.Windows.Forms.Padding(4);
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(109, 28);
            this.textBox34.TabIndex = 38;
            // 
            // textBox35
            // 
            this.textBox35.Location = new System.Drawing.Point(250, 204);
            this.textBox35.Margin = new System.Windows.Forms.Padding(4);
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(109, 28);
            this.textBox35.TabIndex = 37;
            // 
            // textBox36
            // 
            this.textBox36.Location = new System.Drawing.Point(370, 204);
            this.textBox36.Margin = new System.Windows.Forms.Padding(4);
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(109, 28);
            this.textBox36.TabIndex = 36;
            // 
            // textBox37
            // 
            this.textBox37.Location = new System.Drawing.Point(490, 204);
            this.textBox37.Margin = new System.Windows.Forms.Padding(4);
            this.textBox37.Name = "textBox37";
            this.textBox37.Size = new System.Drawing.Size(109, 28);
            this.textBox37.TabIndex = 35;
            // 
            // textBox38
            // 
            this.textBox38.Location = new System.Drawing.Point(610, 204);
            this.textBox38.Margin = new System.Windows.Forms.Padding(4);
            this.textBox38.Name = "textBox38";
            this.textBox38.Size = new System.Drawing.Size(109, 28);
            this.textBox38.TabIndex = 34;
            // 
            // textBox39
            // 
            this.textBox39.Location = new System.Drawing.Point(730, 204);
            this.textBox39.Margin = new System.Windows.Forms.Padding(4);
            this.textBox39.Name = "textBox39";
            this.textBox39.Size = new System.Drawing.Size(109, 28);
            this.textBox39.TabIndex = 33;
            // 
            // textBox40
            // 
            this.textBox40.Location = new System.Drawing.Point(850, 206);
            this.textBox40.Margin = new System.Windows.Forms.Padding(4);
            this.textBox40.Name = "textBox40";
            this.textBox40.Size = new System.Drawing.Size(109, 28);
            this.textBox40.TabIndex = 32;
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(10, 164);
            this.textBox25.Margin = new System.Windows.Forms.Padding(4);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(109, 28);
            this.textBox25.TabIndex = 31;
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(130, 165);
            this.textBox26.Margin = new System.Windows.Forms.Padding(4);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(109, 28);
            this.textBox26.TabIndex = 30;
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(250, 165);
            this.textBox27.Margin = new System.Windows.Forms.Padding(4);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(109, 28);
            this.textBox27.TabIndex = 29;
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(370, 165);
            this.textBox28.Margin = new System.Windows.Forms.Padding(4);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(109, 28);
            this.textBox28.TabIndex = 28;
            // 
            // textBox29
            // 
            this.textBox29.Location = new System.Drawing.Point(490, 164);
            this.textBox29.Margin = new System.Windows.Forms.Padding(4);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(109, 28);
            this.textBox29.TabIndex = 27;
            // 
            // textBox30
            // 
            this.textBox30.Location = new System.Drawing.Point(610, 164);
            this.textBox30.Margin = new System.Windows.Forms.Padding(4);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(109, 28);
            this.textBox30.TabIndex = 26;
            // 
            // textBox31
            // 
            this.textBox31.Location = new System.Drawing.Point(730, 164);
            this.textBox31.Margin = new System.Windows.Forms.Padding(4);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(109, 28);
            this.textBox31.TabIndex = 25;
            // 
            // textBox32
            // 
            this.textBox32.Location = new System.Drawing.Point(850, 165);
            this.textBox32.Margin = new System.Windows.Forms.Padding(4);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(109, 28);
            this.textBox32.TabIndex = 24;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(10, 124);
            this.textBox17.Margin = new System.Windows.Forms.Padding(4);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(109, 28);
            this.textBox17.TabIndex = 23;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(130, 124);
            this.textBox18.Margin = new System.Windows.Forms.Padding(4);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(109, 28);
            this.textBox18.TabIndex = 22;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(250, 124);
            this.textBox19.Margin = new System.Windows.Forms.Padding(4);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(109, 28);
            this.textBox19.TabIndex = 21;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(370, 123);
            this.textBox20.Margin = new System.Windows.Forms.Padding(4);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(109, 28);
            this.textBox20.TabIndex = 20;
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(490, 123);
            this.textBox21.Margin = new System.Windows.Forms.Padding(4);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(109, 28);
            this.textBox21.TabIndex = 19;
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(610, 123);
            this.textBox22.Margin = new System.Windows.Forms.Padding(4);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(109, 28);
            this.textBox22.TabIndex = 18;
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(730, 123);
            this.textBox23.Margin = new System.Windows.Forms.Padding(4);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(109, 28);
            this.textBox23.TabIndex = 17;
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(850, 123);
            this.textBox24.Margin = new System.Windows.Forms.Padding(4);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(109, 28);
            this.textBox24.TabIndex = 16;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(10, 84);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(109, 28);
            this.textBox9.TabIndex = 15;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(130, 84);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(109, 28);
            this.textBox10.TabIndex = 14;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(250, 84);
            this.textBox11.Margin = new System.Windows.Forms.Padding(4);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(109, 28);
            this.textBox11.TabIndex = 13;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(370, 84);
            this.textBox12.Margin = new System.Windows.Forms.Padding(4);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(109, 28);
            this.textBox12.TabIndex = 12;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(490, 84);
            this.textBox13.Margin = new System.Windows.Forms.Padding(4);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(109, 28);
            this.textBox13.TabIndex = 11;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(610, 84);
            this.textBox14.Margin = new System.Windows.Forms.Padding(4);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(109, 28);
            this.textBox14.TabIndex = 10;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(730, 84);
            this.textBox15.Margin = new System.Windows.Forms.Padding(4);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(109, 28);
            this.textBox15.TabIndex = 9;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(850, 84);
            this.textBox16.Margin = new System.Windows.Forms.Padding(4);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(109, 28);
            this.textBox16.TabIndex = 8;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(850, 44);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(109, 28);
            this.textBox8.TabIndex = 7;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(730, 44);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(109, 28);
            this.textBox7.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(610, 44);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(109, 28);
            this.textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(490, 44);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(109, 28);
            this.textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(370, 45);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(109, 28);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(250, 45);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(109, 28);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(130, 45);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(109, 28);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 44);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 28);
            this.textBox1.TabIndex = 0;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(318, 333);
            this.start.Margin = new System.Windows.Forms.Padding(4);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(148, 64);
            this.start.TabIndex = 54;
            this.start.Text = "开始";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.StartClick);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(502, 333);
            this.Stop.Margin = new System.Windows.Forms.Padding(4);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(148, 64);
            this.Stop.TabIndex = 55;
            this.Stop.Text = "停止";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.StopClick);
            // 
            // QUIT
            // 
            this.QUIT.Location = new System.Drawing.Point(686, 333);
            this.QUIT.Margin = new System.Windows.Forms.Padding(4);
            this.QUIT.Name = "QUIT";
            this.QUIT.Size = new System.Drawing.Size(148, 64);
            this.QUIT.TabIndex = 56;
            this.QUIT.Text = "退出";
            this.QUIT.UseVisualStyleBackColor = true;
            this.QUIT.Click += new System.EventHandler(this.QUITClick);
            // 
            // timerAD
            // 
            this.timerAD.Tick += new System.EventHandler(this.TimerADTick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(873, 356);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1307, 416);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.QUIT);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USB7660系列_demo_C#(AD部分)";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.TextBox textBox49;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Timer timerAD;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox40;
		private System.Windows.Forms.TextBox textBox39;
		private System.Windows.Forms.TextBox textBox38;
		private System.Windows.Forms.TextBox textBox37;
		private System.Windows.Forms.TextBox textBox36;
		private System.Windows.Forms.TextBox textBox35;
		private System.Windows.Forms.TextBox textBox34;
		private System.Windows.Forms.TextBox textBox33;
		private System.Windows.Forms.TextBox textBox48;
		private System.Windows.Forms.TextBox textBox47;
		private System.Windows.Forms.TextBox textBox46;
		private System.Windows.Forms.TextBox textBox45;
		private System.Windows.Forms.TextBox textBox44;
		private System.Windows.Forms.TextBox textBox43;
		private System.Windows.Forms.TextBox textBox42;
		private System.Windows.Forms.TextBox textBox41;
		private System.Windows.Forms.TextBox textBox32;
		private System.Windows.Forms.TextBox textBox31;
		private System.Windows.Forms.TextBox textBox30;
		private System.Windows.Forms.TextBox textBox29;
		private System.Windows.Forms.TextBox textBox28;
		private System.Windows.Forms.TextBox textBox27;
		private System.Windows.Forms.TextBox textBox26;
		private System.Windows.Forms.TextBox textBox25;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox16;
		private System.Windows.Forms.TextBox textBox15;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox24;
		private System.Windows.Forms.TextBox textBox23;
		private System.Windows.Forms.TextBox textBox22;
		private System.Windows.Forms.TextBox textBox21;
		private System.Windows.Forms.TextBox textBox20;
		private System.Windows.Forms.TextBox textBox19;
		private System.Windows.Forms.TextBox textBox18;
		private System.Windows.Forms.TextBox textBox17;
		private System.Windows.Forms.Button QUIT;
		private System.Windows.Forms.Button Stop;
		private System.Windows.Forms.Button start;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cobAIAmp;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cobAIrange;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cobChCnt;
		private System.Windows.Forms.ComboBox cobABFlag;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cobChMode;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
