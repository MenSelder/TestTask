using System;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    // info holder ...

    Type collideType = typeof(DataBase);
    private Transform selectedObjct = null;

    private void Update()
    {
        var cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;
        if (!Physics.Raycast(cameraRay, out hit))
            return;


        if (selectedObjct == null)
        {
            if (hit.collider != null && hit.transform.gameObject.TryGetComponent(collideType, out Component component))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    selectedObjct = hit.transform; //change it...
                    Debug.Log("+++");
                }
            }
        }

        if (Input.GetMouseButtonUp(0) && selectedObjct != null)
        {
            selectedObjct = null;
            Debug.Log("---");
        }
    }
}
