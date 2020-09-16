using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShootButton : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerExitHandler
{
    public UIController player = new UIController();
    public Baseballmanager manager = new Baseballmanager();

    public void OnPointerClick(PointerEventData eventData)
    {
        player.SendNum();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
    }

    public void OnPointerExit(PointerEventData eventData)
    {
    }
}
