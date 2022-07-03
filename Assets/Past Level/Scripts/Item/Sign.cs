using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sign : MonoBehaviour
{
    GameObject tip;
    Text text;
    public string s;

    void Start()
    {
        tip = GameObject.Find("Canvas").transform.Find("Tip").gameObject;
        text = tip.GetComponentInChildren<Text>();
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            text.text = s.Replace("\\n", "\n");
            tip.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            text.text = "";
            tip.SetActive(false);
        }
    }
}
