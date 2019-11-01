using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class JoystickScript : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler 
{
   public Image space , bg, joystick;
   public Vector3  InputDirection { set ; get ;}
    Vector2 pos;


    void Start()
    {
        InputDirection = Vector3.zero;
       

    }


    public virtual void OnDrag(PointerEventData ped)
    {
        
       
        pos = Vector2.zero;

      

        if(RectTransformUtility.ScreenPointToLocalPointInRectangle(bg.rectTransform , ped.position , ped.pressEventCamera, out pos))
        {
         
            pos.x /= bg.rectTransform.sizeDelta.x;    // to get ratios b/w pointer pos on recttransform and size of recttransform
            pos.y /= bg.rectTransform.sizeDelta.y;


            float x = (bg.rectTransform.pivot.x == 1) ? pos.x * 2 + 1 : pos.x * 2 - 1;
            float y = (bg.rectTransform.pivot.y == 1) ? pos.y * 2 + 1 : pos.y * 2 - 1;

            InputDirection = new Vector3(x, 0, y);

            InputDirection = (InputDirection.magnitude > 1) ? InputDirection.normalized : InputDirection;



           joystick.rectTransform.anchoredPosition = new Vector3(InputDirection.x * (bg.rectTransform.sizeDelta.x/3),
          InputDirection.z * (bg.rectTransform.sizeDelta.y / 3) );

            bg.rectTransform.position = new Vector2(ped.position.x + bg.rectTransform.sizeDelta.x/2, ped.position.y + bg.rectTransform.sizeDelta.y / 2);

        }


    }
   
    public virtual void OnPointerDown(PointerEventData ped)
    {
        float posy = ped.position.y + bg.rectTransform.sizeDelta.y/2  ;
        float posx = ped.position.x + bg.rectTransform.sizeDelta.x / 2;
  
        bg.rectTransform.position = new Vector2(posx , posy);




      
    }
    public virtual void OnPointerUp(PointerEventData ped)
    {
        InputDirection = Vector3.zero;
        joystick.rectTransform.anchoredPosition = Vector2.zero;
    }



}
