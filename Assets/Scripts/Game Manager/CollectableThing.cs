using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableThing : MonoBehaviour
{
    //public GameObject gameManager;
    public StaticVariables statVars;
    public int objectiveNumber; // Set this between 0 and the last objective index
    public bool showOnHud;
    public Text HUDText;
    public bool imageIndicator;
    public Image HUDImage;
    
    // Start is called before the first frame update
    void Start()
    {
        //gameManager = GameObject.FindGameObjectWithTag("GameManager");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            statVars.objectiveSet[objectiveNumber] = true;
            if (showOnHud)
            {
                if (!imageIndicator)
                {
                    if (HUDText.gameObject.activeSelf == false)
                    {
                        HUDText.gameObject.SetActive(true);
                    }
                    else
                    {
                        HUDText.gameObject.SetActive(false);
                    }
                }
                else
                {
                    if (HUDImage.gameObject.activeSelf == false)
                    {
                        HUDImage.gameObject.SetActive(true);
                    }
                    else
                    {
                        HUDImage.gameObject.SetActive(false);                   }

                }
            }
            Destroy(gameObject);
        }
    }
}
