# AbstractFactory Pattern - 抽象工廠模式

定義：提供一個建立一系列相關或相互依賴物件的介面，而無需指定他們具體的類別

抽象工廠模式讓建立實體的過程與用戶端分離，用戶端透過他們的抽象介面才操作實體，例子後半段採用簡單工廠來建立抽象介面的實體，
更進一步使用反射加寫設定檔的方式，讓未來新增的類別不需要再去增加簡單工廠的`switch`敘述式，非常的彈性與方便。


# 類別圖

![抽象工廠模式](https://github.com/BryanYu/DesignPatternPractice/blob/master/AbstractFactory/ClassDiagram1.png)


