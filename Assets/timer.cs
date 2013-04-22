using UnityEngine;
using System.Collections;

public class timer : MonoBehaviour {
	
	void Start () {
	
	}
	
	float time = 0;
	void Update () {
		time += Time.deltaTime;
		if(time>=4){
			Destroy(gameObject);
		}
	}
}
