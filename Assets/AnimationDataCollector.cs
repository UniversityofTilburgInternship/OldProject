using UnityEngine;
using System.Collections;
using System.Xml;
using System.Text.RegularExpressions;
using System.Collections.Generic;

public class AnimationDataCollector : MonoBehaviour
{
  private static string pathToSettings;
  private static List<PersonalityAnimation> listanimations = new List<PersonalityAnimation>();
  public static List<PersonalityAnimation> getAnimations()
  {
    readlist();
    return listanimations;
  }
  // Use this for initialization
  private static void readlist()
  {
    pathToSettings = Application.dataPath + "\\Resources\\settings.xml";
    XmlDocument settings = loadXMLSettings(pathToSettings);
    XmlNode animations = settings.SelectSingleNode("settings/animations");
    foreach (XmlNode animation in animations)
    {
      PersonalityAnimation newPersonalityAnimation = new PersonalityAnimation();
      newPersonalityAnimation.setAnimID(stripSpecialCharacters(animation["name"].InnerText));
      foreach (XmlNode personality in animation["personalities"])
      {
        newPersonalityAnimation.addPersonality(int.Parse(stripSpecialCharacters(personality.InnerText)));
      }
      listanimations.Add(newPersonalityAnimation);
    }
  }

  static string stripSpecialCharacters(string text)
  {
    return Regex.Replace(text, @"\s+", "");
  }

  static XmlDocument loadXMLSettings(string path)
  {
    XmlDocument doc = new XmlDocument();
    doc.Load(path);

    return doc;
  }
  // Update is called once per frame
  void Update()
  {

  }
}

                                                                                                    