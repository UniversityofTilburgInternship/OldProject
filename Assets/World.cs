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
		settings = Settings;
		personalityValue = 0;
		normalActivity = false;
		UnityGoblin = UnityGoblin.Instantiate();
		
}
		public UnityEngine.Color Color{  get { return UnityGoblin.Color; }
  set{UnityGoblin.Color = value; }
 }
	public System.Boolean Destroyed{  get { return UnityGoblin.Destroyed; }
  set{UnityGoblin.Destroyed = value; }
 }
	public System.Boolean IsMovingLegs{  get { return UnityGoblin.IsMovingLegs; }
  set{UnityGoblin.IsMovingLegs = value; }
 }
	public UnityEngine.Vector3 Position{  get { return UnityGoblin.Position; }
  set{UnityGoblin.Position = value; }
 }
	public UnityEngine.Vector3 Scale{  get { return UnityGoblin.Scale; }
  set{UnityGoblin.Scale = value; }
 }
	public UnityGoblin UnityGoblin;
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
	public System.Boolean normalActivity;
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
	public System.Int32 ___chance_factor00;
	public System.Single count_down1;
	public System.Int32 ___randomPersonalityIndex10;
	public Casanova.Prelude.Tuple<System.String, System.Int32> ___personalityValue10;
	public Casanova.Prelude.Tuple<System.String, System.Int32> ___personalValue10;
	public void Update(float dt, World world) {
frame = World.frame;

		this.Rule0(dt, world);
		this.Rule1(dt, world);
		this.Rule2(dt, world);
		this.Rule3(dt, world);
	}





	int s0=-1;
	public void Rule0(float dt, World world){ switch (s0)
	{

	case -1:
	___chance_factor00 = 1;
	if(((((personalityValue) / (UnityEngine.Random.Range(1,100)))) > (___chance_factor00)))
	{

	goto case 3;	}else
	{

	goto case 4;	}
	case 3:
	AvatarGenerator.Log(true);
	s0 = 2;
return;
	case 4:
	AvatarGenerator.Log(false);
	s0 = 2;
return;
	case 2:
	normalActivity = true;
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
	___randomPersonalityIndex10 = UnityEngine.Random.Range(0,(settings.Count) * (2));
	if(((___randomPersonalityIndex10) > (((settings.Count) - (1)))))
	{

	goto case 9;	}else
	{

	goto case 10;	}
	case 9:
	___personalityValue10 = (settings)[((___randomPersonalityIndex10) - (settings.Count))];
	personalityValue = ((100) - (___personalityValue10.Item2));
	s1 = -1;
return;
	case 10:
	___personalValue10 = (settings)[___randomPersonalityIndex10];
	personalityValue = ___personalValue10.Item2;
	s1 = -1;
return;	
	default: return;}}
	

	int s2=-1;
	public void Rule2(float dt, World world){ switch (s2)
	{

	case -1:
	if(!(UnityEngine.Input.GetKey(KeyCode.C)))
	{

	s2 = -1;
return;	}else
	{

	goto case 0;	}
	case 0:
	Position = ((Position) - (new UnityEngine.Vector3((dt) * (2f),0f,0f)));
	IsMovingLegs = true;
	s2 = -1;
return;	
	default: return;}}
	

	int s3=-1;
	public void Rule3(float dt, World world){ switch (s3)
	{

	case -1:
	if(!(UnityEngine.Input.GetKey(KeyCode.Space)))
	{

	s3 = -1;
return;	}else
	{

	goto case 0;	}
	case 0:
	Position = ((Position) + (new UnityEngine.Vector3((dt) * (2f),0f,0f)));
	IsMovingLegs = true;
	s3 = -1;
return;	
	default: return;}}
	





}
<<<<<<< HEAD
<<<<<<< HEAD
}                   
=======
}                  
>>>>>>> 606a378846399e6fa5135009531cedccf79cb0e8
=======
}                           
>>>>>>> a317f33e1cc569d8fd182ddc7be217cebfad5e01
