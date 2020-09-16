using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Button : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerExitHandler, IPointerUpHandler
{
    public UIController Player = new UIController();
    [SerializeField]
    private int MYNum = 0;
    bool IsOnClicked = false;

    public void OnPointerUp(PointerEventData eventData)
    {

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (IsOnClicked == true)
        {
            Player.DisCount();
            Player.DeleteNumber(MYNum);
            Debug.Log(MYNum + "discount");
            IsOnClicked = false;
        }

        else
        {
            if (Player.ButtonManage())
            {
                Player.ClickCount();
                Player.GetNumber(MYNum);
                Debug.Log(MYNum + "added");
                IsOnClicked = true;
            }
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
    }

    public void OnPointerExit(PointerEventData eventData)
    {
    }

    void Update()
    {
        
    }
}
