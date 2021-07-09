using RimWorld;
using Verse;

namespace EffigyMod
{
    // Token: 0x02000002 RID: 2
    public class Building_Effigy : Building_Art, IObservedThoughtGiver
    {
        public Thought_Memory GiveObservedThought(Pawn observer)
        {
            var thoughtDef = ThoughtDef.Named("Thought_Effigy");
            if (ThoughtMaker.MakeThought(thoughtDef) is not Thought_MemoryObservation thought_MemoryObservation)
            {
                return null;
            }

            thought_MemoryObservation.Target = this;
            return thought_MemoryObservation;
        }

        public HistoryEventDef GiveObservedHistoryEvent(Pawn observer)
        {
            return null;
        }
    }
}