using UnityEngine;
using System.Collections;

public class MarsRotation : MonoBehaviour {

	public Transform target;

	public float RotationSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		target.transform.rotation = new Quaternion(target.transform.rotation.x + Time.deltaTime  * RotationSpeed,target.transform.rotation.y,target.transform.rotation.z,0);
	}
}