# TemplateMethod Pattern - 範本方法模式

定義：定義一個操作演算法的框架，將一些步驟交由子類別來實作。範本方法使子類別可以不改變一個演算法的框架結構即可重新定義該演算法的特定步驟。

範本方法透過把不變的行為提升到父類別，去除子類別重複的程式碼，達到程式複用(Reuse)。適合使用在一個系列流程或步驟，而不同情境時某些步驟會有不同的操作方式時，父類別可以提供預設實作，並將方法標示為`Virtual`，繼承的子類別在依照情境決定加入流程或是全部覆寫成自己的方法，或是將方法標示為`abstract`，強制子類別實作。


# 類別圖

![範本方法模式](https://github.com/BryanYu/DesignPatternPractice/blob/master/TemplateMethod/ClassDiagram1.png)


