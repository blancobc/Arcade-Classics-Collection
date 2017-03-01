using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

	// GAME MANAGER
	GameManager GM;
	void Awake () {
		GM = GameManager.instancia;
	}

		
	// Etiquetas donde se mostraran los puntos
	public Text puntosSnake;
	public Text puntosArkanoid;
	public Text puntosPacman;
	public Text puntosSpaceInvaders;
	public Text puntosTetris;
	public Text puntosOtro;


	void Start(){

		// Al comenzar cargamos los puntos de cada juego
		puntosSnake.text = PlayerPrefs.GetInt("puntosSnake").ToString();
		puntosArkanoid.text = PlayerPrefs.GetInt("puntosArkanoid").ToString();
		puntosPacman.text = PlayerPrefs.GetInt("puntosPacman").ToString();
		puntosSpaceInvaders.text = PlayerPrefs.GetInt("puntosSpaceInvaders").ToString();
		puntosTetris.text = PlayerPrefs.GetInt("puntosTetris").ToString();
		puntosOtro.text = PlayerPrefs.GetInt("puntosOtro").ToString();

	}



	// OPCIONES DEL MENU

	public void OpcionIntro(){
		GM.cambiarEstado(Estado.INTRO);
		Application.LoadLevel("Intro");
	}
	
	public void OpcionSalir(){
		Application.Quit();
	}

	public void OpcionSnake(){
		GM.cambiarEstado(Estado.JUEGO);
		Application.LoadLevel("JuegoSnake");
	}

	public void OpcionArkanoid(){
		GM.cambiarEstado(Estado.JUEGO);
		Application.LoadLevel("JuegoArkanoid");
	}

	public void OpcionPacman(){
		GM.cambiarEstado(Estado.JUEGO);
		Application.LoadLevel("JuegoPacMan");
	}

	public void OpcionTetris(){
		GM.cambiarEstado(Estado.JUEGO);
		Application.LoadLevel("JuegoTetris");
	}
}
