using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARCursor : MonoBehaviour
{
    public GameObject cursorChildObject;
    public ARRaycastManager raycastManager;
    public bool useCursor = true;
    private SelectTree selectTree;

    void Start()
    {
        cursorChildObject.SetActive(useCursor);
        selectTree = GameObject.FindObjectOfType<SelectTree>();
        selectTree.MenuButtonOpen();
    }

    // Update is called once per frame
    void Update()
    {
        if (useCursor)
        {
            updateCursor();
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            if (useCursor)
            {
                GameObject.Instantiate(selectTree.xxx, transform.position, transform.rotation);
            } else
            {
                List<ARRaycastHit> hits = new List<ARRaycastHit>();
                raycastManager.Raycast(Input.GetTouch(0).position, hits, TrackableType.Planes);
                if(hits.Count > 0)
                {
                    GameObject.Instantiate(selectTree.xxx, hits[0].pose.position, hits[0].pose.rotation);
                }
            }
        }
    }

    void updateCursor()
    {
        Vector2 screenPosition = Camera.main.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        raycastManager.Raycast(screenPosition, hits, TrackableType.Planes);

        if(hits.Count > 0)
        {
            transform.position = hits[0].pose.position;
            transform.rotation = hits[0].pose.rotation;
        }
    }
}
