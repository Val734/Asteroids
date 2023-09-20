using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//anadir
using UnityEngine.Events;



public class HealthBehaviourScript : MonoBehaviour
{
    public UnityEvent OnDie;//Evento
    public UnityEvent<float> OnChangeHealth;//Evento
    public float CurrentHealth;
    public float MaxHealth;
    
    private void OnEnable()
    {
        CurrentHealth=MaxHealth;
        OnChangeHealth.Invoke(CurrentHealth);
    }

    public void Heal(float health)
        {
            CurrentHealth+=health;
            if(CurrentHealth>MaxHealth)
            {
                CurrentHealth=MaxHealth;
            }
        OnChangeHealth.Invoke(CurrentHealth);       
        }
    public void Hurt(float damage)
        {
            CurrentHealth-=damage;    
            if(CurrentHealth<=0)
            {
                OnDie.Invoke();//Avisar de que llega a 0
                CurrentHealth=0;
            }
        OnChangeHealth.Invoke(CurrentHealth);
        }
    public float GetHealth()
    {
        return CurrentHealth;
    }
}

