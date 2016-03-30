using UnityEngine;
using System.Collections;

public class CheckForCollision : MonoBehaviour {
	public GameObject cubePreview;
	void OnCollisionEnter(Collision c){

		if(c.transform.tag == "Block"){

			cubePreview.renderer.material.color = new Color(255,0,0,25f);

		}else{

			cubePreview.renderer.material.color = new Color(0,255,0,25f);
		}


	}
}
