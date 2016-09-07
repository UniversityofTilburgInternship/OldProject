using UnityEngine;
using System.Collections;

public class UnityCube : MonoBehaviour
{

    public Color Color
    {
        get { return gameObject.GetComponent<Renderer>().material.color; }
        set { gameObject.GetComponent<Renderer>().material.color = value; }
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

    public static UnityCube Instantiate()
    {
        var _object = GameObject.Instantiate(Resources.Load("MyCube"), Random.insideUnitSphere, Quaternion.identity) as GameObject;
        return _object.GetComponent<UnityCube>();
    }

    public static UnityCube Find()
    {
        return GameObject.Find("/MyCube").GetComponent<UnityCube>();
    }
}       