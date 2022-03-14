
# <p dir="rtl">
فيديوهات الدرس</p>




* 
[المؤثرات البصرية](https://www.youtube.com/watch?v=H_soQavwCWY&list=PL_gewShnRvv_n0U2MPdkUsMqsX4_KxYHW&index=21)

---


# <p dir="rtl">
شرح الدرس </p>




* اضف serializedField من نوع gameObject و متغير من نوع bool 

    ```
[SerializeField] GameObject winningFX;
bool isControlEnabled = true;
```


* قم بإضافة اللازم ب case "Finish  

        ```
 case "Finish":
    winningFX.SetActive(true);
    isControlEnabled = false;
```


* قم بإضافة اللازم ب case "default 

        ```
default:
isControlEnabled = false;
```




---

**[Github](https://github.com/kuwaitcodes/gamedev-c4-cw)**

<p dir="rtl">
<strong>تمرين</strong> </p>




* 
أضف تأثير بصري للفوز - يظهر عندما يصل الاعب إلى منطقة الانتهاء


* 
أضف تأثير بصري للخسارة - يظهر عندما يصطدم اللاعب بالمعوقات
<p dir="rtl">
<strong>Bonus</strong></p>


<p dir="rtl">
لنقم بإستخدام متجر Unity Assets Store ونبحث عن صاروخ ونضعه بدل من الشكل الأولي الذي قمنا بصنعه</p>

