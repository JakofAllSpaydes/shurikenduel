using UnityEngine;
using System.Collections;

public class weapon2action : MonoBehaviour {
	public Vector3 direction;
	public float speed;
	public ParticleSystem smallExplosion;

	// Use this for initialization
	void Start () {
		


	}
	
	// Update is called once per frame
	void Update () {
		transform.position += (direction * speed * Time.deltaTime);
		//transform.Rotate (Vector3.forward, (1000f*Time.deltaTime));
	
	}

void OnCollisionEnter2D(Collision2D collider){
	
	if (collider.gameObject.tag == "walls") {
		Destroy (this.gameObject);
		Instantiate (smallExplosion, transform.position, Quaternion.identity);
	}
	
	if (collider.gameObject.tag == "weapons1") {
		Destroy (this.gameObject);
		Instantiate (smallExplosion, transform.position, Quaternion.identity);
	}
	
}
}