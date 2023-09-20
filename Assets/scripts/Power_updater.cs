using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 


public class Power_updater : MonoBehaviour
{
    public int power; 
    public static event Action<int> OnUpdatepower=delegate{};

    public void Updatepower()
    {
        OnUpdatepower.Invoke(power);
    }
}