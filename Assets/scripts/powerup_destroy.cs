using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class powerup_destroy : MonoBehaviour
{
   
    public int power;
    public UnityEvent<int> OnChangepower;

    private void OnEnable()
    {
        Power_updater.OnUpdatepower += Addpower;
    }

    private void OnDisable()
    {
        Power_updater.OnUpdatepower -= Addpower;
    }

    private void Start()
    {
        power = 0;
    }

    public void Addpower(int d)
    {
        power += d;
        OnChangepower.Invoke(power);
    }

    public void Resetpower()
    {
        power = 0;
        OnChangepower.Invoke(power);
    }
}
