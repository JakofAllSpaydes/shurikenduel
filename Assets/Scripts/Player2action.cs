using UnityEngine;
using System.Collections;

public class Player2action : MonoBehaviour {
 	public int jumpHeight;
	public GameObject weapon2Prefab;
	public GameObject Player1action;
	public ParticleSystem playerDeath;
	public GameObject manager;

	// Use this for initialization
	void Start () {
		Player1action = GameObject.Find ("player 1");
	}
	
	// Update is called once per frame
	void Update () {

		GameObject [] weaponcountarray2 = GameObject.FindGameObjectsWithTag ("weapons2");


if (Input.GetKeyDown(KeyCode.UpArrow)){
		  GetComponent<Rigidbody2D>().AddForce (Vector2.up * jumpHeight);
	}

		if (weaponcountarray2.Length <= 5) {
			if (Input.GetKeyDown (KeyCode.LeftArrow)) {
				GameObject weapon2 = (GameObject)Instantiate (weapon2Prefab, transform.position + Vector3.left * 0.8f, Quaternion.identity);
				Vector3 newDirection = new Vector3 ();
				newDirection.x = -Mathf.Cos (transform.rotation.eulerAngles.z * Mathf.Deg2Rad);
				newDirection.y = Mathf.Sin (transform.rotation.eulerAngles.z * Mathf.Deg2Rad);
			
				weapon2.GetComponent<weapon2action> ().direction = newDirection;
			}
		}

		if (weaponcountarray2.Length <= 5) {
			if (Input.GetKeyDown (KeyCode.DownArrow)) {
				GameObject weapon1 = (GameObject)Instantiate (weapon2Prefab, transform.position + Vector3.left * 0.8f, Quaternion.identity);
				Vector3 newDirection = new Vector3 ();
				newDirection.x = -Mathf.Cos (transform.rotation.eulerAngles.z * Mathf.Deg2Rad);
				newDirection.y = -20 * Mathf.Deg2Rad;
			
				weapon1.GetComponent<weapon2action> ().direction = newDirection;
			}
		}

		if (weaponcountarray2.Length <= 5) {
			if (Input.GetKeyDown (KeyCode.RightArrow)) {
				GameObject weapon1 = (GameObject)Instantiate (weapon2Prefab, transform.position + Vector3.left * 0.8f, Quaternion.identity);
				Vector3 newDirection = new Vector3 ();
				newDirection.x = -Mathf.Cos (transform.rotation.eulerAngles.z * Mathf.Deg2Rad);
				newDirection.y = 20 * Mathf.Deg2Rad;
			
				weapon1.GetComponent<weapon2action> ().direction = newDirection;
			}
		}



		}

	void OnCollisionEnter2D(Collision2D collider){
		
		if (collider.gameObject.tag == "weapons1") {
			Instantiate (playerDeath, transform.position, Quaternion.identity);
			
			GameObject[] allWeapon = GameObject.FindGameObjectsWithTag ("weapons1");
			for(int i=0; i<allWeapon.Length; i++){
				Destroy(allWeapon[i].gameObject);
			}
			GameObject[] allWeapon2 = GameObject.FindGameObjectsWithTag ("weapons2");
			for(int i=0; i<allWeapon2.Length; i++){
				Destroy(allWeapon2[i].gameObject);
			}

			manager.gameObject.GetComponent<gameManager> ().p1win = true;

			Destroy (this.gameObject);

			//transform.position = new Vector3(7.5f,-2.68f,0);
			//Player1action.GetComponent <Player1action> ().transform.position = new Vector3(-7.5f,-2.68f,0);

		}
	}


}
