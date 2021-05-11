using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Option2QuestManager : MonoBehaviour
{
    void Start()
    {
        
    }


    public void OnTouchDown(BaseEventData eventData)
    {

        Debug.Log("OnTouchDown");
      
    }

    public void OnMove()
    {
        Debug.Log("OnMove");
    }

    public void OnRelease()
    {
        Debug.Log("OnRelease");
    }
}
