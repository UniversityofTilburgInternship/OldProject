using UnityEngine;
using System.Collections;

public class UnityGoblin : MonoBehaviour
{

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

                gameObject.GetComponent<Animator>().Play("run");
            }
        }

    }


    bool destroyed = false;
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