# Visitor Pattern - 訪問者模式

定義：表示一個作用於某物件結構中的各元素之操作。它使你可以在不改變各元素之類別的前提下，定義作用於這些元素的新操作。

訪問者模式適用於資料結構相對穩定的系統，他把資料結構和作用於結構上的操作耦合分開，使得操作集合更為簡化。增加新的操作很容易，
因為增加新的操作等於一個新的訪問者。缺點是增加新的資料結構比較困難。


# 類別圖

![訪問者模式](https://github.com/BryanYu/DesignPatternPractice/blob/master/Visitor/ClassDiagram1.png)


