using UnityEngine;
using System.Collections;

public class Player1action : MonoBehaviour {
	public int jumpHeight;
	public GameObject weapon1Prefab;
	public GameObject Player2action;
	public ParticleSystem playerDeath;
	public GameObject manager;

	// Use this for initialization
	void Start () {
		Player2action = GameObject.Find ("player 2");
	}

	
	// Update is called once per frame
	void Update () {

		GameObject [] weaponcountarray = GameObject.FindGameObjectsWithTag ("weapons1");
		Debug.Log (weaponcountarray.Length);

	if (Input.GetKeyDown(KeyCode.W)){
		  GetComponent<Rigidbody2D>().AddForce (Vector2.up * jumpHeight);
	}
	if (weaponcountarray.Length<=5) {
			if (Input.GetKeyDown (KeyCode.D)) {
				GameObject weapon1 = (GameObject)Instantiate (weapon1Prefab, transform.position + Vector3.right * 0.8f, Quaternion.identity);
				Vector3 newDirection = new Vector3 ();
				newDirection.x = Mathf.Cos (transform.rotation.eulerAngles.z * Mathf.Deg2Rad);
				newDirection.y = Mathf.Sin (transform.rotation.eulerAngles.z * Mathf.Deg2Rad);
			
				weapon1.GetComponent<weapon1action> ().direction = newDirection;
			}
		}

		if (weaponcountarray.Length<=5) {
			if (Input.GetKeyDown (KeyCode.S)) {
				GameObject weapon1 = (GameObject)Instantiate (weapon1Prefab, transform.position + Vector3.right * 0.8f, Quaternion.identity);
				Vector3 newDirection = new Vector3 ();
				newDirection.x = Mathf.Cos (transform.rotation.eulerAngles.z * Mathf.Deg2Rad);
				newDirection.y = -20 * Mathf.Deg2Rad;
	
				weapon1.GetComponent<weapon1action> ().direction = newDirection;
			}
		}
		//Debug.Log (transform.rotation.eulerAngles.z*  Mathf.Deg2Rad);
		if (weaponcountarray.Length<=5) {
			if (Input.GetKeyDown (KeyCode.A)) {
				GameObject weapon1 = (GameObject)Instantiate (weapon1Prefab, transform.position + Vector3.right * 0.8f, Quaternion.identity);
				Vector3 newDirection = new Vector3 ();
				newDirection.x = Mathf.Cos (transform.rotation.eulerAngles.z * Mathf.Deg2Rad);
				newDirection.y = 20 * Mathf.Deg2Rad;
			
				weapon1.GetComponent<weapon1action> ().direction = newDirection;
			}
		}
	}

	void OnCollisionEnter2D(Collision2D collider){
		
		if (collider.gameObject.tag == "weapons2") {
			Instantiate (playerDeath, transform.position, Quaternion.identity);

			GameObject[] allWeapon = GameObject.FindGameObjectsWithTag ("weapons1");
			for(int i=0; i<allWeapon.Length; i++){
				Destroy(allWeapon[i].gameObject);
			}
			GameObject[] allWeapon2 = GameObject.FindGameObjectsWithTag ("weapons2");
			for(int i=0; i<allWeapon2.Length; i++){
				Destroy(allWeapon2[i].gameObject);
			}

			manager.gameObject.GetComponent<gameManager> ().p2win = true;

			Destroy (this.gameObject);
			//transform.position = new Vector3(-7.5f,-2.69f,0);
			//Player2action.GetComponent <Player2action> ().transform.position = new Vector3(7.5f,-2.68f,0);
		}
	}

}
