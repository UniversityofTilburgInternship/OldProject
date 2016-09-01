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
		SelectedCubeToDestroy = (new Nothing<Cube>());
		Cubes = (

Enumerable.Empty<Cube>()).ToList<Cube>();
		
}
		public List<Cube> Cubes;
	public Option<Cube> SelectedCubeToDestroy;
	public Cube ___selected_element30;

System.DateTime init_time = System.DateTime.Now;
	public void Update(float dt, World world) {
var t = System.DateTime.Now;

		for(int x0 = 0; x0 < Cubes.Count; x0++) { 
			Cubes[x0].Update(dt, world);
		}
		this.Rule0(dt, world);
		this.Rule1(dt, world);
		this.Rule2(dt, world);
		this.Rule3(dt, world);
	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	Cubes = (

(Cubes).Select(__ContextSymbol1 => new { ___c00 = __ContextSymbol1 })
.Where(__ContextSymbol2 => !(__ContextSymbol2.___c00.Destroyed))
.Select(__ContextSymbol3 => __ContextSymbol3.___c00)
.ToList<Cube>()).ToList<Cube>();
	s0 = -1;
return;	
	default: return;}}
	

	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	if(!(UnityEngine.Input.GetKeyDown(KeyCode.P)))
	{

	s1 = -1;
return;	}else
	{

	goto case 0;	}
	case 0:
	Cubes = new Cons<Cube>(new Cube(), (Cubes)).ToList<Cube>();
	s1 = -1;
return;	
	default: return;}}
	

	int s2=-1;
	public void Rule2(float dt, World world){ 
	switch (s2)
	{

	case -1:
	if(!(((SelectedCubeToDestroy.IsSome) && (SelectedCubeToDestroy.Value.Destroyed))))
	{

	s2 = -1;
return;	}else
	{

	goto case 0;	}
	case 0:
	SelectedCubeToDestroy = (new Nothing<Cube>());
	s2 = -1;
return;	
	default: return;}}
	

	int s3=-1;
	public void Rule3(float dt, World world){ 
	switch (s3)
	{

	case -1:
	if(!(((UnityEngine.Input.GetKeyDown(KeyCode.R)) && (((Cubes.Count) > (0))))))
	{

	s3 = -1;
return;	}else
	{

	goto case 1;	}
	case 1:
	___selected_element30 = (Cubes)[UnityEngine.Random.Range(0,Cubes.Count)];
	SelectedCubeToDestroy = (new Just<Cube>(___selected_element30));
	s3 = -1;
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
		UnityCube ___cube00;
		___cube00 = UnityCube.Instantiate();
		System.Single ___dist00;
		___dist00 = 3f;
		List<UnityEngine.Vector3> ___checkpoints00;
		___checkpoints00 = (

(new Cons<UnityEngine.Vector3>(new UnityEngine.Vector3((___cube00.Position.x) + (___dist00),___cube00.Position.y,___cube00.Position.z),(new Cons<UnityEngine.Vector3>(new UnityEngine.Vector3((___cube00.Position.x) + (___dist00),(___cube00.Position.y) + (___dist00),___cube00.Position.z),(new Cons<UnityEngine.Vector3>(new UnityEngine.Vector3(___cube00.Position.x,(___cube00.Position.y) + (___dist00),___cube00.Position.z),(new Cons<UnityEngine.Vector3>(___cube00.Position,(new Empty<UnityEngine.Vector3>()).ToList<UnityEngine.Vector3>())).ToList<UnityEngine.Vector3>())).ToList<UnityEngine.Vector3>())).ToList<UnityEngine.Vector3>())).ToList<UnityEngine.Vector3>()).ToList<UnityEngine.Vector3>();
		Velocity = Vector3.zero;
		UnityCube = ___cube00;
		Factor = 1.4f;
		Checkpoints = ___checkpoints00;
		
}
		public List<UnityEngine.Vector3> Checkpoints;
	public UnityEngine.Color Color{  get { return UnityCube.Color; }
  set{UnityCube.Color = value; }
 }
	public System.Boolean Destroyed{  get { return UnityCube.Destroyed; }
  set{UnityCube.Destroyed = value; }
 }
	public System.Single Factor;
	public UnityEngine.Vector3 Position{  get { return UnityCube.Position; }
  set{UnityCube.Position = value; }
 }
	public UnityEngine.Vector3 Scale{  get { return UnityCube.Scale; }
  set{UnityCube.Scale = value; }
 }
	public UnityCube UnityCube;
	public UnityEngine.Vector3 Velocity;
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
	public System.Single count_down2;
	public System.Single count_down1;
	public UnityEngine.Vector3 ___c21;
	public System.Int32 counter22;
	public UnityEngine.Vector3 ___dir020;
	public System.Single count_down3;
	public void Update(float dt, World world) {
frame = World.frame;

		this.Rule0(dt, world);
		this.Rule1(dt, world);
		this.Rule2(dt, world);
		this.Rule3(dt, world);
	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	Color = Color.red;
	s0 = 3;
return;
	case 3:
	count_down2 = 1f;
	goto case 4;
	case 4:
	if(((count_down2) > (0f)))
	{

	count_down2 = ((count_down2) - (dt));
	s0 = 4;
return;	}else
	{

	goto case 2;	}
	case 2:
	Color = Color.green;
	s0 = 0;
return;
	case 0:
	count_down1 = 1f;
	goto case 1;
	case 1:
	if(((count_down1) > (0f)))
	{

	count_down1 = ((count_down1) - (dt));
	s0 = 1;
return;	}else
	{

	s0 = -1;
return;	}	
	default: return;}}
	

	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	Position = ((Position) + (((Velocity) * (dt))));
	s1 = -1;
return;	
	default: return;}}
	

	int s2=-1;
	public void Rule2(float dt, World world){ 
	switch (s2)
	{

	case -1:
	
	counter22 = -1;
	if((((Checkpoints).Count) == (0)))
	{

	goto case 0;	}else
	{

	___c21 = (Checkpoints)[0];
	goto case 2;	}
	case 2:
	counter22 = ((counter22) + (1));
	if((((((Checkpoints).Count) == (counter22))) || (((counter22) > ((Checkpoints).Count)))))
	{

	goto case 0;	}else
	{

	___c21 = (Checkpoints)[counter22];
	goto case 3;	}
	case 3:
	___dir020 = ((___c21) - (Position));
	Position = Position;
	Velocity = ___dir020.normalized;
	Destroyed = Destroyed;
	s2 = 7;
return;
	case 7:
	if(!(((0f) > (UnityEngine.Vector3.Dot(___dir020,(___c21) - (Position))))))
	{

	s2 = 7;
return;	}else
	{

	goto case 6;	}
	case 6:
	Position = ___c21;
	Velocity = Vector3.zero;
	Destroyed = Destroyed;
	s2 = 4;
return;
	case 4:
	count_down3 = 1f;
	goto case 5;
	case 5:
	if(((count_down3) > (0f)))
	{

	count_down3 = ((count_down3) - (dt));
	s2 = 5;
return;	}else
	{

	s2 = 2;
return;	}
	case 0:
	Position = Position;
	Velocity = Velocity;
	Destroyed = true;
	s2 = -1;
return;	
	default: return;}}
	

	int s3=-1;
	public void Rule3(float dt, World world){ 
	switch (s3)
	{

	case -1:
	if(!(((world.SelectedCubeToDestroy.IsSome) && (((world.SelectedCubeToDestroy.Value) == (this))))))
	{

	s3 = -1;
return;	}else
	{

	goto case 1;	}
	case 1:
	if(!(((Factor) > (0f))))
	{

	goto case 0;	}else
	{

	goto case 2;	}
	case 2:
	Scale = ((Scale) + (((Vector3.one) * (dt))));
	Factor = ((Factor) - (dt));
	Destroyed = Destroyed;
	s3 = 1;
return;
	case 0:
	Scale = Scale;
	Factor = Factor;
	Destroyed = true;
	s3 = -1;
return;	
	default: return;}}
	





}
}                     