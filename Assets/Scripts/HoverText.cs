using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverText : MonoBehaviour
{
    public GameObject Hovertext;
    // Start is called before the first frame update
    void Start()
    {
        Hovertext.SetActive(false);
    }

    public void OnMouseOver()
    {
        Hovertext.SetActive(true);
    }
    public void OnMouseExit()
    {
        Hovertext.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButton(0))
        //{
        //    Hovertext.SetActive(true);
        //}
    }
}
