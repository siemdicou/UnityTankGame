using UnityEngine;
using System.Collections;

public class Gone : MonoBehaviour {

	public float maxLifeTime = 0.2f;
	private float lifeTime = 0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float delta = Time.deltaTime;
		
		lifeTime += delta;
		if (lifeTime > maxLifeTime) 
		{
			Destroy(this.gameObject);
		}
	}
}
