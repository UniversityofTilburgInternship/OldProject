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
		Cubes = (

Enumerable.Empty<Cube>()).ToList<Cube>();
		
}
		public List<Cube> Cubes;

System.DateTime init_time = System.DateTime.Now;
	public void Update(float dt, World world) {
var t = System.DateTime.Now;

		for(int x0 = 0; x0 < Cubes.Count; x0++) { 
			Cubes[x0].Update(dt, world);
		}
		this.Rule0(dt, world);
		this.Rule1(dt, world);
	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	if(!(UnityEngine.Input.GetKeyDown(KeyCode.P)))
	{

	s0 = -1;
return;	}else
	{

	goto case 0;	}
	case 0:
	Cubes = new Cons<Cube>(new Cube(), (Cubes)).ToList<Cube>();
	s0 = -1;
return;	
	default: return;}}
	

	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	Cubes = (

(Cubes).Select(__ContextSymbol1 => new { ___c10 = __ContextSymbol1 })
.Where(__ContextSymbol2 => !(__ContextSymbol2.___c10.Destroyed))
.Select(__ContextSymbol3 => __ContextSymbol3.___c10)
.ToList<Cube>()).ToList<Cube>();
	s1 = -1;
return;	
	default: return;}}
	





}
public class Cube{
public int frame;
public bool JustEntered = true;
	public int ID;
public Cube()
	{JustEntered = false;
 frame = World.frame;
		UnityCube = UnityCube.Instantiate();
		
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
	public System.Single count_down1;
	public System.Single count_down3;
	public System.Single count_down2;
	public void Update(float dt, World world) {
frame = World.frame;

		this.Rule0(dt, world);
		this.Rule1(dt, world);
		this.Rule2(dt, world);
	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	count_down1 = 5f;
	goto case 2;
	case 2:
	if(((count_down1) > (0f)))
	{

	count_down1 = ((count_down1) - (dt));
	s0 = 2;
return;	}else
	{

	goto case 0;	}
	case 0:
	Destroyed = true;
	s0 = -1;
return;	
	default: return;}}
	

	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	Color = Color.red;
	s1 = 3;
return;
	case 3:
	count_down3 = 1f;
	goto case 4;
	case 4:
	if(((count_down3) > (0f)))
	{

	count_down3 = ((count_down3) - (dt));
	s1 = 4;
return;	}else
	{

	goto case 2;	}
	case 2:
	Color = Color.green;
	s1 = 0;
return;
	case 0:
	count_down2 = 1f;
	goto case 1;
	case 1:
	if(((count_down2) > (0f)))
	{

	count_down2 = ((count_down2) - (dt));
	s1 = 1;
return;	}else
	{

	s1 = -1;
return;	}	
	default: return;}}
	

	int s2=-1;
	public void Rule2(float dt, World world){ 
	switch (s2)
	{

	case -1:
	if(!(UnityEngine.Input.GetKey(KeyCode.Space)))
	{

	s2 = -1;
return;	}else
	{

	goto case 0;	}
	case 0:
	Position = ((Position) + (new UnityEngine.Vector3(-0.05f,0f,0f)));
	s2 = -1;
return;	
	default: return;}}
	





}
}       