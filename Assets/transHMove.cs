using UnityEngine;
using System.Collections;

public class transHMove : MonoBehaviour {
	public GameObject face;
	
	void Start () {
		Application.targetFrameRate = 60;
	}
	
	
	void Update () {
		if(Input.GetButtonDown ("Fire1")){
			print("asdasdasdasd");
			GameObject f = (GameObject) Instantiate(face, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
		}
	}
}
