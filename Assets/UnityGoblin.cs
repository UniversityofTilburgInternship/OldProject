using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Casanova.Prelude;

public class UnityGoblin : MonoBehaviour
{
  public List<Tuple<string, Tuple<int, int>>> listSettings { get; set; }
  public Color Color
  {
    get { return gameObject.GetComponent<Renderer>().material.color; }
    set { gameObject.GetComponent<Renderer>().material.color = value; }
  }

  public bool IsMovingLegs
  {
    get { return gameObject.GetComponent<Animation>(); }
    set
    {
      if (value && !gameObject.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("walk"))
      {

        gameObject.GetComponent<Animator>().Play("cast");
      }
    }
  }

  public Vector3 Scale
  {
    get
    {
      return gameObject.transform.localScale;
    }
    set
    {
      gameObject.transform.localScale = value;
    }
  }

  bool destroyed = false;
  public bool Destroyed
  {
    get { return destroyed; }
    set
    {
      destroyed = value;
      if (destroyed)
        GameObject.Destroy(gameObject);
    }
  }
  void Start()
  {
    //AvatarGenerator settings = gameObject.GetComponent<AvatarGenerator>();
    //listSettings = settings.SettingsList;
  }

  public Vector3 Position
  {
    get { return gameObject.transform.position; }
    set { gameObject.transform.position = value; }
  }

  public static UnityGoblin Instantiate()
  {
    var _object = GameObject.Instantiate(Resources.Load("Goblin"), Random.insideUnitSphere, Quaternion.identity) as GameObject;
    return _object.GetComponent<UnityGoblin>();
  }


  public static UnityGoblin Find()
  {
    return GameObject.Find("/Goblin").GetComponent<UnityGoblin>();
  }

}

   