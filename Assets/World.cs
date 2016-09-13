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
		AvatarGenerator ___avatar_generator00;
		___avatar_generator00 = AvatarGenerator.Find();
		Goblins = (

Enumerable.Empty<Goblin>()).ToList<Goblin>();
		AvatarGen = ___avatar_generator00;
		
}
		public AvatarGenerator AvatarGen;
	public List<Goblin> Goblins;
	public System.Int32 ___x00;
	public System.Int32 counter20;

System.DateTime init_time = System.DateTime.Now;
	public void Update(float dt, World world) {
var t = System.DateTime.Now;

		for(int x0 = 0; x0 < Goblins.Count; x0++) { 
			Goblins[x0].Update(dt, world);
		}
		this.Rule0(dt, world);

	}





	int s0=-1;
	public void Rule0(float dt, World world){ switch (s0)
	{

	case -1:
	
	counter20 = -1;
	if((((Enumerable.Range(0,((1) + (((((AvatarGen.Amount) - (1))) - (0))))).ToList<System.Int32>()).Count) == (0)))
	{

	goto case 0;	}else
	{

	___x00 = (Enumerable.Range(0,((1) + (((((AvatarGen.Amount) - (1))) - (0))))).ToList<System.Int32>())[0];
	goto case 2;	}
	case 2:
	counter20 = ((counter20) + (1));
	if((((((Enumerable.Range(0,((1) + (((((AvatarGen.Amount) - (1))) - (0))))).ToList<System.Int32>()).Count) == (counter20))) || (((counter20) > ((Enumerable.Range(0,((1) + (((((AvatarGen.Amount) - (1))) - (0))))).ToList<System.Int32>()).Count)))))
	{

	goto case 0;	}else
	{

	___x00 = (Enumerable.Range(0,((1) + (((((AvatarGen.Amount) - (1))) - (0))))).ToList<System.Int32>())[counter20];
	goto case 3;	}
	case 3:
	Goblins = new Cons<Goblin>(new Goblin((

(AvatarGen.SettingsList).Select(__ContextSymbol1 => new { ___characteristic00 = __ContextSymbol1 })
.Select(__ContextSymbol2 => new Casanova.Prelude.Tuple<System.String, System.Int32>(__ContextSymbol2.___characteristic00.Item1,UnityEngine.Random.Range(__ContextSymbol2.___characteristic00.Item2.Item1,__ContextSymbol2.___characteristic00.Item2.Item2)))
.ToList<Casanova.Prelude.Tuple<System.String, System.Int32>>()).ToList<Casanova.Prelude.Tuple<System.String, System.Int32>>()), (Goblins)).ToList<Goblin>();
	s0 = 2;
return;
	case 0:
	if(!(false))
	{

	s0 = 0;
return;	}else
	{

	s0 = -1;
return;	}	
	default: return;}}
	






}
public class Goblin{
public int frame;
public bool JustEntered = true;
private List<Casanova.Prelude.Tuple<System.String, System.Int32>> Settings;
	public int ID;
public Goblin(List<Casanova.Prelude.Tuple<System.String, System.Int32>> Settings)
	{JustEntered = false;
 frame = World.frame;
		UnityGoblin ___goblin00;
		___goblin00 = UnityGoblin.Instantiate();
		settings = Settings;
		personalityValue = 0;
		personalityIndex = 0;
		normalActivity = false;
		newPosition = Vector3.zero;
		Velocity = Vector3.zero;
		UnityGoblin = ___goblin00;
		
}
		public UnityEngine.Color Color{  get { return UnityGoblin.Color; }
  set{UnityGoblin.Color = value; }
 }
	public GoblinAnimation CurrentAnimation{  set{UnityGoblin.CurrentAnimation = value; }
 }
	public System.Boolean Destroyed{  get { return UnityGoblin.Destroyed; }
  set{UnityGoblin.Destroyed = value; }
 }
	public UnityEngine.Vector3 Forward{  get { return UnityGoblin.Forward; }
 }
	public UnityEngine.Vector3 Position{  get { return UnityGoblin.Position; }
  set{UnityGoblin.Position = value; }
 }
	public UnityEngine.Vector3 Rotation{  get { return UnityGoblin.Rotation; }
  set{UnityGoblin.Rotation = value; }
 }
	public UnityEngine.Vector3 Scale{  get { return UnityGoblin.Scale; }
  set{UnityGoblin.Scale = value; }
 }
	public System.Int32 ToProxyCode{  get { return UnityGoblin.ToProxyCode; }
  set{UnityGoblin.ToProxyCode = value; }
 }
	public UnityGoblin UnityGoblin;
	public UnityEngine.Vector3 Velocity;
	public System.Collections.Generic.List<PersonalityAnimation> animations{  get { return UnityGoblin.animations; }
  set{UnityGoblin.animations = value; }
 }
	public System.Boolean enabled{  get { return UnityGoblin.enabled; }
  set{UnityGoblin.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityGoblin.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return UnityGoblin.hideFlags; }
  set{UnityGoblin.hideFlags = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return UnityGoblin.isActiveAndEnabled; }
 }
	public System.Collections.Generic.List<Casanova.Prelude.Tuple<System.String,Casanova.Prelude.Tuple<System.Int32,System.Int32>>> listSettings{  get { return UnityGoblin.listSettings; }
  set{UnityGoblin.listSettings = value; }
 }
	public System.String name{  get { return UnityGoblin.name; }
  set{UnityGoblin.name = value; }
 }
	public UnityEngine.Vector3 newPosition;
	public System.Boolean normalActivity;
	public System.Int32 personalityIndex;
	public System.Int32 personalityValue;
	public List<Casanova.Prelude.Tuple<System.String, System.Int32>> settings;
	public System.String tag{  get { return UnityGoblin.tag; }
  set{UnityGoblin.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return UnityGoblin.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityGoblin.useGUILayout; }
  set{UnityGoblin.useGUILayout = value; }
 }
	public System.Single count_down1;
	public UnityEngine.Vector3 ___dir010;
	public UnityEngine.Vector3 ___dir021;
	public System.Int32 ___chance_factor30;
	public System.Single count_down2;
	public System.Int32 ___randomPersonalityIndex40;
	public Casanova.Prelude.Tuple<System.String, System.Int32> ___personalityValue40;
	public Casanova.Prelude.Tuple<System.String, System.Int32> ___personalValue40;
	public System.Single count_down3;
	public void Update(float dt, World world) {
frame = World.frame;

		this.Rule0(dt, world);
		this.Rule1(dt, world);
		this.Rule2(dt, world);
		this.Rule3(dt, world);
		this.Rule4(dt, world);
		this.Rule5(dt, world);
		this.Rule6(dt, world);
	}





	int s0=-1;
	public void Rule0(float dt, World world){ switch (s0)
	{

	case -1:
	newPosition = new UnityEngine.Vector3(UnityEngine.Random.Range((UnityGoblin.Position.x) + (10f),(UnityGoblin.Position.x) - (20f)),UnityGoblin.Position.y,UnityEngine.Random.Range((UnityGoblin.Position.z) + (10f),(UnityGoblin.Position.z) - (20f)));
	s0 = 0;
return;
	case 0:
	count_down1 = 10f;
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
	public void Rule1(float dt, World world){ switch (s1)
	{

	case -1:
	___dir010 = ((newPosition) - (Position));
	Position = ((Position) + (((Velocity) * (dt))));
	Rotation = UnityEngine.Vector3.RotateTowards(Forward,___dir010,(dt) * (10f),0f);
	s1 = -1;
return;	
	default: return;}}
	

	int s2=-1;
	public void Rule2(float dt, World world){ switch (s2)
	{

	case -1:
	___dir021 = ((newPosition) - (Position));
	Position = Position;
	Velocity = ___dir021.normalized;
	s2 = 1;
return;
	case 1:
	if(!(((0f) > (UnityEngine.Vector3.Dot(___dir021,(newPosition) - (Position))))))
	{

	s2 = 1;
return;	}else
	{

	goto case 0;	}
	case 0:
	Position = Position;
	Velocity = Vector3.zero;
	s2 = -1;
return;	
	default: return;}}
	

	int s3=-1;
	public void Rule3(float dt, World world){ switch (s3)
	{

	case -1:
	___chance_factor30 = 1;
	if(((((personalityValue) / (UnityEngine.Random.Range(1,100)))) > (___chance_factor30)))
	{

	goto case 6;	}else
	{

	goto case 7;	}
	case 6:
	UnityGoblin.Animate(personalityIndex);
	normalActivity = true;
	s3 = 4;
return;
	case 7:
	normalActivity = false;
	s3 = 4;
return;
	case 4:
	count_down2 = 10f;
	goto case 5;
	case 5:
	if(((count_down2) > (0f)))
	{

	count_down2 = ((count_down2) - (dt));
	s3 = 5;
return;	}else
	{

	s3 = -1;
return;	}	
	default: return;}}
	

	int s4=-1;
	public void Rule4(float dt, World world){ switch (s4)
	{

	case -1:
	___randomPersonalityIndex40 = UnityEngine.Random.Range(0,(settings.Count) * (2));
	if(((___randomPersonalityIndex40) > (((settings.Count) - (1)))))
	{

	goto case 15;	}else
	{

	goto case 16;	}
	case 15:
	___personalityValue40 = (settings)[((___randomPersonalityIndex40) - (settings.Count))];
	personalityValue = ((100) - (___personalityValue40.Item2));
	personalityIndex = ___randomPersonalityIndex40;
	s4 = 13;
return;
	case 16:
	___personalValue40 = (settings)[___randomPersonalityIndex40];
	personalityValue = ___personalValue40.Item2;
	personalityIndex = ___randomPersonalityIndex40;
	s4 = 13;
return;
	case 13:
	count_down3 = 10f;
	goto case 14;
	case 14:
	if(((count_down3) > (0f)))
	{

	count_down3 = ((count_down3) - (dt));
	s4 = 14;
return;	}else
	{

	s4 = -1;
return;	}	
	default: return;}}
	

	int s5=-1;
	public void Rule5(float dt, World world){ switch (s5)
	{

	case -1:
	if(!(UnityEngine.Input.GetKey(KeyCode.C)))
	{

	s5 = -1;
return;	}else
	{

	goto case 0;	}
	case 0:
	Position = ((Position) - (new UnityEngine.Vector3((dt) * (2f),0f,0f)));
	CurrentAnimation = GoblinAnimation.Walk;
	s5 = -1;
return;	
	default: return;}}
	

	int s6=-1;
	public void Rule6(float dt, World world){ switch (s6)
	{

	case -1:
	if(!(UnityEngine.Input.GetKey(KeyCode.Space)))
	{

	s6 = -1;
return;	}else
	{

	goto case 0;	}
	case 0:
	Position = ((Position) + (new UnityEngine.Vector3((dt) * (2f),0f,0f)));
	CurrentAnimation = GoblinAnimation.Run;
	s6 = -1;
return;	
	default: return;}}
	





}
<<<<<<< HEAD
}        
=======
}  
>>>>>>> c7c9a0fba5e07cebee3968ed52f2ed8ce00fb6ff
