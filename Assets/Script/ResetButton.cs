using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ResetButton : MonoBehaviour ,IPointerClickHandler
{
    public Baseballmanager manager;

    public void Active()
    {
        gameObject.active = true;
    }

    void Start()
    {
        gameObject.active = false;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Reset();
    }

    private void Reset()
    {
        manager.reset();

        gameObject.active = false;
    }
}
