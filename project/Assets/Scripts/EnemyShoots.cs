using UnityEngine;
using System.Collections;

public class EnemyShoots : MonoBehaviour {
	private float reloadTime;
	public float timeToReload;
	public GameObject bulletPrefeb;
	private Transform turret;
	private Transform nozzle;
	// Use this for initialization
	void Start () {
		reloadTime = 0;

		Transform transforms = this.gameObject.GetComponentInChildren<Transform> ();
		foreach (Transform t in transforms) 
		{
			if(t.gameObject.name == "Turret")
			{
				turret = t;
			}	
			if(t.gameObject.name == "Nozzle")
			{
				nozzle = t;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		reloadTime += Time.deltaTime;
		if (reloadTime >= timeToReload) 
		{
			checkForPlayer();	
		}
	}
	private void checkForPlayer()
	{
		Ray myRay = new Ray ();
		myRay.origin = turret.position;
		myRay.direction = turret.forward;

		RaycastHit hitInfo;

		if (Physics.Raycast (myRay, out hitInfo, 10f)) 
		{
			string hitObjectName = hitInfo.collider.gameObject.name;
			if(hitObjectName == "Tank")
			{
				Instantiate(bulletPrefeb,nozzle.position, nozzle.rotation);

				reloadTime = 0f;
			}
		}
	}
}
