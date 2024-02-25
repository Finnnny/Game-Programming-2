using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IdolInfoView : MonoBehaviour
{
    public Idols idols;
    public GameObject idolInfoViewObj;

    private Sprite newSignatureSprite;
    private Sprite newPhotoSprite;
    private Image changeImg;


    [Header("Player Group Name")]
    public TextMeshProUGUI groupNameTMP;

    [Header("Basic Details")]
    public TextMeshProUGUI idolNameTMP;
    public TextMeshProUGUI levelTMP;
    public TextMeshProUGUI hpTMP;

    [Header("Idol Details")]
    public TextMeshProUGUI categoryTMP;
    public TextMeshProUGUI descriptionTMP;
    public TextMeshProUGUI typeTMP;

    [Header("Stats")]
    public TextMeshProUGUI vitTMP;
    public TextMeshProUGUI strTMP;
    public TextMeshProUGUI defTMP;
    public TextMeshProUGUI flexTMP;
    public TextMeshProUGUI agiTMP;
    public TextMeshProUGUI luckTMP;

    [Header("Idol Signature & Idol Photo")]
    public GameObject idolSignatureObj;
    public GameObject idolPhotoObj;


    public void OnEnable()
    {
        DisplayIdol(idols);
    }

    public void DisplayIdol(Idols idols)
    {
        groupNameTMP.text = idols.idolGroupName.ToString();
        idolNameTMP.text = idols.idolName.ToString();
        levelTMP.text = idols.level.ToString();
        hpTMP.text = idols.hp.ToString() + "/" + idols.hp.ToString();
        categoryTMP.text = idols.idolCategory.ToString();
        typeTMP.text = idols.idolType.ToString();

        switch (idols.idolCategory)
        {
            case (IdolCategory.Angel):
                descriptionTMP.text = "Invincible smile destroys the MEDIA... want to know her secret, MYSTERIOUS. Even her flaws are within her AREA, " +
                    "you, perfect and a liar, are like a genius IDOL!"; break;
            case (IdolCategory.NEET):
                descriptionTMP.text = "A girl who always stays at home. Not in Education, Employment or Training. Is there any hope for her at all?"; break;
            case (IdolCategory.Wildin):
                descriptionTMP.text = "Now here's someone who knows how to have fun! Burn, and burn brighter! Yahoo! Just don't check on her grades..."; break;
            case (IdolCategory.Suspicious):
                descriptionTMP.text = "Sneaking around in the undergound, there's no way she's actually an Idol... What's that in her pants!?"; break;
            case (IdolCategory.TrickTrackLover):
                descriptionTMP.text = "Everywhere she goes, she's dancing, singing, and being annoying. Is she ever going to stop? "; break;
            case (IdolCategory.Wallflower):
                descriptionTMP.text = "The kind of girl you see at the back of the classroom... Perhaps she's hiding a big secret."; break;
            case (IdolCategory.AmateurOtaku):
                descriptionTMP.text = "Maybe Amateur isn't the right word to describe her. Japanese culture is what she eats, sleeps. and breathes..."; break;
            default:
                break;
        }
        
        vitTMP.text = idols.vit.ToString();
        strTMP.text = idols.str.ToString();
        defTMP.text = idols.def.ToString();
        flexTMP.text = idols.flex.ToString();
        agiTMP.text = idols.agi.ToString();
        luckTMP.text = idols.luck.ToString();

        //Change to character BaseName? If so, create nickname attribute in idols, where Base name serves as the unique ID... or just change the theme from image to... feetpic or something
        changeImg = idolSignatureObj.GetComponent<Image>();
        newSignatureSprite = Resources.Load<Sprite>("TeamUI/IconSignatures/Sign" + idols.idolCategory.ToString());
        changeImg.sprite = newSignatureSprite;

        changeImg = idolPhotoObj.GetComponent<Image>();
        newPhotoSprite = Resources.Load<Sprite>("TeamUI/IconPhotocards/Photo" + idols.idolCategory.ToString());
        changeImg.sprite = newPhotoSprite;

    }

    public void ClearView()
    {
        idols = null;

        groupNameTMP.text = null;
        idolNameTMP.text = null;
        levelTMP.text = null;
        hpTMP.text = null;
        categoryTMP.text = null;
        descriptionTMP.text = null;
        typeTMP.text = null;
        vitTMP.text = null;
        strTMP.text = null;
        defTMP.text = null;
        flexTMP.text = null;
        agiTMP.text = null;
        luckTMP.text = null;

        newSignatureSprite = null;

    }
    public void OnDisable()
    {
        ClearView();
    }

}
