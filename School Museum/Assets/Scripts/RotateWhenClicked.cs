using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWhenClicked : MonoBehaviour {

    bool clickedBefore = false;

    public void ClickedButtonToRotate(float angle)
    {
        if (!clickedBefore)
        {
            StartCoroutine(RotateMePlease(angle));
            clickedBefore = true;
        }      
    }

    IEnumerator RotateMePlease(float angle)
    {
        while (transform.eulerAngles.y <= angle) 
        {
            Debug.Log(transform.eulerAngles);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, angle)), 0.01f);
            yield return null;
        }
    }
}
