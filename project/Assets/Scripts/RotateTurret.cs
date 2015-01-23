using UnityEngine;
using System.Collections;

public class RotateTurret : MonoBehaviour {
	
	public Camera camera;
	private Transform[] transforms;
	private Transform turret;
	void Start () {
		transforms = gameObject.GetComponentsInChildren<Transform>();
		foreach (Transform t in transforms) 
		{
			if (t.gameObject.name == "turret")
			{
				turret = t;
			}
		}
	}
	
	
	void Update () {

		//print("mousePos = "+ mousePos);
		Vector3 mousePos = Input.mousePosition;
		mousePos.z = camera.transform.position.y - turret.transform.position.y;
		
		Vector3 worldPos = camera.ScreenToWorldPoint(mousePos);
		
		turret.LookAt (worldPos);
		
		//print("worldPos = "+ worldPos);
	}
}
