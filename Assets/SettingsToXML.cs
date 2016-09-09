using UnityEngine;
using System.Collections;
using System.Xml;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using Casanova.Prelude;

public class SettingsToXML : MonoBehaviour
{
  [Header("Use default (stored) values")]
  public bool defaultValue = true;

  [Header("Extraversion ")]
  [Range(0, 100)]
  public int Extraversion;

  [Header("Egoism ")]
  [Range(0, 100)]
  public int Egoism;

  [Header("Thouroughness ")]
  [Range(0, 100)]
  public int Thorougness;

  [Header("Emotional stability ")]
  [Range(0, 100)]
  public int EmotionalStability;

  public List<Tuple<string, int>> SettingsList;
  private string pathToSettings;

  // Use this for initialization
  void Start()
  {
    pathToSettings = Application.dataPath + "\\Resources\\settings.xml";

    XmlDocument settings = loadXMLSettings(pathToSettings);
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

    SettingsList = settingsToList();

  }

  // Update is called once per frame
  void Update()
  {

  }

  string stripSpecialCharacters(string text)
  {
    return Regex.Replace(text, @"\s+", "");
  }
  List<Tuple<string, int>> settingsToList()
  {
    List<Tuple<string, int>> listSettings = new List<Tuple<string, int>>();
    
    listSettings.Add(new Tuple<string, int>("Extraversion", Extraversion));
    listSettings.Add(new Tuple<string, int>("Egoism", Egoism));
    listSettings.Add(new Tuple<string, int>("Thoroughness", Thorougness));
    listSettings.Add(new Tuple<string, int>("EmotionalStability", EmotionalStability));

    return listSettings;
  }

  XmlDocument loadXMLSettings(string path)
  {
    XmlDocument doc = new XmlDocument();
    doc.Load(path);

    return doc;
  }


}
                                                               