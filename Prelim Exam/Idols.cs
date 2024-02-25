using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
[CreateAssetMenu(fileName = "Idols", menuName = "ScriptableObjects/Idols")]
public class Idols : ScriptableObject
{
    [Header("Player Group Name")]
    public string idolGroupName;

    [Header("Basic Details")]
    public string idolName;
    public int level;
    public int hp;

    [Header("Idol Details")]
    public IdolCategory idolCategory;
    public IdolType idolType;
    public Moves[] moves;

    [Header("Stats")]
    public int vit;
    public int str;
    public int def;
    public int flex;
    public int agi;
    public int luck;

    public void Attack()
    {
        Debug.Log($"{name} use Trendy Song!");
    }



}
