using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour {

	public bool p1win;
	public bool p2win;
	//public GameObject screenCamera;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (p1win == true) {
			GameObject.Find("p1winscreen").GetComponent<SpriteRenderer>().enabled = true;
			//screenCamera.gameObject.GetComponent<screenShake> ().shakeStart ();
		}

		if (p2win == true) {
			GameObject.Find("p2winscreen").GetComponent<SpriteRenderer>().enabled = true;
		}

	
		if (Input.GetKeyDown (KeyCode.G)){
			p1win = false;
			p2win = false;
			GameObject.Find("p1winscreen").GetComponent<SpriteRenderer>().enabled = false;
			GameObject.Find("p2winscreen").GetComponent<SpriteRenderer>().enabled = false;
			SceneManager.LoadScene(0);
		}

	}
}
