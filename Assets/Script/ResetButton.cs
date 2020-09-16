using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ResetButton : MonoBehaviour ,IPointerClickHandler
{
    [SerializeField]
    private Baseballmanager manager = new Baseballmanager();

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
