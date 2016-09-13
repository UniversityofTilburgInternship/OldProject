using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PersonalityAnimation : MonoBehaviour
{
  private string AnimID;
  private List<int> personalities = new List<int>();

  public void addPersonality(int personality)
  {
    personalities.Add(personality);
  }

  public string getAnimID() { return AnimID; }
  public void setAnimID(string animID) { this.AnimID = animID; }

  public List<int> getPersonalities() { return personalities; }
  public void setPersonalities(List<int> personality) { this.personalities = personality; }

  public bool containsPersonality(int personalityName)
  {
    foreach (int i in personalities)
    {
      if (i == personalityName) return true;
    }
    return false;
  }

  // Use this for initialization
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }
}
                                                                                           