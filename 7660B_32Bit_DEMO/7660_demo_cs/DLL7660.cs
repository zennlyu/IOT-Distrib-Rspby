using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace _660_demo_cs
{
    public class DLL7660
    {
        //���豸
        [DllImport("USB7660.dll", CharSet = CharSet.Auto)]
        public static extern Int32 ZT7660_OpenDevice(UInt32 cardNO);
        //�ر��豸
        [DllImport("USB7660.dll", CharSet = CharSet.Auto)]
        public static extern Int32 ZT7660_CloseDevice(UInt32 cardNO);
        //�õ���ǰ����š���������Ϊ0��ʾ�޴���
        [DllImport("USB7660.dll", CharSet = CharSet.Auto)]
        public static extern Int32 ZT7660_GetLastErr();
        //��������
        [DllImport("USB7660.dll", CharSet = CharSet.Auto)]
        public static extern void ZT7660_ClearLastErr();
        //��ָ��ͨ�����е������ݲɼ�
        [DllImport("USB7660.dll", CharSet = CharSet.Auto)]
        public static extern Int32 ZT7660_AIonce(UInt32 cardNO,
                                                 UInt32 chMode,
                                                 UInt32 chNO,
                                                 UInt32 AIrange,
                                                 UInt32 AIAmp,
                                                 UInt32 ADstartMode,
                                                 UInt32 ADfreq,
                                                 UInt32 ABflag,
                                                 UInt32 ch1Flag,
                                                 UInt32 ADctrlWord,
                                                 UInt32 ADoverTime);
        //��ʼ��AD
        [DllImport("USB7660.dll", CharSet = CharSet.Auto)]
        public static extern Int32 ZT7660_AIinit(UInt32 cardNO,
                                                 UInt32 chMode,
                                                 UInt32 chNO,
                                                 UInt32 AIrange,
                                                 UInt32 AIAmp,
                                                 UInt32 ADstartMode,
                                                 UInt32 ADfreq,
                                                 UInt32 ABflag,
                                                 UInt32 ch1Flag,
                                                 UInt32 ADctrlWord,
                                                 UInt32 ADoverTime);
        //���ģ����Ӳ��������(FIFO)
        [DllImport("USB7660.dll", CharSet = CharSet.Auto)]
        public static extern Int32 ZT7660_ClearFifo(UInt32 cardNO);
        //�õ������������е�ǰ���ݸ���
        [DllImport("USB7660.dll", CharSet = CharSet.Auto)]
        public static extern Int32 ZT7660_GetSFifoDataCnt(UInt32 cardNO);

        //������ȡAD���ݡ�
        [DllImport("USB7660.dll", CharSet = CharSet.Auto)]
        public static extern Int32 ZT7660_AIFifoEx(UInt32 cardNO,
                                                  UInt32 wantReadCount,
                                                  [MarshalAs(UnmanagedType.I2)] out UInt16 pResultArr);
        //�õ�ָ��ͨ���Ŀ���������״̬
        [DllImport("USB7660.dll", CharSet = CharSet.Auto)]
        public static extern Int32 ZT7660_DIBit(UInt32 cardNO, UInt32 chNO);
        //�õ�����ͨ���Ŀ���������״̬
        [DllImport("USB7660.dll", CharSet = CharSet.Auto)]
        public static extern Int32 ZT7660_DIAll(UInt32 cardNO);
        //ָ��ĳͨ���Ŀ��������״̬
        [DllImport("USB7660.dll", CharSet = CharSet.Auto)]
        public static extern Int32 ZT7660_DOBit(UInt32 cardNO, UInt32 chNO, UInt32 nState);
        //ָ������ͨ���Ŀ��������״̬
        [DllImport("USB7660.dll", CharSet = CharSet.Auto)]
        public static extern Int32 ZT7660_DOAll(UInt32 cardNO, UInt32 nStateAll);

    }
}
