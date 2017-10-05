# Prototype Pattern - 原型模式

定義：用原型實例指定建立物件的種類，並透過Clone這些原型建立新的物件，而且不需要知道任何建立的細節。

在.Net中，只要繼承`ICloneable`介面並實作`Clone`方法就可以實作Prototype Pattern了

* [ICloneable](https://msdn.microsoft.com/zh-tw/library/system.icloneable(v=vs.110).aspx/)

淺複製與深複製：
淺複製：淺複製物件時，實值型別(Value Type)會逐項複製到新物件，參考型別(Reference Type)只會複製參考位址。
深複製：深複製物件時，會將參考型別的位址指向複製過的新物件。

# 類別圖

![原型模式](https://github.com/BryanYu/DesignPatternPractice/blob/master/Prototype/ClassDiagram1.png)


