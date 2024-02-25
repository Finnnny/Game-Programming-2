using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class IdolCharacterButton : MonoBehaviour
{
    public TextMeshProUGUI idolNameTxt;
    public TextMeshProUGUI hpText;

    public IdolManager idolManager;

    public GameObject idolTypeObj;
    public GameObject idolCategoryObj;
    public Image imageType,imageCategory;
    public Sprite newSpriteType, newSpriteCategory;

    public void SetIdolData(Idols unit)
    {
        idolNameTxt.text = unit.idolName;
        hpText.text = "HP: " + unit.hp.ToString();

        imageType = idolTypeObj.GetComponent<Image>();
        imageCategory = idolCategoryObj.GetComponent<Image>();
        ChangeSprite(unit);

    }

    public void ChangeSprite(Idols unit)
    {
        newSpriteType = Resources.Load<Sprite>("TeamUI/IconTypes/Icon" + unit.idolType.ToString());
        imageType.sprite = newSpriteType;
        newSpriteCategory = Resources.Load<Sprite>("TeamUI/IconCategory/" + unit.idolCategory.ToString());
        imageCategory.sprite = newSpriteCategory;
    }
}
