using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screws : MonoBehaviour
{
    RaycastHit hit;

    public GameObject[] screws;
    public GameObject cover;
    bool allActive = true;

    //alex testing
    private int screwsleft = 4;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity))
            {
                if(hit.collider.tag == "Screw1")
                {
                    screws[0].SetActive(false);
                    dropscrews();
                }

                if (hit.collider.tag == "Screw2")
                {
                    screws[1].SetActive(false);
                    dropscrews();
                }

                if (hit.collider.tag == "Screw3")
                {
                    screws[2].SetActive(false);
                    dropscrews();
                }

                if (hit.collider.tag == "Screw4")
                {
                    screws[3].SetActive(false);
                    dropscrews();
                }
            }
        }
    }

    private void dropscrews()
    {
        screwsleft--;
        if (screwsleft == 0)
        {
            cover.SetActive(false);
        }
    }
}
