using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _660_demo_cs
{
    public partial class Form1 : Form
    {
        UInt32 m_cardNO = 1; //�忨��
        TextBox[] m_txtArr;
        UInt16[] m_readArr;
        Boolean m_bTimerADFsh;
        UInt32 m_chCnt = 48; //ͨ����

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_txtArr = new TextBox[48];
            m_readArr = new UInt16[500000];
            foreach (Control ctl in this.groupBox1.Controls)
            {
                if (ctl is TextBox)
                {
                    Int32 inx = Convert.ToInt32(ctl.Name.Substring(7)) - 1; //����0
                    m_txtArr[inx] = (TextBox)ctl;
                    m_txtArr[inx].Text = "ͨ��" + (inx + 1).ToString();
                }
            }
            //���豸
            if (DLL7660.ZT7660_OpenDevice(m_cardNO) != 0)
            {
                MessageBox.Show("Open device is failed!");
                //return;
            }
            this.Text = "�����: " + DLL7660.ZT7660_GetLastErr().ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //�ر��豸
            DLL7660.ZT7660_ClearLastErr();
            DLL7660.ZT7660_CloseDevice(m_cardNO);
        }

       private void btnStartAD_Click(object sender, EventArgs e) //����AD
       {
           //ZT7660_ClearFifo(m_cardNO);
           //7660B�����ˣ�48ͨ����100K�ɼ�������0~10000mV
           DLL7660.ZT7660_AIinit(m_cardNO, 1, m_chCnt, 2, 0, 0, 5, 1, 1, 0, 0);
//           DLL7660.ZT7660_AIinit(m_cardNO, 1, m_chCnt, 2, 0, 0, 5, 0, 0, 0, 0); //���7660A
           m_bTimerADFsh = true;
           timerAD.Interval = 1;
           timerAD.Enabled = true;
           btnStartAD.Enabled = false;
           btnStopAD.Enabled = true;
           this.Text = "�����: " + DLL7660.ZT7660_GetLastErr().ToString();
       }

        private void btnStopAD_Click(object sender, EventArgs e)
        {
            //ֹͣAD
            m_bTimerADFsh = false;
            timerAD.Enabled = false;
            btnStartAD.Enabled = true;
            btnStopAD.Enabled = false;
        }

        private void timerAD_Tick(object sender, EventArgs e)
        {
            if (m_bTimerADFsh != true) return;
            m_bTimerADFsh = false;
            UInt32 wantCount;
            Int32 retCount, currCnt;
            wantCount = m_chCnt*250; //m_chCnt * 100; //������ͨ����������
            currCnt = DLL7660.ZT7660_GetSFifoDataCnt(m_cardNO); //�ж������������е�ǰ���ݸ���
            if (currCnt >= wantCount)
            {
                retCount = DLL7660.ZT7660_AIFifoEx(m_cardNO, wantCount, out m_readArr[0]); //����
                //��ʾǰ m_chCnt ����
                if (retCount >= wantCount)
                {
                    for (UInt32 k = 0; k < m_chCnt; k++)
                    {
                        m_txtArr[k].Text = (m_readArr[k]).ToString("F2") + "mV";
                    }
                }
/*
                //�Բɵ�������ƽ��
                if (retCount >= wantCount)
                {
                    double sumVal;
                    for (UInt32 k = 0; k < m_chCnt; k++)
                    {
                        sumVal = 0;
                        for (UInt32 i = 0; i < 100; i++)
                        {
                            //sumVal = sumVal + Convert.ToUInt16(m_readArr[i * m_chCnt + k]);
                            sumVal = sumVal + m_readArr[i * m_chCnt + k];
                        }
                        //��ԭ��ֵת��Ϊ 0~5000mV ֮�����
                        //m_txtArr[k].Text = (sumVal / 100.0 / 65536.0 * 5000.0).ToString("F2") + "mV";
                        m_txtArr[k].Text = (sumVal / 100.0).ToString("F2") + "mV";
                    }
                }
 */
            }
            groupBox1.Text = DLL7660.ZT7660_GetSFifoDataCnt(m_cardNO).ToString();
            if (DLL7660.ZT7660_GetLastErr() != 0) this.Text = "�����: " + DLL7660.ZT7660_GetLastErr().ToString();
            m_bTimerADFsh = true;
        }
    }
}