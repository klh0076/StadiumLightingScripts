using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SectionPanel : MonoBehaviour
{
    // values set from inspector
    public GameObject p;
    public GameObject m;
    public Color lightGrey;
    public Color white;
    public Color blue;
    public Color orange;
    public Color selectedC;
    public Button whiteBtn;
    public Button blueBtn;
    public Button orangeBtn;
    public Button unselectBtn;
    public Button loadBtn;
    public Button saveBtn;
    public Button exitBtn;
    public Button b;
    public GameObject pixelTemp;
    public Text sectionInfoText;

    public Image hideImage;

 // class variables
    public static byte[] currentValues;
    public static bool[] isSelected;
    public static int sectionType;
    public static int sectionSize;

    public static GameObject pixelTemps;
    public static Color lightGreyS;
    public static Color blueS;
    public static Color orangeS;
    public static Color whiteS;
    public static Color selectedS;
    // UI componets
    public static GameObject[] pixelObjs = new GameObject[299];
  
 
    void Start()
    {
        Debug.Log("P2 - Start start");
        b.onClick.AddListener(() => switchPanels());
        Debug.Log("P2 - Start end");
    }


    private void Awake()
    {
        Debug.Log("P2 - Awake Start");
        pixelTemps = pixelTemp;
        lightGreyS = lightGrey;
        blueS = blue;
        orangeS = orange;
        whiteS = white;
        selectedS = selectedC;
        sectionType = 1;
        sectionSize = 299;

        currentValues = new byte[299];
        isSelected = new bool[299];

        whiteBtn.onClick.AddListener(() => whiteClicked());
        blueBtn.onClick.AddListener(() => blueClicked());
        orangeBtn.onClick.AddListener(() => orangeClicked());
        unselectBtn.onClick.AddListener(() => unselectAll());
        loadBtn.onClick.AddListener(() => loadBoard());

        exitBtn.onClick.AddListener(() => exitClicked());
        saveBtn.onClick.AddListener(() => saveClicked());
        Debug.Log("P2 - Awake End");
    }

    public static void loadValues()
    {
        Debug.Log("P2 - Load Values");
        for (int i = 0; i < sectionSize; i++)
        {
            currentValues[i] = S.show.getTheValue(S.currentFrame, sectionType, i);
        }

    }

    public static void updateUI()
    {
        Debug.Log("P2 - Update UI");
        byte b;
        for (int i = 0; i < sectionSize; i++)
        {
            b = currentValues[i];
            switch (b)
            {
                case 0:
                    pixelObjs[i].GetComponent<Image>().color = lightGreyS;
                    break;
                case 1:
                    pixelObjs[i].GetComponent<Image>().color = whiteS;
                    break;
                case 2:
                    pixelObjs[i].GetComponent<Image>().color = blueS;
                    break;
                case 3:
                    pixelObjs[i].GetComponent<Image>().color = orangeS;
                    break;
            }
        } 
    }

    public void loadBoard()
    {
        Debug.Log("P2 - Load Board Start");
        loadBtn.interactable = false;
        sectionType = S.currentSection;
        
        

        if (sectionType == 2 || sectionType == 2 || sectionType == 7 || sectionType == 11 || sectionType == 12 || sectionType == 16)
        {
            Debug.Log("P2 - ");
            float px = -325;
            float py = -150;
            pixelObjs = new GameObject[299];
            sectionSize = 299;
            // 12
            for (int i = 1; i < 300; i++)
            {
                pixelObjs[i - 1] = Instantiate(pixelTemp);
                pixelObjs[i - 1].transform.SetParent(transform.Find("Panel"));
                pixelObjs[i - 1].transform.localPosition = new Vector3(px, py);
                pixelObjs[i - 1].transform.name = "" + (i - 1);
                pixelObjs[i - 1].GetComponent<Image>().color = lightGreyS;
                //DontDestroyOnLoad(leftSectionObjs[i - 1]);
                if (i % 23 == 0)
                {
                    px = -325;
                    py = py + 27;
                }
                else
                {
                    px = px + 26;
                }
            }
        }
        else if (sectionType == 4 || sectionType == 13)
        {
            Debug.Log("P2 - ");
            float px = 225;
            float py = -150;

            int pxs = 16;
            int count = 1;
            pixelObjs = new GameObject[286];
            sectionSize = 286;
            for (int i = 1; i < 287; i++)
            {
                pixelObjs[i - 1] = Instantiate(pixelTemp);
                pixelObjs[i - 1].transform.SetParent(transform.Find("Panel"));
                pixelObjs[i - 1].transform.localPosition = new Vector3(px, py);
                pixelObjs[i - 1].transform.name = "" + (i - 1);
                pixelObjs[i - 1].GetComponent<Image>().color = lightGreyS;

                if (count == pxs)
                {
                    pxs = pxs + 1;
                    count = 1;
                    px = 225;
                    py = py + 27;
                }
                else
                {
                    px = px - 26;
                    count++;
                }


            }
        }
        else if (sectionType == 1 || sectionType == 10)
        {
            Debug.Log("P2 - ");
            float px = -225;
            float py = -150;

            int pxs = 16;
            int count = 1;
            sectionSize = 286;
            pixelObjs = new GameObject[286];
            for (int i = 1; i < 287; i++)
            {
                pixelObjs[i - 1] = Instantiate(pixelTemp);
                pixelObjs[i - 1].transform.SetParent(transform.Find("Panel"));
                pixelObjs[i - 1].transform.localPosition = new Vector3(px, py);
                pixelObjs[i - 1].transform.name = "" + (i - 1);
                pixelObjs[i - 1].GetComponent<Image>().color = lightGreyS;

                if (count == pxs)
                {
                    pxs = pxs + 1;
                    count = 1;
                    px = -225;
                    py = py + 27;
                }
                else
                {
                    px = px + 26;
                    count++;
                }
            }
        }
        else if (sectionType == 8 || sectionType == 17)
        {
            Debug.Log("P2 - ");
            float px = 225;
            float py = -150;

            int pxs = 10;
            int count = 1;
            sectionSize = 208;
            pixelObjs = new GameObject[208];
            for (int i = 1; i < 209; i++)
            {
                pixelObjs[i - 1] = Instantiate(pixelTemp);
                pixelObjs[i - 1].transform.SetParent(transform.Find("Panel"));
                pixelObjs[i - 1].transform.localPosition = new Vector3(px, py);
                pixelObjs[i - 1].transform.name = "" + (i - 1);
                pixelObjs[i - 1].GetComponent<Image>().color = lightGreyS;

                if (count == pxs)
                {
                    pxs = pxs + 1;
                    count = 1;
                    px = 225;
                    py = py + 27;
                }
                else
                {
                    px = px - 26;
                    count++;
                }
            }
        }
        else if (sectionType == 6 || sectionType == 15)
        {
            Debug.Log("P2 - ");
            float px = -225;
            float py = -150;

            int pxs = 10;
            int count = 1;
            sectionSize = 208;
            pixelObjs = new GameObject[208];
            for (int i = 1; i < 209; i++)
            {
                pixelObjs[i - 1] = Instantiate(pixelTemp);
                pixelObjs[i - 1].transform.SetParent(transform.Find("Panel"));
                pixelObjs[i - 1].transform.localPosition = new Vector3(px, py);
                pixelObjs[i - 1].transform.name = "" + (i - 1);
                pixelObjs[i - 1].GetComponent<Image>().color = lightGreyS;

                if (count == pxs)
                {
                    pxs = pxs + 1;
                    count = 1;
                    px = -225;
                    py = py + 27;
                }
                else
                {
                    px = px + 26;
                    count++;
                }
            }
        }
        else if (sectionType == 20 || sectionType == 21 || sectionType == 24 || sectionType == 25)
        {
            Debug.Log("P2 - ");
            float px = -300;
            float py = -90;

            pixelObjs = new GameObject[207];
            sectionSize = 207;
            for (int i = 1; i < 208; i++)
            {
                pixelObjs[i - 1] = Instantiate(pixelTemp);
                pixelObjs[i - 1].transform.SetParent(transform.Find("Panel"));
                pixelObjs[i - 1].transform.localPosition = new Vector3(px, py);
                pixelObjs[i - 1].transform.name = "" + (i - 1);
                pixelObjs[i - 1].GetComponent<Image>().color = lightGreyS;

                if (i % 23 == 0)
                {
                    px = -300;
                    py = py + 27;
                }
                else
                {
                    px = px + 26;
                }
            }
        }
        else if (sectionType == 22 || sectionType == 23)
        {
            Debug.Log("P2 - ");
            float px = 125;
            float py = -100;

            int pxs = 6;
            int count = 1;
            sectionSize = 90;
            pixelObjs = new GameObject[90];
            for (int i = 1; i < 91; i++)
            {
                pixelObjs[i - 1] = Instantiate(pixelTemp);
                pixelObjs[i - 1].transform.SetParent(transform.Find("Panel"));
                pixelObjs[i - 1].transform.localPosition = new Vector3(px, py);
                pixelObjs[i - 1].transform.name = "" + (i - 1);
                pixelObjs[i - 1].GetComponent<Image>().color = lightGreyS;

                if (count == pxs)
                {
                    pxs = pxs + 1;
                    count = 1;
                    px = 125;
                    py = py + 27;
                }
                else
                {
                    px = px - 26;
                    count++;
                }
            }
        }
        else if (sectionType == 19 || sectionType == 26)
        {
            Debug.Log("P2 - ");
            float px = -200;
            float py = -100;

            int pxs = 6;
            int count = 1;
            sectionSize = 90;
            pixelObjs = new GameObject[90];
            for (int i = 1; i < 91; i++)
            {
                pixelObjs[i - 1] = Instantiate(pixelTemp);
                pixelObjs[i - 1].transform.SetParent(transform.Find("Panel"));
                pixelObjs[i - 1].transform.localPosition = new Vector3(px, py);
                pixelObjs[i - 1].transform.name = "" + (i - 1);
                pixelObjs[i - 1].GetComponent<Image>().color = lightGreyS;

                if (count == pxs)
                {
                    pxs = pxs + 1;
                    count = 1;
                    px = -200;
                    py = py + 27;
                }
                else
                {
                    px = px + 26;
                    count++;
                }
            }
        }

        loadValues();
        updateUI();
        hideImage.enabled = false;
        Debug.Log("P2 - Load Board end");
    }
    public void exitClicked()
    {
        Debug.Log("P2 - exit clicked");
        for (int i = 0; i < pixelObjs.Length; i++)
        {
            pixelObjs[i].SetActive(false);
            pixelObjs[i] = null;
        }
        loadBtn.interactable = true;
        hideImage.enabled = true;
    }
    public void unselectAll()
    {
        for (int i = 0; i < 289; i++)
        {
            isSelected[i] = false;
        }
        updateUI();
    }
    public void saveClicked()
    {
        Debug.Log("P2 - save clicked");
        for (int i = 0; i < sectionSize; i++)
        {
            S.show.setValue(S.currentFrame, sectionType, i, currentValues[i]);
        }
    }
    public  void whiteClicked()
    {
        Debug.Log("P2 - whtie clicked ");
        for (int i = 0; i < 289; i++)
        {
            if (isSelected[i] == true)
            {
                currentValues[i] = 1;
            }
        }
        updateUI();
        unselectAll();
    }
    public void blueClicked()
    {
        Debug.Log("P2 - blue clicked ");
        for (int i = 0; i < 289; i++)
        {
            if (isSelected[i] == true)
            {
                currentValues[i] = 2;
            }
        }
        updateUI();
        unselectAll();
    }
    public void orangeClicked()
    {
        Debug.Log("P2 - orange clicked ");
        for (int i = 0; i < 289; i++)
        {
            if (isSelected[i] == true)
            {
                currentValues[i] = 3;
            }
        }
        updateUI();
        unselectAll();
    }

    public static void clicked(int index)
    {
        Debug.Log("P2 - Clicked " + index);
        if (isSelected[index] == false)
        {
            isSelected[index] = true;
            pixelObjs[index].GetComponent<Image>().color = selectedS;
        }
        else
        {
            isSelected[index] = false;
            if (currentValues[index] == 1)
            {
                pixelObjs[index].GetComponent<Image>().color = whiteS;
            }
            else if (currentValues[index] == 2)
            {
                pixelObjs[index].GetComponent<Image>().color = blueS;
            }
            else if (currentValues[index] == 3)
            {
                pixelObjs[index].GetComponent<Image>().color = orangeS;
            }
            else
            {
                pixelObjs[index].GetComponent<Image>().color = lightGreyS;
            }
        }
    }

    public void switchPanels()
    {
        Debug.Log("P2 - Switch Panels start");
        exitClicked();
        p.SetActive(false);
        m.SetActive(true);
        S.reload();
        pixelObjs = null;
        loadBtn.interactable = true;

        Debug.Log("P2 - Switch Panels end");
    }
}
