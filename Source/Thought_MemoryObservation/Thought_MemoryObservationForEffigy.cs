using RimWorld;

namespace EffigyMod
{
    // Token: 0x02000002 RID: 2
    public class Thought_MemoryObservationForEffigy : Thought_MemoryObservation
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public override bool TryMergeWithExistingMemory(out bool showBubble)
		{
			bool result;
			if (!pawn.IsColonist)
			{
				result = base.TryMergeWithExistingMemory(out showBubble);
			}
			else
			{
				showBubble = false;
				result = true;
			}
			return result;
		}
	}
}
