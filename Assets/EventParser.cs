using UnityEngine;
using System.Collections;

public class EventParser : MonoBehaviour 
{
  void parseXml()
  {
    pathToSettings = Application.dataPath + "\\Resources\\events.xml";

    XmlDocument eventsXmlFile = loadXMLSettings(pathToSettings);
    
    XmlNode eventsNode = eventsXmlFile.SelectSingleNode("events");
	foreach(XmlNode threshold in event["threshold"])
	{
	
	}
    foreach (XmlNode event in eventsNode)
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
  }

  // Update is called once per frame
  void Update()
  {

  }

  string stripSpecialCharacters(string text)
  {
    return Regex.Replace(text, @"\s+", "");
  }



	// Use this for initialization
	void Start () 
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
         