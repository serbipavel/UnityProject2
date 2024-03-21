using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRay : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform pointer;
    public Transform player;
    public MySelectable previousSelected;

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(player.transform.position+new Vector3(0,1.5f,0), transform.forward);
        Debug.DrawRay(player.transform.position + new Vector3(0, 1.5f, 0), transform.forward * 100, Color.red);
        
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            pointer.position = hit.point;
            /* hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.yellow;*/
            MySelectable selectable = hit.collider.gameObject.GetComponent<MySelectable>();
            if (previousSelected && previousSelected != selectable)

            {
                previousSelected.Deselect();
                previousSelected = null;
            }
            if (selectable)
            {
                previousSelected = selectable;
                selectable.Select();


                if (Input.GetMouseButtonDown(0)) // ��������� ������� ����� ������ ����
                {

                    GameObject objectHit = hit.transform.gameObject;
                    Destroy(objectHit); // ������� ������

                }
            }
        }
        else if (previousSelected)
        {
            previousSelected.Deselect();
            previousSelected = null;
        }
    }
}
