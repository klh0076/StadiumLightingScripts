using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PixelAction : MonoBehaviour
{
    
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() => selected());
    }

    public void selected()
    {
        
        int index = int.Parse(GetComponent<Button>().transform.name);
        SectionPanel.clicked(index);

        
        
    }
}
// set buttons for static buttons on S
/*
   public static Button topBtn;
   public static Button bottomBtn;
   public static Button leftBtn;
   public static Button rightBtn;

   public static Button whiteBtn;
   public static Button blueBtn;
   public static Button orangeButton;

   public static Button clearBtn;
   public static Button SaveFrameBtn;
   public static Button prevFrameBtn;
   public static Button nextBtn;
   public static Button copyToNextBtn;
   public static Button copyToFollowingBtn;
   */
/*
topBtn = Instantiate(topBtnS);
topBtn.transform.SetParent(transform.Find("Panel1"));
topBtn.transform.localPosition = new Vector3(px, py);
topBtn.transform.name = "topBtnS";

px = -473;
py = 41;
bottomBtn = Instantiate(bottomBtnS);
bottomBtn.transform.SetParent(transform.Find("Panel1"));
bottomBtn.transform.localPosition = new Vector3(px, py);
bottomBtn.transform.name = "bottomBtnS";

px = -501;
py = 71;
leftBtn = Instantiate(leftBtnS);
leftBtn.transform.SetParent(transform.Find("Panel1"));
leftBtn.transform.localPosition = new Vector3(px, py);
leftBtn.transform.name = "leftBtnS";

px = -445;
py = 72;
rightBtn = Instantiate(rightBtnS);
rightBtn.transform.SetParent(transform.Find("Panel1"));
rightBtn.transform.localPosition = new Vector3(px, py);
rightBtn.transform.name = "rightBtnS";

px = -534;
py = 140;
whiteBtn = Instantiate(whiteBtnS);
whiteBtn.transform.SetParent(transform.Find("Panel1"));
whiteBtn.transform.localPosition = new Vector3(px, py);
whiteBtn.transform.name = "leftBtnS";

px = -474;
py = 140;
blueBtn = Instantiate(blueBtnS);
blueBtn.transform.SetParent(transform.Find("Panel1"));
blueBtn.transform.localPosition = new Vector3(px, py);
blueBtn.transform.name = "blueBtnS";

px = -412;
py = 140;
orangeButton = Instantiate(orangeButtonS);
orangeButton.transform.SetParent(transform.Find("Panel1"));
orangeButton.transform.localPosition = new Vector3(px, py);
orangeButton.transform.name = "orangeBtnS";

px = -495;
py = -180;
clearBtn = Instantiate(clearBtnS);
clearBtn.transform.SetParent(transform.Find("Panel1"));
clearBtn.transform.localPosition = new Vector3(px, py);
clearBtn.transform.name = "clearBtnS";

px = -492;
py = -145;
SaveFrameBtn = Instantiate(SaveFrameBtnS);
SaveFrameBtn.transform.SetParent(transform.Find("Panel1"));
SaveFrameBtn.transform.localPosition = new Vector3(px, py);
SaveFrameBtn.transform.name = "SaveFrameBtnS";

px = -526;
py = -63;
prevFrameBtn = Instantiate(prevFrameBtnS);
prevFrameBtn.transform.SetParent(transform.Find("Panel1"));
prevFrameBtn.transform.localPosition = new Vector3(px, py);
prevFrameBtn.transform.name = "prevFrameBtnS";

px = -446;
py = -63;
nextBtn = Instantiate(nextBtnS);
nextBtn.transform.SetParent(transform.Find("Panel1"));
nextBtn.transform.localPosition = new Vector3(px, py);
nextBtn.transform.name = "nextBtnS";

px = -307;
py = -130;
copyToNextBtn = Instantiate(copyToNextBtnS);
copyToNextBtn.transform.SetParent(transform.Find("Panel1"));
copyToNextBtn.transform.localPosition = new Vector3(px, py);
copyToNextBtn.transform.name = "copyToNextBtnS";

px = -307;
py = -165;
copyToFollowingBtn = Instantiate(copyToFollowingBtnS);
copyToFollowingBtn.transform.SetParent(transform.Find("Panel1"));
copyToFollowingBtn.transform.localPosition = new Vector3(px, py);
copyToFollowingBtn.transform.name = "copyToFollowingBtnS";



topBtn.GetComponent<Image>().color = blackR;
bottomBtn.GetComponent<Image>().color = blackR;
leftBtn.GetComponent<Image>().color = blackR;
rightBtn.GetComponent<Image>().color = blackR;
*/