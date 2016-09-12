using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Casanova.Prelude;

public enum GoblinAnimation { Idle = 0, Walk = 1, Hit1 = 2, Run = 3, Hit2 = 4, Attack1 = 5, Attack2 = 6, Pow_Attack = 7 }
public class UnityGoblin : MonoBehaviour
{
  public List<Tuple<string, Tuple<int, int>>> listSettings { get; set; }
  public Color Color
  {
    get { return gameObject.GetComponent<Renderer>().material.color; }
    set { gameObject.GetComponent<Renderer>().material.color = value; }
  }

  public GoblinAnimation CurrentAnimation
  {
    set
    {
      if (!gameObject.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName(value.ToString().ToLower()))
      {
        gameObject.GetComponent<Animator>().Play(value.ToString().ToLower());
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
                                     