/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2013-11-14
 * Time: 13:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace USB7660
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
        Int32 CardCount;
		UInt32 m_cardNO; //板卡号
        Int32 ren;
        TextBox[] m_txtArr;
        Int16[] m_readArr;

        UInt32 m_ABFlag;
        UInt32 m_ChMode;
        UInt32 m_chCnt;
        UInt32 m_AIrange;
        UInt32 m_AIAmp;        
        
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			Stop.Focus();
			//初始化控件 参数
			cobABFlag.Items.Add("A型");
			cobABFlag.Items.Add("B型");
            cobABFlag.SelectedIndex = 0;
            m_ABFlag = 0;
			
			cobChMode.Items.Add("单端多通道");
			cobChMode.Items.Add("双端多通道");
            cobChMode.SelectedIndex = 0;
            m_ChMode = 1;
		
			for(int i=0;i<48;i++)
			{
				cobChCnt.Items.Add((i+1).ToString());
			}
            cobChCnt.SelectedIndex = 47;
            m_chCnt = Convert.ToUInt32(cobChCnt.Text);
			
			cobAIrange.Items.Add("0~5000mV");
			cobAIrange.Items.Add("0~10000mV");
			cobAIrange.Items.Add("-5000~+5000mV");
			cobAIrange.Items.Add("-10000~+10000mV");
            cobAIrange.SelectedIndex = 1;
            m_AIrange = 2;
			
			cobAIAmp.Items.Add("1倍(无增益)");
			cobAIAmp.Items.Add("10倍");
			cobAIAmp.Items.Add("100倍");
            cobAIAmp.SelectedIndex = 0;
            m_AIAmp = 0;
			
			//建立数组控件
			m_txtArr = new TextBox[48];
			foreach (Control ctl in this.groupBox2.Controls)
            {
                if (ctl is TextBox)
                {
                    Int32 inx = Convert.ToInt32(ctl.Name.Substring(7)) - 1; //基于0
                    m_txtArr[inx] = (TextBox)ctl;
                    m_txtArr[inx].Text = "通道" + (inx + 1).ToString();
                }
            }

			m_readArr = new Int16[48000];
            m_cardNO = 1;

            CardCount = DLL7660.ZT7660_GetCardCount();
            MessageBox.Show("当前可使用设备数量:" + CardCount.ToString());

			//打开设备
            if (DLL7660.ZT7660_OpenDevice(m_cardNO) != 0)
            {
                MessageBox.Show("Open device is failed!");
            }
            label6.Text = "错误号: " + DLL7660.ZT7660_GetLastErr().ToString();
		}
		
		void QUITClick(object sender, EventArgs e)
		{
            //关闭设备
            DLL7660.ZT7660_ClearLastErr();
            DLL7660.ZT7660_CloseDevice(m_cardNO);
			this.Close();
		}
		
		
		void CobABFlagSelectedIndexChanged(object sender, EventArgs e)
		{
            if (cobABFlag.SelectedIndex == 0)
                m_ABFlag = 0;
            if (cobABFlag.SelectedIndex == 1)
                m_ABFlag = 1;
		}
		
		void CobChModeSelectedIndexChanged(object sender, EventArgs e)
		{
            if (cobChMode.SelectedIndex == 0)
                m_ChMode = 1;
            if (cobChMode.SelectedIndex == 1)
                m_ChMode = 3;
		}
		
		void CobAIrangeSelectedIndexChanged(object sender, EventArgs e)
		{
            if (cobAIrange.SelectedIndex == 0)
                m_AIrange = 1;
            if (cobAIrange.SelectedIndex == 1)
                m_AIrange = 2;
            if (cobAIrange.SelectedIndex == 2)
                m_AIrange = 5;
            if (cobAIrange.SelectedIndex == 3)
                m_AIrange = 6;
		}
		
		void CobAIAmpSelectedIndexChanged(object sender, EventArgs e)
		{
            if (cobAIAmp.SelectedIndex == 0)
                m_AIAmp = 0;
            if (cobAIAmp.SelectedIndex == 1)
                m_AIAmp = 1;
            if (cobAIAmp.SelectedIndex == 2)
                m_AIAmp = 2;
		}
		
		void CobChCntSelectedIndexChanged(object sender, EventArgs e)
		{
            m_chCnt = Convert.ToUInt32(cobChCnt.Text);
		}
		
		void StartClick(object sender, EventArgs e)
		{
           //label7.Text = "当前通道数: " + m_chCnt.ToString();
           ren = DLL7660.ZT7660_ClearFifo(m_cardNO);
           //AD初始化
		   if (m_ABFlag==0)
              ren = DLL7660.ZT7660_AIinit(m_cardNO, m_ChMode, m_chCnt, m_AIrange, m_AIAmp, 0, 3, m_ABFlag, 0, 0, 0);//50KHz
		   if (m_ABFlag==1)
              ren = DLL7660.ZT7660_AIinit(m_cardNO, m_ChMode, m_chCnt, m_AIrange, m_AIAmp, 0, 3, m_ABFlag, 1, 0, 0);//25KHz
           start.Enabled = false;
           Stop.Enabled = true;
           //MessageBox.Show("AD初始化错误号:" + ren.ToString());
           label6.Text = "错误号: " + (DLL7660.ZT7660_GetLastErr()).ToString();
           timerAD.Interval = 10;
           timerAD.Enabled = true;
		}
		
		void StopClick(object sender, EventArgs e)
		{
			//停止AD
			DLL7660.ZT7660_ADstop (m_cardNO);
            timerAD.Enabled = false;
            start.Enabled = true;
            Stop.Enabled = false;
           
		}
		
		void TimerADTick(object sender, EventArgs e)
		{
            UInt32 WantCount, EveryChCnt;
            Int32 FifoCnt;
            Double sumVal;
            UInt32 i, k;
            
            EveryChCnt = Convert.ToUInt32(textBox49.Text);
            WantCount = m_chCnt * EveryChCnt;//读取数据量必须是通道的整数倍
            FifoCnt = DLL7660.ZT7660_GetSFifoDataCnt(m_cardNO);//判断驱动缓冲区中当前数据个数
            label7.Text = "驱动缓冲区中数据个数: " + FifoCnt.ToString();
            if (FifoCnt >= WantCount)
            {
                DLL7660.ZT7660_AIFifoEx(m_cardNO, WantCount, m_readArr); //成批读数
                //各通道求平均值
                for (k = 0; k < m_chCnt; k++)
                {
                    sumVal=0;
                    for(i = 0; i < EveryChCnt; i++)
                    {
                    	sumVal = sumVal + m_readArr[i * m_chCnt+ k];
                    }
                    m_txtArr[k].Text = (sumVal / EveryChCnt).ToString("F1") + "mV";
                }
				//显示前一组数据
				/*
				for (int k = 0; k < m_chCnt; k++)
				{
					m_txtArr[k].Text = m_readArr[k].ToString("F2") + "mV";
				}*/
             }
             label6.Text = "错误号: " + DLL7660.ZT7660_GetLastErr().ToString();        		
		}
	
	}
}
            	
            	
