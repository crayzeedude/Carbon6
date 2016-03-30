using UnityEngine;
using System.Collections;

public class CreateWall : MonoBehaviour {
	
	//dimensiones
	public int xSize = 10;
	public int ySize = 10;
	public int zSize = 1;
	
	//Espaciado
	public float xEspaciado = 0;
	public float yEspaciado = 0;
	public float zEspaciado = 0;
	
	//posicion inicial relativa al padre
	public float xIni = 0;
	public float yIni = 0;
	public float zIni = 0;
	
	public GameObject ladrillo;
	
	//direcciones de x y z
	
		
	
	void Start () {
		
		//direcciones relativas al padre		
		Vector3 forward = transform.forward;
		Vector3 left = transform.right;
		Vector3 up = transform.up;
		//tamaño de los bloques ladrillo
		float xScale = ladrillo.transform.localScale.x;
		float yScale = ladrillo.transform.localScale.y;
		float zScale = ladrillo.transform.localScale.z;
				
		for (int iz = 0; iz < zSize; iz++){
			for (int iy = 0; iy < ySize; iy++){
				for (int ix = 0; ix < xSize; ix++){
					Instantiate (ladrillo, transform.position + forward*iz*zScale + left*ix*xScale + up*iy*yScale + new Vector3 (xIni + xEspaciado*ix, yIni + yEspaciado*iy, zIni + zEspaciado*iz), transform.rotation);
				}
			}
		}
	}
}
