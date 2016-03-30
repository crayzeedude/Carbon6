using UnityEngine;
using System.Collections;

public class SaveBlocks : MonoBehaviour {



	/**
	 * <summery>
	 * Keeps the selected voxel in RAM
	 * so we can use it in game
	 * 
	 **/


	void Awake(){




		DontDestroyOnLoad(gameObject);




	}
}
