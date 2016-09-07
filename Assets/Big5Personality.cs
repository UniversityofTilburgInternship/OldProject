using UnityEngine;
using System.Collections;

namespace PersonalityProject {

	public class Big5Personality : MonoBehaviour
	{
		public int ExtraversionScale;
		public int EgoismScale;
		public int ThoroughnessScale;
		public int EmotionalStabilityScale;
		public int OpennessScale;

		public ArrayList toList()
		{
            return new ArrayList() { this.ExtraversionScale, this.EgoismScale, this.ThoroughnessScale, this.EmotionalStabilityScale, this.OpennessScale };
		}
	}

}            