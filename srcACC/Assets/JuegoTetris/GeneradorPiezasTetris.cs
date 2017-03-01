using UnityEngine;
using System.Collections;

public class GeneradorPiezasTetris : MonoBehaviour {
	
	// Prefab
	public GameObject[] objPrefab;

	// Parametros de generacion
	public float velocidad = 1f;

	// Offsets
	public float espacioLateral = 1f;
	public float espacioSuperior = 4f;
	public float espacioInferior = 10f;

	// Limites de pantalla
	private float xMax;
	private float yMax;


	// Inicializacion
	void Start () {

		xMax = (Camera.main.orthographicSize * Camera.main.aspect) - espacioLateral;
		yMax = Camera.main.orthographicSize - espacioSuperior/2 - espacioInferior/2;

		print("antes de generar la pieza");
		generaPieza();
	}
	
	// Genera una pieza arriba
	public void generaPieza() {

		// tipo de pieza
		int i = Random.Range(0, objPrefab.Length);

		print("genero el i = "+i);

		// generamos el objeto en la posicion (x, y)
		float y = yMax + espacioSuperior/2;

		Instantiate(objPrefab[i],
			new Vector2(0, y),
		            Quaternion.identity);

		print("ya lo he instanciado en y = " +y);
	}
	
}