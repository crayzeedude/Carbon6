using UnityEngine;
using System.Collections;

public class CursorLock : MonoBehaviour {
	
	public bool isLocked;
	
	void Start(){
		SetLock(true);
	}
	
	void SetLock(bool isLocked){
		Screen.lockCursor  = isLocked;
		Screen.showCursor = !isLocked;
	}
	
	
	
	
	
	void Update(){
		if(Input.GetKey (KeyCode.L)){
			isLocked = !isLocked;
			SetLock (isLocked);
		}
	}
}	