﻿using CRUX_GUI_Cognex.Class;
using CRUX_GUI_Cognex.User_Controls;
using CRUX_GUI_Cognex.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUX_GUI_Cognex.Ex_Form
{
    public partial class Ex_Frm_Status : Form
    {
        public CancellationTokenSource TokenSource { get; set; }
        public Task Checker = null;
        public Ex_Frm_Status ()
        {
            try
            {
                InitializeComponent();
                TopLevel = false;
                Dock = DockStyle.Fill;
                FormBorderStyle = FormBorderStyle.None;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void StartCheckStatus()
        {
            try
            {
                Timer_Time.Start();
                TokenSource = new CancellationTokenSource();
                Show();
                Checker = Task.Factory.StartNew(() => ThreadTaskAlive(TokenSource.Token));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void StopCheckStatus()
        {
            try
            {
                TokenSource.Cancel();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Ex_Frm_Status_Load(object sender, EventArgs e)
        {
            //Region = System.Drawing.Region.FromHrgn(WinApis.CreateRoundRectRgn(0, 0, this.Width, this.Height, 15, 15));
        }

        private void Ex_Frm_Status_Shown(object sender, EventArgs e)
        {
            try
            {
                Region = System.Drawing.Region.FromHrgn(WinApis.CreateRoundRectRgn(0, 0, this.Width, this.Height, 5, 5));
                if (Globals.Insp_Type[0] == 5)
                {
                    Lb_AF.Visible = true;
                    Pb_AF.Visible = true;
                }
                if (Globals.Insp_Type[0] == 6)
                {
                    Lb_AF.Visible = false;
                    Pb_AF.Visible = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Pb_VSS_State_Click(object sender, EventArgs e)
        {
            try
            {
                ChageWindowState((sender as PictureBox)?.Name.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Pb_MI_State_Click(object sender, EventArgs e)
        {
            try
            {
                ChageWindowState((sender as PictureBox)?.Name.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Pb_SEQ_State_Click(object sender, EventArgs e)
        {
            try
            {
                ChageWindowState((sender as PictureBox)?.Name.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Pb_CAM_State_Click(object sender, EventArgs e)
        {
            try
            {
                ChageWindowState((sender as PictureBox)?.Name.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void StopTwinkleThread()
        {
            try
            {
                TokenSource.Cancel();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ChageWindowState(string name)
        {
            try
            {
                string ProcessName = string.Empty;
                switch (name)
                {
                    case "Pb_VSS_State":
                        ProcessName = EnumHelper.GetDescription(Enums.ProcessNames.Server);
                        break;

                    case "Pb_SEQ_State":
                        ProcessName = EnumHelper.GetDescription(Enums.ProcessNames.Sequence);
                        break;

                    case "Pb_CAM_State":
                        if (Modes.NET_SIMULATION_MODE)
                            ProcessName = EnumHelper.GetDescription(Enums.ProcessNames.Sim_Cam);
                        else
                            ProcessName = EnumHelper.GetDescription(Enums.ProcessNames.Camera);
                        break;

                    case "Pb_MI_State":
                        ProcessName = EnumHelper.GetDescription(Enums.ProcessNames.Main);
                        break;
                    case "Pb_Light":
                        break;

                    case "Pb_AF":
                        break;

                }
                ProcessSet temp = Program.GetProcess(ProcessName);
                IntPtr procHandler = WinApis.FindWindow(null, temp.Proc.MainWindowTitle);
                Enums.WINDOWS_STATE State = Enums.WINDOWS_STATE.SW_SHOW;

                if (temp.State == Enums.WINDOWS_STATE.SW_MINIMIZE)
                    State = Enums.WINDOWS_STATE.SW_SHOW;

                else if (temp.State == Enums.WINDOWS_STATE.SW_SHOW)
                    State = Enums.WINDOWS_STATE.SW_MINIMIZE;

                WinApis.ShowWindow(procHandler, (int)State);
                WinApis.SetForegroundWindow(procHandler);
                temp.State = State;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void Timer_Time_Tick(object sender, EventArgs e)
        {
            try
            {
                Lb_DateTime.Text = System.DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// UI가 다른 Task의 상태를 확인하지 말고 다른 개별 Task가 UI로 상태를 보낸다?
        /// 다시 빨강색으로 바꾸는 조건? 타이머 여러개...?;;
        /// </summary>
        public void ThreadTaskAlive(CancellationToken token)
        {
            int nRet = Consts.APP_OK;
            CmdMsgParam Param = new CmdMsgParam();

            while (true)
            {
                try
                {
                    if (token.IsCancellationRequested == true)
                        return;
                    #region Camera Check
                    Param.ClearOffset();
                    Param.SetInteger(1);
                    nRet = Systems.g_Ipc.SendCommand((ushort)((Systems.CurDisplayIndex + 1) * 100 + IpcConst.CAMERA_TASK), IpcConst.TASK_ALIVE_FUNC, IpcConst.TASK_ALIVE_SIGNAL,
                                                                 IpcInterface.CMD_TYPE_RES, Consts.ALIVE_RESPONSE_TIME, Param.GetByteSize(), Param.GetParam());
                    if (nRet == Consts.APP_OK)
                        Systems.AliveList[Systems.CurDisplayIndex].Camera = true;
                    else
                        Systems.AliveList[Systems.CurDisplayIndex].Camera = false;
                    #endregion

                    #region SEQ Check
                    Param.ClearOffset();
                    Param.SetInteger(1);
                    nRet = Systems.g_Ipc.SendCommand((ushort)((Systems.CurDisplayIndex + 1) * 100 + IpcConst.SEQ_TASK), IpcConst.TASK_ALIVE_FUNC, IpcConst.TASK_ALIVE_SIGNAL,
                                                IpcInterface.CMD_TYPE_RES, Consts.ALIVE_RESPONSE_TIME, Param.GetByteSize(), Param.GetParam());
                    if (nRet == Consts.APP_OK)
                        Systems.AliveList[Systems.CurDisplayIndex].Sequence = true;
                    else
                        Systems.AliveList[Systems.CurDisplayIndex].Sequence = false;
                    #endregion                    
                    //#region LIGHT Check
                    //Param.ClearOffset();
                    //nRet = Systems.g_Ipc.SendCommand((ushort)((Systems.CurDisplayIndex + 1) * 100 + IpcConst.LIGHT_TASK),
                    //                                          IpcConst.TASK_ALIVE_FUNC,
                    //                                          IpcConst.TASK_ALIVE_SIGNAL,
                    //                                          IpcInterface.CMD_TYPE_RES,
                    //                                          nTimeOutCnt,
                    //                                          Param.GetByteSize(),
                    //                                          Param.GetParam());
                    //if (nRet != Consts.APP_OK)
                    //    break;


                    //if (nRet == Consts.APP_OK)
                    //    Systems.AliveList[Systems.CurDisplayIndex].light = true;
                    //else
                    //    Systems.AliveList[Systems.CurDisplayIndex].light = false;
                    //#endregion
                    // Check Main PC Task Alive
                    #region Main Check
                    Param.ClearOffset();
                    Param.SetInteger(1);
                    nRet = Systems.g_Ipc.SendCommand((ushort)((Systems.CurDisplayIndex + 1) * 100 + IpcConst.MAINPC_TASK), IpcConst.TASK_ALIVE_FUNC, IpcConst.TASK_ALIVE_SIGNAL,
                                                IpcInterface.CMD_TYPE_RES, Consts.ALIVE_RESPONSE_TIME, Param.GetByteSize(), Param.GetParam());
                    if (nRet == Consts.APP_OK)
                        Systems.AliveList[Systems.CurDisplayIndex].MainPc = true;
                    else
                        Systems.AliveList[Systems.CurDisplayIndex].MainPc = false;
                    #endregion
                    #region AF Check
                    if (Globals.Insp_Type[0] == 5)
                    {
                        Param.ClearOffset();
                        Param.SetInteger(1);
                        nRet = Systems.g_Ipc.SendCommand((ushort)((Systems.CurDisplayIndex + 1) * 100 + IpcConst.AF_TASK), IpcConst.TASK_ALIVE_FUNC, IpcConst.TASK_ALIVE_SIGNAL,
                                                    IpcInterface.CMD_TYPE_RES, Consts.ALIVE_RESPONSE_TIME, Param.GetByteSize(), Param.GetParam());
                        if (nRet == Consts.APP_OK)
                            Systems.AliveList[Systems.CurDisplayIndex].AF = true;
                        else
                            Systems.AliveList[Systems.CurDisplayIndex].AF = false;
                    }
                    #endregion
                    #region Light Check

                    Param.ClearOffset();
                    Param.SetInteger(1);
                    nRet = Systems.g_Ipc.SendCommand((ushort)((Systems.CurDisplayIndex + 1) * 100 + IpcConst.LIGHT_TASK), IpcConst.TASK_ALIVE_FUNC, IpcConst.TASK_ALIVE_SIGNAL,
                                                IpcInterface.CMD_TYPE_RES, Consts.ALIVE_RESPONSE_TIME, Param.GetByteSize(), Param.GetParam());
                    if (nRet == Consts.APP_OK)
                        Systems.AliveList[Systems.CurDisplayIndex].Light = true;
                    else
                        Systems.AliveList[Systems.CurDisplayIndex].Light = false;

                    #endregion
                    BeginInvoke(new Action(() =>
                   {
                       SetState();
                   }));

                    Thread.Sleep(Consts.ALIVE_INTERVAL);
                }
                catch (Exception ex)
                {
                    //Systems.LogWriter.Error("Error", ex);
                    Systems.WriteLog(0, Enums.LogLevel.ERROR, $"[ GUI ] Task Status Check 실패, Exception Message : {ex.Message}", false, false);
                    throw ex;
                }
            }
        }

        private void SetState()
        {
            try
            {
                System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
                string resourceName = asm.GetName().Name + ".Properties.Resources";
                var rm = new System.Resources.ResourceManager(resourceName, asm);

                if (Systems.g_Ipc.m_fnGetConnected())
                    Pb_VSS_State.Image = (Bitmap)rm.GetObject("Connect");
                else
                    Pb_VSS_State.Image = (Bitmap)rm.GetObject("Disconnect");
                //Pb_VSS_State.Refresh();

                if (Systems.AliveList[Systems.CurDisplayIndex].Camera)
                    Pb_CAM_State.Image = (Bitmap)rm.GetObject("Connect");
                else
                    Pb_CAM_State.Image = (Bitmap)rm.GetObject("Disconnect");

                if (Systems.AliveList[Systems.CurDisplayIndex].Sequence)
                    Pb_SEQ_State.Image = (Bitmap)rm.GetObject("Connect");
                else

                    Pb_SEQ_State.Image = (Bitmap)rm.GetObject("Disconnect");
                if (Systems.AliveList[Systems.CurDisplayIndex].MainPc)
                    Pb_MI_State.Image = (Bitmap)rm.GetObject("Connect");
                else
                    Pb_MI_State.Image = (Bitmap)rm.GetObject("Disconnect");
                if (Globals.Insp_Type[0] == 5)
                {
                    if (Systems.AliveList[Systems.CurDisplayIndex].AF)
                        Pb_AF.Image = (Bitmap)rm.GetObject("Connect");
                    else
                        Pb_AF.Image = (Bitmap)rm.GetObject("Disconnect");
                }

                if (Systems.AliveList[Systems.CurDisplayIndex].Light)
                    Pb_Light.Image = (Bitmap)rm.GetObject("Connect");
                else
                    Pb_Light.Image = (Bitmap)rm.GetObject("Disconnect");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}