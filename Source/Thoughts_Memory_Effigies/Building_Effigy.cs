using RimWorld;

namespace EffigyMod
{
    // Token: 0x02000002 RID: 2
    public class Building_Effigy : Building_Art, IThoughtGiver
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Thought_Memory GiveObservedThought()
		{
			var def = ThoughtDef.Named("Thought_Effigy");
			var thought_MemoryObservation = ThoughtMaker.MakeThought(def) as Thought_MemoryObservation;
			thought_MemoryObservation.Target = this;
			return thought_MemoryObservation;
		}
	}
}
