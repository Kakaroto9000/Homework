using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakeData : MonoBehaviour
{
    public Text nameTank;
    public Text damageTank;
    public Text tankSpeed;
    public Text speedRotahion;
    public Text reloadTime;
    public Text cost;
    public void OnMoused(TankParametrs TakenData)
    {
        nameTank.text = string.Format(TakenData.TankName);
        damageTank.text = string.Format(TakenData.Damage);
        tankSpeed.text = string.Format(TakenData.Speed);
        speedRotahion.text = string.Format(TakenData.Rotationspeed);
        reloadTime.text = string.Format(TakenData.Reload);
        cost.text = string.Format(TakenData.cost);
    }
}