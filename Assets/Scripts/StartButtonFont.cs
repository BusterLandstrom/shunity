using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartButtonFont : MonoBehaviour
{
    public TMP_Text startText;
    public TMP_Text creditsText;
    public TMP_Text exitText;
    public TMP_Text backText;
    public TMP_Text titleText;
    public TMP_Text ccText;
    
    public TMP_FontAsset FontA;
    public TMP_FontAsset FontB;

    public Material FontMaterialA;
    public Material FontMaterialB;
    
    private bool doode;

    void Start(){
        doode = true;
        StartCoroutine(Change());
    }

    IEnumerator Change()
    {
        while (doode == true){

        startText.font = FontA;
        startText.fontSharedMaterial = FontMaterialA;
        creditsText.font = FontA;
        creditsText.fontSharedMaterial = FontMaterialA;
        exitText.font = FontA;
        exitText.fontSharedMaterial = FontMaterialA;
        backText.font = FontA;
        backText.fontSharedMaterial = FontMaterialA;
        titleText.font = FontA;
        titleText.fontSharedMaterial = FontMaterialA;
        ccText.font = FontA;
        ccText.fontSharedMaterial = FontMaterialA;
 
        yield return new WaitForSeconds(Random.Range(0.6f, 1f));
 
        startText.font = FontB;
        startText.fontSharedMaterial = FontMaterialB;
        creditsText.font = FontB;
        creditsText.fontSharedMaterial = FontMaterialB;
        exitText.font = FontB;
        exitText.fontSharedMaterial = FontMaterialB;
        backText.font = FontB;
        backText.fontSharedMaterial = FontMaterialB;
        titleText.font = FontB;
        titleText.fontSharedMaterial = FontMaterialB;
        ccText.font = FontB;
        ccText.fontSharedMaterial = FontMaterialB;

        yield return new WaitForSeconds(Random.Range(0.6f, 1f));
        }
    }
}
