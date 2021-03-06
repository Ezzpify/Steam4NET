// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	[InterfaceVersion("CLIENTCONTENTSERVER_INTERFACE_VERSION001")]
	public interface IClientContentServer
	{
		[VTableSlot(0)]
		Int32 GetHSteamUser();
		[VTableSlot(1)]
		CSteamID GetSteamID();
		[VTableSlot(2)]
		void LogOn(UInt32 uContentServerID);
		[VTableSlot(3)]
		void LogOff();
		[VTableSlot(4)]
		bool BLoggedOn();
		[VTableSlot(5)]
		ELogonState GetLogonState();
		[VTableSlot(6)]
		bool BConnected();
		[VTableSlot(7)]
		Int32 RaiseConnectionPriority(EConnectionPriority eConnectionPriority);
		[VTableSlot(8)]
		void ResetConnectionPriority(Int32 hRaiseConnectionPriorityPrev);
		[VTableSlot(9)]
		void SetCellID(UInt32 cellID);
		[VTableSlot(10)]
		bool SendClientContentAuthRequest(CSteamID steamID, UInt32 unContentID, bool bUseToken, UInt64 ulSessionToken, bool bTokenPresent);
		[VTableSlot(11)]
		bool BCheckTicket(CSteamID steamID, UInt32 uContentID, Byte[] pvTicketData, UInt32 cubTicketLength);
	};
}
