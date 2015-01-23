using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	public float speed;
	public float maxLifeTime = 6f;
	private float lifeTime = 0f;
	public GameObject BoomPre;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		float delta = Time.deltaTime;

		transform.Translate (Vector3.forward * speed * delta);

		lifeTime += delta;
		if (lifeTime > maxLifeTime) 
		{
			Destroy(this.gameObject);
		}
	}
	void OnCollisionEnter(Collision coll)
	{
		Instantiate (BoomPre, this.transform.position, this.transform.rotation);

		Destroy (this.gameObject);
	}
}
