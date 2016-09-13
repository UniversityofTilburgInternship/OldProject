using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Casanova.Prelude;

public enum GoblinAnimation { Idle = 0, Walk = 1, Hit1 = 2, Run = 3, Hit2 = 4, Attack1 = 5, Attack2 = 6, Pow_Attack = 7 }
public class UnityGoblin : MonoBehaviour
{
  public static List<PersonalityAnimation> animations = new List<PersonalityAnimation>();
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

  public int ToProxyCode { get { return ToProxyCode; } set { this.ToProxyCode = value; Animate(value); } }


  public void Animate(int id)
  {
    List<PersonalityAnimation> foundItems = new List<PersonalityAnimation>();
    for (int i = 0; i < animations.Count; i++)
    {

      if (animations[i].containsPersonality(id))
      {
        foundItems.Add(animations[i]);
      }
    }

    int randomIndex = Random.Range(0, foundItems.Count - 1);
    gameObject.GetComponent<Animator>().Play(animations[randomIndex].getAnimID());
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
    animations = (AvatarGenerator.Find()).animations;
  }

  public Vector3 Position
  {
    get { return gameObject.transform.position; }
    set { gameObject.transform.position = value; }
  }

  public Vector3 Forward
  {
    get
    {
      return gameObject.transform.forward;
    }
  }

  public Vector3 Rotation
  {
    get
    {
      return gameObject.transform.rotation.eulerAngles;
    }
    set
    {
      gameObject.transform.rotation = Quaternion.LookRotation(value);
    }
  }

  public static UnityGoblin Instantiate()
  {
    var _object = GameObject.Instantiate(Resources.Load("Goblin"), new Vector3(Screen.width / 2.0f + Random.Range(1.0f, 20.0f), 0.0f, Screen.height / 2.0f + Random.Range(1.0f, 20.0f)), Quaternion.identity) as GameObject;
    return _object.GetComponent<UnityGoblin>();
  }


  public static UnityGoblin Find()
  {
    return GameObject.Find("/Goblin").GetComponent<UnityGoblin>();
  }

}
                        