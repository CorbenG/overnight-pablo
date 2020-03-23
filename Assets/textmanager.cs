using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class textmanager : MonoBehaviour
{
    public GameObject yourText;
    public GameObject theirText;
    public GameObject canvas;
    private string prevtext = "New Text";
    private string _text;
    public Text nexttext;
    private GameObject currentText;
    int total = 1;

    // Start is called before the first frame update
    void Start()
    {
        ArrayList bublist = new ArrayList();
    }

    // Update is called once per frame
    void Update()
    {
        _text = nexttext.GetComponent<Text>().text;


        if (nexttext.GetComponent<Text>().text != prevtext)
        {
            /*
            GameObject newtext = Instantiate(yourText, new Vector3(100, -200, 0), new Quaternion(0, 0, 0, 0));

            newtext.transform.SetParent(canvas.transform);
            newtext.transform.localPosition = new Vector3(25, -200, 0);
            newtext.transform.localScale = new Vector3(1, 1, 1);
            newtext.GetComponent<UnityEngine.UI.Text>().text = (nexttext.GetComponent<Text>().text);
            newtext.name = "Text " + total;
            for (int j = 1; j <= total; j++)
            {
                currentText = GameObject.Find("Text " + j);
                Vector3 position = currentText.transform.position;
                position.y += 1;
                currentText.transform.position = position;
            }
            total++;
            prevtext = nexttext.GetComponent<Text>().text;
            */
            if (nexttext.GetComponent<Text>().text[0] == '0')
            {
                GameObject newtext = Instantiate(yourText, new Vector3(100, -200, 0), new Quaternion(0, 0, 0, 0));

                newtext.transform.SetParent(canvas.transform);
                newtext.transform.localPosition = new Vector3(25, -200, 0);
                newtext.transform.localScale = new Vector3(1, 1, 1);
                _text = _text.Substring(1);
                print(_text);
                newtext.GetComponent<UnityEngine.UI.Text>().text = (_text);
                prevtext = nexttext.GetComponent<Text>().text;
                newtext.name = "Text " + total;
                for (int j = 1; j <= total; j++)
                {
                    currentText = GameObject.Find("Text " + j);
                    Vector3 position = currentText.transform.position;
                    position.y += 1;
                    currentText.transform.position = position;
                }
                total++;
                prevtext = nexttext.GetComponent<Text>().text;
            }
            if (nexttext.GetComponent<Text>().text[0] == '1')
            {
                GameObject newtext = Instantiate(theirText, new Vector3(100, -200, 0), new Quaternion(0, 0, 0, 0));

                newtext.transform.SetParent(canvas.transform);
                newtext.transform.localPosition = new Vector3(-25, -200, 0);
                newtext.transform.localScale = new Vector3(1, 1, 1);
                _text = _text.Substring(1);
                newtext.GetComponent<UnityEngine.UI.Text>().text = (_text);
                prevtext = nexttext.GetComponent<Text>().text;
                newtext.name = "Text " + total;
                for (int j = 1; j <= total; j++)
                {
                    currentText = GameObject.Find("Text " + j);
                    Vector3 position = currentText.transform.position;
                    position.y += 1;
                    currentText.transform.position = position;
                }
                total++;
                
            }
    }
    /*
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newtext = Instantiate(yourText, new Vector3(100, -200, 0), new Quaternion(0, 0, 0, 0));

            newtext.transform.SetParent(canvas.transform);
            newtext.transform.localPosition = new Vector3(25, -200, 0);
            newtext.transform.localScale = new Vector3(1, 1, 1);
            newtext.GetComponent<UnityEngine.UI.Text>().text = (nexttext.GetComponent<Text>().text);
            newtext.name = "Text " + total;
            for (int j = 1; j <= total; j++)
            {
                currentText = GameObject.Find("Text " + j);
                Vector3 position = currentText.transform.position;
                position.y += 1;
                currentText.transform.position = position;
            }
            total++;

        }

        if (Input.GetMouseButtonDown(1))
        {
            GameObject newtext = Instantiate(theirText, new Vector3(100, -200, 0), new Quaternion(0, 0, 0, 0));

            newtext.transform.SetParent(canvas.transform);
            newtext.transform.localPosition = new Vector3(-25, -200, 0);
            newtext.transform.localScale = new Vector3(1, 1, 1);
            newtext.GetComponent<UnityEngine.UI.Text>().text = (nexttext.GetComponent<Text>().text);
            newtext.name = "Text " + total;
            for (int j = 1; j <= total; j++)
            {
                currentText = GameObject.Find("Text " + j);
                Vector3 position = currentText.transform.position;
                position.y += 1;
                currentText.transform.position = position;
            }
            total++;

        }
        */
    }
}
