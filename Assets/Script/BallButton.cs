using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BallButton : MonoBehaviour, IPointerClickHandler
{
    public UIController Player;
    public int MYNum;

    private bool IsOnClicked = false;

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
}
