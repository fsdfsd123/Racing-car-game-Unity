using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class HttpContorller : MonoBehaviour {
    /// <summary>
    /// 统一资源定位符  http://116.255.178.121:8001
    /// </summary>
    private string URL = "http://116.255.178.121:8001";
    /// <summary>
    /// http 请求返回内容
    /// </summary>
    /// <param name="backMessage"></param>
    public delegate void HttpCallBack(string backMessage);
    /// <summary>
    /// 资源请求返回
    /// </summary>
    public HttpCallBack callBack;
   public RawImage llllllllllll;
	void Start () {
        //不删除这个物体
        DontDestroyOnLoad(gameObject);
          StartCoroutine(LoadHttpMessage("https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1505200370&di=5cc9add14918c12137e93a6ad907fb6a&imgtype=jpg&er=1&src=http%3A%2F%2Fimg5.duitang.com%2Fuploads%2Fblog%2F201404%2F14%2F20140414122447_NZtJJ.jpeg", registCallBack));
        regist("poi", "8888icxz88");
    }
	

	void Update () {
	
	}
    /// <summary>
    /// 注册方法
    /// </summary>
    /// <param name="name">用户名</param>                
    /// <param name="psw">密码</param>
    public void regist(string name, string psw)
    {
        //StartCoroutine(LoadHttpMessage(URL + "/regist?name=" + name + "&psw=" + psw, registCallBack));
        StartCoroutine(LoadHttpMessage(URL + "/level", registCallBack));
    }

    private void registCallBack(string backMessage)
    {
        Debug.Log("registCallBack backMessage = " + backMessage);
    }    

    IEnumerator LoadHttpMessage(string url,HttpCallBack back)
    {
        WWW www = new WWW(url);
        float beginTime = Time.deltaTime;
        bool isChaoShi = false;
        while (!www.isDone &&Time.deltaTime - beginTime <1)
        {
            Debug.Log("是否加载完成 = " + www.isDone);
        
            yield return null;
        }
        if (Time.deltaTime - beginTime >= 1)
        {
            isChaoShi = true;
            Debug.Log("连接超时");
            StartCoroutine(LoadHttpMessage(url, back));
        }
        else
        {
            Debug.Log("www.text = " + www.text);
            llllllllllll.texture = www.texture;
            Debug.Log("www.error = " + www.error);
            //停一帧在开始继续
            back(www.text);
        }
     
    } 
}
