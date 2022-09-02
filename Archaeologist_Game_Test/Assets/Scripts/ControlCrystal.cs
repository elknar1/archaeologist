using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ControlCrystal : MonoBehaviour, IDragHandler, IDropHandler
{
    public Canvas canvas;
    RectTransform rect;
    public void Start()
    {
        rect = GetComponent<RectTransform>();
        canvas = GameObject.FindGameObjectWithTag("Canvas").GetComponent<Canvas>();
    }
    public void OnDrag(PointerEventData eventData)
    {
        rect.anchoredPosition += eventData.delta / canvas.scaleFactor;
        
    }
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log(this.gameObject.GetComponent<RectTransform>().anchoredPosition);
    }
}
