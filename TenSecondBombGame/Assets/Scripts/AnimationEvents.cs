using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEvents : MonoBehaviour
{

    [SerializeField]
    private GameObject Explode = null;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   


    public void EndExplosion()
    {
        Explode.SetActive(false);
     
    }





}
