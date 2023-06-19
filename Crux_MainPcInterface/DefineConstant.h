#pragma once

#define __W(x)			L##x
#define _W(x)			__W(x)
#define __WFUNCTION__	_W(__FUNCTION__)

#define	WM_TRAYICON_MSG					WM_USER + 1
#define	WM_PRINT_UI_LOG_MSG_UNICODE		WM_USER + 2
#define	WM_PRINT_UI_LOG_MSG_MULTI_BYTE	WM_USER + 3


#define VS_MAIN_PC_SIMULATOR_TASK_INI_FILE			theApp.GETDRV() + _T(":\\CRUX\\Data\\INI\\CRUX_MainPcSimulator.ini")
#define VS_MAIN_PC_INTERFACE_TASK_INI_FILE			theApp.GETDRV() + _T(":\\CRUX\\Data\\INI\\CRUX_MainPcInterface.ini")

#define INIT_FILE_PATH						theApp.GETDRV() + _T(":\\Crux\\DATA\\INI\\Initialize.ini")

//MergeTool INI_FILE_PATH//
#define MERGE_TOOL_FOLDER					theApp.GETDRV() + _T(":\\MergeTool")
#define MERGE_TOOL_INI_FILE					theApp.GETDRV() + _T(":\\MergeTool\\MergeRule.ini")

#define CRUX_GUI_TASK					10





enum {		
	// Timer index
	eTIMER_VS_CONNECT = 0 
};


#define SOCKET_SERVER_MODE	 0
#define SOCKET_CLIENT_MODE	 1


#define MAIN_PC_PACKET_STX_SIZE					1
#define MAIN_PC_PACKET_HEADER_SIZE				1
#define MAIN_PC_PACKET_DATA_SIZE_INFO_SIZE		4
#define MAIN_PC_PACKET_ETX_SIZE					1
#define MAIN_PC_PACKET_TOTAL					(MAIN_PC_PACKET_STX_SIZE + MAIN_PC_PACKET_HEADER_SIZE + MAIN_PC_PACKET_DATA_SIZE_INFO_SIZE + MAIN_PC_PACKET_ETX_SIZE)

#define MAIN_PC_PACKET_STX_POS					0
#define MAIN_PC_PACKET_HEADER_POS				(MAIN_PC_PACKET_STX_POS + MAIN_PC_PACKET_STX_SIZE)
#define MAIN_PC_PACKET_DATA_SIZE_INFO_POS		(MAIN_PC_PACKET_HEADER_POS + MAIN_PC_PACKET_HEADER_SIZE)
#define MAIN_PC_PACKET_DATA_POS					(MAIN_PC_PACKET_DATA_SIZE_INFO_POS + MAIN_PC_PACKET_DATA_SIZE_INFO_SIZE)

#define MAIN_PC_PACKET_STX						0x02
#define MAIN_PC_PACKET_HEADER					0x24
#define MAIN_PC_PACKET_ETX						0x03


//*************** Main PC --> Inspect PC  ***************************************//
#define MAIN_PC_PACKET_GRAB_START					"MOT.GRAB.START."
#define MAIN_PC_PACKET_GRAB_READY					"MOT.GRAB.END."
#define MAIN_PC_PACKET_ISNP_GRAB_START				"MOT.INSP.START."
#define MAIN_PC_PACKET_RECIPE_CHANGE				"MOT.RECIPE.CHANGE."
#define MAIN_PC_PACKET_SYSTEM_TIME_SET				"MOT.TIME.SET."
#define MAIN_PC_PACKET_PG_CHANGE_PARRERN			"MOT.PATTERN.CHANGE"	// 180801 YSS
#define MAIN_PC_PACKET_PG_OFF						"MOT.PATTERN.OFF"		// 180801 YSS
#define MAIN_PC_PACKET_PG_ON						"MOT.PATTERN.ON"		// 180822 YSS
#define MAIN_PC_PACKET_AF_READY						"MOT.AF.READY."		// 180822 YSS

#define MAIN_PC_PACKET_RECIPE_CURRENT_ID_REPLY		"MOT.RECIPE.CURRENT_ID."
#define MAIN_PC_PACKET_MOTION_RELATIVE_MOVE_REPLY	"MOT.MOTION.RELATIVE_MOVE."
#define MAIN_PC_PACKET_MOTION_RECIPE_POS_REPLY		"MOT.MOTION.SET_RECIPE_POS."
#define MAIN_PC_PACKET_VACUUM_SWITCH_REPLY			"MOT.VACUUM.SWITCH."
#define MAIN_PC_PACKET_MOTION_STATUS_REPLY			"MOT.MOTION.STATUS."
#define MAIN_PC_PACKET_LINE_GRAB_REPLY			    "MOT.LINE.GRAB."
#define MAIN_PC_PACKET_STAGEMOVE_REPLY				"MOT.GRAB.STAGEMOVE."


//*************** Inspect PC --> Main PC ***************************************//
#define MAIN_PC_PACKET_GRAB_START_REPLY				"FDB.GRAB.START."
#define MAIN_PC_PACKET_GRAB_READY_REPLY				"FDB.AF.READY."
#define MAIN_PC_PACKET_GRAB_END_REPLY				"FDB.GRAB.END."
#define MAIN_PC_PACKET_INSP_END_REPLY				"FDB.INSP.END."
#define MAIN_PC_PACKET_CLASSIFY_END_REPLY			"FDB.CLASS.END."
#define MAIN_PC_PACKET_RECIPE_CHANGE_REPLY			"FDB.RECIPE.CHANGE."
#define MAIN_PC_PACKET_REQ_CURRENT_RECIPE			"FDB.RECIPE.CURRENT_ID."
#define MAIN_PC_PACKET_INSPECT_JUDGED_REPLY			"FDB.INSP.RESULT."  // 추가 2019.04.12 오병종

#define MAIN_PC_PACKET_ALARM_OCCURED				"FDB.ALARM."
#define MAIN_PC_PACKET_MOTION_RELATIVE_MOVE			"FDB.MOTION.RELATIVE_MOVE."
#define MAIN_PC_PACKET_MOTION_SET_RECIPE_POS		"FDB.MOTION.SET_RECIPE_POS."
#define MAIN_PC_PACKET_VACUUM_SWITCH				"FDB.VACUUM.SWITCH."
#define MAIN_PC_PACKET_LINE_GRAB      				"FDB.LINE.GRAB.END."
#define MAIN_PC_PACKET_MOTION_STATUS				"FDB.MOTION.STATUS."
#define MAIN_PC_PACKET_STAGEMOVE_FORWARD			"FDB.GRAB.STAGEMOVE.F."
#define MAIN_PC_PACKET_STAGEMOVE_BACKWARD			"FDB.GRAB.STAGEMOVE.B."

// Align 결과 송부 추가
#define MAIN_PC_PACKET_ALIGN_RESULT					"FDB.ALIGN.RESULT."
// PG 관련 명령 추가	180801 YSS
#define MAIN_PC_PACKET_PG_CHANGE_PATTERN_REPLY		"FDB.PATTERN."
#define MAIN_PC_PACKET_PG_ON_REPLY					"FDB.PATTERN.ON."
#define MAIN_PC_PACKET_PG_OFF_REPLY					"FDB.PATTERN.OFF."


#ifdef UNICODE 
#define CODETYPE  2
#else
#define CODETYPE  1
#endif

#define SIZE_VIRTUAL_ID								50 * CODETYPE
#define SIZE_CELL_ID								50 * CODETYPE
#define SIZE_RECIPE_ID								50 * CODETYPE
#define SIZE_LOT_ID									50 * CODETYPE
#define SIZE_MOTOR_TYPE_NAME						20 * CODETYPE
#define SIZE_JUDGE									2  * CODETYPE // 추가 2019.04.12 오병종


#define TIMEOUT_CLASSIFY_END						600000
#define TIMEOUT_MAINPC_REPLY						10000
#define TIMEOUT_MAINPC_MOTION_MOVE_REPLY			10000
#define TIMEOUT_GRAB_END_OK							600000