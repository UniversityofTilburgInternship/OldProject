using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PersonalityAnimation : MonoBehaviour
{
  private string AnimID;
  private List<string> personalities = new List<string>();

  public void addPersonality(string personality)
  {
    personalities.Add(personality);
  }

  public string getAnimID() { return AnimID; }
  public void setAnimID(string animID) { this.AnimID = animID; }

  public List<string> getPersonalities() { return personalities; }
  public void setPersonalities(List<string> personality) { this.personalities = personality; }

  public bool containsPersonality(string personalityName)
  {
    return this.personalities.Contains(personalityName);
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
                        