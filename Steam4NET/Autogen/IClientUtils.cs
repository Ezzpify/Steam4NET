// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	[InterfaceVersion("CLIENTUTILS_INTERFACE_VERSION001")]
	public interface IClientUtils
	{
		[VTableSlot(0)]
		string GetInstallPath();
		[VTableSlot(1)]
		string GetUserBaseFolderInstallImage();
		[VTableSlot(2)]
		string GetManagedContentRoot();
		[VTableSlot(3)]
		UInt32 GetSecondsSinceAppActive();
		[VTableSlot(4)]
		UInt32 GetSecondsSinceComputerActive();
		[VTableSlot(5)]
		void SetComputerActive();
		[VTableSlot(6)]
		EUniverse GetConnectedUniverse();
		[VTableSlot(7)]
		UInt32 GetServerRealTime();
		[VTableSlot(8)]
		string GetIPCountry();
		[VTableSlot(9)]
		bool GetImageSize(Int32 iImage, ref UInt32 pnWidth, ref UInt32 pnHeight);
		[VTableSlot(10)]
		bool GetImageRGBA(Int32 iImage, Byte[] pubDest, Int32 nDestBufferSize);
		[VTableSlot(11)]
		bool GetCSERIPPort(ref UInt32 unIP, ref UInt16 usPort);
		[VTableSlot(12)]
		UInt32 GetNumRunningApps();
		[VTableSlot(13)]
		Byte GetCurrentBatteryPower();
		[VTableSlot(14)]
		void SetOfflineMode(bool bOffline);
		[VTableSlot(15)]
		bool GetOfflineMode();
		[VTableSlot(16)]
		UInt32 SetAppIDForCurrentPipe(UInt32 nAppID, bool bTrackProcess);
		[VTableSlot(17)]
		UInt32 GetAppID();
		[VTableSlot(18)]
		void SetAPIDebuggingActive(bool bActive, bool bVerbose);
		[VTableSlot(19)]
		bool IsAPICallCompleted(UInt64 hSteamAPICall, ref bool pbFailed);
		[VTableSlot(20)]
		ESteamAPICallFailure GetAPICallFailureReason(UInt64 hSteamAPICall);
		[VTableSlot(21)]
		bool GetAPICallResult(UInt64 hSteamAPICall, Byte[] pCallback, Int32 cubCallback, Int32 iCallbackExpected, ref bool pbFailed);
		[VTableSlot(22)]
		bool SignalAppsToShutDown();
		[VTableSlot(23)]
		UInt32 GetCellID();
		[VTableSlot(24)]
		bool BIsGlobalInstance();
		[VTableSlot(25)]
		UInt64 CheckFileSignature(string szFileName);
		[VTableSlot(26)]
		UInt64 GetBuildID();
		[VTableSlot(27)]
		void SetCurrentUIMode(EUIMode eUIMode);
		[VTableSlot(28)]
		bool ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eInputLineMode, string szText, UInt32 uMaxLength);
		[VTableSlot(29)]
		UInt32 GetEnteredGamepadTextLength();
		[VTableSlot(30)]
		bool GetEnteredGamepadTextInput(StringBuilder pchValue, UInt32 cchValueMax);
		[VTableSlot(31)]
		void GamepadTextInputClosed(Int32 hSteamPipe, bool arg1, string arg2);
		[VTableSlot(32)]
		void SetSpew(ESpewGroup eSpewGroup, Int32 iSpewLevel, Int32 iLogLevel);
		[VTableSlot(33)]
		bool BDownloadsDisabled();
		[VTableSlot(34)]
		void SetFocusedWindow(EWindowType eWindowType, UInt32 uUnk);
		[VTableSlot(35)]
		string GetSteamUILanguage();
	};
}