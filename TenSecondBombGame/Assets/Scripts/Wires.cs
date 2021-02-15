using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wires : MonoBehaviour
{
    RaycastHit hit;
    public GameObject[] wires;
    public GameObject[] cutWires;

    int RedWire;
    int BlueWire;
    int GreenWire;
    int YellowWire;

    void Start()
    {
        for(int i =0; i < cutWires.Length; i++)
        {
            cutWires[i].SetActive(false);
        }
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(Camera.main.ScreenPointToRay (Input.mousePosition), out hit, Mathf.Infinity, RedWire))
            {
                Debug.Log("Red Wire Pressed");
                wires[1].SetActive(false);
                cutWires[1].SetActive(true);
            }

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity, BlueWire))
            {
                Debug.Log("Blue Wire Pressed");
                wires[2].SetActive(false);
                cutWires[2].SetActive(true);
            }

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity, GreenWire))
            {
                Debug.Log("Green Wire Pressed");
                wires[3].SetActive(false);
                cutWires[3].SetActive(true);
            }

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity, YellowWire))
            {
                Debug.Log("Yellow Wire Pressed");
                wires[4].SetActive(false);
                cutWires[4].SetActive(true);
            }
        }
    }

    //private void OnMouseEnter()
    //{
    //    //Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    //    CursorController.Instance.SetWireCursor();
    //}

    //private void OnMouseExit()
    //{
    //    //Cursor.SetCursor(null, Vector2.zero, cursorMode);
    //    CursorController.Instance.SetDefaultCursor();
    //}
}
