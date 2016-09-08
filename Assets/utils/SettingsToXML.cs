using UnityEngine;
using System.Collections;
using System.Xml;
using System.Text.RegularExpressions;

public class SettingsToXML : MonoBehaviour
{
  [Header("Use default (stored) values")]
  public bool defaultValue = true;

  [Header("Extraversion - Introversion")]
  [Range(-100, 100)]
  public int Extraversion;

  [Header("Egoism - Altruism")]
  [Range(-100, 100)]
  public int Egoism;

  [Header("Thouroughness - Chaoticness")]
  [Range(-100, 100)]
  public int Thorougness;

  [Header("Emotional stability - Neuroticism")]
  [Range(-100, 100)]
  public int EmotionalStability;

  private string pathToSettings;

  // Use this for initialization
  void Start()
  {
    pathToSettings = Application.dataPath + "\\Resources\\settings.xml";

    XmlDocument settings = LoadXMLSettings(pathToSettings);
    if (defaultValue)
    {

      XmlNode personalities = settings.SelectSingleNode("settings/personalities");
      foreach (XmlNode personality in personalities)
      {
        if (stripSpecialCharacters(personality["name"].InnerText).Equals("Extraversion"))
          Extraversion = int.Parse(personality.SelectSingleNode("value").InnerText);

        else if (stripSpecialCharacters(personality["name"].InnerText).Equals("Egoism"))
          Egoism = int.Parse(personality.SelectSingleNode("value").InnerText);

        else if (stripSpecialCharacters(personality["name"].InnerText).Equals("Thoroughness"))
          Thorougness = int.Parse(personality.SelectSingleNode("value").InnerText);

        else if (stripSpecialCharacters(personality["name"].InnerText).Equals("EmotionalStability"))
          EmotionalStability = int.Parse(personality.SelectSingleNode("value").InnerText);
      }
    }
    else
    {

      XmlNode personalities = settings.SelectSingleNode("settings/personalities");
      foreach (XmlNode personality in personalities)
      {
        if (stripSpecialCharacters(personality["name"].InnerText).Equals("Extraversion"))
          personality.SelectSingleNode("value").InnerText = Extraversion.ToString();

        else if (stripSpecialCharacters(personality["name"].InnerText).Equals("Egoism"))
          personality.SelectSingleNode("value").InnerText = Egoism.ToString();

        else if (stripSpecialCharacters(personality["name"].InnerText).Equals("Thoroughness"))
          personality.SelectSingleNode("value").InnerText = Thorougness.ToString();

        else if (stripSpecialCharacters(personality["name"].InnerText).Equals("EmotionalStability"))
          personality.SelectSingleNode("value").InnerText = EmotionalStability.ToString();
      }

      //node.Attributes[0].Value = this.Egoism.ToString();

      settings.Save(pathToSettings);
    }
  }

  // Update is called once per frame
  void Update()
  {

  }

  string stripSpecialCharacters(string text)
  {
    return Regex.Replace(text, @"\s+", "");
  }

  XmlDocument LoadXMLSettings(string path)
  {
    XmlDocument doc = new XmlDocument();
    doc.Load(path);

    return doc;
  }
}
