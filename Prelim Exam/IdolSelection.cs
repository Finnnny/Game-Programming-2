using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class IdolSelection : MonoBehaviour
{
    public IdolManager idolManager;
    public Transform parentPos;
    public GameObject idolCharacterPrefab;
    public IdolInfoView idolInfoView;

    void Start()
    {
        float posX;
        float idolCount = 0;

        foreach (Idols i in idolManager.idols)
        {
            GameObject buttonPrefab = Instantiate(idolCharacterPrefab, parentPos);
            
            IdolCharacterButton idolCharacterButton = buttonPrefab.GetComponent<IdolCharacterButton>();
            idolCharacterButton.SetIdolData(i);

            Button button = buttonPrefab.GetComponent<Button>();
            button.onClick.AddListener(() => idolInfoView.DisplayIdol(i));

            posX = idolCount * 400;

            idolCharacterButton.transform.localPosition = idolCharacterButton.transform.localPosition + new Vector3(posX, 0, 0);
            idolCount++;
        }
    }
}