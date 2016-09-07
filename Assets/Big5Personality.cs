using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Big5Personality : MonoBehaviour
{
    public int ExtraversionScale;
    public int EgoismScale;
    public int ThoroughnessScale;
    public int EmotionalStabilityScale;
    public int OpennessScale;

    public Big5Personality()
    {
        this.ExtraversionScale = 0;
        this.EgoismScale = 0;
        this.ThoroughnessScale = 0;
        this.EmotionalStabilityScale = 0;
        this.OpennessScale = 0;
    }

    public ArrayList toArrayList()
    {
        return new ArrayList() { this.ExtraversionScale, this.EgoismScale, this.ThoroughnessScale, this.EmotionalStabilityScale, this.OpennessScale };
    }
    public List<int> toList()
    {
        return new List<int>() { this.ExtraversionScale, this.EgoismScale, this.ThoroughnessScale, this.EmotionalStabilityScale, this.OpennessScale };
    }
}

                                                   