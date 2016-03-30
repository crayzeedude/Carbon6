using UnityEngine;
using System.Collections;

public class PlaceCube : MonoBehaviour {


	RaycastHit hit;



	public GameObject cube;

	public GameObject cubePreview;
		
	public float rotX;
	public float rotY;
	public float rotZ;

	public AudioClip placeCube;
	public AudioClip destroyCube;


	public GameObject heavyCube;
	public GameObject heavyCubePrism;
	public GameObject heavyCubeInner;

	
	public GameObject plasticCube;
	public GameObject plasticCubePrism;
	public GameObject plasticCubeInner;




	public float buildDist;


	[HideInInspector]
	public GameObject clonedCube;
	void Update () {
		
		
		
	
			
			
		if(Input.GetKeyDown(KeyCode.F)){
			cube = hit.transform.gameObject;
		}
		
		
		if(Physics.Raycast (Camera.main.ScreenPointToRay (new Vector3(Screen.width / 2 , Screen.height / 2)),
		                    out hit, buildDist)){
			
			if(hit.transform.tag == "Voxel"){
				cubePreview.renderer.enabled = true;




			
			
			cubePreview.transform.position = CubePosition();
		

			if(Input.GetMouseButtonDown(0)){

					Instantiate(cube,CubePosition(),new Quaternion(rotX,rotY,rotZ	,0));
				



			}

			if(Input.GetMouseButtonDown (1)){

				if(hit.transform.tag == "Voxel"){
					Destroy (hit.transform.gameObject);
				}
	

			}



		
		}   
	
		}
		cube.transform.rotation = Quaternion.FromToRotation(transform.up, hit.normal) * transform.rotation;

	}

	void OnGUI(){

		GUILayout.Label("Press Q for  Cube Selection");

		if(Input.GetKey(KeyCode.Q)){

			if(GUILayout.Button ("Plastic Cube")){
				cube = plasticCube;
			}
			if(GUILayout.Button ("Plastic Cube Prism")){
				cube = plasticCubePrism;
			}
			if(GUILayout.Button ("Plastic Cube Inner")){
				cube = plasticCubeInner;
			}
			//Heavy cubes
			if(GUILayout.Button ("Heavy Cube")){
				cube = heavyCube;
			}
			
			if(GUILayout.Button ("Heavy Cube Prism")){
				cube = heavyCubePrism;
			}
			if(GUILayout.Button ("Heavy Cube Inner")){
				cube = heavyCubeInner	;
			}



		}
	}

	Vector3 CubePosition(){


		float x = hit.transform.position.x + hit.normal.normalized.x;
		float y = hit.transform.position.y + hit.normal.normalized.y;
		float z = hit.transform.position.z + hit.normal.normalized.z;

		float roundedX = Mathf.Floor(x);
		float roundedY = Mathf.Floor(y);
		float roundedZ = Mathf.Floor(z);


		return new Vector3(roundedX,roundedY,roundedZ);
	}
	Quaternion CubeRotation(float x, float y, float z){
		return new Quaternion(x,y,z,0);
	}



}

