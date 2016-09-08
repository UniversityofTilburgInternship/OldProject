using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Big5Personality 
{
    public int ExtraversionScale = 0;
    public int EgoismScale = 0;
    public int ThoroughnessScale = 0;
    public int EmotionalStabilityScale = 0;
    public int OpennessScale = 0;

    public void setList(List<int> values)
    {
        this.ExtraversionScale = values[0];
        this.EgoismScale = values[1];
        this.ThoroughnessScale = values[2];
        this.EmotionalStabilityScale = values[3];
        this.OpennessScale = values[4];
    }
    public Big5Personality() { }

    public ArrayList toArrayList()
    {
        return new ArrayList() { this.ExtraversionScale, this.EgoismScale, this.ThoroughnessScale, this.EmotionalStabilityScale, this.OpennessScale };
    }
    public List<int> toList()
    {
        return new List<int>() { this.ExtraversionScale, this.EgoismScale, this.ThoroughnessScale, this.EmotionalStabilityScale, this.OpennessScale };
    }
}
                                                                                                                