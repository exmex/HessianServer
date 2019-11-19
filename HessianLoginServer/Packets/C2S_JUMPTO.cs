using System;

namespace HessianLoginServer.Packets
{
    public class S2C_JUMPTO
    {
	    [Packet(CommonProtocolType._S2C_JUMPTO)]
	    public static void OnS2C_JUMPTO(Packet packet)
	    {
		    var targetPlayerUid = packet.Reader.ReadUInt32();
		    var ack = new Packet(CommonProtocolType._S2C_JUMPTO);
		    ack.Writer.Write((byte)1);
		    ack.Writer.Write(targetPlayerUid);
		    packet.SendBack(ack);
		    /*
	
	PROTOCOL_DECLARE(C2S_JUMPTO, _C2S_JUMPTO)
	{
	public:
		UINT32	nTargetPlayerUID;
	};
	
	
	PROTOCOL_DECLARE(S2C_JUMPTO, _S2C_JUMPTO)
	{
	public:
		UINT8	nChannelServerID;
		UINT32	nTargetPlayerUID;
	};
	
		     */
	    }
    }
}