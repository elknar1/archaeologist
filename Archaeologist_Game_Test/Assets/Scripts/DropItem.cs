using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropItem : MonoBehaviour, IDropHandler
{
    public Text text;
    int count = 0;
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag!= null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            count++;
            text.text = count.ToString();
        }
    }
}
