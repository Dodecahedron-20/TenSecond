using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wires : MonoBehaviour
{
    RaycastHit hit;
    public GameObject[] wires;
    public GameObject[] cutWires;

    public LayerMask layerMask;


    //alex cross script parts
    [SerializeField]
    private TestingNumbers CutWire;

    //making a clip noise
    [SerializeField]
    private AudioSource ClipAudio = null;
    [SerializeField]
    private AudioSource sizzleAudio = null;


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
            Debug.Log("anything");

            if(Physics.Raycast(Camera.main.ScreenPointToRay (Input.mousePosition), out hit, Mathf.Infinity, layerMask))
            {
                if(hit.collider.tag == "RedWire")
                {
                    Debug.Log("mamma mia itsa bomb");
                    wires[0].SetActive(false);
                    cutWires[0].SetActive(true);
                    WireCut();

                }
                
                if(hit.collider.tag == "BlueWire")
                {
                    Debug.Log("blue bomb");
                    wires[1].SetActive(false);
                    cutWires[1].SetActive(true);
                    WireCut();

                }

                if(hit.collider.tag == "GreenWire")
                {
                    Debug.Log("green bomb");
                    wires[2].SetActive(false);
                    cutWires[2].SetActive(true);
                    WireCut();

                }

                if(hit.collider.tag == "YellowWire")
                {
                    Debug.Log("yellow bomb");
                    wires[3].SetActive(false);
                    cutWires[3].SetActive(true);
                    WireCut();


                }
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

    private void WireCut()
    {
        ClipAudio.Play();
        sizzleAudio.Play();
        CutWire.wiresLeftUI();

    }




}
