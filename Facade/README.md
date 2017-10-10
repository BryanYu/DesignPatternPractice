# Facade Pattern - 外觀模式

定義：為子系統中的一組介面提供一個一致的介面。此模式定義了一個高層介面，這個介面使得這一子系統更加容易使用。

在三個情況下，適合使用外觀模式

* 設計初期，將不同的層分離
* 開發時期，子系統可能因為不斷的重構而變得複雜，這時候增加`Facade`提供簡單的介面，降低他們之間的依賴。
* 舊有系統可開發`Facade`介面，讓新系統調用。

# 類別圖

![外觀模式](https://github.com/BryanYu/DesignPatternPractice/blob/master/Facade/ClassDiagram1.png)


