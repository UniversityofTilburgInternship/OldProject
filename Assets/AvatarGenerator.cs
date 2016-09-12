using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Casanova.Prelude;
using System.Xml;
using System.Text.RegularExpressions;

public class AvatarGenerator : MonoBehaviour
{
  [Header("Amount of characters")]
  [Range(1, 100)]
  public int Amount;

  [Header("Use default (stored) values")]
  public bool defaultValue = true;

  [Header("Extraversion ")]
  [Range(0, 100)]
  public int minExtraversion;
  [Range(0, 100)]
  public int maxExtraversion;

  [Header("Egoism ")]
  [Range(0, 100)]
  public int minEgoism;
  [Range(0, 100)]
  public int maxEgoism;

  [Header("Thouroughness ")]
  [Range(0, 100)]
  public int minThorougness;
  [Range(0, 100)]
  public int maxThorougness;

  [Header("Emotional stability ")]
  [Range(0, 100)]
  public int minEmotionalStability;
  [Range(0, 100)]
  public int maxEmotionalStability;

  public List<Tuple<string, Tuple<int, int>>> SettingsList;
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
        {
          minExtraversion = int.Parse(personality.SelectSingleNode("minvalue").InnerText);
          maxExtraversion = int.Parse(personality.SelectSingleNode("maxvalue").InnerText);
        }

        else if (stripSpecialCharacters(personality["name"].InnerText).Equals("Egoism"))
        {
          maxEgoism = int.Parse(personality.SelectSingleNode("maxvalue").InnerText);
          minEgoism = int.Parse(personality.SelectSingleNode("minvalue").InnerText);
        }

        else if (stripSpecialCharacters(personality["name"].InnerText).Equals("Thoroughness"))
        {
          minThorougness = int.Parse(personality.SelectSingleNode("minvalue").InnerText);
          maxThorougness = int.Parse(personality.SelectSingleNode("maxvalue").InnerText);
        }

        else if (stripSpecialCharacters(personality["name"].InnerText).Equals("EmotionalStability"))
        {
          minEmotionalStability = int.Parse(personality.SelectSingleNode("minvalue").InnerText);
          maxEmotionalStability = int.Parse(personality.SelectSingleNode("maxvalue").InnerText);
        }
      }
    }
    else
    {

      XmlNode personalities = settings.SelectSingleNode("settings/personalities");
      foreach (XmlNode personality in personalities)
      {
        if (stripSpecialCharacters(personality["name"].InnerText).Equals("Extraversion"))
        {
          personality.SelectSingleNode("minvalue").InnerText = minExtraversion.ToString();
          personality.SelectSingleNode("maxvalue").InnerText = maxExtraversion.ToString();

        }

        else if (stripSpecialCharacters(personality["name"].InnerText).Equals("Egoism"))
        {
          personality.SelectSingleNode("minvalue").InnerText = minEgoism.ToString();
          personality.SelectSingleNode("maxvalue").InnerText = maxEgoism.ToString();
        }

        else if (stripSpecialCharacters(personality["name"].InnerText).Equals("Thoroughness"))
        {
          personality.SelectSingleNode("minvalue").InnerText = minThorougness.ToString();
          personality.SelectSingleNode("maxvalue").InnerText = maxThorougness.ToString();

        }

        else if (stripSpecialCharacters(personality["name"].InnerText).Equals("EmotionalStability"))
        {
          personality.SelectSingleNode("minvalue").InnerText = minEmotionalStability.ToString();
          personality.SelectSingleNode("maxvalue").InnerText = maxEmotionalStability.ToString();

        }
      }


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
  List<Tuple<string, Tuple<int, int>>> settingsToList()
  {
    List<Tuple<string, Tuple<int, int>>> listSettings = new List<Tuple<string, Tuple<int, int>>>();

    listSettings.Add(new Tuple<string, Tuple<int, int>>("Extraversion", new Tuple<int, int>(minExtraversion, maxExtraversion)));
    listSettings.Add(new Tuple<string, Tuple<int, int>>("Egoism", new Tuple<int, int>(minEgoism, maxEgoism)));
    listSettings.Add(new Tuple<string, Tuple<int, int>>("Thoroughness", new Tuple<int, int>(minThorougness, maxThorougness)));
    listSettings.Add(new Tuple<string, Tuple<int, int>>("EmotionalStability", new Tuple<int, int>(minEmotionalStability, maxEmotionalStability)));

    return listSettings;
  }

  XmlDocument loadXMLSettings(string path)
  {
    XmlDocument doc = new XmlDocument();
    doc.Load(path);

    return doc;
  }
  public static AvatarGenerator Find()
  {
    var avatarGenerator = GameObject.Find("AvatarGenerator").GetComponent<AvatarGenerator>();
    avatarGenerator.Start();
    //ListSettings = avatarGenerator.SettingsList;
    //amountOfAvatars = avatarGenerator.Amount;
    return avatarGenerator;
  }

  public static void Log(object message)
  {
    Debug.Log(message);
  }
}                                                                                                                                                                                                                                                                                                                                                                            