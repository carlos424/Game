#pragma strict

var sheep: GameObject;
var sheep2: GameObject;//copy of the sheep facing the other way :-)
	
	function OnGUI() {
	
		GUILayout.BeginHorizontal ("box");
		
		if (GUILayout.Button("Idle/Eating")){
		Time.timeScale = 1;
		sheep.GetComponent.<Animation>().CrossFade("idle");
		sheep2.GetComponent.<Animation>().CrossFade("idle");
		
		}
		
		if (GUILayout.Button("Look Right")){
		Time.timeScale = 1;
		sheep.GetComponent.<Animation>().CrossFade("lookRight");
		sheep2.GetComponent.<Animation>().CrossFade("lookRight");
		
		}
		
		if (GUILayout.Button("Look Left")){
		Time.timeScale = 1;
		sheep.GetComponent.<Animation>().CrossFade("lookLeft");
		sheep2.GetComponent.<Animation>().CrossFade("lookLeft");
		
		}
		
		if (GUILayout.Button("Jump")){
		Time.timeScale = 1.5;
		sheep.GetComponent.<Animation>().CrossFade("jump");
		sheep2.GetComponent.<Animation>().CrossFade("jump");
		
		}
		
		if (GUILayout.Button("Walk")){
		Time.timeScale = 1.5;
		sheep.GetComponent.<Animation>().CrossFade("walk");
		sheep2.GetComponent.<Animation>().CrossFade("walk");
		
		}
		
		if (GUILayout.Button("Run")){
		Time.timeScale = 1.5;
		sheep.GetComponent.<Animation>().CrossFade("run");
		sheep2.GetComponent.<Animation>().CrossFade("run");
		
		}
		
		GUILayout.EndHorizontal ();
	}
	
	