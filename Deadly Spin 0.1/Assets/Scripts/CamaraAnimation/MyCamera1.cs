using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCamera1 : MonoBehaviour
{
    public static MyCamera1 Instance {get ;private set;}

    void Awake() {
        Instance = this;
    }
    //Variables de tiempo de movimiento de la camara
    public float TimeToMove;
    public float Timer;
    private bool IsAnimation=false;
    //Variables de movimiento de la camara
    public Transform [] Views;
    public float TransitionSpeed;
    Transform CurrentView;
    bool IsTurn = true;
    void Start()
    {
        CurrentView = transform;
    }
    void Update()
    {
        /*En caso de que se requiera una animacion especifica
         se que quita los compentarios de la parte que se vaya a usar*/
        //Condicion para cambio de la Perspectiva
        //Primera Perspectiva
        /*if (Input.GetKeyDown(KeyCode.G))
        {
            CurrentView=Views[0];
        }
        //Segunda Perspectiva
          if (Input.GetKeyDown(KeyCode.Y))
        {
            CurrentView=Views[1];
        }
        //Tercera Perspectiva
          if (Input.GetKeyDown(KeyCode.O))
        {
            CurrentView=Views[2];
        }
        //Cuarta Perspectiva
          /*if (Input.GetKeyDown(KeyCode.D))
        {
            CurrentView=Views[3];
        }
        if (IsTurn){
            CurrentView = Views[1];
        }   
        else{
            CurrentView = Views[2];
        }
         if(Input.GetMouseButtonDown(0)){
            IsTurn=!IsTurn;
        }
        if(Input.GetMouseButtonDown(0) &&! IsAnimation){
            IsAnimation = true;
            Timer = 0f;
        }*/

    }

    //Movimiento de la camara
    private void LateUpdate() {
        //Movimiento lineal
        transform.position = Vector3.Lerp(transform.position, CurrentView.position, Time.deltaTime*TransitionSpeed);

        Vector3 CurrentAngle = new Vector3(
            //Rotacion en el eje X
            Mathf.Lerp(transform.rotation.eulerAngles.x, CurrentView.transform.rotation.eulerAngles.x, Time.deltaTime*TransitionSpeed),
            //Rotacion en el eje Y
            Mathf.Lerp(transform.rotation.eulerAngles.y, CurrentView.transform.rotation.eulerAngles.y, Time.deltaTime*TransitionSpeed),
            //Rotacion en el eje Z
            Mathf.Lerp(transform.rotation.eulerAngles.z, CurrentView.transform.rotation.eulerAngles.z, Time.deltaTime*TransitionSpeed)
        );
        transform.eulerAngles = CurrentAngle;   
    }
    //Funcion de movimiento de la camara
    //Se hace esta funcion para ser llamada en el game manager
    public void Camara(int Vista){

        if(Vista==0){
        CurrentView=Views[0];
        }
        if(Vista==1){
        CurrentView=Views[1];
        }
        if(Vista==2){
        CurrentView=Views[2];
        }
    }
}
