using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Declaramos los estados del juego
public enum GameState{Ready, Playing, Ended};
//Este Script nos permite llamar funciones y que se ejecuten controladamente 
public class GameManager : MonoBehaviour

{
    //Variables que se ven afectadas dependiendo del estado del juego
    public GameState gameState = GameState.Ready;
    public bool Vivos,Activador;
    public bool ejecucion = true;
    void Update()
    {   
        //Cambiar el estado de juego, aca pasamos de ready a playing
        bool action = Input.GetKeyDown(KeyCode.Space);
        UpdateGameState(action);
         if(gameState == GameState.Playing){
             MyCamera1.Instance.Camara(1);

             //Condicion que activa la animacion de la primera vez
            if (ejecucion){
            StartCoroutine(Tiempo());
                if(Activador==true){
                    Animaciones.Instance.Animacion("preparacionPj1");
                    Activador=false;
                    ejecucion=false;
                }
            }
        }
        
    }
    //Funcion que cambia el estado del juego
    void UpdateGameState(bool action){
        if(gameState == GameState.Ready && action){
            gameState = GameState.Playing;
            Vivos=true;
        }
    }
    //Funcion que temporiza el tiempo de la primera animacion
    IEnumerator Tiempo()
    {
        yield return new WaitForSeconds(3);
        Activador=true;
    }        
}
