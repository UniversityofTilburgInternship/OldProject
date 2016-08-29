#pragma warning disable 162,108,618
using Casanova.Prelude;
using System.Linq;
using System;
using System.Collections.Generic;
using UnityEngine;
namespace Game {public class World : MonoBehaviour{
public static int frame;
void Update () { Update(Time.deltaTime, this); 
 frame++; }
public bool JustEntered = true;


public void Start()
	{
		Cube = new Cube();
		
}
		public Cube Cube;

System.DateTime init_time = System.DateTime.Now;
	public void Update(float dt, World world) {
var t = System.DateTime.Now;

		Cube.Update(dt, world);


	}











}
public class Cube{
public int frame;
public bool JustEntered = true;
	public int ID;
public Cube()
	{JustEntered = false;
 frame = World.frame;
		UnityCube = UnityCube.Find();
		
}
		public UnityEngine.Color Color{  get { return UnityCube.Color; }
  set{UnityCube.Color = value; }
 }
	public System.Boolean Destroyed{  get { return UnityCube.Destroyed; }
  set{UnityCube.Destroyed = value; }
 }
	public UnityEngine.Vector3 Position{  get { return UnityCube.Position; }
  set{UnityCube.Position = value; }
 }
	public UnityEngine.Vector3 Scale{  get { return UnityCube.Scale; }
  set{UnityCube.Scale = value; }
 }
	public UnityCube UnityCube;
	public System.Boolean enabled{  get { return UnityCube.enabled; }
  set{UnityCube.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityCube.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return UnityCube.hideFlags; }
  set{UnityCube.hideFlags = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return UnityCube.isActiveAndEnabled; }
 }
	public System.String name{  get { return UnityCube.name; }
  set{UnityCube.name = value; }
 }
	public System.String tag{  get { return UnityCube.tag; }
  set{UnityCube.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return UnityCube.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityCube.useGUILayout; }
  set{UnityCube.useGUILayout = value; }
 }
	public void Update(float dt, World world) {
frame = World.frame;

		this.Rule0(dt, world);

	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	Position = ((Position) + (new UnityEngine.Vector3(0.05f,0f,0f)));
	s0 = -1;
return;	
	default: return;}}
	






}
}   