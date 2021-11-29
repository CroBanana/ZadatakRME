using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RightClick : MonoBehaviour, IPointerClickHandler
{
    public GameObject text;
    //public GameObject AppleText;
    //public GameObject BananaText;
    //public GameObject OrangeText;
    //public GameObject WatermalonText;

    public void OnPointerClick(PointerEventData eventData)
    {
      
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            //if (gameObject.name == "Apple")
            //{
            //    AppleText.SetActive(true);
            //}
            //if (gameObject.name == "Banana")
            //{
            //    BananaText.SetActive(true);
            //}
            //if (gameObject.name == "Orange")
            //{
            //    OrangeText.SetActive(true);
            //}
            //if (gameObject.name == "Watermalon")
            //{
            //    WatermalonText.SetActive(true);
            //}
            text.SetActive(true);
        }
          
    }
}
