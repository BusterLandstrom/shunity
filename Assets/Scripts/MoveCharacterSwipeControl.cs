using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveCharacterSwipeControl : MonoBehaviour
{
    private float move;

    public CharacterController2D character;

    private float x1;
    private float x2;

    void Update()
    {
        if(Input.GetTouch(0).phase == TouchPhase.Began){
            x1 = Input.mousePosition.x;

        } else if(Input.GetTouch(0).phase == TouchPhase.Ended){
            x2 = Input.mousePosition.x;

            if(x1 > x2){
                move = -1f;
                character.Move(move);
            } else if(x1 < x2){
                move = 1f;
                character.Move(move);
            }
        }
    }
}
