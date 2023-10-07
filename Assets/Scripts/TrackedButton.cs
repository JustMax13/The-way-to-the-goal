using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TrackedButton : Button
{
    public Action IsOnPointerClick;
    public Action IsOnPointerDown;
    public Action IsOnPointerEnter;
    public Action IsOnPointerExit;
    public Action IsOnPointerUp;

    public override void OnPointerClick(PointerEventData eventData)
    {
        base.OnPointerClick(eventData);
        IsOnPointerClick?.Invoke();
    }
    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
        IsOnPointerDown?.Invoke();
    }
    public override void OnPointerEnter(PointerEventData eventData)
    {
        base.OnPointerEnter(eventData);
        IsOnPointerEnter?.Invoke();
    }
    public override void OnPointerExit(PointerEventData eventData)
    {
        base.OnPointerExit(eventData);
        IsOnPointerExit?.Invoke();
    }
    public override void OnPointerUp(PointerEventData eventData)
    {
        base.OnPointerUp(eventData);
        IsOnPointerUp?.Invoke();
    }
}
