# TemplateMethod Pattern - 範本方法模式

定義：定義一個操作演算法的框架，將一些步驟交由子類別來實作。範本方法使子類別可以不改變一個演算法的框架結構即可重新定義該演算法的特定步驟。

範本方法透過把不變的行為提升到父類別，去除子類別重複的程式碼，達到程式複用(Reuse)。適合使用在一個系列流程或步驟，而不同情境時某些步驟會有不同的操作方式

# 類別圖

![範本方法模式](https://github.com/BryanYu/DesignPatternPractice/blob/master/TemplateMethod/ClassDiagram1.png)


