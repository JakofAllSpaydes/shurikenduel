using UnityEngine;
using System.Collections;

public class shurikenaction : MonoBehaviour {
	public GameObject Shield;
	public Vector3 spawnarea;


	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", 0f, 4f);

	}


	
	// Update is called once per frame


	void Update () {



		transform.position = spawnarea;

		transform.Rotate (Vector3.forward, (800f*Time.deltaTime));
	
}

	void Spawn(){
		spawnarea.x = (Random.Range (-7, 7));
			while (spawnarea.x<-5 || spawnarea.x>5){
			spawnarea.x=3;
			}
	}

	void OnCollisionEnter2D (Collision2D collider){

		//if (collider.gameObject.tag == "weapons1" || collider.gameObject.tag == "weapons2") {
		//}


	}

}