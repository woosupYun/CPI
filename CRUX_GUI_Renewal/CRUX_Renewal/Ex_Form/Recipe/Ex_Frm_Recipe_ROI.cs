﻿using Cognex.VisionPro.QuickBuild;
using CRUX_Renewal.Class;
using CRUX_Renewal.User_Controls;
using CRUX_Renewal.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUX_Renewal.Ex_Form
{
    public partial class Ex_Frm_Recipe_ROI : Form
    {
        Uct_main_View MainPic;
        Uct_Mini_View MiniPic;
        int m_nCamPsModeRatio = 1;
        Label m_lbImageState = new Label();

        public Ex_Frm_Recipe_ROI()
        {
            InitializeComponent();
            TopLevel = false;
            Dock = DockStyle.Fill;
            FormBorderStyle = FormBorderStyle.None;
            Show();
        }
        public void FormInitialize(int no)
        {
            MiniPic = new Uct_Mini_View();// m_UcRcpTeachPic.m_ucPicMiniMap;
            MiniPic.miniMapSize(pnlMinGuideLine.Width, pnlMinGuideLine.Height, pnlMinGuideLine.Location.X, pnlMinGuideLine.Location.Y);
            this.Controls.Add(MiniPic);
            MiniPic.Location = new Point(pnlMinGuideLine.Location.X, pnlMinGuideLine.Location.Y);
            MiniPic.BackColor = Color.Black;
            MainPic = new Uct_main_View(this, ref MiniPic, true, pnlMapGuideLine.Width, pnlMapGuideLine.Height,
                                                 pnlMapGuideLine.Location.X, pnlMapGuideLine.Location.Y);
            MiniPic.ucRefMainImg(ref MainPic); 
           // MainPic.m_fnSetCameraFovRatio(MainPic.m_fnGetCameraFovSize());
            //m_nCamPsModeRatio = MainPic.m_fnGetCameraFovRatio();
            MainPic.BackColor = Color.Red;
            //MainPic.m_fnLinkCurCoord(ref lbCoordX, ref lbCoordY);
            MainPic.m_fnLinkNowRatio(ref lbRatio);
            //MainPic.m_fnLinkPointCoord(ref lbPntX1, ref lbPntY1);
            //MainPic.m_fnLinkGdOriginCoord(ref lbGdOriginX1, ref lbGdOriginY1);
            //MainPic.m_fnLinkCurRGBVal(ref lbClrR, ref lbClrG, ref lbClrB);

            //MainPic.m_fnLinkDrawLineCoord(ref lblDrawLineX1, ref lblDrawLineY1, ref lblDrawLineX2, ref lblDrawLineY2);

            // ROI 좌표 등록 사용 안함
            MainPic.m_fnUseEventRectOff();
            MainPic.InitRectColor((int)Enums.DrawRct.INSP, Color.Red);
            MainPic.InitRectColor((int)Enums.DrawRct.RND, Color.LightSkyBlue);
            MainPic.InitRectColor((int)Enums.DrawRct.NON, Color.Yellow);
            MainPic.InitRectColor((int)Enums.DrawRct.HOLE, Color.Purple);   //2019.02.20 for Hole ROI
            MainPic.InitRectColor((int)Enums.DrawRct.PAD, Color.Pink);
            MainPic.InitRectColor((int)Enums.DrawRct.FDC_MARK, Color.Orange);
            MainPic.InitRectColor((int)Enums.DrawRct.ALIGN_MARK, Color.LightSteelBlue);
            MainPic.InitRectColor((int)Enums.DrawRct.PAD_INSP, Color.Crimson);
            MainPic.InitRectColor((int)Enums.DrawRct.PAD_NONE, Color.Gold);

            // point 좌표 등록 사용 안함
            //MainPic.m_fnUseEventPointOff();
            //MainPic.InitPointColor((int)Enums.DrawPnt.WORK_ORIGN, Color.LightGreen);
            //MainPic.InitPointColor((int)Enums.DrawPnt.GD_ORIGIN, Color.LightGoldenrodYellow);
            //MainPic.InitPointColor((int)Enums.DrawPnt.FDC_POINT, Color.Red, (int)Enums.E_PNT_VIEW_KIND.POINT);
            //MainPic.InitPointColor((int)Enums.DrawPnt.POLYGON_PAD_INSP, Color.LightGreen, (int)Enums.E_PNT_VIEW_KIND.POLYGON);
            //MainPic.InitPointColor((int)Enums.DrawPnt.POLYGON_PAD_NONE, Color.LightGreen, (int)Enums.E_PNT_VIEW_KIND.POLYGON);

            //// ROI 좌표 중복 등록 사용 안함
            //MainPic.m_fnUseRoiMultiLine(false);

            //// 가이드 라인 사용 안함
            //MainPic.m_fnUseEventGuideLineView(false);
        }
        private void Ex_Frm_AccountManage_Load(object sender, EventArgs e)
        {
            //Region = System.Drawing.Region.FromHrgn(WinApis.CreateRoundRectRgn(0, 0, this.Width, this.Height, 15, 15));
        }

        private void Ex_Frm_AccountManage_Shown(object sender, EventArgs e)
        {
            //Region = System.Drawing.Region.FromHrgn(WinApis.CreateRoundRectRgn(0, 0, this.Width, this.Height, 5, 5));
            ////WinApis.SetWindowRgn(Btn_Manage.Handle, WinApis.CreateRoundRectRgn(0, 0, Btn_Manage.Width, Btn_Manage.Height, 15, 15), true);
            ////WinApis.SetWindowRgn(Btn_Login.Handle, WinApis.CreateRoundRectRgn(0, 0, Btn_Login.Width, Btn_Login.Height, 15, 15), true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Mat tt = OpenCvSharp.Cv2.ImRead(@"D:\회사업무\프로젝트\ACI\삼성프로젝트\All-1.bmp", OpenCvSharp.ImreadModes.Unchanged);
            //uctrl_MainPic1.m_fnSetBitmap(@"D:\회사업무\프로젝트\ACI\삼성프로젝트\All-1.bmp");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Mat tt = OpenCvSharp.Cv2.ImRead(@"D:\회사업무\프로젝트\ACI\삼성프로젝트\All-1.bmp", OpenCvSharp.ImreadModes.Unchanged);
            MainPic.OpenImage(@"D:\회사업무\프로젝트\ACI\삼성프로젝트\All-1.bmp");
        }
    }
}