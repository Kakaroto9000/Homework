using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New TankData", menuName = "Tank Data", order = 51)]
public class TankParametrs : ScriptableObject
{
    public string TankName;
    public string Damage;
    public string Speed;
    public string Rotationspeed;
    public string Reload;
    public string cost;
}
