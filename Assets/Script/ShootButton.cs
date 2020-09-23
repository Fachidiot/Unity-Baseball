using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShootButton : MonoBehaviour, IPointerClickHandler
{
    public UIController player;
    public Baseballmanager manager;

    public void OnPointerClick(PointerEventData eventData)
    {
        player.SendNum();
    }
}
