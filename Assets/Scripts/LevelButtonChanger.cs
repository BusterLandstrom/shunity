using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class LevelButtonChanger : MonoBehaviour
{
    public TMP_Text L1;
    public TMP_Text L2;
    public TMP_Text L3;
    public TMP_Text L4;
    public TMP_Text L5;
    public TMP_Text L6;
    public TMP_Text L7;
    public TMP_Text L8;
    public TMP_Text L9;
    public TMP_Text L10;
    public TMP_Text BackText;
    public TMP_Text LevelSelect;

    public TMP_FontAsset FontA;
    public TMP_FontAsset FontB;

    public Material FontMaterialA;
    public Material FontMaterialB;
    
    private bool doodie;

    void Start(){
        doodie = true;
        StartCoroutine(Change());
    }

    IEnumerator Change()
    {
        while (doodie == true){

        L1.font = FontA;
        L1.fontSharedMaterial = FontMaterialA;
        L2.font = FontA;
        L2.fontSharedMaterial = FontMaterialA;
        L3.font = FontA;
        L3.fontSharedMaterial = FontMaterialA;
        L4.font = FontA;
        L4.fontSharedMaterial = FontMaterialA;
        L5.font = FontA;
        L5.fontSharedMaterial = FontMaterialA;
        L6.font = FontA;
        L6.fontSharedMaterial = FontMaterialA;
        L7.font = FontA;
        L7.fontSharedMaterial = FontMaterialA;
        L8.font = FontA;
        L8.fontSharedMaterial = FontMaterialA;
        L9.font = FontA;
        L9.fontSharedMaterial = FontMaterialA;
        L10.font = FontA;
        L10.fontSharedMaterial = FontMaterialA;
        BackText.font = FontA;
        BackText.fontSharedMaterial = FontMaterialA;
        LevelSelect.font = FontA;
        LevelSelect.fontSharedMaterial = FontMaterialA;
        
 
        yield return new WaitForSeconds(Random.Range(0.6f, 1f));
 
        L1.font = FontB;
        L1.fontSharedMaterial = FontMaterialB;
        L2.font = FontB;
        L2.fontSharedMaterial = FontMaterialB;
        L3.font = FontB;
        L3.fontSharedMaterial = FontMaterialB;
        L4.font = FontB;
        L4.fontSharedMaterial = FontMaterialB;
        L5.font = FontB;
        L5.fontSharedMaterial = FontMaterialB;
        L6.font = FontB;
        L6.fontSharedMaterial = FontMaterialB;
        L7.font = FontB;
        L7.fontSharedMaterial = FontMaterialB;
        L8.font = FontB;
        L8.fontSharedMaterial = FontMaterialB;
        L9.font = FontB;
        L9.fontSharedMaterial = FontMaterialB;
        L10.font = FontB;
        L10.fontSharedMaterial = FontMaterialB;
        BackText.font = FontB;
        BackText.fontSharedMaterial = FontMaterialB;
        LevelSelect.font = FontB;
        LevelSelect.fontSharedMaterial = FontMaterialB;
        

        yield return new WaitForSeconds(Random.Range(0.6f, 1f));
        }
    }
}
