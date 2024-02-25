using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Moves", menuName = "ScriptableObjects/Moves")]
public class Moves : ScriptableObject
{
    public string moveName;
    public int damage;
    public int PP;
    public IdolType type;
    public string moveDescription;
}