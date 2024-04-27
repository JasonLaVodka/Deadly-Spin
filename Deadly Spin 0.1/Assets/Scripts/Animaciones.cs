using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Codigo de animacion del arma
public class Animaciones : MonoBehaviour
{
        public static Animaciones Instance {get ;private set;}

    void Awake() {
        Instance = this;
    }
    private Animator mAnimator;
    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }
    public void Animacion(string Animacion)
    {
        /*Esta Funcion es para ejecutar las animaciones  nesecita trabajo se puede activar la 
         animacion antes de tiempo es posible a futuros cambios sea eliminada*/

     if (mAnimator != null)

        {
            //Condiciones para que cada animacion se ejecute respectivamente
            if (Animacion=="preparacionPj1")
                {
                mAnimator.SetTrigger("Prep Pj1");
                
                }
            if (Animacion=="shootYouPj1") 
                {
                mAnimator.SetTrigger("ShootYouPj1");
                }
            if (Animacion=="preparacionPj2")
                {
                mAnimator.SetTrigger("PrepPj2");
                }
            if (Animacion=="shootYouPj2")
                {
                mAnimator.SetTrigger("ShootYouPj2");
                }
            if (Animacion=="shootHePj")
                {
                mAnimator.SetTrigger("ShootHePj1");
                }
            if (Animacion=="shootHePj")
            {
                mAnimator.SetTrigger("ShootHePj2");
            }
        }
    
    }
}
