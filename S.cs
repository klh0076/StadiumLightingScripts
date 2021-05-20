using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;


public class S : MonoBehaviour
{
// **************************************
//      Feilds that must be assigned in inspector

// Panels / canvas / pixels
    public Canvas cv;
    public GameObject p1TempPixel;
    public GameObject frameIndicatorInit;
    public GameObject panel2;
    public GameObject panel1;
    // Buttons
    public Button b1;
    public Button b2;
    public Button b3;
    public Button b4;
    public Button b6;
    public Button b7;
    public Button b8;
    public Button b10;
    public Button b11;
    public Button b12;
    public Button b13;
    public Button b15;
    public Button b16;
    public Button b17;
    public Button b19;
    public Button b20;
    public Button b21;
    public Button b22;
    public Button b23;
    public Button b24;
    public Button b25;
    public Button b26;
    public Button whiteBtn;
    public Button blueBtn;
    public Button orangeButton;
    public Button clearBtn;
    public Button SaveFrameBtn;
    public Button prevFrameBtn;
    public Button nextBtn;
    public Button copyToNextBtn;
    public Button selectAllBtn;
    public Button copyFollowingBtn;
    public Button copyToAlikeBtn;
    public Button hideUIBtn;
    public Button showUIBtn;
    public Button expandTopBtn;
// Text Feilds
    public Text fCounterCopy;
    public Text fCounter;
// Images
    public Image layout;
// Colors
    public Color lightGreyR;
    public Color whiteR;
    public Color blueR;
    public Color orangeR;
    public Color redR;
    public Color blackR;
    public Color frameEditedFalseColor;
    public Color hidden;
// **************************************************

//***************************************************
// Class variable

    public int numOfFrames = 10;   // How many frames 
    public static int currentFrame = 0; // current index of frames

    public static LightShow show; // storage for frames
    public static int currentSection = 0; // selected index to pass to panel2
    public static int currentSectionSize; // selected size to pass to panel2

    public  bool[] editedFrames; // was using to display which frames have been saved / edited
    public  bool isCurrentFrameClear; // determines if current frames is edited - not in full use

    // sectionss
    public static GameObject[] s11 = new GameObject[299];
    public static GameObject[] s12 = new GameObject[299];
    public static GameObject[] s2 = new GameObject[299];
    public static GameObject[] s3 = new GameObject[299];
    public static GameObject[] s16 = new GameObject[299];
    public static GameObject[] s7 = new GameObject[299];

    public static GameObject[] s1 = new GameObject[286];
    public static GameObject[] s4 = new GameObject[286];
    public static GameObject[] s10 = new GameObject[286];
    public static GameObject[] s13 = new GameObject[286];

    public static GameObject[] s15 = new GameObject[208];
    public static GameObject[] s8 = new GameObject[208];
    public static GameObject[] s17 = new GameObject[208];
    public static GameObject[] s6 = new GameObject[208];

    public static GameObject[] s24 = new GameObject[207];
    public static GameObject[] s25 = new GameObject[207];
    public static GameObject[] s20 = new GameObject[207];
    public static GameObject[] s21 = new GameObject[207];

    public static GameObject[] s19 = new GameObject[90];
    public static GameObject[] s22 = new GameObject[90];
    public static GameObject[] s23 = new GameObject[90];
    public static GameObject[] s26 = new GameObject[90];

// selection values
    bool s1on = false;
    bool s2on = false;
    bool s3on = false;
    bool s4on = false;
    bool s6on = false;
    bool s7on = false;
    bool s8on = false;
    bool s10on = false;
    bool s11on = false;
    bool s12on = false;
    bool s13on = false;
    bool s15on = false;
    bool s16on = false;
    bool s17on = false;
    bool s19on = false;
    bool s20on = false;
    bool s21on = false;
    bool s22on = false;
    bool s23on = false;
    bool s24on = false;
    bool s25on = false;
    bool s26on = false;

    // Static copys
    public static GameObject panel2static;
    public static Color lightGrey;
    public static Color blue;
    public static Color orange;
    public static Color white;
    public static Color red;
    public static Color black;


    /* %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
     *   AWAKE
     * 
     *  - (1) does some initial setup, (2) then dynamically 
     *    creates all the sections pixels of the stadium
     *  %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% */
    private void Awake()
    {
        Debug.Log("P1 - Awake Start ");
        currentSection = 0;
        show = new LightShow();
        
        panel2static = panel2;
        panel1.SetActive(false);
        panel2static.SetActive(true);

        blue = blueR;
        orange = orangeR;
        white = whiteR;
        red = redR;
        black = blackR;
        lightGrey = lightGreyR;


 // DYNAMIC SECTION CREATION
        int h = 7;
        int w = 6;
        int wh = 4;
        int hh = 9;
        int ht = 6;
        float px = -50;
        float py = 180;
        // 12
        for (int i = 1; i < 300; i++)
        {
            s12[i - 1] = Instantiate(p1TempPixel);
            s12[i - 1].transform.SetParent(transform.Find("Panel1"));
            s12[i - 1].transform.localPosition = new Vector3(px, py);
            s12[i - 1].transform.name = "13." + i;
            s12[i - 1].GetComponent<Image>().color = blue;
            //DontDestroyOnLoad(leftSectionObjs[i - 1]);
            if (i % 23 == 0)
            {
                px = -50;
                py = py + ht;
            }
            else
            {
                px = px + w;
            }
        }
        //-----------------------------------------------------
        // 11
        px = 96;
        py = 180;
        for (int i = 1; i < 300; i++)
        {
            s11[i - 1] = Instantiate(p1TempPixel);
            s11[i - 1].transform.SetParent(transform.Find("Panel1"));
            s11[i - 1].transform.localPosition = new Vector3(px, py);
            s11[i - 1].transform.name = "11." + i;
            s11[i - 1].GetComponent<Image>().color = blue;
            //DontDestroyOnLoad(leftSectionObjs[i - 1]);
            if (i % 23 == 0)
            {
                px = 96;
                py = py + ht;
            }
            else
            {
                px = px + w;
            }
        }
        //-----------------------------------------------------
        // 2
        px = -50;
        py = -180;
        for (int i = 1; i < 300; i++)
        {
            s2[i - 1] = Instantiate(p1TempPixel);
            s2[i - 1].transform.SetParent(transform.Find("Panel1"));
            s2[i - 1].transform.localPosition = new Vector3(px, py);
            s2[i - 1].transform.name = "2." + i;
            s2[i - 1].GetComponent<Image>().color = blue;
            //DontDestroyOnLoad(leftSectionObjs[i - 1]);
            if (i % 23 == 0)
            {
                px = -50;
                py = py - ht;
            }
            else
            {
                px = px + w;
            }
        }
        //-----------------------------------------------------
        // 3
        px = 96;
        py = -180;
        for (int i = 1; i < 300; i++)
        {
            s3[i - 1] = Instantiate(p1TempPixel);
            s3[i - 1].transform.SetParent(transform.Find("Panel1"));
            s3[i - 1].transform.localPosition = new Vector3(px, py);
            s3[i - 1].transform.name = "3." + i;
            s3[i - 1].GetComponent<Image>().color = blue;
            //DontDestroyOnLoad(leftSectionObjs[i - 1]);
            if (i % 23 == 0)
            {
                px = 96;
                py = py - ht;
            }
            else
            {
                px = px + w;
            }
        }
        //-----------------------------------------------------
        // 16
        px = -160;
        py = -46;
        for (int i = 1; i < 300; i++)
        {
            s16[i - 1] = Instantiate(p1TempPixel);
            s16[i - 1].transform.SetParent(transform.Find("Panel1"));
            s16[i - 1].transform.localPosition = new Vector3(px, py);
            s16[i - 1].transform.name = "16." + i;
            s16[i - 1].GetComponent<Image>().color = blue;
            //DontDestroyOnLoad(leftSectionObjs[i - 1]);
            if (i % 23 == 0)
            {
                px = px - hh;
                py = -46;
            }
            else
            {
                py = py + wh;
            }
        }
        //-----------------------------------------------------
        // 7
        px = 350;
        py = 42;
        for (int i = 1; i < 300; i++)
        {
            s7[i - 1] = Instantiate(p1TempPixel);
            s7[i - 1].transform.SetParent(transform.Find("Panel1"));
            s7[i - 1].transform.localPosition = new Vector3(px, py);
            s7[i - 1].transform.name = "7." + i;
            s7[i - 1].GetComponent<Image>().color = blue;
            //DontDestroyOnLoad(leftSectionObjs[i - 1]);
            if (i % 23 == 0)
            {
                px = px + hh;
                py = 42;
            }
            else
            {
                py = py - wh;
            }
        }
        // @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        //    TYPE B SECTIONS
        px = -58;
        py = 180;
        int pxs = 16;
        int count = 1;
        for (int i = 1; i < 287; i++)
        {
            s13[i - 1] = Instantiate(p1TempPixel);
            s13[i - 1].transform.SetParent(transform.Find("Panel1"));
            s13[i - 1].transform.localPosition = new Vector3(px, py);
            s13[i - 1].transform.name = "13." + i;
            s13[i - 1].GetComponent<Image>().color = white;
            if ( count == pxs)
            {
                pxs = pxs + 1;
                count = 1;
                px = -58;
                py = py + ht;
            }
            else
            {
                px = px - w;
                count++;
            }    
        }
        //    10
        px = 242;
        py = 180;
        pxs = 16;
        count = 1;
        for (int i = 1; i < 287; i++)
        {
            s10[i - 1] = Instantiate(p1TempPixel);
            s10[i - 1].transform.SetParent(transform.Find("Panel1"));
            s10[i - 1].transform.localPosition = new Vector3(px, py);
            s10[i - 1].transform.name = "10." + i;
            s10[i - 1].GetComponent<Image>().color = white;
            if (count == pxs)
            {
                pxs = pxs + 1;
                count = 1;
                px = 242;
                py = py + ht;
            }
            else
            {
                px = px + w;
                count++;
            }
        }

        //    1 ------------------------
        px = -58;
        py = -180;
        pxs = 16;
        count = 1;
        for (int i = 1; i < 287; i++)
        {
            s1[i - 1] = Instantiate(p1TempPixel);
            s1[i - 1].transform.SetParent(transform.Find("Panel1"));
            s1[i - 1].transform.localPosition = new Vector3(px, py);
            s1[i - 1].transform.name = "1." + i;
            s1[i - 1].GetComponent<Image>().color = white;
            if (count == pxs)
            {
                pxs = pxs + 1;
                count = 1;
                px = -58;
                py = py - ht;
            }
            else
            {
                px = px - w;
                count++;
            }
        }
        //    4-------------------
        px = 242;
        py = -180;
        pxs = 16;
        count = 1;
        for (int i = 1; i < 287; i++)
        {
            s4[i - 1] = Instantiate(p1TempPixel);
            s4[i - 1].transform.SetParent(transform.Find("Panel1"));
            s4[i - 1].transform.localPosition = new Vector3(px, py);
            s4[i - 1].transform.name = "4." + i;
            s4[i - 1].GetComponent<Image>().color = white;
            if (count == pxs)
            {
                pxs = pxs + 1;
                count = 1;
                px = 242;
                py = py - ht;
            }
            else
            {
                px = px + w;
                count++;
            }
        }
        // @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        //    15-------------------
        px = -160;
        py = 62;
        pxs = 10;
        count = 1;
        for (int i = 1; i < 209; i++)
        {
            s15[i - 1] = Instantiate(p1TempPixel);
            s15[i - 1].transform.SetParent(transform.Find("Panel1"));
            s15[i - 1].transform.localPosition = new Vector3(px, py);
            s15[i - 1].transform.name = "15." + i;
            s15[i - 1].GetComponent<Image>().color = white;
            if (count == pxs)
            {
                pxs = pxs + 1;
                count = 1;
                px = px - hh;
                py = 62;
            }
            else
            {
                py = py + wh;
                count++;
            }
        }
        //    8 -------------------
        px = 350;
        py = 62;

        pxs = 10;
        count = 1;

        for (int i = 1; i < 209; i++)
        {
            s8[i - 1] = Instantiate(p1TempPixel);
            s8[i - 1].transform.SetParent(transform.Find("Panel1"));
            s8[i - 1].transform.localPosition = new Vector3(px, py);
            s8[i - 1].transform.name = "8." + i;
            s8[i - 1].GetComponent<Image>().color = white;
            if (count == pxs)
            {
                pxs = pxs + 1;
                count = 1;
                px = px + hh;
                py = 62;
            }
            else
            {
                py = py + wh;
                count++;
            }


        }

        //    17-------------------
        px = -160;
        py = -62;

        pxs = 10;
        count = 1;

        for (int i = 1; i < 209; i++)
        {
            s17[i - 1] = Instantiate(p1TempPixel);
            s17[i - 1].transform.SetParent(transform.Find("Panel1"));
            s17[i - 1].transform.localPosition = new Vector3(px, py);
            s17[i - 1].transform.name = "17." + i;
            s17[i - 1].GetComponent<Image>().color = white;
            if (count == pxs)
            {
                pxs = pxs + 1;
                count = 1;
                px = px - hh;
                py = -62;
            }
            else
            {
                py = py - wh;
                count++;
            }


        }
        // 6 ------------------
        px = 350;
        py = -62;

        pxs = 10;
        count = 1;

        for (int i = 1; i < 209; i++)
        {
            s6[i - 1] = Instantiate(p1TempPixel);
            s6[i - 1].transform.SetParent(transform.Find("Panel1"));
            s6[i - 1].transform.localPosition = new Vector3(px, py);
            s6[i - 1].transform.name = "6." + i;
            s6[i - 1].GetComponent<Image>().color = white;
            if (count == pxs)
            {
                pxs = pxs + 1;
                count = 1;
                px = px + hh;
                py = -62;
            }
            else
            {
                py = py - wh;
                count++;
            }


        }
        // 25------------------------------------
        px = 96;
        py = 106;
        for (int i = 1; i < 208; i++)
        {
            s25[i - 1] = Instantiate(p1TempPixel);
            s25[i - 1].transform.SetParent(transform.Find("Panel1"));
            s25[i - 1].transform.localPosition = new Vector3(px, py);
            s25[i - 1].transform.name = "25." + i;
            s25[i - 1].GetComponent<Image>().color = blue;
            if (i % 23 == 0)
            {
                px = 96;
                py = py + h;
            }
            else
            {
                px = px + w;
            }
        }
        // 24------------------------------------
        px = -48;
        py = 106;
        for (int i = 1; i < 208; i++)
        {
            s24[i - 1] = Instantiate(p1TempPixel);
            s24[i - 1].transform.SetParent(transform.Find("Panel1"));
            s24[i - 1].transform.localPosition = new Vector3(px, py);
            s24[i - 1].transform.name = "24." + i;
            s24[i - 1].GetComponent<Image>().color = blue;
            if (i % 23 == 0)
            {
                px = -48;
                py = py + h;
            }
            else
            {
                px = px + w;
            }
        }
        // 20------------------------------------
        px = -48;
        py = -106;
        for (int i = 1; i < 208; i++)
        {
            s20[i - 1] = Instantiate(p1TempPixel);
            s20[i - 1].transform.SetParent(transform.Find("Panel1"));
            s20[i - 1].transform.localPosition = new Vector3(px, py);
            s20[i - 1].transform.name = "20." + i;
            s20[i - 1].GetComponent<Image>().color = blue;
            if (i % 23 == 0)
            {
                px = -48;
                py = py - h;
            }
            else
            {
                px = px + w;
            }
        }
        // 21------------------------------------
        px = 96;
        py = -106;
        for (int i = 1; i < 208; i++)
        {
            s21[i - 1] = Instantiate(p1TempPixel);
            s21[i - 1].transform.SetParent(transform.Find("Panel1"));
            s21[i - 1].transform.localPosition = new Vector3(px, py);
            s21[i - 1].transform.name = "21." + i;
            s21[i - 1].GetComponent<Image>().color = blue;
            if (i % 23 == 0)
            {
                px = 96;
                py = py - h;
            }
            else
            {
                px = px + w;
            }
        }
        // ---- 23
        px = -58;
        py = 106;

        pxs = 6;
        count = 1;

        for (int i = 1; i < 91; i++)
        {
            s23[i - 1] = Instantiate(p1TempPixel);
            s23[i - 1].transform.SetParent(transform.Find("Panel1"));
            s23[i - 1].transform.localPosition = new Vector3(px, py);
            s23[i - 1].transform.name = "23." + i;
            s23[i - 1].GetComponent<Image>().color = white;

            if (count == pxs)
            {
                pxs = pxs + 1;
                count = 1;
                px = -58;
                py = py  + h; 
            }
            else
            {
                px = px - w;
                count++;
            }
        }
        // ---- 26
        px = 242;
        py = 106;

        pxs = 6;
        count = 1;

        for (int i = 1; i < 91; i++)
        {
            s26[i - 1] = Instantiate(p1TempPixel);
            s26[i - 1].transform.SetParent(transform.Find("Panel1"));
            s26[i - 1].transform.localPosition = new Vector3(px, py);
            s26[i - 1].transform.name = "26." + i;
            s26[i - 1].GetComponent<Image>().color = white;

            if (count == pxs)
            {
                pxs = pxs + 1;
                count = 1;
                px = 242;
                py = py + h;
            }
            else
            {
                px = px +  w;
                count++;
            }
        }
        // ---- 22
        px = 242;
        py = -106;

        pxs = 6;
        count = 1;

        for (int i = 1; i < 91; i++)
        {
            s22[i - 1] = Instantiate(p1TempPixel);
            s22[i - 1].transform.SetParent(transform.Find("Panel1"));
            s22[i - 1].transform.localPosition = new Vector3(px, py);
            s22[i - 1].transform.name = "22." + i;
            s22[i - 1].GetComponent<Image>().color = white;

            if (count == pxs)
            {
                pxs = pxs + 1;
                count = 1;
                px = 242;
                py = py - h;
            }
            else
            {
                px = px + w;
                count++;
            }
        }
        // ---- 19
        px = -58;
        py = -106;

        pxs = 6;
        count = 1;

        for (int i = 1; i < 91; i++)
        {
            s19[i - 1] = Instantiate(p1TempPixel);
            s19[i - 1].transform.SetParent(transform.Find("Panel1"));
            s19[i - 1].transform.localPosition = new Vector3(px, py);
            s19[i - 1].transform.name = "19." + i;
            s19[i - 1].GetComponent<Image>().color = white;

            if (count == pxs)
            {
                pxs = pxs + 1;
                count = 1;
                px = -58;
                py = py - h;
            }
            else
            {
                px = px - w;
                count++;
            }
        }
        Debug.Log("P1 - Awake End ");
    }

    /* %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    *  START 
    * 
    *  - class var init / button action assigments
    *  %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% */
    void Start()
    {
        Debug.Log("P1 - Start start");

        numOfFrames = 10;
        currentFrame = 0;
        editedFrames = new bool[numOfFrames];
        isCurrentFrameClear = true;

        hideUIBtn.onClick.AddListener(() => hideUI());
        showUIBtn.onClick.AddListener(() => showUI());
        nextBtn.onClick.AddListener(() => nextFrame());
        prevFrameBtn.onClick.AddListener(() => prevFrame());
        copyFollowingBtn.onClick.AddListener(() => copyToFollowingSections());
        copyToAlikeBtn.onClick.AddListener(() => copyToAlikeSection());
        blueBtn.onClick.AddListener(() => blueClicked());
        orangeButton.onClick.AddListener(() => orangeClicked());
        whiteBtn.onClick.AddListener(() => whiteClicked());
        copyToNextBtn.onClick.AddListener(() => Randomize());
        selectAllBtn.onClick.AddListener(() => selectAll()); 
        expandTopBtn.onClick.AddListener(() => expandSection());
        b1.onClick.AddListener(() => s1Clicked());
        b2.onClick.AddListener(() => s2Clicked());
        b3.onClick.AddListener(() => s3Clicked());
        b4.onClick.AddListener(() => s4Clicked());
        b6.onClick.AddListener(() => s6Clicked());
        b7.onClick.AddListener(() => s7Clicked());
        b8.onClick.AddListener(() => s8Clicked());
        b10.onClick.AddListener(() => s10Clicked());
        b11.onClick.AddListener(() => s11Clicked());
        b12.onClick.AddListener(() => s12Clicked());
        b13.onClick.AddListener(() => s13Clicked());
        b15.onClick.AddListener(() => s15Clicked());
        b16.onClick.AddListener(() => s16Clicked());
        b17.onClick.AddListener(() => s17Clicked());
        b19.onClick.AddListener(() => s19Clicked());
        b20.onClick.AddListener(() => s20Clicked());
        b21.onClick.AddListener(() => s21Clicked());
        b22.onClick.AddListener(() => s22Clicked());
        b23.onClick.AddListener(() => s23Clicked());
        b24.onClick.AddListener(() => s24Clicked());
        b25.onClick.AddListener(() => s25Clicked());
        b26.onClick.AddListener(() => s26Clicked());

        // color setup
        b1.GetComponent<Image>().color = blackR;
        b2.GetComponent<Image>().color = blackR;
        b3.GetComponent<Image>().color = blackR;
        b4.GetComponent<Image>().color = blackR;
        b6.GetComponent<Image>().color = blackR;
        b7.GetComponent<Image>().color = blackR;
        b8.GetComponent<Image>().color = blackR;
        b10.GetComponent<Image>().color = blackR;
        b11.GetComponent<Image>().color = blackR;
        b12.GetComponent<Image>().color = blackR;
        b13.GetComponent<Image>().color = blackR;
        b15.GetComponent<Image>().color = blackR;
        b16.GetComponent<Image>().color = blackR;
        b17.GetComponent<Image>().color = blackR; 
        b19.GetComponent<Image>().color = blackR;
        b20.GetComponent<Image>().color = blackR;
        b21.GetComponent<Image>().color = blackR;
        b22.GetComponent<Image>().color = blackR;
        b23.GetComponent<Image>().color = blackR;
        b24.GetComponent<Image>().color = blackR;
        b25.GetComponent<Image>().color = blackR;
        b26.GetComponent<Image>().color = blackR;

        loadUI();
        Debug.Log("P1 - Start end ");
    }



    /* %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    *  SHOW / HIDE UI
    * 
    *  - shows/hides the editing buttons in the ui to 
    *    allow the show to be seen better 
    *  %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% */
    public void hideUI()
    {
        Debug.Log("P1 - HideUI ");
        showUIBtn.interactable = true;
        hideUIBtn.interactable = false;
        layout.enabled = true;
    }

    public void showUI()
    {
        Debug.Log("P1 - ShowUI ");
        showUIBtn.interactable = false;
        hideUIBtn.interactable = true;
        layout.enabled = false; ;
    }


    /* %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
     *  LOAD UI
     * 
     *  - reads the values of (show) at currentFrame.
     *    interprets the value as a color, then sets 
     *    the corresponding section to the color.
     *  %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% */
    public static void loadUI()
    {
        Debug.Log("P1 - LoaudUI start ");
        // 2   --------------------------------------------
        for (int i = 0; i < 299; i++)
        {
            byte b = show.s2Values[currentFrame, i];
            switch (b)
            {
                case 0:
                    s2[i].GetComponent<Image>().color = lightGrey;
                    break;
                case 1:
                    s2[i].GetComponent<Image>().color = white;
                    break;
                case 2:
                    s2[i].GetComponent<Image>().color = blue;
                    break;
                case 3:
                    s2[i].GetComponent<Image>().color = orange;
                    break;
            }
        }
        // 3   --------------------------------------------
        for (int i = 0; i < 299; i++)
        {
            byte b = show.s3Values[currentFrame, i];
            switch (b)
            {
                case 0:
                    s3[i].GetComponent<Image>().color = lightGrey;
                    break;
                case 1:
                    s3[i].GetComponent<Image>().color = white;
                    break;
                case 2:
                    s3[i].GetComponent<Image>().color = blue;
                    break;
                case 3:
                    s3[i].GetComponent<Image>().color = orange;
                    break;
            }
        }
        // 7   --------------------------------------------
        for (int i = 0; i < 299; i++)
        {
            byte b = show.s7Values[currentFrame, i];
            switch (b)
            {
                case 0:
                    s7[i].GetComponent<Image>().color = lightGrey;
                    break;
                case 1:
                    s7[i].GetComponent<Image>().color = white;
                    break;
                case 2:
                    s7[i].GetComponent<Image>().color = blue;
                    break;
                case 3:
                    s7[i].GetComponent<Image>().color = orange;
                    break;
            }
        }
        // 11   --------------------------------------------
        for (int i = 0; i < 299; i++)
        {
            byte b = show.s11Values[currentFrame, i];
            switch (b)
            {
                case 0:
                    s11[i].GetComponent<Image>().color = lightGrey;
                    break;
                case 1:
                    s11[i].GetComponent<Image>().color = white;
                    break;
                case 2:
                    s11[i].GetComponent<Image>().color = blue;
                    break;
                case 3:
                    s11[i].GetComponent<Image>().color = orange;
                    break;
            }
        }
        // 12   --------------------------------------------
        for (int i = 0; i < 299; i++)
        {
            byte b = show.s12Values[currentFrame, i];
            switch (b)
            {
                case 0:
                    s12[i].GetComponent<Image>().color = lightGrey;
                    break;
                case 1:
                    s12[i].GetComponent<Image>().color = white;
                    break;
                case 2:
                    s12[i].GetComponent<Image>().color = blue;
                    break;
                case 3:
                    s12[i].GetComponent<Image>().color = orange;
                    break;
            }
        }
        // 16   --------------------------------------------
        for (int i = 0; i < 299; i++)
        {
            byte b = show.s16Values[currentFrame, i];
            switch (b)
            {
                case 0:
                    s16[i].GetComponent<Image>().color = lightGrey;
                    break;
                case 1:
                    s16[i].GetComponent<Image>().color = white;
                    break;
                case 2:
                    s16[i].GetComponent<Image>().color = blue;
                    break;
                case 3:
                    s16[i].GetComponent<Image>().color = orange;
                    break;
            }
        }
        // 1   --------------------------------------------
        for (int i = 0; i < 286; i++)
        {
            byte b = show.s1Values[currentFrame, i];
            switch (b)
            {
                case 0:
                    s1[i].GetComponent<Image>().color = lightGrey;
                    break;
                case 1:
                    s1[i].GetComponent<Image>().color = white;
                    break;
                case 2:
                    s1[i].GetComponent<Image>().color = blue;
                    break;
                case 3:
                    s1[i].GetComponent<Image>().color = orange;
                    break;
            }
        }
        // 4   --------------------------------------------
        for (int i = 0; i < 286; i++)
        {
            byte b = show.s4Values[currentFrame, i];
            switch (b)
            {
                case 0:
                    s4[i].GetComponent<Image>().color = lightGrey;
                    break;
                case 1:
                    s4[i].GetComponent<Image>().color = white;
                    break;
                case 2:
                    s4[i].GetComponent<Image>().color = blue;
                    break;
                case 3:
                    s4[i].GetComponent<Image>().color = orange;
                    break;
            }
        }
        // 10   --------------------------------------------
        for (int i = 0; i < 286; i++)
        {
            byte b = show.s10Values[currentFrame, i];
            switch (b)
            {
                case 0:
                    s10[i].GetComponent<Image>().color = lightGrey;
                    break;
                case 1:
                    s10[i].GetComponent<Image>().color = white;
                    break;
                case 2:
                    s10[i].GetComponent<Image>().color = blue;
                    break;
                case 3:
                    s10[i].GetComponent<Image>().color = orange;
                    break;
            }
        }
        // 13   --------------------------------------------
        for (int i = 0; i < 286; i++)
        {
            byte b = show.s13Values[currentFrame, i];
            switch (b)
            {
                case 0:
                    s13[i].GetComponent<Image>().color = lightGrey;
                    break;
                case 1:
                    s13[i].GetComponent<Image>().color = white;
                    break;
                case 2:
                    s13[i].GetComponent<Image>().color = blue;
                    break;
                case 3:
                    s13[i].GetComponent<Image>().color = orange;
                    break;
            }
        }
        // 6   --------------------------------------------
        for (int i = 0; i < 208; i++)
        {
            byte b = show.s6Values[currentFrame, i];
            switch (b)
            {
                case 0:
                    s6[i].GetComponent<Image>().color = lightGrey;
                    break;
                case 1:
                    s6[i].GetComponent<Image>().color = white;
                    break;
                case 2:
                    s6[i].GetComponent<Image>().color = blue;
                    break;
                case 3:
                    s6[i].GetComponent<Image>().color = orange;
                    break;
            }
        }
        // 8   --------------------------------------------
        for (int i = 0; i < 208; i++)
        {
            byte b = show.s8Values[currentFrame, i];
            switch (b)
            {
                case 0:
                    s8[i].GetComponent<Image>().color = lightGrey;
                    break;
                case 1:
                    s8[i].GetComponent<Image>().color = white;
                    break;
                case 2:
                    s8[i].GetComponent<Image>().color = blue;
                    break;
                case 3:
                    s8[i].GetComponent<Image>().color = orange;
                    break;
            }
        }
        // 15   --------------------------------------------
        for (int i = 0; i < 208; i++)
        {
            byte b = show.s15Values[currentFrame, i];
            switch (b)
            {
                case 0:
                    s15[i].GetComponent<Image>().color = lightGrey;
                    break;
                case 1:
                    s15[i].GetComponent<Image>().color = white;
                    break;
                case 2:
                    s15[i].GetComponent<Image>().color = blue;
                    break;
                case 3:
                    s15[i].GetComponent<Image>().color = orange;
                    break;
            }
        }
        // 17   --------------------------------------------
        for (int i = 0; i < 208; i++)
        {
            byte b = show.s17Values[currentFrame, i];
            switch (b)
            {
                case 0:
                    s17[i].GetComponent<Image>().color = lightGrey;
                    break;
                case 1:
                    s17[i].GetComponent<Image>().color = white;
                    break;
                case 2:
                    s17[i].GetComponent<Image>().color = blue;
                    break;
                case 3:
                    s17[i].GetComponent<Image>().color = orange;
                    break;
            }
        }

        // 19   --------------------------------------------
        for (int i = 0; i < 90; i++)
        {
            byte b = show.s19Values[currentFrame, i];
            switch (b)
            {
                case 0:
                    s19[i].GetComponent<Image>().color = lightGrey;
                    break;
                case 1:
                    s19[i].GetComponent<Image>().color = white;
                    break;
                case 2:
                    s19[i].GetComponent<Image>().color = blue;
                    break;
                case 3:
                    s19[i].GetComponent<Image>().color = orange;
                    break;
            }
        }
        // 22   --------------------------------------------
        for (int i = 0; i < 90; i++)
        {
            byte b = show.s22Values[currentFrame, i];
            switch (b)
            {
                case 0:
                    s22[i].GetComponent<Image>().color = lightGrey;
                    break;
                case 1:
                    s22[i].GetComponent<Image>().color = white;
                    break;
                case 2:
                    s22[i].GetComponent<Image>().color = blue;
                    break;
                case 3:
                    s22[i].GetComponent<Image>().color = orange;
                    break;
            }
        }
        // 23   --------------------------------------------
        for (int i = 0; i < 90; i++)
        {
            byte b = show.s23Values[currentFrame, i];
            switch (b)
            {
                case 0:
                    s23[i].GetComponent<Image>().color = lightGrey;
                    break;
                case 1:
                    s23[i].GetComponent<Image>().color = white;
                    break;
                case 2:
                    s23[i].GetComponent<Image>().color = blue;
                    break;
                case 3:
                    s23[i].GetComponent<Image>().color = orange;
                    break;
            }
        }
        // 26   --------------------------------------------
        for (int i = 0; i < 90; i++)
        {
            byte b = show.s26Values[currentFrame, i];
            switch (b)
            {
                case 0:
                    s26[i].GetComponent<Image>().color = lightGrey;
                    break;
                case 1:
                    s26[i].GetComponent<Image>().color = white;
                    break;
                case 2:
                    s26[i].GetComponent<Image>().color = blue;
                    break;
                case 3:
                    s26[i].GetComponent<Image>().color = orange;
                    break;
            }
        }
        // 20   --------------------------------------------
        for (int i = 0; i < 207; i++)
        {
            byte b = show.s20Values[currentFrame, i];
            switch (b)
            {
                case 0:
                    s20[i].GetComponent<Image>().color = lightGrey;
                    break;
                case 1:
                    s20[i].GetComponent<Image>().color = white;
                    break;
                case 2:
                    s20[i].GetComponent<Image>().color = blue;
                    break;
                case 3:
                    s20[i].GetComponent<Image>().color = orange;
                    break;
            }
        }
        // 21   --------------------------------------------
        for (int i = 0; i < 207; i++)
        {
            byte b = show.s21Values[currentFrame, i];
            switch (b)
            {
                case 0:
                    s21[i].GetComponent<Image>().color = lightGrey;
                    break;
                case 1:
                    s21[i].GetComponent<Image>().color = white;
                    break;
                case 2:
                    s21[i].GetComponent<Image>().color = blue;
                    break;
                case 3:
                    s21[i].GetComponent<Image>().color = orange;
                    break;
            }
        }
        // 24   --------------------------------------------
        for (int i = 0; i < 207; i++)
        {
            byte b = show.s24Values[currentFrame, i];
            switch (b)
            {
                case 0:
                    s24[i].GetComponent<Image>().color = lightGrey;
                    break;
                case 1:
                    s24[i].GetComponent<Image>().color = white;
                    break;
                case 2:
                    s24[i].GetComponent<Image>().color = blue;
                    break;
                case 3:
                    s24[i].GetComponent<Image>().color = orange;
                    break;
            }
        }
        // 25   --------------------------------------------
        for (int i = 0; i < 207; i++)
        {
            byte b = show.s25Values[currentFrame, i];
            switch (b)
            {
                case 0:
                    s25[i].GetComponent<Image>().color = lightGrey;
                    break;
                case 1:
                    s25[i].GetComponent<Image>().color = white;
                    break;
                case 2:
                    s25[i].GetComponent<Image>().color = blue;
                    break;
                case 3:
                    s25[i].GetComponent<Image>().color = orange;
                    break;
            }
        }
        Debug.Log("P1 - LoadUI end ");
    }





    /* %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
     *  RESET SELECTION BUTTONS
     * 
     *  - (NOT IMPLEMENTED)
     *     Suppose to unselect all the ui seclection
     *     buttons and set all the on values to off.
     *  %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% */
    public void resetSelectionButtons()
    {
        
    }






    /* %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
     * COLOR CLICKED
     * 
     *  - sets all the selected sections to color, and sets
     *    (show) at current frame / section to corresponding
     *    color byte value
     *  %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% */
    public void blueClicked()
    {
        Debug.Log("P1 - Blue clicked ");
        if (s1on)
        {
            show.setS1(2);
        }
        if (s2on)
        {
            show.setS2(2);
        }
        if (s3on)
        {
            show.setS3(2);
        }
        if (s4on)
        {
            show.setS4(2);
        }
        if (s6on)
        {
            show.setS6(2);
        }
        if (s7on)
        {
            show.setS7(2);
        }
        if (s8on)
        {
            show.setS8(2);
        }
        if (s10on)
        {
            show.setS10(2);
        }
        if (s11on)
        {
            show.setS11(2);
        }
        if (s12on)
        {
            show.setS12(2);
        }
        if (s13on)
        {
            show.setS13(2);
        }
        if (s15on)
        {
            show.setS15(2);
        }
        if (s16on)
        {
            show.setS16(2);
        }
        if (s17on)
        {
            show.setS17(2);
        }
        if (s19on)
        {
            show.setS19(2);
        }
        if (s20on)
        {
            show.setS20(2);
        }
        if (s21on)
        {
            show.setS21(2);
        }
        if (s22on)
        {
            show.setS22(2);
        }
        if (s23on)
        {
            show.setS23(2);
        }
        if (s24on)
        {
            show.setS24(2);
        }
        if (s25on)
        {
            show.setS25(2);
        }
        if (s26on)
        {
            show.setS26(2);
        }

        loadUI();
        
    }
    public void orangeClicked()
    {
        Debug.Log("P1 - Orange Clicked ");
       
        if (s1on)
        {
            show.setS1(3);
        }
        if (s2on)
        {
            show.setS2(3);
        }
        if (s3on)
        {
            show.setS3(3);
        }
        if (s4on)
        {
            show.setS4(3);
        }
        if (s6on)
        {
            show.setS6(3);
        }
        if (s7on)
        {
            show.setS7(3);
        }
        if (s8on)
        {
            show.setS8(3);
        }
        if (s10on)
        {
            show.setS10(3);
        }
        if (s11on)
        {
            show.setS11(3);
        }
        if (s12on)
        {
            show.setS12(3);
        }
        if (s13on)
        {
            show.setS13(3);
        }
        if (s15on)
        {
            show.setS15(3);
        }
        if (s16on)
        {
            show.setS16(3);
        }
        if (s17on)
        {
            show.setS17(3);
        }
        if (s19on)
        {
            show.setS19(3);
        }
        if (s20on)
        {
            show.setS20(3);
        }
        if (s21on)
        {
            show.setS21(3);
        }
        if (s22on)
        {
            show.setS22(3);
        }
        if (s23on)
        {
            show.setS23(3);
        }
        if (s24on)
        {
            show.setS24(3);
        }
        if (s25on)
        {
            show.setS25(3);
        }
        if (s26on)
        {
            show.setS26(3);
        }

        loadUI();
        
    }
    public  void whiteClicked()
    {
        Debug.Log("P1 - ");
        if (s1on)
        {
            show.setS1(1);
        }
        if (s2on)
        {
            show.setS2(1);
        }
        if (s3on)
        {
            show.setS3(1);
        }
        if (s4on)
        {
            show.setS4(1);
        }
        if (s6on)
        {
            show.setS6(1);
        }
        if (s7on)
        {
            show.setS7(1);
        }
        if (s8on)
        {
            show.setS8(1);
        }
        if (s10on)
        {
            show.setS10(1);
        }
        if (s11on)
        {
            show.setS11(1);
        }
        if (s12on)
        {
            show.setS12(1);
        }
        if (s13on)
        {
            show.setS13(1);
        }
        if (s15on)
        {
            show.setS15(1);
        }
        if (s16on)
        {
            show.setS16(1);
        }
        if (s17on)
        {
            show.setS17(1);
        }
        if (s19on)
        {
            show.setS19(1);
        }
        if (s20on)
        {
            show.setS20(1);
        }
        if (s21on)
        {
            show.setS21(1);
        }
        if (s22on)
        {
            show.setS22(1);
        }
        if (s23on)
        {
            show.setS23(1);
        }
        if (s24on)
        {
            show.setS24(1);
        }
        if (s25on)
        {
            show.setS25(1);
        }
        if (s26on)
        {
            show.setS26(1);
        }

        loadUI();
        
    }

    public void Randomize()
    {
        Debug.Log("P1 - Random clicked");
        Random r = new Random();


        if (s1on)
        {
            for (int i = 0; i < 286; i++)
            {
                byte b = (byte)Random.Range(1, 4);
                show.s1Values[currentFrame, i] = b;
            }
        }
        if (s2on)
        {
            for (int i = 0; i < 299; i++)
            {
                byte b = (byte)Random.Range(1, 4);
                show.s2Values[currentFrame, i] = b;
            }
        }
        if (s3on)
        {
            for (int i = 0; i < 299; i++)
            {
                byte b = (byte)Random.Range(1, 4);
                show.s3Values[currentFrame, i] = b;
            }
        }
        if (s4on)
        {
            for (int i = 0; i < 286; i++)
            {
                byte b = (byte)Random.Range(1, 4);
                show.s4Values[currentFrame, i] = b;
            }
        }
        if (s6on)
        {
            for (int i = 0; i < 208; i++)
            {
                byte b = (byte)Random.Range(1, 4);
                show.s6Values[currentFrame, i] = b;
            }
        }
        if (s7on)
        {
            for (int i = 0; i < 299; i++)
            {
                byte b = (byte)Random.Range(1, 4);
                show.s7Values[currentFrame, i] = b;
            }
        }
        if (s8on)
        {
            for (int i = 0; i < 208; i++)
            {
                byte b = (byte)Random.Range(1, 4);
                show.s8Values[currentFrame, i] = b;
            }
        }
        if (s10on)
        {
            for (int i = 0; i < 286; i++)
            {
                byte b = (byte)Random.Range(1, 4);
                show.s10Values[currentFrame, i] = b;
            }
        }
        if (s11on)
        {
            for (int i = 0; i < 299; i++)
            {
                byte b = (byte)Random.Range(1, 4);
                show.s11Values[currentFrame, i] = b;
            }
        }
        if (s12on)
        {
            for (int i = 0; i < 299; i++)
            {


                byte b = (byte)Random.Range(1, 4);
                show.s12Values[currentFrame, i] = b;
            }
        }
        if (s13on)
        {
            for (int i = 0; i < 286; i++)
            {
                byte b = (byte)Random.Range(1, 4);
                show.s13Values[currentFrame, i] = b;
            }
        }
        if (s15on)
        {

            for (int i = 0; i < 208; i++)
            {
                byte b = (byte)Random.Range(1, 4);
                show.s15Values[currentFrame, i] = b;
            }
        }
        if (s16on)
        {
            for (int i = 0; i < 299; i++)
            {
                byte b = (byte)Random.Range(1, 4);
                show.s16Values[currentFrame, i] = b;
            }
        }
        if (s17on)
        {
            for (int i = 0; i < 208; i++)
            {
                byte b = (byte)Random.Range(1, 4);
                show.s17Values[currentFrame, i] = b;
            }
        }
        if (s19on)
        {
            for (int i = 0; i < 90; i++)
            {
                byte b = (byte)Random.Range(1, 4);
                show.s19Values[currentFrame, i] = b;
            }
        }
        if (s20on)
        {
            for (int i = 0; i < 207; i++)
            {
                byte b = (byte)Random.Range(1, 4);
                show.s20Values[currentFrame, i] = b;
            }
        }
        if (s21on)
        {
            for (int i = 0; i < 207; i++)
            {
                byte b = (byte)Random.Range(1, 4);
                show.s21Values[currentFrame, i] = b;
            }
        }
        if (s22on)
        {
            for (int i = 0; i < 90; i++)
            {
                byte b = (byte)Random.Range(1, 4);
                show.s22Values[currentFrame, i] = b;
            }
        }
        if (s23on)
        {
            for (int i = 0; i < 90; i++)
            {
                byte b = (byte)Random.Range(1, 4);
                show.s23Values[currentFrame, i] = b;
            }
        }
        if (s24on)
        {
            for (int i = 0; i < 207; i++)
            {
                byte b = (byte)Random.Range(1, 4);
                show.s24Values[currentFrame, i] = b;
            }
        }
        if (s25on)
        {
            for (int i = 0; i < 207; i++)
            {
                byte b = (byte)Random.Range(0, 4);
                show.s25Values[currentFrame, i] = b;
            }
        }
        if (s26on)
        {
            for (int i = 0; i < 90; i++)
            {
                byte b = (byte)Random.Range(1, 4);
                show.s26Values[currentFrame, i] = b;
            }
        }

        loadUI();
    }


    /* %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
     * NEXT / PREV FRAME
     * 
     *  - if currentFrame is in appropriate range then
     *    the function will update (currentFrame), and 
     *    load the ui based on the new frame values.
     * %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% */
    public void nextFrame()
    {
        Debug.Log("P1 - NextFrame called ");
        if (currentFrame < 9)
        {
            currentFrame = currentFrame + 1;
            updatedFrameCount();       
            loadUI();
            Debug.Log("P1 - NextFrame executed");
        }
    }
    public  void prevFrame()
    {
        Debug.Log("P1 - PrevFramed Called");
        if (currentFrame > 0)
        {
            currentFrame = currentFrame - 1;
            updatedFrameCount(); 
            loadUI();
            Debug.Log("P1 - PrevFrame executed");
        }
    }

    // Updates text feild for currentFrame
    public  void updatedFrameCount()
    {
        fCounter.GetComponent<Text>().text = "Frame: " + currentFrame + "/ " + numOfFrames;
    }

    /* %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
     * SELECT ALL
     * 
     *  - clickes all the section selection buttons.
     *    inverts - does not just set all to on.
     * %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% */
    public void selectAll()
    {
        Debug.Log("P1 - Select All Called");
        s1Clicked();
        s2Clicked();
        s3Clicked();
        s4Clicked();
        s6Clicked();
        s7Clicked();
        s8Clicked();
        s10Clicked();
        s11Clicked();
        s12Clicked();
        s13Clicked();
        s15Clicked();
        s16Clicked();
        s17Clicked();
        s19Clicked();
        s20Clicked();
        s21Clicked();
        s22Clicked();
        s23Clicked();
        s24Clicked();
        s25Clicked();
        s26Clicked();
        Debug.Log("P1 - Select all end");
    }

    /* %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
     * IS ONLY ONE SELECTED
     * 
     * - checks to see if only one section is selected.
     *   if true will update current section and current
     *   section size.
     * %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% */
    public bool isOnlyOneSelected()
    {
        int count = 0;
        int section = 0;
        if (s1on)
        {
            count++;
            section = 1;
            currentSectionSize = 286;
        }
        if (s2on)
        {
            count++;
            section = 2;
            currentSectionSize = 299;
        }
        if (s3on)
        {
            count++;
            section = 3;
            currentSectionSize = 299;
        }
        if (s4on)
        {
            count++;
            section = 4;
            currentSectionSize = 286;
        }
        if (s6on)
        {
            count++;
            section = 6;
            currentSectionSize = 231;
        }
        if (s7on)
        {
            count++;
            section = 7;
            currentSectionSize = 299;
        }
        if (s8on)
        {
            count++;
            section = 8;
            currentSectionSize = 231;
        }
        if (s10on)
        {
            count++;
            section = 10;
            currentSectionSize = 286;
        }
        if (s11on)
        {
            count++;
            section = 11;
            currentSectionSize = 299;
        }
        if (s12on)
        {
            count++;
            section = 12;
            currentSectionSize = 299;
        }
        if (s13on)
        {
            count++;
            section = 13;
            currentSectionSize = 286;
        }
        if (s15on)
        {
            count++;
            section = 15;
            currentSectionSize = 231;
        }
        if (s16on)
        {
            count++;
            section = 16;
            currentSectionSize = 299;
        }
        if (s17on)
        {
            count++;
            section = 17;
            currentSectionSize = 231;
        }
        if (s19on)
        {
            count++;
            section = 19;
            currentSectionSize = 90;
        }
        if (s20on)
        {
            count++;
            section = 20;
            currentSectionSize = 207;
        }
        if (s21on)
        {
            count++;
            section = 21;
            currentSectionSize = 207;
        }
        if (s22on)
        {
            count++;
            section = 22;
            currentSectionSize = 90;
        }
        if (s23on)
        {
            count++;
            section = 23;
            currentSectionSize = 90;
        }
        if (s24on)
        {
            count++;
            section = 24;
            currentSectionSize = 207;
        }
        if (s25on)
        {
            count++;
            section = 25;
            currentSectionSize = 207;
        }
        if (s26on)
        {
            count++;
            section = 26;
            currentSectionSize = 90;
        }


        if (count == 1)
        {
            currentSection = section;
            return true;
        }
        else
        {
            Debug.Log("Can only expand one section ********************");
            return false;
        }
    }

    /* %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
     * SECTION SELECTIONS
     * 
     * - sets section isOn value to on if off, off if on.
     *   updates ui to illistrate isOn values
     *   
     *  IMPROVEMENTS - these methods could be reconstructed
     *  as one method with a section input. Would have to
     *  contstuct a string and use the GetComponet Find name of 
     *  the string.
     * %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% */
    public void s1Clicked()
    {
        if (s1on == false)
        {
            s1on = true;
            b1.GetComponent<Image>().color = redR;

        }
        else
        {
            s1on = false;
            b1.GetComponent<Image>().color = blackR;
        }
    }
    public void s2Clicked()
    {
        if (s2on == false)
        {
            s2on = true;
            b2.GetComponent<Image>().color = redR;
        }
        else
        {
            s2on = false;
            b2.GetComponent<Image>().color = blackR;
        }
    }
    public void s3Clicked()
    {
        if (s3on == false)
        {
            s3on = true;
            b3.GetComponent<Image>().color = redR;
        }
        else
        {
            s3on = false;
            b3.GetComponent<Image>().color = blackR;
        }
    }
    public void s4Clicked()
    {
        if (s4on == false)
        {
            s4on = true;
            b4.GetComponent<Image>().color = redR;
        }
        else
        {
            s4on = false;
            b4.GetComponent<Image>().color = blackR;
        }
    }
    public void s6Clicked()
    {
        if (s6on == false)
        {
            s6on = true;
            b6.GetComponent<Image>().color = redR;
        }
        else
        {
            s6on = false;
            b6.GetComponent<Image>().color = blackR;
        }
    }
    public void s7Clicked()
    {
        if (s7on == false)
        {
            s7on = true;

            b7.GetComponent<Image>().color = redR;
        }
        else
        {
            s7on = false;
            b7.GetComponent<Image>().color = blackR;
        }
    }
    public void s8Clicked()
    {
        if (s8on == false)
        {
            s8on = true;

            b8.GetComponent<Image>().color = redR;
        }
        else
        {
            s8on = false;
            b8.GetComponent<Image>().color = blackR;
        }
    }
    public void s10Clicked()
    {
        if (s10on == false)
        {
            s10on = true;

            b10.GetComponent<Image>().color = redR;
        }
        else
        {
            s10on = false;
            b10.GetComponent<Image>().color = blackR;
        }
    }
    public void s11Clicked()
    {
        if (s11on == false)
        {
            s11on = true;

            b11.GetComponent<Image>().color = redR;
        }
        else
        {
            s11on = false;
            b11.GetComponent<Image>().color = blackR;
        }
    }
    public void s12Clicked()
    {
        if (s12on == false)
        {
            s12on = true;

            b12.GetComponent<Image>().color = redR;
        }
        else
        {
            s12on = false;
            b12.GetComponent<Image>().color = blackR;
        }
    }
    public void s13Clicked()
    {
        if (s13on == false)
        {
            s13on = true;

            b13.GetComponent<Image>().color = redR;
        }
        else
        {
            s13on = false;
            b13.GetComponent<Image>().color = blackR;
        }
    }
    public void s15Clicked()
    {
        if (s15on == false)
        {
            s15on = true;

            b15.GetComponent<Image>().color = redR;
        }
        else
        {
            s15on = false;
            b15.GetComponent<Image>().color = blackR;
        }
    }
    public void s16Clicked()
    {
        if (s16on == false)
        {
            s16on = true;

            b16.GetComponent<Image>().color = redR;
        }
        else
        {
            s16on = false;
            b16.GetComponent<Image>().color = blackR;
        }
    }
    public void s17Clicked()
    {
        if (s17on == false)
        {
            s17on = true;

            b17.GetComponent<Image>().color = redR;
        }
        else
        {
            s17on = false;
            b17.GetComponent<Image>().color = blackR;
        }
    }
    public void s19Clicked()
    {
        if (s19on == false)
        {
            s19on = true;

            b19.GetComponent<Image>().color = redR;
        }
        else
        {
            s19on = false;
            b19.GetComponent<Image>().color = blackR;
        }
    }
    public void s20Clicked()
    {
        if (s20on == false)
        {
            s20on = true;

            b20.GetComponent<Image>().color = redR;
        }
        else
        {
            s20on = false;
            b20.GetComponent<Image>().color = blackR;
        }
    }
    public void s21Clicked()
    {
        if (s21on == false)
        {
            s21on = true;

            b21.GetComponent<Image>().color = redR;
        }
        else
        {
            s21on = false;
            b21.GetComponent<Image>().color = blackR;
        }
    }
    public void s22Clicked()
    {
        if (s22on == false)
        {
            s22on = true;

            b22.GetComponent<Image>().color = redR;
        }
        else
        {
            s22on = false;
            b22.GetComponent<Image>().color = blackR;
        }
    }
    public void s23Clicked()
    {
        if (s23on == false)
        {
            s23on = true;

            b23.GetComponent<Image>().color = redR;
        }
        else
        {
            s23on = false;
            b23.GetComponent<Image>().color = blackR;
        }
    }
    public void s24Clicked()
    {
        if (s24on == false)
        {
            s24on = true;

            b24.GetComponent<Image>().color = redR;
        }
        else
        {
            s24on = false;
            b24.GetComponent<Image>().color = blackR;
        }
    }
    public void s25Clicked()
    {
        if (s25on == false)
        {
            s25on = true;

            b25.GetComponent<Image>().color = redR;
        }
        else
        {
            s25on = false;
            b25.GetComponent<Image>().color = blackR;
        }
    }
    public void s26Clicked()
    {
        if (s26on == false)
        {
            s26on = true;

            b26.GetComponent<Image>().color = redR;
        }
        else
        {
            s26on = false;
            b26.GetComponent<Image>().color = blackR;
        }
    }

    /* %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
     * EXPAND SECTION
     * 
     * - if only one section is selected, it will expand
     *   the section to (panel2)
     * %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% */
    public void expandSection()
    {
        Debug.Log("P1 - Expand Section Start");
        if (isOnlyOneSelected()) { 
            
            panel2static.SetActive(false);
            panel1.SetActive(true);
            //SectionPanel.reload();

            Debug.Log("P1 - Expand Section - Valid / excuted");
        } else
        {
            Debug.Log("P1 - Expand Section invalid");
        }
    }

    /* %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
     * RELOAD
     * 
     * - called from (panel2) to reload the values of panel1
     * %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% */
    public static void reload()
    {
        Debug.Log("P1 - Reloaded called");
        panel2static.SetActive(true);
        loadUI();
    }

    /* %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
     * COPY FUNCTIONS
     * 
     * - CopyAlike - if only one section is selected, it 
     *               copys the section to all sections that 
     *               have the same size / deminsions
     * - copyFollowing - copys to all frames after
     * %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% */
    public void copyToAlikeSection()
    {
        Debug.Log("P1 - Copy Alike called");
        if (isOnlyOneSelected())
        {
            Debug.Log("P1 - Copy Alike valid");
            int b = currentSection;
            int sze = currentSectionSize;
            if (b == 2 || b == 3 || b == 7 || b == 11 || b == 12 || b == 16)
            {
                for (int i = 0; i < sze; i++)
                {
                    show.setValue(currentFrame, 2, i, show.getTheValue(currentFrame, currentSection, i));
                    show.setValue(currentFrame, 3, i, show.getTheValue(currentFrame, currentSection, i));
                    show.setValue(currentFrame, 7, i, show.getTheValue(currentFrame, currentSection, i));
                    show.setValue(currentFrame, 11, i, show.getTheValue(currentFrame, currentSection, i));
                    show.setValue(currentFrame, 12, i, show.getTheValue(currentFrame, currentSection, i));
                    show.setValue(currentFrame, 16, i, show.getTheValue(currentFrame, currentSection, i));
                }
            }
            else if (b == 1 || b == 4 || b == 10 || b == 13)
            {
                for (int i = 0; i < sze; i++)
                {
                    show.setValue(currentFrame, 1, i, show.getTheValue(currentFrame, currentSection, i));
                    show.setValue(currentFrame, 4, i, show.getTheValue(currentFrame, currentSection, i));
                    show.setValue(currentFrame, 10, i, show.getTheValue(currentFrame, currentSection, i));
                    show.setValue(currentFrame, 13, i, show.getTheValue(currentFrame, currentSection, i));
       
                }
            }
            else if (b == 6 || b == 8 || b == 15 || b == 17)
            {
                for (int i = 0; i < sze; i++)
                {
                    show.setValue(currentFrame, 6, i, show.getTheValue(currentFrame, currentSection, i));
                    show.setValue(currentFrame, 8, i, show.getTheValue(currentFrame, currentSection, i));
                    show.setValue(currentFrame, 15, i, show.getTheValue(currentFrame, currentSection, i));
                    show.setValue(currentFrame, 17, i, show.getTheValue(currentFrame, currentSection, i));

                }
            }
            else if (b ==  19 || b == 22 || b == 23 || b == 26)
            {
                for (int i = 0; i < sze; i++)
                {
                    show.setValue(currentFrame, 19, i, show.getTheValue(currentFrame, currentSection, i));
                    show.setValue(currentFrame, 22, i, show.getTheValue(currentFrame, currentSection, i));
                    show.setValue(currentFrame, 23, i, show.getTheValue(currentFrame, currentSection, i));
                    show.setValue(currentFrame, 26, i, show.getTheValue(currentFrame, currentSection, i));
                   
                }
            }
            else if (b == 20 || b == 21 || b == 24 || b == 25 )
            {
                for (int i = 0; i < sze; i++)
                {
                    show.setValue(currentFrame, 20, i, show.getTheValue(currentFrame, currentSection, i));
                    show.setValue(currentFrame, 21, i, show.getTheValue(currentFrame, currentSection, i));
                    show.setValue(currentFrame, 24, i, show.getTheValue(currentFrame, currentSection, i));
                    show.setValue(currentFrame, 25, i, show.getTheValue(currentFrame, currentSection, i));
                }
            }
            loadUI();
            Debug.Log("P1 - Copy Alike excuted");
        } else { Debug.Log("P1 - Copy Alike invalid"); }


    }
    public void copyToFollowingSections()
    {
        Debug.Log("P1 - Copy Following called");
        for (int f = currentFrame + 1; f < numOfFrames; f++)
        {
            for (int i = 0; i < 299; i++)
            {
                show.setValue(f, 2, i, show.getTheValue(f-1, 2, i));
                show.setValue(f, 3, i, show.getTheValue(f-1, 3, i));
                show.setValue(f, 12, i, show.getTheValue(f-1, 12, i));
                show.setValue(f, 11, i, show.getTheValue(f-1, 11, i));
                show.setValue(f, 7, i, show.getTheValue(f-1, 7, i));
                show.setValue(f, 16, i, show.getTheValue(f-1, 16, i));
            }
            for (int i = 0; i < 286; i++)
            {
                show.setValue(f, 1, i, show.getTheValue(f-1, 1, i));
                show.setValue(f, 4, i, show.getTheValue(f-1, 4, i));
                show.setValue(f, 10, i, show.getTheValue(f-1, 10, i));
                show.setValue(f, 13, i, show.getTheValue(f-1, 13, i));
            }
            for (int i = 0; i < 208; i++)
            {
                show.setValue(f, 6, i, show.getTheValue(f-1, 6, i));
                show.setValue(f, 8, i, show.getTheValue(f-1, 8, i));
                show.setValue(f, 15, i, show.getTheValue(f-1, 15, i));
                show.setValue(f, 17, i, show.getTheValue(f-1, 17, i));
                
            }
            for (int i = 0; i < 90; i++)
            {
                show.setValue(f, 19, i, show.getTheValue(f-1, 2, i));
                show.setValue(f, 22, i, show.getTheValue(f-1, 3, i));
                show.setValue(f, 23, i, show.getTheValue(f-1, 12, i));
                show.setValue(f, 26, i, show.getTheValue(f-1, 11, i));
     
            }
            for (int i = 0; i < 207; i++)
            {
                show.setValue(f, 20, i, show.getTheValue(f-1, 2, i));
                show.setValue(f, 21, i, show.getTheValue(f-1, 3, i));
                show.setValue(f, 24, i, show.getTheValue(f-1, 12, i));
                show.setValue(f, 25, i, show.getTheValue(f-1, 11, i));

            }

        }
        Debug.Log("P1 - Copy Following excuted");
    }


}


