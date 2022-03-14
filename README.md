
---


# <p dir="rtl">
فيديوهات الدرس</p>




* 
[المراحل](https://www.youtube.com/watch?v=_ubH-N3L9jA&list=PL_gewShnRvv_n0U2MPdkUsMqsX4_KxYHW&index=20)

---


# <p dir="rtl">
شرح الدرس </p>




* اضافة مكتبة الScene manegment

    ```
  using UnityEngine.SceneManagement;
```


* إضافة دالة loadNextScene()

        ```
void LoadNextScene(){
	int currentSceneIndex = SceneManager.GetActiveScene ().buildIndex;
	int nextSceneIndex = currentSceneIndex + 1;
	if (nextSceneIndex == SceneManager.sceneCountInBuildSettings) {
	    nextSceneIndex = 0;
	}
	SceneManager.LoadScene(nextSceneIndex);
    }
```





* 
اضف دالة **<code>LoadFirstLevel </code></strong>

```
Void LoadFirstLevel(){
SceneManager.LoadScene(0);
}
```



* اضف متغير loadingTime

    ```
int loadingTime = 2;
```




* 
قم بتغيير اللازم داخل دالة  onCollisionEnter()

```
void OnCollisionEnter(Collision collision){
switch (collision.gameObject.tag) {
case "Friendly":
    break;
case "Finish":
    Invoke ("LoadNextScene", loadingTime);
    break;
default:
    Invoke ("LoadFirstLevel", loadingTime);
    break;
}
}
```



---

<strong>[Github](https://github.com/kuwaitcodes/gamedev-c4-cw)</strong>

<p dir="rtl">
<strong>تمرين</strong> </p>




* 
صمم المراحل ٢ و ٣


* 
عند الوصول لنهاية أي مرحلة، يذهب اللاعب إلى المرحلة القادمة


* 
المرحلة تظهر بعد ٣ ثواني من الوصول إلى نقطة الانتهاء 
