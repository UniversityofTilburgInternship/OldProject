using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Casanova.Prelude;

public class UnityEvent : MonoBehaviour
{
  private List<Assets.Event> allEvents;
  private Assets.Event randomEvent;

  private Assets.Event selectRandomEvent()
  {
    int randomIndex = Random.Range(0, allEvents.Count - 1);
    return allEvents[randomIndex];
  }

  public string eventName
  {
    get
    {
      return randomEvent.eventName;
    }
    set
    {
      randomEvent.eventName = value;
    }
  }

  public List<Tuple<string, int>> Thresholds
  {
    get
    {
      return randomEvent.thresholds;
    }
    set
    {
      randomEvent.thresholds = value;
    }
  }

  public float radius
  {
    get
    {
      return randomEvent.radius;
    }
    set
    {
      randomEvent.radius = value;
    }
  }


  public Vector3 position
  {
    get
    {
      return randomEvent.position;
    }
    set
    {
      randomEvent.position = value;
    }
  }

  public string animation
  {
    get
    {
      return randomEvent.animation;
    }
    set
    {
      randomEvent.animation = value;
    }
  }

  public string soundFileName { get { return randomEvent.soundFileName; } set { randomEvent.soundFileName = value; } }


  // Use this for initialization
  void Start()
  {
    List<Assets.Event> eventObjects = EventParser.unityEvents;
    allEvents = eventObjects;
    randomEvent = selectRandomEvent();
  }

  // Update is called once per frame
  void Update()
  {

  }
}
       