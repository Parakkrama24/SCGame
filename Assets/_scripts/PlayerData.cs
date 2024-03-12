using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New PlayerData",menuName ="Player Data")]
public class PlayerData : ScriptableObject
{
    public int PlayerId;
    public int MaxHealth;
    public int Power;
    public int Cost;
    public int defence;
    public int Agility;
}
