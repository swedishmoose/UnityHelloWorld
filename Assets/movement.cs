using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
	
	void Start () {
	
	}
	
	float time = 0;
	int dir = 0;
	void Update () {
		time += Time.deltaTime;
		if(time>=0.1){
			if(transform.position.z>2){
				dir = 0;
			}
			else if(transform.position.z<-2){
				dir = 1;
			}
			if(dir==0){
				transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z-0.1f);
			}
			else if(dir==1){
				transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z+0.1f);
			}
		}
	}
}
