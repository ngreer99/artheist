using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArtCount : MonoBehaviour
{
    public Image firstArt;
    public GameObject ArtPanel;
    public Image[] ArtImages;
    private int ArtVisible;
    private static ArtCount instance;
    // Start is called before the first frame update
    /*
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    */
    void Awake()
    {
        instance = this;
    }

    public static void SetCount(int art)
    {
        instance._SetCount(art);
    }

    public static void RemoveArt()
    {
        instance._RemoveArt();
    }

    private void _SetCount(int art)
    {
        RectTransform panelRT = ArtPanel.GetComponent<RectTransform>();
        panelRT.sizeDelta = new Vector2(14 + art * 18, panelRT.sizeDelta.y);
        ArtImages = new Image[art];
        ArtImages[0] = firstArt;
        for (int i = 1; i < art; i++)
        {
            GameObject newArtObj = Instantiate(firstArt.gameObject, panelRT) as GameObject;
            ArtImages[i] = newArtObj.GetComponent<Image>();
            RectTransform artRT = newArtObj.GetComponent<RectTransform>();
            RectTransform firstHeartRT = firstArt.GetComponent<RectTransform>();
            artRT.anchorMax = firstHeartRT.anchorMax;
            artRT.anchorMin = firstHeartRT.anchorMin;
            artRT.anchoredPosition = firstHeartRT.anchoredPosition;
            artRT.sizeDelta = firstHeartRT.sizeDelta;
            artRT.localPosition = new Vector3(firstHeartRT.localPosition.x + 18 * i, firstHeartRT.localPosition.y, firstHeartRT.localPosition.z);
        }
        ArtVisible = art;
    }

    private void _RemoveArt()
    {
        ArtVisible--;
        if (ArtVisible >= 0)
        {
            ArtImages[ArtVisible].enabled = false;
        }
    }
}
