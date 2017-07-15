// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLAccountDaysTTL : TLObject 
	{
		public Int32 Days { get; set; }

		public TLAccountDaysTTL() { }
		public TLAccountDaysTTL(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AccountDaysTTL; } }

		public override void Read(TLBinaryReader from)
		{
			Days = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt32(Days);
		}
	}
}