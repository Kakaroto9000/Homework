using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeData : MonoBehaviour
{
    public TankParametrs TakenData;
    public void OnMouseDown()
    {
        Debug.Log(TakenData.TankName); 
        Debug.Log(TakenData.Damage);
        Debug.Log(TakenData.Speed);
        Debug.Log(TakenData.Rotationspeed);
        Debug.Log(TakenData.Reload);
        Debug.Log(TakenData.cost);
    }
}