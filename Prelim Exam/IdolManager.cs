using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdolManager : MonoBehaviour
{
    public Idols[] idols;
    private string folderPath = "Characters"; // Folder name inside the Assets/Resources folder

    void Start()
    {
        idols = Resources.LoadAll<Idols>(folderPath);
    }
}
