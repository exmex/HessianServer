; http://www.autoitscript.com/

#include <GUIConstantsEx.au3>
#include <WindowsConstants.au3>
#include <EditConstants.au3>

$nMaxProcessNumber = 8
$nMinProcessNumber = 0

$nTotalProcess = 0
$nOption_DeveloperVersion = 0
$sOption_BuildType = ""
$nOption_SoundEnabled = 0
$nOption_FullScreen = 0
$nOption_IntroMovieEnabled = 0
$nOption_SeekFreePackageMap = 0
$sOption_MainWindowLocation = ""
$sOption_MainWindowAlignType = ""
$sOption_LogWindowLocation = ""
$sOption_LogWindowAlignType = ""
$sOption_PlatformType = ""
$sOption_LaunchType = ""
$sOption_LoginServerAddress = ""
$sOption_LoginServerAddresses = ""
$nOption_AutoConnect = 0
$nOption_AutoEnterChannel = 0
$nOption_AutoCreateRoom = 0
$sOption_RoomMapInfo = ""
$nOption_RoomKillLimit = 0
$nOption_RoomRoundLimit = 0
$nOption_RoomTimeLimit = 0
$sOption_DefaultRoomTitle = ""
$sOption_ConnectType = ""
$sOption_DefaultLevel = ""
$sOption_RemoteHostAddress = ""
$sOption_AdditionalParam = ""
Dim $aOption_InitialAccount[$nMaxProcessNumber]
Dim $aOption_Resolution[$nMaxProcessNumber]
Dim $aOption_IsAdult[$nMaxProcessNumber]
Dim $aOption_RemoteControl[$nMaxProcessNumber]

$sIniFilename = StringTrimRight(@ScriptFullPath, 4) & ".ini"
$sLoginIniFilename = StringTrimRight(@ScriptFullPath, 4) & "_Login.ini"

Dim $aDesktopRect[4] ; X, Y, Width, Height

$nProcessControlVerticalInterval = 50
$nWindowTypeLog = 1
$nWindowTypeMain = 2
$bContinueLoop = 1
$bStartProcess = 0

$sDefaultLocation_None = "None"
$sDefaultLocation_Primary = "Main Monitor"
$sDefaultLocation_PrimaryLeft = "Left Monitor"
$sDefaultLocation_PrimaryRight = "Right Monitor"

$sDefaultAlignType_None = "None"
$sDefaultAlignType_Diagonal = "Diagonal"
$sDefaultAlignType_AlignTop = "Align Top"
$sDefaultAlignType_AlignBottom = "Align Bottom"
$sDefaultAlignType_AlignLeft = "Align Left"
$sDefaultAlignType_AlignRight = "Align Right"

Dim $aDefaultResolutions[1][2]

AddDefaultResolution(400, 300)
AddDefaultResolution(640, 480)
AddDefaultResolution(800, 500)
AddDefaultResolution(800, 600)
AddDefaultResolution(1024, 768)
AddDefaultResolution(1280, 800)
AddDefaultResolution(1280, 960)
AddDefaultResolution(1280, 1024)
AddDefaultResolution(1440, 900)
AddDefaultResolution(1680, 1050)
AddDefaultResolution(1920, 1080)
AddDefaultResolution(1920, 1200)

Func AddDefaultResolution($ResX, $ResY)
	$nBound = UBound($aDefaultResolutions)
	$aDefaultResolutions[$nBound-1][0] = $ResX
	$aDefaultResolutions[$nBound-1][1] = $ResY
	ReDim $aDefaultResolutions[$nBound + 1][2]
EndFunc

$GUI_Main = GUICreate("Launch Hessian", 450, 400)
$aGUIPosition = WinGetPos($GUI_Main)
Opt("GUIResizeMode", $GUI_DOCKALL)

$Label_TotalProcess = GUICtrlCreateLabel("Process count", 10, 14)
$Input_TotalProcess = GUICtrlCreateInput("", 80, 10, 40, 20, $ES_READONLY)
$Updown_TotalProcess = GUICtrlCreateUpdown($Input_TotalProcess)
$CheckBox_SoundEnabled = GUICtrlCreateCheckbox("Sound output", 10, 40)
GUICtrlSetTip(-1, "When off, adds the -nosound command to the run line.");
$CheckBox_FullScreen = GUICtrlCreateCheckbox("Fullscreen", 10, 60)
GUICtrlSetTip(-1, "실행시킬 프로세스 수가 하나인 상태에서 표시하면 -fullscreen 명령을," & @CRLF & "그렇지 않거나 해제하면 -windowed 명령을 실행줄에 추가합니다.");
$CheckBox_IntroMovieEnabled = GUICtrlCreateCheckbox("Intro movie", 10, 80)
GUICtrlSetTip(-1, "해제하면 프로세스 실행시 도입부 동영상을 건너뜁니다." & @CRLF & "-nostartupmovies 파라메터를 활성화시켜 건너뜁니다.");
$CheckBox_SeekFreePackageMap = GUICtrlCreateCheckbox("Bypass package GUID checking", 10, 100)
GUICtrlSetTip(-1, "표시하면 호스트와 클라이언트 연결시 패키지 GUID 검사를 생략합니다." & @CRLF & "-SeekFreePackageMap 파라메터를 활성화합니다.");
$Label_MainWindowLocation = GUICtrlCreateLabel("Main Window Location", 140, 14)
GUICtrlSetTip(-1, "윈도우 시작메뉴가 있는 쪽이 주 모니터입니다.");
$Combo_MainWindowLocation = GUICtrlCreateCombo("", 185, 10, 100, 20)
GUICtrlSetData($Combo_MainWindowLocation, $sDefaultLocation_Primary)
GUICtrlSetData($Combo_MainWindowLocation, $sDefaultLocation_PrimaryLeft)
GUICtrlSetData($Combo_MainWindowLocation, $sDefaultLocation_PrimaryRight)
$Label_MainWindowAlignType = GUICtrlCreateLabel("Main Window Align", 295, 14)
GUICtrlSetTip(-1, "창 배치 방식을 지정합니다.");
$Combo_MainWindowAlignType = GUICtrlCreateCombo("", 350, 10, 90, 20)
GUICtrlSetData($Combo_MainWindowAlignType, $sDefaultAlignType_None)
GUICtrlSetData($Combo_MainWindowAlignType, $sDefaultAlignType_Diagonal)
GUICtrlSetData($Combo_MainWindowAlignType, $sDefaultAlignType_AlignTop)
GUICtrlSetData($Combo_MainWindowAlignType, $sDefaultAlignType_AlignBottom)
GUICtrlSetData($Combo_MainWindowAlignType, $sDefaultAlignType_AlignLeft)
GUICtrlSetData($Combo_MainWindowAlignType, $sDefaultAlignType_AlignRight)
$Label_LogWindowLocation = GUICtrlCreateLabel("Log Window", 140, 44)
GUICtrlSetTip(-1, "윈도우 시작메뉴가 있는 쪽이 주 모니터입니다.");
$Combo_LogWindowLocation = GUICtrlCreateCombo("", 185, 40, 100, 20)
GUICtrlSetData($Combo_LogWindowLocation, $sDefaultLocation_None)
GUICtrlSetData($Combo_LogWindowLocation, $sDefaultLocation_Primary)
GUICtrlSetData($Combo_LogWindowLocation, $sDefaultLocation_PrimaryLeft)
GUICtrlSetData($Combo_LogWindowLocation, $sDefaultLocation_PrimaryRight)
$Label_LogWindowAlignType = GUICtrlCreateLabel("Log Window Align", 295, 44)
GUICtrlSetTip(-1, "창 배치 방식을 지정합니다.");
$Combo_LogWindowAlignType = GUICtrlCreateCombo("", 350, 40, 90, 20)
GUICtrlSetData($Combo_LogWindowAlignType, $sDefaultAlignType_None)
GUICtrlSetData($Combo_LogWindowAlignType, $sDefaultAlignType_Diagonal)
GUICtrlSetData($Combo_LogWindowAlignType, $sDefaultAlignType_AlignTop)
GUICtrlSetData($Combo_LogWindowAlignType, $sDefaultAlignType_AlignBottom)
GUICtrlSetData($Combo_LogWindowAlignType, $sDefaultAlignType_AlignLeft)
GUICtrlSetData($Combo_LogWindowAlignType, $sDefaultAlignType_AlignRight)
$Group_PlatformType = GUICtrlCreateGroup("Platform", 220, 70, 110, 60)
Opt('GUICoordMode', 0) ; relative
$Radio_PlatformWin32 = GUICtrlCreateRadio("Win32", 10, 15, 60, 20)
GUICtrlSetTip(-1, "일반적인 실행 환경입니다.");
$Radio_PlatformWin64 = GUICtrlCreateRadio("Win64", 0, 20, 60, 20)
GUICtrlSetTip(-1, "64비트 OS가 설치되어 있고 64비트 개발 환경에서 빌드된 실행파일이 있을 경우 사용 가능합니다.");
Opt('GUICoordMode', 1) ; absolute
$Group_BuildType = GUICtrlCreateGroup("Build Type", 350, 70, 90, 80)
Opt('GUICoordMode', 0) ; relative
$Radio_DebugBuild = GUICtrlCreateRadio("Debug", 10, 15, 60, 20)
GUICtrlSetTip(-1, "개발용으로 빌드된 디버그 실행 파일이 있을 경우 사용 가능합니다.");
$Radio_ReleaseBuild = GUICtrlCreateRadio("Release", 0, 20, 60, 20)
GUICtrlSetTip(-1, "일반적인 실행 빌드입니다.");
$Radio_InternalBuild = GUICtrlCreateRadio("Internal", 0, 20, 60, 20)
GUICtrlSetTip(-1, "일반적인 실행 빌드입니다.");
Opt('GUICoordMode', 1) ; absolute
$Tab_Options = GUICtrlCreateTab(10, 135, 430, 180)
	$TabItem_OnlineClient = GUICtrlCreateTabItem("Online Client")
		$Label_LoginServerAddress = GUICtrlCreateLabel("LoginServerIP", 25, 170)
		GUICtrlSetTip(-1, "지정하지 않을 경우 HessianGame.ini 파일의 채널 서버 주소로 접속합니다.");
		Opt('GUICoordMode', 0) ; relative
		$Combo_LoginServerAddress = GUICtrlCreateCombo("", 90, -4, 210, 20)
		$Button_AddLoginServerAddress = GUICtrlCreateButton("Add", 220, -2, 40)
		GUICtrlSetTip(-1, "입력된 주소를 저장 목록에 추가합니다.");
		$Button_DeleteLoginServerAddress = GUICtrlCreateButton("Delete", 50, 0, 40)
		GUICtrlSetTip(-1, "선택된 주소를 저장 목록에서 삭제합니다.");
		$CheckBox_AutoConnect = GUICtrlCreateCheckbox("Auto Connect", -360, 30)
		GUICtrlSetTip(-1, "표시하면 -AutoConnectChannelServer 명령을 실행줄에 추가합니다.");
		$CheckBox_AutoEnterChannel = GUICtrlCreateCheckbox("Auto Enter Channel", 0, 20)
		GUICtrlSetTip(-1, "표시하면 -AutoEnterChannel 명령을 실행줄에 추가합니다.");
		$CheckBox_AutoCreateRoom = GUICtrlCreateCheckbox("Auto Create Room", 0, 20)
		GUICtrlSetTip(-1, "표시하면 채널에 입장한 직후 입력한 미션ID와 맵ID로 방을 생성합니다." & @CRLF & "방의 기본 제목을 반드시 지정해야 합니다." & @CRLF & "첫번째 게임 프로세스만 방을 생성합니다.");
		$Label_RoomMapInfo = GUICtrlCreateLabel("Room Map Info", 120, 3)
		GUICtrlSetTip(-1, "DataSheet\MapInfo.xml 파일의 내용과 동일합니다.");
		$Combo_RoomMapInfo = GUICtrlCreateCombo("", 50, -4, 230, 20)
		$Label_RoomKillLimit = GUICtrlCreateLabel("Room Kill Limit", -140, 30)
		$Combo_RoomKillLimit = GUICtrlCreateCombo("", 50, -4, 50, 0)
		GUICtrlSetData($Combo_RoomKillLimit, 60)
		GUICtrlSetData($Combo_RoomKillLimit, 100)
		GUICtrlSetData($Combo_RoomKillLimit, 120)
		GUICtrlSetData($Combo_RoomKillLimit, 160)
		GUICtrlSetData($Combo_RoomKillLimit, 200)
		$Label_RoomRoundLimit = GUICtrlCreateLabel("Room Round Limit", 70, 4)
		$Combo_RoomRoundLimit = GUICtrlCreateCombo("", 80, -4, 40, 0)
		GUICtrlSetData($Combo_RoomRoundLimit, 1)
		GUICtrlSetData($Combo_RoomRoundLimit, 3)
		GUICtrlSetData($Combo_RoomRoundLimit, 5)
		GUICtrlSetData($Combo_RoomRoundLimit, 7)
		GUICtrlSetData($Combo_RoomRoundLimit, 9)
		$Label_RoomTimeLimit = GUICtrlCreateLabel("Room Time Limit", 60, 4)
		$Combo_RoomTimeLimit = GUICtrlCreateCombo("", 60, -4, 50, 0)
		GUICtrlSetData($Combo_RoomTimeLimit, 300)
		GUICtrlSetData($Combo_RoomTimeLimit, 600)
		GUICtrlSetData($Combo_RoomTimeLimit, 900)
		GUICtrlSetData($Combo_RoomTimeLimit, 1200)
		GUICtrlSetData($Combo_RoomTimeLimit, 1500)
		$Label_DefaultRoomTitle = GUICtrlCreateLabel("Default Room", -350, 30)
		GUICtrlSetTip(-1, "로비에서 방을 만들 때 기본으로 입력하고자 하는 방 제목을 미리 지정할 수 있습니다." & @CRLF & "내용을 입력하면 -DefaultRoomTitle 명령을 실행줄에 추가합니다.");
		$Input_DefaultRoomTitle = GUICtrlCreateInput("", 120, -4, 280, 20)
		Opt('GUICoordMode', 1) ; absolute
	$TabItem_DirectClient = GUICtrlCreateTabItem("Direct Client")
		$Group_ConnectType = GUICtrlCreateGroup("Connect Client", 25, 170, 210, 80)
		Opt('GUICoordMode', 0) ; relative
		$Radio_ConnectTypeHostClient = GUICtrlCreateRadio("Host Client", 15, 15, 180, 20)
		GUICtrlSetTip(-1, "첫번째 프로세스는 호스트로 실행하고, 다른 프로세스는 로컬 호스트로 접속하는 클라이언트로 실행합니다.");
		$Radio_ConnectTypeRemoteClient = GUICtrlCreateRadio("Remote Client", 0, 20, 180, 20)
		GUICtrlSetTip(-1, "모든 프로세스를 원격 호스트로 접속하는 클라이언트로 실행합니다.");
		$Radio_ConnectTypeStandAlone = GUICtrlCreateRadio("Standalone", 0, 20, 180, 20)
		GUICtrlSetTip(-1, "모든 프로세스를 네트워크에 연결되지 않은 프로세스로 실행합니다.");
		$Label_DefaultLevel = GUICtrlCreateLabel("Default Level", -15, 40)
		GUICtrlSetTip(-1, "호스트 또는 단독으로 실행될 때 이 레벨을 사용합니다. 원격 호스트로 접속할 경우 이 내용은 무시됩니다.");
		$Combo_DefaultLevel = GUICtrlCreateCombo("", 70, -4, 340, 20)
		$Label_RemoteHostAddress = GUICtrlCreateLabel("Remote Host Address", -70, 30)
		GUICtrlSetTip(-1, "접속 시도할 원격 호스트 주소입니다.");
		$Input_RemoteHostAddress = GUICtrlCreateInput("", 110, -4, 290, 20)
		Opt('GUICoordMode', 1) ; absolute
	GUICtrlCreateTabItem("")
$Label_AdditionalParam = GUICtrlCreateLabel("Additional Params", 12, 330)
GUICtrlSetTip(-1, "임의의 파라메터를 실행줄에 추가합니다.");
$Input_AdditionalParam = GUICtrlCreateInput("", 100, 326, 340, 20)
Dim $aInput_InitialAccount[$nMaxProcessNumber]
Dim $aLabel_Processes[$nMaxProcessNumber]
Dim $aLabel_InitialAccount[$nMaxProcessNumber]
Dim $aLabel_Resolution[$nMaxProcessNumber]
Dim $aCombo_Resolution[$nMaxProcessNumber]
Dim $aCheckBox_IsAdult[$nMaxProcessNumber]
Dim $aCheckBox_RemoteControl[$nMaxProcessNumber]
For $i = 0 To $nMaxProcessNumber - 1
	$aLabel_Processes[$i] = GUICtrlCreateLabel("Processes " & $i + 1, 12, 364 + $i * $nProcessControlVerticalInterval)
	$aLabel_InitialAccount[$i] = GUICtrlCreateLabel("Initial Account", 70, 364 + $i * $nProcessControlVerticalInterval)
	GUICtrlSetTip(-1, "공란으로 두면 임의의 계정명을 생성합니다.");
	$aInput_InitialAccount[$i] = GUICtrlCreateInput("", 100, 360 + $i * $nProcessControlVerticalInterval, 80, 20)
	$aLabel_Resolution[$i] = GUICtrlCreateLabel("Res:", 190, 364 + $i * $nProcessControlVerticalInterval)
	GUICtrlSetTip(-1, "기본값으로 할 경우 엔진의 기본 설정 해상도로 지정됩니다." & @CRLF & "원하는 해상도가 목록에 없을 경우 기본값으로 설정한 뒤 추가 파라메터에 '-ResX=가로해상도 -ResY=세로해상도'를 입력하세요.");
	$aCombo_Resolution[$i] = GUICtrlCreateCombo("기본값", 230, 360 + $i * $nProcessControlVerticalInterval, 80)
	For $j = 0 To UBound($aDefaultResolutions) - 2
		GUICtrlSetData(-1, $aDefaultResolutions[$j][0] & "x" & $aDefaultResolutions[$j][1])
	Next
	For $j = 0 To UBound($aDefaultResolutions) - 2
		GUICtrlSetData(-1, $aDefaultResolutions[$j][1] & "x" & $aDefaultResolutions[$j][0])
	Next
	$aCheckBox_IsAdult[$i] = GUICtrlCreateCheckbox("IsAdult", 320, 360 + $i * $nProcessControlVerticalInterval)
	$aCheckBox_RemoteControl[$i] = GUICtrlCreateCheckbox("RemoteControl", 390, 360 + $i * $nProcessControlVerticalInterval)
	GUICtrlSetTip(-1, "RemoteControl 창을 띄웁니다.");
Next
$Button_Start = GUICtrlCreateButton("Launch", default, default, 200, 30)

MainFunc()

Func MainFunc()
	CheckDesktopRect()
	ReadFromIni()
	If $nOption_DeveloperVersion == 1 Then
		If FileExists(@ScriptDir & "\..\HessianGame\Content") == 1 Then
			ReadUnrealEngineLevel(@ScriptDir & "\..\HessianGame\Content")
			ReadDataSheetInfo(@ScriptDir & "\..\HessianGame\DataSheet")
		Else
			ReadUnrealEngineLevel(@ScriptDir & "\..\HessianGame\CookedPC")
			ReadDataSheetInfo(@ScriptDir & "\..\HessianGame\DataSheet")
		EndIf
	EndIf

	GUICtrlSetLimit($Updown_TotalProcess, $nMaxProcessNumber, $nMinProcessNumber)
	GUIRegisterMsg(0x020A, "EventReceived")

	ApplyOptionsToControls()
	AddNewLoginServerAddress()
	EventReceived(0,0,0,0)
	HotKeySet("{ENTER}", "OnKeyPressEnter");

	GUISetState(@SW_SHOW)
	GUICtrlSetState($Button_Start, $GUI_FOCUS)

	While $bContinueLoop
		$msg = GUIGetMsg()

		Select
		Case $msg = $Updown_TotalProcess
			EventReceived(0,0,0,0)

		Case $msg = $Button_AddLoginServerAddress
			AddNewLoginServerAddress()

		Case $msg = $Button_DeleteLoginServerAddress
			$sToDelete = GUICtrlRead($Combo_LoginServerAddress)
			$sNextDefault = ""
			$sAddresses = StringSplit($sOption_LoginServerAddresses, "|")
			$sOption_LoginServerAddresses = ""
			For $i = 1 To $sAddresses[0]
				; 삭제할 주소를 제외하고 나머지 주소를 재조립한다.
				If $sAddresses[$i] <> $sToDelete Then
					$sOption_LoginServerAddresses = $sOption_LoginServerAddresses & $sAddresses[$i] & "|"
					$sNextDefault = $sAddresses[$i]
				EndIf
			Next
			$sOption_LoginServerAddresses = StringTrimRight($sOption_LoginServerAddresses, 1)
			GUICtrlSetData($Combo_LoginServerAddress, "|" & $sOption_LoginServerAddresses, $sNextDefault)

		Case $msg = $Radio_ConnectTypeHostClient
			GUICtrlSetState($Label_DefaultLevel, $GUI_ENABLE)
			GUICtrlSetState($Combo_DefaultLevel, $GUI_ENABLE)
			GUICtrlSetState($Label_RemoteHostAddress, $GUI_DISABLE)
			GUICtrlSetState($Input_RemoteHostAddress, $GUI_DISABLE)

		Case $msg = $Radio_ConnectTypeRemoteClient
			GUICtrlSetState($Label_DefaultLevel, $GUI_DISABLE)
			GUICtrlSetState($Combo_DefaultLevel, $GUI_DISABLE)
			GUICtrlSetState($Label_RemoteHostAddress, $GUI_ENABLE)
			GUICtrlSetState($Input_RemoteHostAddress, $GUI_ENABLE)

		Case $msg = $Radio_ConnectTypeStandAlone
			GUICtrlSetState($Label_DefaultLevel, $GUI_ENABLE)
			GUICtrlSetState($Combo_DefaultLevel, $GUI_ENABLE)
			GUICtrlSetState($Label_RemoteHostAddress, $GUI_DISABLE)
			GUICtrlSetState($Input_RemoteHostAddress, $GUI_DISABLE)

		Case $msg = $CheckBox_AutoCreateRoom
			If GUICtrlRead($CheckBox_AutoCreateRoom) == $GUI_CHECKED Then
				GUICtrlSetState($Label_RoomMapInfo, $GUI_ENABLE)
				GUICtrlSetState($Combo_RoomMapInfo, $GUI_ENABLE)
				GUICtrlSetState($Label_RoomKillLimit, $GUI_ENABLE)
				GUICtrlSetState($Combo_RoomKillLimit, $GUI_ENABLE)
				GUICtrlSetState($Label_RoomRoundLimit, $GUI_ENABLE)
				GUICtrlSetState($Combo_RoomRoundLimit, $GUI_ENABLE)
				GUICtrlSetState($Label_RoomTimeLimit, $GUI_ENABLE)
				GUICtrlSetState($Combo_RoomTimeLimit, $GUI_ENABLE)
			Else
				GUICtrlSetState($Label_RoomMapInfo, $GUI_DISABLE)
				GUICtrlSetState($Combo_RoomMapInfo, $GUI_DISABLE)
				GUICtrlSetState($Label_RoomKillLimit, $GUI_DISABLE)
				GUICtrlSetState($Combo_RoomKillLimit, $GUI_DISABLE)
				GUICtrlSetState($Label_RoomRoundLimit, $GUI_DISABLE)
				GUICtrlSetState($Combo_RoomRoundLimit, $GUI_DISABLE)
				GUICtrlSetState($Label_RoomTimeLimit, $GUI_DISABLE)
				GUICtrlSetState($Combo_RoomTimeLimit, $GUI_DISABLE)
			EndIf

		Case $msg = $Button_Start
			$bStartProcess = 1
			$bContinueLoop = 0

		Case $msg = $GUI_EVENT_CLOSE
			$bContinueLoop = 0

		EndSelect
	WEnd

	GUICtrlSetState($Button_Start, $GUI_DISABLE)
	ApplyControlsToOptions()

	GUIDelete($GUI_Main)

	WriteToIni()

	If $bStartProcess == 1 Then
		LaunchAll()
	EndIf
EndFunc

Func CheckDesktopRect()
	$hTaslkbar = WinGetHandle("[CLASS:Shell_TrayWnd]")
	$aTaskbarRect = WinGetPos($hTaslkbar)

	$nTaskbarBorderSize = 0
	If $aTaskbarRect[0] < 0 Then
		$nTaskbarBorderSize = -$aTaskbarRect[0]
	ElseIf $aTaskbarRect[1] < 0 Then
		$nTaskbarBorderSize = -$aTaskbarRect[1]
	EndIf

	$aTaskbarRect[0] += $nTaskbarBorderSize
	$aTaskbarRect[1] += $nTaskbarBorderSize
	$aTaskbarRect[2] -= $nTaskbarBorderSize * 2
	$aTaskbarRect[3] -= $nTaskbarBorderSize * 2

	$aDesktopRect[0] = 0
	$aDesktopRect[1] = 0
	$aDesktopRect[2] = @DesktopWidth
	$aDesktopRect[3] = @DesktopHeight

	If $aTaskbarRect[2] == $aDesktopRect[2] Then
		If $aTaskbarRect[1] == 0 Then
			; 작업 바가 위쪽에 있을 때
			$aDesktopRect[1] = $aTaskbarRect[3]
			$aDesktopRect[3] -= $aTaskbarRect[3]
		Else
			; 작업 바가 아래쪽에 있을 때
			$aDesktopRect[3] -= $aTaskbarRect[3]
		EndIf
	ElseIf $aTaskbarRect[3] == $aDesktopRect[3] Then
		If $aTaskbarRect[0] == 0 Then
			; 작업 바가 왼쪽에 있을 때
			$aDesktopRect[0] = $aTaskbarRect[2]
			$aDesktopRect[2] -= $aTaskbarRect[2]
		Else
			; 작업 바가 오른쪽에 있을 때
			$aDesktopRect[2] -= $aTaskbarRect[2]
		EndIf
	EndIf
EndFunc

Func OnKeyPressEnter()
	HotKeySet("{ENTER}");
	If WinActive($GUI_Main) == 1 Then
		$bStartProcess = 1
		$bContinueLoop = 0
	Else
		Send("{ENTER}")
		HotKeySet("{ENTER}", "OnKeyPressEnter");
	EndIf
EndFunc

Func EventReceived($hWnd, $Msg, $wParam, $lParam)
	;MsgBox(0, "EventReceived " & $Msg, $wParam)
	$value = GUICtrlRead($Input_TotalProcess)

	If $Msg == 0x020A Then
		If $wParam == "0x00780000" Then
			; 위로 스크롤
			If $value < $nMaxProcessNumber Then
				$value = $value + 1
			EndIf
		ElseIf $wParam == "0xFF880000" Then
			; 아래로 스크롤
			If $value > $nMinProcessNumber Then
				$value = $value - 1
			EndIf
		EndIf
	EndIf

	GUICtrlSetData($Input_TotalProcess, $value)

	; 바뀐 프로세스 수에 맞게 창 크기 조절
	WinMove($GUI_Main, "", Default, Default, $aGUIPosition[2], $aGUIPosition[3] + $value * $nProcessControlVerticalInterval)

	For $i = 0 To $nMaxProcessNumber - 1
		$StateToSet = $GUI_HIDE
		If $i < $value Then
			$StateToSet = $GUI_SHOW
		EndIf

		GUICtrlSetState($aLabel_Processes[$i], $StateToSet)
		GUICtrlSetState($aLabel_InitialAccount[$i], $StateToSet)
		GUICtrlSetState($aInput_InitialAccount[$i], $StateToSet)
		GUICtrlSetState($aLabel_Resolution[$i], $StateToSet)
		GUICtrlSetState($aCombo_Resolution[$i], $StateToSet)
		GUICtrlSetState($aCheckBox_IsAdult[$i], $StateToSet)
		GUICtrlSetState($aCheckBox_RemoteControl[$i], $StateToSet)
		GUICtrlSetPos($Button_Start, 120, 360 + $value * $nProcessControlVerticalInterval)
	Next
EndFunc

Func ReadFromIni()
	; 기본 설정 값 읽어오기
	$nTotalProcess = IniRead($sIniFilename, "General", "TotalProcess", 0)
	$sOption_BuildType = IniRead($sIniFilename, "General", "BuildType", "")
	$nOption_SoundEnabled = IniRead($sIniFilename, "General", "SoundEnabled", 1)
	$nOption_FullScreen = IniRead($sIniFilename, "General", "FullScreen", 0)
	$nOption_IntroMovieEnabled = IniRead($sIniFilename, "General", "IntroMovieEnabled", 1)
	$nOption_SeekFreePackageMap = IniRead($sIniFilename, "General", "SeekFreePackageMap", 0)
	$sOption_MainWindowLocation = IniRead($sIniFilename, "General", "MainWindowLocation", "")
	$sOption_MainWindowAlignType = IniRead($sIniFilename, "General", "MainWindowAlignType", "")
	$sOption_LogWindowLocation = IniRead($sIniFilename, "General", "LogWindowLocation", "")
	$sOption_LogWindowAlignType = IniRead($sIniFilename, "General", "LogWindowAlignType", "")
	$sOption_PlatformType = IniRead($sIniFilename, "General", "PlatformType", "")
	$sOption_LaunchType = IniRead($sIniFilename, "General", "LaunchType", "")
	$nOption_DeveloperVersion = IniRead($sLoginIniFilename, "General", "DeveloperVersion", 0)
	$sOption_LoginServerAddress = IniRead($sLoginIniFilename, "General", "LoginServerAddress", "")

	If $sOption_LoginServerAddress == "" Then
		$sOption_LoginServerAddress = IniRead($sIniFilename, "General", "LoginServerAddress", "")
	Endif

	GUICtrlSetData($Combo_LoginServerAddress, $sOption_LoginServerAddress, $sOption_LoginServerAddress)
	AddNewLoginServerAddress()

	$sOption_LoginServerAddresses = IniRead($sIniFilename, "General", "LoginServerAddresses", "")
	$nOption_AutoConnect = IniRead($sIniFilename, "General", "AutoConnect", 0)
	$nOption_AutoEnterChannel = IniRead($sIniFilename, "General", "AutoEnterChannel", 0)
	$nOption_AutoCreateRoom = IniRead($sIniFilename, "General", "AutoCreateRoom", 0)
	$sOption_RoomMapInfo = IniRead($sIniFilename, "General", "RoomMapInfo", 0)
	$nOption_RoomKillLimit = IniRead($sIniFilename, "General", "RoomKillLimit", 0)
	$nOption_RoomRoundLimit = IniRead($sIniFilename, "General", "RoomRoundLimit", 0)
	$nOption_RoomTimeLimit = IniRead($sIniFilename, "General", "RoomTimeLimit", 0)
	$sOption_DefaultRoomTitle = IniRead($sIniFilename, "General", "DefaultRoomTitle", "")
	$sOption_ConnectType = IniRead($sIniFilename, "General", "ConnectType", "")
	$sOption_DefaultLevel = IniRead($sIniFilename, "General", "DefaultLevel", "")
	$sOption_RemoteHostAddress = IniRead($sIniFilename, "General", "RemoteHostAddress", "")
	$sOption_AdditionalParam = IniRead($sIniFilename, "General", "AdditionalParam", "")
	For $i = 0 To $nMaxProcessNumber - 1
		$aOption_InitialAccount[$i] = IniRead($sIniFilename, "Process" & $i + 1, "InitialAccount", "")
		$aOption_Resolution[$i] = IniRead($sIniFilename, "Process" & $i + 1, "Resolution", "")
		$aOption_IsAdult[$i] = IniRead($sIniFilename, "Process" & $i + 1, "IsAdult", 0)
		$aOption_RemoteControl[$i] = IniRead($sIniFilename, "Process" & $i + 1, "RemoteControl", 0)
	Next

	; 기본값 설정
	If $sOption_BuildType == "" Then
		$sOption_BuildType = "Release"
	EndIf
	If $sOption_MainWindowLocation == "" Then
		$sOption_MainWindowLocation = $sDefaultLocation_Primary
	EndIf
	If $sOption_MainWindowAlignType == "" Then
		$sOption_MainWindowAlignType = $sDefaultAlignType_None
	EndIf
	If $sOption_LogWindowLocation == "" Then
		$sOption_LogWindowLocation = $sDefaultLocation_None
	EndIf
	If $sOption_LogWindowAlignType == "" Then
		$sOption_LogWindowAlignType = $sDefaultAlignType_None
	EndIf
	If $sOption_PlatformType == "" Then
		$sOption_PlatformType = "Win32"
	EndIf
	If $sOption_LaunchType == "" Then
		$sOption_LaunchType = "OnlineClient"
	EndIf
	If $sOption_ConnectType == "" Then
		$sOption_ConnectType = "HostClient"
	EndIf
EndFunc

Func ReadUnrealEngineLevel($sPathname)
	; 언리얼 엔진의 사용 가능한 레벨 정보 읽어오기
	$hSearch = FileFindFirstFile($sPathname & "\*.*")
	If $hSearch <> -1 Then
		While 1
			$sFilename = FileFindNextFile($hSearch)
			If @error = 1 Then
				ExitLoop
			EndIf

			$sAttrib = FileGetAttrib($sPathname & "\" & $sFilename)
			If StringInStr($sAttrib, "H") == 0 Then
				If StringInStr($sAttrib, "D") <> 0 Then
					ReadUnrealEngineLevel($sPathname & "\" & $sFilename)
				ElseIf StringRight($sFilename, 5) == ".umap" Then
					;MsgBox(0, "file", $sFilename)
					GUICtrlSetData($Combo_DefaultLevel, $sFilename)
				ElseIf StringRight($sFilename, 5) == ".hmap" Then
					;MsgBox(0, "file", $sFilename)
					GUICtrlSetData($Combo_DefaultLevel, $sFilename)
				EndIf
			EndIf
		WEnd

		FileClose($hSearch)
	EndIf
EndFunc

Func ReadDataSheetInfo($sPathname)
	; 생성 가능한 방 정보 읽어오기
	$hFileMapInfo = FileOpen($sPathname & "\MapInfo.xml", 0)
	If $hFileMapInfo <> -1 Then
		While 1
			$sLine = FileReadLine($hFileMapInfo)
			If @error <> 0 Then
				ExitLoop
			EndIf
			$nMapID = 0
			$nMissionID = 0
			$nMapName = ""
			$aWordElement = StringSplit($sLine, "= ")
			$sMapInfoLine = ""
			For $i = 1 To $aWordElement[0] - 1
				If $aWordElement[$i] == "ID" Then
					$nMapID = Number(StringReplace($aWordElement[$i + 1], """", ""))
				EndIf
				If $aWordElement[$i] == "Name" Then
					$nMapName = StringReplace($aWordElement[$i + 1], """", "")
				EndIf
				If $aWordElement[$i] == "MissionID" Then
					$nMissionID = Number(StringReplace($aWordElement[$i + 1], """", ""))
				EndIf
			Next
			If $nMapID <> 0 And $nMissionID <> 0 And $nMapName <> "" Then
				$sMapInfoLine = $nMapID & " (Mission ID:" & $nMissionID & ") " & $nMapName
				;MsgBox(0, "", $sMapInfoLine)
				GUICtrlSetData($Combo_RoomMapInfo, $sMapInfoLine)
			EndIf
		WEnd
		FileClose($hFileMapInfo)
	EndIf
EndFunc

Func ApplyOptionsToControls()
	GUICtrlSetData($Input_TotalProcess, $nTotalProcess)
	If $sOption_BuildType == "Debug" Then
		GUICtrlSetState($Radio_DebugBuild, $GUI_CHECKED)
	EndIf
	If $sOption_BuildType == "Release" Then
		GUICtrlSetState($Radio_ReleaseBuild, $GUI_CHECKED)
	EndIf
	If $sOption_BuildType == "Internal" Then
		GUICtrlSetState($Radio_InternalBuild, $GUI_CHECKED)
	EndIf
	If $nOption_SoundEnabled <> 0 Then
		GUICtrlSetState($CheckBox_SoundEnabled, $GUI_CHECKED)
	EndIf
	If $nOption_FullScreen <> 0 Then
		GUICtrlSetState($CheckBox_FullScreen, $GUI_CHECKED)
	EndIf
	If $nOption_IntroMovieEnabled <> 0 Then
		GUICtrlSetState($CheckBox_IntroMovieEnabled, $GUI_CHECKED)
	EndIf
	If $nOption_SeekFreePackageMap <> 0 Then
		GUICtrlSetState($CheckBox_SeekFreePackageMap, $GUI_CHECKED)
	EndIf
	GUICtrlSetData($Combo_MainWindowLocation, $sOption_MainWindowLocation)
	GUICtrlSetData($Combo_MainWindowAlignType, $sOption_MainWindowAlignType)
	GUICtrlSetData($Combo_LogWindowLocation, $sOption_LogWindowLocation)
	GUICtrlSetData($Combo_LogWindowAlignType, $sOption_LogWindowAlignType)
	If $sOption_PlatformType == "Win32" Then
		GUICtrlSetState($Radio_PlatformWin32, $GUI_CHECKED)
	EndIf
	If $sOption_PlatformType == "Win64" Then
		GUICtrlSetState($Radio_PlatformWin64, $GUI_CHECKED)
	EndIf
	If $sOption_LaunchType == "OnlineClient" Then
		GUICtrlSetState($TabItem_OnlineClient, $GUI_SHOW)
	EndIf
	If $sOption_LaunchType == "DirectClient" Then
		GUICtrlSetState($TabItem_DirectClient, $GUI_SHOW)
	EndIf
	If $sOption_LoginServerAddresses <> "" Then
		$sAddresses = StringSplit($sOption_LoginServerAddresses, "|")
		For $i = 1 To $sAddresses[0]
			GUICtrlSetData($Combo_LoginServerAddress, $sAddresses[$i])
		Next
	EndIf
	If $sOption_LoginServerAddress <> "" Then
		GUICtrlSetData($Combo_LoginServerAddress, $sOption_LoginServerAddress)
	EndIf
	If $nOption_AutoConnect <> 0 Then
		GUICtrlSetState($CheckBox_AutoConnect, $GUI_CHECKED)
	EndIf
	If $nOption_AutoEnterChannel <> 0 Then
		GUICtrlSetState($CheckBox_AutoEnterChannel, $GUI_CHECKED)
	EndIf
	If $nOption_AutoCreateRoom <> 0 Then
		GUICtrlSetState($CheckBox_AutoCreateRoom, $GUI_CHECKED)
	Else
		GUICtrlSetState($Label_RoomMapInfo, $GUI_DISABLE)
		GUICtrlSetState($Combo_RoomMapInfo, $GUI_DISABLE)
		GUICtrlSetState($Label_RoomKillLimit, $GUI_DISABLE)
		GUICtrlSetState($Combo_RoomKillLimit, $GUI_DISABLE)
		GUICtrlSetState($Label_RoomRoundLimit, $GUI_DISABLE)
		GUICtrlSetState($Combo_RoomRoundLimit, $GUI_DISABLE)
		GUICtrlSetState($Label_RoomTimeLimit, $GUI_DISABLE)
		GUICtrlSetState($Combo_RoomTimeLimit, $GUI_DISABLE)
	EndIf
	If $sOption_RoomMapInfo <> "" Then
		GUICtrlSetData($Combo_RoomMapInfo, $sOption_RoomMapInfo)
	EndIf
	If $nOption_RoomKillLimit <> "" Then
		GUICtrlSetData($Combo_RoomKillLimit, $nOption_RoomKillLimit)
		GUICtrlSetData($Combo_RoomKillLimit, $nOption_RoomKillLimit)
	EndIf
	If $nOption_RoomRoundLimit <> "" Then
		GUICtrlSetData($Combo_RoomRoundLimit, $nOption_RoomRoundLimit)
		GUICtrlSetData($Combo_RoomRoundLimit, $nOption_RoomRoundLimit)
	EndIf
	If $nOption_RoomTimeLimit <> "" Then
		GUICtrlSetData($Combo_RoomTimeLimit, $nOption_RoomTimeLimit)
		GUICtrlSetData($Combo_RoomTimeLimit, $nOption_RoomTimeLimit)
	EndIf
	If $sOption_DefaultRoomTitle <> "" Then
		GUICtrlSetData($Input_DefaultRoomTitle, $sOption_DefaultRoomTitle)
	EndIf
	If $sOption_ConnectType == "HostClient" Then
		GUICtrlSetState($Radio_ConnectTypeHostClient, $GUI_CHECKED)
		GUICtrlSetState($Label_DefaultLevel, $GUI_ENABLE)
		GUICtrlSetState($Combo_DefaultLevel, $GUI_ENABLE)
		GUICtrlSetState($Label_RemoteHostAddress, $GUI_DISABLE)
		GUICtrlSetState($Input_RemoteHostAddress, $GUI_DISABLE)
	EndIf
	If $sOption_ConnectType == "RemoteClient" Then
		GUICtrlSetState($Radio_ConnectTypeRemoteClient, $GUI_CHECKED)
		GUICtrlSetState($Label_DefaultLevel, $GUI_DISABLE)
		GUICtrlSetState($Combo_DefaultLevel, $GUI_DISABLE)
		GUICtrlSetState($Label_RemoteHostAddress, $GUI_ENABLE)
		GUICtrlSetState($Input_RemoteHostAddress, $GUI_ENABLE)
	EndIf
	If $sOption_ConnectType == "StandAlone" Then
		GUICtrlSetState($Radio_ConnectTypeStandAlone, $GUI_CHECKED)
		GUICtrlSetState($Label_DefaultLevel, $GUI_ENABLE)
		GUICtrlSetState($Combo_DefaultLevel, $GUI_ENABLE)
		GUICtrlSetState($Label_RemoteHostAddress, $GUI_DISABLE)
		GUICtrlSetState($Input_RemoteHostAddress, $GUI_DISABLE)
	EndIf
	If $sOption_DefaultLevel <> "" Then
		GUICtrlSetData($Combo_DefaultLevel, $sOption_DefaultLevel)
	EndIf
	If $sOption_RemoteHostAddress <> "" Then
		GUICtrlSetData($Input_RemoteHostAddress, $sOption_RemoteHostAddress)
	EndIf
	If $sOption_AdditionalParam <> "" Then
		GUICtrlSetData($Input_AdditionalParam, $sOption_AdditionalParam)
	EndIf
	For $i = 0 To $nMaxProcessNumber - 1
		If $aOption_InitialAccount[$i] <> "" Then
			GUICtrlSetData($aInput_InitialAccount[$i], $aOption_InitialAccount[$i])
		EndIf
		If $aOption_Resolution[$i] <> "" Then
			GUICtrlSetData($aCombo_Resolution[$i], $aOption_Resolution[$i])
		EndIf
		if $aOption_IsAdult[$i] <> 0 Then
			GUICtrlSetState($aCheckBox_IsAdult[$i], $GUI_CHECKED)
		EndIf		
		If $aOption_RemoteControl[$i] <> 0 Then
			GUICtrlSetState($aCheckBox_RemoteControl[$i], $GUI_CHECKED)
		EndIf
	Next

	If $nOption_DeveloperVersion <> 1 Then
		GUICtrlDelete($Label_LogWindowLocation)
		GUICtrlDelete($Combo_LogWindowLocation)

		GUICtrlDelete($TabItem_DirectClient)

		GUICtrlDelete($CheckBox_AutoConnect)
		GUICtrlDelete($CheckBox_AutoEnterChannel)
		GUICtrlDelete($CheckBox_AutoCreateRoom)
		GUICtrlDelete($Label_RoomMapInfo)
		GUICtrlDelete($Combo_RoomMapInfo)
		GUICtrlDelete($Label_RoomKillLimit)
		GUICtrlDelete($Combo_RoomKillLimit)
		GUICtrlDelete($Label_RoomRoundLimit)
		GUICtrlDelete($Combo_RoomRoundLimit)
		GUICtrlDelete($Label_RoomTimeLimit)
		GUICtrlDelete($Combo_RoomTimeLimit)
		GUICtrlDelete($Label_DefaultRoomTitle)
		GUICtrlDelete($Input_DefaultRoomTitle)

		;GUICtrlDelete($Label_AdditionalParam)
		;GUICtrlDelete($Input_AdditionalParam)
	EndIf
EndFunc

Func ApplyControlsToOptions()
	$nTotalProcess = GUICtrlRead($Input_TotalProcess)
	If GUICtrlRead($Radio_DebugBuild) == $GUI_CHECKED Then
		$sOption_BuildType = "Debug"
	EndIf
	If GUICtrlRead($Radio_ReleaseBuild) == $GUI_CHECKED Then
		$sOption_BuildType = "Release"
	EndIf
	If GUICtrlRead($Radio_InternalBuild) == $GUI_CHECKED Then
		$sOption_BuildType = "Internal"
	EndIf
	If GUICtrlRead($CheckBox_SoundEnabled) == $GUI_CHECKED Then
		$nOption_SoundEnabled = 1
	Else
		$nOption_SoundEnabled = 0
	EndIf
	If GUICtrlRead($CheckBox_FullScreen) == $GUI_CHECKED Then
		$nOption_FullScreen = 1
	Else
		$nOption_FullScreen = 0
	EndIf
	If GUICtrlRead($CheckBox_IntroMovieEnabled) == $GUI_CHECKED Then
		$nOption_IntroMovieEnabled = 1
	Else
		$nOption_IntroMovieEnabled = 0
	EndIf
	If GUICtrlRead($CheckBox_SeekFreePackageMap) == $GUI_CHECKED Then
		$nOption_SeekFreePackageMap = 1
	Else
		$nOption_SeekFreePackageMap = 0
	EndIf
	$sOption_MainWindowLocation = GUICtrlRead($Combo_MainWindowLocation)
	$sOption_MainWindowAlignType = GUICtrlRead($Combo_MainWindowAlignType)
	$sOption_LogWindowLocation = GUICtrlRead($Combo_LogWindowLocation)
	$sOption_LogWindowAlignType = GUICtrlRead($Combo_LogWindowAlignType)
	If $sOption_LogWindowLocation == "0" Then
		$sOption_LogWindowLocation = ""
	EndIf
	If GUICtrlRead($Radio_PlatformWin32) == $GUI_CHECKED Then
		$sOption_PlatformType = "Win32"
	EndIf
	If GUICtrlRead($Radio_PlatformWin64) == $GUI_CHECKED Then
		$sOption_PlatformType = "Win64"
	EndIf
	If GUICtrlRead($Tab_Options, 1) == $TabItem_OnlineClient Then
		$sOption_LaunchType = "OnlineClient"
	EndIf
	If GUICtrlRead($Tab_Options, 1) == $TabItem_DirectClient Then
		$sOption_LaunchType = "DirectClient"
	EndIf
	$sOption_LoginServerAddress = GUICtrlRead($Combo_LoginServerAddress)
	AddNewLoginServerAddress()
	If GUICtrlRead($CheckBox_AutoConnect) == $GUI_CHECKED Then
		$nOption_AutoConnect = 1
	Else
		$nOption_AutoConnect = 0
	EndIf
	If GUICtrlRead($CheckBox_AutoEnterChannel) == $GUI_CHECKED Then
		$nOption_AutoEnterChannel = 1
	Else
		$nOption_AutoEnterChannel = 0
	EndIf
	If GUICtrlRead($CheckBox_AutoCreateRoom) == $GUI_CHECKED Then
		$nOption_AutoCreateRoom = 1
	Else
		$nOption_AutoCreateRoom = 0
	EndIf
	$sOption_RoomMapInfo = GUICtrlRead($Combo_RoomMapInfo)
	If $sOption_RoomMapInfo == "0" Then
		$sOption_RoomMapInfo = ""
	EndIf
	$nOption_RoomKillLimit = GUICtrlRead($Combo_RoomKillLimit)
	If $nOption_RoomKillLimit == "0" Then
		$nOption_RoomKillLimit = ""
	EndIf
	$nOption_RoomRoundLimit = GUICtrlRead($Combo_RoomRoundLimit)
	If $nOption_RoomRoundLimit == "0" Then
		$nOption_RoomRoundLimit = ""
	EndIf
	$nOption_RoomTimeLimit = GUICtrlRead($Combo_RoomTimeLimit)
	If $nOption_RoomTimeLimit == "0" Then
		$nOption_RoomTimeLimit = ""
	EndIf
	$sOption_DefaultRoomTitle = GUICtrlRead($Input_DefaultRoomTitle)
	If $sOption_DefaultRoomTitle == "0" Then
		$sOption_DefaultRoomTitle = ""
	EndIf
	If GUICtrlRead($Radio_ConnectTypeHostClient) == $GUI_CHECKED Then
		$sOption_ConnectType = "HostClient"
	EndIf
	If GUICtrlRead($Radio_ConnectTypeRemoteClient) == $GUI_CHECKED Then
		$sOption_ConnectType = "RemoteClient"
	EndIf
	If GUICtrlRead($Radio_ConnectTypeStandAlone) == $GUI_CHECKED Then
		$sOption_ConnectType = "StandAlone"
	EndIf
	$sOption_DefaultLevel = GUICtrlRead($Combo_DefaultLevel)
	If $sOption_DefaultLevel == "0" Then
		$sOption_DefaultLevel = ""
	EndIf
	$sOption_RemoteHostAddress = GUICtrlRead($Input_RemoteHostAddress)
	If $sOption_RemoteHostAddress == "0" Then
		$sOption_RemoteHostAddress = ""
	EndIf
	$sOption_AdditionalParam = GUICtrlRead($Input_AdditionalParam)
	If $sOption_AdditionalParam == "0" Then
		$sOption_AdditionalParam = ""
	EndIf
	For $i = 0 To $nMaxProcessNumber - 1
		$aOption_InitialAccount[$i] = GUICtrlRead($aInput_InitialAccount[$i])
		$aOption_Resolution[$i] = GUICtrlRead($aCombo_Resolution[$i])
		If $aOption_Resolution[$i] == "기본값" Then
			$aOption_Resolution[$i] = ""
		EndIf
		If GUICtrlRead($aCheckBox_IsAdult[$i]) == $GUI_CHECKED Then
			$aOption_IsAdult[$i] = 1
		Else
			$aOption_IsAdult[$i] = 0
		EndIf		
		If GUICtrlRead($aCheckBox_RemoteControl[$i]) == $GUI_CHECKED Then
			$aOption_RemoteControl[$i] = 1
		Else
			$aOption_RemoteControl[$i] = 0
		EndIf
	Next
EndFunc

Func WriteToIni()
	IniWrite($sIniFilename, "General", "TotalProcess", $nTotalProcess)
	IniWrite($sIniFilename, "General", "BuildType", $sOption_BuildType)
	IniWrite($sIniFilename, "General", "SoundEnabled", $nOption_SoundEnabled)
	IniWrite($sIniFilename, "General", "FullScreen", $nOption_FullScreen)
	IniWrite($sIniFilename, "General", "IntroMovieEnabled", $nOption_IntroMovieEnabled)
	IniWrite($sIniFilename, "General", "SeekFreePackageMap", $nOption_SeekFreePackageMap)
	IniWrite($sIniFilename, "General", "MainWindowLocation", $sOption_MainWindowLocation)
	IniWrite($sIniFilename, "General", "MainWindowAlignType", $sOption_MainWindowAlignType)
	IniWrite($sIniFilename, "General", "LogWindowLocation", $sOption_LogWindowLocation)
	IniWrite($sIniFilename, "General", "LogWindowAlignType", $sOption_LogWindowAlignType)
	IniWrite($sIniFilename, "General", "PlatformType", $sOption_PlatformType)
	IniWrite($sIniFilename, "General", "LaunchType", $sOption_LaunchType)
	IniWrite($sIniFilename, "General", "LoginServerAddress", $sOption_LoginServerAddress)
	IniWrite($sIniFilename, "General", "LoginServerAddresses", $sOption_LoginServerAddresses)
	IniWrite($sIniFilename, "General", "AutoConnect", $nOption_AutoConnect)
	IniWrite($sIniFilename, "General", "AutoEnterChannel", $nOption_AutoEnterChannel)
	IniWrite($sIniFilename, "General", "AutoCreateRoom", $nOption_AutoCreateRoom)
	IniWrite($sIniFilename, "General", "RoomMapInfo", $sOption_RoomMapInfo)
	IniWrite($sIniFilename, "General", "RoomKillLimit", $nOption_RoomKillLimit)
	IniWrite($sIniFilename, "General", "RoomRoundLimit", $nOption_RoomRoundLimit)
	IniWrite($sIniFilename, "General", "RoomTimeLimit", $nOption_RoomTimeLimit)
	IniWrite($sIniFilename, "General", "DefaultRoomTitle", $sOption_DefaultRoomTitle)
	IniWrite($sIniFilename, "General", "ConnectType", $sOption_ConnectType)
	IniWrite($sIniFilename, "General", "DefaultLevel", $sOption_DefaultLevel)
	IniWrite($sIniFilename, "General", "RemoteHostAddress", $sOption_RemoteHostAddress)
	IniWrite($sIniFilename, "General", "AdditionalParam", $sOption_AdditionalParam)
	For $i = 0 To $nMaxProcessNumber - 1
		IniWrite($sIniFilename, "Process" & $i + 1, "InitialAccount", $aOption_InitialAccount[$i])
		IniWrite($sIniFilename, "Process" & $i + 1, "Resolution", $aOption_Resolution[$i])
		IniWrite($sIniFilename, "Process" & $i + 1, "IsAdult", $aOption_IsAdult[$i])
		IniWrite($sIniFilename, "Process" & $i + 1, "RemoteControl", $aOption_RemoteControl[$i])
	Next
EndFunc

Func AddNewLoginServerAddress()
	$sCurrentEntry = GUICtrlRead($Combo_LoginServerAddress)
	$sAddresses = StringSplit($sOption_LoginServerAddresses, "|")
	For $i = 1 To $sAddresses[0]
		If $sAddresses[$i] == $sCurrentEntry Then
			; 이미 있는 주소와 중복되므로 추가하지 않는다.
			$sCurrentEntry = ""
			Return
		EndIf
	Next

	If GetValidIPAndPort($sCurrentEntry) <> "" Then
		GUICtrlSetData($Combo_LoginServerAddress, $sCurrentEntry)
		If $sOption_LoginServerAddresses <> "" Then
			$sOption_LoginServerAddresses = $sOption_LoginServerAddresses & "|"
		EndIf
		$sOption_LoginServerAddresses = $sOption_LoginServerAddresses & $sCurrentEntry
	Else
		$sOption_LoginServerAddress = ""
		$sInvalidFormat = "Alias (IP address: port)"
		GUICtrlSetData($Combo_LoginServerAddress, $sInvalidFormat, $sInvalidFormat)
	EndIf
EndFunc

Func GetValidIPAndPort($sAddress)
	$sReplaced = StringRegExpReplace($sAddress, "^.+\((\d+\.\d+\.\d+\.\d+\:\d+)\)$", "\1")

	If @error == 0 And @extended == 1 Then
		Return $sReplaced
	EndIf

	Return ""
EndFunc

Func LaunchAll()
	; 실행 파일 설정
	$sExecutable = ""
	If $sOption_PlatformType == "Win32" Then
		$sExecutable = @ScriptDir & "\Win32"
	EndIf
	If $sOption_PlatformType == "Win64" Then
		$sExecutable = @ScriptDir & "\Win64"
	EndIf

	If $sOption_BuildType == "Debug" Then
		$sExecutable = $sExecutable & "\DEBUG-HessianGame.exe"
	EndIf
	If $sOption_BuildType == "Release" Then
		$sExecutable = $sExecutable & "\HessianGame.exe"
	EndIf
	If $sOption_BuildType == "Internal" Then
		$sExecutable = $sExecutable & "\ShippingPC-HessianGame-Internal.exe"
	EndIf

	If FileExists($sExecutable) == 0 Then
		MsgBox(0, "Error", "실행 파일이 존재하지 않습니다." & @CRLF & $sExecutable);
		Return
	EndIf

	; 파라메터 설정
	$sParameters = ""

	If $sOption_LaunchType == "DirectClient" Then
		$sParameters = $sParameters & "-DEV_NO_LOBBY "
	EndIf

	If $nOption_AutoConnect == 1 Then
		$sParameters = $sParameters & "-AutoConnectChannelServer "
	EndIf

	If $nOption_AutoEnterChannel == 1 Then
		$sParameters = $sParameters & "-AutoEnterChannel "
	EndIf

	If $nOption_SoundEnabled == 0 Then
		$sParameters = $sParameters & "-nosound "
	EndIf

	If $nOption_FullScreen == 1 And $nTotalProcess == 1 Then
		$sParameters = $sParameters & "-fullscreen "
	Else
		$sParameters = $sParameters & "-windowed "
	EndIf

	If $nOption_IntroMovieEnabled == 0 Then
		$sParameters = $sParameters & "-nostartupmovies "
	EndIf

	If $nOption_SeekFreePackageMap == 1 Then
		$sParameters = $sParameters & "-SeekFreePackageMap "
	EndIf

	If $sOption_LogWindowLocation <> "" And $sOption_LogWindowLocation <> $sDefaultLocation_None Then
		$sParameters = $sParameters & "-log "
	EndIf

	If $sOption_DefaultRoomTitle <> "" Then
		$sParameters = $sParameters & "-DefaultRoomTitle=""" & $sOption_DefaultRoomTitle & """ "
	EndIf

	If $sOption_AdditionalParam <> "" Then
		$sParameters = $sParameters & $sOption_AdditionalParam & " "
	EndIf

	If $sOption_LoginServerAddress <> "" Then
		$aReplaced = StringSplit(GetValidIPAndPort($sOption_LoginServerAddress), ":")
		If $aReplaced[0] == 2 Then
			$sParameters = $sParameters & "-LoginServerIP=" & $aReplaced[1]& " -LoginServerPort=" & $aReplaced[2] & " "
			$sParameters = $sParameters & "-AutoChannelServerIP=" & $aReplaced[1]& " -AutoChannelServerPort=5555 "
		EndIf
	EndIf

	For $i = 0 To $nTotalProcess - 1
		$sPreParameter = ""

		If $nTotalProcess > 1 Then
			$fAllcationRatio = $i / ($nTotalProcess - 1)
		Else
			$fAllcationRatio = 0
		EndIf

		If $sOption_LaunchType == "OnlineClient" Then
			$sPreParameter = "-account=" & $aOption_InitialAccount[$i] & " "
			$sPreParameter = $sPreParameter & "-Key=" & $aOption_InitialAccount[$i] & "|aaaa|" & $aOption_IsAdult[$i] & "| "
		ElseIf $sOption_LaunchType == "DirectClient" Then
			; 캐릭터 이름과 소속 팀을 설정한다.
			$sParamNameTeam = "?name=" & @ComputerName & "_" & $i + 1 & "?team=" & Mod($i, 2)

			If $sOption_ConnectType == "HostClient" Then
				If $i == 0 Then
					$sPreParameter = $sOption_DefaultLevel & "?listen" & $sParamNameTeam & " "
				Else
					$sPreParameter = "127.0.0.1" & $sParamNameTeam & " "
				EndIf
			ElseIf $sOption_ConnectType == "RemoteClient" Then
				$sPreParameter = $sOption_RemoteHostAddress & $sParamNameTeam & " "
			ElseIf $sOption_ConnectType == "StandAlone" Then
				$sPreParameter = $sOption_DefaultLevel & $sParamNameTeam & " "
			EndIf
		Else
			ExitLoop
		EndIf

		$aSplitResolution = StringSplit($aOption_Resolution[$i], "x")
		If $aSplitResolution[0] == 2 Then
			$sPreParameter = $sPreParameter & "-ResX=" & $aSplitResolution[1] & " -ResY=" & $aSplitResolution[2] & " "
		EndIf
		
		If $nOption_DeveloperVersion == 1 And $aOption_RemoteControl[$i] == 1 Then
			$sPreParameter = $sPreParameter & "-RemoteControl "
		EndIf

		If $i == 0 And $nOption_AutoCreateRoom == 1 Then
			$nMissionID = 0
			$nMapID = 0
			; 미션 ID 는 ':' 과 ')' 기호 사이에 있는 것으로 간주한다.
			$nFindMissionIDStart = StringInStr($sOption_RoomMapInfo, ":")
			$nFindMissionIDEnd = StringInStr($sOption_RoomMapInfo, ")")
			If $nFindMissionIDStart > 0 And $nFindMissionIDStart < $nFindMissionIDEnd Then
				$nMissionID = Number(StringMid($sOption_RoomMapInfo, $nFindMissionIDStart + 1, $nFindMissionIDEnd - $nFindMissionIDStart - 1))
			EndIf
			If StringInStr($sOption_RoomMapInfo, " ") > 0 Then
				$nMapID = Number(StringLeft($sOption_RoomMapInfo, StringInStr($sOption_RoomMapInfo, " ")))
			EndIf
			$sPreParameter = $sPreParameter & "-AutoCreateRoom=""" & $nMissionID & "," & $nMapID & "," & $nOption_RoomKillLimit & "," & $nOption_RoomRoundLimit & "," & $nOption_RoomTimeLimit & ",16," & $sOption_DefaultRoomTitle & """ "
		EndIf

		LaunchProcess($sExecutable, $sPreParameter & $sParameters, $fAllcationRatio)
	Next
EndFunc

Func LaunchProcess($sExecutable, $sFullParameters, $fAllcationRatio)
	$sExecutableFull = $sExecutable & "  " & $sFullParameters

	;MsgBox(0, "", $sExecutableFull);
	$PID = Run($sExecutableFull)
	$hWindow = ""

	$sLogWindowTitle = $sExecutable
	$sMainWindowTitle = "HessianGame"

	If $PID > 0 Then
		If $sOption_LogWindowLocation <> $sDefaultLocation_None Then
			ReallocateWindow($PID, $sLogWindowTitle, $nWindowTypeLog, $fAllcationRatio, $sOption_LogWindowAlignType)
		EndIf

		ReallocateWindow($PID, $sMainWindowTitle, $nWindowTypeMain, $fAllcationRatio, $sOption_MainWindowAlignType)
	EndIf
EndFunc

Func ReallocateWindow($PID, $sWindowTitle, $nWindowType, $fAllcationRatio, $sAllocationType)
	While 1
		; 어떤 이유로든 프로세스가 중간에 종료되었다면 실행을 중단한다.
		If ProcessExists($PID) == 0 Then
			Exit
		EndIf

		; uc 스크립트 빌드
		If WinActive("Message", "Scripts are outdated.") == 1 Then
			;Send("!y")
			; 빌드 결과를 알 수 없으므로 실행을 종료한다.
			Exit
		EndIf

		$hWindow = FindWindow($PID, $sWindowTitle)
		If $hWindow <> "" Then
			$nWindowState = WinGetState($hWindow)
			If Not BitAND($nWindowState, 16) Then
				If Not BitAND($nWindowState, 8) Then
					WinActivate($hWindow)
				EndIf
				If $nOption_FullScreen == 0 Or $nWindowType == $nWindowTypeLog Then
					MoveWindowPosition($hWindow, $nWindowType, $fAllcationRatio, $sAllocationType)
				EndIf
				ExitLoop
			EndIf
		EndIf
		Sleep(1000)
	WEnd
EndFunc

Func FindWindow($PID, $sWindowTitle)
	$aWinList = WinList($sWindowTitle)
	For $i = 1 To $aWinList[0][0]
		$hWindow = $aWinList[$i][1]
		If $hWindow <> "" Then
			If WinGetProcess($hWindow) == $PID Then
				Return $hWindow
			EndIf
		EndIf
	Next

	return ""
EndFunc

Func MoveWindowPosition($hWindow, $nWindowType, $fAllcationRatio, $sAllocationType)
	$aWindowCurrentPosition = WinGetPos($hWindow)

	$fAllcationRatioX = $fAllcationRatio
	$fAllcationRatioY = $fAllcationRatio
	If $sAllocationType == $sDefaultAlignType_AlignTop Then
		$fAllcationRatioY = 0
	ElseIf $sAllocationType == $sDefaultAlignType_AlignBottom Then
		$fAllcationRatioY = 1
	ElseIf $sAllocationType == $sDefaultAlignType_AlignLeft Then
		$fAllcationRatioX = 0
	ElseIf $sAllocationType == $sDefaultAlignType_AlignRight Then
		$fAllcationRatioX = 1
	ElseIf $sAllocationType <> $sDefaultAlignType_Diagonal Then
		Return
	EndIf

	$nWindowPositionX = ($aDesktopRect[2] - $aWindowCurrentPosition[2]) * $fAllcationRatioX + $aDesktopRect[0]
	If $nWindowType == $nWindowTypeMain Then
		If $sOption_MainWindowLocation == $sDefaultLocation_PrimaryLeft Then
			$nWindowPositionX = $nWindowPositionX - @DesktopWidth
		ElseIf $sOption_MainWindowLocation == $sDefaultLocation_PrimaryRight Then
			$nWindowPositionX = $nWindowPositionX + @DesktopWidth
		EndIf
	ElseIf $nWindowType == $nWindowTypeLog Then
		If $sOption_LogWindowLocation == $sDefaultLocation_PrimaryLeft Then
			$nWindowPositionX = $nWindowPositionX - @DesktopWidth
		ElseIf $sOption_LogWindowLocation == $sDefaultLocation_PrimaryRight Then
			$nWindowPositionX = $nWindowPositionX + @DesktopWidth
		EndIf
	EndIf

	$nWindowPositionY = ($aDesktopRect[3] - $aWindowCurrentPosition[3]) * $fAllcationRatioY + $aDesktopRect[1]

	;MsgBox(0, "MOVE", $aWindowCurrentPosition[2] & " " & $aWindowCurrentPosition[3])
	WinMove($hWindow, "", $nWindowPositionX, $nWindowPositionY, $aWindowCurrentPosition[2], $aWindowCurrentPosition[3], 2)
	;WinMove($hWindow, "", $nWindowPositionX, $nWindowPositionY)
EndFunc
