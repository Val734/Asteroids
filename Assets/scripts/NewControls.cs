using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

using UnityEngine.Events;


public class NewControls : MonoBehaviour
{
    private InputPlayerActions ipa; 

    public Vector2 moveValue; 
    public UnityEvent PassShoot;

    public UnityEvent Shoot2; 
    

    private void Awake()
    {
        ipa=new InputPlayerActions(); 
        ipa.Player.Shoot.started+=OnShoot; 
        //ipa.Player.Move.performed+=OnMove; 
        ipa.Player.Move2.canceled +=OnStopMove; 

        ipa.Player.Move2.performed+=OnMove2; 

        ipa.Player.Shoot2.started+=OnShoot2; 

    }
    public void OnShoot2(InputAction.CallbackContext c)
    {
        Shoot2.Invoke();
    }

    public void OnShoot(InputAction.CallbackContext c)//permite leer el valor que devuelve del mando
    {
        PassShoot.Invoke();

        
    }

    private void OnStopMove(InputAction.CallbackContext c)
    {
        moveValue=Vector2.zero; 
    }

   private void OnMove2(InputAction.CallbackContext c) 
   {
       moveValue=c.ReadValue<Vector2>(); 
       

   }



    private void OnEnable()
    {
        ipa.Enable(); 
    }

    private void OnDisable()
    {
        ipa.Disable();
    }
}
