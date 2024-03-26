using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class PointerAction : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool pointerDown = false;
    Vector3 startPosition;

    public UnityEvent OnTapLeft, OnTapRight;

    void Update()
    {
        if (pointerDown)
        {
            if (startPosition.x < Screen.width / 2) OnTapLeft?.Invoke();
            else OnTapRight?.Invoke();
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        pointerDown = true;
        startPosition = Input.mousePosition;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pointerDown = false;
        startPosition = Vector3.zero;
    }
}
